using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ViewAdminInquiry : System.Web.UI.Page
{
    Connection D = new Connection();
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["AdminId"];

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

        try
        {
            string qry = "";

            if (ddlcourse.SelectedValue != "" && ddlcourse.SelectedValue != "0")
            {
                qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Course c,Reference r where  im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id  and  im.CourseId='" + ddlcourse.SelectedValue + "' order by id desc";
            }
            else
            {
                qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Course c,Reference r where  im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id  order by id desc";
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


}