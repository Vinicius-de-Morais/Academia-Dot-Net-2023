using aula26;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula26
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Proficao { get; set; }

        public Pessoa(int id, string nome, string proficao)
        {
            Id = id;
            Nome = nome;
            Proficao = proficao;
        }

        public Pessoa()
        {
        }

        public bool insertOnDb()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.openSqlConnection();
            SqlTransaction sqlTransaction = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = sqlTransaction;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into pessoa values (@nome, @profissao) SELECT SCOPE_IDENTITY();";

            command.Parameters.Add("@nome", SqlDbType.VarChar, 256);
            command.Parameters.Add("@profissao", SqlDbType.VarChar, 256);

            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Proficao;

            try
            {
                this.Id = Convert.ToInt32(command.ExecuteScalar());
                sqlTransaction.Commit();
                return true;
            }catch(Exception e)
            {
                sqlTransaction.Rollback();
                throw new Exception("Erro na insercao: " + e.Message);
            }
            finally
            {
                banco.closeSqlConnection();
            }

        }

        public bool deleteOnDb()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.openSqlConnection();
            SqlTransaction sqlTransaction = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = sqlTransaction;
            command.CommandType = CommandType.Text;

            command.CommandText = "DELETE from pessoa WHERE id = (@id) ;";
            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = Id;

            try
            {
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                sqlTransaction.Rollback();
                throw new Exception("Erro na insercao: " + e.Message);
            }
            finally
            {
                banco.closeSqlConnection();
            }

        }

        public bool updateOnDb()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.openSqlConnection();
            SqlTransaction sqlTransaction = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = sqlTransaction;
            command.CommandType = CommandType.Text;

            command.CommandText = "update pessoa set nome = @nome, " +
                "  profissao = @profissao where id = @id";

            command.Parameters.Add("@nome", SqlDbType.VarChar, 256);
            command.Parameters.Add("@profissao", SqlDbType.VarChar, 256);
            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Proficao;
            command.Parameters[2].Value = Id;

            try
            {
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                sqlTransaction.Rollback();
                throw new Exception("Erro na insercao: " + e.Message);
            }
            finally
            {
                banco.closeSqlConnection();
            }
        }

        public static DataTable getAll()
        {
            Banco banco = new Banco();

            DataTable data = banco.executeGenericQuery("SELECT * FROM pessoa");
            return data;
        }

        public static List<Pessoa> getAllToList()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.openSqlConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM pessoa", cn);

            List<Pessoa> pessoas = new List<Pessoa>();
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pessoa pessoa = new Pessoa(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    pessoas.Add(pessoa);
                }

                return pessoas;
            }
            catch (Exception e)
            {
                throw new Exception("Erro no get all: " + e.Message);
            }
            finally
            {
                banco.closeSqlConnection();
            }
        }

        public override string? ToString()
        {
            return Id + " | " + Nome + " | " + Proficao;
        }
    }
}
