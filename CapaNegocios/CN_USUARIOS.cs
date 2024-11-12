using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_USUARIOS
    {
        private CD_USUARIO objCD_USUARIO = new CD_USUARIO();

        public List<USUARIO> Listar()
        {
            return objCD_USUARIO.Listar();
        }

        public void registrar(string nombreusuario, string phone, string clave, string correo, int idRol, bool estado)
        {
            objCD_USUARIO.registrar(nombreusuario, phone, clave, correo, idRol, estado);
        }
        public void elimina(string nombreusuario)
        {
            objCD_USUARIO.eliminar(nombreusuario);
        }

        public bool sihay(string nombreusuario)
        {
            return objCD_USUARIO.ExisteUsuario(nombreusuario);
        }


        public void editar(string nombreusuario, string phone, string clave, string correo, int idRol, bool estado)
        {
            objCD_USUARIO.actualizarPorNombre(nombreusuario, phone, clave, correo, idRol, estado);
        }
    }
}
