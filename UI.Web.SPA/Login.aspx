<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LearnByPractice.UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>LearnByPractice - Пријавување</title>
    <link rel="stylesheet" href="wwwroot/lib/bootstrap/dist/css/bootstrap.css" />
    <link rel="stylesheet" href="wwwroot/lib/bootstrap/dist/css/bootstrap-theme.css" />
    <link rel="stylesheet" href="wwwroot/app/styles/Site.css" />
    <script type="text/javascript" src="Scripts/modernizr-2.8.3.js"></script>
    <script type="text/javascript" src="wwwroot/lib/jquery/dist/jquery.js"></script>
    <script type="text/javascript" src="wwwroot/lib/bootstrap/dist/js/bootstrap.js"></script>
</head>
<body class="app">
    <div class="container body-content">
        <br />
        <form id="LoginForm" runat="server" role="form">
            <section>
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Пријавување
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-lg-8">
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="KorisnichkoImeLabel" AssociatedControlID="KorisnichkoImeTextBox" Text="Корисничко име:" />
                                            <asp:TextBox runat="server" ID="KorisnichkoImeTextBox" CssClass="form-control" MaxLength="20" placeholder="Корисничко име" ValidationGroup="Najava" required />
                                        </div>
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="LozinkaLabel" AssociatedControlID="LozinkaTextBox" Text="Лозинка:" />
                                            <asp:TextBox runat="server" ID="LozinkaTextBox" CssClass="form-control" MaxLength="20" placeholder="Лозинка" TextMode="Password" ValidationGroup="Najava" required />
                                        </div>
                                        <div class="checkbox">
                                            <label>
                                                <asp:CheckBox runat="server" ID="ZapomniMeCheckBox" Text="Запомни ме" /></label>
                                        </div>
                                        <div class="btn-group">
                                            <asp:Button runat="server" ID="NajaviSeButton" CssClass="btn btn-success" Text="Најави се" OnClick="NajaviSeButton_Click" ValidationGroup="Najava" />
                                        </div>
                                        <div>
                                            <asp:Label runat="server" ID="NajavaPorakaZaGreshkaLabel" CssClass="alert-danger" Visible="false" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel-footer">
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                Регистрирање
                            </div>
                            <div class="panel-body">
                            </div>
                            <div class="panel-footer">
                            </div>
                        </div>
                    </div>

                </div>
            </section>
        </form>
        <hr />
        <footer class="text-center">
            <p>&copy; 2017 - ФИКТ</p>
        </footer>
    </div>
</body>
</html>
