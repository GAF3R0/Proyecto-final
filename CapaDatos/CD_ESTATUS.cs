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
    public class CD_ESTATUS
    {
        public List<ESTATUS> Listar()
        {
            List<ESTATUS> lista = new List<ESTATUS>();

            using (MySqlConnection oconexion = new MySqlConnection(ConexionBD.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select est_id , Est_descricion from Estatus");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ESTATUS()
                            {
                                est_id = Convert.ToInt32(dr["est_id"]),
                                Est_descricion = dr["Est_descricion"].ToString()
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

