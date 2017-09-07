using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ProjetoWeb_001
{
    public class ConectDisciplina
    {
        //Propriedade de dados do Disciplina
        public int ID_Disciplina { get; set; }
        public string Codigo_Disciplina { get; set; }
        public string Nome_Disciplina { get; set; }
        public string Ementa_Disciplina { get; set; }
        public string Semestre_Disciplina { get; set; }
        public string Carga_Horaria { get; set; }

        public MySqlConnection connection;
        public string Erro;

        public ConectDisciplina()
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

        public void InserirDisciplina()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "INSERT INTO Disciplina (Codigo_Disciplina, Nome_Disciplina, Ementa_Disciplina, Semestre_Disciplina, Carga_Horaria) VALUES(";
            query = query + "'" + Codigo_Disciplina + "',"
                          + "'" + Nome_Disciplina + "',"
                          + "'" + Ementa_Disciplina + "',"
                          + "'" + Semestre_Disciplina + "',"
                          + "'" + Carga_Horaria + "')";

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

        public List<ConectDisciplina> VisualizarDisciplinas()
        {
            List<ConectDisciplina> L = new List<ConectDisciplina>();

            string query = "SELECT * FROM Disciplina";

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
                        ConectDisciplina Disciplina = new ConectDisciplina();
                        Disciplina.ID_Disciplina = Convert.ToInt32(dataReader["ID_Disciplina"].ToString());
                        Disciplina.Codigo_Disciplina = dataReader["Codigo_Disciplina"].ToString();
                        Disciplina.Nome_Disciplina = dataReader["Nome_Disciplina"].ToString();
                        Disciplina.Ementa_Disciplina = dataReader["Ementa_Disciplina"].ToString();
                        Disciplina.Semestre_Disciplina = dataReader["Semestre_Disciplina"].ToString();
                        Disciplina.Carga_Horaria = dataReader["Carga_Horaria"].ToString();

                        L.Add(Disciplina);
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

        public ConectDisciplina retornarItem(int id)
        {

            string query = "SELECT * FROM Disciplina WHERE ID_Disciplina = " + id;
            ConectDisciplina C = new ConectDisciplina();

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
                        C.ID_Disciplina = Convert.ToInt32(dataReader["ID_Disciplina"].ToString());
                        C.Codigo_Disciplina = dataReader["Codigo_Disciplina"].ToString();
                        C.Nome_Disciplina = dataReader["Nome_Disciplina"].ToString();
                        C.Ementa_Disciplina = dataReader["Ementa_Disciplina"].ToString();
                        C.Semestre_Disciplina = dataReader["Semestre_Disciplina"].ToString();
                        C.Carga_Horaria = dataReader["Carga_Horaria"].ToString();
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
            string query = "UPDATE Disciplina SET ";
            query = query + "Codigo_Disciplina='" + Codigo_Disciplina + "',"
                          + "Nome_Disciplina='" + Nome_Disciplina + "',"
                          + "Ementa_Disciplina='" + Ementa_Disciplina + "',"
                          + "Semestre_Disciplina='" + Semestre_Disciplina + "',"
                          + "Carga_Horaria='" + Carga_Horaria + "' "
                          + "WHERE ID_Disciplina=" + ID_Disciplina;

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
            string query = "DELETE FROM disciplina "
                          + "WHERE ID_Disciplina=" + ID_Disciplina;

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

    }
}