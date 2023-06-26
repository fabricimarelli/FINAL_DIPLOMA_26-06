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
    public partial class frmSocios : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmSocios instancia;
        public static frmSocios OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmSocios();
            if (instancia.IsDisposed)
                instancia = new frmSocios();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        private Socios cSocios;
        
        private Socio oSocio;
       
        char ACCION;
        

        public frmSocios()
        {
            InitializeComponent();
            cSocios=Socios.ObtenerInstancia();
            
            COMBO_SOCIOS();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = cSocios.ObtenerSocios();
            dgvSocios.Columns[0].HeaderText = "ID";
            dgvSocios.Columns[1].HeaderText = "Ingreso";
            dgvSocios.Columns[2].HeaderText = "Nombre";
            dgvSocios.Columns[3].HeaderText = "Apellido";
            dgvSocios.Columns[4].HeaderText = "DNI";
            dgvSocios.Columns[5].HeaderText = "Nacimiento";
            dgvSocios.Columns[6].HeaderText = "Domicilio";
            dgvSocios.Columns[7].HeaderText = "Celular";
            dgvSocios.Columns[8].HeaderText = "Email";
            dgvSocios.Columns[9].HeaderText = "Foto";
            dgvSocios.ReadOnly = true;
            dgvSocios.AutoResizeColumn(0);
            

        }

        private void MODO_GRILLA()
        {
            gbDatosSocio.Enabled = false;
            gbListaSocios.Enabled = true;
        }

        
        private void MODO_DATOS()
        {
            gbListaSocios.Enabled = false;
            gbDatosSocio.Enabled = true;
            rbComun.Checked = true;
            gbAviacion.Enabled=false;
            

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
            txtNombre.Clear();
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtDNI.Clear();
            dtpFechaNacim.Value = DateTime.Now;
            txtCelular.Clear();
            txtEmail.Clear();
            txtID.Clear();
            rbAviacion.Checked = false;
            rbComun.Checked = true;
            cbPiloto.Checked = false;
            txtHorasVoladas.Clear();
            

        }

        private void VUELCA_DATOS()
        {
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un socio de la lista");
                return;
            }
            oSocio = (Socio)dgvSocios.CurrentRow.DataBoundItem;
            txtNombre.Text = oSocio.nombre;
            txtApellido.Text = oSocio.apellido;
            txtDomicilio.Text = oSocio.domicilio;
            txtDNI.Text = oSocio.DNI.ToString();
            dtpFechaNacim.Value = oSocio.fechaNacimiento;
            txtCelular.Text = oSocio.celular;
            txtEmail.Text = oSocio.email;
            txtID.Text = oSocio.ID_socio.ToString();

            Type tipo = oSocio.GetType();
            if (typeof(MODELO.Socio).IsEquivalentTo(tipo))
            {
                rbComun.Checked = true;
            }
            else
            {
                rbAviacion.Checked = true;
                if (((MODELO.Piloto)oSocio).esPiloto)
                {
                    cbPiloto.Checked = true;
                    //traer las licencias al cheboxlist
                    
                }
                txtHorasVoladas.Text = ((MODELO.Piloto)oSocio).horasVoladas.ToString();
            }

        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = 'A';
            MODO_DATOS();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ACCION = 'E';
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista");
                return;
            }
            oSocio = (MODELO.Socio)dgvSocios.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista");
                return;
            }
            //oSocio = (MODELO.Socio)dgvSocios.CurrentRow.DataBoundItem;
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista");
                return;
            }
            oSocio = (MODELO.Socio)dgvSocios.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el socio " + oSocio.nombre + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cSocios.EliminarSocio(oSocio);
                ARMA_GRILLA();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = new Bitmap(opnfd.FileName);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void rbAviacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAviacion.Checked)
            {
                gbAviacion.Enabled = true;
            }
            else
            {
                gbAviacion.Enabled = false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            #region VALIDACIONES SOCIO 
            int DNI;
            if(!Int32.TryParse(txtDNI.Text, out DNI))
            {
                MessageBox.Show("Ingrese un DNI valido");
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese Apellido");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                MessageBox.Show("Ingrese domicilio");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("Ingrese celular");
                return;
            }
            
            #endregion
            #region VUELCA DATOS COMUNES
            
            if (ACCION == 'A')
            {
                if (rbComun.Checked == true)
                {
                    oSocio = new Socio();
                }
                if (rbAviacion.Checked == true)
                {
                    oSocio = new Piloto();
                }
            }
            oSocio.nombre = txtNombre.Text;
            oSocio.apellido = txtApellido.Text;
            oSocio.domicilio = txtDomicilio.Text;
            oSocio.DNI = DNI;
            oSocio.fechaNacimiento = dtpFechaNacim.Value.Date;
            oSocio.celular = txtCelular.Text;
            oSocio.email = txtEmail.Text;
            #endregion
            
            decimal horasVoladas = 0;
            if (rbAviacion.Checked)
            {
                if (cbPiloto.Checked)
                {
                    ((MODELO.Piloto)oSocio).esPiloto = true;

                }
                else
                {
                    ((MODELO.Piloto)oSocio).esPiloto = false;
                }
                
                if(!decimal.TryParse(txtHorasVoladas.Text, out horasVoladas))
                {
                    MessageBox.Show("Igrese las horas en formato correcto");
                    return;
                }
                ((MODELO.Piloto)oSocio).horasVoladas = horasVoladas;

                
                
            }

            if (ACCION == 'A')
            {
                oSocio.fechaAdmision = DateTime.Now;
                cSocios.AgregarSocio(oSocio);

            }
            if (ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos del socio " + oSocio.nombre + " ?", "ATENCION", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    cSocios.ModificarSocio(oSocio);
                    ARMA_GRILLA();
                }
            }

            MODO_GRILLA();
            ARMA_GRILLA();
            LIMPIAR();
        }

        

        private void COMBO_SOCIOS()
        {
            // Vacío la lista de clientes cada vez que quiero armar una nueva
            cmbSocios.Items.Clear();

            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbSocios.Items.AddRange(cSocios.ObtenerSocios().ToArray());
            cmbSocios.DisplayMember = "nombre";
            
           
        }

        private void ARMAGRILLADNI()
        {
            
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = cSocios.ObtenerSocioDNI(cmbSocios.SelectedItem != null ? ((MODELO.Socio)cmbSocios.SelectedItem).DNI: 0);
            
        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ARMAGRILLADNI();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
