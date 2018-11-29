using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using DALC;

namespace webpruebas
{
    public partial class agregarMotivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //siempre conectado para navegar
            if (Session["userName"] == null)
            {
                Response.Redirect("/index.aspx");
            }

            //nombre del usuario
            lblUserName.Text = Session["userName"].ToString().ToUpper();
        }

        protected void btnAgregarMotivo_Click(object sender, EventArgs e)
        {

            decimal motivo = Convert.ToDecimal(DropDownList1.Text);
            Session["idMotivo"] = motivo;
            if (motivo > 0)
            {
                Response.Redirect("agregarPermiso.aspx");
            }
            else
            {
                lblAvisoIngreso.Text = "Error";
            }



        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string sessionRut = Session["userID"].ToString();
            //realizar consulta para saber que funcionario es
            //y redirigir a la pagina de cada uno
            var consulta = from usu in Conexion.Entidades.USUARIO
                           where sessionRut == usu.RUT
                           select new
                           {
                               usu.NOMBRE,
                               usu.RUT,
                               usu.ID_TIPOUSUARIO
                           };
            foreach (var x in consulta)
            {
                /*5 FUNCIONARIO*/
                if (x.ID_TIPOUSUARIO == 5)
                {
                    Session["userID"] = x.RUT;
                    Session["userName"] = x.NOMBRE;
                    Response.Redirect("Funcionario/menuFuncionario.aspx");

                }
                /*2*/
                else if (x.ID_TIPOUSUARIO == 2)
                {
                    Session["userID"] = x.RUT;
                    Session["userName"] = x.NOMBRE;
                    Response.Redirect("JI/menuJI.aspx");
                }
                /*3*/
                else if (x.ID_TIPOUSUARIO == 3)
                {
                    Session["userID"] = x.RUT;
                    Session["userName"] = x.NOMBRE;
                    Response.Redirect("JS/menuJS.aspx");
                }
                /*4*/
                else if (x.ID_TIPOUSUARIO == 4)
                {
                    Session["userID"] = x.RUT;
                    Session["userName"] = x.NOMBRE;
                    Response.Redirect("Alcalde/menuAlcalde.aspx");
                }
            }

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("/index.aspx");
        }
    }
}
