using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public  class CLIENTE
    {
        public int Cli_Id { get; set; }
        public String Cli_Nombre { get; set; }
        public int Cli_Edad { get; set; }
        public String Cli_Telefono { get; set; }
        public String Cli_Telefono_Emer { get; set; }
        public String Cli_Correo { get; set; }
        public String Cli_Domicilio { get; set; }
        public String Cli_Colonia { get; set; }
        public ESTATUS oestatus { get; set; }
        public String Fecha_Creacion { get; set; }
        public String Fecha_termina { get; set; }

    }
}
