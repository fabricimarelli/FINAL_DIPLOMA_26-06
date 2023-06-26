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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)//saca el valor usuario al hacer focus
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)///agrega el valor usuario al sacar focus
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)//saca el valor contraseña al hacer focus
        {
            if(txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)//agrega contraseña como placeholder
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)//para mover el form login
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    //aca valida el user
                    
                    string encriptPassword=MODELO.Encrypt.GetSHA256(txtPass.Text.Trim());
                    using (CONTEXTO.Aeroclub dbase = new CONTEXTO.Aeroclub())
                    {
                        var lst = from d in dbase.Usuarios
                                  where d.nombreUsuario == txtUser.Text
                                  && d.password==encriptPassword
                                  select d;
                        if(lst.Count() > 0)
                        {
                            
                            frmMenuPrincipal menuPrincipal = frmMenuPrincipal.ObtenerInstancia();
                            menuPrincipal.Show();
                            this.Hide();

                        }
                        else
                        {
                            errorMessage("Contraseña o usuario incorrecto");
                            txtPass.Clear();
                            txtUser.Focus();
                        }

                    }

                }
                else
                {
                    errorMessage("Ingrese contraseña valida");
                }
            }
            else
            {
                errorMessage("Ingrese Usuario valido");
            }
           
        }

        private void errorMessage(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
        }

    }
}
