﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verPermiso.aspx.cs" Inherits="webpruebas.verPermiso1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <!-- Bootstrap CSS -->
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <title>Ver Permiso</title>
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
                    <a class="nav-link" href="#">Home<span class="sr-only">(current)</span></a>
                </li>
            </ul>
            <form class="form-inline mt-2 mt-md-0">
                <p>
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </p>
                <a class="btn btn-outline-light" href="InicioSesion.aspx">Cerrar Sesión</a>
            </form>
        </div>
    </nav>
    <!-- Cuerpo de Pagina -->
    <center>
    <form id="form1" runat="server" style="width: 80%;">
        <br />
        <br />
        <br />
        <div style="text-align: center;">
            <div class="jumbotron" style="border-radius:20px;">
                <asp:GridView ID="gridPermisos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                    <br />
                    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
                    <br />
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
