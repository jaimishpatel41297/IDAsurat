<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Certificate.aspx.cs" Inherits="Certificate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">Certificate</h2>
                </div>
            </div>
        </div>
    </section>
<%--    <section id="content">
        <div class="container">
            <section class="course">
                <div class="row">
                    <asp:Literal runat="server" ID="ltrcer"></asp:Literal>
                </div>
            </section>--%>
 <%--          </div>
    </section>--%>
            <section id="content">
                <div class="container">
                    <div class="row">
                        <div class="skill-home">
                            <div class="skill-home-solid clearfix">
                                <asp:Literal runat="server" ID="ltrcer"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
 
</asp:Content>

