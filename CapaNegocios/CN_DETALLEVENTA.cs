using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_DETALLEVENTA
    {
        private CD_DETALLEVENTA objcd_detaventa = new CD_DETALLEVENTA();

        public List<DETALLEVENTA> Listar()
        {
            return objcd_detaventa.Listar();
        }

        public void InsertarDetalleVenta(long folio, long prodId, decimal precioUnitario, int cantidad, decimal precioTotal, decimal totalVenta)
        {
            objcd_detaventa.InsertarDetalleVenta(folio, prodId, precioUnitario, cantidad, precioTotal, totalVenta);
        }
    }
}
