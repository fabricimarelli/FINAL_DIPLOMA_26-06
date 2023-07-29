using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Auditorias;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Auditorias
    {
        private static Auditorias instancia;

        public static Auditorias ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Auditorias();
            }
            return instancia;
        }

        Aeroclub oAeroclub;
        private Auditorias()
        {
            oAeroclub=Aeroclub.obtener_instancia();
        }

        public List<Auditoria> ObtenerAuditorias()
        {
            return GestionaAuditorias.ObtieneAuditorias(oAeroclub);
        }

        public void AgregarAuditoria(Auditoria auditoria)
        {
            OperacionesAuditorias.AgregarAuditoria(oAeroclub, auditoria);
            oAeroclub.SaveChanges();
        }
    }
}
