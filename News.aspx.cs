using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News : System.Web.UI.Page
{
    Connection D = new Connection(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindnews();
        }
    }

    private void Bindnews()
    {
        try
        {
            string m1 = "";
            string qry = "select * from News";
            DataTable dt = D.GetDataTable(qry);

            foreach (DataRow row in dt.Rows)
            {  
                m1 += "<div class='col-sm-4 col-sm-4'>" +
                            "<div class='team-member'>" +
                                "<img class='img-responsive' src='" + row["Image"] + "' alt=''>" +
                            "</div>" +
                        "</div>";

            }
            ltrnew.Text = m1;
        }
        catch (Exception e)
        {

        }
    }
}