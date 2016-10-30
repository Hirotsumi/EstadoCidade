using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using br.ucb.Biblioteca.DTO;
using System.Configuration;

namespace br.ucb.Biblioteca.DAO
{
    internal class CidadeDAO
    {
        internal DataSet listarCidades(EstadoDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Casa"].ToString()))
            {
                try{
                    conn.Open();
                    var sql = "SELECT Id, DescCidade FROM Cidades WHERE IdEstado = @IdEstado";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@IdEstado", dto.idEstado);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dtSet = new DataSet();
                    adapter.Fill(dtSet);
                    return dtSet;
                }
                catch(Exception e)
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
