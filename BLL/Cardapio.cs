using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cardapio
    {

        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();


        private int idcardapio;

        private int idcardap;

        private string status;

        private string desc;

        private string valor;

        private string nome;

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

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Idcardap
        {
            get
            {
                return idcardap;
            }

            set
            {
                idcardap = value;
            }
        }

        public int Idcardapio
        {
            get
            {
                return idcardapio;
            }

            set
            {
                idcardapio = value;
            }
        }

        public void ExcluircCardapio()
        {

            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE Cardapio SET status_cardap = 0 WHERE Id_Cardapio = '" + Idcardapio + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public void IncluirCardapio()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Cardapio  (nome,valor,descricao,status_cardap) values( '" + Nome + "'," + Valor + ",'"  + Desc + "','1')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataSet ListarCardapio(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_Cardapio,nome,valor,descricao,status_cardap  FROM Cardapio where status_cardap = 1 ";

            return c.RetornarDataSet(SQL);

        }




    }
    }

