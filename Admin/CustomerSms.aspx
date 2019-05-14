<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="CustomerSms.aspx.cs" Inherits="Admin_CustomerSms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Inquiry SMS</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="white-box">
                    <p class="text-muted m-b-10 font-13">
                        <div class="alert alert-success alert-dismissable" id="divSuccess" runat="server" visible="false">
                            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                            Success ! Changes Done Successfully
                        </div>
                        <div class="alert alert-danger alert-dismissable" id="divError" runat="server" visible="false">
                            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                            Failure ! Changes Not Done Successfully !
                        </div>
                    </p>
                    <div class="row">
                        <div class="col-sm-12 col-lg-12 col-xs-12">
                            <div class="form-group">
                                <label for="">
                                    Select Customer
                                </label>
                                <div>
                                    <asp:DropDownList ID="ddltype" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddltype_SelectedIndexChanged">
                                         <asp:ListItem Text="Select Category" Value="Select Category" />
                                        <asp:ListItem Text="Inquiry Detail" Value="Inquiry Detail" />
                                        <asp:ListItem Text="Student Detail" Value="Student Detail" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Type Message
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddComplain" ControlToValidate="txtmsg" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox runat="server" ID="txtmsg" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div class="text-right">
                                <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddComplain" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Send SMS</asp:LinkButton>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
                <div class="white-box">
                    <h3 class="box-title m-b-0">Data</h3>
                    <div class="row">
                        <div class="col-sm-12 col-xs-12 table-responsive">
                            <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:TemplateField HeaderText="Select Data">
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="AllCheckBox" AutoPostBack="true" OnCheckedChanged="AllCheckBox_CheckedChanged" runat="server"></asp:CheckBox>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Sr. No.">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HiddenField ID="HiddenFieldId" Value='<%# Eval("Id") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" />
                                    <asp:BoundField DataField="InquiryDate" HeaderText="InquiryDate" DataFormatString="{0: dd-MM-yyyy}" />
                                    <asp:BoundField DataField="FollowUpdate" HeaderText="FollowUpdate" DataFormatString="{0: dd-MM-yyyy}" />
                                    <asp:BoundField DataField="CName" HeaderText="Course Name" />
                                    <asp:BoundField DataField="Remark" HeaderText="Remark" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

