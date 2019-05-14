using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_AddEmployee : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IDASurat"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            Binadcategory();
        }
    }
    private void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select  e.*,c.Category as category1 from EmployeeMaster as e,[Category] as c where e.Category=c.ID");
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
        catch { }
    }
    //protected void lbSubmit_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        string qry = "insert into EmployeeMaster(Name,MobileNo) values('" + txtName.Text + "','" + txtno.Text + "')";

    //        D.ExecuteQuery(qry);

    //        BindData();

    //        divSuccess.Visible = true;
    //        divError.Visible = false;

    //        Clear();
    //    }
    //    catch (Exception ex)
    //    {
    //        divSuccess.Visible = false;
    //        divError.Visible = true;
    //    }
    //}
    //protected void lbDelete_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        LinkButton lb = (LinkButton)sender;
    //        int id = Convert.ToInt32(lb.CommandArgument.ToString());
    //        D.ExecuteQuery("delete from EmployeeMaster where Id=" + id);

    //        divSuccess.Visible = true;
    //        divError.Visible = false;

    //        BindData();
    //    }
    //    catch (Exception ex)
    //    {
    //        divError.Visible = true;
    //        divSuccess.Visible = false;
    //    }
    //}
    private void Clear()
    {
        txtname.Text = "";
        txtmobno.Text = "";
        readi.Checked = false;
        writei.Checked = false;
        alli.Checked = false;
        reada.Checked = false;
        writea.Checked = false;
        alla.Checked = false;
        txtuname.Text = "";
        txtpass.Text = "";
    }


    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        int st = 1;
        int st1 = 0;
        try
        {
            //if( readi.Checked == true || readi.Checked == true|| alli.Checked == true || reada.Checked == true || writew.Checked  == true|| alla.Checked == true )
            if (alli.Checked == true && alla.Checked == true)
            {
                string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st + "','" + st + "','" + st + "','" + st + "','" + st + "','" + st + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                D.ExecuteQuery(qry);
            }
            else
            {
                if (readi.Checked == true && reada.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st + "','" + st1 + "','" + st1 + "','" + st + "','" + st1 + "','" + st1 + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (readi.Checked == true && writea.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st + "','" + st1 + "','" + st1 + "','" + st1 + "','" + st + "','" + st1 + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (readi.Checked == true && alla.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st + "','" + st1 + "','" + st1 + "','" + st + "','" + st + "','" + st + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (writei.Checked == true && reada.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st1 + "','" + st + "','" + st1 + "','" + st + "','" + st1 + "','" + st1 + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (writei.Checked == true && writea.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st1 + "','" + st + "','" + st1 + "','" + st1 + "','" + st + "','" + st1 + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (writei.Checked == true && alla.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st1 + "','" + st + "','" + st1 + "','" + st + "','" + st + "','" + st + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (alli.Checked == true && reada.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st + "','" + st + "','" + st + "','" + st + "','" + st1 + "','" + st1 + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
                else if (alli.Checked == true && writea.Checked == true)
                {
                    string qry = "insert into EmployeeMaster(Name,MobileNo,Category,Readinquiry,Writeinquiry,Allinquiry,Readattendance,Writeattendance,Allattendance,Username,Password) values('" + txtname.Text + "','" + txtmobno.Text + "','" + ddlemployeeCategory.SelectedValue + "','" + st + "','" + st + "','" + st + "','" + st1 + "','" + st + "','" + st1 + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                    D.ExecuteQuery(qry);
                }
            }
            BindData();

            divSuccess.Visible = true;
            divError.Visible = false;

            Clear();
        }
        catch (Exception ex)
        {
            divSuccess.Visible = false;
            divError.Visible = true;
        }
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        string qry = "";
        int st = 1;
        int st1 = 0;
        if (alli.Checked == true && alla.Checked == true)
        {
            qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st + "',Writeinquiry='" + st + "',Allinquiry='" + st + "',Readattendance='" + st + "',Writeattendance='" + st + "',Allattendance='" + st + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
        }
        else
        {
            if (readi.Checked == true && reada.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st + "',Writeinquiry='" + st1 + "',Allinquiry='" + st1 + "',Readattendance='" + st + "',Writeattendance='" + st1 + "',Allattendance='" + st1 + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (readi.Checked == true && writea.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st + "',Writeinquiry='" + st1 + "',Allinquiry='" + st1 + "',Readattendance='" + st1 + "',Writeattendance='" + st + "',Allattendance='" + st1 + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (readi.Checked == true && alla.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st + "',Writeinquiry='" + st1 + "',Allinquiry='" + st1 + "',Readattendance='" + st + "',Writeattendance='" + st + "',Allattendance='" + st + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (writei.Checked == true && reada.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st1 + "',Writeinquiry='" + st + "',Allinquiry='" + st1 + "',Readattendance='" + st + "',Writeattendance='" + st1 + "',Allattendance='" + st1 + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (writei.Checked == true && writea.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st1 + "',Writeinquiry='" + st + "',Allinquiry='" + st1 + "',Readattendance='" + st1 + "',Writeattendance='" + st + "',Allattendance='" + st1 + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (writei.Checked == true && alla.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st1 + "',Writeinquiry='" + st + "',Allinquiry='" + st1 + "',Readattendance='" + st + "',Writeattendance='" + st + "',Allattendance='" + st + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (alla.Checked == true && reada.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st + "',Writeinquiry='" + st + "',Allinquiry='" + st + "',Readattendance='" + st + "',Writeattendance='" + st1 + "',Allattendance='" + st1 + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
            else if (alla.Checked == true && writea.Checked == true)
            {
                qry = "Update EmployeeMaster set Category='" + ddlemployeeCategory.SelectedValue + "',Name='" + txtname.Text + "',MobileNo='" + txtmobno.Text + "',Readinquiry='" + st + "',Writeinquiry='" + st + "',Allinquiry='" + st + "',Readattendance='" + st1 + "',Writeattendance='" + st + "',Allattendance='" + st1 + "',Username='" + txtuname.Text + "',Password='" + txtpass.Text + "' where ID=" + lbSubmit.CommandArgument;
                D.ExecuteQuery(qry);
            }
        }
        D.ExecuteQuery(qry);

        BindData();

        divSuccess.Visible = true;
        divError.Visible = false;
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;

        Clear();
    }
    protected void ddlemployeeCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void lbEdit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupUser()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from EmployeeMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["ID"].ToString();

            ddlemployeeCategory.Text = dt.Rows[0]["Category"].ToString();
            txtname.Text = dt.Rows[0]["Name"].ToString();
            txtmobno.Text = dt.Rows[0]["MobileNo"].ToString();
            txtuname.Text = dt.Rows[0]["Username"].ToString();
            txtpass.Text = dt.Rows[0]["Password"].ToString();
            string a1 = dt.Rows[0]["Readinquiry"].ToString();
            string a2 = dt.Rows[0]["Writeinquiry"].ToString();
            string a3 = dt.Rows[0]["Allinquiry"].ToString();
            string a4 = dt.Rows[0]["Readattendance"].ToString();
            string a5 = dt.Rows[0]["Writeattendance"].ToString();
            string a6 = dt.Rows[0]["Allattendance"].ToString();
            if (a3 == "True" & a6 == "True")
            {
                readi.Checked = true;
                writei.Checked = true;
                alli.Checked = true;
                reada.Checked = true;
                writea.Checked = true;
                alla.Checked = true;
            }
            else
            {
                if (a1 == "True" & a4 == "True")
                {
                    if (a2 == "True" & a3 == "True")
                    {
                        readi.Checked = true;
                        writei.Checked = true;
                        alli.Checked = true;
                        reada.Checked = true;
                        writea.Checked = false;
                        alla.Checked = false;
                    }
                    else
                    {
                        readi.Checked = true;
                        writei.Checked = false;
                        alli.Checked = false;
                        reada.Checked = true;
                        writea.Checked = false;
                        alla.Checked = false;
                    }
                }
                else if (a1 == "True" & a5 == "True")
                {
                    if (a2 == "True" & a3 == "True")
                    {
                        readi.Checked = true;
                        writei.Checked = true;
                        alli.Checked = true;
                        reada.Checked = false;
                        writea.Checked = true;
                        alla.Checked = false;
                    }
                    else
                    {
                        readi.Checked = true;
                        writei.Checked = false;
                        alli.Checked = false;
                        reada.Checked = false;
                        writea.Checked = true;
                        alla.Checked = false;
                    }
                }
                else if (a1 == "True" & a6 == "True")
                {
                    if (a2 == "True" & a3 == "True")
                    {
                        readi.Checked = true;
                        writei.Checked = true;
                        alli.Checked = true;
                        reada.Checked = true;
                        writea.Checked = true;
                        alla.Checked = true;
                    }
                    else
                    {
                        readi.Checked = true;
                        writei.Checked = false;
                        alli.Checked = false;
                        reada.Checked = true;
                        writea.Checked = true;
                        alla.Checked = true;
                    }
                }
                else if (a2 == "True" & a4 == "True")
                {
                    if (a1 == "True" & a3 == "True")
                    {
                        readi.Checked = true;
                        writei.Checked = true;
                        alli.Checked = true;
                        reada.Checked = true;
                        writea.Checked = false;
                        alla.Checked = false;
                    }
                    else
                    {
                        readi.Checked = false;
                        writei.Checked = true;
                        alli.Checked = false;
                        reada.Checked = true;
                        writea.Checked = false;
                        alla.Checked = false;
                    }
                }
                else if (a2 == "True" & a5 == "True")
                {

                    if (a1 == "True" & a3 == "True")
                    {
                        readi.Checked = true;
                        writei.Checked = true;
                        alli.Checked = true;
                        reada.Checked = false;
                        writea.Checked = true;
                        alla.Checked = false;
                    }
                    else
                    {
                        readi.Checked = false;
                        writei.Checked = true;
                        alli.Checked = false;
                        reada.Checked = false;
                        writea.Checked = true;
                        alla.Checked = false;
                    }
                }
                else if (a2 == "True" & a6 == "True")
                {
                    if (a1 == "True" & a3 == "True")
                    {
                        readi.Checked = true;
                        writei.Checked = true;
                        alli.Checked = true;
                        reada.Checked = true;
                        writea.Checked = true;
                        alla.Checked = true;
                    }
                    else
                    {
                        readi.Checked = false;
                        writei.Checked = true;
                        alli.Checked = false;
                        reada.Checked = true;
                        writea.Checked = true;
                        alla.Checked = true;
                    }
                }
                else if (a3 == "True" & a4 == "True")
                {
                    readi.Checked = true;
                    writei.Checked = true;
                    alli.Checked = true;
                    reada.Checked = true;
                    writea.Checked = false;
                    alla.Checked = false;
                }
                else if (a3 == "True" & a5 == "True")
                {
                    readi.Checked = true;
                    writei.Checked = true;
                    alli.Checked = true;
                    reada.Checked = false;
                    writea.Checked = true;
                    alla.Checked = false;
                }
            }

            //BindData();
        }

    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from EmployeeMaster where Id=" + id);

            divSuccess.Visible = true;
            divError.Visible = false;

            Clear();

            BindData();
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            divSuccess.Visible = false;
        }
    }
    public void Binadcategory()
    {
        DataTable dt = D.GetDataTable("select * from Category");
        if (dt.Rows.Count > 0)
        {
            ddlemployeeCategory.DataTextField = "Category";
            ddlemployeeCategory.DataValueField = "ID";
            ddlemployeeCategory.DataSource = dt;
            ddlemployeeCategory.DataBind();
            ddlemployeeCategory.Items.Insert(0, new ListItem("Select Empolyee Category", "0"));
        }

    }
    protected void alli_CheckedChanged(object sender, EventArgs e)
    {

        if (alli.Checked == true)
        {
            readi.Checked = true;
            writei.Checked = true;
        }
        else
        {
            readi.Checked = false;
            writei.Checked = false;
        }

    }
    protected void alla_CheckedChanged(object sender, EventArgs e)
    {
        if (alla.Checked == true)
        {
            reada.Checked = true;
            writea.Checked = true;
        }
        else
        {
            reada.Checked = false;
            writea.Checked = false;
        }           
    }
}