using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ViewAdminAttendance : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
                Bindstudent();
                BindCourse();
           
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

    private void Bindstudent()
    {
        DataTable dt = D.GetDataTable("select * from InquiryMaster where Status=1");
        if (dt.Rows.Count > 0)
        {
            ddlstd.DataTextField = "Name";
            ddlstd.DataValueField = "Id";
            ddlstd.DataSource = dt;
            ddlstd.DataBind();
            ddlstd.Items.Insert(0, new ListItem("Select Student", "0"));
        }
    }
    protected void IbView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewAdminattendancegraph.aspx");
    }
    protected void IbSearch_Click(object sender, EventArgs e)
    {
        string c = txtdate.Text;
        string c1 = ddlcourse.SelectedValue;
        string c3 = ddlstd.SelectedValue;
        string qry = "";
        try
        {
            if (c != "" && c1 != "0" && c3 != "0")
            {

                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Course='" + c1 + "' and a.Date='" + c + "' and a.Student='" + c3 + "' order by ID desc";
            }
            else if (c != "" && c1 != "0")
            {
                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Course='" + c1 + "' and a.Date='" + c + "' order by ID desc";
            }
            else if (c != "" && c3 != "0")
            {
                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Date='" + c + "' and a.Student='" + c3 + "' order by ID desc";
            }
            else if (c1 != "0" && c3 != "0")
            {
                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Course='" + c1 + "' and  a.Student='" + c3 + "' order by ID desc";
            }
            else if (c != "")
            {
                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Date='" + c + "'  order by ID desc";

            }
            else if (c1 != "0")
            {
                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Course='" + c1 + "' order by ID desc";

            }
            else if (c3 != "0")
            {
                qry = "select a.*,c.Title as CourseName,t.Name as TeacherName,s.Name as StudentName from Attendance as a,[EmployeeMaster] as t,Course c,InquiryMaster as s where a.Course=c.Id and a.Faculty=t.Id and a.Student=s.Id and a.Student='" + c3 + "' order by ID desc";

            }


            DataTable dt = D.GetData(qry);
            if (dt.Rows.Count > 0)
            {
                gv.DataSource = dt;
                gv.DataBind();
                foreach (GridViewRow row in gv.Rows)
                {
                    Label l = (Label)row.FindControl("lblatt");
                    string s = l.Text;
                    if (s == "A")
                    {
                        row.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        row.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                dt = null;
                gv.DataSource = dt;
                gv.DataBind();
            }
        }
        catch (Exception e12)
        {

        }
    }
}