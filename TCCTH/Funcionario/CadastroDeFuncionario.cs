using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace TCCTH.Funcionario
{
    public partial class CadastroDeFuncionario : Form
    {
        public CadastroDeFuncionario()
        {
            InitializeComponent();
        }

        private Int32 codigo;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public byte Operação
        {
            get
            {
                return operação;
            }

            set
            {
                operação = value;
            }
        }

        private byte operação;

        


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtBairro1.Clear();
            txtCelular1.Clear();
            txtCep1.Clear();
            txtCidade1.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtEndereço1.Clear();
            txtNome1.Clear();
            txtNumero1.Clear();
            txtRg1.Clear();
            txtSalario1.Clear();
            txtTelefone1.Clear();
            txtUf1.Clear();


        }

        private void combocarregar()
        {

            //trocar codigo pelo que esta no site esse do biel esta confuso
           
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            BLL.Funcionario func = new BLL.Funcionario();
            switch (Operação)
            {
                case 0:
                    func.Nome = this.txtNome1.Text.ToString();
                    func.Numero = Convert.ToInt32(this.txtNumero1.Text);
                    func.Cpf = this.txtCpf.Text;
                    func.Complemento = this.txtComplemento.Text;
                    func.Rg = this.txtRg1.Text.ToString();
                    func.Salario = Convert.ToInt32(this.txtSalario1.Text);
                    func.Telefone = (this.txtTelefone1.Text);
                    func.Uf = this.txtUf1.Text.ToString();
                    func.Cidade = this.txtCidade1.Text;
                    func.Logradouro = this.txtEndereço1.Text.ToString();
                    func.Endereço = this.txtEndereço1.Text.ToString();
                    func.Email = this.txtEmail.Text.ToString();
                    func.Data_nascimento = Convert.ToDateTime(this.txtDataNasc.Text);
                    func.cpf = this.txtCpf.Text.ToString();
                    func.Cidade = this.txtCidade1.Text.ToString();
                    func.Cep = (txtCep1.Text);
                    func.Celular = (txtCelular1.Text);
                    func.Bairro = this.txtBairro1.Text.ToString();
                    func.Id_Cargo = Convert.ToInt32(cbocargo.Text);
                    func.Uf = this.txtUf1.Text.ToString();


                    func.IncluirFUNC();

                    MessageBox.Show("Funcionario Cadastrado");






                    break;


                case 1:
                    func.IdFuncionario = this.Codigo;
                    func.Nome = this.txtNome1.Text.ToString();
                    func.Numero = Convert.ToInt32(this.txtNumero1.Text);
                    func.Cpf = this.txtCpf.Text;
                    func.Complemento = this.txtComplemento.Text;
                    func.Rg = this.txtRg1.Text.ToString();
                    func.Salario = Convert.ToDecimal(this.txtSalario1.Text);
                    func.Telefone = (this.txtTelefone1.Text);
                    func.Uf = this.txtUf1.Text.ToString();
                    func.Cidade = this.txtCidade1.Text;
                    func.Logradouro = this.txtEndereço1.Text.ToString();
                    func.Endereço = this.txtEndereço1.Text.ToString();
                    func.Email = this.txtEmail.Text.ToString();
                    func.Data_nascimento = Convert.ToDateTime(this.txtDataNasc.Text);
                    func.cpf = this.txtCpf.Text.ToString();
                    func.Cidade = this.txtCidade1.Text.ToString();
                    func.Cep = this.txtCep1.Text;
                    func.Celular = (txtCelular1.Text);
                    func.Bairro = this.txtBairro1.Text.ToString();
                    func.Id_Cargo = Convert.ToInt32(cbocargo.Text);
                    func.Uf = this.txtUf1.Text.ToString();


                    func.Alterar();

                    MessageBox.Show("Funcionario Alterado");

                    break;
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            Funcionario.Consulta consultafuncionario = new Funcionario.Consulta();
            consultafuncionario.Show();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Cep objSelecionarTipoVenda = new BLL.Cep();
                DataGridView dgv = new DataGridView();
                objSelecionarTipoVenda.cep = this.txtCep1.Text;
                DataTable t = objSelecionarTipoVenda.ConsultaMagrini();
                BLL.Cep Produ = new BLL.Cep();
                string Cep = t.Rows[0][0].ToString();
                string Logradouro = t.Rows[0][1].ToString();
                string Bairro = t.Rows[0][3].ToString();
                string Cidade = t.Rows[0][2].ToString();
                string UF = t.Rows[0][4].ToString();
                txtEndereço1.Text = Cep;

                txtUf1.Text = UF;
                txtEndereço1.Text = Logradouro;
                txtBairro1.Text = Bairro;
                txtCidade1.Text = Cidade;
                //txtUF.Text = UF;
                //    this.btnBuscarCep.Enabled = false;

                //  this.txtCep.Enabled = false;

                // Destino = txtEndereço.Text + " - " + txtBairro.Text + " - " + txtCidade.Text + " - " + txtUF;
                //CalcularFrete();
                //btnSelecionarEndereço.Enabled = true;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                //throw;
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Funcionario.Consulta cons = new Funcionario.Consulta();
            cons.Show();
            this.Close();
        }

        private void txtUf1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroDeFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtId1_TextChanged(object sender, EventArgs e)
        {

        }



        private void CarregarCampos(object o, EventArgs e)
        {


            try
            {

                // CarregarCampos();


                if (Operação != Convert.ToByte(BLL.Funcoesgerais.Operação.Inclusao))
                {
                    BLL.Funcionario Func = new BLL.Funcionario();
                    SqlDataReader dr;

                    Func.IdFuncionario = codigo;
                    dr = Func.Consultar();

                    if (dr.Read())
                    {
                        this.txtNome1.Text = dr["nome"].ToString();
                        this.txtRg1.Text = dr["rg"].ToString();
                        this.txtCpf.Text = dr["cpf"].ToString();
                        this.txtTelefone1.Text = dr["telefone"].ToString();
                        this.txtComplemento.Text = dr["complemento"].ToString();
                        this.txtNumero1.Text = dr["numero"].ToString();
                        this.txtSalario1.Text = dr["salario"].ToString();
                        this.txtTelefone1.Text = dr["telefone"].ToString();
                        this.txtUf1.Text = dr["uf"].ToString();
                        this.txtBairro1.Text = dr["bairro"].ToString();
                        this.txtCelular1.Text = dr["celular"].ToString();
                        this.txtCep1.Text = dr["cep"].ToString();
                        this.txtCidade1.Text = dr["Cidade"].ToString();
                        this.txtDataNasc.Text = dr["Data_Nascimento"].ToString();
                        this.txtEmail.Text = dr["email"].ToString();
                        this.cbocargo.Text = dr["Id_Cargo"].ToString();
                        this.txtEndereço1.Text = dr["logradouro"].ToString();

                    }
                }
            }

            catch (Exception ex)

            { MessageBox.Show(ex.Source, ex.Message); }
        }



        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar) || //Letras
                    char.IsSymbol(e.KeyChar) || //Símbolos
                    char.IsWhiteSpace(e.KeyChar) || //Espaço
                    char.IsPunctuation(e.KeyChar)) //Pontuação
                    e.Handled = true; //Não permitir
                                      //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'..

                //Abaixo só é permito de 0 a 9
                if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.Handled = true; //Allow only numbers
            }

        }

        private void txtDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Text = string.Format("{0:dd/MM/yyyy}", dt); //Formata retirando a Hora
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIdCargo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
           
            DAO.CPF valida = new DAO.CPF();
            if (txtCpf.MaxLength>11)
            {
                
            }
            
        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            if (txtDataNasc.MaskCompleted)
            {
                
            }
            else
            {
                MessageBox.Show("Campo preenchido incorretamente");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    } }