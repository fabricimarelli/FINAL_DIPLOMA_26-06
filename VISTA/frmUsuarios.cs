using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADORA;

namespace VISTA
{
    public partial class frmUsuarios : Form
    {
        private static frmUsuarios instancia;
        public static frmUsuarios OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmUsuarios();
            if (instancia.IsDisposed)
                instancia = new frmUsuarios();
            return instancia;
        }

        private Usuarios cUsuarios;
        private Usuario oUsuario;
        char ACCION;

        public frmUsuarios()
        {
            InitializeComponent();
            cUsuarios = Usuarios.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = cUsuarios.ObtenerUsuarios(); 
            dgvUsuarios.Columns[0].HeaderText = "ID";
            dgvUsuarios.Columns[1].HeaderText = "Username";
            dgvUsuarios.Columns[2].HeaderText = "Email";
            dgvUsuarios.Columns[3].HeaderText = "Admin";
            dgvUsuarios.Columns[4].Visible = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AutoResizeColumn(0);
            dgvUsuarios.AutoResizeColumn(3);
            dgvUsuarios.AutoResizeColumn(4);
        }

        private void MODO_GRILLA()
        {
            gbDatosUsuario.Enabled = false;
            gbListaUsuarios.Enabled = true;
            COMBO_USUARIOS();
        }

        private void MODO_DATOS()
        {
            gbListaUsuarios.Enabled = false;
            gbDatosUsuario.Enabled = true;

            if (ACCION == 'C')
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }

        }

        private void LIMPIAR()
        {
            txtID.Clear();
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            txtContraseñaVerif.Clear();
            txtEmail.Clear();
            rbAdmin.Checked = false;
            rbOperador.Checked = false;
        }

        private void VUELCA_DATOS()
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                return;
            }

            oUsuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            txtID.Text = oUsuario.ID_usuario.ToString();
            txtNombreUsuario.Text = oUsuario.nombreUsuario;
            txtEmail.Text=oUsuario.email;
            if (oUsuario.admin)
            {
                rbAdmin.Checked = true;
                rbOperador.Checked = false;
            }
            else
            {
                rbAdmin.Checked=false;
                rbOperador.Checked = true;
            }
        }

        private void COMBO_USUARIOS()
        {
            cmbUsuarios.Items.Clear();

            //le pido la lista y la asigno como arreglo
            cmbUsuarios.Items.AddRange(cUsuarios.ObtenerUsuarios().ToArray());
            cmbUsuarios.Items.Insert(0, new Usuario { nombreUsuario = "Username", email = "Todos los usuarios" });
            cmbUsuarios.DisplayMember = "email";
            cmbUsuarios.DisplayMember = "nombreUsuario";
        }

        private void ARMAGRILLAUSERNAME()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = cUsuarios.ObtenerUsuariomatricula(cmbUsuarios.SelectedItem != null ? ((MODELO.Usuario)cmbUsuarios.SelectedItem).nombreUsuario : "0");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ARMAGRILLAUSERNAME();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = 'A';
            MODO_DATOS();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ACCION = 'E';
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            oUsuario = (MODELO.Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista");
                return;
            }
            oUsuario = (MODELO.Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el usuario " + oUsuario.nombreUsuario + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cUsuarios.EliminarUsuario(oUsuario);
                ARMA_GRILLA();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingrese nombre de usuario");//validar que no exista
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContraseñaVerif.Text))
            {
                MessageBox.Show("Debe verificar la contraseña");
                return;
            }
            if (!(txtContraseña.Text == txtContraseñaVerif.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Ingrese un email");//validar con expresion regular
                return;
            }
            #endregion
            if (ACCION == 'A')
            {
                oUsuario = new Usuario();
            }
            oUsuario.nombreUsuario = txtNombreUsuario.Text;
            oUsuario.password = Encrypt.GetSHA256(txtContraseña.Text.Trim());//guarda la contraseña hasheada
            oUsuario.email=txtEmail.Text;
            if (rbAdmin.Checked)
                oUsuario.admin = true;
            else
                oUsuario.admin = false;

            if (ACCION == 'A')
            {
                cUsuarios.AgregarUsuario(oUsuario);
            }
            if (ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos de la aeronave " + oUsuario.nombreUsuario + " ?", "ATENCION", MessageBoxButtons.YesNo);
                cUsuarios.ModificarUsuario(oUsuario);
            }
            MODO_GRILLA();
            ARMA_GRILLA();
            LIMPIAR();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
