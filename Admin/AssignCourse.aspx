<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AssignCourse.aspx.cs" Inherits="Admin_AssignCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Assign Course</h4>
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
                            <div <%--style="margin-left: 25%; margin-right: 25%;"--%>>
                                <div class="form-group">
                                    <label for="">Select Teacher</label>
                                    <div>
                                        <asp:DropDownList ID="ddlfaculty" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="">Select Course</label>
                                    <div>
                                        <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="">
                                        Subject Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtsub" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtsub" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="">
                                        Chapter Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtchap" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtchap" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                  <div class="form-group">
                                <div class="form-group col-md-3 col-sd-3 col-lg-3">
                                    <label for="">
                                        Read Course: 
                                     <asp:CheckBox ID="readi" runat="server" />
                                    </label>
                                </div>

                                <div class="form-group col-md-3 col-sd-3 col-lg-3">
                                    <label for="">
                                        Write Course: 
                                     <asp:CheckBox ID="writei" runat="server" />
                                    </label>
                                </div>

                                <div class="form-group col-md-3 col-sd-3 col-lg-3">
                                    <label for="">
                                        All Course: 
                                     <asp:CheckBox ID="alli" runat="server" AutoPostBack="true" OnCheckedChanged="alli_CheckedChanged"/>
                                    </label>
                                </div>
                            </div>

                                <div class="text-right" style="margin-top: 4%;">
                                    <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="Ibcancel" ValidationGroup="AddEmployee" OnClick="Ibcancel_Click" Visible="true" class=" fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>  
                                </div>
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
                            <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sr. No.">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Teacher Name" DataField="TeacherName" />
                                    <asp:BoundField HeaderText="Course Name" DataField="CourseName" />
                                    <asp:BoundField HeaderText="Subject Name" DataField="Subject" />
                                    <asp:BoundField HeaderText="Chapter Name" DataField="Chapter" />
                                     <asp:BoundField DataField="Readcourse" HeaderText="Read Course" />
                                    <asp:BoundField DataField="Writecourse" HeaderText="Write Course" />
                                    <asp:BoundField DataField="Allcourse" HeaderText="All Course" />
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
        </div>
    </div>
</asp:Content>

