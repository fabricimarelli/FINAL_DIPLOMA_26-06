using CONTEXTO;
using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.Cursos
{
    public class OperacionesCursos
    {
        public static void EliminarCursos(Aeroclub aeroclub, Curso curso)
        {
            aeroclub.Cursos.Remove(curso);
        }

        public static void AgregarCurso(Aeroclub aeroclub, Curso curso)
        {
            aeroclub.Cursos.Add(curso);
        }
    }
}
