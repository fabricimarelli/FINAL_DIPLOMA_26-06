using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Aeronaves;
using CASOS_USO.Mantenimientos;
using CASOS_USO.Vuelos;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Mantenimientos
    {
        private static Mantenimientos instancia;


        public static Mantenimientos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Mantenimientos();
            }
            return instancia;
        }


        Aeroclub oAeroclub;

        private Mantenimientos()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Aeronave> OBTENER_AERONAVE()
        {
            return CASOS_USO.Aeronaves.GestionaAeroanves.ObtieneAeronaves(oAeroclub);
        }


        public List<Mantenimiento> ObtenerMantenimientos()
        {
            return GestionaMantenimientos.ObtieneMantenimiento(oAeroclub);
        }

        public void AgregarMantenimiento(Mantenimiento Mantenimiento)
        {
            OperacionesMantenimientos.AgregarMantenimiento(oAeroclub, Mantenimiento);
            oAeroclub.SaveChanges();
        }

        public void EliminarMantenimiento(Mantenimiento Mantenimiento)
        {
            OperacionesMantenimientos.EliminarMantenimientos(oAeroclub, Mantenimiento);
            oAeroclub.SaveChanges();
        }

        public void ModificarMantenimiento(Mantenimiento Mantenimiento)
        {
            oAeroclub.SaveChanges();
        }

        public List<Mantenimiento> ObtieneMantenimiento(int ID_aeronave)
        {

            return CASOS_USO.Mantenimientos.GestionaMantenimientos.ObtieneMantenimiento(oAeroclub, ID_aeronave);
        }

    }

}

