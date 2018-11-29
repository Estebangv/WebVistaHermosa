using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALC;
using Negocio;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Image = iTextSharp.text.Image;

namespace webpruebas.JS
{
    public partial class resolucionesGenerales : System.Web.UI.Page
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

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("/index.aspx");
        }

        protected void btnPDFunidad_Click(object sender, EventArgs e)
        {
            string destopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Document doc = new Document(PageSize.LETTER);
            PdfWriter escritor = PdfWriter.GetInstance(doc, new FileStream(destopPath + @"\informe Unidad.pdf", FileMode.Create));
            doc.Open();

            Paragraph titulo = new Paragraph("Informe de Unidad \n" + ddlUnidad.SelectedValue, FontFactory.GetFont("arial", 40, 1, BaseColor.GRAY));
            titulo.Alignment = Element.ALIGN_CENTER;

            Paragraph fecha = new Paragraph("Fecha informe" + obtenerFecha(), FontFactory.GetFont("arial", 16, 1, BaseColor.GRAY));
            fecha.Alignment = Element.ALIGN_RIGHT;

            Paragraph subtittle = new Paragraph("Cantidad de solicitudes por unidad", FontFactory.GetFont("arial", 20, 1, BaseColor.GRAY));
            subtittle.Alignment = Element.ALIGN_CENTER;

            Paragraph body1 = new Paragraph("Solicitudes aprobadas: " + obtenerSolicitudA(), FontFactory.GetFont("arial", 32, 1, BaseColor.GRAY));
            body1.Alignment = Element.ALIGN_CENTER;

            Paragraph body2 = new Paragraph("Solicitudes rechazadas: " + obtenerSolicitudR(), FontFactory.GetFont("arial", 32, 1, BaseColor.GRAY));
            body2.Alignment = Element.ALIGN_CENTER;

            Paragraph body3 = new Paragraph("Solicitudes pendientes: " + obtenerSolicitudP(), FontFactory.GetFont("arial", 32, 1, BaseColor.GRAY));
            body3.Alignment = Element.ALIGN_CENTER;

            Paragraph cantidad = new Paragraph("Cantidad de solicitudes: " + obtenersoli(), FontFactory.GetFont("arial", 22, 1, BaseColor.GRAY));
            cantidad.Alignment = Element.ALIGN_CENTER;

            Paragraph pie = new Paragraph("Resolucion generada por sistema de permisos Ilustre municipalidad de Vista Hermosa ", FontFactory.GetFont("arial", 30, 1, BaseColor.GRAY));
            pie.Alignment = Element.ALIGN_CENTER;

            doc.Add(titulo);
            doc.Add(fecha);
            doc.Add(subtittle);
            doc.Add(body1);
            doc.Add(body2);
            doc.Add(body3);
            doc.Add(cantidad);
            doc.Add(pie);

            doc.Close();


        }




        public string obtenerFecha()
        {
            DateTime time = DateTime.Today;
            string date = time.ToString("dd/mm/yyyy");
            return date;
        }
        public int obtenerSolicitudA()
        {
            var consulta = (from s in Conexion.Entidades.SOLICITUD
                            where s.ESTADO == "APROBADO" && s.PERMISO.USUARIO.UNIDAD.ID_UNIDAD == ddlUnidad.SelectedIndex
                            select s.ID_SOLICITUD).Count();
            return consulta;
        }
        public int obtenerSolicitudR()
        {

            var consulta = (from s in Conexion.Entidades.SOLICITUD
                            where s.ESTADO == "RECHAZADO" && s.PERMISO.USUARIO.UNIDAD.ID_UNIDAD == ddlUnidad.SelectedIndex
                            select s.ID_SOLICITUD).Count();

            return consulta;
        }
        public int obtenerSolicitudP()
        {

            var consulta = (from s in Conexion.Entidades.SOLICITUD
                            where s.ESTADO == "PENDiENTE" && s.PERMISO.USUARIO.UNIDAD.ID_UNIDAD == ddlUnidad.SelectedIndex
                            select s.ID_SOLICITUD).Count();

            return consulta;
        }
        public int obtenersoli()
        {



            int soli = obtenerSolicitudA() + obtenerSolicitudP() + obtenerSolicitudR();
            return soli;
        }


    }
}