<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="Viewwebinquery.aspx.cs" Inherits="Admin_Viewwebinquery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View WebSite inquiry</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
            <div class="white-box">
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
                                <asp:BoundField DataField="Surname" HeaderText="Surname" />
                                <asp:BoundField DataField="Fathername" HeaderText="Fathername" />
                                <asp:BoundField DataField="Dob" HeaderText="DOB" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="Mobile" HeaderText="Mobile No" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Academic" HeaderText="Academic Level" />
                                <asp:BoundField DataField="Marital" HeaderText="Marital Status" />
                                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                <asp:BoundField DataField="Bloodgroup" HeaderText="Bloodgroup" />
                                <asp:BoundField DataField="Nationality" HeaderText="Nationality" />
                                <asp:BoundField DataField="Address" HeaderText="Address" />
                                <asp:BoundField DataField="sname" HeaderText="State" />
                                <asp:BoundField DataField="cname" HeaderText="City" />
                                <asp:BoundField DataField="District" HeaderText="District" />
                                <asp:BoundField DataField="Pincode" HeaderText="Pincode" />
                                <asp:BoundField DataField="Category" HeaderText="Course;s Category" />
                                <asp:BoundField DataField="Course" HeaderText="Course Name" />
                                <asp:BoundField DataField="Remarks" HeaderText="Remarks" />
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="lbAccept" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-check btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbAccept_Click"></asp:LinkButton>
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

