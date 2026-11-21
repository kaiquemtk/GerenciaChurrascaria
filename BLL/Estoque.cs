using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Estoque
    {
        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();

        private string nome1;
        private int id_Cardapio;
        private int id_Estoque;
        private int idest;
        private int idEstoq;
        private int idforn;
        private int idprod;
        private string statusprod;
        private DateTime data;
        private int quantidade;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Statusprod
        {
            get { return statusprod; }
            set { statusprod = value; }
        }

        public int Idprod
        {
            get { return idprod; }
            set { idprod = value; }
        }

        public int Idforn
        {
            get { return idforn; }
            set { idforn = value; }
        }

        public int IdEstoq
        {
            get { return idEstoq; }
            set { idEstoq = value; }
        }

        public int Idest
        {
            get { return idest; }
            set { idest = value; }
        }

        public int Id_Estoque
        {
            get { return id_Estoque; }
            set { id_Estoque = value; }
        }

        public int Id_Cardapio
        {
            get { return id_Cardapio; }
            set { id_Cardapio = value; }
        }

        public string Nome1
        {
            get { return nome1; }
            set { nome1 = value; }
        }

        public void IncluirEstoque()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Estoque (quantidade,data,status_estoque,Id_Fornecedor,Nome) values(" + Quantidade + ",'" + Data.ToString("yyyyMMdd") + "',1," + Idforn + ",'" + (Nome1 ?? "").Replace("'", "''") + "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM Estoque WHERE Id_Estoque = " + Id_Estoque;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarEstoque(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_Estoque,quantidade,data,status_estoque,Id_Fornecedor,Nome FROM Estoque where status_estoque = 1 ";

            return c.RetornarDataSet(SQL);
        }

        public DataSet ListarEstoqueCompleto()
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT e.Id_Estoque, e.Nome, f.nome_fantasia AS fornecedor, e.quantidade, e.data " +
                  "FROM Estoque e LEFT JOIN Fornecedor f ON f.Id_Fornecedor = e.Id_Fornecedor " +
                  "WHERE e.status_estoque = 1";

            return c.RetornarDataSet(SQL);
        }

        public DataSet ListarFornecedores()
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_Fornecedor, nome_fantasia FROM Fornecedor WHERE status_fornec = 1 ORDER BY nome_fantasia";

            return c.RetornarDataSet(SQL);
        }

        public void Alterar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE Estoque SET quantidade = " + Quantidade + ", data = '" + Data.ToString("yyyyMMdd") + "', Id_Fornecedor = " + Idforn + ", Nome = '" + (Nome1 ?? "").Replace("'", "''") + "' WHERE Id_Estoque = " + Idest;

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluir()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE Estoque SET status_estoque = 0 WHERE Id_Estoque = '" + Idest + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}