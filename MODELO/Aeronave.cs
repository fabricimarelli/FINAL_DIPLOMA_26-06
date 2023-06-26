using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Aeronave
    {
        #region PROPIEDADES

        public int ID_aeronave { get; set; }
        public string matricula { get; set; }
        public string marcaModelo { get; set; }
        public decimal taquimetro { get; set; }
        public decimal taquimetroFuturo { get; set; }
        public decimal tarifaHora { get; set; }
        public bool enServicio { get; set; }

        #endregion
        public override string ToString()
        {
            return matricula;
        }
        #region METODOS

        #endregion

    }
}