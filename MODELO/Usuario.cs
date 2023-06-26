using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Usuario
    {
        public int ID_usuario { get; set; }
        public string nombreUsuario { get; set; }
        public string email { get; set; }//para resetear la password
        public bool admin { get; set; }
        public string password { get; set; }
        //public Socio socio { get; set; }
    }
}
