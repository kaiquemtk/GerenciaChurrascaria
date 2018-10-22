using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cep
    {

        private static string SQL;

        

        DAO.ConexaoString C = new DAO.ConexaoString();


        private string _cep;
        
        private string _Logradouro;

        private string _Cidade;

        private string _Bairro;

        private string _UF;

        

        public string Logradouro
        {
            get
            {
                return _Logradouro;
            }

            set
            {
                _Logradouro = value;
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

        public string cep
        {
            get
            {
                return _cep;
            }

            set
            {
                _cep = value;
            }
        }

        public DataSet ListarFuncionario(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_Fornecedor,email,nome_fantasia,numero,cnpj,complemento,contato,cep FROM Fornecedor ";

            return c.RetornarDataSet(SQL);

        }




        public DataTable ConsultaMagrini()
        {
            DataTable dt = new DataTable(); ;
            SQL = "SELECT * FROM CEP WHERE CEP = " + _cep + " ";
            dt = C.RetornarDataTable(SQL);

            return dt;
        }


         
            DAO.ConexaoString c = new DAO.ConexaoString();
            
        

        }

}


