using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using CONTEXTO;

namespace CASOS_USO.Auditorias
{
    public class GestionaAuditorias
    {
        public static List<Auditoria> ObtieneAuditorias(Aeroclub aeroclub)
        {
            return aeroclub.Auditorias.ToList();
        }
    }
}
