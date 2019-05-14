using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddDuration : System.Web.UI.Page
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
            DataTable dt = D.GetDataTable("select * from DurationMaster");
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
            string qry = "insert into DurationMaster(Duration,Number) values('" + txtduration.Text + "','"+ txtno.Text + "')";

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
            D.ExecuteQuery("delete from DurationMaster where Id=" + id);

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
            DataTable dt = D.GetData("select * from DurationMaster where Id=" + lb.CommandArgument);
            if (dt.Rows.Count > 0)
            {

                lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

                txtduration.Text = dt.Rows[0]["Duration"].ToString();
                txtno.Text = dt.Rows[0]["Number"].ToString();
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
            string qry = "Update DurationMaster set Duration='" + txtduration.Text + "',Number='"+ txtno.Text + "' where Id='" + lbSubmit.CommandArgument + "'";

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
        txtduration.Text = "";
        txtno.Text = "";
    }
}