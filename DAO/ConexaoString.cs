using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
public class ConexaoString
    {
        private static SqlConnection cn;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static SqlDataReader dr;
        private static SqlParameter p;
        private static DataSet ds;
        private static String SQL; //instrucao SQL
        private static DataTable dt;
        //criar a string de conexao com o banco de dados
        // private static string Caminho = @"Data Source=LOCALHOST;User Id=GANACHEE;Password=280386;";
        private static string Caminho = @"Server=DANILO-PC\SQLEXPRESS; Database = CHURRASCARIA ;User Id=churras; Password=123456;";
        //private static string Caminho = @"Data source=Localhost; Database=Ganachee ;User Id=GANACHEE1;Password=280386;";
        //veja no site https://www.connectionstrings.com
        
        public SqlConnection Conectar()
        {
            try
            {
                cn = new SqlConnection(Caminho);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Fechar(SqlConnection conexao)
        {
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public int ExecutarComandoRetorno(string sqlComando)
        {
            //UTILIZAR SEQUENCIA NO ORACLE
            //NO LUGAR DESTE METODO
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity"; //select table_seq.currval
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public SqlDataReader RetornarDataReader(string Comando)
        {
            try
            {
                 SqlDataReader dr;


                SqlCommand cmd = new SqlCommand(Comando, Conectar());
                dr = cmd.ExecuteReader();

                return dr;
                //return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






        public DataTable RetornarDataTable(string Comando)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(Comando, Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public DataSet RetornarDataSet(string Comando)
        {
            try
            {
                DataSet ds = new DataSet();

                SqlCommand cmd = new SqlCommand(Comando, Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CreateOracleCommand()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Emp ORDER BY EmpNo";
            command.CommandType = CommandType.Text;
        }






        public void ExecutarComando(string Comando)
        {
            try
            {
                //OleDbCommand cmd = new OleDbCommand(Comando, Conectar());
                cmd = new SqlCommand(Comando, Conectar());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public static SqlConnection abrirBanco()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Caminho);
                conexao.Open();
                return conexao;
            }
            catch (SqlException exAce)
            {
                throw exAce;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharBanco(SqlConnection conexao)
        {
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (SqlException exAce)
            {
                throw exAce;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataSet retornarDataSet(string sqlComando)
        {
            SqlConnection conexao;
            conexao = abrirBanco();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmdComando = new SqlCommand(sqlComando, conexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdComando);

                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandType = CommandType.Text;

                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharBanco(conexao);
            }
        }

        public int executarComandoRetorno(string sqlComando)
        {
            SqlConnection conexao;
            conexao = abrirBanco();
            try
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static string Conexao()
        {
            string info = "";
            try
            {

                string oledb = Caminho;
                cn = new SqlConnection(oledb);

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    //cn.BeginTransaction();
                    info = "Conectado com a Versão Access " + cn.ServerVersion + " Utilizando a fonte " + cn.DataSource;
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return info + " Estado da Conexao " + cn.State.ToString() + " OK";
        }
    }
}
    
    

