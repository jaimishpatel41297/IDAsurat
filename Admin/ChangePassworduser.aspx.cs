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

public partial class Admin_ChangePassworduser : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IDASurat"].ToString());
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["UserId"];
        if (!IsPostBack)
        {
        }
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["UserId"] != null)
        {

            if (txtnewpass.Text.ToString() == txtconfirm.Text.ToString())
            {
                string id = cookie.Value.ToString();
                string qry = "select * from EmployeeMaster where Password = '" + txtoldpass.Text + "' and Id='" + id + "'";
                DataTable dt = D.GetData(qry);
                if (dt.Rows.Count != 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@PASS", txtnewpass.Text.ToString());
                    
                    cmd.Connection = cn;
                    cmd.CommandText = "update EmployeeMaster set Password = @PASS";
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    txtoldpass.Text = "";
                    txtnewpass.Text = "";
                    txtconfirm.Text = "";
                    divSuccess.Visible = true;
                    divError.Visible = false;
                    divfail.Visible = false;
                }
                else
                {
                    divSuccess.Visible = false;
                    divError.Visible = false;
                    divfail.Visible = true;
                }
            }
            else
            {
                divSuccess.Visible = false;
                divError.Visible = true;
                divfail.Visible = false;
            }
        }
    }
}