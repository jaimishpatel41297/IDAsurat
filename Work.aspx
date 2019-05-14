<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Work.aspx.cs" Inherits="Work" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">Student Work</h2>
                </div>
            </div>
        </div>
    </section>

    <%--<section id="content">
        <div class="container">
            <div class="row service-v1 margin-bottom-40">
                <div class="col-md-4 md-margin-bottom-40">
                    <img class="img-responsive" src="img/service1.jpg" alt="">
                    <h3>Web Development</h3>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident, doloribus omnis minus temporibus perferendis nesciunt quam repellendus nulla nemo ipsum odit corrupti consequuntur possimus</p>
     </div>
                <div class="col-md-4">
                    <img class="img-responsive" src="img/service2.jpg" alt="">
    <h3>Mobile Development</h3>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident, doloribus omnis minus temporibus perferendis nesciunt quam repellendus nulla nemo ipsum odit corrupti consequuntur possimus</p>
     </div>
                <div class="col-md-4 md-margin-bottom-40">
                    <img class="img-responsive" src="img/service3.jpg" alt="">
    <h3>Responsive Design</h3>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident, doloribus omnis minus temporibus perferendis nesciunt quam repellendus nulla nemo ipsum odit corrupti consequuntur possimus</p>
        </div>
            </div>
        </div>
     </section>--%>
    <section id="content1">
        <div class="container">
            <br />
            <h1 class="aligncenter"></h1>
            <br />
            <div class="row">
                <div class="col-lg-12">
                    <ul id="thumbs" class="portfolio">
                        <div class="row service-v1 margin-bottom-40">
                            <li class="item-thumbs">
                                <div class="col-md-4">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Student Work" href="img/works/g17.jpeg"></a>
                                    <img style="height: 279px; width: 326px" src="img/gallary/g17.jpeg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Student Work" href="img/Works/g18.jpeg"></a>
                                    <img style="height: 279px; width: 326px" src="img/gallary/g18.jpeg" alt="">
                                </div>
                            </li>
                        </div>
                    </ul>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

