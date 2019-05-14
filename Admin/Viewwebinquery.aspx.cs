using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Viewwebinquery : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Binddata();
    }

    private void Binddata()
    {
        try
        {
            string qry = "";

            qry = "select o.*,s.StateName as sname,c.CityName as cname from OnlineRegistration o, State s, City c where o.State = s.StateId and o.City = c.CityId and Status=0";

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
            string qry = "update OnlineRegistration set Status=1 where id=" +ids;
            D.ExecuteQuery(qry);
            Binddata();
        }
        catch (Exception e33)
        {

        }
    }
}