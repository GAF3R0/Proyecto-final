using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidades;
using QRCoder;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace CapaDatos
{
    public class CD_CLIENTE
    {
        String conectadobb = ConexionBD.cadena;
        public List<CLIENTE> Listar()
        {
            List<CLIENTE> lista = new List<CLIENTE>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {

                    /*
                     SELECT e.est_descricion,c.Cli_Nombre,c.Cli_Telefono,c.Cli_Telefono_Emer,c.Cli_Correo,c.Cli_Domicilio,c.Cli_Colonia,
                            c.Est_id,c.Fecha_Creacion,c.Fecha_termina
                            FROM Estatus e
                            INNER JOIN cliente c ON c.Est_id =  e.Est_id;
                     */
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT e.est_descricion,c.Cli_Id,c.Cli_Nombre,c.Cli_Edad,c.Cli_Telefono,c.Cli_Telefono_Emer,c.Cli_Correo,c.Cli_Domicilio,c.Cli_Colonia,");
                    query.AppendLine(" c.Est_id,c.Fecha_Creacion,c.Fecha_termina FROM cliente c  INNER JOIN Estatus e  ON c.Est_id =  e.Est_id;");


                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CLIENTE()
                            {
                                Cli_Id = Convert.ToInt32(dr["Cli_Id"]),
                                Cli_Nombre = dr["Cli_Nombre"].ToString(),
                                Cli_Edad = Convert.ToInt32(dr["Cli_Edad"]),
                                Cli_Telefono = dr["Cli_Telefono"].ToString(),
                                Cli_Telefono_Emer = dr["Cli_Telefono_Emer"].ToString(),
                                Cli_Correo = dr["Cli_Correo"].ToString(),
                                Cli_Domicilio = dr["Cli_Domicilio"].ToString(),
                                Cli_Colonia = dr["Cli_Colonia"].ToString(),
                                oestatus = new ESTATUS()
                                {
                                    est_id = Convert.ToInt32(dr["est_id"]),
                                    Est_descricion = dr["Est_descricion"].ToString()
                                },
                                Fecha_Creacion = (DateTime)dr["Fecha_Creacion"],
                                Fecha_termina = (DateTime)dr["Fecha_termina"]

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los clientes: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }

        public void ingresar_cliente(string Cli_Nombre, int edad, string telefono, string telefono911, string correo, string domicilio, string colonia, int estadoId)
        {
            string insertQuery = "INSERT INTO Cliente (Cli_Nombre, Cli_Edad, Cli_Telefono, Cli_Telefono_Emer, Cli_Correo, Cli_Domicilio, Cli_Colonia, Est_id, Fecha_Creacion, Fecha_termina) " +
                                 "VALUES (@Cli_Nombre, @Edad, @Telefono, @Telefono911, @Correo, @Domicilio, @Colonia, @EstadoId, NOW(), DATE_ADD(NOW(), INTERVAL 1 MONTH))";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Cli_Nombre", Cli_Nombre);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Telefono911", telefono911);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@Colonia", colonia);
                        command.Parameters.AddWithValue("@EstadoId", estadoId);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ingresar el cliente: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
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

        public bool clienteexiste(string Cli_Nombre)
        {
                string query = "SELECT COUNT(*) FROM Cliente WHERE Cli_Nombre = @Cli_Nombre";
                using (MySqlConnection connection = new MySqlConnection(conectadobb))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Cli_Nombre", Cli_Nombre);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al verificar la existencia del usuario: " + ex.Message, ex);
                    }
                }
        }

        public void actualizarPorNombreCliente(string Cli_Nombre, int edad, string telefono, string telefono911, string correo, string domicilio, string colonia, int estadoId)
        {
            // Verifica si el cliente existe
            if (!clienteexiste(Cli_Nombre))
            {
                throw new Exception("El cliente no existe.");
            }

            string updateQuery = "UPDATE Cliente SET Cli_Edad=@edad, Cli_Telefono = @Telefono, Cli_Telefono_Emer = @TelefonoEmergencia, Cli_Correo = @Correo, Cli_Domicilio = @Domicilio, Cli_Colonia = @Colonia, Est_id = @IdEstatus, Fecha_Creacion = @FechaCreacion, Fecha_termina = @FechaTermina WHERE Cli_Nombre = @Cli_Nombre";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@edad", edad);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@TelefonoEmergencia", telefono911);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@Colonia", colonia);
                        command.Parameters.AddWithValue("@IdEstatus", estadoId);
                        command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                        command.Parameters.AddWithValue("@FechaTermina", DateTime.Now.AddMonths(1));
                        command.Parameters.AddWithValue("@Cli_Nombre", Cli_Nombre); // Usa el nombre del cliente como criterio de búsqueda

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el cliente: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
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

        public void eliminar(string Cli_Nombre)
        {
            string deleteQuery = "DELETE FROM Cliente WHERE Cli_Nombre = @Cli_Nombre";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Cli_Nombre", Cli_Nombre);

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

        public List<CLIENTE> Listar_miembros()
        {
            List<CLIENTE> listamiembros = new List<CLIENTE>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {

                    /*
                    SELECT c.Cli_Id, c.Cli_Nombre, e.Est_descricion, c.Cli_Edad, c.Cli_Telefono, c.Cli_Telefono_Emer, 
                    c.Cli_Correo, c.Cli_Domicilio, c.Cli_Colonia, c.Est_id, c.Fecha_Creacion, c.Fecha_termina
                    FROM cliente c
                    INNER JOIN Estatus e ON e.Est_id = c.Est_id where e.Est_descricion = "miembro";
                    */
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(" SELECT c.Cli_Id, c.Cli_Nombre, e.Est_descricion, c.Cli_Edad, c.Cli_Telefono, c.Cli_Telefono_Emer,c.Cli_Correo,");
                    query.AppendLine(" c.Cli_Domicilio, c.Cli_Colonia, c.Est_id, c.Fecha_Creacion, c.Fecha_termina FROM cliente c INNER JOIN Estatus e ON e.Est_id = c.Est_id where e.Est_descricion = 'miembro' ");


                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listamiembros.Add(new CLIENTE()
                            {
                                Cli_Id = Convert.ToInt32(dr["Cli_Id"]),
                                Cli_Nombre = dr["Cli_Nombre"].ToString(),
                                Cli_Edad = Convert.ToInt32(dr["Cli_Edad"]),
                                Cli_Telefono = dr["Cli_Telefono"].ToString(),
                                Cli_Telefono_Emer = dr["Cli_Telefono_Emer"].ToString(),
                                Cli_Correo = dr["Cli_Correo"].ToString(),
                                Cli_Domicilio = dr["Cli_Domicilio"].ToString(),
                                Cli_Colonia = dr["Cli_Colonia"].ToString(),
                                oestatus = new ESTATUS()
                                {
                                    est_id = Convert.ToInt32(dr["est_id"]),
                                    Est_descricion = dr["Est_descricion"].ToString()
                                },
                                Fecha_Creacion = (DateTime)dr["Fecha_Creacion"],
                                Fecha_termina = (DateTime)dr["Fecha_termina"]

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los clientes: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return listamiembros;
        }

        public CLIENTE ObtenerInformacionMiembro(int idMiembro)
        {
            CLIENTE miembro = null;
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(" SELECT c.Cli_Id, c.Cli_Nombre, c.Cli_Telefono, c.Cli_Telefono_Emer,");
                    query.AppendLine(" c.Fecha_Creacion, c.Fecha_termina");
                    query.AppendLine(" FROM cliente c");
                    query.AppendLine(" WHERE c.Cli_Id = @idMiembro");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idMiembro", idMiembro);

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Parseamos los datos obtenidos
                            DateTime fechaTermina = Convert.ToDateTime(dr["Fecha_termina"]);
                            DateTime fechaActual = DateTime.Now;

                            // Calculamos el estatus de la membresía
                            string estatusMembresia = fechaTermina < fechaActual
                                ? "Membresía inactiva"
                                : "Membresía activa";

                            miembro = new CLIENTE()
                            {
                                Cli_Id = Convert.ToInt32(dr["Cli_Id"]),
                                Cli_Nombre = dr["Cli_Nombre"].ToString(),
                                Cli_Telefono = dr["Cli_Telefono"].ToString(),
                                Cli_Telefono_Emer = dr["Cli_Telefono_Emer"].ToString(),
                                Fecha_Creacion = (DateTime)dr["Fecha_Creacion"],
                                Fecha_termina = (DateTime)dr["Fecha_termina"],
                                oestatus = new ESTATUS()
                                {
                                    Est_descricion = estatusMembresia
                                }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la información del miembro: " + ex.Message, ex);
                }
            }
            return miembro;
        }




        public List<CLIENTE> Listar_visistas()
        {
            List<CLIENTE> listavisita = new List<CLIENTE>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {

                    /*
                    SELECT c.Cli_Id, c.Cli_Nombre, e.Est_descricion, c.Cli_Edad, c.Cli_Telefono, c.Cli_Telefono_Emer, 
                    c.Cli_Correo, c.Cli_Domicilio, c.Cli_Colonia, c.Est_id, c.Fecha_Creacion, c.Fecha_termina
                    FROM cliente c
                    INNER JOIN Estatus e ON e.Est_id = c.Est_id where e.Est_descricion = "miembro";
                    */
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(" SELECT c.Cli_Id, c.Cli_Nombre, e.Est_descricion, c.Cli_Edad, c.Cli_Telefono, c.Cli_Telefono_Emer,c.Cli_Correo,");
                    query.AppendLine(" c.Cli_Domicilio, c.Cli_Colonia, c.Est_id, c.Fecha_Creacion, c.Fecha_termina FROM cliente c INNER JOIN Estatus e ON e.Est_id = c.Est_id where e.Est_descricion = 'Visitante' ");


                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listavisita.Add(new CLIENTE()
                            {
                                Cli_Id = Convert.ToInt32(dr["Cli_Id"]),
                                Cli_Nombre = dr["Cli_Nombre"].ToString(),
                                Cli_Edad = Convert.ToInt32(dr["Cli_Edad"]),
                                Cli_Telefono = dr["Cli_Telefono"].ToString(),
                                Cli_Telefono_Emer = dr["Cli_Telefono_Emer"].ToString(),
                                Cli_Correo = dr["Cli_Correo"].ToString(),
                                Cli_Domicilio = dr["Cli_Domicilio"].ToString(),
                                Cli_Colonia = dr["Cli_Colonia"].ToString(),
                                oestatus = new ESTATUS()
                                {
                                    est_id = Convert.ToInt32(dr["est_id"]),
                                    Est_descricion = dr["Est_descricion"].ToString()
                                },
                                Fecha_Creacion = (DateTime)dr["Fecha_Creacion"],
                                Fecha_termina = (DateTime)dr["Fecha_termina"]

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los clientes: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return listavisita;
        }

        public void Renovar(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conectadobb))
                {
                    conn.Open();
                    string query = " UPDATE Cliente SET Fecha_Creacion = @FechaCreacion, Fecha_termina = @FechaTermina WHERE Cli_Id = @Cli_Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cli_Id", id);
                        cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@FechaTermina", DateTime.Now.AddMonths(1));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al renovar la membresía: " + ex.Message);
            }
        }

        public void generaqr(int id)
        {
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.Cli_Id ");
                    query.AppendLine("FROM cliente c ");
                    query.AppendLine("WHERE c.Cli_Id = @CliId");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.Parameters.AddWithValue("@CliId", id);

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int clienteId = Convert.ToInt32(dr["Cli_Id"]);
                            string qrData = clienteId.ToString();

                            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                            {
                                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                                using (QRCode qrCode = new QRCode(qrCodeData))
                                {
                                    Bitmap qrCodeImage = qrCode.GetGraphic(20);

                                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                                    saveFileDialog.Filter = "PNG Image|*.png";
                                    saveFileDialog.Title = "Guardar Código QR";
                                    saveFileDialog.FileName = $"ID_{clienteId}_QRCode.png";
                                    saveFileDialog.InitialDirectory = @"C:\Users\SALINITAS\Pictures\QR Gym";

                                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        qrCodeImage.Save(saveFileDialog.FileName);
                                        MessageBox.Show("Código QR guardado exitosamente.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al generar el código QR: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
        }
    }
}





