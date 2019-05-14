using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Viewincomegraph : System.Web.UI.Page
{
    Connection D = new Connection();
    String strChart = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        LoadPieGraph();
    }

    private void LoadPieGraph()
    {
        string qry = "";

        SqlCommand cmd = new SqlCommand("getFeeTotalByMonth");
        cmd.Parameters.AddWithValue("@from", txtFrom.Text);
        cmd.Parameters.AddWithValue("@to", txtTo.Text);
        DataTable dtGraph = D.GetDataTableBySP(cmd);

        strChart += "<html>" + Environment.NewLine +
                   "<head>" + Environment.NewLine +
                   "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>" + Environment.NewLine +
                   "<title>Highcharts Example</title>" + Environment.NewLine +
                   "<script type='text/javascript' src='http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js'></script>" + Environment.NewLine +
                   "<script type='text/javascript'>" + Environment.NewLine +
                   "$(function () {" + Environment.NewLine +
                   "var chart;" + Environment.NewLine +
                   "$(document).ready(function() {" + Environment.NewLine +
                   "Highcharts.getOptions().colors = $.map(Highcharts.getOptions().colors, function(color) {" + Environment.NewLine +
                   "return {" + Environment.NewLine +
                   "radialGradient: { cx: 0.5, cy: 0.3, r: 0.7 }," + Environment.NewLine +
                   "stops: [" + Environment.NewLine +
                   "[0, color]," + Environment.NewLine +
                   "[1, Highcharts.Color(color).brighten(-0.3).get('rgb')] // darken" + Environment.NewLine +
                   "]" + Environment.NewLine +
                   "};" + Environment.NewLine +
                   "});" + Environment.NewLine +
                   "chart = new Highcharts.Chart({" + Environment.NewLine +
                   "chart: {" + Environment.NewLine +
                   "renderTo: 'container'," + Environment.NewLine +
                   "plotBackgroundColor: null," + Environment.NewLine +
                   "plotBorderWidth: null," + Environment.NewLine +
                   "plotShadow: false" + Environment.NewLine +
                   "}," + Environment.NewLine +
                   "title: {" + Environment.NewLine +
                   "text: 'Fees Details'" + Environment.NewLine +
                   "}," + Environment.NewLine +
                   "tooltip: {" + Environment.NewLine +
                   "pointFormat: '{series.name}:<b>{point.y}</b>'," + Environment.NewLine +
                   "percentageDecimals: 1" + Environment.NewLine +
                   "}," + Environment.NewLine +
                   "plotOptions: {" + Environment.NewLine +
                   "pie: {" + Environment.NewLine +
                   "allowPointSelect: true," + Environment.NewLine +
                   "cursor: 'pointer'," + Environment.NewLine +
                   "dataLabels: {" + Environment.NewLine +
                   "enabled: true," + Environment.NewLine +
                   "color: '#000000'," + Environment.NewLine +
                   "connectorColor: '#000000'," + Environment.NewLine +
                   "formatter: function() {" + Environment.NewLine +
                   "return '<b>'+ this.point.name +'</b>: '+ this.y +'';" + Environment.NewLine +
                   "}" + Environment.NewLine +
                   "}" + Environment.NewLine +
                   "}" + Environment.NewLine +
                   "}," + Environment.NewLine +
                   "series: [{" + Environment.NewLine +
                   "type: 'pie'," + Environment.NewLine +
                   "name: 'Count'," + Environment.NewLine +
                   "data: [" + Environment.NewLine;

        if (dtGraph.Rows.Count > 0)
        {
            strChart += "['Total Fees'," + dtGraph.Rows[0][0].ToString() + "]," + Environment.NewLine;
        }

        strChart += "]" + Environment.NewLine +
               "}]" + Environment.NewLine +
               "});" + Environment.NewLine +
               "});" + Environment.NewLine +
               "});" + Environment.NewLine +
               "</script>" + Environment.NewLine +
               "</head>" + Environment.NewLine +
               "<body>" + Environment.NewLine +
               "<script src='https://code.highcharts.com/highcharts.src.js' type='text/javascript'></script>" + Environment.NewLine +
               "<script src='../exporting.js' type='text/javascript'></script>" + Environment.NewLine +

               "<div id='container' style='min-width: 400px; height: 400px; margin: 0 auto'></div>" + Environment.NewLine +
               "</body>" + Environment.NewLine +
               "</html>";


        ltrGraph.Text = strChart;
    }
}