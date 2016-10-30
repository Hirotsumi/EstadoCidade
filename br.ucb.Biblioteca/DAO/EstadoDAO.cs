using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace br.ucb.Biblioteca.DAO
{
    internal class EstadoDAO
    {
        internal DataSet listarEstados()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Casa"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT IdEstado, DescEstado FROM Estados ORDER BY DescEstado";
                    SqlCommand command = new SqlCommand(sql,conn);
                    command.CommandType = CommandType.Text;
                    DataSet dtSet = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtSet);
                    return dtSet;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
