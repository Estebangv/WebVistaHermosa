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
    public partial class solicitudPermiso : System.Web.UI.Page
    {
        Entidades entiti = new Entidades();

        protected void Page_Load(object sender, EventArgs e)
        {
            //siempre conectado para navegar
            if (Session["userName"] == null)
            {
                Response.Redirect("/index.aspx");
            }

            Session["IDPERMISO"].ToString();
            txtIDPermiso.Text = Session["IDPERMISO"].ToString();
            lblUserName.Text = Session["userName"].ToString().ToUpper();
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("/index.aspx");
        }

        protected void btnValidacion_Click(object sender, EventArgs e)
        {
            string estado = ddlEstado.SelectedValue;
            decimal idPer = Convert.ToDecimal(Session["IDPERMISO"].ToString());
            var consulta = (from y in Conexion.Entidades.SOLICITUD
                            where y.ID_PERMISO == idPer
                            select y.ID_SOLICITUD).First();

            decimal idSOL = consulta;

            entiti.PKG_MODIFICAR_ESTADO(idPer, idSOL, estado);
            //entiti.SaveChanges();

            RESOLUCION resolucion = new RESOLUCION();

            var consulta1 = (from p in Conexion.Entidades.RESOLUCION select p.ID_RESOLUCION).Max();
            decimal ilRes= consulta1 + 1;

            resolucion.ID_SOLICITUD = idSOL;
            resolucion.ID_RESOLUCION = ilRes;
            resolucion.FECHA_RESOLUCION = DateTime.Today;
            resolucion.CODIGO = "Rel00" + ilRes;

            entiti.RESOLUCION.Add(resolucion);
            entiti.SaveChanges();

            lblPrueba.Text = "Permiso modificado";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/JI/autorizarPermiso.aspx");
        }

        
    }
}