using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;

public partial class cp_sms_OperatorMaster : System.Web.UI.MasterPage
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Request.Cookies["UserId"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            CheckUser();
        }
    }

    private void CheckUser()
    {

        Cookie1 = Request.Cookies["UserId"].Value;

        try
        {
            DataTable dt = D.GetDataTable("select * from EmployeeMaster where Id='" + Cookie1 + "'  ");
            if (dt.Rows.Count > 0)
            {
                string redinquiry = dt.Rows[0]["Readinquiry"].ToString();
                string alliry = dt.Rows[0]["Allinquiry"].ToString();
                string reaatt = dt.Rows[0]["Readattendance"].ToString();
                string allatt = dt.Rows[0]["Allattendance"].ToString();
                if (alliry == "True" && allatt == "True")
                {
                    Addinq.Visible = true;
                    Addatt.Visible = true;
                }
                else if (redinquiry == "True" && allatt == "True")
                {
                    if (alliry == "True")
                    {
                        Addinq.Visible = true;
                        Addatt.Visible = true;
                    }
                    else
                    {
                        Addinq.Visible = false;
                        Addatt.Visible = true;
                    }
                }
                else if (alliry == "True" && reaatt == "True")
                {
                    if (allatt == "True")
                    {
                        Addinq.Visible = true;
                        Addatt.Visible = true;
                    }
                    else
                    {
                        Addinq.Visible = true;
                        Addatt.Visible = false;
                    }
                }
                else if (redinquiry == "True" && reaatt == "True")
                {
                    Addinq.Visible = false;
                    Addatt.Visible = false;
                }

            }
        }
        catch (Exception e)
        {
        }
    }

    public string Cookie1 { get; set; }
}
