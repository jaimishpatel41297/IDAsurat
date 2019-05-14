<%@ Page Title="" EnableEventValidation="true" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="AddInquiry.aspx.cs" Inherits="Admin_AddInquiry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="plugins/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="angular/angular.min.js"></script>

    <script src="angular/InquiryController.js"></script>

    <style type="text/css">
        .left-nav, .right-nav {
            float: left;
        }

        .right-nav {
            margin-left: 20px;
        }

        a {
            cursor: pointer;
        }


        .modal-header {
            text-align: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid" ng-app="Inquiry" ng-controller="InquiryController">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add Inquiry</h4>
            </div>
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="row">
                    <div class="col-md-12" style="margin-left: 30%;">
                        <div class="col-md-4">
                            <label>
                                Customer Name
                            </label>
                        </div>
                    </div>
                    <div class="col-md-12" style="margin-left: 30%;">

                        <div class="col-md-4">
                            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" MaxLength="10" ng-model="SEARCH_USER.MOBILE" placeholder="Search" />
                            <span style="text-align: left;" ng-bind="SEARCH_USER.MNO" hidden></span>
                            <span class="text-left text-danger" ng-bind="SEARCH_USER.MESSAGE"></span>
                        </div>
                        <div class="col-md-4 text-left">
                            <button type="button" class="btn btn-primary btn-sm m-t-10" ng-click="GetSearch(SEARCH_USER)">Search</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
        </div>
        <div class="row">
            <div class="col-md-4 col-sm-12 col-xs-12">
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
                                    Select Course<asp:Label ID="lberror" runat="server" Text="*" ForeColor="Red" Visible="false"></asp:Label>
                                </label>
                                <div>
                                    <asp:DropDownList ID="ddlCourse" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Mobile No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtno" ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtno" runat="server" ValidationGroup="AddEmployee" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtName" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtName" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    DOB
                                  <%--  <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtdob" ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>--%>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtdob" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender3" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdob">
                                    </asp:CalendarExtender>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Email
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtemail" ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtemail" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Discount
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtdis" ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtdis" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="">
                                    Inquiry Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtidate" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtidate" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy-MM-dd" TargetControlID="txtidate">
                                    </asp:CalendarExtender>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="">
                                    Follow Up Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtfdate" ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtfdate" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender2" runat="server" Format="yyyy-MM-dd" TargetControlID="txtfdate">
                                    </asp:CalendarExtender>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Reference By
                                </label>
                                <div>
                                    <div>
                                        <asp:DropDownList ID="ddlref" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Remark
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtdesc" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Select Employee
                                </label>
                                <div>
                                    <asp:DropDownList ID="ddlEmployee" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="text-right">
                                <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click"  CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                                <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddLeauge" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                                <asp:LinkButton runat="server" ValidationGroup="AddEmployee" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect" ID="IbCancel" OnClick="IbCancel_Click">Cancel</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-8 col-lg-8 col-xs-12 col-sm-12">
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
                                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                    <asp:BoundField DataField="Discount" HeaderText="Discount" />
                                    <asp:BoundField DataField="DOB" HeaderText="DOB" DataFormatString="{0 : dd-MM-yyyy}" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" />
                                    <asp:BoundField DataField="InquiryDate" HeaderText="InquiryDate" DataFormatString="{0: dd-MM-yyyy}" />
                                    <asp:BoundField DataField="FollowUpdate" HeaderText="FollowUpdate" DataFormatString="{0: dd-MM-yyyy}" />
                                    <asp:BoundField DataField="CName" HeaderText="Course Name" />
                                    <asp:BoundField DataField="CAmount" HeaderText="Course Fee" />
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

        <div class="modal fade" id="InfoModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Inquiry Detail</h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="modal-body">

                                <ul class="nav nav-tabs tabs customtab">
                                    <li class="active tab"><a href="#Details" data-toggle="tab"><span class="visible-xs"><i class="fa fa-home"></i></span><span class="hidden-xs">Details</span> </a></li>
                                    <li class="tab"><a href="#follow" data-toggle="tab"><span class="visible-xs"><i class="fa fa-user"></i></span><span class="hidden-xs">FollowUp</span> </a></li>
                                    <li class="tab"><a href="#next" data-toggle="tab"><span class="visible-xs"><i class="fa fa-user"></i></span><span class="hidden-xs">Family</span> </a></li>
                                </ul>

                                <div class="tab-content">
                                    <!-- .tabs 1 -->
                                    <div class="tab-pane active" id="Details">
                                        <div class="form-group">
                                            <label>
                                                Course Name :
                                            </label>

                                            <span ng-bind="CName"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Name :
                                            </label>
                                            <span ng-bind="Name"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Dob :
                                            </label>
                                            <span ng-bind="DOB"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Email :
                                            </label>
                                            <span ng-bind="Email"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Mobile No :
                                            </label>

                                            <span ng-bind="Mobile"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Discount :
                                            </label>

                                            <span ng-bind="Discount"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Inquiry Date :
                                            </label>

                                            <span ng-bind="IDate"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Follow Up Date :
                                            </label>

                                            <span ng-bind="FDate"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Reference By :
                                            </label>

                                            <span ng-bind="RName"></span>

                                        </div>
                                    </div>
                                    <div class="tab-pane" id="follow">
                                        <div class="form-group">
                                            <label>
                                                Course Name :
                                            </label>

                                            <span ng-bind="CName"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Name :
                                            </label>
                                            <span ng-bind="Name"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Dob :
                                            </label>
                                            <span ng-bind="DOB"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Email :
                                            </label>
                                            <span ng-bind="Email"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Mobile No :
                                            </label>

                                            <span ng-bind="Mobile"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Discount :
                                            </label>

                                            <span ng-bind="Discount"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Inquiry Date :
                                            </label>

                                            <span ng-bind="IDate"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Follow Up Date :
                                            </label>

                                            <span ng-bind="FDate"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Reference By :
                                            </label>

                                            <span ng-bind="RName"></span>

                                        </div>
                                    </div>
                                    <div class="tab-pane" id="next">
                                        <div class="form-group">
                                            <label>
                                                Course Name :
                                            </label>

                                            <span ng-bind="CName"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Name :
                                            </label>
                                            <span ng-bind="Name"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Mobile No :
                                            </label>

                                            <span ng-bind="Mobile"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Discount :
                                            </label>

                                            <span ng-bind="Discount"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Inquiry Date :
                                            </label>

                                            <span ng-bind="IDate"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Follow Up Date :
                                            </label>

                                            <span ng-bind="FDate"></span>

                                        </div>
                                        <div class="form-group">
                                            <label>
                                                Reference By :
                                            </label>

                                            <span ng-bind="RName"></span>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="modal-footer">
                        <div class="text-right">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

