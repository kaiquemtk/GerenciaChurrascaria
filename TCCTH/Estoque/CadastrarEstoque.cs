using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH
{
    public partial class CadastrarEstoque : Form
    {
        public CadastrarEstoque()
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

        private void CadastrarEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet4.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.cHURRASTRABALHODataSet4.Produto);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet3.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.cHURRASTRABALHODataSet3.Fornecedor);

        }
        private void CarregarCampos(object o, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet21.Cardapio' table. You can move, or remove it, as needed.
            this.cardapioTableAdapter.Fill(this.cHURRASTRABALHODataSet21.Cardapio);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet20.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter2.Fill(this.cHURRASTRABALHODataSet20.Fornecedor);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet19.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter3.Fill(this.cHURRASTRABALHODataSet19.Produto);

            try
            { 
            


                // CarregarCampos();


                if (Operação != Convert.ToByte(BLL.ValidarCPF.Operação.Inclusao))
                {
                    BLL.Estoque estoq = new BLL.Estoque();
                    SqlDataReader dr;

                    estoq.Id_Estoque = codigo;
                    dr = estoq.Consultar();

                    if (dr.Read())
                    {
                        this.txtQuantidade.Text = dr["quantidade"].ToString();
                        this.txtcompra.Text = dr["data"].ToString();
                        this.txtNome.Text = dr["Nome"].ToString();
                        this.cbofornecedor.SelectedValue = dr["Id_Fornecedor"].ToString();
                        this.cboproduto.SelectedValue = dr["Id_Cardapio"].ToString();
                        


                    }
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Source, ex.Message);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Estoque.ConsultarEstoque es = new Estoque.ConsultarEstoque();
            this.Hide();
            es.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BLL.Estoque estoq = new BLL.Estoque();
            switch (Operação)
            {
                case 0:


                    if (txtQuantidade.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Quantidade vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    estoq.Quantidade = Convert.ToInt32(this.txtQuantidade.Text);
                    estoq.Data = Convert.ToDateTime(this.txtcompra.Text);
                    estoq.Idforn = Convert.ToInt32(cbofornecedor.SelectedValue);
                    estoq.Id_Cardapio = Convert.ToInt32(cboproduto.SelectedValue);
                    estoq.Nome1 = this.txtNome.Text;






                    estoq.IncluirEstoque();



                    MessageBox.Show("Estoque Cadastrado");


                    break;


                case 1:
                    estoq.Idest = Convert.ToInt32(this.txtidestoq.Text);
                    estoq.Quantidade = Convert.ToInt32(this.txtQuantidade.Text);
                    estoq.Data = Convert.ToDateTime(this.txtcompra.Text);
                    estoq.Idforn = Convert.ToInt32(cbofornecedor.SelectedValue);
                    estoq.Id_Cardapio = Convert.ToInt32(cboproduto.SelectedValue);
                    estoq.Nome1 = this.txtNome.Text;





                    estoq.Alterar();

                    MessageBox.Show("Fornecedor Alterado");






                    break;
            

    }
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbofornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fornecedorBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fornecedorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cboproduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void produtoBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void produtoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtidestoq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void produtoBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fornecedorBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
