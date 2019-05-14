﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ViewFollowup : System.Web.UI.Page
{
    Connection D = new Connection();
    HttpCookie cookie;

    protected void Page_Load(object sender, EventArgs e)
    {

        cookie = Request.Cookies["UserId"];

        if (!IsPostBack)
        {
            if (cookie != null)
            {
                BindData();
                BindDDL();
                //string avalue = hdn_lblIP1.Value;
                //List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtDynamic")).ToList();
                //int i = 1;
                //foreach (string key in keys)
                //{
                //    this.CreateTextBox("txtDynamic" + i, Convert.ToInt32(avalue));
                //    i++;
                //}

                txti1.Visible = false;
                lb1.Visible = false;
                txti2.Visible = false;
                lb2.Visible = false;
                txti3.Visible = false;
                lb3.Visible = false;
                txti4.Visible = false;
                lb4.Visible = false;

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }

    private void BindDDL()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from CourseMaster");
            if (dt.Rows.Count > 0)
            {
                ddlcourse.DataTextField = "Name";
                ddlcourse.DataValueField = "Id";
                ddlcourse.DataSource = dt;
                ddlcourse.DataBind();
                ddlcourse.Items.Insert(0, new ListItem("Select Course", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }

    private void BindData()
    {
        string id = cookie.Value.ToString();
        try
        {
            string qry = "";

            if (ddlcourse.SelectedValue != "" && ddlcourse.SelectedValue != "0")
            {
                qry = "select im.*,cm.Name as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Reference r where im.CourseId=cm.Id and im.Refid=r.Id and Status=0 and im.CourseId='" + ddlcourse.SelectedValue + "' and UserId='" + id + "' order by id desc";
            }
            else
            {
                qry = "select im.*,cm.Name as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Reference r where im.CourseId=cm.Id and im.Refid=r.Id and Status=0 and UserId='" + id + "' order by id desc";
            }
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
        catch (Exception ex)
        {

        }
    }

    protected void lbAccept_Click(object sender, EventArgs e)
    {
        //txtpdate.Text = DateTime.Now.ToString("dd-MM-yyyy");

        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Showpopupss()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmitFees.CommandArgument = ids.ToString();

    }

    protected void lbReject_Click(object sender, EventArgs e)
    {
        txtpdate.Text = DateTime.Now.ToString("dd-MM-yyyy");

        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Showpopups()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();
    }

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string qry = "update InquiryMaster set RDate='" + txtpdate.Text + "',Reason='" + txtpdesc.Text + "',Status=0 where id=" + lbSubmit.CommandArgument;

            D.ExecuteQuery(qry);

            Clear();

            BindData();
        }
        catch (Exception ex)
        {
        }
    }


    protected void Clear()
    {
        txtpdate.Text = "";
        txtpdesc.Text = "";
    }

    protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlFees_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string number = ddlFees.SelectedValue.ToString();

            if (number == "Yearly")
            {
                txti1.Visible = true;
                lb1.Visible = true;
                txti2.Visible = false;
                lb2.Visible = false;
                txti3.Visible = false;
                lb3.Visible = false;
                txti4.Visible = false;
                lb4.Visible = false;
            }
            else if (number == "Half Yearly")
            {
                txti1.Visible = true;
                lb1.Visible = true;
                txti2.Visible = true;
                lb2.Visible = true;
                txti3.Visible = false;
                lb3.Visible = false;
                txti4.Visible = false;
                lb4.Visible = false;
            }
            else if (number == "Quarterly")
            {
                txti1.Visible = true;
                lb1.Visible = true;
                txti2.Visible = true;
                lb2.Visible = true;
                txti3.Visible = true;
                lb3.Visible = true;
                txti4.Visible = false;
                lb4.Visible = false;
            }
            else if (number == "Monthly")
            {
                txti1.Visible = true;
                lb1.Visible = true;
                txti2.Visible = true;
                lb2.Visible = true;
                txti3.Visible = true;
                lb3.Visible = true;
                txti4.Visible = true;
                lb4.Visible = true;
            }
        }
        catch (Exception e22)
        {

        }
    }

    private void CreateTextBox(string id, int selectedValue)
    {

        //string qry = "Select * from DurationMaster where Id=" + selectedValue;

        //DataTable dt = D.GetDataTable(qry);
        //if (dt.Rows.Count > 0)
        //{

        //    int number = Convert.ToInt32(dt.Rows[0]["Number"].ToString());

        //    for (int i = 0; i < number; i++)
        //    {
        //        TextBox txt = new TextBox();
        //        txt.ID = id + i;
        //        pnlTextBoxes.Controls.Add(txt);

        //        Literal lt = new Literal();
        //        lt.Text = "<br />";
        //        pnlTextBoxes.Controls.Add(lt);
        //    }
        //}
    }

    protected void lbSubmitFees_Click(object sender, EventArgs e)
    {

        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        string qry = "";
        try
        {
            string number = ddlFees.SelectedValue.ToString();
            if (number == "Yearly")
            {
                string num = ddlpay.SelectedValue.ToString();
                qry = "insert into FeesMaster(InquiryId,DurationId,Fee1,FeeDate1,paymentid,Bankname,Number) values('" + ids + "','" + 1 + "','" + txti1.Text + "','" + txtdate1.Text + "','" + num + "','" + txtb1.Text + "','" + txtp1.Text + "')";
                D.ExecuteQuery(qry);
                D.ExecuteQuery("update InquiryMaster set AdmissionDate='" + DateTime.Now + "', Status=1 where Id=" + ids);
                D.ExecuteQuery("insert into Student(Name,MobileNo,CourseId) select Name,MobileNo,CourseId from InquiryMaster where Id = " + ids);
            }
            else if (number == "Half Yearly")
            {
                string num = ddlpay.SelectedValue.ToString();
                string num1 = ddlpay2.SelectedValue.ToString();
                qry = "insert into FeesMaster(InquiryId,DurationId,Fee1,FeeDate1,Fee2,FeeDate2,paymentid,Bankname,Number,paymentid2,Bankname2,Number2) values('" + ids + "','" + 2 + "','" + txti1.Text + "','" + txtdate1.Text + "','" + txti2.Text + "','" + txtdate2.Text + "','" + num + "','" + txtb1.Text + "','" + txtp1.Text + "','" + num1 + "','" + txtb2.Text + "','" + txtp2.Text + "')";
                D.ExecuteQuery(qry);
                D.ExecuteQuery("update InquiryMaster set AdmissionDate='" + DateTime.Now + "', Status=1 where Id=" + ids);
                D.ExecuteQuery("insert into Student (Name,MobileNo,CourseId) select Name,MobileNo,CourseId from InquiryMaster where Id = " + ids);
            }
            else if (number == "Quarterly")
            {
                string num = ddlpay.SelectedValue.ToString();
                string num1 = ddlpay2.SelectedValue.ToString();
                string num2 = ddlpay3.SelectedValue.ToString();
                qry = "insert into FeesMaster(InquiryId,DurationId,Fee1,FeeDate1,Fee2,FeeDate2,Fee3,FeeDate3,paymentid,Bankname,Number,paymentid2,Bankname2,Number2,paymentid3,Bankname3,Number3) values('" + ids + "','" + 3 + "','" + txti1.Text + "','" + txtdate1.Text + "','" + txti2.Text + "','" + txtdate2.Text + "','" + txti3.Text + "','" + txtdate3.Text + "','" + num + "','" + txtb1.Text + "','" + txtp1.Text + "','" + num1 + "','" + txtb2.Text + "','" + txtp2.Text + "','" + num2 + "','" + txtb3.Text + "','" + txtp3.Text + "')";
                D.ExecuteQuery(qry);
                D.ExecuteQuery("update InquiryMaster set AdmissionDate='" + DateTime.Now + "', Status=1 where Id=" + ids);
                D.ExecuteQuery("insert into Student (Name,MobileNo,CourseId) select Name,MobileNo,CourseId from InquiryMaster where Id = " + ids);
            }
            else if (number == "Monthly")
            {
                string num = ddlpay.SelectedValue.ToString();
                string num1 = ddlpay2.SelectedValue.ToString();
                string num2 = ddlpay3.SelectedValue.ToString();
                string num3 = ddlpay4.SelectedValue.ToString();
                qry = "insert into FeesMaster(InquiryId,DurationId,Fee1,FeeDate1,Fee2,FeeDate2,Fee3,FeeDate3,Fee4,FeeDate4,paymentid,Bankname,Number,paymentid2,Bankname2,Number2,paymentid3,Bankname3,Number3,paymentid4,Bankname4,Number4) values('" + ids + "','" + 4 + "','" + txti1.Text + "','" + txtdate1.Text + "','" + txti2.Text + "','" + txtdate2.Text + "','" + txti3.Text + "','" + txtdate3.Text + "','" + txti4.Text + "','" + txtdate4.Text + "','" + num + "','" + txtb1.Text + "','" + txtp1.Text + "','" + num1 + "','" + txtb2.Text + "','" + txtp2.Text + "','" + num2 + "','" + txtb3.Text + "','" + txtp3.Text + "','" + num3 + "','" + txtb4.Text + "','" + txtp4.Text + "')";
                D.ExecuteQuery(qry);
                D.ExecuteQuery("update InquiryMaster set AdmissionDate='" + DateTime.Now + "', Status=1 where Id=" + ids);
                D.ExecuteQuery("insert into Student (Name,MobileNo,CourseId) select Name,MobileNo,CourseId from InquiryMaster where Id = " + ids);
            }
            //D.ExecuteQuery("update InquiryMaster set AdmissionDate='" + DateTime.Now + "', Status=1 where Id=" + ids);
            BindData();
            Clear();
        }
        catch (Exception ex)
        {
        }

    }

    protected void lbCancelFees_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Closepopupss()", true);

        txti1.Visible = false;
        lb1.Visible = false;
        txti2.Visible = false;
        lb2.Visible = false;
        txti3.Visible = false;
        lb3.Visible = false;
        txti4.Visible = false;
        lb4.Visible = false;

        ddlFees.SelectedValue = "Select Duration";
        Clear();
    }
    protected void lbCancel_Click1(object sender, EventArgs e)
    {
        Clear();
    }

    protected void ddlpay_SelectedIndexChanged(object sender, EventArgs e)
    {
        string num = ddlpay.SelectedValue.ToString();
        try
        {

            if (num == "Cash")
            {
                l.Visible = false;
                txtp1.Visible = false;
                txtb1.Visible = false;
            }
            else
            {
                l.Visible = true;
                txtp1.Visible = true;
                txtb1.Visible = true;
            }
        }
        catch
        {

        }
    }
    protected void ddlpay2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string num = ddlpay2.SelectedValue.ToString();
        if (num == "Cash")
        {
            l1.Visible = false;
            txtp2.Visible = false;
            txtb2.Visible = false;

        }
        else
        {
            l1.Visible = true;
            txtp2.Visible = true;
            txtb2.Visible = true;

        }
    }
    protected void ddlpay3_SelectedIndexChanged(object sender, EventArgs e)
    {
        string num = ddlpay3.SelectedValue.ToString();

        if (num == "Cash")
        {
            l2.Visible = false;
            txtp3.Visible = false;
            txtb3.Visible = false;

        }
        else
        {
            l2.Visible = true;
            txtp3.Visible = true;
            txtb3.Visible = true;

        }
    }
    protected void ddlpay4_SelectedIndexChanged(object sender, EventArgs e)
    {
        string num = ddlpay4.SelectedValue.ToString();
        if (num == "Cash")
        {
            l3.Visible = false;
            txtp4.Visible = false;
            txtb4.Visible = false;
        }
        else
        {
            l3.Visible = true;
            txtp4.Visible = true;
            txtb4.Visible = true;
        }

    }
}