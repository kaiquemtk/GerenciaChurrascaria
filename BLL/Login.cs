using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BLL
{
   public class Login
    {
        private static string SQL;
        private static SqlDataReader dr;
        DAO.ConexaoString df = new DAO.ConexaoString();

        private int _IdLogin;
        private string _Nome;
        private int _IdNivelAcesso;
        private string _Senha;
        private DateTime _DataCriacaoSenha;
        private DateTime _DataExpiracaoSenha;
        private DateTime _DataUltimoAcesso;
        private int _SenhaAtiva;
        private int _DiasUltimoAcesso;
        private string _TipoUsuario;
        private int _PerguntaSecretaId;
        private int _StatusLoginID;

        public int StatusLoginID
        {
            get { return _StatusLoginID; }
            set { _StatusLoginID = value; }
        }

        public int PerguntaSecretaId
        {
            get { return _PerguntaSecretaId; }
            set { _PerguntaSecretaId = value; }
        }
        private string _RespostaPerguntaSecreta;

        private int idfuncionario;


        DAO.ConexaoString C = new DAO.ConexaoString();

        // private DateTime DataVenda;


        public string RespostaPerguntaSecreta
        {
            get
            {
                return _RespostaPerguntaSecreta;
            }
            set
            {
                _RespostaPerguntaSecreta = value.ToUpper();
            }
        }


        public string TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }
            set
            {
                _TipoUsuario = value.ToUpper();
            }
        }



        public int DiasUltimoAcesso
        {
            get
            {
                return _DiasUltimoAcesso;
            }
            set
            {
                _DiasUltimoAcesso = value;
            }
        }


        public int IdLogin
        {
            get
            {
                return _IdLogin;
            }
            set
            {
                _IdLogin = value;
            }
        }
        private int funcionarioid;

        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value.ToUpper().Trim();
            }
        }

        public int IdNivelAcesso
        {
            get
            {
                return _IdNivelAcesso;
            }
            set
            {
                _IdNivelAcesso = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                _Senha = value;
            }
        }

        public DateTime DataCriacaoSenha
        {
            get
            {
                return _DataCriacaoSenha;
            }
            set
            {
                _DataCriacaoSenha = value;
            }
        }

        public DateTime DataUltimoAcesso
        {
            get
            {
                return _DataUltimoAcesso;
            }
            set
            {
                _DataUltimoAcesso = value;
            }
        }



        public DateTime DataExpiracaoSenha
        {
            get
            {
                return _DataExpiracaoSenha;
            }
            set
            {
                _DataExpiracaoSenha = value;
            }
        }

        public int SenhaAtiva
        {
            get
            {
                return _SenhaAtiva;
            }
            set
            {
                _SenhaAtiva = value;
            }
        }

        private int _statusLogin;

        public int StatusLogin
        {
            get { return _statusLogin; }
            set { _statusLogin = value; }
        }

        public int Funcionarioid
        {
            get
            {
                return funcionarioid;
            }

            set
            {
                funcionarioid = value;
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

        public void Incluir()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO TBLOGIN (  loginid,nivelacessoid,NomedeUsuario,senha,datacriacaosenha,Dataultimoacesso,senhaativo,statuslogin) VALUES ('" + _IdLogin + "', '" + _IdNivelAcesso + "', '" + _Nome + "', '" + _Senha + "', #" + _DataCriacaoSenha + "#, #" + _DataUltimoAcesso + "#,#" + _DataUltimoAcesso + "#, '" + _SenhaAtiva + "', '" + _statusLogin + "'); ";
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
                SQL = "UPDATE TBLOGIN SET NivelAcessoID = '" + _IdNivelAcesso + "', NomeDeUsuario = '" + _Nome + "', Senha = '" + _Senha + "' WHERE LoginID=" + _IdLogin;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarEntregador()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE TBLOGIN SET NivelAcessoID = '" + _IdNivelAcesso + "', NomeDeUsuario = NULL, Senha = NULL WHERE LoginID=" + _IdLogin;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool Logar()
        {
            DAO.ConexaoString objConexao = new DAO.ConexaoString();

            SQL = "SELECT * FROM Tb_Login WHERE usuario = '" + _Nome + "' AND senha = '" + _Senha + "' AND status_Login = 1";

            dr = objConexao.RetornarDataReader(SQL);

            if (dr.HasRows && dr.Read())
            {
                Idfuncionario = Convert.ToInt32(dr["Id_Funcionario"]);
                Nome = dr["usuario"].ToString();
                Senha = dr["senha"].ToString();
                IdNivelAcesso = Convert.ToInt32(dr["nivelAcesso"]);

                return true;
            }
            else
            {
                return false;
            }
        }










        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT * FROM tb_Login WHERE Id_Login = " +IdLogin;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void FixarStatus(Byte Valor)
        { //Valor 1 = Reativar    Valor 0 = Desativar
            try
            {

                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE TBLOGIN SET StatusLogin = '" + Valor + "' WHERE LoginID = " + _IdLogin;
                c.ExecutarComando(SQL);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ListarCargo(string texto)
        {
            
            

        }

        public void Excluir()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "DELETE FROM TBLOGIN WHERE LoginID = '" + _IdLogin + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ListarAtivo()
        {

            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT * FROM TBLOGIN where StatusLogin = 1 ORDER BY NomeDeUsuario";



            return c.RetornarDataSet(SQL);




        }
        public DataSet ListarDesativo()
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT * FROM TBLOGIN where StatusLogin = 0 ORDER BY NomeDeUsuario";


            return c.RetornarDataSet(SQL);



        }



        public SqlDataReader ContarVendasDeHoje()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
              //  SQL = "SELECT COUNT(*) AS TOTALVENDA FROM TBVENDA WHERE STATUSVENDA = 6 AND DATADAVENDA ='" + DataVenda + "'";
                return df.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public SqlDataReader ContarPedidosPendentes()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT COUNT(*) AS TOTALPEDIDOS FROM TBVENDA WHERE STATUSVENDA = 3 OR STATUSVENDA = 4";
                return df.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ContarEntregasPendentes()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT COUNT(*) AS TOTALENTREGAS FROM TBVENDA WHERE STATUSVENDA = 5";
                return df.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ContarEstoqueBaixo()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "SELECT COUNT(*) AS TOTALESTOQUE FROM TBPRODUTOESTOQUE WHERE QUANTIDADEATUAL < QUANTIDADEMINIMA AND STATUSPRODUTO = 1";
                return df.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

    

