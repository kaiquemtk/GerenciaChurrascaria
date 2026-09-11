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

        private int idfornecedor1;

        private int idfornec;

        private int idforncedor;

        private string endereco_id;

        private string contato1;

        private string complemento1;

        private string cnpj;

        private int numero1;

        private string email1;

        private string cep1;

        private string cEP1;

        private string uF1;

        private string bairro1;

        private string cidade1;

        private string logradouro;

        private int id_Fornecedor;

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
        private int endereçoid;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Endereço
        {
            get { return _Endereço; }
            set { _Endereço = value; }
        }

        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public string Complemento
        {
            get { return _Complemento; }
            set { _Complemento = value; }
        }

        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }

        public string UF
        {
            get { return _UF; }
            set { _UF = value; }
        }

        public string Contato
        {
            get { return _Contato; }
            set { _Contato = value; }
        }

        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }

        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

        public int idFornecedor
        {
            get { return id_Fornecedor; }
            set { id_Fornecedor = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Cidade1
        {
            get { return cidade1; }
            set { cidade1 = value; }
        }

        public string Bairro1
        {
            get { return bairro1; }
            set { bairro1 = value; }
        }

        public string UF1
        {
            get { return uF1; }
            set { uF1 = value; }
        }

        public string CEP1
        {
            get { return cEP1; }
            set { cEP1 = value; }
        }

        public int Endereçoid
        {
            get { return endereçoid; }
            set { endereçoid = value; }
        }

        public string Cep1
        {
            get { return cep1; }
            set { cep1 = value; }
        }

        public string Email1
        {
            get { return email1; }
            set { email1 = value; }
        }

        public int Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Complemento1
        {
            get { return complemento1; }
            set { complemento1 = value; }
        }

        public string Contato1
        {
            get { return contato1; }
            set { contato1 = value; }
        }

        public string Endereco_id
        {
            get { return endereco_id; }
            set { endereco_id = value; }
        }

        public int Idforncedor
        {
            get { return idforncedor; }
            set { idforncedor = value; }
        }

        public int Idfornec
        {
            get { return idfornec; }
            set { idfornec = value; }
        }

        public int Idfornecedor1
        {
            get { return idfornecedor1; }
            set { idfornecedor1 = value; }
        }

        public void IncluirFUNC()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Fornecedor (email, status_fornec, nome_fantasia, numero, cnpj, complemento, contato, cep) " +
                      "VALUES ('" + _Email + "', 1, '" + _Nome + "', '" + _Numero + "', '" + _CNPJ + "', '" + _Complemento + "', '" + _Contato + "', '" + _Cep + "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataSet ListarFornecedor(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_Fornecedor,email,nome_fantasia,numero,cnpj,complemento,contato,cep FROM Fornecedor where status_fornec = 1  ";

            return c.RetornarDataSet(SQL);
        }

        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM Fornecedor WHERE Id_Fornecedor = " + Idfornec;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Alterar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE Fornecedor SET email = '" + Email + "', nome_fantasia = '" + Nome + "', numero = '" + Numero + "', cnpj = '" + CNPJ + "', complemento = '" + Complemento + "', contato = '" + Contato + "', cep = '" + Cep + "' WHERE Id_Fornecedor = " + Idfornec;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void excluir()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE Fornecedor SET status_fornec = 0 WHERE Id_Fornecedor = '" + Idfornecedor1 + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}