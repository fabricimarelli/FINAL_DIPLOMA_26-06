using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Aeronaves
{
    public class GestionaAeroanves
    {


        public static List<Aeronave> ObtieneAeronaves(Aeroclub aeroclub)
        {
            return aeroclub.Aeronaves.ToList();
        }


        public static List<Aeronave> ObtenerAeronaveMAT(Aeroclub aeroclub, int ID_aeronave)
        {
            var aeronaves = from Aeronaves in aeroclub.Aeronaves
                            where (ID_aeronave != null ? Aeronaves.ID_aeronave == ID_aeronave : true)
                            select Aeronaves;
            return aeronaves.ToList();
        }

        public static Aeronave ObtenerUNAAeronave(Aeroclub aeroclub, string matricula)//prueba
        {
            var aeronave = from Aeronaves in aeroclub.Aeronaves
                           where (matricula != null ? Aeronaves.matricula == matricula : true)
                           select Aeronaves;
            return aeronave.First();

        }
    }
}
