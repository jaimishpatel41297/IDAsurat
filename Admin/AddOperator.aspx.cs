using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddOperator : System.Web.UI.Page
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
            DataTable dt = D.GetDataTable("select * from OperatorMaster");
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
            string qry = "insert into OperatorMaster (Name,MobileNo,UserName,Password) values('" + txtName.Text + "','" + txtno.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "')";

            D.ExecuteQuery(qry);

            BindData();

            divSuccess.Visible = true;
            divError.Visible = false;
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
            D.ExecuteQuery("delete from OperatorMaster where Id=" + id);

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
}