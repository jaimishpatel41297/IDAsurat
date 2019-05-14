using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class Connection
{
    SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IDASurat"].ConnectionString.ToString());
    public Connection()
    {
    }
    public int GetMaxId(string SqlQuery)
    {
        int id = 0;
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = new SqlCommand(SqlQuery, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        return id;
    }
    public DataTable GetDataTable(string strqry)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = new SqlCommand(strqry, cnn);
            cnn.Close();
            cnn.Open();
            cm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            if (msg.Contains("Connection Timeout Expired"))
            {
                HttpContext.Current.Response.Redirect("~/Admin/500.html", false);
            }
            else
            {
                throw new Exception(msg);
            }

        }
        finally
        {
            cnn.Close();
        }
        return dt;
    }

    public DataTable GetDataTableBySP(SqlCommand cmd)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = cmd;
            cm.CommandType = CommandType.StoredProcedure;
            cm.Connection = cnn;
            cnn.Open();
            cm.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            cnn.Close();
        }
        return dt;
    }

    public void ExecuteQuery(string qry)
    {
        cnn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cnn;
        cmd.CommandText = qry;
        cmd.ExecuteNonQuery();
        cnn.Close();
    }
    public void ExecuteQueryBySP(SqlCommand scmd)
    {
        cnn.Open();
        SqlCommand cmd = scmd;
        cmd.Connection = cnn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        cnn.Close();
    }

    public DataTable GetData(string qry)
    {
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cnn.Close();

        }
        catch (Exception ex)
        {

        }
        return dt;

    }
}
public class SearchUserData
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string MobileNo { get; set; }
    public string Discount { get; set; }
    public string InquiryDate { get; set; }
    public string FollowUpdate { get; set; }
    public string CourseId { get; set; }
    public string RefId { get; set; }
    public string CName { get; set; }
    public string RName { get; set; }
    public string UserId { get; set; }
}
public class GeneralDataSearch
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<SearchUserData> getuserdata { get; set; }

}