using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Usuarios;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Usuarios
    {
        private static Usuarios instancia;


        public static Usuarios ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Usuarios();
            }
            return instancia;
        }

        Aeroclub oAeroclub;

        private Usuarios()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return GestionaUsuarios.ObtieneUsuario(oAeroclub);
        }

        public void AgregarUsuario(Usuario Usuario)
        {
            OperacionesUsuarios.AgregarUsuario(oAeroclub, Usuario);
            oAeroclub.SaveChanges();
        }

        public void EliminarUsuario(Usuario Usuario)
        {
            OperacionesUsuarios.EliminarUsuarios(oAeroclub, Usuario);
            oAeroclub.SaveChanges();
        }

        public void ModificarUsuario(Usuario Usuario)
        {
            oAeroclub.SaveChanges();
        }

        public List<Usuario> ObtenerUsuariomatricula(string nombreUsuario)
        {

            return CASOS_USO.Usuarios.GestionaUsuarios.ObtenerUsuarioUSERNAME(oAeroclub, nombreUsuario);
        }

    }

}