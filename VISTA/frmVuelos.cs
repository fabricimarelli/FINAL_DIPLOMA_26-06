using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;
using MODELO;

namespace VISTA
{
    public partial class frmVuelos : Form
    {
        private static frmVuelos instancia;
        public static frmVuelos OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmVuelos();
            if (instancia.IsDisposed)
                instancia = new frmVuelos();
            return instancia;
        }

        private Vuelos cVuelos;
        private Aeronaves cAeronaves;
        private Socios cSocios;
        private Vuelo oVuelo;
        char ACCION;
        decimal origTime = 0.1m;
        decimal origHoras = 0.1m;

        public frmVuelos()
        {
            InitializeComponent();
            cVuelos = Vuelos.ObtenerInstancia();
            cAeronaves = Aeronaves.ObtenerInstancia();
            cSocios = Socios.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA_MATRICULA();
            //ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvVuelos.DataSource = null;
            dgvVuelos.DataSource = cVuelos.ObtenerVuelos();
            dgvVuelos.Columns[0].HeaderText = "ID";
            dgvVuelos.Columns[1].HeaderText = "Aeronave";
            dgvVuelos.Columns[2].HeaderText = "Piloto";
            dgvVuelos.Columns[3].HeaderText = "Taq Salida";
            dgvVuelos.Columns[4].HeaderText = "Taq Llegada";
            dgvVuelos.Columns[5].HeaderText = "Tiempo";
            dgvVuelos.ReadOnly = true;
            dgvVuelos.AutoResizeColumn(0);
            dgvVuelos.AutoResizeColumn(3);
            dgvVuelos.AutoResizeColumn(4);
        }

        private void MODO_GRILLA()
        {
            gbDatosVuelo.Enabled = false;
            gbListaVuelos.Enabled = true;
            COMBO_VUELOS();
        }

        private void MODO_DATOS()
        {
            gbListaVuelos.Enabled = false;
            gbDatosVuelo.Enabled = true;

            if (ACCION == 'C')
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
            cmbAlumno.Enabled = false;
            txtTarifa.Enabled = false;
            txtTiempo.Enabled = false;
            COMBO_AERONAVES();
            COMBO_PILOTOS();
            COMBO_ALUMNOS();

        }

        private void LIMPIAR()
        {
            txtID.Clear();
            cmbAeronave.Items.Clear();
            cmbAeronave.Invalidate();
            cmbAlumno.Items.Clear();
            cmbPiloto.Items.Clear();
            txtObs.Clear();
            txtTaqLlegada.Clear();
            txtTaqSalida.Clear();
            txtTarifa.Clear();
            txtTiempo.Clear();
            cbInstruc.Checked = false;
        }

        private void VUELCA_DATOS()
        {
            if (dgvVuelos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vuelo de la lista");
                return;
            }

            oVuelo = (Vuelo)dgvVuelos.CurrentRow.DataBoundItem;
            txtID.Text = oVuelo.ID_vuelo.ToString();
            txtTaqLlegada.Text = oVuelo.taquimLlegada.ToString();
            txtTaqSalida.Text=oVuelo.taquimSalida.ToString();
            txtTarifa.Text = oVuelo.tarifa.ToString();
            txtTiempo.Text = oVuelo.tiempo.ToString();
            cmbAeronave.SelectedItem = oVuelo.aeronave;
            cmbPiloto.SelectedItem = oVuelo.piloto;
            
            

            Type tipo = oVuelo.GetType();
            if (typeof(MODELO.Vuelo).IsEquivalentTo(tipo))
            {
                cbInstruc.Checked = false;
            }
            else
            {
                cbInstruc.Checked = true;

                cmbAlumno.SelectedItem=((Instruccion)oVuelo).alumno;
            }
            
        }

        private void COMBO_VUELOS()
        {
            // Vacío la lista de clientes cada vez que quiero armar una nueva
            cmbVuelos.Items.Clear();
            cmbVuelos.Items.AddRange(cVuelos.OBTENER_AERONAVE().ToArray());
            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbVuelos.Items.Insert(0, new MODELO.Aeronave { ID_aeronave=0, matricula = "Todas las aeronaves..." }); 
            cmbVuelos.DisplayMember = "matricula";
            cmbVuelos.ValueMember = "ID_aeronave";
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

        private void COMBO_ALUMNOS()
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
            List<Piloto> listaPilotosSinLicencia = listaPilotos.Where(p => !p.esPiloto).ToList();
            cmbAlumno.Items.Clear();

            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbAlumno.Items.AddRange(listaPilotosSinLicencia.ToArray());

            cmbAlumno.DisplayMember = "apellido";
        }


        private void COMBO_AERONAVES()
        {

            cmbAeronave.Items.Clear();

            //le pido la lista y la asigno como arreglo
            cmbAeronave.Items.AddRange(cVuelos.OBTENER_AERONAVE().ToArray());
            cmbAeronave.Items.Insert(0, new MODELO.Aeronave { matricula = "LV-..." });
            cmbAeronave.DisplayMember = "matricula";
            cmbAeronave.ValueMember = "matricula";

        }

        private void ARMA_GRILLA_MATRICULA()//REVISAR, NO ANDA
        {

            dgvVuelos.DataSource = null;
            dgvVuelos.DataSource = cVuelos.ObtieneVuelo(cmbVuelos.SelectedItem!= null ?((MODELO.Aeronave)cmbVuelos.SelectedItem).ID_aeronave : 0);
            dgvVuelos.Columns[0].HeaderText = "ID";
            dgvVuelos.Columns[1].HeaderText = "Aeronave";
            dgvVuelos.Columns[2].HeaderText = "Piloto";
            dgvVuelos.Columns[3].HeaderText = "Taq Salida";
            dgvVuelos.Columns[4].HeaderText = "Taq Llegada";
            dgvVuelos.Columns[5].HeaderText = "Tiempo";
            dgvVuelos.Columns[6].HeaderText = "Tarifa";
            dgvVuelos.Columns[7].HeaderText = "Fecha";
            dgvVuelos.Columns[8].HeaderText = "Obs";
            dgvVuelos.ReadOnly = true;
            dgvVuelos.AutoResizeColumn(0);
            dgvVuelos.AutoResizeColumn(3);
            dgvVuelos.AutoResizeColumn(4);


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
            if (dgvVuelos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un vuelo de la lista");
                return;
            }
            oVuelo = (MODELO.Vuelo)dgvVuelos.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvVuelos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un vuelo de la lista");
                return;
            }
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ACCION = 'B';
            if (dgvVuelos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un vuelo de la lista");
                return;
            }
            oVuelo = (MODELO.Vuelo)dgvVuelos.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el vuelo " + oVuelo.ID_vuelo + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                MODIFICA_AERONAVE(oVuelo);
                cVuelos.EliminarVuelo(oVuelo);
                ARMA_GRILLA();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            decimal taqLleg = 0;
            decimal taqSal = 0;
            if (!decimal.TryParse(txtTaqLlegada.Text,out taqLleg))
            {
                MessageBox.Show("Ingrese taquimetro de llegada correctamente");
                return;
            }
            if (!decimal.TryParse(txtTaqSalida.Text, out taqSal))
            {
                MessageBox.Show("Ingrese taquimetro de salida correctamente");
                return;
            }
            if(cmbAeronave.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una aeronave");
                return;
            }
            if (cmbPiloto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un piloto");
                return;
            }
            if (cbInstruc.Checked)
            {
                if (cmbAlumno.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un alumno");
                    return;
                }
            }
            #endregion
            if (ACCION == 'A')
            {
                if (!cbInstruc.Checked)
                {
                    oVuelo = new Vuelo();
                    
                }
                else
                {
                    oVuelo = new Instruccion();
                    
                }
                
            }
            origTime = oVuelo.tiempo;//variable que almacena el tiempo del vuelo en caso de que sea
            origHoras = oVuelo.tiempo;
            oVuelo.piloto = (Piloto)cmbPiloto.SelectedItem;
            oVuelo.aeronave = (Aeronave)cmbAeronave.SelectedItem;
            oVuelo.fechaVuelo = dtpFechaVuelo.Value.Date;
            oVuelo.taquimLlegada = taqLleg;
            oVuelo.taquimSalida = taqSal;
            oVuelo.tiempo = oVuelo.CALCULAR_TIEMPO();
            oVuelo.tarifa = oVuelo.CALCULAR_TARIFA();
            oVuelo.observaciones=txtObs.Text;

            if(oVuelo.GetType() == typeof(Instruccion))
            {
                ((Instruccion)oVuelo).alumno = (Piloto)cmbAlumno.SelectedItem;
                //MessageBox.Show("ENtro caltuclo tarifa ins " + ((Instruccion)oVuelo).CALCULAR_TARIFA_INS());
                oVuelo.tarifa= ((Instruccion)oVuelo).CALCULAR_TARIFA();
            }

            if (ACCION == 'A')
            {
                //oVuelo.fechaAdmision = DateTime.Now;
                cVuelos.AgregarVuelo(oVuelo);
                
            }
            if (ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos del vuelo " + oVuelo.ID_vuelo + " ?", "ATENCION", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    
                    cVuelos.ModificarVuelo(oVuelo);
                    
                }
            }

            MODIFICA_AERONAVE(oVuelo);
            MODO_GRILLA();
            ARMA_GRILLA();
            LIMPIAR();

        }

        private void MODIFICA_AERONAVE(Vuelo oVuelo)//para modificar el taquimetro del avion involucrado
        {
            
            if(ACCION == 'A')
            {
                Aeronave oAeronaveSelec = (Aeronave)cmbAeronave.SelectedItem;
                Piloto oPilotoSelec=(Piloto)cmbPiloto.SelectedItem;
                oAeronaveSelec.taquimetro += oVuelo.tiempo;
                oPilotoSelec.horasVoladas+=oVuelo.tiempo; 
                cAeronaves.ModificarAeronave(oAeronaveSelec);
                cSocios.ModificarSocio(oPilotoSelec);
            }
            else if(ACCION == 'B')
            {
                Aeronave oAeronaveSelec = cAeronaves.ObtenerUNAAeronave(oVuelo.aeronave.matricula);
                Piloto oPilotoSelec = cSocios.ObtenerUNPiloto(oVuelo.piloto.DNI);
                oAeronaveSelec.taquimetro -= oVuelo.tiempo;
                oPilotoSelec.horasVoladas-=oVuelo.tiempo;
                cAeronaves.ModificarAeronave(oAeronaveSelec);
                cSocios.ModificarSocio(oPilotoSelec);
            }else if (ACCION == 'E')
            {
                Aeronave oAeronaveSelec = cAeronaves.ObtenerUNAAeronave(oVuelo.aeronave.matricula);
                Piloto oPilotoSelec = cSocios.ObtenerUNPiloto(oVuelo.piloto.DNI);
                if (oVuelo.tiempo < origTime||oVuelo.tiempo<origHoras)
                {
                    oAeronaveSelec.taquimetro -= (origTime - oVuelo.tiempo);
                    oPilotoSelec.horasVoladas -= (origHoras - oVuelo.tiempo);
                }
                else if(oVuelo.tiempo > origTime||oVuelo.tiempo>origHoras)
                {
                    oAeronaveSelec.taquimetro+=(oVuelo.tiempo - origTime);
                    oPilotoSelec.horasVoladas += (oVuelo.tiempo - origHoras);
                }
                cAeronaves.ModificarAeronave(oAeronaveSelec);
                cSocios.ModificarSocio(oPilotoSelec);
            }
           
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void cbInstruc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInstruc.Checked)
                cmbAlumno.Enabled = true;
            else
                cmbAlumno.Enabled = false;
        }
    }
}
