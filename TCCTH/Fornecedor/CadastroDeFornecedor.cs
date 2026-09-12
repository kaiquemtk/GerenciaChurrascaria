using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Fornecedor
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
            textBox1.Visible = false;
            txtIdFornec.Visible = false;
        }


        private int endereçoid;

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


        private Int32 _Operação;

        public int Operação
        {
            get
            {
                return _Operação;
            }

            set
            {
                _Operação = value;
            }
        }

        public int Endereçoid
        {
            get
            {
                return endereçoid;
            }

            set
            {
                endereçoid = value;
            }
        }

        private void CarregarCampos(object o, EventArgs e)
        {
            try
            {
                if (Operação != Convert.ToByte(BLL.ValidarCPF.Operação.Inclusao))
                {
                    BLL.Fornecedor Forn = new BLL.Fornecedor();
                    SqlDataReader dr;

                    Forn.Idfornec = codigo;
                    dr = Forn.Consultar();

                    if (dr.Read())
                    {
                        this.txtEmail.Text = dr["email"].ToString();
                        this.txtNome.Text = dr["nome_fantasia"].ToString();
                        this.txtNumero.Text = dr["numero"].ToString();
                        this.txtCNPJ.Text = dr["cnpj"].ToString();
                        this.txtComplemento.Text = dr["complemento"].ToString();
                        this.txtContato.Text = dr["contato"].ToString();
                        this.txtCep1.Text = dr["cep"].ToString();

                        // Busca o endereço (Logradouro/Bairro/Cidade/UF) a partir do CEP salvo
                        BLL.Cep objCep = new BLL.Cep();
                        objCep.cep = this.txtCep1.Text.Replace("-", "");
                        DataTable tCep = objCep.ConsultaMagrini();

                        if (tCep.Rows.Count > 0)
                        {
                            this.txtEndereço.Text = tCep.Rows[0][1].ToString();
                            this.txtCidade.Text = tCep.Rows[0][2].ToString();
                            this.txtBairro.Text = tCep.Rows[0][3].ToString();
                            this.txtUF.Text = tCep.Rows[0][4].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Source, ex.Message);
            }

        }





        private void CadastroDeFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fornecedor.ConsultarFornecedor consl = new ConsultarFornecedor();
            this.Hide();
            consl.Show();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            txtCep1.Clear();
            txtCNPJ.Clear();
            txtContato.Clear();
            txtNome.Clear();
            txtUF.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Fornecedor fornec = new BLL.Fornecedor();
            BLL.Fornecedor func = new BLL.Fornecedor();
            switch (Operação)
            {
                case 0:

                    if (txtNome.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNumero.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Numero vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtCNPJ.Text == string.Empty)
                    {
                        MessageBox.Show("Campo CNPJ vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtContato.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Contato vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtEmail.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Email vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }




                    func.Nome = this.txtNome.Text.ToString();
                    func.Endereço = this.txtEndereço.Text.ToString();
                    func.Cidade = this.txtCidade.Text.ToString();
                    func.Contato = this.txtContato.Text.ToString();
                    func.Email = this.txtEmail.Text.ToString();
                    func.Numero = Convert.ToInt32(this.txtNumero.Text);
                    func.Complemento = this.txtComplemento.Text.ToString();
                    func.Bairro = this.txtBairro.Text.ToString();
                    func.Cep = this.txtCep1.Text.ToString().Replace("-", "");
                    func.UF = this.txtUF.Text.ToString();
                    func.CNPJ = System.Text.RegularExpressions.Regex.Replace(this.txtCNPJ.Text, "[^0-9]", "");

                    func.IncluirFUNC();


                    MessageBox.Show("Fornecedor Cadastrado");


                    break;


                case 1:
                    fornec.Idfornec = Convert.ToInt32(this.txtIdFornec.Text);
                    fornec.Nome = this.txtNome.Text.ToString();
                    fornec.Numero = Convert.ToInt32(this.txtNumero.Text);
                    fornec.CNPJ = System.Text.RegularExpressions.Regex.Replace(this.txtCNPJ.Text, "[^0-9]", "");
                    fornec.Complemento = this.txtComplemento.Text;
                    fornec.Contato = this.txtContato.Text.ToString();
                    fornec.Email = (this.txtEmail.Text);
                    fornec.Cep = this.txtCep1.Text.ToString().Replace("-", "");

                    fornec.Alterar();

                    MessageBox.Show("Fornecedor Alterado");

                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                txtEndereço.Text = Cep;


                txtUF.Text = UF;
                txtEndereço.Text = Logradouro;
                txtBairro.Text = Bairro;
                txtCidade.Text = Cidade;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                //throw;
            }
        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (DAO.ValidarEmail.validarEmail(txtEmail.Text))
            {

            }
            else
            {
                MessageBox.Show("E-MAIL INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem");
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {

            if (DAO.Cnpj.VALIDAO(txtCNPJ.Text))
            {

            }
            else
            {
                MessageBox.Show("E-MAIL INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem");
            }


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;

            {

            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
            {

            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
            {

            }
        }

        private void txtUF_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtEndereço_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
            {

            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;

            {

            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;

            {

            }
        }

        private void txtContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;

            {

            }
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
                txtEndereço.Text = Cep;


                txtUF.Text = UF;
                txtEndereço.Text = Logradouro;
                txtBairro.Text = Bairro;
                txtCidade.Text = Cidade;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                //throw;
            }
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}