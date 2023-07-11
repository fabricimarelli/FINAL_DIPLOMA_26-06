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

        public frmCursos()
        {
            InitializeComponent();
        }

       
    }
}
