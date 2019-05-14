using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddBranch : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from BranchMaster");
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

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string qry = "insert into BranchMaster(Name) values('" + txtName.Text + "')";

            D.ExecuteQuery(qry);

            BindData();

            divSuccess.Visible = true;
            divError.Visible = false;

            Clear();
        }
        catch (Exception ex)
        {
            divSuccess.Visible = false;
            divError.Visible = true;
        }
    }

    protected void lbDelete_Click(object Sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)Sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from BranchMaster where Id=" + id);

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

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument);
            DataTable dt = D.GetData("select * from BranchMaster where Id=" + lb.CommandArgument);
            if (dt.Rows.Count > 0)
            {

                lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

                txtName.Text = dt.Rows[0]["Name"].ToString();
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            string qry = "Update BranchMaster set Name='" + txtName.Text + "' where Id='" + lbSubmit.CommandArgument + "'";

            D.ExecuteQuery(qry);

            BindData();

            divSuccess.Visible = true;
            divError.Visible = false;
            lbUpdate.Visible = false;
            lbSubmit.Visible = true;

            Clear();
        }

        catch (Exception ex)
        {

        }
    }

    public void Clear()
    {
        txtName.Text = "";
    }
}