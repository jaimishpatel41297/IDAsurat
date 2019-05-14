using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ViewAdminMissed : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
              BindDDL();
            }
        }

private void BindDDL()
{
 	 try
        {
            DataTable dt = D.GetDataTable("select * from Course");
            if (dt.Rows.Count > 0)
            {
                ddlcourse.DataTextField = "Title";
                ddlcourse.DataValueField = "Id";
                ddlcourse.DataSource = dt;
                ddlcourse.DataBind();
                ddlcourse.Items.Insert(0, new ListItem("Select Course", "0"));
            }

        }
        catch (Exception ex)
        {
        }
}

private void BindData()
{
    
    try
    {
        string qry = "";

        if (ddlcourse.SelectedValue != "")
        {
            qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im,Course c, CourseMaster cm,Reference r where im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id and Status= 0 and im.CourseId='" + ddlcourse.SelectedValue + "' ";
        }
        else
        {
            qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im,Course c, CourseMaster cm,Reference r where im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id and Status= 0";
        }
        DataTable dt = D.GetDataTable(qry);
        if (dt.Rows.Count > 0)
        {
            gv.DataSource = dt;
            gv.DataBind();

        }
        else
        {
            dt = null;
            gv.DataSource = dt;
            gv.DataBind();
        }
    }
    catch (Exception ex)
    {

    }
}
    
    protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);

        try
        {
            D.ExecuteQuery("Delete from InquiryMaster where id=" + ids);

            BindData();
        }
        catch (Exception ex)
        {

        }
    }
}