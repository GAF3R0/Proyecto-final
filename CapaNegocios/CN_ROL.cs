using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_ROL
    {
        private CD_ROL objCD_ROL = new CD_ROL();

        public List<ROL> Listar()
        {
            return objCD_ROL.Listar();
        }
    }
}
