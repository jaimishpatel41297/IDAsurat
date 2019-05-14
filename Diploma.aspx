<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Diploma.aspx.cs" Inherits="Diploma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">Diploma</h2>
                </div>
            </div>
        </div>
    </section>


    <section id="content">
        <div class="container">
            <div class="row">
                <div class="skill-home">
                    <div class="skill-home-solid clearfix">
                        <asp:Literal runat="server" ID="ltrdip"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>

