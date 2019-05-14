using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddCourse : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            Bindddl();
        }
    }

    private void Bindddl()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from Course");
            if (dt.Rows.Count > 0)
            {
                ddlcour.DataTextField = "Title";
                ddlcour.DataValueField = "Id";
                ddlcour.DataSource = dt;
                ddlcour.DataBind();
                ddlcour.Items.Insert(0, new ListItem("select course", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }
    private void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select cm.*,c.Title as Coursename from CourseMaster cm,Course c where cm.Courseid=c.Id");
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
            string qry = "insert into CourseMaster(Courseid,Batch,Amount) values('" + ddlcour.SelectedValue + "','" + txtbatch.Text + "','" + txtAmount.Text + "')";

            D.ExecuteQuery(qry);

            BindData();
            Clear();
            divSuccess.Visible = true;
            divError.Visible = false;
        }
        catch (Exception ex)
        {
            divSuccess.Visible = false;
            divError.Visible = true;
        }
    }

    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            string qry = "Update CourseMaster set Courseid='" + ddlcour.SelectedValue + "',Batch='" + txtbatch.Text + "',Amount='" + txtAmount.Text + "' where Id='" + lbSubmit.CommandArgument + "'";

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

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument);
            DataTable dt = D.GetData("select * from CourseMaster where Id=" + lb.CommandArgument);
            if (dt.Rows.Count > 0)
            {

                lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

                ddlcour.SelectedValue = dt.Rows[0]["Courseid"].ToString();
                txtbatch.Text = dt.Rows[0]["Batch"].ToString();
                txtAmount.Text = dt.Rows[0]["Amount"].ToString();
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbDelete_Click(object Sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)Sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from CourseMaster where Id=" + id);

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

    public void Clear()
    {
        txtbatch.Text = "";
        ddlcour.SelectedValue = "0";
        txtAmount.Text = "";
    }
    protected void IbCancel_Click(object sender, EventArgs e)
    {
        Clear();
        lbSubmit.Visible = true;
        lbUpdate.Visible = false;
    }
}