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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbGenReportes = new System.Windows.Forms.GroupBox();
            this.cbAplicaFiltros = new System.Windows.Forms.CheckBox();
            this.gbFiltrosMant = new System.Windows.Forms.GroupBox();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbProceso = new System.Windows.Forms.RadioButton();
            this.cmbAeronaveMant = new System.Windows.Forms.ComboBox();
            this.rbAeronaveMant = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.gbEntidades = new System.Windows.Forms.GroupBox();
            this.rbVuelos = new System.Windows.Forms.RadioButton();
            this.rbReservas = new System.Windows.Forms.RadioButton();
            this.rbMantenimientos = new System.Windows.Forms.RadioButton();
            this.btnReportExcel = new System.Windows.Forms.Button();
            this.btnReportPDF = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbFiltrosVuelosReserv = new System.Windows.Forms.GroupBox();
            this.cmbAeronaveVuelos = new System.Windows.Forms.ComboBox();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbAeronaveVuelos = new System.Windows.Forms.RadioButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbGenReportes.SuspendLayout();
            this.gbFiltrosMant.SuspendLayout();
            this.gbEstados.SuspendLayout();
            this.gbEntidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbFiltrosVuelosReserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGenReportes
            // 
            this.gbGenReportes.Controls.Add(this.gbFiltrosVuelosReserv);
            this.gbGenReportes.Controls.Add(this.cbAplicaFiltros);
            this.gbGenReportes.Controls.Add(this.gbFiltrosMant);
            this.gbGenReportes.Controls.Add(this.gbEntidades);
            this.gbGenReportes.Controls.Add(this.btnReportExcel);
            this.gbGenReportes.Controls.Add(this.btnReportPDF);
            this.gbGenReportes.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbGenReportes.ForeColor = System.Drawing.Color.White;
            this.gbGenReportes.Location = new System.Drawing.Point(12, 12);
            this.gbGenReportes.Name = "gbGenReportes";
            this.gbGenReportes.Size = new System.Drawing.Size(453, 791);
            this.gbGenReportes.TabIndex = 47;
            this.gbGenReportes.TabStop = false;
            this.gbGenReportes.Text = "Generador de reportes";
            // 
            // cbAplicaFiltros
            // 
            this.cbAplicaFiltros.AutoSize = true;
            this.cbAplicaFiltros.Location = new System.Drawing.Point(24, 167);
            this.cbAplicaFiltros.Name = "cbAplicaFiltros";
            this.cbAplicaFiltros.Size = new System.Drawing.Size(137, 25);
            this.cbAplicaFiltros.TabIndex = 50;
            this.cbAplicaFiltros.Text = "Aplicar filtros";
            this.cbAplicaFiltros.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosMant
            // 
            this.gbFiltrosMant.Controls.Add(this.gbEstados);
            this.gbFiltrosMant.Controls.Add(this.cmbAeronaveMant);
            this.gbFiltrosMant.Controls.Add(this.rbAeronaveMant);
            this.gbFiltrosMant.Controls.Add(this.rbEstado);
            this.gbFiltrosMant.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbFiltrosMant.ForeColor = System.Drawing.Color.White;
            this.gbFiltrosMant.Location = new System.Drawing.Point(6, 207);
            this.gbFiltrosMant.Name = "gbFiltrosMant";
            this.gbFiltrosMant.Size = new System.Drawing.Size(441, 232);
            this.gbFiltrosMant.TabIndex = 49;
            this.gbFiltrosMant.TabStop = false;
            this.gbFiltrosMant.Text = "Filtros mantenimiento";
            // 
            // gbEstados
            // 
            this.gbEstados.Controls.Add(this.rbFinalizado);
            this.gbEstados.Controls.Add(this.rbPendiente);
            this.gbEstados.Controls.Add(this.rbProceso);
            this.gbEstados.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbEstados.ForeColor = System.Drawing.Color.White;
            this.gbEstados.Location = new System.Drawing.Point(186, 27);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(199, 134);
            this.gbEstados.TabIndex = 51;
            this.gbEstados.TabStop = false;
            this.gbEstados.Text = "Estado";
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(18, 92);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(140, 31);
            this.rbFinalizado.TabIndex = 52;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Location = new System.Drawing.Point(18, 61);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(145, 31);
            this.rbPendiente.TabIndex = 52;
            this.rbPendiente.TabStop = true;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbProceso
            // 
            this.rbProceso.AutoSize = true;
            this.rbProceso.Location = new System.Drawing.Point(18, 30);
            this.rbProceso.Name = "rbProceso";
            this.rbProceso.Size = new System.Drawing.Size(97, 25);
            this.rbProceso.TabIndex = 45;
            this.rbProceso.TabStop = true;
            this.rbProceso.Text = "Proceso";
            this.rbProceso.UseVisualStyleBackColor = true;
            // 
            // cmbAeronaveMant
            // 
            this.cmbAeronaveMant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAeronaveMant.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cmbAeronaveMant.ForeColor = System.Drawing.Color.White;
            this.cmbAeronaveMant.FormattingEnabled = true;
            this.cmbAeronaveMant.Location = new System.Drawing.Point(186, 184);
            this.cmbAeronaveMant.Name = "cmbAeronaveMant";
            this.cmbAeronaveMant.Size = new System.Drawing.Size(199, 29);
            this.cmbAeronaveMant.TabIndex = 47;
            // 
            // rbAeronaveMant
            // 
            this.rbAeronaveMant.AutoSize = true;
            this.rbAeronaveMant.Location = new System.Drawing.Point(25, 185);
            this.rbAeronaveMant.Name = "rbAeronaveMant";
            this.rbAeronaveMant.Size = new System.Drawing.Size(115, 25);
            this.rbAeronaveMant.TabIndex = 45;
            this.rbAeronaveMant.TabStop = true;
            this.rbAeronaveMant.Text = "Aeronave";
            this.rbAeronaveMant.UseVisualStyleBackColor = true;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Location = new System.Drawing.Point(25, 62);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(89, 25);
            this.rbEstado.TabIndex = 44;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            // 
            // gbEntidades
            // 
            this.gbEntidades.Controls.Add(this.rbVuelos);
            this.gbEntidades.Controls.Add(this.rbReservas);
            this.gbEntidades.Controls.Add(this.rbMantenimientos);
            this.gbEntidades.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbEntidades.ForeColor = System.Drawing.Color.White;
            this.gbEntidades.Location = new System.Drawing.Point(6, 36);
            this.gbEntidades.Name = "gbEntidades";
            this.gbEntidades.Size = new System.Drawing.Size(441, 114);
            this.gbEntidades.TabIndex = 47;
            this.gbEntidades.TabStop = false;
            this.gbEntidades.Text = "Seleccione una entidad";
            // 
            // rbVuelos
            // 
            this.rbVuelos.AutoSize = true;
            this.rbVuelos.Location = new System.Drawing.Point(19, 51);
            this.rbVuelos.Name = "rbVuelos";
            this.rbVuelos.Size = new System.Drawing.Size(86, 25);
            this.rbVuelos.TabIndex = 18;
            this.rbVuelos.TabStop = true;
            this.rbVuelos.Text = "Vuelos";
            this.rbVuelos.UseVisualStyleBackColor = true;
            // 
            // rbReservas
            // 
            this.rbReservas.AutoSize = true;
            this.rbReservas.Location = new System.Drawing.Point(312, 51);
            this.rbReservas.Name = "rbReservas";
            this.rbReservas.Size = new System.Drawing.Size(105, 25);
            this.rbReservas.TabIndex = 20;
            this.rbReservas.TabStop = true;
            this.rbReservas.Text = "Reservas";
            this.rbReservas.UseVisualStyleBackColor = true;
            // 
            // rbMantenimientos
            // 
            this.rbMantenimientos.AutoSize = true;
            this.rbMantenimientos.Location = new System.Drawing.Point(128, 51);
            this.rbMantenimientos.Name = "rbMantenimientos";
            this.rbMantenimientos.Size = new System.Drawing.Size(165, 25);
            this.rbMantenimientos.TabIndex = 19;
            this.rbMantenimientos.TabStop = true;
            this.rbMantenimientos.Text = "Mantenimientos";
            this.rbMantenimientos.UseVisualStyleBackColor = true;
            // 
            // btnReportExcel
            // 
            this.btnReportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportExcel.FlatAppearance.BorderSize = 0;
            this.btnReportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportExcel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportExcel.Location = new System.Drawing.Point(24, 703);
            this.btnReportExcel.Name = "btnReportExcel";
            this.btnReportExcel.Size = new System.Drawing.Size(187, 40);
            this.btnReportExcel.TabIndex = 17;
            this.btnReportExcel.Text = "Generar Excel";
            this.btnReportExcel.UseVisualStyleBackColor = false;
            this.btnReportExcel.Click += new System.EventHandler(this.btnVuelosExcel_Click);
            // 
            // btnReportPDF
            // 
            this.btnReportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportPDF.FlatAppearance.BorderSize = 0;
            this.btnReportPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPDF.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportPDF.Location = new System.Drawing.Point(245, 703);
            this.btnReportPDF.Name = "btnReportPDF";
            this.btnReportPDF.Size = new System.Drawing.Size(185, 40);
            this.btnReportPDF.TabIndex = 16;
            this.btnReportPDF.Text = "Generar PDF";
            this.btnReportPDF.UseVisualStyleBackColor = false;
            this.btnReportPDF.Click += new System.EventHandler(this.btnVuelosPDF_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(471, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1107, 385);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "Taquimetro";
            title4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "Taquimetro de aeronaves";
            title4.Text = "Taquimetro aeronaves";
            this.chart1.Titles.Add(title4);
            // 
            // gbFiltrosVuelosReserv
            // 
            this.gbFiltrosVuelosReserv.Controls.Add(this.cmbAeronaveVuelos);
            this.gbFiltrosVuelosReserv.Controls.Add(this.rbDNI);
            this.gbFiltrosVuelosReserv.Controls.Add(this.rbAeronaveVuelos);
            this.gbFiltrosVuelosReserv.Controls.Add(this.txtDNI);
            this.gbFiltrosVuelosReserv.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gbFiltrosVuelosReserv.ForeColor = System.Drawing.Color.White;
            this.gbFiltrosVuelosReserv.Location = new System.Drawing.Point(6, 454);
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
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(505, 403);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(480, 399);
            this.chart2.TabIndex = 49;
            this.chart2.Text = "chart2";
            title5.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            title5.ForeColor = System.Drawing.Color.White;
            title5.Name = "Title1";
            title5.Text = "Horas aeronaves - Último mes";
            this.chart2.Titles.Add(title5);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(1047, 403);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(480, 398);
            this.chart3.TabIndex = 50;
            this.chart3.Text = "chart3";
            title6.BackColor = System.Drawing.Color.Transparent;
            title6.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            title6.ForeColor = System.Drawing.Color.White;
            title6.Name = "Title1";
            title6.Text = "Reservas aeronaves - Último mes";
            this.chart3.Titles.Add(title6);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1580, 815);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gbGenReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.gbGenReportes.ResumeLayout(false);
            this.gbGenReportes.PerformLayout();
            this.gbFiltrosMant.ResumeLayout(false);
            this.gbFiltrosMant.PerformLayout();
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            this.gbEntidades.ResumeLayout(false);
            this.gbEntidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbFiltrosVuelosReserv.ResumeLayout(false);
            this.gbFiltrosVuelosReserv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenReportes;
        private System.Windows.Forms.Button btnReportPDF;
        private System.Windows.Forms.Button btnReportExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rbReservas;
        private System.Windows.Forms.RadioButton rbMantenimientos;
        private System.Windows.Forms.RadioButton rbVuelos;
        private System.Windows.Forms.GroupBox gbFiltrosMant;
        private System.Windows.Forms.RadioButton rbAeronaveMant;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.GroupBox gbEntidades;
        private System.Windows.Forms.ComboBox cmbAeronaveMant;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.RadioButton rbProceso;
        private System.Windows.Forms.GroupBox gbFiltrosVuelosReserv;
        private System.Windows.Forms.ComboBox cmbAeronaveVuelos;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.RadioButton rbAeronaveVuelos;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.CheckBox cbAplicaFiltros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}