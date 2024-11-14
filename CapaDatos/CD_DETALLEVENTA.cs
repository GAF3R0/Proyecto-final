using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public  class CD_DETALLEVENTA
    {
        String conectadobb = ConexionBD.cadena;
        public void ingresar(int id,  int idUsuario, int prodId, decimal precioVenta, int cantidad, decimal subtotal)
        {
            string insertQuery = "INSERT INTO DetalleVenta (Id_DetalleVenta, Id_Usuario, Prod_Id, Precio_Venta, Cantidad, Subtotal) " +
                                 "VALUES (@id,  @idUsuario, @prodId, @precioVenta, @cantidad, @subtotal)";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@idUsuario", idUsuario);
                        command.Parameters.AddWithValue("@prodId", prodId);
                        command.Parameters.AddWithValue("@precioVenta", precioVenta);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@subtotal", subtotal);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ingresar los usuarios: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }



    }
}
