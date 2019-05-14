using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Addcategory : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IDASurat"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            divSuccess.Visible = false;
            divError.Visible = false;
            BindData();
        }
    }
    private void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from Category");
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
        catch { }
    }
    public void Clear()
    {
        txtName.Text = "";

    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        string qry = "insert into Category(Category) values('" + txtName.Text + "')";
        D.ExecuteQuery(qry);

        BindData();

        Clear();
        divSuccess.Visible = true;
        divError.Visible = false;

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);
        string qry = "";
        qry = "Update Category set Category='" + txtName.Text + "' where ID=" + lbSubmit.CommandArgument;
        D.ExecuteQuery(qry);

        BindData();

        divSuccess.Visible = true;
        divError.Visible = false;
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;
        Clear();
    }
  
    protected void lbEdit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupProduct()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from Category where ID=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;


            lbSubmit.CommandArgument = dt.Rows[0]["ID"].ToString();
            txtName.Text = dt.Rows[0]["Category"].ToString();

            BindData();
        }
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from Category where ID=" + id);

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
    protected void IbCancel_Click1(object sender, EventArgs e)
    {
        Clear();
        lbSubmit.Visible = true;
        lbUpdate.Visible = false;
    }
}