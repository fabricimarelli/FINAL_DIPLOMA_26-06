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
    public partial class frmAviones : Form
    {
        private static frmAviones instancia;
        public static frmAviones OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmAviones();
            if (instancia.IsDisposed)
                instancia = new frmAviones();
            return instancia;
        }

        private Aeronaves cAeronaves;
        private Aeronave oAeronave;
        char ACCION;

        public frmAviones()
        {
            InitializeComponent();
            cAeronaves = Aeronaves.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvAviones.DataSource = null;
            dgvAviones.DataSource = cAeronaves.ObtenerAeronaves();
            dgvAviones.Columns[0].HeaderText = "ID";
            dgvAviones.Columns[1].HeaderText = "Matricula";
            dgvAviones.Columns[2].HeaderText = "Marca";
            dgvAviones.Columns[3].HeaderText = "Taquimetro";
            dgvAviones.Columns[4].HeaderText = "Taq futuro";
            dgvAviones.Columns[5].HeaderText = "Tarifa(hora)";
            dgvAviones.Columns[6].HeaderText = "Disponible";
            dgvAviones.ReadOnly = true;
            dgvAviones.AutoResizeColumn(0);
            dgvAviones.AutoResizeColumn(3);
            dgvAviones.AutoResizeColumn(4);

        }
        private void MODO_GRILLA()
        {
            gbDatosAviones.Enabled = false;
            gbGrillaAviones.Enabled = true;
            COMBO_AERONAVES();
        }
        private void MODO_DATOS()
        {
            gbGrillaAviones.Enabled = false;
            gbDatosAviones.Enabled = true;
            cbServicio.Checked = true;
            
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
            txtMatricula.Clear();
            txtMarca.Clear();
            txtTaquimetro.Clear();
            txtTarifa.Clear();
            cbServicio.Enabled = true;
        }
        private void VUELCA_DATOS()
        {
            if (dgvAviones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un avion de la lista");
                return;
            }

            oAeronave = (Aeronave)dgvAviones.CurrentRow.DataBoundItem;
            txtID.Text = oAeronave.ID_aeronave.ToString();
            txtMatricula.Text = oAeronave.matricula;
            txtMarca.Text = oAeronave.marcaModelo;
            txtTaquimetro.Text = oAeronave.taquimetro.ToString();
            txtTarifa.Text = oAeronave.tarifaHora.ToString();
            if (oAeronave.enServicio)
            {
                cbServicio.Checked = true;
            }
            else
            {
                cbServicio.Checked = false;
            }
        }
        private void COMBO_AERONAVES()
        {
            
            cmbAeronaves.Items.Clear();

            //le pido la lista y la asigno como arreglo
            cmbAeronaves.Items.AddRange(cAeronaves.ObtenerAeronaves().ToArray());
            cmbAeronaves.DisplayMember = "marcaModelo";
            cmbAeronaves.DisplayMember = "matricula";

        }
        private void ARMAGRILLAMATRICULA()
        {

            dgvAviones.DataSource = null;
            dgvAviones.DataSource = cAeronaves.ObtenerAeronavematricula(cmbAeronaves.SelectedItem != null ? ((MODELO.Aeronave)cmbAeronaves.SelectedItem).ID_aeronave:0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ARMAGRILLAMATRICULA();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = 'A';
            MODO_DATOS();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ACCION = 'E';
            if (dgvAviones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un avion de la lista");
                return;
            }
            oAeronave = (MODELO.Aeronave)dgvAviones.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvAviones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un avion de la lista");
                return;
            }
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAviones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un avion de la lista");
                return;
            }
            oAeronave = (MODELO.Aeronave)dgvAviones.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la aeronave " + oAeronave.matricula + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cAeronaves.EliminarAeronave(oAeronave);
                ARMA_GRILLA();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Ingrese marca");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Ingrese matricula");
                return;
            }
            decimal tarifa = 0;
            decimal taquimetro = 0;
            if(!decimal.TryParse(txtTarifa.Text, out tarifa))
            {
                MessageBox.Show("Ingrese la tarifa correctamente");
            }
            if(!decimal.TryParse(txtTaquimetro.Text, out taquimetro))
            {
                MessageBox.Show("Ingrese valor de taquimetro correctamente");
            }
            #endregion
            if (ACCION == 'A')
            {
                oAeronave=new Aeronave();
              
            }
            oAeronave.matricula=txtMatricula.Text;
            oAeronave.marcaModelo = txtMarca.Text;
            oAeronave.tarifaHora = tarifa;
            oAeronave.taquimetro = taquimetro;
            if (cbServicio.Checked)
            {
                oAeronave.enServicio=true;
            }
            else
            {
                oAeronave.enServicio = false;
            }
                

            if (ACCION == 'A')
            {
                cAeronaves.AgregarAeronave(oAeronave);
            }
            if(ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos de la aeronave " + oAeronave.matricula + " ?", "ATENCION", MessageBoxButtons.YesNo);
                cAeronaves.ModificarAeronave(oAeronave);
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
