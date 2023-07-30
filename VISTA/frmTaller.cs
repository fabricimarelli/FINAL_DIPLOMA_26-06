using CONTROLADORA;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmTaller : Form
    {
        private static frmTaller instancia;
        public static frmTaller OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmTaller();
            if (instancia.IsDisposed)
                instancia = new frmTaller();
            return instancia;
        }

        private Mantenimientos cMantenimientos;
        private Aeronaves cAeronaves;
        private Mantenimiento oMantenimiento;
        char ACCION;
        decimal origTime = 0.1m;

        public frmTaller()
        {
            InitializeComponent();
            cMantenimientos = Mantenimientos.ObtenerInstancia();
            cAeronaves = Aeronaves.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA_MATRICULA();
            ARMA_GRILLA_MATRICULA_FUT();
            ARMA_GRILLA_MATRICULA_Vencimiento();

        }

        private void ARMA_GRILLA()
        {
            dgvReparaciones.DataSource = null;
            dgvReparaciones.DataSource = cMantenimientos.ObtenerMantenimientos();
            dgvReparaciones.Columns[0].HeaderText = "ID";
            dgvReparaciones.Columns[1].HeaderText = "Aeronave";
            dgvReparaciones.Columns[2].HeaderText = "Fecha Inicio";
            dgvReparaciones.Columns[3].HeaderText = "Fecha Fin";
            dgvReparaciones.Columns[4].HeaderText = "Trabajos";
            dgvReparaciones.Columns[5].HeaderText = "Estado";
            dgvReparaciones.ReadOnly = true;
            dgvReparaciones.AutoResizeColumn(0);
            dgvReparaciones.AutoResizeColumn(3);
            dgvReparaciones.AutoResizeColumn(4);
        }

        private void MODO_GRILLA()
        {
            gbDatosMant.Enabled = false;
            gbListaMant.Enabled = true;
            COMBO_MANTENIMIENTOS();
            ARMA_GRILLA_MATRICULA_FUT();
        }

        private void MODO_DATOS()
        {
            gbListaMant.Enabled = false;
            gbDatosMant.Enabled = true;

            if (ACCION == 'C')
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
            
            //gbEstado.Enabled = false;
            //gbMantFut.Enabled = false;
            COMBO_AERONAVES();
      

        }

        private void LIMPIAR()
        {
            txtID.Clear();
            cmbAeronave.Items.Clear();
            cmbAeronave.Invalidate();
            txtDetallesTrabajo.Clear();
            rbFinalizado.Checked = false;
            rbPendiente.Checked = false;
            rbProceso.Checked = false;
            txtTaqFuturo.Clear();
            
        }

        private void VUELCA_DATOS()
        {
            if (dgvReparaciones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un mantenimiento de la lista");
                return;
            }

            oMantenimiento = (Mantenimiento)dgvReparaciones.CurrentRow.DataBoundItem;
            txtID.Text = oMantenimiento.ID_mantenimiento.ToString();
            cmbAeronave.SelectedItem = oMantenimiento.aeronave;
            dtpInicio.Value = oMantenimiento.fechaInicio;
            dtpFin.Value = oMantenimiento.fechaFin;
            txtDetallesTrabajo.Text = oMantenimiento.trabajos;
            txtTaqFuturo.Text=oMantenimiento.proximoMant.ToString();

            if (oMantenimiento.estado == "pendiente")
            {
                rbPendiente.Checked = true;
                rbProceso.Checked = false;
                rbFinalizado.Checked = false;
            }
            else if (oMantenimiento.estado == "proceso")
            {
                rbPendiente.Checked = false;
                rbProceso.Checked = true;
                rbFinalizado.Checked = false;
            }
            else
            {
                rbFinalizado.Checked=true;
                rbPendiente.Checked=false;
                rbProceso.Checked=false;
            }


        }

        private void COMBO_MANTENIMIENTOS()
        {
            // Vacío la lista de clientes cada vez que quiero armar una nueva
            cmbMantenimientos.Items.Clear();
            cmbMantenimientos.Items.AddRange(cMantenimientos.OBTENER_AERONAVE().ToArray());
            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbMantenimientos.Items.Insert(0, new MODELO.Aeronave { ID_aeronave = 0, matricula = "Todas las aeronaves..." });
            cmbMantenimientos.DisplayMember = "matricula";
            cmbMantenimientos.ValueMember = "ID_aeronave";
        }

        private void COMBO_AERONAVES()
        {

            cmbAeronave.Items.Clear();

            //le pido la lista y la asigno como arreglo
            cmbAeronave.Items.AddRange(cMantenimientos.OBTENER_AERONAVE().ToArray());
            cmbAeronave.Items.Insert(0, new MODELO.Aeronave { matricula = "LV-..." });
            cmbAeronave.DisplayMember = "matricula";
            cmbAeronave.ValueMember = "matricula";

        }

        

        private void ARMA_GRILLA_MATRICULA()//Obtiene mantenimientos por grilla
        {

            dgvReparaciones.DataSource = null;
            dgvReparaciones.DataSource = cMantenimientos.ObtieneMantenimiento(cmbMantenimientos.SelectedItem != null ? ((MODELO.Aeronave)cmbMantenimientos.SelectedItem).ID_aeronave : 0);
            dgvReparaciones.Columns[0].HeaderText = "ID";
            dgvReparaciones.Columns[1].HeaderText = "Aeronave";
            dgvReparaciones.Columns[2].HeaderText = "Fecha Inicio";
            dgvReparaciones.Columns[3].HeaderText = "Fecha Fin";
            dgvReparaciones.Columns[4].HeaderText = "Detalles";
            dgvReparaciones.Columns[5].HeaderText = "Estado";
            dgvReparaciones.ReadOnly = true;
            dgvReparaciones.AutoResizeColumn(0);
            dgvReparaciones.AutoResizeColumn(3);
            dgvReparaciones.AutoResizeColumn(4);


        }

        private void ARMA_GRILLA_MATRICULA_FUT()//obtiene aeronaves por grilla
        {

            dgvReparacionesFuturas.DataSource = null;
            dgvReparacionesFuturas.DataSource = cAeronaves.ObtenerAeronaves();
            dgvReparacionesFuturas.Columns[0].Visible = false;
            dgvReparacionesFuturas.Columns[1].HeaderText = "Matricula";
            dgvReparacionesFuturas.Columns[2].Visible = false;
            dgvReparacionesFuturas.Columns[3].HeaderText = "Taquimetro";
            dgvReparacionesFuturas.Columns[4].HeaderText = "Taquimetro futuro";
            dgvReparacionesFuturas.Columns[5].Visible=false;
            dgvReparacionesFuturas.Columns[6].HeaderText = "En servicio";
            dgvReparacionesFuturas.ReadOnly = true;

        }

        private void ARMA_GRILLA_MATRICULA_Vencimiento()
        {
            List<Aeronave> listaAeronaves = cAeronaves.ObtenerAeronaves();
            List<Aeronave> listaAeronavesProx = listaAeronaves.Where(avion => avion.taquimetroFuturo - avion.taquimetro <= 10).ToList();
            dgvReparacionesFuturas.DataSource = null;
            dgvReparacionesFuturas.DataSource = listaAeronavesProx;
            dgvReparacionesFuturas.Columns[0].Visible = false;
            dgvReparacionesFuturas.Columns[1].HeaderText = "Matricula";
            dgvReparacionesFuturas.Columns[2].Visible = false;
            dgvReparacionesFuturas.Columns[3].HeaderText = "Taquimetro";
            dgvReparacionesFuturas.Columns[4].HeaderText = "Taquimetro futuro";
            dgvReparacionesFuturas.Columns[5].Visible = false;
            dgvReparacionesFuturas.Columns[6].HeaderText = "En servicio";
            dgvReparacionesFuturas.ReadOnly = true;

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            ACCION = 'B';
            if (dgvReparaciones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un vuelo de la lista");
                return;
            }
            oMantenimiento = (MODELO.Mantenimiento)dgvReparaciones.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el vuelo " + oMantenimiento.ID_mantenimiento + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                MODIFICA_AERONAVE(oMantenimiento);
                cMantenimientos.EliminarMantenimiento(oMantenimiento);
                ARMA_GRILLA();
                ARMA_GRILLA_MATRICULA_FUT();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvReparaciones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un mantenimiento de la lista");
                return;
            }
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ACCION = 'E';
            if (dgvReparaciones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un mantenimiento de la lista");
                return;
            }
            oMantenimiento = (MODELO.Mantenimiento)dgvReparaciones.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = 'A';
            MODO_DATOS();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA_MATRICULA();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            decimal taqFuturo = 0;
            if (cmbAeronave.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una aeronave");
                return;
            }
            if (dtpInicio.Value > dtpFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de finalización");
                return;
            }
            if(txtDetallesTrabajo.Text.Length < 3)
            {
                MessageBox.Show("Ingrese los trabajos a realizar");
                return;
            }
            if (rbFinalizado.Checked == false && rbPendiente.Checked == false && rbProceso.Checked == false)
            {
                MessageBox.Show("Seleccione un estado");
                return;
            }
            if(!decimal.TryParse(txtTaqFuturo.Text,out taqFuturo))
            {
                MessageBox.Show("Ingrese taquimetro futuro correctamente");
                return;
            }
            #endregion

            if (ACCION == 'A')
            {
                oMantenimiento=new Mantenimiento();
            }

            origTime = oMantenimiento.proximoMant;
            oMantenimiento.aeronave=(Aeronave)cmbAeronave.SelectedItem;
            oMantenimiento.fechaInicio = dtpInicio.Value;
            oMantenimiento.fechaFin=dtpFin.Value;
            oMantenimiento.trabajos = txtDetallesTrabajo.Text;
            oMantenimiento.proximoMant = taqFuturo;
            //cargaren aeronave taq futuro
            if (rbFinalizado.Checked)
            {
                oMantenimiento.estado = "finalizado";
            }
            else if (rbPendiente.Checked)
            {
                oMantenimiento.estado="pendiente";
            }
            else
            {
                oMantenimiento.estado = "proceso";
            }

            if (ACCION == 'A')
            {
                cMantenimientos.AgregarMantenimiento(oMantenimiento);
            }
            if(ACCION == 'E')
            {
                cMantenimientos.ModificarMantenimiento(oMantenimiento);
            }

            MODIFICA_AERONAVE(oMantenimiento);
            MODO_GRILLA();
            ARMA_GRILLA();
            LIMPIAR();
            ARMA_GRILLA_MATRICULA_FUT();
        }

        private void MODIFICA_AERONAVE(Mantenimiento oMantenimineto)//para modificar el taquimetroFut del avion involucrado
        {

            if (ACCION == 'A')
            {
                Aeronave oAeronaveSelec = (Aeronave)cmbAeronave.SelectedItem;
                oAeronaveSelec.taquimetroFuturo += oMantenimineto.proximoMant;
                cAeronaves.ModificarAeronave(oAeronaveSelec);
            }
            else if (ACCION == 'B')
            {
                Aeronave oAeronaveSelec = cAeronaves.ObtenerUNAAeronave(oMantenimineto.aeronave.matricula);
                oAeronaveSelec.taquimetroFuturo -= oMantenimineto.proximoMant;
                cAeronaves.ModificarAeronave(oAeronaveSelec);
            }
            else if (ACCION == 'E')
            {
                Aeronave oAeronaveSelec = cAeronaves.ObtenerUNAAeronave(oMantenimineto.aeronave.matricula);
                if (oMantenimineto.proximoMant< origTime /*|| oMantenimineto.proximoMant < origHoras*/)
                {
                    oAeronaveSelec.taquimetroFuturo -= (origTime - oMantenimiento.proximoMant);
                }
                else if (oMantenimineto.proximoMant > origTime /*|| oMantenimineto.proximoMant > origHoras*/)
                {
                    oAeronaveSelec.taquimetroFuturo += (oMantenimiento.proximoMant - origTime);
                }
                if (rbProceso.Checked)
                {
                    oAeronaveSelec.enServicio = false;
                }
                if (rbPendiente.Checked || rbFinalizado.Checked)
                {
                    oAeronaveSelec.enServicio = true;
                }
                cAeronaves.ModificarAeronave(oAeronaveSelec);
            }

        }

        private void btnUrgentes_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA_MATRICULA_Vencimiento();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA_MATRICULA_FUT();
        }
    }
}
