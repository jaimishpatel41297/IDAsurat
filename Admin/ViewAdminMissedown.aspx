<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewAdminMissedown.aspx.cs" Inherits="Admin_ViewAdminMissedown" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Showpopups() {
            $('#ReasonModal').modal('show');
        }
    </script>
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View Missed inquiry</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
            <div class="white-box">
                <div class="row">
                    <div class="col-sm-6 col-lg-6 col-xs-12">
                        <div class="form-group">
                            <label for="">
                                Select Course
                            </label>
                            <div>
                                <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcourse_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                <h3 class="box-title m-b-0">Data</h3>
                <div class="row">
                    <div class="col-sm-12 col-xs-12 table-responsive">
                        <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="Sr. No.">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                <asp:BoundField DataField="Discount" HeaderText="Discount" />
                                <asp:BoundField DataField="InquiryDate" HeaderText="InquiryDate" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="FollowUpdate" HeaderText="FollowUpdate" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="CName" HeaderText="Course Name" />
                                <asp:BoundField DataField="Amount" HeaderText="Course Fee" />
                                <asp:BoundField DataField="RName" HeaderText="Reference By" />
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="lbDelete" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

