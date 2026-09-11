using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

using System.Data;


namespace BLL
{
    public class PagarContas


    {
        private static string SQL;
        private int id;

        DAO.ConexaoString C = new DAO.ConexaoString();

        private string dataDoPagamento;



        private string pagamento;


        private int idcontaa;

        private int idconta;

        private string valor;



        private string data;




        private string statusconta;



        private string nome;

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
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

        public string Pagamento12
        {
            get
            {
                return pagamento;
            }

            set
            {
                pagamento = value;
            }
        }

        public string Statusconta
        {
            get
            {
                return statusconta;
            }

            set
            {
                statusconta = value;
            }
        }

        public int Idconta
        {
            get
            {
                return idconta;
            }

            set
            {
                idconta = value;
            }
        }

        public int Idcontaa
        {
            get
            {
                return idcontaa;
            }

            set
            {
                idcontaa = value;
            }
        }

        public string DataDoPagamento
        {
            get
            {
                return dataDoPagamento;
            }

            set
            {
                dataDoPagamento = value;
            }
        }

        public void IncluirConta()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO ContaPagar  (data_vencimento,nome_conta,valor,status_conta,data_pagamento) values( '" + Data + "','" + Nome + "','" + Valor + "','1','" + DataDoPagamento + "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void Alterar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();



                SQL = "UPDATE  ContaPagar SET data_vencimento = '" + Data + "',  nome_conta = '" + Nome + "', valor = '" + Valor + "', data_pagamento ='" + DataDoPagamento + "'    WHERE Id_ContaPagar = " + Idconta;

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public DataSet ListarContas(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT Id_ContaPagar,data_vencimento,nome_conta,valor,status_conta,data_pagamento  FROM ContaPagar where status_conta = 1 ";

            return c.RetornarDataSet(SQL);

        }



        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM ContaPagar WHERE Id_ContaPagar = " + Idconta;
                return c.RetornarDataReader(SQL);
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
                SQL = "UPDATE ContaPagar SET status_conta = 0 WHERE Id_ContaPagar = '" + Idconta + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

    }
}

