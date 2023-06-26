using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Vuelos
{
    public class OperacionesVuelos
    {
        public static void EliminarVuelos(Aeroclub aeroclub, Vuelo vuelo)
        {
            aeroclub.Vuelos.Remove(vuelo);
        }

        public static void AgregarVuelo(Aeroclub aeroclub, Vuelo vuelo)
        {
            aeroclub.Vuelos.Add(vuelo);
        }
    }
}