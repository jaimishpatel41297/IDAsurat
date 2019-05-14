using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Configuration;


public partial class Admin_Idareceipt_Feereceipt : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IDASurat"].ConnectionString.ToString());
    Connection cn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];
        //string ID = "1";
        //string Report_Name = Request.QueryString["Report_Name"];
        string Report_Name = "FeesReceipt";
        string Installment1 = Request.QueryString["Fee"];
        string Method = Request.QueryString["Method"];
        //TestCertificate
        //Fe
        if (Report_Name != null && Report_Name == "FeesReceipt" && Installment1 != null && ID != null)
        {
            CustomSqlQuery MasterQuery = new CustomSqlQuery();
            MasterQuery.Name = "CustomSqlQuery";

            if (Installment1 == "Fee1")
            {
                if (Method == "Cash")
                {
                    MasterQuery.Sql = "select fm.Fee1 as Fee,fm.FeeDate1 as FeeDate,fm.paymentid as Pay,fm.Bankname as Bank,fm.Number as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Cheque")
                {
                    MasterQuery.Sql = "select fm.Fee1 as Fee,fm.Fee1 as Fe,fm.FeeDate1 as FeeDate,fm.FeeDate1 as Date,fm.paymentid as Pay1,fm.Bankname as Bank,fm.Number as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Draft")
                {
                    MasterQuery.Sql = "select fm.Fee1 as Fee,fm.Fee1 as Fe,fm.FeeDate1 as FeeDate,fm.FeeDate1 as Date,fm.paymentid as Pay2,fm.Bankname as Bank,fm.Number as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
            }
            else if (Installment1 == "Fee2")
            {
                if (Method == "Cash")
                {
                    MasterQuery.Sql = "select fm.Fee2 as Fee,fm.FeeDate2 as FeeDate,fm.paymentid2 as Pay,fm.Bankname2 as Bank,fm.Number2 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Cheque")
                {
                    MasterQuery.Sql = "select fm.Fee2 as Fee,fm.Fee2 as Fe,fm.FeeDate2 as FeeDate,fm.FeeDate2 as Date,fm.paymentid2 as Pay1,fm.Bankname2 as Bank,fm.Number2 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Draft")
                {
                    MasterQuery.Sql = "select fm.Fee2 as Fee,fm.FeeDate2 as FeeDate,fm.FeeDate2 as Date,fm.paymentid2 as Pay2,fm.Bankname2 as Bank,fm.Number2 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
            }
            else if (Installment1 == "Fee3")
            {
                if (Method == "Cash")
                {
                    MasterQuery.Sql = "select fm.Fee3 as Fee,fm.FeeDate3 as FeeDate,fm.paymentid3 as Pay,fm.Bankname3 as Bank,fm.Number3 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Cheque")
                {
                    MasterQuery.Sql = "select fm.Fee3 as Fee,fm.Fee3 as Fe,fm.FeeDate3 as FeeDate,fm.FeeDate3 as Datefm.paymentid3 as Pay1,fm.Bankname3 as Bank,fm.Number3 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Draft")
                {
                    MasterQuery.Sql = "select fm.Fee3 as Fee,fm.FeeDate3 as FeeDate,fm.paymentid3 as Pay2,fm.FeeDate3 as Date,fm.Bankname3 as Bank,fm.Number3 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
            }
            else if (Installment1 == "Fee4")
            {
                if (Method == "Cash")
                {
                    MasterQuery.Sql = "select fm.Fee4 as Fee,fm.FeeDate4 as FeeDate,fm.paymentid4 as Pay,fm.Bankname4 as Bank,fm.Number4 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Cheque")
                {
                    MasterQuery.Sql = "select fm.Fee4 as Fee,fm.Fee4 as Fe,fm.FeeDate4 as FeeDate,fm.FeeDate4 as Date,fm.paymentid4 as Pay1,fm.Bankname4 as Bank,fm.Number4 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
                else if (Method == "Draft")
                {
                    MasterQuery.Sql = "select fm.Fee4 as Fee,fm.FeeDate4 as FeeDate,fm.paymentid4 as Pay2,fm.FeeDate4 as Date,fm.Bankname4 as Bank,fm.Number4 as Num,fm.*,im.Name as StudentName from FeesMaster fm, InquiryMaster im where im.Id=fm.InquiryId and InquiryId=" + ID;
                }
            }
            FeesReceipt Servicememo1 = new FeesReceipt();
            Servicememo1.sqlDataSource1.Queries[0] = MasterQuery;

            using (MemoryStream ms = new MemoryStream())
            {
                Servicememo1.ExportToPdf(ms, new PdfExportOptions() { ShowPrintDialogOnOpen = true });
                WriteDocumentToResponse(ms.ToArray(), "pdf", true, "Fee.pdf");
            }

        }

    }

    void WriteDocumentToResponse(byte[] documentData, string format, bool isInline, string fileName)
    {
        string contentType;
        string disposition = (isInline) ? "inline" : "attachment";

        switch (format.ToLower())
        {
            case "xls":
                contentType = "application/vnd.ms-excel";
                break;
            case "xlsx":
                contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                break;
            case "mht":
                contentType = "message/rfc822";
                break;
            case "html":
                contentType = "text/html";
                break;
            case "txt":
            case "csv":
                contentType = "text/plain";
                break;
            case "png":
                contentType = "image/png";
                break;
            default:
                contentType = String.Format("application/{0}", format);
                break;
        }

        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName));
        Response.BinaryWrite(documentData);
        Response.End();
    }
}