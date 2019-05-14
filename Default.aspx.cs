using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;
using System.Data.Common;

public partial class _Default : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binddata();
            Binddata1();
        }
    }



    private void Binddata1()
    {
        try
        {
            string m1 = "";
            string qry = "select * from course where Type='Diploma'";
            DataTable dt = D.GetDataTable(qry);

            foreach (DataRow row in dt.Rows)
            {
                string type = dt.Rows[0]["Type"].ToString();
                m1 += "<li class='item-thumbs col-lg-4 design' data-id='id-0' data-type='web'>" +
                         "<h3>" + row["Title"] + "</h3>" +
                                    "<span style='display:block;color:#656565;'><h6 style='color:black;'>Course Duration</h6> " + row["Duration"] + "</span>" +
                                     "</li>";

            }
            ltrdip.Text = m1;
        }
        catch (Exception e)
        {

        }
    }

    private void Binddata()
    {
        try
        {
            string m1 = "";
            string qry = "select * from course where Type='Certificated'";
            DataTable dt = D.GetDataTable(qry);

            foreach (DataRow row in dt.Rows)
            {
                string type = dt.Rows[0]["Type"].ToString();
                m1 += "<li class='item-thumbs col-lg-4 design' data-id='id-0' data-type='icon'>" +
                                    "<h3 >" + row["Title"] + "</h3>" +
                                                 //"<span style='display:block;color:#656565;'><h6 style='color:black;'>Course Duration</h6>: " + row["Duration"] + "</span>" +
                                                 "<span style='display:block;color:#656565;'><h6 style='color:black;'>Course Duration</h6> " + row["Duration"] + "</span>" +
                                                "</li>";

            }
            ltrcer.Text = m1;
        }
        catch (Exception e)
        {

        }
    }
}