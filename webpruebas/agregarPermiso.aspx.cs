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
    public partial class agregarPermiso : System.Web.UI.Page
    {
        Entidades entiti = new Entidades();

        protected void Page_Load(object sender, EventArgs e)
        {
            //siempre conectado para navegar
            if (Session["userName"] == null)
            {
                Response.Redirect("/index.aspx");
            }

            //nombre del usuario
            lblUserName.Text = Session["userName"].ToString().ToUpper();

            //para obtener el id del maximo permiso
            var consulta1 = (from p in Conexion.Entidades.PERMISO select p.ID_PERMISO).Max();
            decimal ulIdPer = consulta1 + 1;
            //asignar valores fijos
            lblNumeradorAuto.Text = ulIdPer.ToString();
            decimal idMotivo = Convert.ToDecimal(Session["idMotivo"].ToString());
            txtMotivo.Text = Convert.ToString(idMotivo);

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("agregarMotivo.aspx");
        }

        protected void btnSolicitar_Click(object sender, EventArgs e)
        {
            Session["userID"].ToString();
            Session["idMotivo"].ToString();
            decimal idMotivo = Convert.ToDecimal(Session["idMotivo"].ToString());
            decimal sRut = Convert.ToDecimal(Session["userID"].ToString());
            decimal idTipoPer = Convert.ToDecimal(ddlTipoPer.Text);
            decimal ulIdPer;

            //saber si hay o no un permiso
            var consulta0 = (from p in Conexion.Entidades.PERMISO select p.ID_PERMISO).Count();

            if (consulta0 > 0)
            {
                //para obtener el id del maximo permiso
                var consulta1 = (from p in Conexion.Entidades.PERMISO select p.ID_PERMISO).Max();
                ulIdPer = consulta1 + 1;
            }
            else
            {
                ulIdPer = 1;
            }


            //para obtener los dias del permiso
            var consulta2 = from p in Conexion.Entidades.TIPO_PERMISO
                            select new
                            {
                                p.ID_TIPOPERMISO
                            };

                       
            //para saber id maximo del la solicitud
            var consulta3 = (from s in Conexion.Entidades.SOLICITUD select s.ID_SOLICITUD).Max();


            //crear permiso
            PERMISO permiso = new PERMISO();

            permiso.ID_PERMISO = ulIdPer;
            permiso.ID_MOTIVO = idMotivo;
            permiso.ID_USUARIO = Convert.ToString(sRut);
            permiso.ID_TIPOPERMISO = Convert.ToDecimal(ddlTipoPer.Text);
            permiso.DESCRIPCION = txtDescripcion.Text;

            //crear solicitud
            SOLICITUD solicitud = new SOLICITUD();
            solicitud.ESTADO = "PENDIENTE";
            solicitud.FECHA_SOLICITUD = DateTime.Today;
            solicitud.ID_PERMISO = ulIdPer;
            solicitud.ID_SOLICITUD = consulta3 + 1;

            entiti.PERMISO.Add(permiso);
            entiti.SOLICITUD.Add(solicitud);
            entiti.SaveChanges();

            lblAviso.Text = "Permiso Agregado";
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("/index.aspx");
        }
    }
}