using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CONTROLADORA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MODELO;
using OfficeOpenXml;
using System.IO;
using System.Xml.Linq;

namespace MODELO
{
    public abstract class ReporteAudit//PATRON TEMPLATE
    {
        public void GenerarReporte(List<Auditoria> list)
        {
            IniciarReporte();

            GenerarContenido(list);

            FinalizarReporte();
        }

        protected abstract void IniciarReporte();
        protected abstract void GenerarContenido(List<Auditoria> list);
        protected abstract void FinalizarReporte();
    }

    public class ReporteAuditPDF : ReporteAudit
    {
        Document document;
        PdfPTable table;

        protected override void IniciarReporte()
        {
            // Crear el documento PDF y lo abro
            document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("ReporteAuditoria.pdf", FileMode.Create));
            document.Open();

            table = new PdfPTable(4);
            string imagePath = "C:\\Users\\fabri\\Desktop\\pictureBox1.Image.png";

            //Imagen
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
            image.ScaleToFit(200f, 200f); // Ajustar el tamaño de la imagen
            image.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            document.Add(image);
            document.Add(new Paragraph("\n"));

            // Agregar título al documento
            Paragraph titulo = new Paragraph("Reporte de Auditoria");
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);
            document.Add(new Paragraph("\n"));

            // Agregar encabezados de columnas
            table.AddCell("ID");
            table.AddCell("Username");
            table.AddCell("Operacion");
            table.AddCell("Fecha y hora");

        }

        protected override void GenerarContenido(List<Auditoria> list)
        {

            // Agregar filas con los datos de cada vuelo
            foreach (Auditoria auditoria in list)
            {
                table.AddCell(auditoria.ID_audit.ToString());
                table.AddCell(auditoria.usuario.ToString());
                table.AddCell(auditoria.tipoOperacion.ToString());
                table.AddCell(auditoria.fechaHora.ToString());
            }

            // Ajustar el tamaño de las columnas al tamaño de los datos
            table.WidthPercentage = 100; // Establecer el ancho de la tabla al 100% del ancho disponible
            table.SetWidths(new float[] { 1f, 1f, 1f, 1f}); // Establecer el ancho relativo de cada columna

            document.Add(table);
            document.Close();
        }

        protected override void FinalizarReporte()
        {
            // Abrir el cuadro de diálogo para descargar el archivo
            System.Diagnostics.Process.Start("ReporteAuditoria.pdf");
        }
    }
}
