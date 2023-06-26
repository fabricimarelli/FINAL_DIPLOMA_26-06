using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace VISTA
{
    public partial class frmMenuPrincipal : Form
    {
        private static frmMenuPrincipal instancia;
        public static frmMenuPrincipal ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new frmMenuPrincipal();
            if (instancia.IsDisposed)
                instancia = new frmMenuPrincipal();
            return instancia;
        }

        public frmMenuPrincipal()
        {
            InitializeComponent();
            abrirFromHijo(new frmSocios());
        }


        //para mover el formulario login
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false; 
            btnRestaurar.Visible = true; 
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login=new frmLogin();
            login.Show();

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void abrirFromHijo(object formHijo)//para abrir formulario dentro del panel principal
        {
            if (this.panelContenedor.Controls.Count > 0)//aqui pregunta si hay algun formulario abierto en el panel, si lo hay lo elimina
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock=DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmSocios());
        }

        private void btnAviones_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmAviones());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmReservas());
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmVuelos());
        }

        private void btnUsurios_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmUsuarios());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmReportes());
        }

        private void btnClima_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmPronostico());
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new frmTaller());
        }
    }
}
