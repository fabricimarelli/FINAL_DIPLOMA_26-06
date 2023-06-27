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
        private ReporteVueloPDF ReportePDF;
        private ReporteVueloEXCEL ReporteEXCEL;
        private ReporteCruzadoPDF ReporteCruzadoPDF;

        public frmReportes()
        {
            InitializeComponent();
            cVuelos = Vuelos.ObtenerInstancia();
            cAeronaves = Aeronaves.ObtenerInstancia();
            cSocios = Socios.ObtenerInstancia();
            cReservas = Reservas.ObtenerInstancia();
            ReportePDF=new ReporteVueloPDF();
            ReporteEXCEL=new ReporteVueloEXCEL();
            ReporteCruzadoPDF=new ReporteCruzadoPDF();
            GenerarGraficoBarras();
            GeneraGraficoTortaVuelos(DateTime.Now.AddMonths(-1),DateTime.Now);
            GeneraGraficoDonaReservas(DateTime.Now.AddMonths(-1), DateTime.Now);
            gbFiltrosVuelosReserv.Enabled = false;
        }


        private void btnVuelosExcel_Click(object sender, EventArgs e)
        {
            if (rbVuelos.Checked == true)
            {
                List<Vuelo> list = cVuelos.ObtenerVuelos(); // Obtén la lista de vuelos desde alguna fuente de datos
                ReporteEXCEL.GenerarReporte(list);
            }
            if (rbReservas.Checked == true)
            {
                btnReportExcel.Enabled = false;
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

        private void GeneraGraficoTortaVuelos(DateTime fechaInicio,DateTime fechaFin)
        {

            List<Vuelo> listaVuelos = cVuelos.ObtenerVuelos();
            List<Vuelo> vuelosUltimoMes = listaVuelos.Where(v => v.fechaVuelo >= fechaInicio && v.fechaVuelo <= fechaFin).ToList();


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

        private void GeneraGraficoDonaReservas(DateTime fechaInicio, DateTime fechaFin)
        {

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

        private void btnTempalte_Click(object sender, EventArgs e)
        {
            if (rbVuelos.Checked == true)
            {
                List<Vuelo> list = cVuelos.ObtenerVuelos(); // Obtén la lista de vuelos desde alguna fuente de datos
                ReportePDF.GenerarReporte(list);
            }
            if (rbReservas.Checked == true)
            {
                List<Vuelo> vuelos = cVuelos.ObtenerVuelos();
                List<Reserva> reservas = cReservas.ObtenerReservas();
                ReporteCruzadoPDF.GenerarReporte(vuelos,reservas);
            }
        }

        private void rbReservas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReservas.Checked == true)
            {
                btnReportExcel.Enabled = false;
            }
            else
            {
                btnReportExcel.Enabled = true;
            }
        }

        private void rbAeronaveVuelos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAeronaveVuelos.Checked == true)
            {
                cmbAeronaveVuelos.Enabled = true;
                txtDNI.Enabled = false;
            }
            else
            {
                cmbAeronaveVuelos.Enabled = false;
                txtDNI.Enabled = true;
            }
        }

        private void cbAplicaFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAplicaFiltros.Checked == true)
            {
                gbFiltrosVuelosReserv.Enabled = true;

            }
            else
            {
                gbFiltrosVuelosReserv.Enabled=false;
            }
        }

        private void btnFiltrosGraf_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value;
            DateTime fechaFin =dtpFin.Value;
            GeneraGraficoTortaVuelos(fechaInicio, fechaFin);
            GeneraGraficoDonaReservas(fechaInicio,fechaFin);
        }
    }
}
