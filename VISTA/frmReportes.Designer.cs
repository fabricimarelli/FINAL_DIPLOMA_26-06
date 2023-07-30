namespace VISTA
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbGenReportes = new System.Windows.Forms.GroupBox();
            this.rbReservas = new System.Windows.Forms.RadioButton();
            this.rbVuelos = new System.Windows.Forms.RadioButton();
            this.btnTempalte = new System.Windows.Forms.Button();
            this.gbFiltrosVuelosReserv = new System.Windows.Forms.GroupBox();
            this.cmbAeronaveVuelos = new System.Windows.Forms.ComboBox();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbAeronaveVuelos = new System.Windows.Forms.RadioButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cbAplicaFiltros = new System.Windows.Forms.CheckBox();
            this.btnReportExcel = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbFiltrosGraficos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrosGraf = new System.Windows.Forms.Button();
            this.rbAuditoria = new System.Windows.Forms.RadioButton();
            this.gbGenReportes.SuspendLayout();
            this.gbFiltrosVuelosReserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.gbFiltrosGraficos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGenReportes
            // 
            this.gbGenReportes.Controls.Add(this.rbAuditoria);
            this.gbGenReportes.Controls.Add(this.rbReservas);
            this.gbGenReportes.Controls.Add(this.rbVuelos);
            this.gbGenReportes.Controls.Add(this.btnTempalte);
            this.gbGenReportes.Controls.Add(this.gbFiltrosVuelosReserv);
            this.gbGenReportes.Controls.Add(this.cbAplicaFiltros);
            this.gbGenReportes.Controls.Add(this.btnReportExcel);
            this.gbGenReportes.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbGenReportes.ForeColor = System.Drawing.Color.White;
            this.gbGenReportes.Location = new System.Drawing.Point(12, 12);
            this.gbGenReportes.Name = "gbGenReportes";
            this.gbGenReportes.Size = new System.Drawing.Size(453, 385);
            this.gbGenReportes.TabIndex = 47;
            this.gbGenReportes.TabStop = false;
            this.gbGenReportes.Text = "Generador de reportes";
            // 
            // rbReservas
            // 
            this.rbReservas.AutoSize = true;
            this.rbReservas.Location = new System.Drawing.Point(156, 57);
            this.rbReservas.Name = "rbReservas";
            this.rbReservas.Size = new System.Drawing.Size(105, 25);
            this.rbReservas.TabIndex = 20;
            this.rbReservas.TabStop = true;
            this.rbReservas.Text = "Reservas";
            this.rbReservas.UseVisualStyleBackColor = true;
            this.rbReservas.CheckedChanged += new System.EventHandler(this.rbReservas_CheckedChanged);
            // 
            // rbVuelos
            // 
            this.rbVuelos.AutoSize = true;
            this.rbVuelos.Location = new System.Drawing.Point(31, 57);
            this.rbVuelos.Name = "rbVuelos";
            this.rbVuelos.Size = new System.Drawing.Size(86, 25);
            this.rbVuelos.TabIndex = 18;
            this.rbVuelos.TabStop = true;
            this.rbVuelos.Text = "Vuelos";
            this.rbVuelos.UseVisualStyleBackColor = true;
            // 
            // btnTempalte
            // 
            this.btnTempalte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTempalte.FlatAppearance.BorderSize = 0;
            this.btnTempalte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTempalte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnTempalte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempalte.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempalte.Location = new System.Drawing.Point(20, 309);
            this.btnTempalte.Name = "btnTempalte";
            this.btnTempalte.Size = new System.Drawing.Size(185, 40);
            this.btnTempalte.TabIndex = 51;
            this.btnTempalte.Text = "Generar PDF";
            this.btnTempalte.UseVisualStyleBackColor = false;
            this.btnTempalte.Click += new System.EventHandler(this.btnTempalte_Click);
            // 
            // gbFiltrosVuelosReserv
            // 
            this.gbFiltrosVuelosReserv.Controls.Add(this.cmbAeronaveVuelos);
            this.gbFiltrosVuelosReserv.Controls.Add(this.rbDNI);
            this.gbFiltrosVuelosReserv.Controls.Add(this.rbAeronaveVuelos);
            this.gbFiltrosVuelosReserv.Controls.Add(this.txtDNI);
            this.gbFiltrosVuelosReserv.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbFiltrosVuelosReserv.ForeColor = System.Drawing.Color.White;
            this.gbFiltrosVuelosReserv.Location = new System.Drawing.Point(6, 132);
            this.gbFiltrosVuelosReserv.Name = "gbFiltrosVuelosReserv";
            this.gbFiltrosVuelosReserv.Size = new System.Drawing.Size(441, 148);
            this.gbFiltrosVuelosReserv.TabIndex = 50;
            this.gbFiltrosVuelosReserv.TabStop = false;
            this.gbFiltrosVuelosReserv.Text = "Filtros vuelos y reservas";
            // 
            // cmbAeronaveVuelos
            // 
            this.cmbAeronaveVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAeronaveVuelos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cmbAeronaveVuelos.ForeColor = System.Drawing.Color.White;
            this.cmbAeronaveVuelos.FormattingEnabled = true;
            this.cmbAeronaveVuelos.Location = new System.Drawing.Point(186, 40);
            this.cmbAeronaveVuelos.Name = "cmbAeronaveVuelos";
            this.cmbAeronaveVuelos.Size = new System.Drawing.Size(199, 29);
            this.cmbAeronaveVuelos.TabIndex = 47;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(25, 94);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(62, 25);
            this.rbDNI.TabIndex = 46;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // rbAeronaveVuelos
            // 
            this.rbAeronaveVuelos.AutoSize = true;
            this.rbAeronaveVuelos.Location = new System.Drawing.Point(25, 41);
            this.rbAeronaveVuelos.Name = "rbAeronaveVuelos";
            this.rbAeronaveVuelos.Size = new System.Drawing.Size(115, 25);
            this.rbAeronaveVuelos.TabIndex = 45;
            this.rbAeronaveVuelos.TabStop = true;
            this.rbAeronaveVuelos.Text = "Aeronave";
            this.rbAeronaveVuelos.UseVisualStyleBackColor = true;
            this.rbAeronaveVuelos.CheckedChanged += new System.EventHandler(this.rbAeronaveVuelos_CheckedChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtDNI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDNI.Location = new System.Drawing.Point(186, 91);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(199, 28);
            this.txtDNI.TabIndex = 42;
            // 
            // cbAplicaFiltros
            // 
            this.cbAplicaFiltros.AutoSize = true;
            this.cbAplicaFiltros.Location = new System.Drawing.Point(9, 101);
            this.cbAplicaFiltros.Name = "cbAplicaFiltros";
            this.cbAplicaFiltros.Size = new System.Drawing.Size(137, 25);
            this.cbAplicaFiltros.TabIndex = 50;
            this.cbAplicaFiltros.Text = "Aplicar filtros";
            this.cbAplicaFiltros.UseVisualStyleBackColor = true;
            this.cbAplicaFiltros.CheckedChanged += new System.EventHandler(this.cbAplicaFiltros_CheckedChanged);
            // 
            // btnReportExcel
            // 
            this.btnReportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportExcel.FlatAppearance.BorderSize = 0;
            this.btnReportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportExcel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportExcel.Location = new System.Drawing.Point(245, 309);
            this.btnReportExcel.Name = "btnReportExcel";
            this.btnReportExcel.Size = new System.Drawing.Size(187, 40);
            this.btnReportExcel.TabIndex = 17;
            this.btnReportExcel.Text = "Generar Excel";
            this.btnReportExcel.UseVisualStyleBackColor = false;
            this.btnReportExcel.Click += new System.EventHandler(this.btnVuelosExcel_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(471, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1107, 385);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "Taquimetro";
            title1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Taquimetro de aeronaves";
            title1.Text = "Taquimetro aeronaves";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(505, 403);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(480, 399);
            this.chart2.TabIndex = 49;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Horas aeronaves ";
            this.chart2.Titles.Add(title2);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(1047, 403);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(480, 398);
            this.chart3.TabIndex = 50;
            this.chart3.Text = "chart3";
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Reservas aeronaves";
            this.chart3.Titles.Add(title3);
            // 
            // gbFiltrosGraficos
            // 
            this.gbFiltrosGraficos.Controls.Add(this.label1);
            this.gbFiltrosGraficos.Controls.Add(this.label5);
            this.gbFiltrosGraficos.Controls.Add(this.dtpFin);
            this.gbFiltrosGraficos.Controls.Add(this.dtpInicio);
            this.gbFiltrosGraficos.Controls.Add(this.btnFiltrosGraf);
            this.gbFiltrosGraficos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbFiltrosGraficos.ForeColor = System.Drawing.Color.White;
            this.gbFiltrosGraficos.Location = new System.Drawing.Point(12, 416);
            this.gbFiltrosGraficos.Name = "gbFiltrosGraficos";
            this.gbFiltrosGraficos.Size = new System.Drawing.Size(453, 385);
            this.gbFiltrosGraficos.TabIndex = 51;
            this.gbFiltrosGraficos.TabStop = false;
            this.gbFiltrosGraficos.Text = "Filtros Gráficos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha inicio";
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "HH:mm";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(156, 159);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFin.Size = new System.Drawing.Size(139, 28);
            this.dtpFin.TabIndex = 42;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(156, 86);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpInicio.Size = new System.Drawing.Size(139, 28);
            this.dtpInicio.TabIndex = 41;
            // 
            // btnFiltrosGraf
            // 
            this.btnFiltrosGraf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFiltrosGraf.FlatAppearance.BorderSize = 0;
            this.btnFiltrosGraf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFiltrosGraf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnFiltrosGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrosGraf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrosGraf.Location = new System.Drawing.Point(136, 273);
            this.btnFiltrosGraf.Name = "btnFiltrosGraf";
            this.btnFiltrosGraf.Size = new System.Drawing.Size(187, 40);
            this.btnFiltrosGraf.TabIndex = 17;
            this.btnFiltrosGraf.Text = "Aplicar";
            this.btnFiltrosGraf.UseVisualStyleBackColor = false;
            this.btnFiltrosGraf.Click += new System.EventHandler(this.btnFiltrosGraf_Click);
            // 
            // rbAuditoria
            // 
            this.rbAuditoria.AutoSize = true;
            this.rbAuditoria.Location = new System.Drawing.Point(305, 57);
            this.rbAuditoria.Name = "rbAuditoria";
            this.rbAuditoria.Size = new System.Drawing.Size(107, 25);
            this.rbAuditoria.TabIndex = 52;
            this.rbAuditoria.TabStop = true;
            this.rbAuditoria.Text = "Auditoria";
            this.rbAuditoria.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1580, 815);
            this.Controls.Add(this.gbFiltrosGraficos);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gbGenReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.gbGenReportes.ResumeLayout(false);
            this.gbGenReportes.PerformLayout();
            this.gbFiltrosVuelosReserv.ResumeLayout(false);
            this.gbFiltrosVuelosReserv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.gbFiltrosGraficos.ResumeLayout(false);
            this.gbFiltrosGraficos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenReportes;
        private System.Windows.Forms.Button btnReportExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rbReservas;
        private System.Windows.Forms.RadioButton rbVuelos;
        private System.Windows.Forms.GroupBox gbFiltrosVuelosReserv;
        private System.Windows.Forms.ComboBox cmbAeronaveVuelos;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.RadioButton rbAeronaveVuelos;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.CheckBox cbAplicaFiltros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button btnTempalte;
        private System.Windows.Forms.GroupBox gbFiltrosGraficos;
        private System.Windows.Forms.Button btnFiltrosGraf;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbAuditoria;
    }
}