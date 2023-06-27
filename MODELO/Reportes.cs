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
    public abstract class Reportes//PATRON TEMPLATE
    {
        public void GenerarReporte(List<Vuelo> list)
        {
            IniciarReporte();

            GenerarContenido(list);

            FinalizarReporte();
        }

        protected abstract void IniciarReporte();
        protected abstract void GenerarContenido(List<Vuelo> list);
        protected abstract void FinalizarReporte();
    }

    public class ReporteVueloPDF : Reportes
    {
        Document document;
        PdfPTable table;

        protected override void IniciarReporte()
        {
            // Crear el documento PDF y lo abro
            document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("ReporteVuelos.pdf", FileMode.Create));
            document.Open();

            table = new PdfPTable(6);
            string imagePath = "C:\\Users\\fabri\\Desktop\\pictureBox1.Image.png";

            //Imagen
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
            image.ScaleToFit(200f, 200f); // Ajustar el tamaño de la imagen
            image.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            document.Add(image);
            document.Add(new Paragraph("\n"));

            // Agregar título al documento
            Paragraph titulo = new Paragraph("Reporte de Vuelos");
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);
            document.Add(new Paragraph("\n"));

            // Agregar encabezados de columnas
            table.AddCell("ID Vuelo");
            table.AddCell("Fecha de vuelo");
            table.AddCell("Aeronave");
            table.AddCell("Piloto");
            table.AddCell("Tiempo");
            table.AddCell("Tarifa");

        }

        protected override void GenerarContenido(List<Vuelo> list)
        {

            // Agregar filas con los datos de cada vuelo
            foreach (Vuelo vuelo in list)
            {
                table.AddCell(vuelo.ID_vuelo.ToString());
                table.AddCell(vuelo.fechaVuelo.ToShortDateString());
                table.AddCell(vuelo.aeronave.ToString());
                table.AddCell(vuelo.piloto.ToString());
                table.AddCell(vuelo.tiempo.ToString());
                table.AddCell("$" + vuelo.tarifa.ToString());
            }

            // Ajustar el tamaño de las columnas al tamaño de los datos
            table.WidthPercentage = 100; // Establecer el ancho de la tabla al 100% del ancho disponible
            table.SetWidths(new float[] { 1f, 1f, 1f, 1f, 1f, 1f }); // Establecer el ancho relativo de cada columna

            document.Add(table);
            document.Close();
        }

        protected override void FinalizarReporte()
        {
            // Abrir el cuadro de diálogo para descargar el archivo
            System.Diagnostics.Process.Start("ReporteVuelos.pdf");
        }
    }

    public class ReporteVueloEXCEL : Reportes
    {
        ExcelPackage excelPackage;
        ExcelWorksheet worksheet;
        protected override void IniciarReporte()
        {
            // Crear el archivo Excel
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            excelPackage = new ExcelPackage();

            worksheet = excelPackage.Workbook.Worksheets.Add("Reporte Vuelos");

            // Escribir los encabezados de columna
            worksheet.Cells[1, 1].Value = "ID Vuelo";
            worksheet.Cells[1, 2].Value = "Fecha vuelo";
            worksheet.Cells[1, 3].Value = "Matricula Aeronave";
            worksheet.Cells[1, 4].Value = "Nombre Piloto";
            worksheet.Cells[1, 5].Value = "Apellido Piloto";
            worksheet.Cells[1, 6].Value = "DNI Piloto";
            worksheet.Cells[1, 7].Value = "Tiempo";
            worksheet.Cells[1, 8].Value = "Taquimetro Salida";
            worksheet.Cells[1, 9].Value = "Taquimetro Llegada";
            worksheet.Cells[1, 10].Value = "Tarifa";
            worksheet.Cells[1, 11].Value = "Observaciones";
        }

        protected override void GenerarContenido(List<Vuelo> list)
        {
            int row = 2;
            foreach (Vuelo vuelo in list)
            {
                worksheet.Cells[row, 1].Value = vuelo.ID_vuelo;
                worksheet.Cells[row, 2].Value = vuelo.fechaVuelo;
                worksheet.Cells[row, 3].Value = vuelo.aeronave.ToString();
                worksheet.Cells[row, 4].Value = vuelo.piloto.nombre;
                worksheet.Cells[row, 5].Value = vuelo.piloto.apellido;
                worksheet.Cells[row, 6].Value = vuelo.piloto.DNI;
                worksheet.Cells[row, 7].Value = vuelo.tiempo.ToString();
                worksheet.Cells[row, 8].Value = vuelo.taquimSalida.ToString();
                worksheet.Cells[row, 9].Value = vuelo.taquimLlegada.ToString();
                worksheet.Cells[row, 10].Value = vuelo.tarifa.ToString();
                worksheet.Cells[row, 11].Value = vuelo.observaciones.ToString();

                row++;
            }

        }

        protected override void FinalizarReporte()
        {
            // Guardar el archivo Excel en un MemoryStream
            MemoryStream memoryStream = new MemoryStream();
            excelPackage.SaveAs(memoryStream);

            // Descargar el archivo Excel
            byte[] bytes = memoryStream.ToArray();
            memoryStream.Close();

            File.WriteAllBytes("ReporteVuelos.xlsx", bytes);

            // Abrir el cuadro de diálogo para descargar el archivo
            System.Diagnostics.Process.Start("ReporteVuelos.xlsx");
        }

    }
}
