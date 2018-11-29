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

namespace webpruebas.Alcalde
{
    public partial class generarResoluciones : System.Web.UI.Page
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
            cargarResoluciones();
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            string code = txtRelCod.Text;

            string destopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (code != null)
            {
                Document doc = new Document(PageSize.LETTER);
                PdfWriter escritor = PdfWriter.GetInstance(doc, new FileStream(destopPath + @"\resolucion.pdf", FileMode.Create));
                doc.Open();

                Paragraph titulo = new Paragraph("RESOLUCION N°" + code, FontFactory.GetFont("arial", 40, 1, BaseColor.BLACK));
                titulo.Alignment = Element.ALIGN_CENTER;

                Paragraph fecha = new Paragraph("\n Fecha Resolucion: " + obtenerFecha(), FontFactory.GetFont("arial", 16, 3, BaseColor.BLACK));
                fecha.Alignment = Element.ALIGN_RIGHT;

                Paragraph codigo = new Paragraph("Codigo: " + obtenerCodigo(), FontFactory.GetFont("arial", 16, 3, BaseColor.BLACK));
                codigo.Alignment = Element.ALIGN_RIGHT;

                Paragraph nombre = new Paragraph("\n \n Sr/Sra: " + obtenerNombre(), FontFactory.GetFont("arial", 30, 1, BaseColor.BLACK));
                nombre.Alignment = Element.ALIGN_CENTER;

                Paragraph estado = new Paragraph("\n Se informa que el estado de su solicitud es " + obtenerEstado(), FontFactory.GetFont("arial", 22, 1, BaseColor.BLACK));
                estado.Alignment = Element.ALIGN_CENTER;

                Paragraph salto = new Paragraph("\n \n \n ", FontFactory.GetFont("arial", 22, 1, BaseColor.BLACK));
                salto.Alignment = Element.ALIGN_CENTER;

                Paragraph pie = new Paragraph("\n \n \n \n Resolucion generada por sistema de permisos Ilustre municipalidad de Vista Hermosa ",
                                             FontFactory.GetFont("arial", 12, 1, BaseColor.BLACK));
                pie.Alignment = Element.ALIGN_CENTER;

                Barcode codeBar = new Barcode128();
                codeBar.CodeType = Barcode.CODE128;
                codeBar.Code = obtenerCodigo();

                Image img = codeBar.CreateImageWithBarcode(escritor.DirectContentUnder, BaseColor.BLACK, BaseColor.BLACK);
                img.Alignment = Element.ALIGN_CENTER;
                img.ScalePercent(250);

                doc.Add(titulo);
                doc.Add(fecha);
                doc.Add(codigo);
                doc.Add(nombre);
                doc.Add(estado);
                doc.Add(salto);
                doc.Add(img);
                doc.Add(pie);

                doc.Close();
            }


        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Alcalde/menuAlcalde.aspx");
        }

        public void cargarResoluciones()
        {
            var consulta = from r in Conexion.Entidades.RESOLUCION
                           select new
                           {
                               r.ID_RESOLUCION,
                               r.SOLICITUD.ID_SOLICITUD,
                               r.FECHA_RESOLUCION,
                               r.CODIGO,
                               r.SOLICITUD.ESTADO,
                               r.SOLICITUD.PERMISO.USUARIO.RUT,
                               r.SOLICITUD.PERMISO.USUARIO.NOMBRE,
                               r.SOLICITUD.PERMISO.USUARIO.A_PATERNO
                           };
            GvResol.DataSource = consulta.ToList();
            GvResol.DataBind();
        }

        public string obtenerFecha()
        {
            decimal id = Convert.ToDecimal(txtRelCod.Text);

            var consulta = (from r in Conexion.Entidades.RESOLUCION where id == r.ID_RESOLUCION select r.FECHA_RESOLUCION).Max();

            string date = consulta.ToString("dd/MM/yyyy");
            return date;
        }

        public string obtenerNombre()
        {
            decimal id = Convert.ToDecimal(txtRelCod.Text);

            var consultaN = (from r in Conexion.Entidades.RESOLUCION
                             where id == r.ID_RESOLUCION
                             select r.SOLICITUD.PERMISO.USUARIO.NOMBRE).Max();
            var consultaP = (from r in Conexion.Entidades.RESOLUCION
                             where id == r.ID_RESOLUCION
                             select r.SOLICITUD.PERMISO.USUARIO.A_PATERNO).Max();
            var consultaM = (from r in Conexion.Entidades.RESOLUCION
                             where id == r.ID_RESOLUCION
                             select r.SOLICITUD.PERMISO.USUARIO.A_MATERNO).Max();
            string nombreCompleto = consultaN + " " + consultaP + " " + consultaM;
            return nombreCompleto.ToUpper();
        }

        public string obtenerCodigo()
        {
            decimal id = Convert.ToDecimal(txtRelCod.Text);

            var consulta = (from r in Conexion.Entidades.RESOLUCION
                            where id == r.ID_RESOLUCION
                            select r.CODIGO).Max();

            return consulta;
        }

        public string obtenerEstado()
        {
            decimal id = Convert.ToDecimal(txtRelCod.Text);

            var consulta = (from r in Conexion.Entidades.RESOLUCION
                            where id == r.ID_RESOLUCION
                            select r.SOLICITUD.ESTADO).Max();

            return consulta;
        }
    }
}