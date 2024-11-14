using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DETALLEVENTA
    {
       public int Id_DetalleVenta { get; set; }
       public USUARIO ousuario { get; set; }
       public PRODUCTO oproducto { get; set; }
       public decimal Precio_Venta { get; set; }
       public int Cantidad { get; set; }
       public decimal Subtotal { get; set; }
       public string FechaRegistro { get; set; }


    }
}
