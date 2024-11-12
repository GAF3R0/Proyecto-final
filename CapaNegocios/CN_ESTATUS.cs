using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_ESTATUS
    {
        private CD_ESTATUS objCD_ESTATUS = new CD_ESTATUS();

        public List<ESTATUS> Listar()
        {
            return objCD_ESTATUS.Listar();
        }

    }
}
