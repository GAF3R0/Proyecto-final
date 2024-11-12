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
    public class CD_ROL
    {
        public List<ROL> Listar()
        {
            List<ROL> lista = new List<ROL>();

            using (MySqlConnection oconexion = new MySqlConnection(ConexionBD.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Id_Rol, Descripcion from Rol");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ROL()
                            {
                                Id_Rol = Convert.ToInt32(dr["Id_Rol"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los roles: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }
    }
}
