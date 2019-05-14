<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="ViewFollowup.aspx.cs" Inherits="Admin_ViewFollowup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <script type="text/javascript">
        function Showpopups() {
            $('#ReasonModal').modal('show');
        }
        function ShowpopupUser() {
            debugger;
            $('#UserModal').modal('show');
        }
    </script>
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View folllowup</h4>
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
                                <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                <asp:BoundField DataField="Discount" HeaderText="Discount" />
                                <asp:BoundField DataField="InquiryDate" HeaderText="InquiryDate" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="FollowUpdate" HeaderText="FollowUpdate" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="CName" HeaderText="Course Name" />
                                <asp:BoundField DataField="DOB" HeaderText="DOB" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="Amount" HeaderText="Course Fee" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="RName" HeaderText="Reference By" />
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                         <asp:LinkButton runat="server" ID="lbEdit" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-edit btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbEdit_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbAccept" CommandArgument='<%# Eval("Id") %>' OnClick="lbAccept_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbReject" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbReject_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="ReasonModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Add Reason Details</h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label for="">
                                        Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtpdate" ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox runat="server" ID="txtpdate" CssClass="form-control"></asp:TextBox>
                                        <asp:CalendarExtender ID="CalendarExtender3" runat="server" Format="yyyy-MM-dd" TargetControlID="txtpdate">
                                        </asp:CalendarExtender>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="">
                                        Reason Description
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtpdesc" ID="RequiredFieldValidator32" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox runat="server" ID="txtpdesc" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="modal-footer">
                        <div class="text-right">
                            <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddDetails" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
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
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtname" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtname" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Mobile No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtmobno" ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtmobno" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="">
                                    Discount:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdiscount" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtdiscount" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="">
                                    Inquiry Date:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtadmdate" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtadmdate" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy-MM-dd" TargetControlID="txtadmdate">
                                    </asp:CalendarExtender>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    FollowUp Date:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtfollow" ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtfollow" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender4" runat="server" Format="yyyy-MM-dd" TargetControlID="txtadmdate">
                                    </asp:CalendarExtender>
                                </div>
                            </div>
                            <div class="form-group" style="margin-bottom: 40px;">
                                <label for="">
                                    Course
                                     <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="ddlcourse1" ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                     </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:DropDownList ID="ddlcourse1" runat="server" CssClass="form-control" Style="width: 100%;">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Date of Birth:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdob" ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtdob" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender2" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdob">
                                    </asp:CalendarExtender>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="">
                                    Email:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtemail" ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtemail" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="modal-footer" style="margin-top: 70px;">
                    <div class="text-right">

                        <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddDetails" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>' causesvalidation="false">Update</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="Ibeditcancel" data-dismiss="modal" OnClick="Ibeditcancel_Click" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

