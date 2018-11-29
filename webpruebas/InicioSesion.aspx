<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="webpruebas.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>

</head>
<body>

    <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-success">
        <a class="navbar-brand" href="#">Vista Hermosa</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarCollapse">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                </li>
            </ul>
            <form class="form-inline mt-2 mt-md-0">
                <a class="btn btn-outline-light" href="InicioSesion.aspx">Iniciar Sesión</a>
            </form>
        </div>
    </nav>

    <br />
    <br />
    <br />

    <center>

    <form id="form1" runat="server" >
        <div class="container" style="width:30%;">
        <div class="jumbotron" style="padding-bottom:10px; padding-top:10px;">
        <img class="mb-4" src="Img/header.jpg" alt="" width="72" height="72" />
        <h1 class="h3 mb-3 font-weight-normal">Iniciar Sesión</h1>
        <input type="text" placeholder="&#128100; RUT" name="txtUsuario" id="txtRut" runat="server" autofocus class="alert-info blockquote" />
            <br />
        <input type="password" placeholder="&#128477; Contraseña" name="txtPass" id="txtPass" runat="server" class="alert-info blockquote" />
        <h2><asp:Label ID="lblAviso" runat="server" Text="" ForeColor="Red" Font-Size="Medium"></asp:Label></h2>
        <a class="nav-link" href="cambioPass.aspx">¿Olvido su contraseña?</a>
        <input type="submit" value="Ingresar" runat="server" onserverclick="Unnamed_ServerClick" class="btn btn-outline-primary" style="width:70%;" />
        <p class="mt-5 mb-3 text-muted">© Vista Hermosa</p>
        </div>
        </div>
    </form>

    </center>

    <!-- Pie de Pagina -->
    <div style="position: fixed; bottom: 0; width: 100%; padding-top: 5px; background-color: green; color: white; text-align: center; margin: auto; font-size: small;">
        <div>
            <p>
                2018 Municipalidad de Vista Hermosa
                <br />
                Derechos Reservados
                <br />
                Politicas de privacidad / Terminos y condiciones
            </p>
            <p align="right" style="padding-right: 10px; margin: auto;">Desarrollado por Cheat´sCode</p>
        </div>
    </div>

</body>
</html>
