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
    public partial class frmCursos : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmCursos instancia;
        public static frmCursos OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmCursos();
            if (instancia.IsDisposed)
                instancia = new frmCursos();

            return instancia;
        }

        private Cursos cCursos;
        private Aeronaves cAeronaves;
        private Socios cSocios;
        private Curso oCurso;
        char ACCION;
        public frmCursos()
        {
            InitializeComponent();
            cCursos = Cursos.ObtenerInstancia();
            cAeronaves = Aeronaves.ObtenerInstancia();
            cSocios = Socios.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA_MATRICULA();
        }

        private void ARMA_GRILLA()
        {
            dgvCursos.DataSource = null;
            dgvCursos.DataSource = cCursos.ObtenerCursos();
            dgvCursos.Columns[0].HeaderText = "ID";
            dgvCursos.Columns[1].HeaderText = "Nombre";
            dgvCursos.Columns[2].HeaderText = "Horas Cumplidas";
            dgvCursos.Columns[3].HeaderText = "Categoria";
            dgvCursos.Columns[4].HeaderText = "Estado";
            dgvCursos.Columns[5].HeaderText = "Aeronave";
            dgvCursos.Columns[6].HeaderText = "Alumno";
            dgvCursos.Columns[7].HeaderText = "Instructor";
            dgvCursos.Columns[8].HeaderText = "Fecha Inicio";
            dgvCursos.Columns[9].HeaderText = "Fecha Fin";
            dgvCursos.ReadOnly = true;
            dgvCursos.AutoResizeColumn(0);

        }

        private void MODO_GRILLA()
        {
            gbDatosCurso.Enabled = false;
            gbListaCursos.Enabled = true;
            //COMBO_CURSOS();
        }

        private void MODO_DATOS()
        {
            gbListaCursos.Enabled = false;
            gbDatosCurso.Enabled = true;

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
            COMBO_ALUMNOS();

        }

        private void LIMPIAR()
        {
            txtID.Clear();
            cmbAeronave.Items.Clear();
            cmbInstructor.Items.Clear();
            cmbAlumno.Items.Clear();
            txtHorasCumplidas.Clear();
            txtNombre.Clear();
            rbPPA.Checked = false;
            rbPCA.Checked = false;
            rbAeroap.Checked = false;
            rbAdap.Checked = false;
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            rbProceso.Checked = false;
            rbFinalizado.Checked = false;
            rbCancelado.Checked = false;
        }

        private void VUELCA_DATOS()
        {
            if (dgvCursos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un curso de la lista");
                return;
            }

            oCurso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
            txtID.Text = oCurso.ID_curso.ToString();
            txtNombre.Text = oCurso.nombre;
            txtHorasCumplidas.Text = oCurso.horasCumplidas.ToString();
            dtpInicio.Value = oCurso.fechaInicio;
            dtpFin.Value = oCurso.fechaFin;
            cmbAeronave.SelectedItem = oCurso.aeronave;
            cmbAlumno.SelectedItem = oCurso.alumno;
            cmbInstructor.SelectedItem = oCurso.instructor;
            //vuelca categoria
            if (oCurso.categoria == "PPA")
            {
                rbPPA.Checked = true;
            }
            else if (oCurso.categoria == "PCA")
            {
                rbPPA.Checked = true;
            }
            else if (oCurso.categoria == "Aeroaplicador")
            {
                rbAeroap.Checked = true;
            }
            else if (oCurso.categoria == "Adaptacion")
            {
                rbAdap.Checked = true;
            }
            //vuelca estado
            if (oCurso.estado == "En proceso")
            {
                rbProceso.Checked = true;
            }
            else if (oCurso.estado == "Finalizado")
            {
                rbFinalizado.Checked = true;
            }
            else if (oCurso.estado == "Cancelado")
            {
                rbCancelado.Checked = true;
            }

        }

        private void COMBO_CURSOS()//CAMBIAR AERONAVE POR ALUMNO
        {
            // Vacío la lista de clientes cada vez que quiero armar una nueva
            cmbCursos.Items.Clear();
            cmbCursos.Items.AddRange(cCursos.OBTENER_AERONAVE().ToArray());
            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbCursos.Items.Insert(0, new MODELO.Aeronave { ID_aeronave = 0, matricula = "Todas las aeronaves..." });
            cmbCursos.DisplayMember = "matricula";
            cmbCursos.ValueMember = "ID_aeronave";
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
            List<Piloto> listaPilotosAlumnos = listaPilotos.ToList();//SinLicencia = listaPilotos.Where(p => p.esPiloto).ToList();
            cmbInstructor.Items.Clear();

            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbInstructor.Items.AddRange(listaPilotosAlumnos.ToArray());

            cmbInstructor.DisplayMember = "apellido ";

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
            List<Piloto> listaPilotosAlumnos = listaPilotos.ToList();//SinLicencia = listaPilotos.Where(p => p.esPiloto).ToList();
            cmbAlumno.Items.Clear();

            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbAlumno.Items.AddRange(listaPilotosAlumnos.ToArray());

            cmbAlumno.DisplayMember = "apellido ";

        }

        private void COMBO_AERONAVES()
        {

            cmbAeronave.Items.Clear();

            //le pido la lista y la asigno como arreglo
            cmbAeronave.Items.AddRange(cCursos.OBTENER_AERONAVE().ToArray());
            cmbAeronave.Items.Insert(0, new MODELO.Aeronave { matricula = "LV-..." });
            cmbAeronave.DisplayMember = "matricula";
            cmbAeronave.ValueMember = "matricula";

        }

        private void ARMA_GRILLA_MATRICULA()//REVISAR, NO ANDA
        {

            dgvCursos.DataSource = null;
            dgvCursos.DataSource = cCursos.ObtieneCurso(cmbCursos.SelectedItem != null ? ((MODELO.Aeronave)cmbCursos.SelectedItem).ID_aeronave : 0);//cambiar por alumno
            dgvCursos.Columns[0].HeaderText = "ID";
            dgvCursos.Columns[1].HeaderText = "Nombre";
            dgvCursos.Columns[2].HeaderText = "Horas Cumplidas";
            dgvCursos.Columns[3].HeaderText = "Categoria";
            dgvCursos.Columns[4].HeaderText = "Estado";
            dgvCursos.Columns[5].HeaderText = "Aeronave";
            dgvCursos.Columns[6].HeaderText = "Alumno";
            dgvCursos.Columns[7].HeaderText = "Instructor";
            dgvCursos.Columns[8].HeaderText = "Fecha Inicio";
            dgvCursos.Columns[9].HeaderText = "Fecha Fin";
            dgvCursos.ReadOnly = true;
            dgvCursos.AutoResizeColumn(0);

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
            if (dgvCursos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un curso de la lista");
                return;
            }
            oCurso = (MODELO.Curso)dgvCursos.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvCursos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un curso de la lista");
                return;
            }
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ACCION = 'B';
            if (dgvCursos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un curso de la lista");
                return;
            }
            oCurso = (MODELO.Curso)dgvCursos.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el vuelo " + oCurso.ID_curso + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cCursos.EliminarCurso(oCurso);
                ARMA_GRILLA();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            if (cmbAeronave.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una aeronave");
                return;
            }
            if (cmbInstructor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un instructor");
                return;
            }
            if (cmbAlumno.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }
            if (dtpInicio.Value > dtpFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin");
                return;
            }
            if (!rbPCA.Checked && !rbPPA.Checked && !rbAeroap.Checked && !rbAdap.Checked)
            {
                MessageBox.Show("Seleccione una categoria");
                return;
            }
            if (!rbCancelado.Checked && !rbFinalizado.Checked && !rbProceso.Checked)
            {
                MessageBox.Show("Seleccione un estado");
                return;
            }
            #endregion
            if (ACCION == 'A')
            {
                oCurso = new Curso();
            }
            oCurso.instructor = (Piloto)cmbInstructor.SelectedItem;
            oCurso.aeronave = (Aeronave)cmbAeronave.SelectedItem;
            oCurso.alumno = (Piloto)cmbAlumno.SelectedItem;
            oCurso.fechaInicio = dtpInicio.Value;
            oCurso.fechaFin = dtpFin.Value;
            #region CATEGORIA
            if (rbPPA.Checked)
            {
                oCurso.categoria = "PPA";
            }
            else if (rbPCA.Checked)
            {
                oCurso.categoria = "PCA";
            }
            else if (rbAeroap.Checked)
            {
                oCurso.categoria = "Aeroaplicador";
            }
            else if (rbAdap.Checked)
            {
                oCurso.categoria = "Adaptacion";
            }
            #endregion
            #region ESTADO
            if (rbProceso.Checked)
            {
                oCurso.estado = "En proceso";
            }
            else if(rbCancelado.Checked)
            {
                oCurso.estado = "Cancelado";
            }
            else if(rbFinalizado.Checked)
            {
                oCurso.estado = "Finalizado";
            }
            #endregion
            oCurso.nombre = oCurso.alumno.nombre + " " + oCurso.alumno.apellido + "-" + oCurso.categoria;

            if (ACCION == 'A')
            {
                //oVuelo.fechaAdmision = DateTime.Now;
                cCursos.AgregarCurso(oCurso);

            }
            if (ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos del vuelo " + oCurso.ID_curso + " ?", "ATENCION", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {

                    cCursos.ModificarCurso(oCurso);

                }
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
    }
}
