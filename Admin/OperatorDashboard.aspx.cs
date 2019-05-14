using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cp_sms_Dashboard : System.Web.UI.Page
{
    Connection D = new Connection();
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["UserId"];
        //string id = cookie.Value.ToString();
        if (!IsPostBack)
        {
            BindData();
            BindData1();
        }
    }

    private void BindData()
    {
        string str = "";

        string qry = "select count(*) as Counting from InquiryMaster where Status is null and InquiryDate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";

        DataTable dt = D.GetDataTable(qry);

        if (dt.Rows.Count > 0)
        {
            str += "<li class='text-right'><span class='counter'>" + dt.Rows[0]["Counting"] + "</span></li>";

            ltrInquiry.Text = str;
        }
    }

    private void BindData1()
    {
        string str = "";

        string qry = "select count(*) as Counting from InquiryMaster where Status is null and FollowUpDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "'";

        DataTable dt = D.GetDataTable(qry);

        if (dt.Rows.Count > 0)
        {
            str += "<li class='text-right'><span class='counter'>" + dt.Rows[0]["Counting"] + "</span></li>";
            ltrfollowup.Text = str;
        }
    }
}