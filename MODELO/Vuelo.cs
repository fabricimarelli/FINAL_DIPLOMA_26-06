using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Vuelo
    {
        #region PROPIEDADES
        public int ID_vuelo { get; set; }
        public Aeronave aeronave { get; set; }
        public Piloto piloto { get; set; }
        public decimal taquimSalida { get; set; }
        public decimal taquimLlegada { get; set; }
        public decimal tiempo { get; set; }
        public decimal tarifa { get; set; }
        public DateTime fechaVuelo { get; set; }
        public string observaciones { get; set; }

        #endregion

        #region METODOS
        public decimal CALCULAR_TIEMPO()
        {
            decimal tiempo = 0;
            tiempo = (taquimLlegada - taquimSalida);
            return tiempo;
        }
        public decimal CALCULAR_TARIFA()
        {
            decimal tarifa = 0;
            tarifa = ((aeronave.tarifaHora) * tiempo);
            return tarifa;
        }
        #endregion

    }

    public class Instruccion : Vuelo
    {
        #region PROPIEDADES
        public Piloto alumno { get; set; }
        //public decimal tarifaIns { get; set; }

        #endregion


        #region METODOS


        public decimal CALCULAR_TARIFA()
        {

            decimal tarifa = 0;
            tarifa = ((aeronave.tarifaHora) * tiempo)+(((aeronave.tarifaHora) * tiempo)*0.1m);
            return tarifa;
        }
        #endregion
    }


}