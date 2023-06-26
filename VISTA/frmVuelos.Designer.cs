namespace VISTA
{
    partial class frmVuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbListaVuelos = new System.Windows.Forms.GroupBox();
            this.cmbVuelos = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbAeronave = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPiloto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaqSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaqLlegada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.cbInstruc = new System.Windows.Forms.CheckBox();
            this.gbDatosVuelo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.dtpFechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gbListaVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.gbDatosVuelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaVuelos
            // 
            this.gbListaVuelos.Controls.Add(this.cmbVuelos);
            this.gbListaVuelos.Controls.Add(this.btnConsultar);
            this.gbListaVuelos.Controls.Add(this.btnBuscar);
            this.gbListaVuelos.Controls.Add(this.btnEliminar);
            this.gbListaVuelos.Controls.Add(this.btnEditar);
            this.gbListaVuelos.Controls.Add(this.btnAgregar);
            this.gbListaVuelos.Controls.Add(this.dgvVuelos);
            this.gbListaVuelos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaVuelos.ForeColor = System.Drawing.Color.White;
            this.gbListaVuelos.Location = new System.Drawing.Point(40, 29);
            this.gbListaVuelos.Name = "gbListaVuelos";
            this.gbListaVuelos.Size = new System.Drawing.Size(826, 756);
            this.gbListaVuelos.TabIndex = 4;
            this.gbListaVuelos.TabStop = false;
            this.gbListaVuelos.Text = "Listado de vuelos";
            // 
            // cmbVuelos
            // 
            this.cmbVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbVuelos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVuelos.ForeColor = System.Drawing.Color.White;
            this.cmbVuelos.FormattingEnabled = true;
            this.cmbVuelos.Location = new System.Drawing.Point(172, 36);
            this.cmbVuelos.Name = "cmbVuelos";
            this.cmbVuelos.Size = new System.Drawing.Size(429, 29);
            this.cmbVuelos.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(349, 689);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 40);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(621, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(647, 689);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(186, 689);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(23, 689);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVuelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVuelos.ColumnHeadersHeight = 30;
            this.dgvVuelos.EnableHeadersVisualStyles = false;
            this.dgvVuelos.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvVuelos.Location = new System.Drawing.Point(23, 77);
            this.dgvVuelos.Name = "dgvVuelos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVuelos.RowHeadersVisible = false;
            this.dgvVuelos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVuelos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVuelos.RowTemplate.Height = 24;
            this.dgvVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVuelos.Size = new System.Drawing.Size(781, 578);
            this.dgvVuelos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarifa";
            // 
            // txtTarifa
            // 
            this.txtTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTarifa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTarifa.Location = new System.Drawing.Point(117, 361);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(152, 32);
            this.txtTarifa.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(190, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(73, 28);
            this.txtID.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID Vuelo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(22, 688);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 40);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(432, 688);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbAeronave
            // 
            this.cmbAeronave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAeronave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAeronave.ForeColor = System.Drawing.Color.White;
            this.cmbAeronave.FormattingEnabled = true;
            this.cmbAeronave.Location = new System.Drawing.Point(117, 156);
            this.cmbAeronave.Name = "cmbAeronave";
            this.cmbAeronave.Size = new System.Drawing.Size(409, 29);
            this.cmbAeronave.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Aeronave";
            // 
            // cmbPiloto
            // 
            this.cmbPiloto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbPiloto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPiloto.ForeColor = System.Drawing.Color.White;
            this.cmbPiloto.FormattingEnabled = true;
            this.cmbPiloto.Location = new System.Drawing.Point(117, 223);
            this.cmbPiloto.Name = "cmbPiloto";
            this.cmbPiloto.Size = new System.Drawing.Size(409, 29);
            this.cmbPiloto.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Piloto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Taq. salida";
            // 
            // txtTaqSalida
            // 
            this.txtTaqSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTaqSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaqSalida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTaqSalida.Location = new System.Drawing.Point(117, 289);
            this.txtTaqSalida.Name = "txtTaqSalida";
            this.txtTaqSalida.Size = new System.Drawing.Size(105, 32);
            this.txtTaqSalida.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Taq. llegada";
            // 
            // txtTaqLlegada
            // 
            this.txtTaqLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTaqLlegada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaqLlegada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTaqLlegada.Location = new System.Drawing.Point(274, 289);
            this.txtTaqLlegada.Name = "txtTaqLlegada";
            this.txtTaqLlegada.Size = new System.Drawing.Size(105, 32);
            this.txtTaqLlegada.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tiempo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTiempo.Location = new System.Drawing.Point(421, 289);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(105, 32);
            this.txtTiempo.TabIndex = 35;
            // 
            // cbInstruc
            // 
            this.cbInstruc.AutoSize = true;
            this.cbInstruc.Location = new System.Drawing.Point(329, 68);
            this.cbInstruc.Name = "cbInstruc";
            this.cbInstruc.Size = new System.Drawing.Size(136, 27);
            this.cbInstruc.TabIndex = 1;
            this.cbInstruc.Text = "Instrucción";
            this.cbInstruc.UseVisualStyleBackColor = true;
            this.cbInstruc.CheckedChanged += new System.EventHandler(this.cbInstruc_CheckedChanged);
            // 
            // gbDatosVuelo
            // 
            this.gbDatosVuelo.Controls.Add(this.label7);
            this.gbDatosVuelo.Controls.Add(this.dtpFechaVuelo);
            this.gbDatosVuelo.Controls.Add(this.label6);
            this.gbDatosVuelo.Controls.Add(this.txtObs);
            this.gbDatosVuelo.Controls.Add(this.label99);
            this.gbDatosVuelo.Controls.Add(this.cmbAlumno);
            this.gbDatosVuelo.Controls.Add(this.cbInstruc);
            this.gbDatosVuelo.Controls.Add(this.txtTiempo);
            this.gbDatosVuelo.Controls.Add(this.label8);
            this.gbDatosVuelo.Controls.Add(this.txtTaqLlegada);
            this.gbDatosVuelo.Controls.Add(this.label5);
            this.gbDatosVuelo.Controls.Add(this.txtTaqSalida);
            this.gbDatosVuelo.Controls.Add(this.label4);
            this.gbDatosVuelo.Controls.Add(this.label3);
            this.gbDatosVuelo.Controls.Add(this.cmbPiloto);
            this.gbDatosVuelo.Controls.Add(this.label1);
            this.gbDatosVuelo.Controls.Add(this.cmbAeronave);
            this.gbDatosVuelo.Controls.Add(this.btnCancelar);
            this.gbDatosVuelo.Controls.Add(this.btnGuardar);
            this.gbDatosVuelo.Controls.Add(this.label9);
            this.gbDatosVuelo.Controls.Add(this.txtID);
            this.gbDatosVuelo.Controls.Add(this.txtTarifa);
            this.gbDatosVuelo.Controls.Add(this.label2);
            this.gbDatosVuelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosVuelo.ForeColor = System.Drawing.Color.White;
            this.gbDatosVuelo.Location = new System.Drawing.Point(914, 29);
            this.gbDatosVuelo.Name = "gbDatosVuelo";
            this.gbDatosVuelo.Size = new System.Drawing.Size(626, 756);
            this.gbDatosVuelo.TabIndex = 3;
            this.gbDatosVuelo.TabStop = false;
            this.gbDatosVuelo.Text = "Datos vuelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Observaciones";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(117, 528);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(409, 127);
            this.txtObs.TabIndex = 39;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(113, 408);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(86, 23);
            this.label99.TabIndex = 38;
            this.label99.Text = "Alumno";
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbAlumno.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlumno.ForeColor = System.Drawing.Color.White;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(117, 440);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(409, 29);
            this.cmbAlumno.TabIndex = 37;
            // 
            // dtpFechaVuelo
            // 
            this.dtpFechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVuelo.Location = new System.Drawing.Point(382, 361);
            this.dtpFechaVuelo.Name = "dtpFechaVuelo";
            this.dtpFechaVuelo.Size = new System.Drawing.Size(144, 32);
            this.dtpFechaVuelo.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Fecha ";
            // 
            // frmVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1580, 815);
            this.Controls.Add(this.gbDatosVuelo);
            this.Controls.Add(this.gbListaVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVuelos";
            this.Text = "frmVuelos";
            this.gbListaVuelos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.gbDatosVuelo.ResumeLayout(false);
            this.gbDatosVuelo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbListaVuelos;
        private System.Windows.Forms.ComboBox cmbVuelos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbAeronave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPiloto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaqSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaqLlegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.CheckBox cbInstruc;
        private System.Windows.Forms.GroupBox gbDatosVuelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaVuelo;
    }
}