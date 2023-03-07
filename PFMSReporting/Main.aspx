<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="PFMSReporting.Main" %>

<!DOCTYPE html>
<html lang="en" >


<!-- PFMS/Layout  13 Dec 2022 02:52:00 GMT -->
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>PFMS</title>
    <meta name="keywords" content="HTML5 Template">
    <meta name="description" content="Molla - Bootstrap eCommerce Template">
    <meta name="author" content="p-themes">
    <!-- Favicon -->
    <link rel="apple-touch-icon" sizes="180x180" href="assets/images/icons/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="32x32" href="assets/images/icons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="assets/images/icons/favicon-16x16.png">
    <link rel="manifest" href="assets/images/icons/site.html">
    <link rel="mask-icon" href="assets/images/icons/safari-pinned-tab.svg" color="#666666">
    <link rel="shortcut icon" href="assets/images/icons/favicon.ico">
    <meta name="apple-mobile-web-app-title" content="Molla">
    <meta name="application-name" content="Molla">
    <meta name="msapplication-TileColor" content="#cc9966">
    <meta name="msapplication-config" content="assets/images/icons/browserconfig.xml">
    <meta name="theme-color" content="#ffffff">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto|Varela+Round">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <!-- Plugins CSS File -->
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!-- Main CSS File -->
     <link rel="stylesheet" href="assets/css/style.css">

</head>

<body>
    <form id="form1" runat="server">
    <div class="page-wrapper">
        <header class="header">
            <div class="header-middle sticky-header">
                <div class="container">
                    <div class="header-left">
                       <img src="assets/images/logo.png"  width="250" height="150" style="margin-left: 20px;">
                    </div><!-- End .header-left -->
                </div><!-- End .container -->
            </div><!-- End .header-middle -->
            </header><!-- End .header -->
        <main class="main" dir="rtl">

  <div class="page-content">


        <div class="container" style="margin-top: 30px;">
            <div class="row content">
                <div class="col-sm-8">

                    <h2 for="content" class="col-md-12 control-label pull-right " style="text-align:right">  بيانات التقرير</h2>

                        <div class="col-6">
                            <label for="content" class="col-md-12 control-label pull-right " style="text-align:right">من تاريخ *</label>
                            <input type="date"   id="d1" name="d1" runat="server"  class="form-control" required>
                        </div><!-- End .col-6 -->


                        <div class="col-6">
                            <label for="content" class="col-md-12 control-label pull-right " style="text-align:right">الي تاريخ *</label>
                            <input type="date" id="d2"  runat="server" name="d2" class="form-control" required>
                        </div><!-- End .col-6 -->


                        <div class="col-6" style="margin-top: 50px;">
                            <asp:Button ID="createreport" runat="server" class="btn btn-primary btn-lg" Text="نشاء" OnClick="createreport_Click"/>
                        </div><!-- End .col-6 -->

                </div>



            </div>
        </div>




    </div><!-- End .page-wrapper -->

        </main><!-- End .main -->
        <footer class="footer">
	        <div class="footer-bottom">
	        	<div class="container" dir="ltr">
	        		<p class="footer-copyright">Copyright © 2022 PFMS. All Rights Reserved.</p><!-- End .footer-copyright -->
	        	</div><!-- End .container -->
	        </div><!-- End .footer-bottom -->
        </footer><!-- End .footer -->
    </div><!-- End .page-wrapper -->
    <button id="scroll-top" title="Back to Top"><i class="icon-arrow-up"></i></button>
    <!-- Plugins JS File -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.bundle.min.js"></script>
    <script src="assets/js/jquery.hoverIntent.min.js"></script>
    <script src="assets/js/jquery.waypoints.min.js"></script>
    <script src="assets/js/superfish.min.js"></script>
    <script src="assets/js/owl.carousel.min.js"></script>
    <!-- Main JS File -->
    <script src="assets/js/main.js"></script>
    </form>
</body>

<!-- PFMS/Layout  13 Dec 2022 02:52:00 GMT -->
</html>
