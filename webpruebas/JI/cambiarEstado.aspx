<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cambiarEstado.aspx.cs" Inherits="webpruebas.JI.cambiarEstado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Autorizar Permiso</title>
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-light">
            <div class="row">
                <div class="col-12  border bg-light">
                    <h3 align="center">Sistema de Permisos</h3>
                </div>
            </div>

            <div class="row">
                <%--col pequeño 12, sm medio 12, medio 6-6-12, largo 2-8-2, xtra 2,8,2 --%>
                <div class="col-12 col-sm-12 col-md-6 col-lg-2 col-xl-2 d-none d-md-block border bg-white">
                    <br />
                    <br />
                    <br />
                    <p align="center">Municipalidad de Vista Hermosa</p>
                </div>

                <div class="col-12 col-sm-12 col-md-12  col-lg-8 col-xl-8 border bg-white">
                    <br />
                    <br />
                    <br />
                    <br />

                    <table align="center">
                        <tr>
                            <th>
                                <!--realizar una consulta a la base de datos y sumar uno -->
                                <asp:Label ID="lblNumerador" runat="server" Text="Numerador"></asp:Label>
                            </th>
                            <th>
                                <asp:TextBox ID="txtNumeradorJI" runat="server" ReadOnly="True"></asp:TextBox>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th>
                                <!--que venga de la pagina anterior, READONLY -->
                                <asp:Label ID="lblMotivo" runat="server" Text="Motivo"></asp:Label>
                            </th>
                            <th>
                                <asp:TextBox ID="txtMotivoJI" runat="server" Height="160px" Width="250px" ReadOnly="True"></asp:TextBox>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th>
                                <asp:Label ID="lblTipoPer" runat="server" Text="Tipo Permiso"></asp:Label>
                            </th>
                            <th>
                                <asp:TextBox ID="txtTipoPerJI" runat="server" ReadOnly="True"></asp:TextBox>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th>
                                <asp:Label ID="lblDias" runat="server" Text="Dias"></asp:Label>
                            </th>
                            <th>
                                <asp:TextBox ID="txtDiasJI" runat="server" ReadOnly="True"></asp:TextBox>
                            </th>
                            <th>&nbsp;</th>
                        </tr>
                        <tr>
                            <th>
                                <asp:Label ID="Label1" runat="server" Text="Estado"></asp:Label>
                            </th>
                            <th>
                                <asp:DropDownList ID="ddlEstadoJI" runat="server" DataTextField="Pendiente, Autorizado, Rechazado">
                                </asp:DropDownList>
                            </th>
                            <th>&nbsp;</th>
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
                            <th></th>
                            <th>
                                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                            </th>
                            <th>
                                <asp:Button ID="btnCancelarJI" runat="server" OnClick="btnCancelarJI_Click" Text="Cancelar" />
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
                            <th>
                                <asp:Label ID="lblAvisoJI" runat="server"></asp:Label>
                            </th>
                            <th></th>
                        </tr>
                    </table>

                </div>
                <div class="col-12 col-sm-12 col-md-6 col-lg-2 col-xl-2 d-none d-md-block border bg-white">
                    <br />
                    <br />
                    <p align="center">
                        <img src="Img/header.jpg" />
                    </p>

                </div>
            </div>
            <div class="row">
                <div class="col  border">
                    <p align="right">Desarrollado por Cheat´sCode</p>
                </div>

            </div>
            <div class="row">
                <div class="col  border">
                    <p>2018 Municipalidad de Vista Hermosa</p>
                    <p>Derechos Reservados</p>
                </div>
                <div class="col  border">
                    <p align="right">Politicas de privacidad / Terminos y condiciones</p>
                </div>
            </div>
        </div>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    </form>
    </body>
</html>
