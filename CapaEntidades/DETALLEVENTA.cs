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
       public long folio { get; set; }
       public PRODUCTO oproducto { get; set; }
       public decimal Precio_Produnitario { get; set; }
       public int Cantidad { get; set; }
       public decimal Precio_Prodxcant { get; set; }
       public decimal TotalVenta { get; set; }
       public string FechaRegistro { get; set; }


    }
}
