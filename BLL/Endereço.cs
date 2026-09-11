using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BLL
{
    public class Endereço
    {
        private static string SQL;
        DAO.ConexaoString C = new DAO.ConexaoString();



        private string logradouro;
        private string cidade;

        private string bairro;

        private string uF;

        private string cep;


        private int enderecoid;

        public int Enderecoid
        {
            get
            {
                return enderecoid;
            }

            set
            {
                enderecoid = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                logradouro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string UF
        {
            get
            {
                return uF;
            }

            set
            {
                uF = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public SqlDataReader Consultarendereço()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM endereco WHERE endereco_id = " + Enderecoid;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }


        public void AlterarEndereço()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();

                // Corrigido o nome da tabela para "CEP" e adicionado o WHERE para atualizar apenas o registro certo
                SQL = "UPDATE CEP SET Logradouro = '" + Logradouro + "', Cidade = '" + Cidade + "', Bairro = '" + Bairro + "', UF = '" + UF + "' WHERE CEP = '" + Cep + "'";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
