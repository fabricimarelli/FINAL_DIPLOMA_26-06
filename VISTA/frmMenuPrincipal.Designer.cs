namespace VISTA
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnTaller = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsurios = new System.Windows.Forms.Button();
            this.btnClima = new System.Windows.Forms.Button();
            this.btnVuelos = new System.Windows.Forms.Button();
            this.btnAviones = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1800, 35);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1732, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1701, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1732, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Visible = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1763, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.menuVertical.Controls.Add(this.btnTaller);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.btnReportes);
            this.menuVertical.Controls.Add(this.btnCerrarSesion);
            this.menuVertical.Controls.Add(this.btnUsurios);
            this.menuVertical.Controls.Add(this.btnClima);
            this.menuVertical.Controls.Add(this.btnVuelos);
            this.menuVertical.Controls.Add(this.btnAviones);
            this.menuVertical.Controls.Add(this.btnReservas);
            this.menuVertical.Controls.Add(this.btnSocios);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 35);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 815);
            this.menuVertical.TabIndex = 1;
            // 
            // btnTaller
            // 
            this.btnTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTaller.FlatAppearance.BorderSize = 0;
            this.btnTaller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTaller.Image = ((System.Drawing.Image)(resources.GetObject("btnTaller.Image")));
            this.btnTaller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaller.Location = new System.Drawing.Point(0, 287);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(217, 44);
            this.btnTaller.TabIndex = 10;
            this.btnTaller.Text = "Taller";
            this.btnTaller.UseVisualStyleBackColor = false;
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cursos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 537);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(217, 44);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 759);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(217, 44);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsurios
            // 
            this.btnUsurios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsurios.FlatAppearance.BorderSize = 0;
            this.btnUsurios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnUsurios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsurios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsurios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsurios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsurios.Image")));
            this.btnUsurios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsurios.Location = new System.Drawing.Point(0, 487);
            this.btnUsurios.Name = "btnUsurios";
            this.btnUsurios.Size = new System.Drawing.Size(217, 44);
            this.btnUsurios.TabIndex = 6;
            this.btnUsurios.Text = "Usuarios";
            this.btnUsurios.UseVisualStyleBackColor = false;
            this.btnUsurios.Click += new System.EventHandler(this.btnUsurios_Click);
            // 
            // btnClima
            // 
            this.btnClima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClima.FlatAppearance.BorderSize = 0;
            this.btnClima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnClima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClima.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClima.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClima.Image = ((System.Drawing.Image)(resources.GetObject("btnClima.Image")));
            this.btnClima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClima.Location = new System.Drawing.Point(0, 387);
            this.btnClima.Name = "btnClima";
            this.btnClima.Size = new System.Drawing.Size(217, 44);
            this.btnClima.TabIndex = 5;
            this.btnClima.Text = "Clima";
            this.btnClima.UseVisualStyleBackColor = false;
            this.btnClima.Click += new System.EventHandler(this.btnClima_Click);
            // 
            // btnVuelos
            // 
            this.btnVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVuelos.FlatAppearance.BorderSize = 0;
            this.btnVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVuelos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVuelos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVuelos.Image = ((System.Drawing.Image)(resources.GetObject("btnVuelos.Image")));
            this.btnVuelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVuelos.Location = new System.Drawing.Point(3, 187);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(217, 44);
            this.btnVuelos.TabIndex = 4;
            this.btnVuelos.Text = "Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = false;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // btnAviones
            // 
            this.btnAviones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAviones.FlatAppearance.BorderSize = 0;
            this.btnAviones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAviones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAviones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAviones.Image = ((System.Drawing.Image)(resources.GetObject("btnAviones.Image")));
            this.btnAviones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAviones.Location = new System.Drawing.Point(3, 237);
            this.btnAviones.Name = "btnAviones";
            this.btnAviones.Size = new System.Drawing.Size(217, 44);
            this.btnAviones.TabIndex = 3;
            this.btnAviones.Text = "Aviones";
            this.btnAviones.UseVisualStyleBackColor = false;
            this.btnAviones.Click += new System.EventHandler(this.btnAviones_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(3, 137);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(217, 44);
            this.btnReservas.TabIndex = 2;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSocios.FlatAppearance.BorderSize = 0;
            this.btnSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSocios.Image = ((System.Drawing.Image)(resources.GetObject("btnSocios.Image")));
            this.btnSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocios.Location = new System.Drawing.Point(0, 437);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(217, 44);
            this.btnSocios.TabIndex = 1;
            this.btnSocios.Text = "Socios";
            this.btnSocios.UseVisualStyleBackColor = false;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1580, 815);
            this.panelContenedor.TabIndex = 2;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1800, 850);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Aeroclub Cañada de Gómez";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnAviones;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsurios;
        private System.Windows.Forms.Button btnClima;
        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTaller;
    }
}

