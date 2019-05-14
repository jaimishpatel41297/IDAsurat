using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_AssignCourse : System.Web.UI.Page
{
    Connection D = new Connection();
    string cookie = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            cookie = Request.Cookies["AdminId"].Value;
            if (cookie == "")
            {
                Response.Redirect("Default.aspx");
            }

            BindTeacher();
            BindCourse();
            BindData();
        }
    }

    public void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select t.*,c.Title as CourseName,em.Name as TeacherName from TeacherList as t,Course c, EmployeeMaster em where t.Facultyid=em.id and t.Courseid=c.Id");
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
        catch
        {
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

    private void BindTeacher()
    {
        try
        {
            //DataTable dt = D.GetDataTable("select * from EmployeeMaster where Category=19 ");
            DataTable dt1 = D.GetDataTable("SELECT ID FROM Category WHERE Category='Teacher' OR Category='teacher';");
            string IDR = dt1.Rows[0]["ID"].ToString();
            DataTable dt = D.GetDataTable("select * from EmployeeMaster where Category ='" + IDR + "'");
            if (dt.Rows.Count > 0)
            {
                ddlfaculty.DataTextField = "Name";
                ddlfaculty.DataValueField = "ID";
                ddlfaculty.DataSource = dt;
                ddlfaculty.DataBind();
                ddlfaculty.Items.Insert(0, new ListItem("Select Teacher", "0"));

            }
        }
        catch (Exception e1)
        {

        }
    }
    public void Clear()
    {
        txtsub.Text = "";
        txtchap.Text = "";
        readi.Checked = false;
        writei.Checked = false;
        alli.Checked = false;
        ddlcourse.SelectedValue = "0";
        ddlfaculty.SelectedValue = "0";
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        int st = 1;
        int st1 = 0;
        try
        {
            if (alli.Checked == true)
            {
                string qry = "insert into Teacherlist(FacultyId,CourseId,Subject,Chapter,Readcourse,Writecourse,Allcourse) values('" + ddlfaculty.SelectedValue + "','" + ddlcourse.SelectedValue + "','" + txtsub.Text + "','" + txtchap.Text + "','" + st + "','" + st + "','" + st + "')";
                D.ExecuteQuery(qry);
            }
            else if (writei.Checked == true)
            {
                string qry = "insert into Teacherlist(FacultyId,CourseId,Subject,Chapter,Readcourse,Writecourse,Allcourse) values('" + ddlfaculty.SelectedValue + "','" + ddlcourse.SelectedValue + "','" + txtsub.Text + "','" + txtchap.Text + "','" + st1 + "','" + st + "','" + st1 + "')";
                D.ExecuteQuery(qry);
            }
            else if (readi.Checked == true)
            {
                string qry = "insert into Teacherlist(FacultyId,CourseId,Subject,Chapter,Readcourse,Writecourse,Allcourse) values('" + ddlfaculty.SelectedValue + "','" + ddlcourse.SelectedValue + "','" + txtsub.Text + "','" + txtchap.Text + "','" + st + "','" + st1 + "','" + st1 + "')";
                D.ExecuteQuery(qry);
            }
            BindData();
            Clear();
            divSuccess.Visible = true;
            divError.Visible = false;
        }
        catch (Exception e11)
        {
            divSuccess.Visible = false;
            divError.Visible = true;
        }
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        string qry = "";
        int st = 1;
        int st1 = 0;
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);
        try
        {
            if (alli.Checked == true)
            {
                qry = "Update Teacherlist set FacultyId='" + ddlfaculty.SelectedValue + "',CourseId='" + ddlcourse.SelectedValue + "',Subject='" + txtsub.Text + "',Chapter='" + txtchap.Text + "',Readcourse='" + st + "',Writecourse='" + st + "',Allcourse='" + st + "' where Id=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (writei.Checked == true)
            {
                qry = "Update Teacherlist set FacultyId='" + ddlfaculty.SelectedValue + "',CourseId='" + ddlcourse.SelectedValue + "',Subject='" + txtsub.Text + "',Chapter='" + txtchap.Text + "',Readcourse='" + st1 + "',Writecourse='" + st + "',Allcourse='" + st1 + "' where Id=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (readi.Checked == true)
            {
                qry = "Update Teacherlist set FacultyId='" + ddlfaculty.SelectedValue + "',CourseId='" + ddlcourse.SelectedValue + "',Subject='" + txtsub.Text + "',Chapter='" + txtchap.Text + "',Readcourse='" + st + "',Writecourse='" + st1 + "',Allcourse='" + st1 + "' where Id=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }

            BindData();

            divSuccess.Visible = true;
            divError.Visible = false;
            lbUpdate.Visible = false;
            lbSubmit.Visible = true;
            Clear();
        }
        catch (Exception e33)
        {

        }
    }
    protected void lbEdit_Click(object sender, EventArgs e)
    {

        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from Teacherlist where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;


            lbSubmit.CommandArgument = dt.Rows[0]["ID"].ToString();
            ddlfaculty.SelectedValue = dt.Rows[0]["FacultyId"].ToString();
            ddlcourse.SelectedValue = dt.Rows[0]["CourseId"].ToString();
            txtsub.Text = dt.Rows[0]["Subject"].ToString();
            txtchap.Text = dt.Rows[0]["Chapter"].ToString();
            string a1 = dt.Rows[0]["Readcourse"].ToString();
            string a2 = dt.Rows[0]["Writecourse"].ToString();
            string a3 = dt.Rows[0]["Allcourse"].ToString();
            if (a3 == "True")
            {
                readi.Checked = true;
                writei.Checked = true;
                alli.Checked = true;

            }
            else if (a2 == "True")
            {
                readi.Checked = false;
                writei.Checked = true;
                alli.Checked = false;

            }
            else if (a1 == "True")
            {
                readi.Checked = true;
                writei.Checked = false;
                alli.Checked = false;

            }
            //BindData();
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

            BindData();

        }
        catch (Exception ex)
        {
            divError.Visible = true;
            divSuccess.Visible = false;

        }
    }
    protected void Ibcancel_Click(object sender, EventArgs e)
    {
        Clear();
        lbSubmit.Visible = true;
        lbUpdate.Visible = false;
    }
    protected void alli_CheckedChanged(object sender, EventArgs e)
    {
        if (alli.Checked == true)
        {
            readi.Checked = true;
            writei.Checked = true;
        }
        else
        {
            readi.Checked = false;
            writei.Checked = false;
        }

    }
}