<%@ Page Title="" EnableEventValidation="true" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">Register</h2>
                </div>
            </div>
        </div>
    </section>

    <section id="content">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <br>
                    <div class="alert alert-success hidden" runat="server" visible="false" id="contactSuccess">
                        <strong>Success!</strong> Your message has been sent to us.
                    </div>
                    <div class="alert alert-error hidden" runat="server" visible="false" id="contactError">
                        <strong>Error!</strong> There was an error sending your message.
                    </div>
                    <div class="contact-form">
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="name">
                                    Surname 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSurname" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtSurname" runat="server" ValidationGroup="form" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="email">
                                    Name 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">
                                    Father Name
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtfname" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtfname" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">
                                    Date of Birth 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtdob" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtdob" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender3" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdob"></asp:CalendarExtender>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">
                                    Mobile 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtmobile" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtmobile" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">
                                    Email Address 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtemail" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="message">Academic Level</label><label id="lbAcademic" runat="server" visible="false">*</label>
                                <asp:DropDownList ID="ddlaca" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="Select Academic Level" Value=""></asp:ListItem>
                                    <asp:ListItem Text="10th or Equivalent" Value="10th or Equivalent"></asp:ListItem>
                                    <asp:ListItem Text="12th or Equivalent" Value="12th or Equivalent"></asp:ListItem>
                                    <asp:ListItem Text="Graduation" Value="Graduation"></asp:ListItem>
                                    <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
                                    <asp:ListItem Text="Post Graduation" Value="Post Graduation"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Marital Status</label>
                                <asp:TextBox ID="txtmar" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Gender</label>
                                <asp:RadioButtonList ID="rbGender" runat="server">
                                    <asp:ListItem Value="Male">Male</asp:ListItem>
                                    <asp:ListItem Value="Female">Female</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Blood Group</label>
                                <asp:DropDownList ID="ddlBlood" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="Select Blood Group" Value=""></asp:ListItem>
                                    <asp:ListItem Text="A +ve" Value="A +ve"></asp:ListItem>
                                    <asp:ListItem Text="A -ve" Value="A -ve"></asp:ListItem>
                                    <asp:ListItem Text="AB +ve" Value="AB +ve"></asp:ListItem>
                                    <asp:ListItem Text="AB -ve" Value="AB -ve"></asp:ListItem>
                                    <asp:ListItem Text="B +ve" Value="B +ve"></asp:ListItem>
                                    <asp:ListItem Text="B -ve" Value="B -ve"></asp:ListItem>
                                    <asp:ListItem Text="O +ve" Value="O +ve"></asp:ListItem>
                                    <asp:ListItem Text="O -ve" Value="O -ve"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Nationality</label>
                                <asp:DropDownList ID="ddlNationality" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="India" Value="India"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">
                                    Address
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtadd" ValidationGroup="form" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></label>
                                <asp:TextBox ID="txtadd" runat="server" ValidationGroup="form" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">State</label><label id="lbState" runat="server" visible="false">*</label>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">City</label><label id="lbCity" runat="server" visible="false">*</label>
                                <asp:DropDownList ID="ddlcity" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">District</label>
                                <asp:TextBox ID="txtdisct" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Pincode</label>
                                <asp:TextBox ID="txtpin" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Course Category</label><label id="lbCourseCate" runat="server" visible="false">*</label>
                                <asp:DropDownList ID="ddlCourseCat" runat="server" OnSelectedIndexChanged="ddlCourseCat_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Course</label><label id="lbCourse" runat="server" visible="false">*</label>
                                <asp:DropDownList ID="ddlCourse" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group has-feedback">
                                <label for="subject">Remarks</label>
                                <asp:TextBox ID="txtremark" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <asp:LinkButton ID="IbSubmit" runat="server" ValidationGroup="form" OnClick="IbSubmit_Click" class="btn btn-default">Submit</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

