using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Produto
    {

        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();

        private int idprod;


        private int idforncedor;


        private int quantidade1;

        private DateTime datacadast;




        private string descri;


        private string nome;



        private string statusprod;

        private int idprodu;

        public int Idprodu
        {
            get
            {
                return idprodu;
            }

            set
            {
                idprodu = value;
            }
        }

        public string Statusprod
        {
            get
            {
                return statusprod;
            }

            set
            {
                statusprod = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Descri
        {
            get
            {
                return descri;
            }

            set
            {
                descri = value;
            }
        }

        public DateTime Datacadast
        {
            get
            {
                return datacadast;
            }

            set
            {
                datacadast = value;
            }
        }

        public int Quantidade1
        {
            get
            {
                return quantidade1;
            }

            set
            {
                quantidade1 = value;
            }
        }

        public int Idforncedor
        {
            get
            {
                return idforncedor;
            }

            set
            {
                idforncedor = value;
            }
        }

        public int Idprod
        {
            get
            {
                return idprod;
            }

            set
            {
                idprod = value;
            }
        }

        public void IncluirProduto()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Produto  (status_produto,nome,descriçao,data_cadastro,qtde_estoque_minimo) values('1','"+ Nome  + "','" + Descri  + "','" + Datacadast + "','" + Quantidade1 + "')";
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
                SQL = "SELECT * FROM Produto WHERE Id_Produto = " + Idprodu ;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public DataSet ListarProduto(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_Produto,nome,descriçao,data_cadastro,qtde_estoque_minimo FROM Produto where status_produto = 1 ";

            return c.RetornarDataSet(SQL);

        }




        public void Alterar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();



                SQL = "UPDATE  Produto SET nome = '" + Nome + "',  descriçao = '" + Descri + "', data_cadastro = '" + Datacadast + "', qtde_estoque_minimo ='" + Quantidade1 +  "'  WHERE Id_Produto = " + Idprodu;

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
                SQL = "UPDATE Produto SET status_produto = 0 WHERE Id_Produto = '" + Idprodu + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

    }
}


  