using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using CONTEXTO;

namespace CASOS_USO.Auditorias
{
    public class OperacionesAuditorias
    {
        public static void AgregarAuditoria(Aeroclub aeroclub, Auditoria auditoria)
        {
            aeroclub.Auditorias.Add(auditoria);
        }
    }
}
