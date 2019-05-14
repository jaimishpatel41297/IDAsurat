using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Admin_CustomerSms : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IDASurat"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //BindData();
        }
    }

    private void BindData()
    {
       
        string qry = "select im.*,c.Title as CName from InquiryMaster im, Course c where im.CourseId=c.Id and Status=0  order by id desc";

        DataTable dt = D.GetDataTable(qry);
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
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        SendSms sms = new SendSms();

        SqlCommand cmd = new SqlCommand();
        string mno = "";


        foreach (GridViewRow gvrow in gv.Rows)
        {
            HiddenField theHiddenField = gvrow.FindControl("HiddenFieldId") as HiddenField;

            String qid = theHiddenField.Value;

            var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
            if (checkbox.Checked)
            {

                //string Name = gv.Rows[gvrow.RowIndex].Cells[3].Text;
                string MobileNo = gv.Rows[gvrow.RowIndex].Cells[4].Text;

                mno += "91" + MobileNo;
                string msg = txtmsg.Text;
                //qrys = "insert into SmsMaster(Name,MobileNo,Message)values('" + Name + "','" + MobileNo + "','" + txtmsg.Text + "')";
                //cmd.Connection = cn;
                //cmd.CommandText = qrys;
                //cn.Open();
                //cmd.ExecuteNonQuery();
                //cn.Close();
                sms.sendotp(msg, mno);
                BindData();

            }

        }


        Clear();
    }
    private void Clear()
    {
        txtmsg.Text = "";

    }
    protected void AllCheckBox_CheckedChanged(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand();

        foreach (GridViewRow gvrow in gv.Rows)
        {

            CheckBox checkbox = gvrow.FindControl("CheckBox1") as CheckBox;

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
    protected void ddltype_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddltype.SelectedValue == "Inquiry Detail")
            {
                BindData();
            }
            else if (ddltype.SelectedValue == "Student Detail")
            {
                BindData1();
            }
        }
        catch (Exception e123)
        {

        }
    }

    private void BindData1()
    {
        string qry = "select im.*,c.Title as CName from InquiryMaster im, Course c where im.CourseId=c.Id and Status=1  order by id desc";

        DataTable dt = D.GetDataTable(qry);
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
}