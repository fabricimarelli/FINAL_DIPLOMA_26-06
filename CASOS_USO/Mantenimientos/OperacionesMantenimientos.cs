using CONTEXTO;
using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.Mantenimientos
{
    public class OperacionesMantenimientos
    {
        public static void EliminarMantenimientos(Aeroclub aeroclub, Mantenimiento mantenimiento)
        {
            aeroclub.Mantenimientos.Remove(mantenimiento);
        }

        public static void AgregarMantenimiento(Aeroclub aeroclub, Mantenimiento mantenimiento)
        {
            aeroclub.Mantenimientos.Add(mantenimiento);
        }
    }
}
