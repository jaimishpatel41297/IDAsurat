using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Admin_Default : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindcategory();
        }
    }

    private void Bindcategory()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from Category");
           if (dt.Rows.Count > 0)
                {
                    ddlcat.DataTextField = "Category";
                    ddlcat.DataValueField = "ID";
                    ddlcat.DataSource = dt;
                    ddlcat.DataBind();
                }
           ddlcat.Items.Insert(0, new ListItem("Category", "0"));
           
        }
        catch(Exception e)
        {

        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (ddlUser.SelectedValue == "Admin")
        {

            DataTable dt = D.GetDataTable("select * from SF_ADMIN_MASTER where USERNAME='" + txtUserName.Text.ToString() + "' and PASSWORD='" + txtPassword.Text.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                Response.Cookies["AdminId"].Value = "0";
                Session["AdminId"] = "0";
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                txtPassword.Text = "";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Suceess", "alert('Wrong Username or Password');", true);
            }
        }
        else if (ddlUser.SelectedValue == "User")
        {
            DataTable dt = D.GetDataTable("select * from EmployeeMaster where Username='" + txtUserName.Text.ToString() + "' and Password='" + txtPassword.Text.ToString() + "' and Category=" + ddlcat.SelectedValue);
            //DataTable dt = D.GetDataTable("select * from OperatorMaster where USERNAME='" + txtUserName.Text.ToString() + "' and PASSWORD='" + txtPassword.Text.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                Response.Cookies["Username"].Value = txtUserName.Text.ToString();
                Response.Cookies["UserId"].Value = dt.Rows[0]["Id"].ToString();
                Session["UserId"] = dt.Rows[0]["Id"].ToString();
                Response.Redirect("OperatorDashboard.aspx");
            }
            else
            {
                txtPassword.Text = "";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Suceess", "alert('Wrong Username or Password');", true);
            }
        }
    }
}