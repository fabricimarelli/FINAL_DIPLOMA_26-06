using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Vuelos;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Vuelos
    {
        private static Vuelos instancia;


        public static Vuelos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Vuelos();
            }
            return instancia;
        }

        Aeroclub oAeroclub;

        private Vuelos()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Aeronave> OBTENER_AERONAVE()
        {
            return CASOS_USO.Aeronaves.GestionaAeroanves.ObtieneAeronaves(oAeroclub);
        }


        public List<Vuelo> ObtenerVuelos()
        {
            return GestionaVuelos.ObtieneVuelo(oAeroclub);
        }

        public void AgregarVuelo(Vuelo Vuelo)
        {
            OperacionesVuelos.AgregarVuelo(oAeroclub, Vuelo);
            oAeroclub.SaveChanges();
        }

        public void EliminarVuelo(Vuelo Vuelo)
        {
            OperacionesVuelos.EliminarVuelos(oAeroclub, Vuelo);
            oAeroclub.SaveChanges();
        }

        public void ModificarVuelo(Vuelo Vuelo)
        {
            oAeroclub.SaveChanges();
        }

        public List<Vuelo> ObtieneVuelo(int ID_aeronave)
        {

            return CASOS_USO.Vuelos.GestionaVuelos.ObtieneVuelo(oAeroclub, ID_aeronave);
        }

    }

}