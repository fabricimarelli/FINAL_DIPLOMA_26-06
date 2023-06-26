using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Aeronaves
{
    public class OperacionesAeronaves
    {
        public static void EliminarAeronaves(Aeroclub aeroclub, Aeronave aeronave)
        {
            aeroclub.Aeronaves.Remove(aeronave);
        }

        public static void AgregarAeronave(Aeroclub aeroclub, Aeronave aeronave)
        {
            aeroclub.Aeronaves.Add(aeronave);
        }
    }
}