using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Usuarios
{
    public class OperacionesUsuarios
    {
        public static void EliminarUsuarios(Aeroclub aeroclub, Usuario usuario)
        {
            aeroclub.Usuarios.Remove(usuario);
        }

        public static void AgregarUsuario(Aeroclub aeroclub, Usuario usuario)
        {
            aeroclub.Usuarios.Add(usuario);
        }
    }
}