<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarMotivo.aspx.cs" Inherits="webpruebas.agregarMotivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agregar Motivo</title>
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
                                    <asp:Label ID="lblMotivo" runat="server" Text="Tipo Permiso"></asp:Label>
                                </th>

                                <th>
                                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="EDSmotivos" DataTextField="NOMBREMOTIVO" DataValueField="ID_MOTIVO">
                                    </asp:DropDownList>
                                    <asp:EntityDataSource ID="EDSmotivos" runat="server" ConnectionString="name=Entidades" DefaultContainerName="Entidades" EnableFlattening="False" EntitySetName="MOTIVO">
                                    </asp:EntityDataSource>
                                </th>

                                <th>
                                    <asp:Label ID="lblAvisoMotivo" runat="server"></asp:Label>
                                </th>
                            </tr>
                            <tr>
                                <th>
                                    <asp:Button ID="btnAgregarMotivo" runat="server" Text="Siguiente" OnClick="btnAgregarMotivo_Click" />
                                </th>
                                <th>
                                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                                </th>
                                <th>
                                    <asp:Label ID="lblAvisoIngreso" runat="server"></asp:Label>
                                </th>
                            </tr>
                        </table>

                    </div>



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
