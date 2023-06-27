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
using System.Windows.Input;
using System.Windows.Media;

namespace MODELO
{
    public abstract class ReporteCruzado//PATRON TEMPLATE
    {
        public void GenerarReporte(List<Vuelo> vuelos, List<Reserva> reservas)
        {
            IniciarReporte();

            GenerarContenido(vuelos,reservas);

            FinalizarReporte();
        }

        protected abstract void IniciarReporte();
        protected abstract void GenerarContenido(List<Vuelo> vuelos,List<Reserva>reservas);
        protected abstract void FinalizarReporte();
    }

    public class ReporteCruzadoPDF : ReporteCruzado
    {
        Document document;
        PdfWriter writer;
        PdfPTable tabla;
        protected override void IniciarReporte()
        {
            document = new Document(PageSize.A4.Rotate());

            writer = PdfWriter.GetInstance(document, new FileStream("reporte.pdf", FileMode.Create));
            document.Open();

            //Imagen logo
            string imagePath = "C:\\Users\\fabri\\Desktop\\pictureBox1.Image.png";
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
            image.ScaleToFit(200f, 200f); // Ajustar el tamaño de la imagen
            image.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            document.Add(image);
            document.Add(new Paragraph("\n"));
            
            //Titulo del reporte
            Paragraph titulo = new Paragraph("Informe de Vuelos y Reservas", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);
            document.Add(new Paragraph("\n"));

            //Crear tabla
            tabla = new PdfPTable(11);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2});

        }

        protected override void GenerarContenido(List<Vuelo> vuelos, List<Reserva> reservas)
        {
            // Agregar encabezados de columna a la tabla
            tabla.AddCell(new PdfPCell(new Phrase("ID Reserva"))).BackgroundColor=BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("Fecha"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("Nombre"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("Apellido"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("DNI"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("Hora desde"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("Hora hasta"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("Aeronave"))).BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(new PdfPCell(new Phrase("ID Vuelo"))).BackgroundColor = BaseColor.CYAN;
            tabla.AddCell(new PdfPCell(new Phrase("Aeronave"))).BackgroundColor = BaseColor.CYAN;
            tabla.AddCell(new PdfPCell(new Phrase("Tiempo"))).BackgroundColor = BaseColor.CYAN;

            var datosCombinados = from reserva in reservas
                                  join vuelo in vuelos on new { reserva.Piloto.DNI, reserva.fecha.Date } equals new { vuelo.piloto.DNI, vuelo.fechaVuelo.Date } into joinedData
                                  from item in joinedData.DefaultIfEmpty()
                                  select new { Reserva = reserva, Vuelo = item };

            foreach (var item in datosCombinados)
            {
                // Obtener los valores de reserva y vuelo
                Reserva reserva = item.Reserva;
                Vuelo vuelo = item.Vuelo;

                tabla.AddCell(reserva.ID_reserva.ToString());
                tabla.AddCell(reserva.fecha.ToShortDateString());
                tabla.AddCell(reserva.Piloto.nombre.ToString());
                tabla.AddCell(reserva.Piloto.apellido.ToString());
                tabla.AddCell(reserva.Piloto.DNI.ToString());
                tabla.AddCell(reserva.desde.ToString("HH:mm"));
                tabla.AddCell(reserva.hasta.ToString("HH:mm"));
                tabla.AddCell(reserva.aeronave.matricula.ToString());
                tabla.AddCell(vuelo != null ? vuelo.ID_vuelo.ToString() : "");
                tabla.AddCell(vuelo != null ? vuelo.aeronave.matricula.ToString() : "");
                tabla.AddCell(vuelo != null ? vuelo.tiempo.ToString() : "");
            }


        }

        protected override void FinalizarReporte()
        {
            // Agregar la tabla al documento
            document.Add(tabla);

            // Cerrar el documento
            document.Close();

            // Abrir el cuadro de diálogo para descargar el archivo
            System.Diagnostics.Process.Start("reporte.pdf");
        }
    }
}