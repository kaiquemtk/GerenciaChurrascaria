using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Fornecedor
    {
        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();


        private string _Nome;

        private string _Endereço;

        private string _Cidade;

        private string _Contato;

        private string _Email;

        private int _Numero;

        private string _Complemento;

        private string _Bairro;

        private string _Cep;

        private string _UF;

        private string _CNPJ;

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Endereço
        {
            get
            {
                return _Endereço;
            }

            set
            {
                _Endereço = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _Cidade;
            }

            set
            {
                _Cidade = value;
            }
        }

       

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        

        public int Numero
        {
            get
            {
                return _Numero;
            }

            set
            {
                _Numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return _Complemento;
            }

            set
            {
                _Complemento = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _Bairro;
            }

            set
            {
                _Bairro = value;
            }
        }

       

        public string UF
        {
            get
            {
                return _UF;
            }

            set
            {
                _UF = value;
            }
        }

       

        public string Contato
        {
            get
            {
                return _Contato;
            }

            set
            {
                _Contato = value;
            }
        }

        public string Cep
        {
            get
            {
                return _Cep;
            }

            set
            {
                _Cep = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return _CNPJ;
            }

            set
            {
                _CNPJ = value;
            }
        }

        public void IncluirFUNC()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Fornecedor  (email,nome_fantasia,numero,cnpj,complemento,contato,cep) values( '"  + _Email + "','" + _Nome + "','" + _Numero + "','" + _CNPJ + "','" + _Complemento + "','" + _Contato + "','" + _Cep + "' )";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarFornecedor(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT email,nome_fantasia,numero,cnpj,complemento,contato,cep FROM Fornecedor ";
            
            return c.RetornarDataSet(SQL);

        }

    }




}



        

    

