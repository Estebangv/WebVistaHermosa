using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALC;
using Negocio;

namespace webpruebas
{
    public partial class verPermiso1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //siempre conectado para navegar
            if (Session["userName"] == null)
            {
                Response.Redirect("/index.aspx");
            }

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
            //Decimal unidadValidacion = Session["unidad"].ToString();

            var consulta = from s in Conexion.Entidades.SOLICITUD
                            where s.PERMISO.ID_USUARIO == rutValidacion
                            select new
                            {
                                s.ID_PERMISO,
                                s.PERMISO.MOTIVO.NOMBREMOTIVO,
                                s.PERMISO.TIPO_PERMISO.NOMBREPERMISO,
                                s.PERMISO.TIPO_PERMISO.DIAS,
                                s.PERMISO.DESCRIPCION,
                                s.FECHA_SOLICITUD,
                                s.ESTADO
                            };

            gridPermisos.DataSource = consulta.ToList();
            gridPermisos.DataBind();

            //Response.Redirect("JI/autorizarPermiso.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            string rut = Session["userID"].ToString();
            var consulta = from usu in Conexion.Entidades.USUARIO
                           select new
                           {
                               usu.ID_TIPOUSUARIO,
                               usu.RUT
                           };

            foreach (var x in consulta)
            {
                if (x.RUT == rut)
                {
                    /*5 FUNCIONARIO*/
                    if (x.ID_TIPOUSUARIO == 5)
                    {
                        Response.Redirect("/Funcionario/menuFuncionario.aspx");

                    }
                    /*2*/
                    else if (x.ID_TIPOUSUARIO == 2)
                    {
                        Response.Redirect("/JI/menuJI.aspx");
                    }
                    /*3*/
                    else if (x.ID_TIPOUSUARIO == 3)
                    {
                        Response.Redirect("/JS/menuJS.aspx");
                    }
                    /*4*/
                    else if (x.ID_TIPOUSUARIO == 4)
                    {
                        Response.Redirect("/Alcalde/menuAlcalde.aspx");
                    }
                }
            }
        }

    }
}