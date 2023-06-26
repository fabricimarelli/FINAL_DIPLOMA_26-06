using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Reservas;
using CASOS_USO.Vuelos;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Reservas
    {
        private static Reservas instancia;

        public static Reservas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Reservas();
            }
            return instancia;
        }

        Aeroclub oAeroclub;

        private Reservas()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Aeronave> OBTENER_AERONAVE()
        {
            return CASOS_USO.Aeronaves.GestionaAeroanves.ObtieneAeronaves(oAeroclub);
        }

        public List<Reserva> ObtenerReservas()
        {
            return GestionaReservas.ObtieneReserva(oAeroclub);
        }

        public void AgregarReserva(Reserva reserva)
        {
            OperacionesReservas.AgregarReserva(oAeroclub, reserva);
            oAeroclub.SaveChanges();
        }

        public void EliminarReserva(Reserva reserva)
        {
            OperacionesReservas.EliminarReservas(oAeroclub, reserva);
            oAeroclub.SaveChanges();
        }

        public void ModificarReserva(Reserva reserva)
        {
            oAeroclub.SaveChanges();
        }

        public List<Reserva> ObtieneReserva(int ID_aeronave)
        {
            return CASOS_USO.Reservas.GestionaReservas.ObtieneReserva(oAeroclub, ID_aeronave);
        }
    }
}
