using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Vuelos
{
    public class GestionaVuelos
    {
        public static List<Vuelo> ObtieneVuelo(Aeroclub aeroclub)
        {
            return aeroclub.Vuelos.Include("aeronave").ToList();
        }

        public static Vuelo ObtieneVuelo1(Aeroclub aeroclub, int ID_vuelo)
        {
            return aeroclub.Vuelos.Include("matricula").FirstOrDefault(_ => _.ID_vuelo == ID_vuelo);
        }


        public static List<MODELO.Vuelo> ObtieneVuelo(Aeroclub aeroclub, int ID_aeronave)
        {
            var vuelos = from vuelo in aeroclub.Vuelos.Include("aeronave")
                         where (ID_aeronave != 0 ? vuelo.aeronave.ID_aeronave == ID_aeronave : true)
                         select vuelo;
            return vuelos.ToList();
        }


    }
}