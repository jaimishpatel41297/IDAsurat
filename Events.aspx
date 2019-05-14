<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Events.aspx.cs" Inherits="Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">Events</h2>
                </div>
            </div>
        </div>
    </section>

    <section id="content">
        <div class="container">
        </div>
    </section>

    <%-- <section id="content">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <ul class="portfolio-categ filter">
                        <li class="ga"><a href="#" title="">GARBA</a></li>
                        <li class="ch"><a href="#" title="">CHRISTMAS</a></li>
                        <li class="bl"><a href="#" title="">BLACK DAY</a></li>
                        <li class="bl"><a href="#" title="">BOLLYWOOD THEME</a></li>
                        <li class="ss"><a href="#" title="">SARREE AND SUIT DAY</a></li>
                        <li class="tw"><a href="#" title="">TWIN DAY</a></li>
                        <li class="wo"><a href="#" title="">WOMEN'S DAY</a></li>
                    </ul>
                    <div class="clearfix">
                    </div>
                    <div class="row">
                        <section id="projects">
                            <ul id="thumbs" class="portfolio">
                                <li class="item-thumbs col-lg-4 design" data-id="id-1" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/1.jpg"></a>
                                    <img src="img/event/1.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-2" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/2.jpg"></a>
                                    <img src="img/event/2.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-3" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/3.jpg"></a>
                                    <img src="img/event/3.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-4" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/4.jpg"></a>
                                    <img src="img/event/4.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-5" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/5.jpg"></a>
                                    <img src="img/event/5.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-6" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/6.jpg"></a>
                                    <img src="img/event/6.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-7" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/7.jpg"></a>
                                    <img src="img/event/7.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-8" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/8.jpg"></a>
                                    <img src="img/event/8.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-9" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/9.jpg"></a>
                                    <img src="img/event/9.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-10" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/10.jpg"></a>
                                    <img src="img/event/10.jpg" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-11" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/11.jpg"></a>
                                    <img src="img/event/11.jpg" style="height: 267px; width: 356px" alt="" />
                                </li>
                                <li class="item-thumbs col-lg-4 design" data-id="id-12" data-type="ga">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/12.jpg"></a>
                                    <img src="img/event/12.jpg" style="height: 267px; width: 356px" alt="" />
                                </li>
                                                               
                            </ul>
                        </section>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>

    <%-- <section id="content1">
        <div class="container">
            <h1 class="aligncenter">Garba</h1>
            <div class="row">
                 <div class="col-lg-12">
                    <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/10.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/10.jpg" alt="">
                        </li>
                    </div>
                    <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/9.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/9.jpg" alt="">
                        </li>
                    </div>
                   <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/8.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/8.jpg" alt="">
                        </li>
                    </div>
                    <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/6.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/6.jpg" alt="">
                        </li>
                    </div>
                    <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/2.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/2.jpg" alt="">
                        </li>
                    </div>
                   <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/5.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/5.jpg" alt="">
                        </li>
                    </div>
                     <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/4.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/4.jpg" alt="">
                        </li>
                    </div>
                     <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/3.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/3.jpg" alt="">
                        </li>
                    </div>
                    <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/3.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/3.jpg" alt="">
                        </li>
                    </div>
                      <h1 class="aligncenter">Christmas</h1>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/11.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/11.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/12.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/12.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/13.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/13.jpg" alt="">
                        </li>
                    </div>
                      <h1 class="aligncenter">Days</h1>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/blc1.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/blc1.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/blc2.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/blc2.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/blc3.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/blc3.jpg" alt="">
                        </li>
                    </div>
                     <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/bolly2.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/bolly2.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/bolly1.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/bolly1.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/bolly3.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/bolly3.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/twin2.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/twin2.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/twin1.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/twin1.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/twin3.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/twin3.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/sns2.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/sns2.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/sns1.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/sns1.jpg" alt="">
                        </li>
                    </div>
                      <div class="col-md-4">
                        <li class="item-thumbs col-lg-4 design">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/sns3.jpg"></a>
                            <img style="height: 279px; width: 326px" src="img/event/sns3.jpg" alt="">
                        </li>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <section id="content1">
        <div class="container">
            <h1 class="aligncenter">Garba</h1>
            <div class="row">
                <div class="col-lg-12">
                    <ul id="thumbs" class="portfolio">
                        <div class="row service-v1 margin-bottom-40">
                            <li class="item-thumbs">
                                <div class="col-md-4">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/10.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/10.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/9.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/9.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/8.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/8.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/6.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/6.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/2.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/2.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/5.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/5.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/4.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/4.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/3.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/3.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/7.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/7.jpg" alt="">
                                </div>
                                <h1 class="aligncenter">Christmas</h1>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/12.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/12.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/13.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/13.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/11.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/11.jpg" alt="">
                                </div>
                                <h1 class="aligncenter">Days</h1>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/blc1.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/blc1.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/blc2.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/blc2.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/blc3.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/blc3.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/bolly2.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/bolly2.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/bolly1.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/bolly1.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/bolly3.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/bolly3.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/twin2.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/twin2.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/twin1.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/twin1.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/twin3.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/twin3.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/sns2.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/sns2.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/sns1.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/sns1.jpg" alt="">
                                </div>
                                <div class="col-md-4 md-margin-bottom-40">
                                    <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Event" href="img/event/sns3.jpg"></a>
                                    <img style="height: 265px; width: 360px" src="img/event/sns3.jpg" alt="">
                                </div>
                            </li>
                        </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

