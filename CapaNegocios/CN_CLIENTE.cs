using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_CLIENTE
    {
        private CD_CLIENTE objCD_CLIENTE = new CD_CLIENTE();
        public List<CLIENTE> Listar()
        {
            return objCD_CLIENTE.Listar();
        }

        public void ingresarcln(string Cli_Nombre, int edad, string telefono, string telefono911, string correo, string domicilio, string colonia, int estadoId)
        {
            objCD_CLIENTE.ingresar_cliente(Cli_Nombre, edad, telefono, telefono911, correo, domicilio, colonia, estadoId);
        }

        public bool sihay(string Cli_Nombre)
        {
            return objCD_CLIENTE.clienteexiste(Cli_Nombre);
        }

        public void actualiza(string Cli_Nombre, int edad, string telefono, string telefono911, string correo, string domicilio, string colonia, int estadoId)
        {
            objCD_CLIENTE.actualizarPorNombreCliente(Cli_Nombre, edad,  telefono,  telefono911,  correo,  domicilio,  colonia,  estadoId);
        }

        public void byebye (string Cli_Nombre)
        {
            objCD_CLIENTE.eliminar(Cli_Nombre);
        }

        public List<CLIENTE> LDM()
        {
            return objCD_CLIENTE.Listar_miembros();
        }

        public List<CLIENTE> LDV()
        {
            return objCD_CLIENTE.Listar_visistas();
        }

        public void soyyootravez(int id )
        {
            objCD_CLIENTE.Renovar(id);
        }

        
        public void generaqr(int id)
        {
            objCD_CLIENTE.generaqr(id);  
        }
    }
}
