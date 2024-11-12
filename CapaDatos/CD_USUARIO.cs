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
    public class CD_USUARIO
    {
        String conectadobb = ConexionBD.cadena;
        public List<USUARIO> Listar()
        {
            List<USUARIO> lista = new List<USUARIO>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.Id_Usuario, u.Nombre_Usuario, u.Telefono, u.Correo, u.Clave, u.estado, r.Id_Rol, r.Descripcion FROM Usuario u");
                    query.AppendLine("INNER JOIN Rol r ON r.Id_Rol = u.Id_Rol");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new USUARIO()
                            {
                                Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]),
                                Nombre_Usuario = dr["Nombre_Usuario"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["estado"]),
                                oROl = new ROL()
                                {
                                    Id_Rol = Convert.ToInt32(dr["Id_Rol"]),
                                    Descripcion = dr["Descripcion"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los usuarios: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }

        public void registrar(string nombreusuario, string phone, string clave, string correo, int idRol, bool estado)
        {
            string insertQuery = "INSERT INTO Usuario (Nombre_Usuario, Telefono, Clave, Correo, Id_Rol, Estado) VALUES (@NombreUsuario, @Telefono, @Clave, @Correo, @IdRol, @Estado)";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreusuario);
                        command.Parameters.AddWithValue("@Telefono", phone);
                        command.Parameters.AddWithValue("@Clave", clave);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@IdRol", idRol);
                        command.Parameters.AddWithValue("@Estado", estado);

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

        public void eliminar (string nombreusuario)
        {
            string deleteQuery = "DELETE FROM Usuario WHERE Nombre_Usuario = @NombreUsuario";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreusuario);

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

        public bool ExisteUsuario(string nombreusuario)
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE Nombre_Usuario = @NombreUsuario";
            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreusuario);
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

        public void actualizarPorNombre(string nombreusuario, string phone, string clave, string correo, int idRol, bool estado)
        {
            // Primero, verifica si el usuario existe
            if (!ExisteUsuario(nombreusuario))
            {
                throw new Exception("El usuario no existe.");
            }

            string updateQuery = "UPDATE Usuario SET Telefono = @Telefono, Clave = @Clave, Correo = @Correo, Id_Rol = @IdRol, Estado = @Estado WHERE Nombre_Usuario = @NombreUsuario";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Telefono", phone);
                        command.Parameters.AddWithValue("@Clave", clave);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@IdRol", idRol);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@NombreUsuario", nombreusuario); // Usa el nombre del usuario como criterio de búsqueda

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
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
