using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class USUARIO
    {
        /*
        Id_Usuario INT PRIMARY KEY auto_increment,
        Id_Rol INT,
        Nombre_Usuario VARCHAR(100),
        Telefono VARCHAR(15),
        Clave VARCHAR(10),
        Correo VARCHAR(20),
        Estado_bit VARCHAR(45),
        Fecha_Registro DATETIME default CURRENT_TIMESTAMP
         */
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public ROL oROl { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
