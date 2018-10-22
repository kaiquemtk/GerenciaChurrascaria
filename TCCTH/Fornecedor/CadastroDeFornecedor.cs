using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH.Fornecedor
{
    public partial class txtLogradouro : Form
    {
        public txtLogradouro()
        {
            InitializeComponent();
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

        private void CadastroDeFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtCNPJ.Clear();
            txtContato.Clear();
            txtNome.Clear();
            txtUF.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Fornecedor func = new BLL.Fornecedor();
            switch (Operação)
            {
                case 0:
                    func.Nome = this.txtNome.Text.ToString();
                    func.Endereço = this.txtEndereço.Text.ToString();
                    func.Cidade = this.txtCidade.Text.ToString();
                    func.Contato = this.txtContato.Text.ToString();
                    func.Email = this.txtEmail.Text.ToString();
                    func.Numero = Convert.ToInt32(this.txtNumero.Text);
                    func.Complemento = this.txtComplemento.Text.ToString();
                    //  func.Data_nascimento = Convert.ToInt32(txtDataNasc.Text);
                    func.Bairro = this.txtBairro.Text.ToString();
                    func.Cep = this.txtCep.Text.ToString();
                    func.UF = this.txtUF.Text.ToString();
                    func.CNPJ = this.txtCNPJ.Text.ToString();

                    func.IncluirFUNC();

                    MessageBox.Show("Fornecedor Cadastrado");






                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Cep objSelecionarTipoVenda = new BLL.Cep();
                DataGridView dgv = new DataGridView();
                objSelecionarTipoVenda.cep = this.txtCep.Text;
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

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {


        }
    }

}

