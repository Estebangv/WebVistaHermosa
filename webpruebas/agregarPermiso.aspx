<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarPermiso.aspx.cs" Inherits="webpruebas.agregarPermiso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agregar Permiso</title>
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
                <p>
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </p>
                <a class="btn btn-outline-light" href="Home.aspx">Cerrar Sesión</a>
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
                            <th>
                                <!--realizar una consulta a la base de datos y sumar uno -->
                                <asp:Label ID="lblNumerador" runat="server" Text="Numerador"></asp:Label>
                            </th>
                            <th>
                                <asp:Label ID="lblNumeradorAuto" runat="server"></asp:Label>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th>
                                <!--que venga de la pagina anterior, READONLY -->
                                <asp:Label ID="lblMotivo" runat="server" Text="ID Tipo Permiso"></asp:Label>
                            </th>
                            <th>
                                <asp:TextBox ID="txtMotivo" runat="server" Height="17px" Width="250px" ReadOnly="True"></asp:TextBox>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th>
                                <asp:Label ID="lblTipoPer" runat="server" Text="Motivo"></asp:Label>
                            </th>
                            <th>
                                <asp:DropDownList ID="ddlTipoPer" runat="server" DataSourceID="EDStipoPermiso" DataTextField="NOMBREPERMISO" DataValueField="ID_TIPOPERMISO">
                                </asp:DropDownList>
                                <asp:EntityDataSource ID="EDStipoPermiso" runat="server" ConnectionString="name=Entidades" DefaultContainerName="Entidades" EnableFlattening="False" EntitySetName="TIPO_PERMISO">
                                </asp:EntityDataSource>
                            </th>
                            <th>
                                &nbsp;</th>
                        </tr>
                        <tr>
                            <th>Descripcion</th>
                            <th>
                                <asp:TextBox ID="txtDescripcion" runat="server" Height="130px" Width="249px" TextMode="MultiLine"></asp:TextBox>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                        <tr>

                            <th>
                                <asp:Button ID="btnSolicitar" runat="server" Text="Solicitar Permiso" OnClick="btnSolicitar_Click" />
                            </th>
                            <th>&nbsp;</th>
                            <th>
                                <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
                            </th>
                        </tr>
                        <tr>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                        <tr>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                        <tr>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                        <tr>
                            <th>&nbsp;</th>
                            <th>&nbsp;</th>
                            <th></th>
                        </tr>
                        <tr>
                            <th></th>
                            <th>
                                <asp:Label ID="lblAviso" runat="server" Text=""></asp:Label>
                            </th>
                            <th></th>
                        </tr>
                    </table>




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

