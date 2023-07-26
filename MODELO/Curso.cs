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
        public decimal horasCumplidas { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; }
        public Aeronave aeronave { get; set; }
        public Piloto alumno { get; set; }
        public Piloto instructor { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }


        #endregion
        public override string ToString()
        {
            return nombre;
        }
        #region METODOS
        #endregion
    }
}
