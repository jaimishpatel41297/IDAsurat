<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">About Us</h2>
                </div>
            </div>
        </div>
    </section>
    <section id="content">
        <div class="container">

            <div class="about">

                <div class="row">
                    <div class="col-md-12">
                        <div class="about-logo">
                            <h3>We are Awesome <span class="color">TEAM</span></h3>
                            <p>IDA Surat was established in 2018 to serve the knowledge and skills to the new generation of designers in the field of designing.</p>
                            <p>IDA Surat is the academy which is ISO 9001:2015 certified, which is testimony to the fact to serve quality standard education as per industry with the best in the world.</p>
                        </div>
                    </div>
                </div>
                <br>

                <div class="row">
                    <div class="col-md-6">
                        <img src="img/section-image-1.png" alt="">
                        <div class="space"></div>
                    </div>
                    <div class="col-md-6">
                        <div class="block-heading-two">
                            <h3><span>Why Choose Us?</span></h3>
                        </div>
                        <%--<p>Sed ut perspiciaatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas</p>--%>
                        <ul class="list-unstyled">
                            <li><i class="fa fa-arrow-circle-right pr-10 colored"></i> Industrial internship with training.</li>
                            <br />
                            <li><i class="fa fa-arrow-circle-right pr-10 colored"></i> Excellent curriculum as per industry.</li>
                            <br />
                            <li><i class="fa fa-arrow-circle-right pr-10 colored"></i> 100% focus on practical.</li>
                            <br />
                            <li><i class="fa fa-arrow-circle-right pr-10 colored"></i> Highly qualified faculties from designing.</li>
                            <br />
                            <li><i class="fa fa-arrow-circle-right pr-10 colored"></i> Live projects and practical training.</li>
                        </ul>
                    </div>
                </div>
                <br />
                <hr>
                <br>

                <!-- Our Team starts -->

                <!-- Heading -->
                <div class="block-heading-six">
                    <h3 class="bg-color" style="text-align: center;">Our Team</h3>
                </div>
                <br>

                <!-- Our team starts -->

                <div class="team-six">
                    <div class="row">
                     
                            <div class="col-sm-3 col-sm-3">
                                <!-- Team Member -->
                                <div class="team-member">
                                    <!-- Image -->
                                    <img class="img-responsive"  src="img/team1.jpeg" alt="">
                                    <!-- Name -->
                                    <h4>RADHIKA LALWALA</h4>
                                    <span class="deg"> FASHION DESIGN FACULTY</span>
                                </div>
                            </div>
                            <div class="col-sm-3 col-sm-3">
                                <!-- Team Member -->
                                <div class="team-member">
                                    <!-- Image -->
                                    <img class="img-responsive" src="img/team2.jpg" alt="">
                                    <!-- Name -->
                                    <h4>ADITI JAIN</h4>
                                    <span class="deg">INTERIOR FACULTY</span>
                                </div>
                            </div>
                            <div class="col-sm-3 col-sm-3">
                                <!-- Team Member -->
                                <div class="team-member">
                                    <!-- Image -->
                                    <img class="img-responsive" src="img/team3.jpeg" alt="">
                                    <!-- Name -->
                                    <h4>ZUENA SAIYED</h4>
                                    <span class="deg">MANAGER, INTERIOR DESIGN FACULTY, PROFESSIONAL MAKEUP ARTIST</span>
                                </div>
                            </div>
                           <div class="col-sm-3 col-sm-3">
                                <!-- Team Member -->
                                <div class="team-member">
                                    <!-- Image -->
                                    <img class="img-responsive" src="img/team4.jpg" alt="">
                                    <!-- Name -->
                                    <h4>Malti U Memon</h4>
                                    <span class="deg">FD FACULTY</span>
                                </div>
                            </div>
                        </div>
               
                </div>
                <!-- Our team ends -->
            </div>
        </div>
    </section>
</asp:Content>







