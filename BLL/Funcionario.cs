using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Data;
using System.IO;

namespace BLL
{
    public class Funcionario
    {

        DAO.ConexaoString C = new DAO.ConexaoString();

        private int idnivelacesso;


        private static string SQL;
        private int id;


        private string cEP1;

        private string uf1;


        private string bairro11;

        private string cidade1;


        private string logradouro1;

        

        private int id_Funcionario;

        private string usuario;

        private string senha2;
        private string senha1;

        


        private string nivelAcesso1;

        private string senhaLogin;

        private string statusLogin;

        private string nomeCarg;

        private string _cpf;

        private string _endereço;

        private string _email;

        private string _nome;

        private string _sexo;

        private string _rg;

        private string _celular;

        private DateTime _data_nascimento;

        private string _uf;

        private string _cidade;

        private string _status_Func;

        private int _numero;

        private string _bairro;

        private string _salario;

        private string _cep;

        private string _telefone;

        private int _IdFuncionario;
        private string _logradouro;


        private int _Id_Cargo;

        private string _Complemento;
        private string bairro;


        private string nivelAcesso;


        public string cpf;
        private char sexo1;


        public string Endereço
        {
            get
            {
                return _endereço;
            }

            set
            {
                _endereço = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }

        public string Rg
        {
            get
            {
                return _rg;
            }

            set
            {
                _rg = value;
            }
        }

        public string Celular
        {
            get
            {
                return _celular;
            }

            set
            {
                _celular = value;
            }
        }




        public string Cidade
        {
            get
            {
                return _cidade;
            }

            set
            {
                _cidade = value;
            }
        }


        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _bairro;
            }

            set
            {
                _bairro = value;
            }
        }

        public string Salario
        {
            get
            {
                return _salario;
            }

            set
            {
                _salario = value;
            }
        }

        public string Cep
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

        public string Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                _telefone = value;
            }
        }



        public string Status_Func
        {
            get
            {
                return _status_Func;
            }

            set
            {
                _status_Func = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Uf
        {
            get
            {
                return _uf;
            }

            set
            {
                _uf = value;
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

        public DateTime Data_nascimento
        {
            get
            {
                return _data_nascimento;
            }

            set
            {
                _data_nascimento = value;
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public int Id_Cargo
        {
            get
            {
                return _Id_Cargo;
            }

            set
            {
                _Id_Cargo = value;
            }
        }

        public int IdFuncionario
        {
            get
            {
                return _IdFuncionario;
            }

            set
            {
                _IdFuncionario = value;
            }
        }

        public string Bairro1
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return _logradouro;
            }

            set
            {
                _logradouro = value;
            }
        }

        public string NivelAcesso
        {
            get
            {
                return nivelAcesso;
            }

            set
            {
                nivelAcesso = value;
            }
        }

        public string NomeCarg
        {
            get
            {
                return nomeCarg;
            }

            set
            {
                nomeCarg = value;
            }
        }

        public string StatusLogin
        {
            get
            {
                return statusLogin;
            }

            set
            {
                statusLogin = value;
            }
        }

        public string SenhaLogin
        {
            get
            {
                return senhaLogin;
            }

            set
            {
                senhaLogin = value;
            }
        }

        public string NivelAcesso1
        {
            get
            {
                return nivelAcesso1;
            }

            set
            {
                nivelAcesso1 = value;
            }
        }

        public int Id_Funcionario
        {
            get
            {
                return id_Funcionario;
            }

            set
            {
                id_Funcionario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Senha1
        {
            get
            {
                return senha1;
            }

            set
            {
                senha1 = value;
            }
        }

        public string Senha2
        {
            get
            {
                return senha2;
            }

            set
            {
                senha2 = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Logradouro1
        {
            get
            {
                return logradouro1;
            }

            set
            {
                logradouro1 = value;
            }
        }

        public string Cidade1
        {
            get
            {
                return cidade1;
            }

            set
            {
                cidade1 = value;
            }
        }

        public string Bairro11
        {
            get
            {
                return bairro11;
            }

            set
            {
                bairro11 = value;
            }
        }

        public string Uf1
        {
            get
            {
                return uf1;
            }

            set
            {
                uf1 = value;
            }
        }

        public string CEP1
        {
            get
            {
                return cEP1;
            }

            set
            {
                cEP1 = value;
            }
        }

        public int Idnivelacesso
        {
            get
            {
                return idnivelacesso;
            }

            set
            {
                idnivelacesso = value;
            }
        }

        public void IncluirFUNC()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();

                SQL = "INSERT INTO Funcionario (nome, cpf, rg, data_nascimento, sexo, telefone, celular, email, cep, numero, complemento, status_Func, salario, Id_Cargo) " +
                      "VALUES ('" + _nome + "', '" + Cpf + "', '" + _rg + "', '" + _data_nascimento + "', '" + _sexo + "', '" + _telefone + "', '" + _celular + "', '" + _email + "', '" + _cep + "', '" + _numero + "', '" + _Complemento + "', 1, '" + _salario + "', '" + Id_Cargo + "')";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet niveldeacesso(string texto)
        {
            try
            {
                SQL = "SELECT nivelAcesso FROM tb_Login  " + nivelAcesso + "";
                return C.RetornarDataSet(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarFuncionario(string texto)
        {
            DAO.ConexaoString c = new DAO.ConexaoString();
            SQL = "SELECT id_funcionario, nome,cpf,rg,data_nascimento,sexo,telefone,celular,email,cep,numero,complemento,status_Func,salario,Id_Cargo FROM Funcionario where status_Func = 1 ";

            return c.RetornarDataSet(SQL);

        }



        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();

                // Fazemos o JOIN para buscar os dados do funcionário junto com o endereço da tabela CEP
                SQL = "SELECT f.*, c.Logradouro, c.Cidade, c.Bairro, c.UF " +
                      "FROM Funcionario f " +
                      "INNER JOIN CEP c ON f.cep = c.CEP " +
                      "WHERE f.Id_Funcionario = " + _IdFuncionario;

                return c.RetornarDataReader(SQL);
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



                SQL = "UPDATE  FUNCIONARIO SET nome = '" + _nome + "',  cpf = '" + _cpf + "', rg = '" + _rg + "', data_nascimento ='" + _data_nascimento + "', sexo = '" + _sexo + "', telefone = '" + _telefone + "', celular ='" + _celular + "' ,email = '" + _email + "',cep ='" + _cep + "',numero = '" + _numero + "',complemento = '" + _Complemento + "',salario= '" + _salario + "',Id_Cargo='" + _Id_Cargo + "'  WHERE Id_Funcionario = " + _IdFuncionario;

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void excluir() {

            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "UPDATE Funcionario SET status_Func = 0 WHERE Id_Funcionario = '" + _IdFuncionario + "'";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void incluircargo()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Cargo (nome,status_Cargo) values( '" + nomeCarg + "','1')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public DataSet ListarCarg(string texto)
        {

            SQL = "  SELECT nome,status_Cargo FROM Cargo where  status_Cargo = 1";

            return C.retornarDataSet(SQL);



        }


        public void incluirLogin()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO tb_Login (status_Login,senha,usuario,nivelAcesso,Id_Funcionario,Id_NivelDeAcesso) values( '1','" + senhaLogin + "','" + usuario + "','1','" + Id + "','" + Idnivelacesso + "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        
    }
}

    


