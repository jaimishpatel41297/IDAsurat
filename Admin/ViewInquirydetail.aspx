<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewInquirydetail.aspx.cs" Inherits="Admin_ViewInquirydetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Showpopups() {
            $('#ReasonModal').modal('show');
        }
    </script>
    <script type="text/javascript">
        function Showpopupss() {
            debugger;
            $('#AcceptModal').modal('show');
        }
    </script>
    <script type="text/javascript">
        function Closepopupss() {
            debugger;
            $('#AcceptModal').modal('hide');
        }
    </script>
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View Inquiry Details</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
                <div class="white-box">

                    <ul class="nav nav-tabs tabs customtab">
                        <li class="active tab"><a href="#pending" data-toggle="tab"><span class="visible-xs"><i class="fa fa-home"></i></span><span class="hidden-xs">Pending</span> </a></li>
                        <%--<li class="tab"><a href="#progress" data-toggle="tab"><span class="visible-xs"><i class="fa fa-user"></i></span><span class="hidden-xs">In Progress</span> </a></li>--%>
                        <li class="tab"><a href="#complete" data-toggle="tab"><span class="visible-xs"><i class="fa fa-user"></i></span><span class="hidden-xs">Closed</span> </a></li>
                    </ul>

                    <div class="tab-content">
                        <!-- .tabs 1 -->
                        <div class="tab-pane active" id="pending">
                            <div class="col-sm-6 col-lg-6 col-xs-12" style="margin-bottom: 30px;">
                                <label for="">
                                    Select Course
                                </label>

                                <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcourse_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                            <table>
                                <tbody>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                            <br />
                            <br />
                            <%-- <h3 class="box-title m-b-0">Data</h3>--%>
                            <div class="row">
                                <div class="col-sm-12 col-xs-12">
                                    <asp:GridView runat="server" ID="gv1" CssClass="table table-striped table-bordered" AutoGenerateColumns="false">
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
                                                    <asp:LinkButton runat="server" ID="lbAccept" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-check btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbAccept_Click"></asp:LinkButton>
                                                    <asp:LinkButton runat="server" ID="lbReject" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbReject_Click"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>

                        <div class="tab-pane" id="complete">
                            <div class="form-group">
                                <label for="">
                                    Select Course
                                </label>
                                <asp:DropDownList ID="ddlcoudel" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcoudel_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                            <table>
                                <tbody>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                            <%-- <h3 class="box-title m-b-0">Data</h3>--%>
                            <div class="row">
                                <div class="col-sm-12 col-xs-12">
                                    <asp:GridView runat="server" ID="gv3" CssClass="table table-striped table-bordered" AutoGenerateColumns="false">
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
            </div>
        </div>
        <div class="modal fade" id="ReasonModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Add Reason Details</h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
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
                            <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect" OnClick="lbCancel_Click">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="AcceptModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Add Fee's Details</h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <div class="modal-body">
                                <%--  <asp:HiddenField ID="hdn_lblIP1" runat="server" Value="0" />--%>
                                <div class="form-group">
                                    <asp:DropDownList ID="ddlFees" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlFees_SelectedIndexChanged" AutoPostBack="true">
                                        <asp:ListItem Text="Select Duration" Value="Select Duration" />
                                        <asp:ListItem Text="Yearly" Value="Yearly" />
                                        <asp:ListItem Text="Half Yearly" Value="Half Yearly" />
                                        <asp:ListItem Text="Quarterly" Value="Quarterly" />
                                        <asp:ListItem Text="Monthly" Value="Monthly" />
                                    </asp:DropDownList>
                                </div>
                                <%--<asp:Panel ID="pnlTextBoxes" runat="server">
                            </asp:Panel>--%>
                                <div class="form-group" id="lb1" runat="server">
                                    <div class="form-group">
                                        <label for="">
                                            Select Payment Method
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="ddlpay" ID="RequiredFieldValidator18" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:DropDownList ID="ddlpay" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlpay_SelectedIndexChanged" AutoPostBack="true">
                                                <asp:ListItem Text="Select Payment Method" />
                                                <asp:ListItem Text="Cash" Value="Cash" />
                                                <asp:ListItem Text="Cheque" Value="Cheque" />
                                                <asp:ListItem Text="Draft" Value="Draft" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div runat="server" id="l" visible="false">
                                        <div class="col-sm-6">
                                            <label for="">
                                                Cheque/Draft No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtp1" ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                            </label>
                                            <div>
                                                <asp:TextBox runat="server" ID="txtp1" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <label for="">
                                                Bank Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtb1" ID="RequiredFieldValidator11" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                            </label>
                                            <div>
                                                <asp:TextBox runat="server" ID="txtb1" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Installment 1
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txti1" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txti1" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdate1" ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txtdate1" CssClass="form-control"></asp:TextBox>
                                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdate1">
                                            </asp:CalendarExtender>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group" id="lb2" runat="server">
                                    <div class="form-group">
                                        <label for="">
                                            Select Payment Method
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="ddlpay2" ID="RequiredFieldValidator19" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:DropDownList ID="ddlpay2" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlpay2_SelectedIndexChanged" AutoPostBack="true">
                                                <asp:ListItem Text="Select Payment Method" />
                                                <asp:ListItem Text="Cash" Value="Cash" />
                                                <asp:ListItem Text="Cheque" Value="Cheque" />
                                                <asp:ListItem Text="Draft" Value="Draft" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div runat="server" id="l1" visible="false">
                                        <div class="col-sm-6">
                                            <label for="">
                                                Cheque/Draft No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtp1" ID="RequiredFieldValidator12" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                            </label>
                                            <div>
                                                <asp:TextBox runat="server" ID="txtp2" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <label for="">
                                                Bank Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtb1" ID="RequiredFieldValidator13" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                            </label>
                                            <div>
                                                <asp:TextBox runat="server" ID="txtb2" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Installment 2
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txti2" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txti2" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdate2" ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txtdate2" CssClass="form-control"></asp:TextBox>
                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdate2">
                                            </asp:CalendarExtender>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group" id="lb3" runat="server">
                                    <div class="form-group">
                                        <label for="">
                                            Select Payment Method
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="ddlpay3" ID="RequiredFieldValidator20" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:DropDownList ID="ddlpay3" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlpay3_SelectedIndexChanged" AutoPostBack="true">
                                                <asp:ListItem Text="Select Payment Method" />
                                                <asp:ListItem Text="Cash" Value="Cash" />
                                                <asp:ListItem Text="Cheque" Value="Cheque" />
                                                <asp:ListItem Text="Draft" Value="Draft" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div runat="server" id="l2" visible="false">
                                        <div class="col-sm-6">
                                            <label for="">
                                                Cheque/Draft No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtp1" ID="RequiredFieldValidator14" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                            </label>
                                            <div>
                                                <asp:TextBox runat="server" ID="txtp3" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <label for="">
                                                Bank Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtb1" ID="RequiredFieldValidator15" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                            </label>
                                            <div>
                                                <asp:TextBox runat="server" ID="txtb3" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Installment 3
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txti1" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txti3" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdate3" ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txtdate3" CssClass="form-control"></asp:TextBox>
                                            <asp:CalendarExtender ID="CalendarExtender4" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdate3">
                                            </asp:CalendarExtender>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group" id="lb4" runat="server">
                                    <div class="form-group">
                                    <label for="">
                                        Select Payment Method
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="ddlpay4" ID="RequiredFieldValidator21" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddlpay4" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlpay4_SelectedIndexChanged" AutoPostBack="true">
                                            <asp:ListItem Text="Select Payment Method"  />
                                            <asp:ListItem Text="Cash" Value="Cash" />
                                            <asp:ListItem Text="Cheque" Value="Cheque" />
                                            <asp:ListItem Text="Draft" Value="Draft" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div runat="server" id="l3" visible="false">
                                    <div class="col-sm-6">
                                        <label for="">
                                            Cheque/Draft No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtp1" ID="RequiredFieldValidator16" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txtp4" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <label for="">
                                            Bank Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtb1" ID="RequiredFieldValidator17" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txtb4" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Installment 4
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txti4" ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txti4" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-sm-6">
                                        <label for="">
                                            Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdate4" ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                        </label>
                                        <div>
                                            <asp:TextBox runat="server" ID="txtdate4" CssClass="form-control"></asp:TextBox>
                                            <asp:CalendarExtender ID="CalendarExtender5" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdate4">
                                            </asp:CalendarExtender>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group" id="Div1" runat="server">
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="modal-footer">
                        <div class="text-right">
                            <asp:LinkButton runat="server" ID="lbSubmitFees" ValidationGroup="text" OnClick="lbSubmitFees_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbCancelFees" OnClick="lbCancelFees_Click" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

