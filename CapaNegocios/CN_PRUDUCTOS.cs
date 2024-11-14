using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_PRUDUCTOS
    {
        public CD_PRODUCTOS objcd_productos = new CD_PRODUCTOS();
        public List<PRODUCTO>  Listar()
        {
            return objcd_productos.Listar();
        }

        public void  MPBA(long id, string nombre, int cantidad, decimal precio, string fechacad)
        {
            objcd_productos.ingresar(id, nombre, cantidad, precio, fechacad);
        }

        public void SALV (long id)
        {
            objcd_productos.VMV(id);
        }

        public bool Existe(long id)
        {
            return objcd_productos.Existeprod(id);
        }

        public void EFEHOV(long id, string nombre, int cantidad, decimal precio, string fechacad)
        {
            objcd_productos.L(id, nombre, cantidad, precio, fechacad);
        }

        public void YTS(string nombre, int cantidad)
        {
            objcd_productos.UCP(nombre, cantidad);
        }
    }
}
