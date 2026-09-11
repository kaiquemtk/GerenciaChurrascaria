using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
        public class Web
    {

        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();

        private string _assunto;

        private int _idcontato;


        


        private string _mensagem;


        private string _email;


        private string _nome;

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Mensagem
        {
            get
            {
                return _mensagem;
            }

            set
            {
                _mensagem = value;
            }
        }

        public int Idcontato
        {
            get
            {
                return _idcontato;
            }

            set
            {
                _idcontato = value;
            }
        }

        public string Assunto
        {
            get
            {
                return _assunto;
            }

            set
            {
                _assunto = value;
            }
        }

        public DataSet ListarFale(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id,nome,email,assunto,mensagem FROM Contato  ";

            return c.RetornarDataSet(SQL);

        }


        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM Contato WHERE Id = " + Idcontato;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
