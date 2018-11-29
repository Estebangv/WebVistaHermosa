using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALC;
using Negocio;

namespace webpruebas.JS
{
    public partial class consultarFunci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //siempre conectado para navegar
            if (Session["userName"] == null)
            {
                Response.Redirect("/index.aspx");
            }
            lblUserName.Text = Session["userName"].ToString().ToUpper();

        }

        protected void btnConsultarF_Click(object sender, EventArgs e)
        {
            string rutVal = txtRut.Text;

            var consulta = from u in Conexion.Entidades.USUARIO
                           where u.RUT == rutVal
                           select new
                           {
                               u.NOMBRE,
                               u.A_MATERNO,
                               u.A_PATERNO,
                               u.FECHA_INGRESO,
                               u.FONO,
                               NombreTipo = u.TIPO_USUARIO.NOMBRE,
                               NombreUnidad = u.UNIDAD.NOMBRE
                           };

            gvDatos.DataSource = consulta.ToList();
            gvDatos.DataBind();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("/index.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/JS/menuJS.aspx");
        }

    }
}