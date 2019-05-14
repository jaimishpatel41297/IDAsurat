<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AddEmployee.aspx.cs" Inherits="Admin_AddEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function ShowpopupUser() {
            debugger;
            $('#UserModal').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add Employee</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
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
                    <div class="text-right">
                        <asp:LinkButton runat="server" ID="lbLeague" data-toggle="modal" data-target="#UserModal" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Add User Details</asp:LinkButton>
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
                                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile" />
                                    <asp:BoundField DataField="category1" HeaderText="Category" />
                                    <asp:BoundField DataField="Username" HeaderText="Username" />
                                    <asp:BoundField DataField="Password" HeaderText="Password" />
                                    <asp:BoundField DataField="Readinquiry" HeaderText="Read Inquiry" />
                                    <asp:BoundField DataField="Writeinquiry" HeaderText="Write Inquiry" />
                                    <asp:BoundField DataField="Allinquiry" HeaderText="All Inquiry" />
                                    <asp:BoundField DataField="Readattendance" HeaderText="Read Attendance" />
                                    <asp:BoundField DataField="Writeattendance" HeaderText="Write Attendance" />
                                    <asp:BoundField DataField="Allattendance" HeaderText="All Attendance" />
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="lbEdit" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-edit btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbEdit_Click"></asp:LinkButton>
                                            <asp:LinkButton runat="server" ID="lbDelete" OnClientClick="return confirm('Are You Sure Want To Delete ?')" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="UserModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
        <div class="modal-dialog" style="width: 80%;" role="document">
            <div class="modal-content" style="width: 84%; margin-left: 70px;">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title">Add User</h4>
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="modal-body">
                            <div class="form-group">
                                <label for="">
                                    Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtname" ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtname" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Mobile No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtmobno" ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtmobno" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group" style="margin-bottom: 40px;">
                                <label for="">Select category
                                     <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtuname" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:DropDownList ID="ddlemployeeCategory" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlemployeeCategory_SelectedIndexChanged" Style="width: 100%;">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    User Name:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtuname" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtuname" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="">
                                    Password:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtpass" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtpass" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="form-group col-md-4 col-sd-4 col-lg-4">
                                    <label for="">
                                        Read Inquiry: 
                                     <asp:CheckBox ID="readi" runat="server" />
                                    </label>
                                </div>

                                <div class="form-group col-md-4 col-sd-4 col-lg-4">
                                    <label for="">
                                        Write Inquiry: 
                                     <asp:CheckBox ID="writei" runat="server" />
                                    </label>
                                </div>

                                <div class="form-group col-md-4 col-sd-4 col-lg-4">
                                    <label for="">
                                        All: 
                                     <asp:CheckBox ID="alli" runat="server" AutoPostBack="true" OnCheckedChanged="alli_CheckedChanged"/>
                                    </label>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="form-group col-md-4 col-sd-4 col-lg-4">
                                    <label for="">
                                        Read Attendance: 
                                     <asp:CheckBox ID="reada" runat="server" />
                                    </label>
                                </div>

                                <div class="form-group col-md-4 col-sd-4 col-lg-4">
                                    <label for="">
                                        Write Attendance: 
                                     <asp:CheckBox ID="writea" runat="server" />
                                    </label>
                                </div>

                                <div class="form-group col-md-4 col-sd-4 col-lg-4">
                                    <label for="">
                                        All: 
                                     <asp:CheckBox ID="alla" runat="server" AutoPostBack="true" OnCheckedChanged="alla_CheckedChanged" />
                                    </label>
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="modal-footer" style="margin-top: 70px;">
                    <div class="text-right">
                        <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddUser" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddUser" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--   <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add Employee</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-md-5 col-sm-12 col-xs-12">
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
                                    Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtName" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtName" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Mobile No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtno" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtno" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="text-right">
                                <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                                <button type="reset" class=" fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-7 col-lg-7 col-xs-12 col-sm-12">
                <div class="white-box">
                    <h3 class="box-title m-b-0">Data</h3>
                    <div class="row">
                        <div class="col-sm-12 col-xs-12">
                            <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table-responsive table table-striped table-bordered" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sr. No.">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="lbDelete" OnClientClick="return confirm('Are You Sure Want To Delete ?')" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>

