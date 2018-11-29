using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webpruebas
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            string usuario = txtRut.Value;
            string contrasenia = txtPass.Value;
            try
            {
                var consulta = from usu in Conexion.Entidades.USUARIO
                               select new
                               {
                                   usu.RUT,
                                   usu.PASS,
                                   usu.ID_TIPOUSUARIO,
                                   /*1habilitado 2desahabilitado*/
                                   usu.HABILITADO,
                                   usu.NOMBRE,
                               };

                foreach (var x in consulta)
                {
                    if (x.RUT == usuario && x.PASS == contrasenia && x.HABILITADO == 1)
                    {
                        Session["userID"] = x.RUT;
                        Session["userName"] = x.NOMBRE;
                        //consulta para saber la unidad
                        var consultaUnidad = from uni in Conexion.Entidades.USUARIO
                                             where uni.RUT == x.RUT
                                             select new
                                             {
                                                 uni.ID_UNIDAD
                                             };
                        Session["unidad"] = consultaUnidad;

                        /*5 FUNCIONARIO*/
                        if (x.ID_TIPOUSUARIO == 5)
                        {
                            Response.Redirect("Funcionario/menuFuncionario.aspx");

                        }
                        /*2*/
                        else if (x.ID_TIPOUSUARIO == 2)
                        {
                            Response.Redirect("JI/menuJI.aspx");
                        }
                        /*3*/
                        else if (x.ID_TIPOUSUARIO == 3)
                        {
                            Response.Redirect("JS/menuJS.aspx");
                        }
                        /*4*/
                        else if (x.ID_TIPOUSUARIO == 4)
                        {
                            Response.Redirect("Alcalde/menuAlcalde.aspx");
                        }
                    }
                    else
                    {
                        lblAviso.Text = "El usuario no tiene permisos";
                        txtRut.Value = "";
                        txtPass.Value = "";
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
        }
    }
}