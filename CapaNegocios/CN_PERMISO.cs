using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_PERMISO
    {
        private CD_PERMISO objCD_PERMISO = new CD_PERMISO();

        public List<PERMISO> Listar(int Id_usuario)
        {
            return objCD_PERMISO.Listar(Id_usuario);
        }
    }
}
