<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="webpruebas.index" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link rel="stylesheet" href="/Style.css" />
    <title>Inicio</title>

</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
            <!-- Encabezado -->
            <div class="encabezado">
                <div>
                </div>
                <div>
                    <p align="right"><a href="login.aspx">Inicio Sesion</a></p>
                </div>
            </div>

            <!-- Cuerpo -->
            <div class="contenedor">
                <div class="row">
                    <%--col pequeño 12, sm medio 12, medio 6-6-12, largo 2-8-2, xtra 2,8,2 --%>
                    <div class="col-12 col-sm-12 col-md-6 col-lg-2 col-xl-2 d-none d-md-block border"></div>

                    <div class="col-12 col-sm-12 col-md-12  col-lg-8 col-xl-8 border">
                        <p align="center">
                            <img src="Img/header.jpg" />
                        </p>
                        <h3 align="center">BIENVENIDOS A MUNICIPALIDAD DE VISTA HERMOSA</h3>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
                    <div class="col-12 col-sm-12 col-md-6 col-lg-2 col-xl-2 d-none d-md-block border"></div>
                </div>
            </div>

            <!-- Pie de Pagina -->
            <div class="footer">
                <div class="col  border">
                    <p align="right">Desarrollado por Cheat´sCode</p>
                </div>
            </div>
            <div class="footer">
                <div class="col  border">
                    <p>2018 Municipalidad de Vista Hermosa</p>
                    <p>Derechos Reservados</p>
                </div>
                <div class="col  border">
                    <p>Politicas de privacidad / Terminos y condiciones</p>
                </div>
            </div>


        </div>
    </form>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
