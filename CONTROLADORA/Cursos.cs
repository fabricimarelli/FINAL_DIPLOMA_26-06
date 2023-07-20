using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Cursos;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Cursos
    {
        private static Cursos instancia;

        public static Cursos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Cursos();
            }
            return instancia;
        }

        Aeroclub oAeroclub;

        private Cursos()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Aeronave> OBTENER_AERONAVE()
        {
            return CASOS_USO.Aeronaves.GestionaAeroanves.ObtieneAeronaves(oAeroclub);
        }

        public List<Curso> ObtenerCursos()
        {
            return GestionaCursos.ObtieneCurso(oAeroclub);
        }

        public void AgregarCurso(Curso curso)
        {
            OperacionesCursos.AgregarCurso(oAeroclub, curso);
            oAeroclub.SaveChanges();
        }

        public void EliminarCurso(Curso curso)
        {
            OperacionesCursos.EliminarCursos(oAeroclub, curso);
            oAeroclub.SaveChanges();
        }

        public void ModificarCurso(Curso curso)
        {
            oAeroclub.SaveChanges();
        }

        public List<Curso> ObtieneCurso(int ID_aeronave)
        {
            return CASOS_USO.Cursos.GestionaCursos.ObtieneCurso(oAeroclub, ID_aeronave);
        }
    }
}
