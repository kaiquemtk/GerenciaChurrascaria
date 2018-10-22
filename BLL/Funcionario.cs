using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Data;

namespace BLL
{
    public class Funcionario
    {

        private static string SQL;

        DAO.ConexaoString C = new DAO.ConexaoString();



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

        private decimal _salario;

        private string _cep;

        private string _telefone;

        private int _IdFuncionario;
        private string _logradouro;


        private int _Id_Cargo;

        private string _Complemento;
        private string bairro;


        private string nivelAcesso;


        public string cpf;
       

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

        public decimal Salario
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

        public void IncluirFUNC()
        {
            try
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SQL = "INSERT INTO Funcionario  (nome,cpf,rg,data_nascimento,sexo,telefone,bairro,celular,email,cep,numero,complemento,uf,cidade,logradouro,status_Func,salario,Id_Cargo) values( '" + _nome+ "','" + Cpf + "','" + _rg + "','" + _data_nascimento + "','" + _sexo + "','" + _telefone + "','"+_bairro+"','" + _celular + "','" + _email + "','" + _cep + "','" + _numero + "','" +_Complemento+ "','"+_uf+"','"+_cidade+"','"+_logradouro+"','1','" + _salario + "','" + Id_Cargo +"')";
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
                SQL = "SELECT * FROM Funcionario WHERE Id_Funcionario = " + _IdFuncionario;
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



                SQL = "UPDATE  FUNCIONARIO SET nome = '" + _nome + "',  cpf = '" + _cpf + "', rg = '" + _rg + "', data_nascimento ='" + _data_nascimento + "', sexo = '" + _sexo + "', telefone = '" + _telefone + "',bairro='" + _bairro + "', celular ='" + _celular + "' ,email = '" + _email + "',cep ='" + _cep + "',numero = '" + _numero + "',complemento = '" + _Complemento  + "',salario= '" + _salario + "',Id_Cargo='" + _Id_Cargo + "'  WHERE Id_Funcionario = " + _IdFuncionario;

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
    }




}

