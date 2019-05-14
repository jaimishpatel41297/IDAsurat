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


public partial class Diploma : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binddata();
        }
    }

    private void Binddata()
    {
        try
        {
            string m1 = "";
            string qry = "select * from course where Type='Diploma'";
            DataTable dt = D.GetDataTable(qry);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    m1 += "<div class='col-md-4' style='margin-bottom:33px;'>" +
                         "<span class='icons c1' style='height: 66px;padding:6px 0 0 0;font-size: 57px;'><i class='fa fa-file-text'></i></span>" +
                                      "<div class='textbox'>" +
                                       "<h3>" + dt.Rows[i]["Title"] + "</h3>" +
                                      "<p><span style='color:black;'>Course Duration : </span>" + dt.Rows[i]["Duration"] + "</p>" +
                                        "</div>" +
                                        "</div>";
                }
                else if (i % 2 == 1)
                {
                    m1 += "<div class='col-md-4' style='margin-bottom:33px;'>" +
                        "<span class='icons c4' style='height: 66px;padding:6px 0 0 0;font-size: 57px;'><i class='fa fa-file-text'></i></span>" +
                           "<div class='textbox'>" +
                         "<h3>" + dt.Rows[i]["Title"] + "</h3>" +
                        "<p><span style='color:black;'>Course Duration : </span>" + dt.Rows[i]["Duration"] + "</p>" +
                           "</div>" +
                        "</div>";
                } ltrdip.Text = m1;
            }
        }
        catch (Exception e)
        {

        }
    }
}