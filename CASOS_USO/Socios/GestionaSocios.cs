using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Socios
{
    public class GestionaSocios
    {
        public static List<Socio> ObtieneSocio(Aeroclub aeroclub)//esta es la del combo
        {
            return aeroclub.Socios.ToList();
        }


        public static List<MODELO.Socio> ObtenerSocioDNI(Aeroclub aeroclub, int DNI)
        {
            var socios = from Socios in aeroclub.Socios
                         where (DNI != 0 ? Socios.DNI == DNI : true)
                         select Socios;
            return socios.ToList();
        }

        public static Piloto ObtenerUNSocio(Aeroclub aeroclub, int DNI)//prueba
        {
            var piloto = from Socios in aeroclub.Socios
                         where (DNI != null ? Socios.DNI == DNI : true)
                         select Socios;
            return piloto.OfType<Piloto>().First();

        }

    }
}
