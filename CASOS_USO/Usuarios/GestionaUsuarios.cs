using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Usuarios
{
    public class GestionaUsuarios
    {
        public static List<Usuario> ObtieneUsuario(Aeroclub aeroclub)
        {
            return aeroclub.Usuarios.ToList();
        }


        public static List<MODELO.Usuario> ObtenerUsuarioUSERNAME(Aeroclub aeroclub, string nombreUsuario)
        {
            var usuarios = from Usuarios in aeroclub.Usuarios
                           where (nombreUsuario != null ? Usuarios.nombreUsuario == nombreUsuario : true)
                           select Usuarios;
            return usuarios.ToList();
        }


    }
}