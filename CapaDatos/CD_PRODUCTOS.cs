using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidades;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_PRODUCTOS
    {
        String conectadobb = ConexionBD.cadena;
        public List<PRODUCTO> Listar()
        {
            List<PRODUCTO> lista = new List<PRODUCTO>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT * FROM Productos;");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PRODUCTO()
                            {
                                Prod_Id = Convert.ToInt64(dr["Prod_Id"]),
                                Prod_Nombre = dr["Prod_Nombre"].ToString(),
                                Prod_Cantidad = Convert.ToInt32(dr["Prod_Cantidad"]),
                                Prod_Precio = Convert.ToDecimal(dr["Prod_Precio"]),                                
                                Prod_FechaCad = dr["Prod_FechaCad"] != DBNull.Value
                                                ? Convert.ToDateTime(dr["Prod_FechaCad"]).ToString("yyyy-MM-dd")
                                                : null 
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los productos: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }




        //insert into Productos(Prod_Id,Prod_Nombre,Prod_Cantidad,Prod_Precio,Prod_FechaCad) value(7654321,"Menbresia",20,150.5,null);
        public void ingresar(long id, string nombre, int cantidad, decimal precio, string fechacad)
        {
            string insertQuery = "insert into Productos(Prod_Id,Prod_Nombre,Prod_Cantidad,Prod_Precio,Prod_FechaCad) VALUES (@id, @nombre, @cant, @precio, @fechacad)";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@cant", cantidad);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.Parameters.AddWithValue("@fechacad", fechacad);

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

        public void VMV(long id)
        {
            string deleteQuery = "DELETE FROM Productos WHERE Prod_Id = @id";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró ningún usuario con el nombre especificado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
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

        public bool Existeprod(long ide)
        {
            string query = "SELECT COUNT(*) FROM Productos WHERE Prod_Id = @id";
            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", ide);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Retorna true si el usuario existe
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar la existencia del usuario: " + ex.Message, ex);
                }
            }
        }

        public void L(long prodId, string nombre, int cantidad, decimal precio, string fechacad)
        {
            if (!Existeprod(prodId))
            {
                throw new Exception("El producto no existe.");
            }

            string updateQuery = "UPDATE Productos SET Prod_Nombre = @nombre ,Prod_Cantidad = @Stock ,Prod_Precio = @Precio ,Prod_FechaCad = @fechacad WHERE Prod_Id = @ProdId";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {

                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@Stock", cantidad);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@fechacad", fechacad);
                        command.Parameters.AddWithValue("@ProdId", prodId);

                       
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el producto: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
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

        public void UCP(string nombre, int cantidad)
        {
           
            string query = "UPDATE Productos SET Prod_Cantidad = Prod_Cantidad - @cantidadVendida WHERE Prod_Nombre = @productoNombre";

            using (MySqlConnection conn = new MySqlConnection(conectadobb))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productoNombre", nombre);
                        cmd.Parameters.AddWithValue("@cantidadVendida", cantidad);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la cantidad del producto: " + ex.Message);
                }
            }
        }


    }
}
