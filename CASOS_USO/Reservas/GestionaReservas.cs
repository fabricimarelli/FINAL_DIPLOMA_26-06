using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Reservas
{
    public class GestionaReservas
    {
        public static List<Reserva> ObtieneReserva(Aeroclub aeroclub)
        {
            return aeroclub.Reservas.Include("aeronave").ToList();
        }

        public static Reserva ObtieneReserva1(Aeroclub aeroclub, int ID_reserva)
        {
            return aeroclub.Reservas.Include("matricula").FirstOrDefault(_ => _.ID_reserva == ID_reserva);
        }


        public static List<MODELO.Reserva> ObtieneReserva(Aeroclub aeroclub, int ID_aeronave)
        {
            var reservas = from reserva in aeroclub.Reservas.Include("aeronave")
                           where (ID_aeronave != 0 ? reserva.aeronave.ID_aeronave == ID_aeronave : true)
                           select reserva;
            return reservas.ToList();
        }


    }
}