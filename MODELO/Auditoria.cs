using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Auditoria
    {
        public int ID_audit { get; set; }
        public string usuario { get; set; }
        public string tipoOperacion { get;set; }
        public DateTime fechaHora { get; set; }
    }
}
