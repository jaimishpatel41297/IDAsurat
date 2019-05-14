<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="ViewDetails.aspx.cs" Inherits="Admin_ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View Graph</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="white-box">
                    <label for="" style="margin-left: 17px;">
                        Select Choice
                    </label>
                    <div class="col-sm-12">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="ddlSelect" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlSelect_SelectedIndexChanged">
                                <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                <asp:ListItem Value="1" Text="Month Wise"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Date Wise"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-12" id="months" runat="server" visible="false" style="margin-top: 10px;">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="ddlMonth" runat="server" CssClass="form-control">
                                <asp:ListItem Value="0" Text="Select Month"></asp:ListItem>
                                <asp:ListItem Value="1" Text="January"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Febuary"></asp:ListItem>
                                <asp:ListItem Value="3" Text="March"></asp:ListItem>
                                <asp:ListItem Value="4" Text="April"></asp:ListItem>
                                <asp:ListItem Value="5" Text="May"></asp:ListItem>
                                <asp:ListItem Value="6" Text="June"></asp:ListItem>
                                <asp:ListItem Value="7" Text="July"></asp:ListItem>
                                <asp:ListItem Value="8" Text="August"></asp:ListItem>
                                <asp:ListItem Value="9" Text="Sepetember"></asp:ListItem>
                                <asp:ListItem Value="10" Text="October"></asp:ListItem>
                                <asp:ListItem Value="11" Text="November"></asp:ListItem>
                                <asp:ListItem Value="12" Text="December"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-12" id="fromto" runat="server" visible="false">
                        <div class="col-sm-4">
                            <label for="">
                                From
                            <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtFrom" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                            </asp:RequiredFieldValidator>
                            </label>
                            <div>
                                <asp:TextBox ID="txtFrom" runat="server" ValidationGroup="" CssClass="form-control"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy-MM-dd" TargetControlID="txtFrom">
                                </asp:CalendarExtender>
                            </div>
                        </div>
                        <div class="col-sm-4">
                            <label for="">
                                To
                            <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtTo" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                            </asp:RequiredFieldValidator>
                            </label>
                            <div>
                                <asp:TextBox ID="txtTo" runat="server" ValidationGroup="" CssClass="form-control"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender2" runat="server" Format="yyyy-MM-dd" TargetControlID="txtTo">
                                </asp:CalendarExtender>
                            </div>
                        </div>
                    </div>
                    <div style="margin-top: 45px; margin-left: 16px;">
                        <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect" Visible="false">Submit</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="white-box">
                    <div style="margin-top: 110px; margin-left: 16px;">
                        <asp:Literal ID="ltrGraph" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

