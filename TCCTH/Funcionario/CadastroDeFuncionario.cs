using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
//using System.Data;
using System.Data.SqlClient;
namespace TCCTH.Funcionario

{
    public partial class CadastroDeFuncionario : Form
    {
        public CadastroDeFuncionario()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            txtidendereco.Visible = false;
            
        }

        private int enderecoid;

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

        public int Enderecoid
        {
            get
            {
                return enderecoid;
            }

            set
            {
                enderecoid = value;
            }
        }




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
            BLL.Endereço endere = new BLL.Endereço();
            BLL.Funcionario func = new BLL.Funcionario();
            BLL.Funcionario log = new BLL.Funcionario();
            switch (Operação)
            {
                case 0:
                    func.Nome = this.txtNome1.Text.ToString();
                    func.Numero = Convert.ToInt32(this.txtNumero1.Text);
                    func.Cpf = this.txtCpf.Text;
                    func.Complemento = this.txtComplemento.Text;
                    func.Rg = this.txtRg1.Text.ToString();
                    func.Salario = this.txtSalario1.Text.ToString().Replace(",", ".");
                    func.Telefone = this.txtTelefone1.Text;
                    func.Uf = this.txtUf1.Text.ToString();
                    func.Cidade = this.txtCidade1.Text;
                    func.Logradouro = this.txtEndereço1.Text.ToString();
                    func.Endereço = this.txtEndereço1.Text.ToString();
                    func.Email = this.txtEmail.Text.ToString();
                    func.Data_nascimento = Convert.ToDateTime(this.txtDataNasc.Text);
                    func.cpf = this.txtCpf.Text.ToString();
                    func.Cidade = this.txtCidade1.Text.ToString();
                    func.Celular = this.txtCelular1.Text;
                    func.Cep = (txtCep1.Text).Replace("-", "");
                    func.Bairro = this.txtBairro1.Text.ToString();
                    func.Id_Cargo = Convert.ToInt32(cbocargo.SelectedValue);
                    func.Uf = this.txtUf1.Text.ToString();
                    func.Logradouro1 = this.txtEndereço1.Text.ToString();
                    func.Cidade1 = this.txtCidade1.Text.ToString();
                    func.Bairro1 = this.txtBairro1.Text.ToString();
                    func.Uf1 = this.txtUf1.Text.ToString();
                    func.CEP1 = this.txtCep1.Text.ToString().Replace("-", "");
                    

                    if (rdbFeminino.Checked)
                    {
                        func.Sexo = "F";
                    }
                    else
                    {
                        func.Sexo = "M";
                    }


                    //Validação de campos


                    if (txtNome1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtEmail.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Email vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtRg1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo RG vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtDataNasc.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Data de nascimento vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtCpf.Text == string.Empty)
                    {
                        MessageBox.Show("Campo CPF vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtTelefone1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Telefone vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtCelular1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Celular vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNumero1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Numero vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    else if (txtCep1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Cep vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    else if (txtSalario1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Salario vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }



                   
                    func.IncluirFUNC();



                    if (txtRg1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo obrigatorio não preenchido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRg1.BackColor = Color.Blue;

                    }
                    

                    MessageBox.Show("Funcionario Cadastrado");





                    break;


                case 1:
                    func.IdFuncionario = this.Codigo;
                    func.Nome = this.txtNome1.Text.ToString();
                    func.Numero = Convert.ToInt32(this.txtNumero1.Text);
                    func.Cpf = this.txtCpf.Text;
                    func.Complemento = this.txtComplemento.Text;
                    func.Rg = this.txtRg1.Text.ToString();
                    func.Salario = this.txtSalario1.Text.ToString().Replace(",", ".");
                    func.Telefone = this.txtTelefone1.Text;
                    endere.UF = this.txtUf1.Text.ToString();
                    endere.Cidade = this.txtCidade1.Text;
                    endere.Logradouro = this.txtEndereço1.Text.ToString();
                   // func.Endereço = this.txtEndereço1.Text.ToString();
                    func.Email = this.txtEmail.Text.ToString();
                    func.Data_nascimento = Convert.ToDateTime(this.txtDataNasc.Text);
                    func.cpf = this.txtCpf.Text.ToString();
                    func.Cep = this.txtCep1.Text.Replace("-", "");
                    endere.Cep = this.txtCep1.Text.Replace("-", "");
                    func.Celular = this.txtCelular1.Text;
                    endere.Bairro = this.txtBairro1.Text.ToString();
                    func.Id_Cargo = Convert.ToInt32(cbocargo.SelectedValue);
                    func.Uf = this.txtUf1.Text.ToString();
                    if (rdbFeminino.Checked)
                    {
                        func.Sexo = "F";
                    }
                    else
                    {
                        func.Sexo = "M";
                    }

                    endere.AlterarEndereço();
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
                objSelecionarTipoVenda.cep = this.txtCep1.Text.Replace("-", "");
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
            this.Hide();
            cons.Show();
            
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
            Carregarcombocargo(); // Carrega os cargos na combo box
            CarregarCampos(sender, e); // Executa o carregamento dos dados do funcionário se for Alteração ou Consulta
        }

        private void txtId1_TextChanged(object sender, EventArgs e)
        {

        }



        private void CarregarCampos(object o, EventArgs e)
        {
            try
            {
                this.cargoTableAdapter.Fill(this.cHURRASTRABALHODataSet11.Cargo);

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
                        this.txtCelular1.Text = dr["celular"].ToString();
                        this.txtCep1.Text = dr["cep"].ToString();
                        this.txtDataNasc.Text = dr["Data_Nascimento"].ToString();
                        this.txtEmail.Text = dr["email"].ToString();

                        if (dr["Id_Cargo"] != DBNull.Value)
                        {
                            this.cbocargo.SelectedValue = dr["Id_Cargo"].ToString();
                        }

                        if (dr["sexo"].ToString() == "F")
                        {
                            this.rdbFeminino.Checked = true;
                        }
                        else if (dr["sexo"].ToString() == "M")
                        {
                            this.rdbMasculino.Checked = true;
                        }

                        // Preenche os dados de endereço direto da consulta do funcionário (ou busca pelo CEP preenchido)
                        this.txtEndereço1.Text = dr["logradouro"].ToString();
                        this.txtCidade1.Text = dr["cidade"].ToString();
                        this.txtBairro1.Text = dr["bairro"].ToString();
                        this.txtUf1.Text = dr["uf"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar campos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            

        }

        private void txtDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCargo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (ValidarCPF.validarEmail123(txtCpf.Text))
            {

            }
            else
            {
                MessageBox.Show("CPF INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem");
            }

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            if (ValidarData.ValidarData123( txtDataNasc.Text))
            {

            }
            else
           {
                MessageBox.Show("DATA INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem");

           }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            {

                {


                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail.validarEmail(txtEmail.Text))
            {

            }
            else
            {
                MessageBox.Show("E-MAIL INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem");
            }


        }

        private void txtDataNasc_MaskChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            BLL.Funcionario func = new BLL.Funcionario();
            switch (Operação)
            {
                case 0:
                    func.NomeCarg = this.txtAddCargp.Text.ToString();

                    func.incluircargo();

                    Carregarcombocargo();

                    MessageBox.Show("Cargo Cadastrado");
                    break;
            }
        }

        private void Carregarcombocargo()
        {

            try
            {
                BLL.Funcionario Carg = new BLL.Funcionario();
                this.cbocargo.DataSource = Carg.ListarCarg("").Tables[0];
                this.cbocargo.DisplayMember = "nome";
                this.cbocargo.ValueMember = "Id_Cargo";
                cbocargo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtNome1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRg1_Leave(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtSalario1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar));

        }

        private void txtNome1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtRg1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRg1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRg1_TextChanged(object sender, EventArgs e)
        {
            txtRg1.Text = txtRg1.Text.ToUpper();
        }

        private void txtCpf_Leave_1(object sender, EventArgs e)
        {
            if (ValidarCPF.validarEmail123(txtCpf.Text))
            {

            }
            else
            {
                MessageBox.Show("CPF INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem");
                
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCep1_Leave(object sender, EventArgs e)
        {
            try
            {
                BLL.Cep objSelecionarTipoVenda = new BLL.Cep();
                DataGridView dgv = new DataGridView();
                objSelecionarTipoVenda.cep = this.txtCep1.Text.Replace("-", "");
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

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboNiveldeAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }




    




    
