<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="Addwebcourse.aspx.cs" Inherits="Admin_Addwebcourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-sm-12 col-xs-12">
                <h4 class="page-title">Add Web Course</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-lg-12 col-xs-12">
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
                                <label>
                                    Select Course Type
                                         <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" CssClass="form-control" ControlToValidate="ddlCourse" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                         </asp:RequiredFieldValidator>
                                </label>

                                <asp:DropDownList ID="ddlCourse" ValidationGroup="AddEmployee" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="Select Course Type" />
                                    <asp:ListItem Text="Diploma" Value="Diploma" />
                                    <asp:ListItem Text="Certificated" Value="Certificated" />
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Course Title
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txttitle" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txttitle" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Course Duration
                                    <asp:RequiredFieldValidator Display="Dynamic"  ValidationGroup="AddEmployee" ControlToValidate="txtdur" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtdur" runat="server" TextMode="MultiLine" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="text-right">
                                <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                                <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                                <asp:LinkButton runat="server" ID="IbCancel" ValidationGroup="AddEmployee" OnClick="IbCancel_Click" class=" fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-xs-12 col-sm-12">
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
                                    <asp:BoundField DataField="Type" HeaderText="Course Type" />
                                    <asp:BoundField DataField="Title" HeaderText="Course Title" />
                                    <asp:BoundField DataField="Duration" HeaderText="Course Duration" />
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="lbEdit" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-edit btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbEdit_Click"></asp:LinkButton>
                                            <asp:LinkButton runat="server" ID="lbDelete" OnClientClick="return confirm('Are You Sure Want To Delete ?')" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click1"></asp:LinkButton>
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
</asp:Content>

