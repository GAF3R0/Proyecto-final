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
        /*
         * select d.folio,d.Prod_Id,p.Prod_Nombre,d.Precio_Produnitario,d.CantidadProd,d.Precio_Prodxcant,d.TotalVenta 
         * from Detalle_Venta d 
         * inner join Productos p on p.Prod_Id = d.Prod_Id;
         */
        public List<DETALLEVENTA> Listar()
        {
            List<DETALLEVENTA> lista = new List<DETALLEVENTA>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT d.folio, d.Prod_Id, p.Prod_Nombre,");
                    query.AppendLine("d.Precio_Produnitario, d.CantidadProd,");
                    query.AppendLine("d.Precio_Prodxcant, d.TotalVenta,d.Fecha_Creacion");
                    query.AppendLine("FROM Detalle_Venta d");
                    query.AppendLine("INNER JOIN Productos p ON p.Prod_Id = d.Prod_Id");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DETALLEVENTA()
                            {
                                folio = Convert.ToInt64(dr["folio"]),
                                oproducto = new PRODUCTO
                                {
                                    Prod_Id = Convert.ToInt64(dr["Prod_Id"]),
                                    Prod_Nombre = dr["Prod_Nombre"].ToString()
                                },
                                Cantidad = Convert.ToInt32(dr["CantidadProd"]),
                                Precio_Produnitario = Convert.ToDecimal(dr["Precio_Produnitario"]),
                                Precio_Prodxcant = Convert.ToDecimal(dr["Precio_Prodxcant"]),
                                TotalVenta = Convert.ToDecimal(dr["TotalVenta"]),
                                FechaRegistro = dr["Fecha_Creacion"] != DBNull.Value
                                                ? Convert.ToDateTime(dr["Fecha_Creacion"]).ToString("yyyy-MM-dd")
                                                : null
                            }) ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los detalles de venta: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }



        public void InsertarDetalleVenta(long folio, long prodId, decimal precioUnitario, int cantidad, decimal precioTotal, decimal totalVenta)
        {
            string insertQuery = @"
        INSERT INTO Detalle_Venta
        (folio, Prod_Id, Precio_Produnitario, CantidadProd, Precio_Prodxcant, TotalVenta, Fecha_Creacion) 
        VALUES 
        (@folio, @prodId, @precioUnitario, @cantidad, @precioTotal, @totalVenta, NOW())";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Asignar parámetros
                        command.Parameters.AddWithValue("@folio", folio);
                        command.Parameters.AddWithValue("@prodId", prodId);
                        command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precioTotal", precioTotal);
                        command.Parameters.AddWithValue("@totalVenta", totalVenta);

                        // Ejecutar consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ingresar el detalle de venta: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
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
