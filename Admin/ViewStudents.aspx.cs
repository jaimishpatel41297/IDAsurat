using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

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
            DataTable dt = D.GetDataTable("select * from Course");
            if (dt.Rows.Count > 0)
            {
                ddlcourse.DataTextField = "Title";
                ddlcourse.DataValueField = "Id";
                ddlcourse.DataSource = dt;
                ddlcourse.DataBind();
                ddlcourse.Items.Insert(0, new ListItem("Select Course", "0"));
            }

            DataTable dt1 = D.GetDataTable("select * from Course");
            if (dt.Rows.Count > 0)
            {
                ddlcourse1.DataTextField = "Title";
                ddlcourse1.DataValueField = "Id";
                ddlcourse1.DataSource = dt;
                ddlcourse1.DataBind();
                ddlcourse1.Items.Insert(0, new ListItem("Select Course", "0"));

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
                qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im,Course c, CourseMaster cm,Reference r where im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id and im.CourseId='" + ddlcourse.SelectedValue + "' and UserId='" + id + "' and Status=1";
            }
            else
            {
                qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im,Course c, CourseMaster cm,Reference r where im.CourseId=c.Id and  im.CourseId=cm.Courseid and im.Refid=r.Id and UserId='" + id + "' and Status=1";
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

  

    private void Clear()
    {
        txtname.Text = "";
        txtmobno.Text = "";
        txtdiscount.Text = "";
        txtadmdate.Text = "";
        txtdob.Text = "";
        txtemail.Text = "";
    }

    protected void lbCancel_Click(object sender, EventArgs e)
    {
        Clear1();
    }

    protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();
        int amount = 0;

        string qry1 = "select distinct im.*,cm.Amount as amount from inquirymaster im,Coursemaster cm where im.CourseId=cm.Courseid and im.Id='" + ids + "'";
        DataTable dt1 = D.GetDataTable(qry1);
        if (dt1.Rows.Count > 0)
        {
            amount = Convert.ToInt32(dt1.Rows[0]["amount"].ToString());
        }
        string qry = "select * from feesmaster where InquiryId=" + ids;

        DataTable dt = D.GetDataTable(qry);
        if (dt.Rows.Count > 0)
        {
            lbInst.Text = dt.Rows[0]["DurationId"].ToString();

            if (dt.Rows[0]["DurationId"].ToString() == "1")
            {
                Div1.Visible = true;
                Div2.Visible = false;
                Div3.Visible = false;
                Div4.Visible = false;
            }
            else if (dt.Rows[0]["DurationId"].ToString() == "2")
            {
                Div1.Visible = true;
                Div2.Visible = true;
                Div3.Visible = false;
                Div4.Visible = false;
            }
            else if (dt.Rows[0]["DurationId"].ToString() == "3")
            {
                Div1.Visible = true;
                Div2.Visible = true;
                Div3.Visible = true;
                Div4.Visible = false;
            }
            else if (dt.Rows[0]["DurationId"].ToString() == "4")
            {
                Div1.Visible = true;
                Div2.Visible = true;
                Div3.Visible = true;
                Div4.Visible = true;
            }
            string Fee1 = dt.Rows[0]["Fee1"].ToString();
            amount = amount - Convert.ToInt32(Fee1);
            ltramt.Text = amount.ToString();

            string FeeDate1 = Convert.ToDateTime(dt.Rows[0]["FeeDate1"]).ToString("dd-MM-yyyy");
            string payment1 = dt.Rows[0]["paymentid"].ToString();
            if (payment1 != "Cash")
            {
                if (payment1 == "Cheque" || payment1 == "Draft")
                {
                    f1.Visible = true;
                    string num1 = dt.Rows[0]["Number"].ToString();
                    string bank1 = dt.Rows[0]["Bankname"].ToString();
                    lblnum.Text = num1;
                    lblnam.Text = payment1;
                }
                else
                {
                    f1.Visible = false;
                }
            }
            string Fee2 = dt.Rows[0]["Fee2"] != System.DBNull.Value ? dt.Rows[0]["Fee2"].ToString() : "0";
            amount = amount - Convert.ToInt32(Fee2);
            ltramt2.Text = amount.ToString();

            string FeeDate2 = dt.Rows[0]["FeeDate2"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["FeeDate2"]).ToString("dd-MM-yyyy") : "";
            string payment2 = dt.Rows[0]["paymentid2"].ToString();
            if (payment2 != "Cash")
            {
                if (payment2 == "Cheque" || payment2 == "Draft")
                {
                    f2.Visible = true;
                    string num2 = dt.Rows[0]["Number2"].ToString();
                    string bank2 = dt.Rows[0]["Bankname2"].ToString();
                    lblnum2.Text = num2;
                    lblnam2.Text = bank2;
                }
                else
                {
                    f2.Visible = false;
                }
            }


            string Fee3 = dt.Rows[0]["Fee3"] != System.DBNull.Value ? dt.Rows[0]["Fee3"].ToString() : "0";
            amount = amount - Convert.ToInt32(Fee3);
            ltramt3.Text = amount.ToString();

            string FeeDate3 = dt.Rows[0]["FeeDate3"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["FeeDate3"]).ToString("dd-MM-yyyy") : "";
            string payment3 = dt.Rows[0]["paymentid3"].ToString();
            if (payment3 != "Cash")
            {
                if (payment3 == "Cheque" || payment3 == "Draft")
                {
                    f3.Visible = true;
                    string num3 = dt.Rows[0]["Number3"].ToString();
                    string bank3 = dt.Rows[0]["Bankname3"].ToString();
                    lblnum3.Text = num3;
                    lblnam3.Text = bank3;
                }
                else
                {
                    f3.Visible = false;
                }
            }


            string Fee4 = dt.Rows[0]["Fee4"] != System.DBNull.Value ? dt.Rows[0]["Fee4"].ToString() : "0";
            amount = amount - Convert.ToInt32(Fee4);
            ltramt4.Text = amount.ToString();

            string FeeDate4 = dt.Rows[0]["FeeDate4"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["FeeDate4"]).ToString("dd-MM-yyyy") : "";
            string payment4 = dt.Rows[0]["paymentid4"].ToString();
            if (payment4 != "Cash")
            {
                if (payment4 == "Cheque" || payment4 == "Draft")
                {
                    f4.Visible = true;
                    string num4 = dt.Rows[0]["Number4"].ToString();
                    string bank4 = dt.Rows[0]["Bankname4"].ToString();
                    lblnum4.Text = num4;
                    lblnam4.Text = bank4;
                }
                else
                {
                    f4.Visible = false;
                }
            }

            string p1 = ids.ToString();
            ltrre1.Text = "<a title='ICard' target='_blank' href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=" + p1 + "&Fee=Fee1&Method=" + payment1 + "' class='btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt'></a>";
            ltrre2.Text = "<a title='ICard' target='_blank' href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=" + p1 + "&Fee=Fee2&Method=" + payment2 + "' class='btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt'></a>";
            ltrre3.Text = "<a title='ICard' target='_blank' href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=" + p1 + "&Fee=Fee3&Method=" + payment3 + "' class='btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt'></a>";
            ltrre4.Text = "<a title='ICard' target='_blank' href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=" + p1 + "&Fee=Fee4&Method=" + payment4 + "' class='btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt'></a>";

            lbf1.Text = Fee1;
            lbfDate1.Text = FeeDate1;
            lblpay.Text = payment1;


            lbf2.Text = Fee2;
            lbfDate2.Text = FeeDate2;
            lblpay2.Text = payment2;


            lbf3.Text = Fee3;
            lbfDate3.Text = FeeDate3;
            lblpay3.Text = payment3;


            lbf4.Text = Fee4;
            lbfDate4.Text = FeeDate4;
            lblpay4.Text = payment4;


            //if (lbf2.Text != "-" || lbf3.Text != "-" || lbf4.Text != "-")
            //{
            //    Div5.Visible = false;
            //    Div6.Visible = false;
            //    //lbSubmit.Visible = false;
            //}
            //else
            //{
            //    Div5.Visible = true;
            //    Div6.Visible = true;
            //    //lbSubmit.Visible = true;
            //}
        }

        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Showpopups()", true);


    }
    private void Clear1()
    {
        //txtAmount.Text = "";
    }
    protected void IbEdit1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupUser()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from InquiryMaster where Id=" + lb.CommandArgument);
        try
        {
            if (dt.Rows.Count > 0)
            {

                lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                lbSubmit.CommandArgument = dt.Rows[0]["ID"].ToString();


                txtname.Text = dt.Rows[0]["Name"].ToString();
                txtmobno.Text = dt.Rows[0]["MobileNo"].ToString();
                txtdiscount.Text = dt.Rows[0]["Discount"].ToString();
                string fdate = Convert.ToDateTime(dt.Rows[0]["AdmissionDate"]).ToString("yyyy-MM-dd");

                txtadmdate.Text = fdate;
                ddlcourse1.Text = dt.Rows[0]["CourseId"].ToString();
                string fdate1 = Convert.ToDateTime(dt.Rows[0]["DOB"]).ToString("yyyy-MM-dd");
                txtdob.Text = fdate1;
                txtemail.Text = dt.Rows[0]["Email"].ToString();

            }

        }
        catch (Exception e33)
        {

        }
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from InquiryMaster where Id=" + id);

            divSuccess.Visible = true;
            divError.Visible = false;

            Clear();

            BindData();
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            divSuccess.Visible = false;
        }
    }
    protected void ddlcourse1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        string qry = "";
        int st = 1;
        int st1 = 0;

        qry = "Update InquiryMaster set Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Discount='" + txtdiscount.Text + "',AdmissionDate='" + txtadmdate.Text + "',CourseId='" + ddlcourse1.SelectedValue + "',DOB='" + txtdob.Text + "',Email='" + txtemail.Text + "' where ID=" + lbSubmit.CommandArgument;
        D.ExecuteQuery(qry);

        BindData();

        divSuccess.Visible = true;
        divError.Visible = false;
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;

        Clear();
    }
    protected void Ibeditcancel_Click(object sender, EventArgs e)
    {

    }

    protected void lbSubmit_Click(object sender, EventArgs e)
    {

    }

    protected void lbCancel_Click1(object sender, EventArgs e)
    {
        Clear1();
    }
}