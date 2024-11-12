using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class VENTA
    { 
        public int Ven_Id { get; set; }
        public USUARIO ousuario { get; set; }
        public decimal Monto_Pago { get; set; }
        public decimal Monto_Cambio { get; set; }
        public decimal Monto_Total { get; set; }
        public string FechaRegistro { get; set; }


    }
}
