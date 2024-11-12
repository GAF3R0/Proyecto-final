using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class PERMISO
    {
        public int Id_permiso { get; set; }
        public ROL oROL { get; set; }
        public String Nombremenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
