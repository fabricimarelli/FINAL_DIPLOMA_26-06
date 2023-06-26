namespace VISTA
{
    partial class frmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocios));
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbListaSocios = new System.Windows.Forms.GroupBox();
            this.cmbSocios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.dtpFechaNacim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbTipoSocio = new System.Windows.Forms.GroupBox();
            this.rbAviacion = new System.Windows.Forms.RadioButton();
            this.rbComun = new System.Windows.Forms.RadioButton();
            this.gbAviacion = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHorasVoladas = new System.Windows.Forms.TextBox();
            this.cbPiloto = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatosSocio = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.gbListaSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.gbTipoSocio.SuspendLayout();
            this.gbAviacion.SuspendLayout();
            this.gbDatosSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSocios
            // 
            this.dgvSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSocios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSocios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvSocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSocios.ColumnHeadersHeight = 30;
            this.dgvSocios.EnableHeadersVisualStyles = false;
            this.dgvSocios.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvSocios.Location = new System.Drawing.Point(23, 77);
            this.dgvSocios.Name = "dgvSocios";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSocios.RowHeadersVisible = false;
            this.dgvSocios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSocios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSocios.RowTemplate.Height = 24;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(781, 578);
            this.dgvSocios.TabIndex = 0;
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
            // gbListaSocios
            // 
            this.gbListaSocios.Controls.Add(this.btnReload);
            this.gbListaSocios.Controls.Add(this.cmbSocios);
            this.gbListaSocios.Controls.Add(this.btnConsultar);
            this.gbListaSocios.Controls.Add(this.btnBuscar);
            this.gbListaSocios.Controls.Add(this.btnEliminar);
            this.gbListaSocios.Controls.Add(this.btnEditar);
            this.gbListaSocios.Controls.Add(this.btnAgregar);
            this.gbListaSocios.Controls.Add(this.dgvSocios);
            this.gbListaSocios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaSocios.ForeColor = System.Drawing.Color.White;
            this.gbListaSocios.Location = new System.Drawing.Point(29, 28);
            this.gbListaSocios.Name = "gbListaSocios";
            this.gbListaSocios.Size = new System.Drawing.Size(826, 756);
            this.gbListaSocios.TabIndex = 0;
            this.gbListaSocios.TabStop = false;
            this.gbListaSocios.Text = "Listado de socios";
            // 
            // cmbSocios
            // 
            this.cmbSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbSocios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSocios.ForeColor = System.Drawing.Color.White;
            this.cmbSocios.FormattingEnabled = true;
            this.cmbSocios.Location = new System.Drawing.Point(172, 36);
            this.cmbSocios.Name = "cmbSocios";
            this.cmbSocios.Size = new System.Drawing.Size(429, 29);
            this.cmbSocios.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(193, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 32);
            this.txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtApellido.Location = new System.Drawing.Point(406, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 32);
            this.txtApellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDNI.Location = new System.Drawing.Point(406, 114);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(196, 32);
            this.txtDNI.TabIndex = 10;
            // 
            // dtpFechaNacim
            // 
            this.dtpFechaNacim.CustomFormat = "";
            this.dtpFechaNacim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacim.Location = new System.Drawing.Point(193, 182);
            this.dtpFechaNacim.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacim.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacim.Name = "dtpFechaNacim";
            this.dtpFechaNacim.Size = new System.Drawing.Size(196, 32);
            this.dtpFechaNacim.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDomicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDomicilio.Location = new System.Drawing.Point(193, 114);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(196, 32);
            this.txtDomicilio.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Location = new System.Drawing.Point(193, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(409, 32);
            this.txtEmail.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCelular.Location = new System.Drawing.Point(406, 180);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(196, 32);
            this.txtCelular.TabIndex = 12;
            // 
            // picFoto
            // 
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(22, 38);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(159, 158);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 23;
            this.picFoto.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(67, 270);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(73, 28);
            this.txtID.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID Socio";
            // 
            // gbTipoSocio
            // 
            this.gbTipoSocio.Controls.Add(this.rbAviacion);
            this.gbTipoSocio.Controls.Add(this.rbComun);
            this.gbTipoSocio.ForeColor = System.Drawing.Color.White;
            this.gbTipoSocio.Location = new System.Drawing.Point(92, 313);
            this.gbTipoSocio.Name = "gbTipoSocio";
            this.gbTipoSocio.Size = new System.Drawing.Size(437, 103);
            this.gbTipoSocio.TabIndex = 26;
            this.gbTipoSocio.TabStop = false;
            this.gbTipoSocio.Text = "Tipo de socio";
            // 
            // rbAviacion
            // 
            this.rbAviacion.AutoSize = true;
            this.rbAviacion.Location = new System.Drawing.Point(237, 45);
            this.rbAviacion.Name = "rbAviacion";
            this.rbAviacion.Size = new System.Drawing.Size(117, 27);
            this.rbAviacion.TabIndex = 1;
            this.rbAviacion.TabStop = true;
            this.rbAviacion.Text = "Aviación";
            this.rbAviacion.UseVisualStyleBackColor = true;
            this.rbAviacion.CheckedChanged += new System.EventHandler(this.rbAviacion_CheckedChanged);
            // 
            // rbComun
            // 
            this.rbComun.AutoSize = true;
            this.rbComun.Location = new System.Drawing.Point(33, 45);
            this.rbComun.Name = "rbComun";
            this.rbComun.Size = new System.Drawing.Size(103, 27);
            this.rbComun.TabIndex = 0;
            this.rbComun.TabStop = true;
            this.rbComun.Text = "Común";
            this.rbComun.UseVisualStyleBackColor = true;
            // 
            // gbAviacion
            // 
            this.gbAviacion.Controls.Add(this.label11);
            this.gbAviacion.Controls.Add(this.txtHorasVoladas);
            this.gbAviacion.Controls.Add(this.cbPiloto);
            this.gbAviacion.ForeColor = System.Drawing.Color.White;
            this.gbAviacion.Location = new System.Drawing.Point(22, 422);
            this.gbAviacion.Name = "gbAviacion";
            this.gbAviacion.Size = new System.Drawing.Size(580, 232);
            this.gbAviacion.TabIndex = 27;
            this.gbAviacion.TabStop = false;
            this.gbAviacion.Text = "Aviación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Hs voladas";
            // 
            // txtHorasVoladas
            // 
            this.txtHorasVoladas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtHorasVoladas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasVoladas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHorasVoladas.Location = new System.Drawing.Point(171, 142);
            this.txtHorasVoladas.Name = "txtHorasVoladas";
            this.txtHorasVoladas.Size = new System.Drawing.Size(196, 32);
            this.txtHorasVoladas.TabIndex = 30;
            // 
            // cbPiloto
            // 
            this.cbPiloto.AutoSize = true;
            this.cbPiloto.Location = new System.Drawing.Point(221, 72);
            this.cbPiloto.Name = "cbPiloto";
            this.cbPiloto.Size = new System.Drawing.Size(85, 27);
            this.cbPiloto.TabIndex = 0;
            this.cbPiloto.Text = "Piloto";
            this.cbPiloto.UseVisualStyleBackColor = true;
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
            // gbDatosSocio
            // 
            this.gbDatosSocio.Controls.Add(this.btnExaminar);
            this.gbDatosSocio.Controls.Add(this.btnCancelar);
            this.gbDatosSocio.Controls.Add(this.btnGuardar);
            this.gbDatosSocio.Controls.Add(this.gbAviacion);
            this.gbDatosSocio.Controls.Add(this.gbTipoSocio);
            this.gbDatosSocio.Controls.Add(this.label9);
            this.gbDatosSocio.Controls.Add(this.txtID);
            this.gbDatosSocio.Controls.Add(this.picFoto);
            this.gbDatosSocio.Controls.Add(this.txtCelular);
            this.gbDatosSocio.Controls.Add(this.label8);
            this.gbDatosSocio.Controls.Add(this.txtEmail);
            this.gbDatosSocio.Controls.Add(this.label7);
            this.gbDatosSocio.Controls.Add(this.txtDomicilio);
            this.gbDatosSocio.Controls.Add(this.label6);
            this.gbDatosSocio.Controls.Add(this.label5);
            this.gbDatosSocio.Controls.Add(this.dtpFechaNacim);
            this.gbDatosSocio.Controls.Add(this.txtDNI);
            this.gbDatosSocio.Controls.Add(this.label4);
            this.gbDatosSocio.Controls.Add(this.txtApellido);
            this.gbDatosSocio.Controls.Add(this.label3);
            this.gbDatosSocio.Controls.Add(this.txtNombre);
            this.gbDatosSocio.Controls.Add(this.label2);
            this.gbDatosSocio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSocio.ForeColor = System.Drawing.Color.White;
            this.gbDatosSocio.Location = new System.Drawing.Point(903, 28);
            this.gbDatosSocio.Name = "gbDatosSocio";
            this.gbDatosSocio.Size = new System.Drawing.Size(626, 756);
            this.gbDatosSocio.TabIndex = 0;
            this.gbDatosSocio.TabStop = false;
            this.gbDatosSocio.Text = "Datos socio";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(59, 202);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(81, 32);
            this.btnExaminar.TabIndex = 14;
            this.btnExaminar.Text = "Cargar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(53, 31);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(43, 40);
            this.btnReload.TabIndex = 28;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1580, 815);
            this.Controls.Add(this.gbDatosSocio);
            this.Controls.Add(this.gbListaSocios);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSocios";
            this.Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.gbListaSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.gbTipoSocio.ResumeLayout(false);
            this.gbTipoSocio.PerformLayout();
            this.gbAviacion.ResumeLayout(false);
            this.gbAviacion.PerformLayout();
            this.gbDatosSocio.ResumeLayout(false);
            this.gbDatosSocio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbListaSocios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DateTimePicker dtpFechaNacim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbTipoSocio;
        private System.Windows.Forms.RadioButton rbAviacion;
        private System.Windows.Forms.RadioButton rbComun;
        private System.Windows.Forms.GroupBox gbAviacion;
        private System.Windows.Forms.CheckBox cbPiloto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbDatosSocio;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHorasVoladas;
        private System.Windows.Forms.ComboBox cmbSocios;
        private System.Windows.Forms.Button btnReload;
    }
}