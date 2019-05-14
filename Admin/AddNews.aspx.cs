using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddNews : System.Web.UI.Page
{
    Connection D = new Connection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            divSuccess.Visible = false;
            divError.Visible = false;
            BindData();
        }
    }

    private void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from News");
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
        catch (Exception e11)
        {

        }
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        string qry = "";
        string img = "";

        if (file.HasFile)
        {
            Random rd = new Random();
            int no = rd.Next();
            string ext = System.IO.Path.GetExtension(file.FileName);
            file.SaveAs(System.IO.Path.Combine(Server.MapPath("../Resources/News/"), no + ext));
            img = string.Format("../Resources/News/{0}{1}", no, ext);

            qry = string.Format("insert into News(Image) values('{0}')", img);
            D.ExecuteQuery(qry);
            BindData();

            divSuccess.Visible = true;
            divError.Visible = false;

        }

    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from News where Id=" + id);

            divSuccess.Visible = true;
            divError.Visible = false;

            BindData();
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            divSuccess.Visible = false;
        }
    }
}