using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Reservas
{
    public class OperacionesReservas
    {
        public static void EliminarReservas(Aeroclub aeroclub, Reserva reserva)
        {
            aeroclub.Reservas.Remove(reserva);
        }

        public static void AgregarReserva(Aeroclub aeroclub, Reserva reserva)
        {
            aeroclub.Reservas.Add(reserva);
        }
    }
}