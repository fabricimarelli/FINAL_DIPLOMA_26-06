using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Socios;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Socios
    {
        private static Socios instancia;


        public static Socios ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Socios();
            }
            return instancia;
        }

        Aeroclub oAeroclub;

        private Socios()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Socio> ObtenerSocios()
        {
            return GestionaSocios.ObtieneSocio(oAeroclub);
        }

        public void AgregarSocio(Socio socio)
        {
            OperacionesAeronaves.AgregarSocio(oAeroclub, socio);
            oAeroclub.SaveChanges();
        }

        public void EliminarSocio(Socio socio)
        {
            OperacionesAeronaves.EliminarSocios(oAeroclub, socio);
            oAeroclub.SaveChanges();
        }

        public void ModificarSocio(Socio socio)
        {
            oAeroclub.SaveChanges();
        }

        public List<Socio> ObtenerSocioDNI(int DNI)
        {
            return CASOS_USO.Socios.GestionaSocios.ObtenerSocioDNI(oAeroclub, DNI);
        }

        public Piloto ObtenerUNPiloto(int DNI)
        {
            return CASOS_USO.Socios.GestionaSocios.ObtenerUNSocio(oAeroclub, DNI);
        }

    }

}
