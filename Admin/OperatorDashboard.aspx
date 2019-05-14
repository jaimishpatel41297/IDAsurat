<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/OperatorMaster.master" AutoEventWireup="true" CodeFile="OperatorDashboard.aspx.cs" Inherits="cp_sms_Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Dashboard</h4>
            </div>
        </div>

        <div class="col-lg-12 col-sm-12 col-xs-12">
            <div class="row">
                <a href="Viewinquirrydetailuser.aspx">
                    <div class="col-lg-5 col-sm-5 col-xs-12">
                        <div class="white-box">
                            <h3 class="box-title">Today's Inquiry</h3>
                            <ul class="list-inline two-part">
                                <asp:Literal runat="server" ID="ltrInquiry"></asp:Literal>
                            </ul>
                        </div>
                    </div>
                </a>
                <a href="ViewFollowup.aspx">
                    <div class="col-lg-5 col-sm-4 col-xs-12">
                        <div class="white-box">
                            <h3 class="box-title">Today' FollowUp</h3>
                            <ul class="list-inline two-part">
                                <asp:Literal runat="server" ID="ltrfollowup"></asp:Literal>
                            </ul>
                        </div>
                    </div>
                </a>
            </div>
        </div>

        <div class="row" style="display: none;">
            <div class="col-md-12">
                <div class="white-box">
                    <h3 class="box-title">Recently Registered Users</h3>
                    <div class="table-responsive">
                        <section class="m-b-40">
                            <div class="sttabs tabs-style-bar">
                                <nav>
                                    <ul>
                                        <li><a href="#user" class="sticon ti-home"><span>Users</span></a></li>
                                        <li><a href="#reseller" class="sticon ti-gift"><span>Resseller</span></a></li>
                                    </ul>
                                </nav>
                                <div class="content-wrap text-center">
                                    <section id="user">
                                        <%--<h3>Best Clean Tab ever</h3>--%>
                                        <table class="table table-striped">
                                            <thead>
                                                <tr>
                                                    <th>User Id</th>
                                                    <th>Name</th>
                                                    <th>Email</th>
                                                    <th>Mobile</th>
                                                    <th>Login Type</th>
                                                    <th>Date</th>
                                                    <th>Status</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <asp:ListView runat="server" ID="lvData">
                                                    <ItemTemplate>
                                                        <tr class="text-left">
                                                            <td><%# Eval("ID") %></td>
                                                            <td><%# Eval("NAME") %></td>
                                                            <td><%# Eval("EMAIL") %></td>
                                                            <td><%# Eval("MOBILENO") %></td>
                                                            <td><%# Eval("LOGIN_TYPE") %></td>
                                                            <td><span class="text-muted"><i class="fa fa-clock-o"></i>&nbsp;<%# Eval("DATE") %></span></td>
                                                            <td class="">
                                                                <div class='label label-table label-<%# Eval("STATUSCLASS") %>'><%# Eval("USERSTATUS") %></div>
                                                            </td>

                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:ListView>

                                            </tbody>
                                        </table>


                                    </section>
                                    <section id="reseller">
                                        <table class="table table-striped">
                                            <thead>
                                                <tr>
                                                    <th>User Id</th>
                                                    <th>Name</th>
                                                    <th>Email</th>
                                                    <th>Mobile</th>
                                                    <th>Login Type</th>
                                                    <th>Date</th>
                                                    <th>Status</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <asp:ListView runat="server" ID="lvDataResseler">
                                                    <ItemTemplate>
                                                        <tr class="text-left">
                                                            <td><%# Eval("ID") %></td>
                                                            <td><%# Eval("NAME") %></td>
                                                            <td><%# Eval("EMAIL") %></td>
                                                            <td><%# Eval("MOBILENO") %></td>
                                                            <td><%# Eval("LOGIN_TYPE") %></td>
                                                            <td><span class="text-muted"><i class="fa fa-clock-o"></i>&nbsp;<%# Eval("DATE") %></span></td>
                                                            <td class="">
                                                                <div class='label label-table label-<%# Eval("STATUSCLASS") %>'><%# Eval("USERSTATUS") %></div>
                                                            </td>

                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:ListView>

                                            </tbody>
                                        </table>
                                    </section>

                                </div>
                                <!-- /content -->
                            </div>
                            <!-- /tabs -->
                        </section>
                    </div>
                </div>
            </div>
        </div>
        <!-- .right-sidebar -->
        <div class="right-sidebar">
            <div class="slimscrollright">
                <div class="rpanel-title">Service Panel <span><i class="ti-close right-side-toggle"></i></span></div>
                <div class="r-panel-body">
                    <ul>
                        <li><b>Layout Options</b></li>
                        <li>
                            <div class="checkbox checkbox-info">
                                <input id="checkbox1" type="checkbox" class="fxhdr">
                                <label for="checkbox1">Fix Header </label>
                            </div>
                        </li>
                        <li>
                            <div class="checkbox checkbox-warning">
                                <input id="checkbox2" type="checkbox" class="fxsdr">
                                <label for="checkbox2">Fix Sidebar </label>
                            </div>
                        </li>
                        <li>
                            <div class="checkbox checkbox-success">
                                <input id="checkbox4" type="checkbox" class="open-close">
                                <label for="checkbox4">Toggle Sidebar </label>
                            </div>
                        </li>
                    </ul>
                    <ul id="themecolors" class="m-t-20">
                        <li><b>With Light sidebar</b></li>
                        <li><a href="javascript:void(0)" theme="default" class="default-theme working">1</a></li>
                        <li><a href="javascript:void(0)" theme="green" class="green-theme">2</a></li>
                        <li><a href="javascript:void(0)" theme="gray" class="yellow-theme">3</a></li>
                        <li><a href="javascript:void(0)" theme="blue" class="blue-theme">4</a></li>
                        <li><a href="javascript:void(0)" theme="purple" class="purple-theme">5</a></li>
                        <li><a href="javascript:void(0)" theme="megna" class="megna-theme">6</a></li>
                        <li><b>With Dark sidebar</b></li>
                        <br />
                        <li><a href="javascript:void(0)" theme="default-dark" class="default-dark-theme">7</a></li>
                        <li><a href="javascript:void(0)" theme="green-dark" class="green-dark-theme">8</a></li>
                        <li><a href="javascript:void(0)" theme="gray-dark" class="yellow-dark-theme">9</a></li>

                        <li><a href="javascript:void(0)" theme="blue-dark" class="blue-dark-theme">10</a></li>
                        <li><a href="javascript:void(0)" theme="purple-dark" class="purple-dark-theme">11</a></li>
                        <li><a href="javascript:void(0)" theme="megna-dark" class="megna-dark-theme">12</a></li>
                    </ul>
                    <ul class="m-t-20 chatonline">
                        <li><b>Chat option</b></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/varun.jpg" alt="user-img" class="img-circle">
                            <span>Varun Dhavan <small class="text-success">online</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/genu.jpg" alt="user-img" class="img-circle">
                            <span>Genelia Deshmukh <small class="text-warning">Away</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/ritesh.jpg" alt="user-img" class="img-circle">
                            <span>Ritesh Deshmukh <small class="text-danger">Busy</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/arijit.jpg" alt="user-img" class="img-circle">
                            <span>Arijit Sinh <small class="text-muted">Offline</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/govinda.jpg" alt="user-img" class="img-circle">
                            <span>Govinda Star <small class="text-success">online</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/hritik.jpg" alt="user-img" class="img-circle">
                            <span>John Abraham<small class="text-success">online</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/john.jpg" alt="user-img" class="img-circle">
                            <span>Hritik Roshan<small class="text-success">online</small></span></a></li>
                        <li><a href="javascript:void(0)">
                            <img src="plugins/images/users/pawandeep.jpg" alt="user-img" class="img-circle">
                            <span>Pwandeep rajan <small class="text-success">online</small></span></a></li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- /.right-sidebar -->

        <script src="js/cbpFWTabs.js"></script>
        <script type="text/javascript">
            (function () {
                [].slice.call(document.querySelectorAll('.sttabs')).forEach(function (el) {
                    new CBPFWTabs(el);
                });

            })();
        </script>
    </div>
</asp:Content>

