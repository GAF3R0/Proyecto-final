using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class PERMISOS
    {
        /*
    Id_Permisos INT PRIMARY KEY auto_increment,
    Rol_Id_Rol INT,
    NombreMenu VARCHAR(50),
    FechaCreacion DATETIME  default CURRENT_TIMESTAMP,*/
        public int id_permiso { get; set; }
        public ROL oROL { get; set; }
        public String Nombremenu { get; set; }
        public string FechaRegistro { get; set; }

    }
}
