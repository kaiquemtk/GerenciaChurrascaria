using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BLL
{
    public class Fechamento
    {

        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();

        private int idcomanda;


        private int idfechamento;

        private string statuscomanda;

        private string caixaRecebeu;

        private int numeroComanda;

        private int idFuncionario;

        private string troco1;

        private string statusFecha;

        private DateTime dataFechamento;

        private string troco;

        private string valoraPagar;

        private string valorRecebido;

        public DateTime DataFechamento
        {
            get
            {
                return dataFechamento;
            }

            set
            {
                dataFechamento = value;
            }
        }

        public string Troco
        {
            get
            {
                return troco;
            }

            set
            {
                troco = value;
            }
        }

        public string ValoraPagar
        {
            get
            {
                return valoraPagar;
            }

            set
            {
                valoraPagar = value;
            }
        }

        public string ValorRecebido
        {
            get
            {
                return valorRecebido;
            }

            set
            {
                valorRecebido = value;
            }
        }

        public string StatusFecha
        {
            get
            {
                return statusFecha;
            }

            set
            {
                statusFecha = value;
            }
        }

        public string Troco1
        {
            get
            {
                return troco1;
            }

            set
            {
                troco1 = value;
            }


        }

        public int IdFuncionario
        {
            get
            {
                return idFuncionario;
            }

            set
            {
                idFuncionario = value;
            }
        }

        public int NumeroComanda
        {
            get
            {
                return numeroComanda;
            }

            set
            {
                numeroComanda = value;
            }
        }

        

        public string Statuscomanda
        {
            get
            {
                return statuscomanda;
            }

            set
            {
                statuscomanda = value;
            }
        }

        public string CaixaRecebeu
        {
            get
            {
                return caixaRecebeu;
            }

            set
            {
                caixaRecebeu = value;
            }
        }

        public int Idfechamento
        {
            get
            {
                return idfechamento;
            }

            set
            {
                idfechamento = value;
            }
        }

        public int Idcomanda
        {
            get
            {
                return idcomanda;
            }

            set
            {
                idcomanda = value;
            }
        }

        public void RegistrarFechamento()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Fechamento (valor_total,valor_recebido,status_fechamento,Id_Funcionario,data_fechamento,TROCO,Restatnte) values ('" + ValoraPagar + "','" + ValorRecebido + "','1','" + IdFuncionario + "',SysDateTime(),'" + Troco + "','" + CaixaRecebeu + "')";
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
                SQL = "UPDATE Pedido_comanda SET status_comanda = 0 WHERE id_pedido_comanda = '" + Idcomanda + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void RegistrarComanda()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Comanda (status_comanda, horario_comanda) VALUES (1, CONVERT(TIME, GETDATE()))";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

    }

}
