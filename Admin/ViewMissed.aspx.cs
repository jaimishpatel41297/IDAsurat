using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ViewFollowup : System.Web.UI.Page
{
    Connection D = new Connection();
    HttpCookie cookie;

    protected void Page_Load(object sender, EventArgs e)
    {

        cookie = Request.Cookies["UserId"];

        if (!IsPostBack)
        {
            if (cookie != null)
            {
                BindData();
                BindDDL();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
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
        string id = cookie.Value.ToString();
        try
        {
            string qry = "";

            if (ddlcourse.SelectedValue != "")
            {
                qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im,Course c,CourseMaster cm,Reference r where im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id and Status= 0 and im.CourseId='" + ddlcourse.SelectedValue + "' and UserId='" + id + "'";
            }
            else
            {
                qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Course c,Reference r where im.CourseId=c.Id and  im.CourseId=cm.Courseid and im.Refid=r.Id and Status= 0 and UserId='" + id + "'";
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