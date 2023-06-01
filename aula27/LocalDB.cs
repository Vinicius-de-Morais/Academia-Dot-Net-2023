using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula27
{
    internal class LocalDB
    {
        private string stringConexao = "Data Source=localhost;" +
            "Initial Catalog=Academia_Atos; User ID=TESTEUSER;" +
            "password=.Senha12345678;language=Portuguese";

        private SqlConnection connection;

        private void newConnection()
        {
            connection = new SqlConnection(stringConexao);
        }

        public SqlConnection openSqlConnection()
        {
            try
            {
                newConnection();
                connection.Open();

                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closeSqlConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable executeGenericQuery(string sql)
        {
            try
            {
                openSqlConnection();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeSqlConnection();
            }
        }
    }
}
