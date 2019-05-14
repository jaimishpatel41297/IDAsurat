<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="inner-headline">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="pageTitle">Contact Us</h2>
                </div>
            </div>
        </div>
    </section>
    <section id="content">

        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3129.0814706937986!2d72.78806837113343!3d21.147385439140827!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x6b104820fa51b3c5!2sIDA+SURAT!5e0!3m2!1sen!2sin!4v1553852805556!5m2!1sen!2sin" width="100%" height="450" frameborder="0" style="border: 0" allowfullscreen></iframe>
                </div>
            </div>


            <div class="row">
                <div class="col-md-6">
                    <br>
                    <div class="alert alert-success hidden" id="contactSuccess">
                        <strong>Success!</strong> Your message has been sent to us.
                    </div>
                    <div class="alert alert-error hidden" id="contactError">
                        <strong>Error!</strong> There was an error sending your message.
                    </div>
                    <div class="contact-form">
                        <div class="form-group has-feedback">
                            <label for="name">Name*</label>
                            <input type="text" class="form-control" id="name" name="name" placeholder="">
                            <i class="fa fa-user form-control-feedback"></i>
                        </div>
                        <div class="form-group has-feedback">
                            <label for="email">Email*</label>
                            <input type="email" class="form-control" id="email" name="email" placeholder="">
                            <i class="fa fa-envelope form-control-feedback"></i>
                        </div>
                        <div class="form-group has-feedback">
                            <label for="subject">Subject*</label>
                            <input type="text" class="form-control" id="subject" name="subject" placeholder="">
                            <i class="fa fa-navicon form-control-feedback"></i>
                        </div>
                        <div class="form-group has-feedback">
                            <label for="message">Message*</label>
                            <textarea class="form-control" rows="6" id="message" name="message" placeholder=""></textarea>
                            <i class="fa fa-pencil form-control-feedback"></i>
                        </div>
                        <input type="submit" value="Submit" class="btn btn-default">
                    </div>
                </div>
                <div class="col-md-6">

                    <div class="span4">
                        <div class="title-box clearfix ">
                            <h3 class="title-box_primary">Contact info</h3>
                        </div>
                        <%--<h5>Lorem ipsum dolor sit amet, cadipisicing sit amet, consectetur adipisicing elit. Atque sed, quidem quis praesentium.</h5>
                        <p>
                            Lorem ipsum dolor sit amet, cadipisicing sit amet, consectetur adipisicing elit. Lorem ipsum dolor sit amet, cadipisicing sit amet, consectetur adipisicing elit. Atque sed, quidem quis praesentium Atque sed, quidem quis praesentium, ut unde fuga error commodi architecto, laudantium culpa tenetur at id, beatae pet.<br>
                        </p>--%>
                        <address>
                            <strong>Above company Inc</strong><br>
                            424, J-9 High Street,<br>
                            Canal Road,<br>
                            Nr. Dream World 
                                    <br>
                            Vesu Surat.
                        </address>
                        <strong>NARESH </strong>
                        <br />
                        <p>
                            <i class="icon-phone"></i>(M):97243 23535
                                <br>
                            <i class="icon-envelope-alt"></i>(Whatsapp  No) : 9687353535 | 83200 378 25
                        </p>
                    </div>
                </div>
            </div>
        </div>

    </section>
</asp:Content>

