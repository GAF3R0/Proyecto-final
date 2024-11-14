using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class PRODUCTO
    {
        public long Prod_Id { get; set; }
        public string Prod_Nombre { get; set; }
        public int Prod_Cantidad { get; set; }
        public decimal Prod_Precio { get; set; }
        public string Prod_FechaCad { get; set; }
        public DateTime Fecha_Creacion { get; set; }

    }
}
