using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Pedido
    {


        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();

        private int idpedidocomanda;

        private string total;


        private string valor;




        private int idformade;


        private int idcardapio1;


        private int pedidocomanda;

        private DateTime horacomand;



        private int idformadepaga;

        private string idforma;


        private string descric;


        private int numerocomanda;

        private int idfuncionario;


        private int idcardapio;


        private int quantidade;

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

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public int Idfuncionario
        {
            get
            {
                return idfuncionario;
            }

            set
            {
                idfuncionario = value;
            }
        }

        public int Numerocomanda
        {
            get
            {
                return numerocomanda;
            }

            set
            {
                numerocomanda = value;
            }
        }

        public string Descric
        {
            get
            {
                return descric;
            }

            set
            {
                descric = value;
            }
        }

        public string Idforma
        {
            get
            {
                return idforma;
            }

            set
            {
                idforma = value;
            }
        }

        public int Idformadepaga
        {
            get
            {
                return idformadepaga;
            }

            set
            {
                idformadepaga = value;
            }
        }

        public DateTime Horacomand
        {
            get
            {
                return horacomand;
            }

            set
            {
                horacomand = value;
            }
        }

        public int Pedidocomanda
        {
            get
            {
                return pedidocomanda;
            }

            set
            {
                pedidocomanda = value;
            }
        }

        public int Idcardapio11
        {
            get
            {
                return idcardapio1;
            }

            set
            {
                idcardapio1 = value;
            }
        }

        public int Idformade
        {
            get
            {
                return idformade;
            }

            set
            {
                idformade = value;
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

        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public int Idpedidocomanda
        {
            get
            {
                return idpedidocomanda;
            }

            set
            {
                idpedidocomanda = value;
            }
        }

        public void IncluirCardapio()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Pedido_comanda(quantidade, Id_Cardapio, horario_comanda, Id_Funcionario, status_comanda, Id_Forma_Pagamento, Valor) VALUES (" + quantidade + ", " + Idcardapio + ", GETDATE(), " + Idfuncionario + ", 1, " + Idformade + ", " + Total.Replace(",", ".") + ")";
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
            SQL = "SELECT Id_Cardapio,nome,valor,descricao  FROM Cardapio ";

            return c.RetornarDataSet(SQL);

        }


        public void DeletarPedido()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "DELETE FROM Pedido_comanda WHERE id_pedido_comanda = " + Idpedidocomanda;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet ListarPedido(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT id_pedido_comanda,Quantidade,Valor  FROM Pedido_comanda where  status_comanda = 1 ";

            return c.RetornarDataSet(SQL);

        }

        public DataSet ListarDesativados(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT id_pedido_comanda,Quantidade,Id_Cardapio,Id_Funcionario,Id_Forma_Pagamento,Valor  FROM Pedido_comanda where  status_comanda = 0 ";

            return c.RetornarDataSet(SQL);

        }


        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM Cardapio WHERE Id_Cardapio = " + Idcardapio;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }
    }

}








    

