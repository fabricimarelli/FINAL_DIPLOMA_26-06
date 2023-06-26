using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Curso
    {
        #region PROPIEDADES
        public int ID_curso { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }
        public Aeronave aeronave { get; set; }
        public decimal horasVoladas { get; set; }
        public Piloto alumno { get; set; }


        #endregion

        #region METODOS
        #endregion
    }
}
