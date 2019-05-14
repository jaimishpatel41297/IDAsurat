using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_AddAttendance : System.Web.UI.Page
{
    Connection D = new Connection();
    string cookie = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["UserId"].Value;

        if (!IsPostBack)
        {
            //if (Request.Cookies["ID"] == null)
            if (cookie == "")
            {
                Response.Redirect("Default.aspx");
            }

            BindTeacher();
            BindCourse();
        }
    }
    public void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from InquiryMaster where Status=1 and CourseId= '" + ddlcourse.SelectedValue + "'");
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
        DataTable dt1 = D.GetDataTable("select distinct(Batch) from [dbo].[CourseMaster]");
        if (dt1.Rows.Count > 0)
        {
            ddlbranch.DataTextField = "Batch";
            ddlbranch.DataValueField = "Batch";
            ddlbranch.DataSource = dt1;
            ddlbranch.DataBind();
            ddlbranch.Items.Insert(0, new ListItem("Select Batch", "0"));
        }
    }

    private void BindTeacher()
    {
        cookie = Request.Cookies["UserId"].Value;
        //string id = cookie.Value.ToString();
        try
        {
            DataTable dt1 = D.GetDataTable("SELECT ID FROM Category WHERE Category='Teacher' OR Category='teacher';");
            string IDR = dt1.Rows[0]["ID"].ToString();
            DataTable dt = D.GetDataTable("select * from EmployeeMaster where Category='"+ IDR +"' and Id='" + cookie + "'");
            if (dt.Rows.Count > 0)
            {
                ddlfaculty.DataTextField = "Name";
                ddlfaculty.DataValueField = "ID";
                ddlfaculty.DataSource = dt;
                ddlfaculty.DataBind();
                //ddlfaculty.Items.Insert(0, new ListItem("Select Teacher", "0"));
            }
        }
        catch(Exception e1)
        {

        }
    }

    protected void chkAll_CheckedChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow gvrow in gv.Rows)
        {

            CheckBox checkbox = gvrow.FindControl("chkAttendance") as CheckBox;

            if (checkbox.Checked == true)
            {
                checkbox.Checked = false;
            }
            else
            {
                checkbox.Checked = true;
            }
        }
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            string CourseId = ddlcourse.SelectedValue;
            string FacultyId = ddlfaculty.SelectedValue;

            if (CourseId != "0" && FacultyId != "0" && CourseId != "" && FacultyId != "")
            {
                foreach (GridViewRow gvRow in gv.Rows)
                {
                    string flag = "";
                    int Sid = Convert.ToInt32(((Label)(gvRow.FindControl("lblnameId"))).Text);
                    CheckBox chkAtt = (CheckBox)gvRow.FindControl("chkAttendance");
                    if (chkAtt.Checked)
                    {
                        flag = "P";
                    }
                    else
                    {
                        flag = "A";
                    }

                    string qry = "insert into Attendance (Course,Student,Attendance,Date,Faculty,Batch) values('" + CourseId + "','" + Sid + "','" + flag + "','" + txtdate.Text + "','" + FacultyId + "','" + ddlbranch .SelectedValue+ "')";
                    D.ExecuteQuery(qry);
                }

                divSuccess.Visible = true;
                divError.Visible = false;
            }
            else
            {
                divError.Visible = true;
            }
        }
        catch (Exception ex)
        {

        }

    }
    protected void IbCancel_Click(object sender, EventArgs e)
    {
        try
        {

            string CourseId = ddlcourse.SelectedValue;
            string FacultyId = ddlfaculty.SelectedValue;
            foreach (GridViewRow gvRow in gv.Rows)
            {

                int Sid = Convert.ToInt32(((Label)(gvRow.FindControl("lblnameId"))).Text);
                CheckBox chkAtt = (CheckBox)gvRow.FindControl("chkAttendance");

                //D.ExecuteQuery("delete from Attendance where Course='" + CourseId + "' and Student='" + Sid + "' and Faculty='" + FacultyId + "' and Date='" + System.DateTime.Now.ToString("dd-MM-yyyy") + "'");
                D.ExecuteQuery("delete from Attendance where Course='" + CourseId + "' and Student='" + Sid + "' and Faculty='" + FacultyId + "' and Date='" + txtdate.Text + "'");
            }
            divSuccess.Visible = true;
            divError.Visible = false;
        }
        catch (Exception ex1)
        {

        }
    }
    protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}