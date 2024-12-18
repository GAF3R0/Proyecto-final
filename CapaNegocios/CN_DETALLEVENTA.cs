﻿using System;
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

        
            public void InsertarDetallesVenta(long folio, List<DETALLEVENTA> detalles)
            {
                foreach (var detalle in detalles)
                {
                
                 objcd_detaventa.InsertarDetalleVenta(
                        folio,
                        detalle.oproducto.Prod_Id,
                        detalle.Cantidad,
                        detalle.TotalVenta);
                }
            }

        

    }
}
