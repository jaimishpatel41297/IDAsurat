<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="Chart.aspx.cs" Inherits="Admin_Chart" %>

<%@ Register Assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>

<%@ Register assembly="DevExpress.XtraCharts.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <dxchartsui:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" DataSourceID="SqlDataSource1" Height="200px" Width="300px"></dxchartsui:WebChartControl>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDASurat %>" SelectCommand="select * from InquiryMaster"></asp:SqlDataSource>
</asp:Content>

