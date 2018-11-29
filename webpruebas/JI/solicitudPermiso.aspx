<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="solicitudPermiso.aspx.cs" Inherits="webpruebas.JI.solicitudPermiso" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Solicitud</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>

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
                <p>
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </p>
                <a class="btn btn-outline-light" href="InicioSesion.aspx">Iniciar Sesión</a>    
            </form>
        </div>
    </nav>

    <br />
    <br />
    <br />

    <center>
    <form id="form1" runat="server" style="width: 80%;">
        
        <div style="text-align: center;">
            <div class="jumbotron" style="border-radius:20px;">
                <!--Cuerpo -->

                <table align="center">
                        <tr>
                            <td>ID Solicitud</td>
                            <td>
                    <asp:TextBox ID="txtIDPermiso" runat="server" CssClass="mr-0" Width="28px"></asp:TextBox>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Estado</td>
                            <td>
                    <asp:DropDownList ID="ddlEstado" runat="server">
                        <asp:ListItem>PENDIENTE</asp:ListItem>
                        <asp:ListItem>ACEPTADO</asp:ListItem>
                        <asp:ListItem>RECHAZADO</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                    <asp:Label ID="lblPrueba" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                    <asp:Button ID="btnValidacion" runat="server" Text="Aceptar" OnClick="btnValidacion_Click" />
                            </td>
                            <td></td>
                            <td>
                    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
                            </td>
                        </tr>
                    </table>



            </div>
        </div>

    </form>
    </center>

    <!-- Pie de Pagina -->
    <div style="position: fixed; bottom: 0; width: 100%; padding-top:5px; background-color: green; color: white; text-align: center; margin:auto; font-size:small;">
        <div>
            <p>2018 Municipalidad de Vista Hermosa <br />
                 Derechos Reservados <br />
                 Politicas de privacidad / Terminos y condiciones
            </p>
            <p align="right" style="padding-right: 10px; margin:auto;">Desarrollado por Cheat´sCode</p>
        </div>
    </div>

</body>
</html>
