using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for AppService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AppService : System.Web.Services.WebService
{

    string websiteclient = "http://idasurat.itfuturz.com/";
    string website = "http://idasurat.itfuturz.com/";

    SqlConnection cn = new SqlConnection("Data Source=103.87.173.217;Initial Catalog=IDASurat;uid=studyfield;pwd=arpit@17;");

    GetData D = new GetData();
    Connection cc = new Connection();

    public AppService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    #region Website Service
    [WebMethod]
    public void InquirySearch(string ACTION, string Mobile, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<SearchUserData> cm = new List<SearchUserData>();
        List<GeneralDataSearch> g = new List<GeneralDataSearch>();
        try
        {
            if (ACTION == "getsearchdata")
            {
                GeneralDataSearch data = new GeneralDataSearch();
                data.MESSAGE = "";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;

                string qry = "select im.*,cm.Name as CName,r.Name as RName from InquiryMaster im, CourseMaster cm,Reference r where im.CourseId=cm.Id and im.Refid=r.Id and im.mobileno = '" + Mobile + "' and im.UserId='" + Id + "'";
                DataTable dt = D.GetDataTable(qry);
                if (dt.Rows.Count > 0)
                {
                    SearchUserData d = new SearchUserData();
                    d.Id = dt.Rows[0]["Id"].ToString();
                    d.Name = dt.Rows[0]["Name"].ToString();
                    d.MobileNo = dt.Rows[0]["MobileNo"].ToString();
                    d.Discount = dt.Rows[0]["Discount"].ToString();
                    d.InquiryDate = Convert.ToDateTime(dt.Rows[0]["InquiryDate"]).ToString("dd-MM-yyyy");
                    d.FollowUpdate = Convert.ToDateTime(dt.Rows[0]["FollowUpdate"]).ToString("dd-MM-yyyy");
                    d.CName = dt.Rows[0]["CName"].ToString();
                    d.RName = dt.Rows[0]["RName"].ToString();
                    cm.Add(d);

                    data.getuserdata = cm;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g[0]));
                }
                else
                {
                    data.MESSAGE = "Failed To Load";
                    data.ORIGINAL_ERROR = "Mobile No Not Exists";
                    data.ERROR_STATUS = true;
                    data.RECORDS = false;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g[0]));
                    return;
                }

            }
        }
        catch (Exception ex)
        {
            GeneralDataSearch data = new GeneralDataSearch();
            data.MESSAGE = "Failed To Load";
            data.ORIGINAL_ERROR = ex.Message;
            data.ERROR_STATUS = true;
            data.RECORDS = false;
            g.Add(data);
            Context.Response.Write(js.Serialize(g[0]));
        }
    }

    [WebMethod]
    public void GetCustomerData(string type)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<SearchUserData> list = new List<SearchUserData>();
        List<GeneralDataSearch> g = new List<GeneralDataSearch>();
        if (type == "customer")
        {
            try
            {
                DataTable dt2 = D.GetDataTable("select *,name + ' - ' + Convert(nvarchar,MobileNo) as fullname from InquiryMaster");
                if (dt2.Rows.Count != 0)
                {
                    for (i = 0; i <= dt2.Rows.Count - 1; i++)
                    {
                        SearchUserData hc = new SearchUserData();
                        hc.Id = dt2.Rows[i]["Id"].ToString();
                        hc.Name = dt2.Rows[i]["fullname"].ToString();
                        list.Add(hc);

                    }
                    GeneralDataSearch data = new GeneralDataSearch();
                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.getuserdata = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g[0]));
                }
                else
                {
                    GeneralDataSearch data = new GeneralDataSearch();
                    data.MESSAGE = "Data Not Available";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g[0]));
                }
            }
            catch (Exception ex)
            {
                GeneralDataSearch data = new GeneralDataSearch();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g[0]));
            }
        }
    }

    #endregion

}