using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
public partial class Registration : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlcategory();
            ddllState();
        }
    }

    private void ddllState()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from State");
            if (dt.Rows.Count > 0)
            {
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateId";
                ddlState.DataSource = dt;
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("select State", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }

    private void ddlcategory()
    {
        try
        {
            DataTable dt = D.GetDataTable("select DISTINCT(Type)  from Course");
            if (dt.Rows.Count > 0)
            {
                ddlCourseCat.DataTextField = "Type";
                ddlCourseCat.DataValueField = "Type";
                ddlCourseCat.DataSource = dt;
                ddlCourseCat.DataBind();
                ddlCourseCat.Items.Insert(0, new ListItem("Course Category", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string sta = ddlState.SelectedValue.ToString();
            DataTable dt = D.GetDataTable("select * from City where StateId='"+ sta +"'");
            if (dt.Rows.Count > 0)
            {
                ddlcity.DataTextField = "CityName";
                ddlcity.DataValueField = "CityId";
                ddlcity.DataSource = dt;
                ddlcity.DataBind();
                ddlcity.Items.Insert(0, new ListItem("select City", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void ddlCourseCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string cat = ddlCourseCat.SelectedValue.ToString();
            DataTable dt = D.GetDataTable("select * from Course where Type='" + cat + "'");
            if (dt.Rows.Count > 0)
            {
                ddlCourse.DataTextField = "Title";
                ddlCourse.DataValueField = "Title";
                ddlCourse.DataSource = dt;
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new ListItem("select Course", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }
    protected void IbSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string qryregistration = string.Format("insert into OnlineRegistration(Name,Surname,Fathername,Dob,Mobile,Email,Academic,Marital,Gender,Bloodgroup,Nationality,Address,State,City,District,Pincode,Category,Course,Remarks,Status) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}')"
                , txtName.Text, txtSurname.Text, txtfname.Text, txtdob.Text, txtmobile.Text, txtemail.Text, ddlaca.SelectedValue, txtmar.Text, rbGender.SelectedValue, ddlBlood.SelectedValue, ddlNationality.SelectedValue, txtadd.Text, ddlState.SelectedValue, ddlcity.SelectedValue, txtdisct.Text, txtpin.Text, ddlCourseCat.SelectedValue, ddlCourse.SelectedValue, txtremark.Text,0);
            D.ExecuteQuery(qryregistration);  

            contactSuccess.Visible = true;
            contactError.Visible = false;

            Clear();
        }
        catch (Exception ex)
        {
            contactSuccess.Visible = false;
            contactError.Visible = true;
        }
    }

    private void Clear()
    {
        txtName.Text = "";
        txtSurname.Text = "";
        txtfname.Text = "";
        txtdob.Text = "";
        txtmobile.Text = "";
        txtemail.Text = "";
        ddlaca.SelectedValue = "Select Academic Level";
        txtmar.Text = "";
        rbGender.SelectedValue = "";
        ddlBlood.SelectedValue = "Select Blood Group";
        ddlNationality.SelectedValue = "Select Nation";
        ddlCourseCat.SelectedIndex = 0;
        txtpin.Text = "";
        ddlCourse.SelectedIndex = 0;
        txtremark.Text = "";
        txtadd.Text = "";
        txtdisct.Text = "";
        ddlState.SelectedIndex = 0;
        ddlcity.SelectedIndex = 0;
    

    }
}