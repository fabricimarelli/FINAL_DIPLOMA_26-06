using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Socios
{
    public class OperacionesAeronaves
    {
        public static void EliminarSocios(Aeroclub aeroclub, Socio socio)
        {
            aeroclub.Socios.Remove(socio);
        }

        public static void AgregarSocio(Aeroclub aeroclub, Socio socio)
        {
            aeroclub.Socios.Add(socio);
        }
    }
}