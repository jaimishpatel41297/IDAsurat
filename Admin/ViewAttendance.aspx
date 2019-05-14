<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="ViewAttendance.aspx.cs" Inherits="Admin_ViewAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View Attendance</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
            <div class="white-box">
                <h3 class="box-title m-b-0">Data</h3>
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="white-box">
                            <div class="row">
                                <div class="col-sm-12 col-lg-12 col-xs-12">

                                    <div class="col-sm-4 form-group">
                                        <label for="">Select Date</label>
                                        <div>
                                            <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>
                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdate">
                                            </asp:CalendarExtender>
                                        </div>
                                    </div>
                                    <div class="col-sm-4 form-group">
                                        <label for="">Select Course</label>
                                        <div>
                                            <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-sm-4 form-group">
                                        <label for="">Select Name</label>
                                        <div>
                                            <asp:DropDownList ID="ddlstd" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="text-left" style="margin-left: 1%;">
                                    <asp:LinkButton runat="server" ID="IbSearch" ValidationGroup="AddEmployee" OnClick="IbSearch_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Search</asp:LinkButton>
                                    <asp:LinkButton Style="margin-left: 1%;" runat="server" ID="IbView" ValidationGroup="AddEmployee" OnClick="IbView_Click1" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">View Attendance Graph</asp:LinkButton>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="col-sm-12 col-xs-12 table-responsive">
                        <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="Sr. No.">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CourseName" HeaderText="Course Name" />
                                <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                                <%--  <asp:BoundField DataField="Attendance" HeaderText="Attendance Data" />--%>
                                <asp:TemplateField HeaderText="Attendance Date">
                                    <ItemTemplate>
                                        <asp:Label ID="lblatt" runat="server" Text='<%#Eval("Attendance") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Date" HeaderText="Attendance Date" DataFormatString="{0: dd-MM-yyyy}" />
                                <%--  <asp:boundfield datafield="date" headertext="date " />--%>
                                <asp:BoundField DataField="TeacherName" HeaderText="Teacher Name" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>

