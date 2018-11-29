using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALC;
using Negocio;

namespace webpruebas.JI
{
    public partial class autorizarPermiso : System.Web.UI.Page
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
            cargarPermisos();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            //Session["unidad"].ToString();
            Response.Redirect("/index.aspx");
        }

        public void cargarPermisos()
        {
            string rutValidacion = Session["userID"].ToString();
            //consulta para obtener estado
            var consulta = from c in Conexion.Entidades.SOLICITUD
                                 where c.PERMISO.USUARIO.RUT != rutValidacion
                                 select new
                                 {
                                     c.PERMISO.ID_PERMISO,
                                     c.PERMISO.TIPO_PERMISO.NOMBREPERMISO,                                                                         
                                     c.PERMISO.ID_USUARIO,
                                     c.PERMISO.TIPO_PERMISO.DIAS,
                                     c.PERMISO.USUARIO.UNIDAD.NOMBRE,
                                     c.PERMISO.DESCRIPCION,
                                     c.ESTADO
                                 };
            gvListarPermisos.DataSource = consulta.ToList();
            gvListarPermisos.DataBind();

            //Response.Redirect("JI/autorizarPermiso.aspx");
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            Session["IDPERMISO"] = txtIdPermiso.Text;            
            Response.Redirect("/JI/solicitudPermiso.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/JI/menuJI.aspx");
        }
    }
}
