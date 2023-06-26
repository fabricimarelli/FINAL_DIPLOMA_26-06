using CONTROLADORA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MODELO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VISTA
{
    public partial class frmReportes : Form
    {
        private static frmReportes instancia;
        public static frmReportes OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmReportes();
            if (instancia.IsDisposed)
                instancia = new frmReportes();
            return instancia;
        }

        private Vuelos cVuelos;
        private Aeronaves cAeronaves;
        private Socios cSocios;
        private Reservas cReservas;

        public frmReportes()
        {
            InitializeComponent();
            cVuelos = Vuelos.ObtenerInstancia();
            cAeronaves = Aeronaves.ObtenerInstancia();
            cSocios = Socios.ObtenerInstancia();
            cReservas = Reservas.ObtenerInstancia();
            GenerarGraficoBarras();
            GeneraGraficoTortaVuelos();
            GeneraGraficoDonaReservas();
        }

        private void btnVuelosPDF_Click(object sender, EventArgs e)
        {
            List<Vuelo> listaVuelos = cVuelos.ObtenerVuelos(); // Obtén la lista de vuelos desde alguna fuente de datos

            // Crear el documento PDF
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("ReporteVuelos.pdf", FileMode.Create));

            document.Open();

            // Agregar el contenido al documento
            PdfPTable table = new PdfPTable(3); // Puedes ajustar el número de columnas según tus necesidades

            // Agregar encabezados de columnas
            //table.AddCell("ID Vuelo");
            table.AddCell("Fecha de vuelo");
            table.AddCell("Aeronave");
            table.AddCell("Piloto");
            //table.AddCell("Tiempo");
            //table.AddCell("Tarifa");

            // Agregar filas con los datos de cada vuelo
            foreach (Vuelo vuelo in listaVuelos)
            {
                //table.AddCell(vuelo.ID_vuelo.ToString());
                table.AddCell(vuelo.fechaVuelo.ToString());
                table.AddCell(vuelo.aeronave.ToString());
                table.AddCell(vuelo.piloto.ToString());
                //table.AddCell(vuelo.tiempo.ToString());
                //table.AddCell(vuelo.tarifa.ToString());
            }

            document.Add(table);
            document.Close();

            // Abrir el cuadro de diálogo para descargar el archivo
            System.Diagnostics.Process.Start("ReporteVuelos.pdf");
        }

        private void btnVuelosExcel_Click(object sender, EventArgs e)
        {
            List<Vuelo> listaVuelos = cVuelos.ObtenerVuelos(); // Obtén la lista de vuelos desde alguna fuente de datos

            // Crear el archivo Excel
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Reporte Vuelos");

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

                // Escribir los datos de cada vuelo
                int row = 2;
                foreach (Vuelo vuelo in listaVuelos)
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

        private void GenerarGraficoBarras()
        {
            List<Aeronave> listaAviones = cAeronaves.ObtenerAeronaves();

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("Area"));
            chart1.Series.Add(new Series("Barras"));

            chart1.Series["Barras"].ChartType = SeriesChartType.Bar;
            chart1.Series["Barras"].XValueType = ChartValueType.String;
            chart1.ChartAreas["Area"].BackColor = Color.FromArgb(49, 66, 82);
            chart1.ChartAreas["Area"].AxisX.LineColor = Color.White;
            chart1.ChartAreas["Area"].AxisY.LineColor = Color.White;
            chart1.ChartAreas["Area"].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas["Area"].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas["Area"].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas["Area"].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas["Area"].AxisY.Interval = 500;
            chart1.ChartAreas["Area"].AxisY.IntervalType = DateTimeIntervalType.Number;
            chart1.Series["Barras"].IsValueShownAsLabel = true;
            chart1.Series["Barras"].LabelForeColor = Color.White;
            chart1.Series["Barras"].LabelBackColor = Color.FromArgb(49, 66, 82);
            chart1.Series["Barras"].LabelFormat = "0.##";
            chart1.Series["Barras"].IsVisibleInLegend = false;


            foreach (Aeronave avion in listaAviones)
            {
                string matricula = avion.matricula;
                decimal taquimetro = avion.taquimetro;

                chart1.Series["Barras"].Points.AddXY(matricula, taquimetro);
            }

            chart1.Update();
        }

        private void GeneraGraficoTortaVuelos()
        {
            DateTime fechaInicio = DateTime.Now.AddMonths(-1);
            DateTime fechaFin = DateTime.Now;

            List<Vuelo> listaVuelos = cVuelos.ObtenerVuelos();
            List<Vuelo> vuelosUltimoMes = listaVuelos.Where(v => v.fechaVuelo >= fechaInicio && v.fechaVuelo <= fechaFin).ToList();

            // Calcular las horas de vuelo por aeronave
            /*var horasPorAeronave = vuelosUltimoMes.GroupBy(v => v.aeronave)
                                                  .Select(g => new { Aeronave = g.Key, HorasVuelo = g.Sum(v => v.tiempo) });*/

            // Crear instancia del control Chart
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.ChartAreas.Add(new ChartArea("Area"));
            chart2.Size = new Size(400, 300);

            // Configurar tipo de gráfico
            chart2.Series.Add("Horas de Vuelo");
            chart2.Series["Horas de Vuelo"].ChartType = SeriesChartType.Pie;
            chart2.Series["Horas de Vuelo"].IsValueShownAsLabel = true;
            chart2.BackColor = Color.FromArgb(49, 66, 82);
            chart2.ChartAreas["Area"].BackColor = Color.FromArgb(49, 66, 82);

            Dictionary<Aeronave, decimal> horasPorAeronave = new Dictionary<Aeronave, decimal>();

            foreach (var vuelo in vuelosUltimoMes)
            {
                if (horasPorAeronave.ContainsKey(vuelo.aeronave))
                {
                    horasPorAeronave[vuelo.aeronave] += vuelo.tiempo;
                }
                else
                {
                    horasPorAeronave[vuelo.aeronave] = vuelo.tiempo;
                }
            }

            // Agregar datos al gráfico
            foreach (var item in horasPorAeronave)
            {
                chart2.Series["Horas de Vuelo"].Points.AddXY(item.Key.matricula, item.Value);
            }

            // Mostrar el gráfico en tu formulario
            this.Controls.Add(chart2);
        }

        private void GeneraGraficoDonaReservas()
        {
            // Obtener los registros de reservas del último mes
            DateTime fechaInicio = DateTime.Now.AddMonths(-1);
            DateTime fechaFin = DateTime.Now;

            List<Reserva> listaReservas = cReservas.ObtenerReservas();
            List<Reserva> reservasDelUltimoMes = listaReservas.Where(v => v.fecha >= fechaInicio && v.fecha <= fechaFin).ToList();

            // Crear instancia del control Chart
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();
            chart3.ChartAreas.Add(new ChartArea("Area"));
            chart3.Size = new Size(400, 300);

            // Configurar tipo de gráfico
            chart3.Series.Add("Reservas de aeronave");
            chart3.Series["Reservas de aeronave"].ChartType = SeriesChartType.Doughnut;
            chart3.Series["Reservas de aeronave"].IsValueShownAsLabel = true;
            chart3.BackColor = Color.FromArgb(49, 66, 82);
            chart3.ChartAreas["Area"].BackColor = Color.FromArgb(49, 66, 82);

            Dictionary<Aeronave, int> reservasPorAeronave = new Dictionary<Aeronave, int>();

            foreach (var reserva in reservasDelUltimoMes)
            {
                if (reservasPorAeronave.ContainsKey(reserva.aeronave))
                {
                    reservasPorAeronave[reserva.aeronave]++;
                }
                else
                {
                    reservasPorAeronave[reserva.aeronave] = 1;
                }
            }
            
            // Agregar los datos al gráfico
            foreach (var item in reservasPorAeronave)
            {
                chart3.Series["Reservas de aeronave"].Points.AddXY(item.Key.matricula, item.Value);
            }
            
            this.Controls.Add(chart3);
        }

    }
}
