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
    public partial class frmReservas : Form
    {
        private static frmReservas instancia;
        public static frmReservas OBTENER_INSTANCIA()
        {
            if(instancia==null)
                instancia = new frmReservas();
            if(instancia.IsDisposed)
                instancia=new frmReservas();
            return instancia;
        }

        private Reservas cReservas;
        private Aeronaves cAeronaves;
        private Socios cSocios;
        private Reserva oReserva;
        char ACCION;

        public frmReservas()
        {
            InitializeComponent();
            cReservas=Reservas.ObtenerInstancia();
            cAeronaves=Aeronaves.ObtenerInstancia();
            cSocios=Socios.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA();
            //ARMA_GRILLA_MATRICULA();
        }

        private void ARMA_GRILLA()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = cReservas.ObtenerReservas();
            dgvReservas.Columns[0].HeaderText = "ID";
            dgvReservas.Columns[1].HeaderText = "Piloto";
            dgvReservas.Columns[2].HeaderText = "Aeronave";
            dgvReservas.Columns[3].HeaderText = "Fecha";
            dgvReservas.Columns[4].HeaderText = "Desde";
            dgvReservas.Columns[5].HeaderText = "Hasta";
            dgvReservas.AutoResizeColumn(0);
            dgvReservas.AutoResizeColumn(3);
            dgvReservas.Columns[4].DefaultCellStyle.Format = "t";
            dgvReservas.Columns[5].DefaultCellStyle.Format = "t";
        }

        private void MODO_GRILLA()
        {
            gbDatosReserva.Enabled = false;
            gbListaReservas.Enabled = true;
            COMBO_RESERVAS();
        }

        private void MODO_DATOS()
        {
            gbListaReservas.Enabled=false;
            gbDatosReserva.Enabled=true;
            if (ACCION == 'C')
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
            COMBO_AERONAVES();
            COMBO_PILOTOS();
        }

        private void LIMPIAR()
        {
            txtID.Clear();
            cmbAeronave.Items.Clear();
            cmbPiloto.Items.Clear();
            dtpFecha.Value=DateTime.Now;
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
        }

        private void VUELCA_DATOS()
        {
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una reserva de la lista");
                return;
            }
                oReserva = (Reserva)dgvReservas.CurrentRow.DataBoundItem;
                txtID.Text = oReserva.ID_reserva.ToString();
                cmbPiloto.SelectedItem = oReserva.Piloto;
                cmbAeronave.SelectedItem = oReserva.aeronave;
                dtpFecha.Value= oReserva.fecha;
                dtpDesde.Value= oReserva.desde;
                dtpHasta.Value= oReserva.hasta;
            
        }

        private void COMBO_RESERVAS()
        {
            // Vacío la lista de reservas cada vez que quiero armar una nueva
            cmbReservas.Items.Clear();
            cmbReservas.Items.AddRange(cReservas.OBTENER_AERONAVE().ToArray());
            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbReservas.Items.Insert(0, new MODELO.Aeronave { ID_aeronave = 0, matricula = "Todas las aeronaves..." });
            cmbReservas.DisplayMember = "matricula";
            cmbReservas.ValueMember = "ID_aeronave";
        }

        private void COMBO_PILOTOS()
        {
            List<Socio> listaSocios = cSocios.ObtenerSocios(); // Obtener lista de objetos de tipo socio
            List<Piloto> listaPilotos = new List<Piloto>();

            foreach (Socio socio in listaSocios)
            {
                if (socio is Piloto) // Verificar si el objeto es de tipo piloto
                {
                    Piloto piloto = (Piloto)socio; // Castear el objeto a tipo piloto
                    listaPilotos.Add(piloto); // Agregar el piloto a la lista de pilotos
                }
            }
            List<Piloto> listaPilotosSinLicencia = listaPilotos.Where(p => p.esPiloto).ToList();
            cmbPiloto.Items.Clear();

            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbPiloto.Items.AddRange(listaPilotosSinLicencia.ToArray());

            cmbPiloto.DisplayMember = "apellido";

        }

        private void COMBO_AERONAVES()
        {

            cmbAeronave.Items.Clear();

            //le pido la lista y la asigno como arreglo
            cmbAeronave.Items.AddRange(cReservas.OBTENER_AERONAVE().ToArray());
            cmbAeronave.Items.Insert(0, new MODELO.Aeronave { matricula = "LV-..." });
            cmbAeronave.DisplayMember = "matricula";
            cmbAeronave.ValueMember = "matricula";

        }

        private void ARMA_GRILLA_MATRICULA()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = cReservas.ObtieneReserva(cmbReservas.SelectedItem != null ? ((MODELO.Aeronave)cmbReservas.SelectedItem).ID_aeronave : 0);
            dgvReservas.Columns[0].HeaderText = "ID";
            dgvReservas.Columns[1].HeaderText = "Piloto";
            dgvReservas.Columns[2].HeaderText = "Aeronave";
            dgvReservas.Columns[3].HeaderText = "Fecha";
            dgvReservas.Columns[4].HeaderText = "Desde";
            dgvReservas.Columns[5].HeaderText = "Hasta";
            dgvReservas.AutoResizeColumn(0);
            dgvReservas.AutoResizeColumn(3);
            dgvReservas.Columns[4].DefaultCellStyle.Format = "t";
            dgvReservas.Columns[5].DefaultCellStyle.Format = "t";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA_MATRICULA();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = 'A';
            MODO_DATOS();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ACCION = 'E';
            if(dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una reserva de la lista");
                return;
            }
            oReserva = (MODELO.Reserva)dgvReservas.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una reserva de la lista");
                return;
            }
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ACCION = 'B';
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una reserva de la lista");
                return;
            }
            oReserva = (MODELO.Reserva)dgvReservas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la reserva " + oReserva.ID_reserva + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                //MODIFICA_RESERVA(oReserva); para volver a poner disponible el avion en la fecha y/o horario??
                cReservas.EliminarReserva(oReserva);
                ARMA_GRILLA();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            if (cmbAeronave.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una aeronave");
                return;
            }
            if (cmbPiloto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un piloto");
                return;
            }
            if (dtpFecha.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha no puede ser pasada, por favor seleccione una fecha correcta");
                return;
            }
            if (dtpHasta.Value.Hour == dtpDesde.Value.Hour)
            {
                MessageBox.Show("La reserva minima es de una hora");
                return;
            }
            if(dtpHasta.Value.Hour < dtpDesde.Value.Hour)
            {
                MessageBox.Show("La HORA HASTA no puede ser menor a la HORA DESDE");
                return;
            }
            #endregion
            #region PASE DE VALORES A OBJETO

            if (ACCION == 'A')
            {
                oReserva=new MODELO.Reserva();
            }
            // Crear una nueva instancia de la clase Reserva y asignar los valores
            oReserva.Piloto = (Piloto)cmbPiloto.SelectedItem;
            oReserva.aeronave = (Aeronave)cmbAeronave.SelectedItem;
            oReserva.fecha = dtpFecha.Value.Date;
            oReserva.desde = dtpDesde.Value;
            oReserva.hasta = dtpHasta.Value;
            #endregion

            if (ACCION == 'A')
            {
                cReservas.AgregarReserva(oReserva);
            }
            if (ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos de la reserva " + oReserva.ID_reserva + " ?", "ATENCION", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {

                    cReservas.ModificarReserva(oReserva);

                }
            }
            MODO_GRILLA();
            ARMA_GRILLA();
            LIMPIAR();
        }

        
    }
}
