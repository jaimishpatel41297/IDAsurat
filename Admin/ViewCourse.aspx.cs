using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_ViewCourse : System.Web.UI.Page
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
                BindCourse();

            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }
    }

    private void BindCourse()
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

    private void BindData()
    {
        string id = cookie.Value.ToString();
        try
        {
            DataTable dt = D.GetDataTable("select t.*,c.Title as CourseName,em.Name as TeacherName from TeacherList as t,Course c, EmployeeMaster em where t.Facultyid=em.id and t.Courseid=c.id and FacultyId='" + id + "'");
            if (dt.Rows.Count > 0)
            {
                gv.DataSource = dt;
                gv.DataBind();
                string a1 = dt.Rows[0]["Readcourse"].ToString();
                string a2 = dt.Rows[0]["Writecourse"].ToString();
                string a3 = dt.Rows[0]["Allcourse"].ToString();

            }
            else
            {
                dt = null;
                gv.DataSource = dt;
                gv.DataBind();
            }
        }
        catch
        {
        }

    }

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupUser()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        //lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from Teacherlist where Id=" + lb.CommandArgument);
        try
        {
            if (dt.Rows.Count > 0)
            {

                //lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                Ibeditcancel.Visible = true;

                lbUpdate.CommandArgument = dt.Rows[0]["ID"].ToString();


                txtsub.Text = dt.Rows[0]["Subject"].ToString();
                txtchap.Text = dt.Rows[0]["Chapter"].ToString();
                ddlcourse.Text = dt.Rows[0]["CourseId"].ToString();


            }

        }
        catch (Exception e33)
        {
        }

    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from Teacherlist where Id=" + id);

            divSuccess.Visible = true;
            divError.Visible = false;

            Clear();

            BindData();
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            divSuccess.Visible = false;
        }
    }

    private void Clear()
    {
        txtsub.Text = "";
        txtchap.Text = "";
        ddlcourse.SelectedValue = "0";
    }

    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        string qry = "";


        qry = "Update Teacherlist set CourseId='" + ddlcourse.SelectedIndex + "',Subject='" + txtsub.Text + "',Chapter='" + txtchap.Text + "' where Id=" + lbUpdate.CommandArgument;
        D.ExecuteQuery(qry);

        BindData();

        divSuccess.Visible = true;
        divError.Visible = false;

        Ibeditcancel.Visible = false;
        lbUpdate.Visible = false;

        Clear();
    }
    protected void Ibeditcancel_Click1(object sender, EventArgs e)
    {

    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void gv_DataBound(object sender, EventArgs e)
    {

    }
    int indexOfColumn = 1;
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        string id = cookie.Value.ToString();
        try
        {
            DataTable dt = D.GetDataTable("select t.*,c.Title as CourseName,em.Name as TeacherName from TeacherList as t,Course c, EmployeeMaster em where t.Facultyid=em.id and t.Courseid=c.id and FacultyId='" + id + "'");
            if (dt.Rows.Count > 0)
            {

                string a1 = dt.Rows[0]["Readcourse"].ToString();
                string a2 = dt.Rows[0]["Writecourse"].ToString();
                string a3 = dt.Rows[0]["Allcourse"].ToString();

                if (a1 == "True")
                {
                    if (e.Row.Cells.Count > indexOfColumn)
                    {
                        e.Row.Cells[4].Visible = false;
                    }
                }
            }
        }
        catch (Exception e33)
        {

        }
    }
}