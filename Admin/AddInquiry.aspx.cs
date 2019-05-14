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

public partial class Admin_AddInquiry : System.Web.UI.Page
{
    Connection D = new Connection();
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["UserId"];
        if (!IsPostBack)
        {
            BindDDL();
            BindData();
          
        }
    }



    private void BindData()
    {

        if (Request.Cookies["UserId"] != null)
        {

            try
            {
                string id = cookie.Value.ToString();
                DataTable dt = D.GetDataTable("select distinct im.*,c.Title as CName,cm.Amount as CAmount from InquiryMaster im,Course c,CourseMaster cm where im.CourseId=c.Id  and im.CourseId=cm.Courseid and UserId='" + id + "' order by id desc");
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
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    private void BindDDL()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from Course");
            if (dt.Rows.Count > 0)
            {
                ddlCourse.DataTextField = "Title";
                ddlCourse.DataValueField = "Id";
                ddlCourse.DataSource = dt;
                ddlCourse.DataBind();
                ddlCourse.Items.Insert(0, new ListItem("select course", "0"));
            }

            DataTable dts = D.GetDataTable("select * from Reference");
            if (dts.Rows.Count > 0)
            {
                ddlref.DataTextField = "Name";
                ddlref.DataValueField = "Id";
                ddlref.DataSource = dts;
                ddlref.DataBind();
                ddlref.Items.Insert(0, new ListItem("Select Reference", "0"));
            }
            string id = cookie.Value.ToString();
            DataTable dtss = D.GetDataTable("select * from EmployeeMaster where Id = '" + id + "'");
            if (dtss.Rows.Count > 0)
            {
                ddlEmployee.DataTextField = "Name";
                ddlEmployee.DataValueField = "Id";
                ddlEmployee.DataSource = dtss;
                ddlEmployee.DataBind();
                //ddlEmployee.Items.Insert(0, new ListItem("Select Employee", "0"));
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlCourse.SelectedValue != "0" && ddlEmployee.SelectedValue != "0" && ddlref.SelectedValue != "0")
               
              {
                string id = cookie.Value.ToString();
                string qry = "insert into InquiryMaster(Name,MobileNo,Discount,DOB,Email,InquiryDate,FollowUpdate,Remark,CourseId,UserId,RefId,Status) values('" + txtName.Text + "','" + txtno.Text + "','" + txtdis.Text + "','" + txtdob.Text + "','" + txtemail.Text + "','" + txtidate.Text + "','" + txtfdate.Text + "','" + txtdesc.Text + "','" + ddlCourse.SelectedValue + "','" + id + "','" + ddlref.SelectedValue + "',0)";             
                D.ExecuteQuery(qry);

                divSuccess.Visible = true;
                divError.Visible = false;

                Clear();

                BindData();
                //SendSms sm = new SendSms();
                //sm.sendotp("Your Inqiury is Registered", txtno.Text);
            }
            else
            {
                lberror.Visible = true;
            }
        }
        catch (Exception ex)
        {
            divSuccess.Visible = false;
            divError.Visible = true;
        }
    }

    public void Clear()
    {
        txtdis.Text = "";
        txtfdate.Text = "";
        txtidate.Text = "";
        txtName.Text = "";
        txtno.Text = "";
        txtdob.Text = "";
        txtemail.Text = "";
        txtdesc.Text = "";
        ddlCourse.SelectedIndex = 0;
        ddlref.SelectedIndex = 0;
        ddlEmployee.SelectedIndex = 0;
    }

    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lbs = (LinkButton)sender;
            int ids = Convert.ToInt32(lbSubmit.CommandArgument);

            D.ExecuteQuery("Update InquiryMaster set NAME='" + txtName.Text + "',MobileNo='" + txtno.Text + "',Discount='" + txtdis.Text + "',DOB='" + txtdob.Text + "',Email='" + txtemail.Text + "',InquiryDate='" + txtidate.Text + "',FollowUpdate='" + txtfdate.Text + "',Remark='" + txtdesc.Text + "',CourseId='" + ddlCourse.SelectedValue + "',RefId='" + ddlref.SelectedValue + "' where Id=" + ids);

            BindData();
            lbUpdate.Visible = false;
            lbSubmit.Visible = true;
            Clear();
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lbs = (LinkButton)sender;
            int ids = Convert.ToInt32(lbs.CommandArgument);

            D.ExecuteQuery("delete from InquiryMaster where Id=" + ids);

            BindData();
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lbs = (LinkButton)sender;
            int ids = Convert.ToInt32(lbs.CommandArgument);
            lbSubmit.CommandArgument = ids.ToString();

            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument);
            DataTable dt = D.GetData("select * from InquiryMaster where Id=" + lb.CommandArgument);
            if (dt.Rows.Count > 0)
            {

                lbSubmit.Visible = false;
                lbUpdate.Visible = true;
                lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtno.Text = dt.Rows[0]["MobileNo"].ToString();
                txtdis.Text = dt.Rows[0]["Discount"].ToString();
                txtdob.Text = dt.Rows[0]["DOB"].ToString();
                txtemail.Text = dt.Rows[0]["Email"].ToString();
                txtidate.Text = dt.Rows[0]["InquiryDate"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["InquiryDate"].ToString()).ToString("yyyy-MM-dd") : "";
                txtfdate.Text = dt.Rows[0]["FollowUpdate"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["FollowUpdate"].ToString()).ToString("yyyy-MM-dd") : "";
                ddlCourse.SelectedValue = dt.Rows[0]["CourseId"].ToString();
                ddlref.SelectedValue = dt.Rows[0]["RefId"].ToString();
                txtdesc.Text = dt.Rows[0]["Remark"].ToString();

            }

        }
        catch
        {

        }
    }

    [WebMethod]
    public static string[] GetCustomers(string prefix)
    {
        List<string> item = new List<string>();
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["IDASurat"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {



                string qry = "";

                qry = "select ID,NAME,MobileNo,Discount,CONVERT(date, InquiryDate,120)as InquiryDate,CONVERT(date, FollowUpdate,120) as FollowUpdate,CourseId From InquiryMaster where MobileNo like '%" + prefix + "%' or Name like '%" + prefix + "%'";

                cmd.CommandText = qry;
                cmd.Connection = conn;
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    //item.Add(string.Format("{0}-{1}", row["MobileNo"], row["NAME"]));
                    string idate = Convert.ToDateTime(row["InquiryDate"]).ToString("yyyy-MM-dd");
                    string fdate = Convert.ToDateTime(row["FollowUpdate"]).ToString("yyyy-MM-dd");

                    //item.Add(string.Format("{0} - {1} - {2} - {3} - {4} - {5}", row["MobileNo"], row["NAME"], row["Discount"], idate, fdate, row["CourseId"]));

                    item.Add(string.Format("{0} - {1}", row["MobileNo"], row["NAME"]));

                }

                conn.Close();
            }
        }
        return item.ToArray();
    }

    protected void IbCancel_Click(object sender, EventArgs e)
    {
        Clear();
        lbSubmit.Visible = true;
        lbUpdate.Visible = false;
    }
}