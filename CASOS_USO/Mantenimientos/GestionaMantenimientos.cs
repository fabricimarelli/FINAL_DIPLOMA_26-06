using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using CONTEXTO.Migrations;
using MODELO;

namespace CASOS_USO.Mantenimientos
{
    public class GestionaMantenimientos
    {
        public static List<Mantenimiento> ObtieneMantenimiento(Aeroclub aeroclub)
        {
            return aeroclub.Mantenimientos.Include("aeronave").ToList();
        }

        public static Mantenimiento ObtieneMantenimiento1(Aeroclub aeroclub, int ID_mantenimiento)
        {
            return aeroclub.Mantenimientos.Include("matricula").FirstOrDefault(_ => _.ID_mantenimiento == ID_mantenimiento);
        }


        public static List<MODELO.Mantenimiento> ObtieneMantenimiento(Aeroclub aeroclub, int ID_aeronave)
        {
            var mantenimientos = from mantenimiento in aeroclub.Mantenimientos.Include("aeronave")
                                 where (ID_aeronave != 0 ? mantenimiento.aeronave.ID_aeronave == ID_aeronave : true)
                                 select mantenimiento;
            return mantenimientos.ToList();
        }


    }
}