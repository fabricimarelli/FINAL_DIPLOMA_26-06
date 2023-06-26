using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Mantenimiento
    {
        public int ID_mantenimiento { get; set; }
        public Aeronave aeronave { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string trabajos { get; set; }
        public string estado { get; set; }
        public decimal proximoMant { get; set; }
        
    }
}
