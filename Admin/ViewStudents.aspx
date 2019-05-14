<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="ViewStudents.aspx.cs" Inherits="Admin_ViewFollowup" %>

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
                <h4 class="page-title">View Student's</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
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
                <div class="row">
                    <div class="col-sm-6 col-lg-6 col-xs-12">
                        <div class="form-group">
                            <label for="">
                                Select Course
                            </label>
                            <div>
                                <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcourse_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
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
                                <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                <asp:BoundField DataField="Discount" HeaderText="Discount" />
                                <asp:BoundField DataField="AdmissionDate" HeaderText="Admission Date" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="CName" HeaderText="Course Name" />
                                <asp:BoundField DataField="DOB" HeaderText="Date Of Birth" DataFormatString="{0: dd-MM-yyyy}" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Amount" HeaderText="Course Fee" />
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="lbEdit" CssClass="btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-info" CommandArgument='<%# Eval("Id") %>' OnClick="lbEdit_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="IbEdit1" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-edit btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="IbEdit1_Click"></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbDelete" OnClientClick="return confirm('Are You Sure Want To Delete ?')" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
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
                        <h4 class="modal-title">Add User</h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label for="">
                                        Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtname" ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
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
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdiscount" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtdiscount" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="">
                                        Admission Date:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtadmdate" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtadmdate" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                        <asp:CalendarExtender ID="CalendarExtender3" runat="server" Format="yyyy-MM-dd" TargetControlID="txtadmdate">
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
                                        <asp:DropDownList ID="ddlcourse1" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlcourse1_SelectedIndexChanged" Style="width: 100%;">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <%--  <div class="form-group">
                                <label for="">
                                   Course Name:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtcrsname" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtcrsname" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>--%>
                                <div class="form-group">
                                    <label for="">
                                        Date of Birth:
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddDetails" ControlToValidate="txtdob" ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtdob" runat="server" ValidationGroup="AddDetails" CssClass="form-control"></asp:TextBox>
                                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdob">
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
                            <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddDetails" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="Ibeditcancel" data-dismiss="modal" OnClick="Ibeditcancel_Click" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="ReasonModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" role="document">
                <div class="modal-content" style="height: 738px; width: 555px; margin-left: 6%;">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Fee's Details</h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                           <ContentTemplate>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label for="">
                                        No of Installment :
                                    </label>
                                    <asp:Label ID="lbInst" runat="server"></asp:Label>
                                </div>
                                <div class="form-group col-lg-12" id="Div1" runat="server" visible="false">
                                     <div class="col-lg-4">
                                        <label for="">
                                            Installment 1
                                        </label>

                                        <div>
                                            <asp:Label ID="lbf1" runat="server"></asp:Label>
                                        </div>
                                        <div>
                                            <asp:Label ID="lbfDate1" runat="server"></asp:Label>
                                        </div>
                                        <div>
                                            <asp:Label ID="lblpay" runat="server"></asp:Label>
                                        </div>
                                        <div runat="server" visible="false" id="f1">
                                            <div>
                                                <asp:Label ID="lblnum" runat="server"></asp:Label>
                                            </div>
                                            <asp:Label ID="lblnam" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                     <div class="col-lg-4">
                                        <label for="">
                                            Remained Fees
                                        </label>
                                        <div>
                                            <asp:Label ID="ltramt" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <label for="">
                                            Print Installment 1 Receipt
                                        </label>
                                        <%--  <a title="ICard" target="_blank" href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=<%# Eval("Id") %>' class="btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt"></a>--%>
                                        <asp:Literal ID="ltrre1" runat="server"></asp:Literal>
                                    </div>
                                </div>
                                <div class="form-group col-lg-12" id="Div2" runat="server" visible="false">
                                    <div class="col-lg-4">
                                        <label for="">
                                            Installment 2
                                        </label>
                                        <div>
                                            <asp:Label ID="lbf2" runat="server"></asp:Label>
                                        </div>
                                        <asp:Label ID="lbfDate2" runat="server"></asp:Label>
                                        <div>
                                            <asp:Label ID="lblpay2" runat="server"></asp:Label>
                                        </div>
                                        <div>
                                            <div runat="server" visible="false" id="f2">
                                                <asp:Label ID="lblnum2" runat="server"></asp:Label>
                                            </div>
                                            <asp:Label ID="lblnam2" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                     <div class="col-lg-4">
                                        <label for="">
                                            Remained Fees
                                        </label>
                                        <div>
                                            <asp:Label ID="ltramt2" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                     <div class="col-lg-4">
                                        <label for="">
                                            Print Installment 2 Receipt
                                        </label>
                                        <asp:Label ID="ltrre2" runat="server"></asp:Label>
                                        <%--  <a title="ICard" target="_blank" href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=<%# Eval("Id") %>' class="btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt"></a>--%>
                                    </div>
                                </div>
                                <div class="form-group col-lg-12" id="Div3" runat="server" visible="false">
                                     <div class="col-lg-4">
                                        <label for="">
                                            Installment 3
                                        </label>
                                        <div>
                                            <asp:Label ID="lbf3" runat="server"></asp:Label>
                                        </div>
                                        <asp:Label ID="lbfDate3" runat="server"></asp:Label>

                                        <div>
                                            <asp:Label ID="lblpay3" runat="server"></asp:Label>
                                        </div>
                                        <div>
                                            <div runat="server" visible="false" id="f3">
                                                <asp:Label ID="lblnum3" runat="server"></asp:Label>
                                            </div>
                                            <asp:Label ID="lblnam3" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                     <div class="col-lg-4">
                                        <label for="">
                                            Remained Fees
                                        </label>
                                        <div>
                                            <asp:Label ID="ltramt3" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <label for="">
                                            Print Installment 3 Receipt
                                        </label>
                                        <asp:Label ID="ltrre3" runat="server"></asp:Label>
                                        <%-- <a title="ICard" target="_blank" href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=<%# Eval("Id") %>' class="btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt"></a>--%>
                                    </div>
                                </div>
                                <div class="form-group col-lg-12" id="Div4" runat="server" visible="false">
                                     <div class="col-lg-4">
                                        <label for="">
                                            Installment 4
                                        </label>
                                        <div>
                                            <asp:Label ID="lbf4" runat="server"></asp:Label>
                                        </div>
                                        <asp:Label ID="lbfDate4" runat="server"></asp:Label>
                                        <div>
                                            <asp:Label ID="lblpay4" runat="server"></asp:Label>
                                        </div>
                                        <div runat="server" visible="false" id="f4">
                                            <div>
                                                <asp:Label ID="lblnum4" runat="server"></asp:Label>
                                            </div>
                                            <asp:Label ID="lblnam4" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                     <div class="col-lg-4">
                                        <label for="">
                                            Remained Fees
                                        </label>
                                        <div>
                                            <asp:Label ID="ltramt4" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <label for="">
                                            Print Installment 4 Receipt
                                        </label>
                                        <asp:Label ID="ltrre4" runat="server"></asp:Label>
                                        <%--<a title="ICard" target="_blank" href='./Idareceipt/Feereceipt.aspx?Report_Name=FeesReceipt&ID=<%# Eval("Id") %>' class="btn-outline btn btn-info btn-circle waves-effect btn-sm fa fa-credit-card-alt"></a>--%>
                                    </div>
                                </div>
                                <%--    <div class="form-group">
                                    <div id="Div5" runat="server" visible="false" style="margin-right: 66%; margin-left: 1%;">
                                        <label for="">
                                            Amount
                                        </label>
                                    </div>
                                    <div id="Div6" runat="server" visible="false">
                                        <asp:TextBox ID="txtAmount" runat="server"  CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>--%>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="text-right">
                        <div class="modal-footer" style="margin-top: 120px;">
                            <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddDetails" OnClick="lbSubmit_Click"></asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" OnClick="lbCancel_Click1"></asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

