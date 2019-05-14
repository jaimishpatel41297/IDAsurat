<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta charset="utf-8">
    <title>Above Multi-purpose Free Bootstrap Responsive Template</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="http://webthemez.com/" />
    <!-- css -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/fancybox/jquery.fancybox.css" rel="stylesheet">
    <link href="css/jcarousel.html" rel="stylesheet" />
    <link href="css/flexslider.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="featured">
        <!-- Slider -->
        <div id="main-slider" class="flexslider">
            <ul class="slides">
                <li>
                    <img src="img/slides/1.jpg" alt="" />
                    <div class="flex-caption">
                        <div class="item_introtext">
                            <%--<strong>Diploma In Interior Designing</strong>--%>
                            <!--<p>The best educational template</p>-->
                        </div>
                    </div>
                </li>
                <li>
                    <img src="img/slides/2.jpg" alt="" />
                    <div class="flex-caption">
                        <div class="item_introtext">
                            <%-- <strong>Interior Course</strong>--%>
                            <!--<p>Get all courses with on-line content</p>-->
                        </div>
                    </div>
                </li>
                <li>
                    <img src="img/slides/3.jpg" alt="" />
                    <div class="flex-caption">
                        <div class="item_introtext">
                            <%-- <strong>Professional Makeup Artist</strong>--%>
                            <!--<p>Awesome Template get it know</p>-->
                        </div>
                    </div>
                </li>
            </ul>
        </div>
        <!-- end slider -->
    </section>

    <section class="callaction">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="aligncenter">
                        <h1 class="aligncenter">Our Featured Courses</h1>
                        <%--<span class="clear spacer_responsive_hide_mobile " style="height: 13px; display: block;"></span>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident, doloribus omnis minus temporibus perferendis nesciunt quam repellendus nulla nemo ipsum odit corrupti consequuntur possimus, vero mollitia velit ad consectetur. Alias, laborum excepturi nihil autem nemo numquam, ipsa architecto non, magni consequuntur quam.</div>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Important course contain -->
    <%-- <section id="content">
        <div class="container">
            <div class="row">--%>
    <%-- <ul class="nav nav-tabs tabs customtab">
                    <li class="active tab"><a href="#pending" data-toggle="tab"><span class="visible-xs"><i class="fa fa-home"></i></span><span class="hidden-xs">Diploma</span> </a></li>
                    <li class="tab"><a href="#complete" data-toggle="tab"><span class="visible-xs"><i class="fa fa-user"></i></span><span class="hidden-xs">Certificated</span> </a></li>
                </ul>
                   <div class="tab-content">--%>
    <!-- .tabs 1 -->
    <%--<div class="tab-pane active" id="pending">    --%>
    <%--   <div class="col-sm-6 col-lg-6 col-xs-12" style="margin-bottom: 30px;">
                                <label for="">
                                    Select Course
                                </label>

                                <asp:DropDownList ID="ddlcourse" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcourse_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>--%>
    <%--<table>
                                <tbody>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                            <br />
                            <br />--%>
    <%-- <h3 class="box-title m-b-0">Data</h3>--%>
    <%--   <div class="row">
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
                            </div>--%>
    <%--</div>

                        <div class="tab-pane" id="complete">--%>

    <%--<div class="form-group">
                                <label for="">
                                    Select Course
                                </label>
                                <asp:DropDownList ID="ddlcoudel" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcoudel_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>--%>
    <%--   <table>
                                <tbody>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>--%>
    <%-- <h3 class="box-title m-b-0">Data</h3>--%>
    <%--       <div class="row">
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
                            </div>--%>
    <%--  </div>
                    </div>--%>
    <%--        <div class="skill-home">
                    <div class="skill-home-solid clearfix">
                        <div class="col-md-3 text-center">
                            <span class="icons c1"><i class="fa fa-trophy"></i></span>
                            <div class="box-area">
                                <h3>Diploma In Interior Designing</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident</p>
                            </div>
                        </div>
                        <div class="col-md-3 text-center">
                            <span class="icons c2"><i class="fa fa-picture-o"></i></span>
                            <div class="box-area">
                                <h3>Professional Makeup Artist</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident</p>
                            </div>
                        </div>
                        <div class="col-md-3 text-center">
                            <span class="icons c3"><i class="fa fa-desktop"></i></span>
                            <div class="box-area">
                                <h3>Interior Course</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident</p>
                            </div>
                        </div>
                        <div class="col-md-3 text-center">
                            <span class="icons c4"><i class="fa fa-globe"></i></span>
                            <div class="box-area">
                                <h3>Personality Development</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam, incidunt eius magni provident</p>
                            </div>
                        </div>
                    </div>
                </div>--%>
    <%--       </div>
        </div>
    </section>--%>

    <section id="content">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <ul class="portfolio-categ filter" style="margin-left: 35%; margin-top: -6%;">
                        <li class="web"><a href="#" title="">Diploma Course</a></li>
                        <li class="icon"><a href="#" title="">Certificated Course</a></li>
                    </ul>
                    <div class="clearfix">
                    </div>
                    <div class="row">
                        <section id="projects">
                            <ul id="thumbs" class="portfolio">
                                <!-- Item Project and Filter Name -->

                                <asp:Literal ID="ltrdip" runat="server"></asp:Literal>

                                <!-- End Item Project -->


                                <asp:Literal ID="ltrcer" runat="server"></asp:Literal>

                                <!-- End Item Project -->

                                <%--                                <li class="item-thumbs col-lg-3 photography" data-id="id-4" data-type="icon">
                                    <h6 class="aligncenter">Degree Computer Course</h6>
                                    <img src="img/works/5.jpg" alt=""/>
                                </li>
                                <!-- End Item Project -->

                                <li class="item-thumbs col-lg-3 design" data-id="id-0" data-type="icon">
                                    <h6 class="aligncenter">Degree Chemical Course</h6>
                                    <img src="img/works/7.jpg" alt=""/>
                                </li>--%>
                                <!-- End Item Project -->
                            </ul>
                        </section>
                    </div>
                </div>
            </div>
        </div>
    </section>


    <div class="testimonial-area">
        <div class="testimonial-solid">
            <div class="container">
                <div class="testi-icon-area">
                    <div class="quote">
                        <i class="fa fa-microphone"></i>
                    </div>
                </div>
                <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carousel-example-generic" data-slide-to="0" class="">
                            <a href="#"></a>
                        </li>
                        <li data-target="#carousel-example-generic" data-slide-to="1" class="">
                            <a href="#"></a>
                        </li>
                        <li data-target="#carousel-example-generic" data-slide-to="2" class="active">
                            <a href="#"></a>
                        </li>
                        <li data-target="#carousel-example-generic" data-slide-to="3" class="">
                            <a href="#"></a>
                        </li>
                    </ol>
                    <div class="carousel-inner">
                        <div class="item">
                            <p>Blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi.</p>
                            <p>
                                <b>- Mark John -</b>
                            </p>
                        </div>
                        <div class="item">
                            <p>Blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi.</p>
                            <p>
                                <b>- Jaison Warner -</b>
                            </p>
                        </div>
                        <div class="item active">
                            <p>Blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi.</p>
                            <p>
                                <b>- Tony Antonio -</b>
                            </p>
                        </div>
                        <div class="item">
                            <p>Blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi.</p>
                            <p>
                                <b>- Leena Doe -</b>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <section id="content4">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="aligncenter">
                        <h2 class="aligncenter">Infrastructure</h1><span class="clear spacer_responsive_hide_mobile " style="height: 13px; display: block;"></span>
                    </div>
                </div>
            </div>
            <div class="row service-v1 margin-bottom-40">
                <div class="col-md-12 md-margin-bottom-40">
                    <%--<img class="img-responsive" src="img/service1.jpg" alt="" style="width: 100%; height: 350px;">--%>

                    <img class="img-responsive" src="img/service5.jpg" alt="" style="width: 100%">
                </div>
            </div>
            <ul id="thumbs" class="portfolio">
                <div class="row service-v1 margin-bottom-40">
                    <li class="item-thumbs">
                        <div class="col-md-4">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service2.jpeg"></a>
                            <img class="img-responsive" src="img/service2.jpeg" alt="">
                        </div>
                        <div class="col-md-4 md-margin-bottom-40">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service8.jpg"></a>
                            <img class="img-responsive" src="img/service8.jpg" alt="">
                        </div>
                        <div class="col-md-4 md-margin-bottom-40">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service3.jpeg"></a>
                            <img class="img-responsive" src="img/service3.jpeg" alt="">
                        </div>
                    </li>
                </div>

                <div class="row service-v1 margin-bottom-40">
                    <li class="item-thumbs">
                        <div class="col-md-4 md-margin-bottom-40">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service1.jpeg"></a>
                            <img class="img-responsive" src="img/service1.jpeg" alt="">
                        </div>
                        <div class="col-md-4">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service6.jpg"></a>
                            <img class="img-responsive" src="img/service6.jpg" alt="">
                        </div>
                        <div class="col-md-4 md-margin-bottom-40">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service7.jpg"></a>
                            <img class="img-responsive" src="img/service7.jpg" alt="">
                        </div>
                    </li>
                </div>
                <div class="row service-v1 margin-bottom-40">
                    <li class="item-thumbs">
                        <div class="col-md-4 md-margin-bottom-40">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service4.jpeg"></a>
                            <img class="img-responsive" src="img/service4.jpeg" alt="">
                        </div>
                        <div class="col-md-4 md-margin-bottom-40"style="height: 237.55px;">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service5.jpg"></a>
                            <img class="img-responsive" src="img/service5.jpg" alt="">
                        </div>
                        <div class="col-md-4">
                            <a class="hover-wrap fancybox" data-fancybox-group="gallery" title="Infrastructure" href="img/service9.jpg"></a>
                            <img class="img-responsive" src="img/service9.jpg" alt="">
                        </div>
                    </li>
                </div>
            </ul>
        </div>
    </section>

    <section class="courses">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="aligncenter">
                        <a href="News.aspx">
                            <h2 class="aligncenter">News</h2>
                            <span class="clear spacer_responsive_hide_mobile " style="height: 13px; display: block;"></span></a>
                    </div>
                </div>
            </div>
            <%--            <div class="row">
                <div class="col-md-4">
                    <div class="textbox">
                        <h3>News Header</h3>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vest sit amet, consec ibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="textbox">
                        <h3>News Header</h3>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vest sit amet, consec ibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="textbox">
                        <h3>News Header</h3>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vest sit amet, consec ibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta.</p>
                    </div>
                </div>
            </div>--%>
            <%--            <div class="row">
                <div class="col-md-4">
                    <div class="textbox">
                        <h3>News Header</h3>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vest sit amet, consec ibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="textbox">
                        <h3>News Header</h3>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vest sit amet, consec ibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="textbox">
                        <h3>News Header</h3>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vest sit amet, consec ibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta.</p>
                    </div>
                </div>
            </div>--%>
        </div>
    </section>
</asp:Content>

