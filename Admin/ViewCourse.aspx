<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="ViewCourse.aspx.cs" Inherits="Admin_ViewCourse" %>

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
                <h4 class="page-title">View Course</h4>

            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
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
            <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
                <div class="white-box">
                    <%--<div class="row">
                        <div class="col-sm-6 col-lg-6 col-xs-12">
                            <div class="text-right">
                                <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="true" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                                <asp:LinkButton runat="server" ID="Ibcancel" ValidationGroup="AddEmployee" OnClick="Ibcancel_Click" Visible="true" CommandArgument='<%# Eval("Id") %>' class=" fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                            </div>
                        </div>
                    </div>--%>
                    <h3 class="box-title m-b-0">Data</h3>
                    <div class="row">
                        <div class="col-sm-12 col-xs-12 table-responsive">
                            <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="false"  AllowPaging="True"  onpageindexchanging="gv_PageIndexChanging" PageSize="15"  PersistedSelection="true"   ondatabound="gv_DataBound" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sr. No.">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Course Name" DataField="CourseName" />
                                    <asp:BoundField HeaderText="Subject Name" DataField="Subject" />
                                    <asp:BoundField HeaderText="Chapter Name" DataField="Chapter" />
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="lbEdit" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-edit btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbEdit_Click"></asp:LinkButton>
                                            <asp:LinkButton runat="server" ID="lbDelete" OnClientClick="return confirm('Are You Sure Want To Delete ?')" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#CCCCCC" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade" id="UserModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
                <div class="modal-dialog" style="width: 80%;" role="document">

                    <div class="modal-content" style="width: 84%; margin-left: 70px;">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                            <h4 class="modal-title">Course</h4>
                        </div>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="modal-body">
                                    <div class="form-group">
                                        <label for="">Select Course</label>
                                        <div>
                                            <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="">
                                            Subject 
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtsub" ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox ID="txtsub" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="">
                                            Chapter:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtchap" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox ID="txtchap" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div class="modal-footer" style="margin-top: 70px;">
                            <div class="text-right">

                                <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                                <asp:LinkButton runat="server" ID="Ibeditcancel" data-dismiss="modal" OnClick="Ibeditcancel_Click1" Visible="false" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

