<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LearnByPractice.UI.Web.wwwroot.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="wwwroot/lib/bootstrap/dist/css/bootstrap.css" />
    <link rel="stylesheet" href="wwwroot/lib/bootstrap/dist/css/bootstrap-theme.css" />
    <link rel="stylesheet" href="wwwroot/app/styles/Site.css" />
    <script type="text/javascript" src="Scripts/modernizr-2.8.3.js"></script>
    <script type="text/javascript" src="wwwroot/lib/jquery/dist/jquery.js"></script>
    <script type="text/javascript" src="wwwroot/lib/bootstrap/dist/js/bootstrap.js"></script>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>Learn By Practice!</title>

    <!-- Bootstrap Core CSS -->
    <link href="wwwroot/app/styles/bootstrap.min.css" rel="stylesheet" />

    <!-- Theme CSS -->
    <link href="wwwroot/app/styles/lbp.min.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="wwwrot/app/styles/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic" rel="stylesheet" type="text/css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body id="page-top" class="app">


    <!-- Navigation -->
    <nav id="mainNav" class="navbar navbar-default navbar-fixed-top navbar-custom">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header page-scroll">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span> Мени <i class="fa fa-bars"></i>
                </button>
                <a class="navbar-brand-fixed-top" href="#page-top">
                    <img src="wwwroot/app/images/logoa/l225.png" height="70" width="100" /></a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li class="hidden">
                        <a href="#page-top"></a>
                    </li>
                    <li class="page-scroll">
                        <a href="#about">За LBP</a>
                    </li>
                    <li class="page-scroll">
                        <a href="#portfolio">Организации</a>
                    </li>
                    <li class="page-scroll">
                        <a href="#signin">Најави се</a>
                    </li>
                    <li class="page-scroll">
                        <a href="#signup">Регистрирај се</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container-fluid -->
    </nav>

    <!-- Header -->
    <header>
        <div class="container" id="maincontent" tabindex="-1">
            <div class="row">
                <div class="col-lg-12">
                    <img class="img-responsive" src="wwwroot/app/images/logoa/fikt.png" height="100" width="200" alt="" />
                    <div class="intro-text">
                        <h1 class="name">Learn By Practice</h1>
                        <br />
                        <br />
                        <span class="opis">-работни групи-</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- About Section -->
    <section class="success" id="about">
        <div class="parallax">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h3 style="color: #1a1a1a"><b>Работните групи...</b></h3>
                    <br />
                    <p id="textZaLBP" style="color: #0d0d0d">
                        Се реализираат секоја година на Факултетот за информатички и комуникациски технологии - Битола. Истите се под менторство на професори од факултетот, како и ментори од компании кои учествуваат во истите.
					
                        <br />
                        Овие групи се вистинска можност за студентите да реализираат практична настава, да се запознаат со нови технологии и поинаков начин на работа на проект и работа во тим.
					
                        <br />
                        Доколку си студент на Факултетот за информатички и комуникациски технологии, пријави се на формата за регистрација и стекни практично искуство уште сега!
				
                    </p>
                </div>
            </div>
        </div>
    </section>

    <!-- Portfolio Grid Section -->
    <section id="portfolio">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h3><b>Компании</b></h3>
                    <br />
                </div>
            </div>
            <br />
            <br />
            <div class="row">

                <!--<div class="col-sm-4 portfolio-item">
                    <a href="#portfolioModal1" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="img/portfolio/cabin.png" class="img-responsive" alt="Cabin">
                    </a>
                </div>-->
                <div class="col-sm-4 portfolio-item">
                    <a href="http://www.seavus.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="wwwroot/app/images/kompanii/seavus.png" class="img-thumbnail" width="500" height="236" alt="Seavus" />
                    </a>
                </div>

                <!-- <div class="col-sm-4 portfolio-item">
                    <a href="#portfolioModal2" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="img/portfolio/cake.png" class="img-responsive" alt="Slice of cake">
                    </a>
                </div>
				-->
                <div class="col-sm-4 portfolio-item">
                    <a href="http://isource.com.mk/" target="_blank" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="wwwroot/app/images/kompanii/isource1.png" class="img-thumbnail" width="500" height="236" alt="isource" />
                    </a>
                </div>

                <!--   <div class="col-sm-4 portfolio-item">
                    <a href="#portfolioModal3" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="img/portfolio/circus.png" class="img-responsive" alt="Circus tent">
                    </a>
                </div>-->
                <div class="col-sm-4 portfolio-item">
                    <a href="http://www.extreme-labs.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="wwwroot/app/images/kompanii/x3m1.png" class="img-thumbnail" width="500" height="236" alt="x3mlabs" />
                    </a>
                </div>

                <!-- <div class="col-sm-4 portfolio-item">
                    <a href="#portfolioModal4" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="img/portfolio/game.png" class="img-responsive" alt="Game controller">
                    </a>
                </div>-->

                <div class="col-sm-4 portfolio-item">
                    <a href="http://www.cosmicdevelopment.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="wwwroot/app/images/kompanii/cosmic1.png" class="img-thumbnail" width="500" height="236" alt="Cosmic Development" />
                    </a>
                </div>
                <!--  <div class="col-sm-4 portfolio-item">
                    <a href="#portfolioModal5" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="img/portfolio/safe.png" class="img-responsive" alt="Safe">
                    </a>
                </div>-->
                <div class="col-sm-4 portfolio-item">
                    <a href="http://www.endava.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="wwwroot/app/images/kompanii/endava1.png" class="img-thumbnail" width="500" height="236" alt="Endava" />
                    </a>
                </div>
                <!--<div class="col-sm-4 portfolio-item">
                    <a href="#portfolioModal6" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                        <img src="img/portfolio/submarine.png" class="img-responsive" alt="Submarine">
                    </a>
                </div>-->
            </div>
        </div>

    </section>

    <!-- Signin Section -->
    <section id="signin">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h3><b>Најави се!</b></h3>
                    <br />
                </div>
            </div>
            <!-- <div class="container"> -->

            <!--
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2"> -->

            <form name="sentMessage" id="contactForm" runat="server" role="form">
                <section>
                    <div class="row">
                        <div class="col-lg-8 col-lg-offset-2">
                            <div class="row control-group">
                                <div class="form-group col-xs-12 floating-label-form-group controls">
                                    <asp:Label runat="server" ID="KorisnichkoImeLabel" AssociatedControlID="KorisnichkoImeTextBox" Text="Корисничко име:" />
                                    <asp:TextBox runat="server" ID="KorisnichkoImeTextBox" CssClass="form-control" MaxLength="20" placeholder="Корисничко име" ValidationGroup="Najava" required="true" />
                                </div>
                            </div>
                            <div class="row control-group">
                                <div class="form-group col-xs-12 floating-label-form-group controls">
                                    <asp:Label runat="server" ID="LozinkaLabel" AssociatedControlID="LozinkaTextBox" Text="Лозинка:" />
                                    <asp:TextBox runat="server" ID="LozinkaTextBox" CssClass="form-control" MaxLength="20" placeholder="Лозинка" TextMode="Password" ValidationGroup="Najava" required="true" />
                                </div>
                            </div>
                            <div class="checkbox">
                                <label>
                                    <asp:CheckBox runat="server" ID="ZapomniMeCheckBox" Text="Запомни ме" /></label>
                            </div>
                            <div class="row">
                                <div class="btn-group col-xs-12">
                                    <asp:Button runat="server" ID="NajaviSeButton" class="btn btn-success btn-lg" Text="Најави се" OnClick="NajaviSeButton_Click" ValidationGroup="Najava" />
                                </div>
                            </div>
                            <div>
                                <asp:Label runat="server" ID="NajavaPorakaZaGreshkaLabel" CssClass="alert-danger" Visible="false" />
                            </div>
                        </div>
                    </div>
                </section>


                <!-- Signup Section -->
                <section id="signup">
                    <div id="registriranjeParallax" class="parallax">
                        <div class="row">
                            <div class="col-lg-12 text-center">
                                <h3 style="color: #3C3C3C"><b>Регистрирај се!</b></h3>
                                <br />
                                <br />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-8 col-lg-offset-2">
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="korisnichkoImeLbl">Корисничко име</asp:Label>
                                        <asp:TextBox runat="server" type="text" class="form-control" placeholder="Корисничко име" ID="korisnichkoImeTxtBox" ValidationGroup="Registracija" />
                                        <asp:RequiredFieldValidator runat="server" ID="korisnichkoImeRequired" ControlToValidate="korisnichkoImeTxtBox" ErrorMessage="Ве молиме внесете го вашето корисничко име." ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="lozinkaLbl">Лозинка</asp:Label>
                                        <asp:TextBox runat="server" type="password" class="form-control" MaxLength="20" placeholder="Лозинка" ID="lozinkaTxtBox" ValidationGroup="Registracija" />
                                        <asp:RequiredFieldValidator runat="server" ID="lozinkaRequired" ControlToValidate="lozinkaTxtBox" ErrorMessage="Ве молиме внесете ја вашата лозинка." ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="potvrdiLozinkaLabel">Потврди лозинка</asp:Label>
                                        <asp:TextBox runat="server" type="password" class="form-control" placeholder="Лозинка" ID="potvrdiLozinkaTextBox" ValidationGroup="Registracija" />
                                        <asp:RequiredFieldValidator runat="server" ID="potvrdiLozinkaRequired" ControlToValidate="potvrdiLozinkaTextBox" ErrorMessage="Ве молиме потврдете ја вашата лозинка." Display="Dynamic" ValidationGroup="Registracija" />
                                        <asp:CompareValidator runat="server" ID="lozinkaCompare" ControlToValidate="potvrdiLozinkaTextBox" ControlToCompare="lozinkaTxtBox" ErrorMessage="Внесовте различна лозинка" ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="imeLabel">Име</asp:Label>
                                        <asp:TextBox runat="server" type="text" class="form-control" placeholder="Име" ID="imeTextBox" ValidationGroup="Registracija" />
                                        <asp:RequiredFieldValidator runat="server" ID="imeRequired" ControlToValidate="imeTextBox" ErrorMessage="Ве молиме внесете го вашето име" ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="prezimeLabel">Презиме</asp:Label>
                                        <asp:TextBox runat="server" type="text" class="form-control" placeholder="Презиме" ID="prezimeTextBox" ValidationGroup="Recistracija" />
                                        <asp:RequiredFieldValidator runat="server" ID="prezimeRequired" ControlToValidate="prezimeTextBox" ErrorMessage="Ве молиме внесете го вашето презиме." ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="polLabel">Пол</asp:Label>
                                        <br />
                                        <asp:Label runat="server" ID="polZhenskiLabel">Женски</asp:Label>
                                        <asp:RadioButton runat="server" Text="Женски" TextAlign="Right" ID="polZhenskiRadioButton" Checked="false" GroupName="Pol" ValidationGroup="Registracija" />
                                        <asp:Label runat="server" ID="polMashkiLabel">Машки</asp:Label>
                                        <asp:RadioButton runat="server" Text="Машки" TextAlign="Right" ID="polMashkiRadioButton" Checked="false" GroupName="Pol" ValidationGroup="Registracija" />
                                        <asp:CustomValidator runat="server" ID="polCustomValidator" Display="Dynamic" ErrorMessage="Ве молиме одберете пол" ValidationGroup="Registracija" />
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="emailLabel">Е-пошта</asp:Label>
                                        <asp:TextBox runat="server" type="email" class="form-control" placeholder="E-пошта" ID="emailTextBox" ValidationGroup="Registracija" />
                                        <asp:RequiredFieldValidator runat="server" ID="emailRequired" ControlToValidate="emailTextBox" ErrorMessage="Ве молиме внесете ја вашата е-пошта." ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="telefonLabel">Телефонски број</asp:Label>
                                        <asp:TextBox runat="server" type="tel" class="form-control" placeholder="Телефонски број" ID="telefonTextBox" ValidationGroup="Registracija" />
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="row control-group">
                                    <div class="form-group col-xs-12 floating-label-form-group controls">
                                        <asp:Label runat="server" ID="ulogaLabel">Улога</asp:Label>
                                        <br />
                                        <asp:Label runat="server" ID="studentRBlabel">Студент</asp:Label>
                                        <asp:RadioButton runat="server" Text="Студент" TextAlign="Right" ID="studentRadioButton" Checked="false" GroupName="Uloga" ValidationGroup="Registracija" />
                                        <asp:Label runat="server" ID="mentorRBlabel">Ментор</asp:Label>
                                        <asp:RadioButton runat="server" Text="Ментор" TextAlign="Right" ID="mentorRadioButton" Checked="false" GroupName="Uloga" ValidationGroup="Registracija" />
                                        <asp:CustomValidator runat="server" ID="CustomValidator1" Display="Dynamic" ErrorMessage="Ве молиме одберете улога." ValidationGroup="Registracija" />
                                    </div>
                                </div>
                                <br />
                                <div id="success"></div>
                                <div class="row">
                                    <div class="form-group col-xs-12">
                                        <asp:Button runat="server" ID="RegistrirajSeButton" type="submit" Text="Регистрирај се" class="btn btn-success btn-lg" OnClick="RegistrirajSeButton_Click" ValidationGroup="Registracija"></asp:Button>
                                    </div>
                                </div>
                                <div>
                                    <asp:Label runat="server" ID="RegistracijaPorakaZaGreshkaLabel" CssClass="alert-danger" Visible="false" />
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </form>
        </div>
        <!--
            </div>
        </div>
        -->
    </section>


    <!-- Footer -->
    <footer class="text-center">
        <div class="footer-above">
            <div class="container">
                <div class="row">
                    <div class="footer-col col-md-4">
                        <h3>Локација</h3>
                        <p>
                            ул. Партизанска бб
                        
                            <br />
                            7000 Битола<br />

                            <br />
                            Република Македонија
                        </p>
                    </div>
                    <div class="footer-col col-md-4">
                        <h3>Организации</h3>
                        <ul class="list-inline">
                            <li>
                                <a href="http://www.seavus.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                                    <img src="wwwroot/app/images/kompanii/seavus.png" class="img-circle" width="50" height="50" style="border: 1px solid black" alt="Seavus" />
                                </a>
                            </li>
                            <li>
                                <a href="http://isource.com.mk/" target="_blank" class="portfolio-link" data-toggle="modal">
                                    <img src="wwwroot/app/images/kompanii/isource1.png" class="img-circle" width="50" height="50" style="border: 1px solid black" alt="isource" />
                                </a>
                            </li>
                            <li>
                                <a href="http://www.extreme-labs.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                                    <img src="wwwroot/app/images/kompanii/x3m1.png" class="img-circle" width="50" height="50" style="border: 1px solid black" alt="x3mlabs" />
                                </a>
                            </li>
                            <li>
                                <a href="http://www.cosmicdevelopment.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                                    <img src="wwwroot/app/images/kompanii/cosmic1.png" class="img-circle" width="50" height="50" style="border: 1px solid black" alt="Cosmic Development" />
                                </a>
                            </li>
                            <li>
                                <a href="http://www.endava.com/" target="_blank" class="portfolio-link" data-toggle="modal">
                                    <img src="wwwroot/app/images/kompanii/endava1.png" class="img-circle" width="50" height="50" style="border: 1px solid black" alt="Endava" />
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class="footer-col col-md-4">
                        <h3><a href="http://fikt.edu.mk/" style="color: white">Факултет за информатички и комуникациски технологии</a></h3>
                        <p>
                            e-mail: contact@fikt.edu.mk
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class="footer-below">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        Сите права задржани. &copy;  2017
                   
                    </div>
                </div>
            </div>
        </div>
    </footer>

    <!-- Scroll to Top Button (Only visible on small and extra-small screen sizes) -->
    <div class="scroll-top page-scroll hidden-sm hidden-xs hidden-lg hidden-md">
        <a class="btn btn-primary" href="#page-top">
            <i class="fa fa-chevron-up"></i>
        </a>
    </div>

    <!-- Portfolio Modals -->
    <!--  <div class="portfolio-modal modal fade" id="portfolioModal1" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-content">
            <div class="close-modal" data-dismiss="modal">
                <div class="lr">
                    <div class="rl">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="modal-body">
                            <h2>Project Title</h2>
                            <hr class="star-primary">
                            <img src="img/portfolio/cabin.png" class="img-responsive img-centered" alt="">
                            <p>Use this area of the page to describe your project. The icon above is part of a free icon set by <a href="https://sellfy.com/p/8Q9P/jV3VZ/">Flat Icons</a>. On their website, you can download their free set with 16 icons, or you can purchase the entire set with 146 icons for only $12!</p>
                            <ul class="list-inline item-details">
                                <li>Client:
                                    <strong><a href="http://startbootstrap.com">Start Bootstrap</a>
                                    </strong>
                                </li>
                                <li>Date:
                                    <strong><a href="http://startbootstrap.com">April 2014</a>
                                    </strong>
                                </li>
                                <li>Service:
                                    <strong><a href="http://startbootstrap.com">Web Development</a>
                                    </strong>
                                </li>
                            </ul>
                            <button type="button" class="btn btn-default" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="portfolio-modal modal fade" id="portfolioModal2" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-content">
            <div class="close-modal" data-dismiss="modal">
                <div class="lr">
                    <div class="rl">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="modal-body">
                            <h2>Project Title</h2>
                            <hr class="star-primary">
                            <img src="img/portfolio/cake.png" class="img-responsive img-centered" alt="">
                            <p>Use this area of the page to describe your project. The icon above is part of a free icon set by <a href="https://sellfy.com/p/8Q9P/jV3VZ/">Flat Icons</a>. On their website, you can download their free set with 16 icons, or you can purchase the entire set with 146 icons for only $12!</p>
                            <ul class="list-inline item-details">
                                <li>Client:
                                    <strong><a href="http://startbootstrap.com">Start Bootstrap</a>
                                    </strong>
                                </li>
                                <li>Date:
                                    <strong><a href="http://startbootstrap.com">April 2014</a>
                                    </strong>
                                </li>
                                <li>Service:
                                    <strong><a href="http://startbootstrap.com">Web Development</a>
                                    </strong>
                                </li>
                            </ul>
                            <button type="button" class="btn btn-default" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="portfolio-modal modal fade" id="portfolioModal3" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-content">
            <div class="close-modal" data-dismiss="modal">
                <div class="lr">
                    <div class="rl">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="modal-body">
                            <h2>Project Title</h2>
                            <hr class="star-primary">
                            <img src="img/portfolio/circus.png" class="img-responsive img-centered" alt="">
                            <p>Use this area of the page to describe your project. The icon above is part of a free icon set by <a href="https://sellfy.com/p/8Q9P/jV3VZ/">Flat Icons</a>. On their website, you can download their free set with 16 icons, or you can purchase the entire set with 146 icons for only $12!</p>
                            <ul class="list-inline item-details">
                                <li>Client:
                                    <strong><a href="http://startbootstrap.com">Start Bootstrap</a>
                                    </strong>
                                </li>
                                <li>Date:
                                    <strong><a href="http://startbootstrap.com">April 2014</a>
                                    </strong>
                                </li>
                                <li>Service:
                                    <strong><a href="http://startbootstrap.com">Web Development</a>
                                    </strong>
                                </li>
                            </ul>
                            <button type="button" class="btn btn-default" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="portfolio-modal modal fade" id="portfolioModal4" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-content">
            <div class="close-modal" data-dismiss="modal">
                <div class="lr">
                    <div class="rl">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="modal-body">
                            <h2>Project Title</h2>
                            <hr class="star-primary">
                            <img src="img/portfolio/game.png" class="img-responsive img-centered" alt="">
                            <p>Use this area of the page to describe your project. The icon above is part of a free icon set by <a href="https://sellfy.com/p/8Q9P/jV3VZ/">Flat Icons</a>. On their website, you can download their free set with 16 icons, or you can purchase the entire set with 146 icons for only $12!</p>
                            <ul class="list-inline item-details">
                                <li>Client:
                                    <strong><a href="http://startbootstrap.com">Start Bootstrap</a>
                                    </strong>
                                </li>
                                <li>Date:
                                    <strong><a href="http://startbootstrap.com">April 2014</a>
                                    </strong>
                                </li>
                                <li>Service:
                                    <strong><a href="http://startbootstrap.com">Web Development</a>
                                    </strong>
                                </li>
                            </ul>
                            <button type="button" class="btn btn-default" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="portfolio-modal modal fade" id="portfolioModal5" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-content">
            <div class="close-modal" data-dismiss="modal">
                <div class="lr">
                    <div class="rl">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="modal-body">
                            <h2>Project Title</h2>
                            <hr class="star-primary">
                            <img src="img/portfolio/safe.png" class="img-responsive img-centered" alt="">
                            <p>Use this area of the page to describe your project. The icon above is part of a free icon set by <a href="https://sellfy.com/p/8Q9P/jV3VZ/">Flat Icons</a>. On their website, you can download their free set with 16 icons, or you can purchase the entire set with 146 icons for only $12!</p>
                            <ul class="list-inline item-details">
                                <li>Client:
                                    <strong><a href="http://startbootstrap.com">Start Bootstrap</a>
                                    </strong>
                                </li>
                                <li>Date:
                                    <strong><a href="http://startbootstrap.com">April 2014</a>
                                    </strong>
                                </li>
                                <li>Service:
                                    <strong><a href="http://startbootstrap.com">Web Development</a>
                                    </strong>
                                </li>
                            </ul>
                            <button type="button" class="btn btn-default" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="portfolio-modal modal fade" id="portfolioModal6" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-content">
            <div class="close-modal" data-dismiss="modal">
                <div class="lr">
                    <div class="rl">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="modal-body">
                            <h2>Project Title</h2>
                            <hr class="star-primary">
                            <img src="img/portfolio/submarine.png" class="img-responsive img-centered" alt="">
                            <p>Use this area of the page to describe your project. The icon above is part of a free icon set by <a href="https://sellfy.com/p/8Q9P/jV3VZ/">Flat Icons</a>. On their website, you can download their free set with 16 icons, or you can purchase the entire set with 146 icons for only $12!</p>
                            <ul class="list-inline item-details">
                                <li>Client:
                                    <strong><a href="http://startbootstrap.com">Start Bootstrap</a>
                                    </strong>
                                </li>
                                <li>Date:
                                    <strong><a href="http://startbootstrap.com">April 2014</a>
                                    </strong>
                                </li>
                                <li>Service:
                                    <strong><a href="http://startbootstrap.com">Web Development</a>
                                    </strong>
                                </li>
                            </ul>
                            <button id="btnSubmit" type="button" class="btn btn-default" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>-->

    <!-- jQuery -->
    <script src="vendor/jquery/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>

    <!-- Contact Form JavaScript -->
    <script src="js/jqBootstrapValidation.js"></script>
    <script src="js/contact_me.js"></script>

    <!-- Theme JavaScript -->
    <script src="js/freelancer.min.js"></script>
</body>
</html>
