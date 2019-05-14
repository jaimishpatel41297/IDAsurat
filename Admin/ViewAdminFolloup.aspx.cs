using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

//Status is null
public partial class Admin_ViewAdminFolloup : System.Web.UI.Page
{
    Connection D = new Connection();
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["AdminId"];
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
        DataTable dt1 = D.GetDataTable("select * from Course");
        if (dt1.Rows.Count > 0)
        {
            ddlcourse1.DataTextField = "Title";
            ddlcourse1.DataValueField = "Id";
            ddlcourse1.DataSource = dt1;
            ddlcourse1.DataBind();
            ddlcourse1.Items.Insert(0, new ListItem("Select Course", "0"));

        }
    }

    private void BindData()
    {

        try
        {
            //string id = cookie.Value.ToString();
            //string qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Course c,Reference r where  im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id and Status=0 and im.FollowUpdate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and UserId='" + id + "'";
            string qry = "select distinct im.*,c.Title as CName,cm.Amount as Amount,r.Name as RName from InquiryMaster im, CourseMaster cm,Course c,Reference r where  im.CourseId=c.Id and im.CourseId=cm.Courseid and im.Refid=r.Id and Status=0 and im.FollowUpdate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
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
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        try
        {
            string qry = "update InquiryMaster set Status=0 where id=" + ids.ToString();

            D.ExecuteQuery(qry);

            Clear();

            BindData();
        }
        catch (Exception ex)
        {
        }
    }
    protected void lbReject_Click(object sender, EventArgs e)
    {
        txtpdate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        Clear();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Showpopups()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string qry = "update InquiryMaster set RDate='" + txtpdate.Text + "',Reason='" + txtpdesc.Text + "',Status=null where id=" + lbSubmit.CommandArgument;

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
    protected void lbEdit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupUser()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbUpdate.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from InquiryMaster where Id=" + lb.CommandArgument);
        try
        {
            if (dt.Rows.Count > 0)
            {

                lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                lbUpdate.CommandArgument = dt.Rows[0]["ID"].ToString();


                txtname.Text = dt.Rows[0]["Name"].ToString();
                txtmobno.Text = dt.Rows[0]["MobileNo"].ToString();
                txtdiscount.Text = dt.Rows[0]["Discount"].ToString();
                string fdate = Convert.ToDateTime(dt.Rows[0]["InquiryDate"]).ToString("yyyy-MM-dd");
                txtadmdate.Text = fdate;
                string fdate2 = Convert.ToDateTime(dt.Rows[0]["FollowUpdate"]).ToString("yyyy-MM-dd");
                txtfollow.Text = fdate2;
                ddlcourse1.Text = dt.Rows[0]["CourseId"].ToString();
                string fdate1 = Convert.ToDateTime(dt.Rows[0]["DOB"]).ToString("yyyy-MM-dd");
                txtdob.Text = fdate1;
                txtemail.Text = dt.Rows[0]["Email"].ToString();

            }

        }
        catch (Exception ex)
        {

        }
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        string qry = "";
        int st = 1;
        int st1 = 0;

        qry = "Update InquiryMaster set Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Discount='" + txtdiscount.Text + "',InquiryDate='" + txtadmdate.Text + "',FollowUpdate='" + txtfollow.Text + "',CourseId='" + ddlcourse1.SelectedValue + "',DOB='" + txtdob.Text + "',Email='" + txtemail.Text + "' where ID=" + lbUpdate.CommandArgument;
        D.ExecuteQuery(qry);

        BindData();

 
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;

        Clear();
    }
    protected void Ibeditcancel_Click(object sender, EventArgs e)
    {

    }
}
