using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Cursos
{
    public class GestionaCursos
    {
        public static List<Curso> ObtieneCurso(Aeroclub aeroclub)
        {
            return aeroclub.Cursos.Include("aeronave").ToList();
        }

        public static Curso ObtieneCurso1(Aeroclub aeroclub, int ID_curso)
        {
            return aeroclub.Cursos.Include("matricula").FirstOrDefault(_ => _.ID_curso == ID_curso);
        }


        public static List<MODELO.Curso> ObtieneCurso(Aeroclub aeroclub, int ID_aeronave)
        {
            var cursos = from vuelo in aeroclub.Cursos.Include("aeronave")
                         where (ID_aeronave != 0 ? vuelo.aeronave.ID_aeronave == ID_aeronave : true)
                         select vuelo;
            return cursos.ToList();
        }
    }
}
