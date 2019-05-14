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

public partial class Certificate : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binddata();
        }
    }
    //foreach (DataRow row in dt.Rows)
    //            {
    //                string type = dt.Rows[0]["Type"].ToString();

    //m1 += "<div class='col-md-4' style='margin-bottom:33px;'>" +
    //     "<div class='textbox'>" +
    //        "<h3>" + row["Title"] + "</h3>" +
    //        "<p><span style='color:black;'>Course Duration : </span>" + row["Duration"] + "</p>" +
    //    "</div>" +
    //    "</div>";
    private void Binddata()
    {
        try
        {
            string m1 = "";
            string qry = "select * from course where Type='Certificated'";
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
                        "<span class='icons c4' style='height: 66px;padding:6px 0 0 0;font-size: 57px;border: #11967C 1px solid;background: #11967C;'><i class='fa fa-file-text'></i></span>" +
                           "<div class='textbox'>" +
                         "<h3>" + dt.Rows[i]["Title"] + "</h3>" +
                        "<p><span style='color:black;'>Course Duration : </span>" + dt.Rows[i]["Duration"] + "</p>" +
                           "</div>" +
                        "</div>";
                } ltrcer.Text = m1;
            }


            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            m1 += "<div class='col-md-5 text-center' style='margin-bottom:33px;'>" +
            //                                         "<span class='icons c1'><i class='fa fa-file-text'></i></span>" +
            //                                         "<div class='box-area'>" +
            //                                             "<h3>" + dt.Rows[i]["Title"] + "</h3>" +
            //                                            "<p><span style='color:black;'>Course Duration : </span>" + dt.Rows[i]["Duration"] + "</p>" +
            //                                         "</div>" +
            //                                     "</div>";
            //        }
            //        else if (i % 2 == 1)
            //        {
            //            m1 += string.Format("<div class='col-md-5 text-center' style='margin-bottom:33px;'><span class='icons c2'><i  class='fa fa-file-text'></i></span><div class='box-area'><h3>{0}</h3><p><span style='color:black;'>Course Duration : </span>{1}</p></div></div>", dt.Rows[i]["Title"], dt.Rows[i]["Duration"]);
            //        }
            //        else
            //        {
            //            m1 += string.Format("<div class='col-md-4 text-center' style='margin-bottom:33px;'><span class='icons c3'><i  class='fa fa-file-text'></i></span><div class='box-area'><h3>{0}</h3><p><span style='color:black;'>Course Duration : </span>{1}</p></div></div>", dt.Rows[i]["Title"], dt.Rows[i]["Duration"]);
            //        }
            //    }


            //}

        }

        catch (Exception e)
        {

        }
    }
}