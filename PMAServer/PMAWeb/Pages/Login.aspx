<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PMAWeb.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<!-- start: Meta -->
    <meta charset="utf-8" />
    <title>Project Management App - Connexion</title>
    <meta name="description" content="Project Management App" />
    <meta name="author" content="Jason Tresfield" />
    <!-- end: Meta -->

    <!-- start: Mobile Specific -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- end: Mobile Specific -->

    <!-- start: CSS -->
    <link href="<%=ResolveUrl("~/Resources/Styles/bootstrap.min.css") %>" rel="stylesheet" />
    <link href="<%=ResolveUrl("~/Resources/Styles/bootstrap.responsive.min.css") %>" rel="stylesheet" />
    <link href="<%=ResolveUrl("~/Resources/Styles/style.css") %>" rel="stylesheet" />
    <link href="<%=ResolveUrl("~/Resources/Styles/style-responsive.css") %>" rel="stylesheet" />
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800&subset=latin,cyrillic-ext,latin-ext" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        body {
            background: url(<%=ResolveUrl("~/Resources/Images/bg-login.jpg") %>);
        }
    </style>
    <!-- end: CSS -->

    <!-- The HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
	  	<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
		<link href="css/ie.css" rel="stylesheet">
	<![endif]-->

    <!--[if IE 9]>
		<link href="css/ie9.css" rel="stylesheet">
	<![endif]-->

    <!-- start: Favicon -->
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Resources/Images/favicon.ico") %>" />
    <!-- end: Favicon -->
</head>
<body>
    <div class="container-fluid-full">
        <div class="row-fluid">
            <div class="row-fluid">
                <div class="login-box">
                    <div class="icons">
                        <a href="#"><i class="halflings-icon home"></i></a>
                        <a href="#"><i class="halflings-icon cog"></i></a>
                    </div>
                    <h2>S'identifier</h2>
                    <form runat="server" class="form-horizontal">
                        <fieldset>
                            <div class="input-prepend" title="Username">
                                <span class="add-on"><i class="halflings-icon user"></i></span>
                                <%--<input class="input-large span10" name="username" id="username" type="text" placeholder="Identifiant" />--%>
                                <asp:TextBox runat="server" CssClass="input-large span10" ID="TxtLogin" Placeholder="Identifiant" />
                            </div>
                            <div class="clearfix"></div>

                            <div class="input-prepend" title="Password">
                                <span class="add-on"><i class="halflings-icon lock"></i></span>
                                <%--<input class="input-large span10" name="password" id="password" type="password" placeholder="Mot de Passe" />--%>
                                <asp:TextBox runat="server" CssClass="input-large span10" ID="TxtPassword" TextMode="Password" Placeholder="Mot de Passe" />
                            </div>
                            <div class="clearfix"></div>

                            <%--                            <label class="remember" for="remember">
                                <input type="checkbox" id="remember" />Remember me</label>--%>

                            <div class="button-login">
                                <%--<button type="submit" class="btn btn-primary">Connexion</button>--%>
                                <asp:Button runat="server" ID="BtnConnect" CssClass="btn btn-primary" Text="Connexion" OnClick="BtnConnect_Click" />
                            </div>
                            <div class="clearfix"></div>
                        </fieldset>
                    </form>
                    <%--                    <hr>
                    <h3>Forgot Password?</h3>
                    <p>
                        No problem, <a href="#">click here</a> to get a new password.
                    </p>--%>
                </div>
            </div>
        </div>
    </div>
    <!-- start: JavaScript-->
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery-1.9.1.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery-migrate-1.0.0.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery-ui-1.10.0.custom.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.ui.touch-punch.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/modernizr.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/bootstrap.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.cookie.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/fullcalendar.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.dataTables.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/excanvas.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.flot.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.flot.pie.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.flot.stack.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.flot.resize.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.chosen.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.uniform.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.cleditor.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.noty.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.elfinder.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.raty.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.iphone.toggle.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.uploadify-3.1.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.gritter.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.imagesloaded.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.masonry.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.knob.modified.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/jquery.sparkline.min.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/counter.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/retina.js") %>"></script>
    <script src="<%=ResolveUrl("~/Resources/Scripts/custom.js") %>"></script>
    <!-- end: JavaScript-->
</body>
</html>
