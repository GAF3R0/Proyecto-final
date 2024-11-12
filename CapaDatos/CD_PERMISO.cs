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
    public class CD_PERMISO
    {
        public List<PERMISO> Listar(int id_usuario)
        {
            List<PERMISO> lista = new List<PERMISO>();

            using (MySqlConnection oconexion = new MySqlConnection(ConexionBD.cadena))
            {
                try
                {
                    Console.WriteLine($"ID de usuario recibido: {id_usuario}");

                    // Construir la consulta
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.Rol_Id_Rol, p.NombreMenu FROM Permisos p");
                    query.AppendLine("INNER JOIN Rol r ON r.Id_Rol = p.Rol_Id_Rol");
                    query.AppendLine("INNER JOIN usuario u ON u.Id_Rol = r.Id_Rol");
                    query.AppendLine("WHERE u.Id_Usuario = @id_usuario");

                    // Mostrar la consulta generada para depuración
                    Console.WriteLine("Consulta SQL: " + query.ToString());

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;

                    // Abrir la conexión
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine("Ejecutando consulta...");

                        if (!dr.HasRows)
                        {
                            Console.WriteLine("No se encontraron registros.");
                        }

                        // Leer los datos
                        while (dr.Read())
                        {
                            int idRol = dr.IsDBNull(dr.GetOrdinal("Rol_Id_Rol")) ? 0 : Convert.ToInt32(dr["Rol_Id_Rol"]);
                            string nombreMenu = dr.IsDBNull(dr.GetOrdinal("NombreMenu")) ? null : dr["NombreMenu"].ToString();

                            // Verificar si las columnas existen y tienen datos
                            Console.WriteLine($"id_rol: {idRol}, NombreMenu: {nombreMenu}");

                            lista.Add(new PERMISO()
                            {
                                oROL = new ROL() { Id_Rol = idRol },
                                Nombremenu = nombreMenu
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw new Exception("Error al listar los Permisos: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }

    }
}

