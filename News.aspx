<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">News</h2>
                </div>
            </div>
        </div>
    </section>
    <section id="content">
        <div class="container">
            <div class="about">
                <div class="team-six">
                    <div class="row">
                        <asp:Literal ID="ltrnew" runat="server"></asp:Literal>
                    </div>

                </div>
                <!-- Our team ends -->
            </div>
        </div>
    </section>
</asp:Content>

