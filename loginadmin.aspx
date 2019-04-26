<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginadmin.aspx.cs" Inherits="admin_loginadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
    <!-- iCheck -->
    <link rel="stylesheet" href="plugins/iCheck/square/blue.css">

    <link rel="stylesheet" href="css/loginadmin.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="card card-container form-signin">
            <!-- <img class="profile-img-card" src="//lh3.googleusercontent.com/-6V8xOA6M7BA/AAAAAAAAAAI/AAAAAAAAAAA/rzlHcD0KYwo/photo.jpg?sz=120" alt="" /> -->
            <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
            <p id="profile-name" class="profile-name-card"></p>
            
                <span id="reauth-email" class="reauth-email"></span>
                <asp:textbox type="text" id="inputEmail" class="form-control" placeholder="Email"  runat="server" ></asp:textbox>
                <asp:textbox type="password" id="inputPassword" class="form-control" AutoPostBack="true" OnTextChanged="inputEmail_TextChanged" placeholder="Password" runat="server"></asp:textbox>
                <%--<input type="email" id="inputEmail" class="form-control" placeholder="Email address" required autofocus>
                <input type="password" id="inputPassword" class="form-control" placeholder="Password" required>--%>
                <%--<div id="remember" class="checkbox">
                    <label>
                        <input type="checkbox" value="remember-me"> Recuerdame
                    </label>
                </div>--%>
                <asp:linkbutton type="submit" id="btningresar" runat="server" Width="100%" class="btn btn-primary" OnClick="btningresar_Click">Login</asp:linkbutton>
                <%--<button class="btn btn-lg btn-primary btn-block btn-signin" type="submit">Sign in</button>--%>
            
            <%--<a href="#" class="forgot-password">
                Olvidaste tu contraseña?
            </a>--%>
            <div id="alerta" role="alert" class="alert alert-danger" runat="server" visible="false" style="padding-top:.3em; padding-bottom:.3em;">sdfd</div>
        </div><!-- /card-container -->
    </div><!-- /container -->

    <!-- jQuery 2.2.3 -->
    <script src="plugins/jQuery/jquery-2.2.3.min.js"></script>
    <!-- Bootstrap 3.3.6 -->
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="plugins/iCheck/icheck.min.js"></script>
    <script>
      $(function () {
        $('input').iCheck({
          checkboxClass: 'icheckbox_square-blue',
          radioClass: 'iradio_square-blue',
          increaseArea: '20%' // optional
        });
      });

    </script>
    </form>
</body>
</html>
