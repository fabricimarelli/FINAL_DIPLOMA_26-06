using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Reserva
    {
        #region PROPIEDADES
        public int ID_reserva { get; set; }
        public Piloto Piloto { get; set; }//usuario que realiza la reserva 
        public Aeronave aeronave { get; set; }//lista con las aeronaves disponibles
        public DateTime fecha { get; set; }
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        #endregion

        #region METODOS
        #endregion
    }
}