using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ProjetoWeb_001
{
    public class conectAluno
    {
        //Propriedade de dados do Aluno
        public int ID_Aluno { get; set; }
        public string Ra_Aluno { get; set; }
        public string Nome_Aluno { get; set; }
        public string Cpf_Aluno { get; set; }
        public string Sexo_Aluno { get; set; }
        public string Ingresso_Aluno { get; set; }

        public MySqlConnection connection;
        public string Erro;

        public conectAluno()
        {

        }

        public void configurarConexao()
        {
            string StringConexao = "SERVER=localhost;" +
                                   "DATABASE=ltp2_2017;" +
                                   "UID=root;" +
                                   "PASSWORD=";

            connection = new MySqlConnection(StringConexao);
        }

        public void abrirConexao()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
        }

        public void fecharConexao()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
        }

        public void InserirAluno()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "INSERT INTO Aluno (Ra_Aluno, Nome_Aluno, Cpf_Aluno, Sexo_Aluno, Ingresso_Aluno) VALUES(";
            query = query + "'" + Ra_Aluno + "',"
                          + "'" + Nome_Aluno + "',"
                          + "'" + Cpf_Aluno + "',"
                          + "'" + Sexo_Aluno + "',"
                          + "'" + Ingresso_Aluno + "')";

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

        public List<conectAluno> visualizarAlunos()
        {
            List<conectAluno> L = new List<conectAluno>();

            string query = "SELECT * FROM Aluno";

            try
            {
                abrirConexao();

                //Cria o comando associado à conexão
                MySqlCommand comando = new MySqlCommand(query, connection);

                //Cria e preenche com dados uma estrutura de reader com o retorno do select do sql
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        conectAluno Aluno = new conectAluno();
                        Aluno.ID_Aluno = Convert.ToInt32(dataReader["ID_Aluno"].ToString());
                        Aluno.Ra_Aluno = dataReader["Ra_Aluno"].ToString();
                        Aluno.Nome_Aluno = dataReader["Nome_Aluno"].ToString();
                        Aluno.Cpf_Aluno = dataReader["Cpf_Aluno"].ToString();
                        Aluno.Sexo_Aluno = dataReader["Sexo_Aluno"].ToString();
                        Aluno.Ingresso_Aluno = dataReader["Ingresso_Aluno"].ToString();

                        L.Add(Aluno);
                    }
                }
                else
                {
                    throw new Exception("Não trouxe resultados.");
                }

                //fechando a estrutura dataReader
                dataReader.Close();

                fecharConexao();

            }
            catch (MySqlException ex)
            {
                Erro = "Erro ao buscar usuarios: " + ex.Message;
                L = null;
            }

            return L;
        }

        public conectAluno retornarItem(int id)
        {

            string query = "SELECT * FROM Aluno WHERE ID_Aluno = " + id;
            conectAluno C = new conectAluno();

            try
            {
                abrirConexao();

                //Cria o comando associado à conexão
                MySqlCommand comando = new MySqlCommand(query, connection);

                //Cria e preenche com dados uma estrutura de reader com o retorno do select do sql
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        C.ID_Aluno = Convert.ToInt32(dataReader["ID_Aluno"].ToString());
                        C.Ra_Aluno = dataReader["Ra_Aluno"].ToString();
                        C.Nome_Aluno = dataReader["Nome_Aluno"].ToString();
                        C.Cpf_Aluno = dataReader["Cpf_Aluno"].ToString();
                        C.Sexo_Aluno = dataReader["Sexo_Aluno"].ToString();
                        C.Ingresso_Aluno = dataReader["Ingresso_Aluno"].ToString();
                    }
                }
                else
                {
                    throw new Exception("Não trouxe resultados.");
                }

                //fechando a estrutura dataReader
                dataReader.Close();

                fecharConexao();

            }
            catch (MySqlException ex)
            {
                Erro = "Erro ao buscar usuarios: " + ex.Message;
                C = null;
            }

            return C;
        }

        public void alterarItem()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "UPDATE Aluno SET ";
            query = query + "Ra_Aluno='" + Ra_Aluno + "',"
                          + "Nome_Aluno='" + Nome_Aluno + "',"
                          + "Cpf_Aluno='" + Cpf_Aluno + "',"
                          + "Sexo_Aluno='" + Sexo_Aluno + "',"
                          + "Ingresso_Aluno='" + Ingresso_Aluno + "' "
                          + "WHERE ID_Aluno=" + ID_Aluno;

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }
        public void excluirItem()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "DELETE FROM aluno "
                          + "WHERE ID_Aluno=" + ID_Aluno;

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }
    }
}