using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH
{
    public partial class CadastrarEstoque : Form
    {
        private Int32 codigo;
        private byte operação;
        private bool carregado;

        public CadastrarEstoque()
        {
            InitializeComponent();
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public byte Operação
        {
            get { return operação; }
            set { operação = value; }
        }

        private void CadastrarEstoque_Load(object sender, EventArgs e)
        {
            CarregarCampos(sender, e);
        }

        private void CarregarCampos(object o, EventArgs e)
        {
            if (carregado) return;
            carregado = true;

            RemoverProduto();
            CarregarFornecedores();

            try
            {
                if (Operação != Convert.ToByte(BLL.ValidarCPF.Operação.Inclusao))
                {
                    BLL.Estoque estoq = new BLL.Estoque();
                    SqlDataReader dr;

                    estoq.Id_Estoque = codigo;
                    dr = estoq.Consultar();

                    if (dr.Read())
                    {
                        this.txtQuantidade.Text = dr["quantidade"].ToString();
                        this.txtcompra.Text = Convert.ToDateTime(dr["data"]).ToString("dd/MM/yyyy");
                        this.txtNome.Text = dr["Nome"].ToString();

                        if (dr["Id_Fornecedor"] != DBNull.Value)
                        {
                            this.cbofornecedor.SelectedValue = Convert.ToInt32(dr["Id_Fornecedor"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CarregarFornecedores()
        {
            try
            {
                BLL.Estoque est = new BLL.Estoque();
                this.cbofornecedor.DataSource = est.ListarFornecedores().Tables[0];
                this.cbofornecedor.DisplayMember = "nome_fantasia";
                this.cbofornecedor.ValueMember = "Id_Fornecedor";
                this.cbofornecedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Esconde o combo e o rótulo "Produto" e sobe os campos que ficam logo abaixo.
        // Se o combo já tiver sido apagado no Designer, isso não faz nada.
        private void RemoverProduto()
        {
            Control[] achados = this.Controls.Find("cboproduto", true);
            Label lblProduto = AcharLabel(this, "Produto");

            if (achados.Length > 0)
            {
                Control cboProduto = achados[0];
                int subir = cbofornecedor.Top - cboProduto.Top;

                if (subir > 0)
                {
                    foreach (Control c in cboProduto.Parent.Controls)
                    {
                        if (c != cboProduto && c != lblProduto && c.Top > cboProduto.Top && c.Top <= cboProduto.Top + subir * 3)
                        {
                            c.Top -= subir;
                        }
                    }
                }

                cboProduto.Visible = false;
            }

            if (lblProduto != null)
            {
                lblProduto.Visible = false;
            }
        }

        private Label AcharLabel(Control pai, string texto)
        {
            foreach (Control c in pai.Controls)
            {
                Label l = c as Label;

                if (l != null && l.Text.Trim() == texto)
                {
                    return l;
                }

                Label dentro = AcharLabel(c, texto);

                if (dentro != null)
                {
                    return dentro;
                }
            }

            return null;
        }

        private void Aviso(string texto)
        {
            MessageBox.Show(texto, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool CamposValidos()
        {
            int quantidade;
            DateTime compra;

            if (txtNome.Text.Trim() == string.Empty)
            {
                Aviso("Campo Nome vazio!");
                return false;
            }

            if (!int.TryParse(txtQuantidade.Text, out quantidade))
            {
                Aviso("Campo Quantidade vazio ou inválido!");
                return false;
            }

            if (cbofornecedor.SelectedValue == null)
            {
                Aviso("Selecione o fornecedor!");
                return false;
            }

            if (!DateTime.TryParseExact(txtcompra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out compra))
            {
                Aviso("Data da compra inválida!");
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtcompra.Clear();
            cbofornecedor.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CamposValidos()) return;

            BLL.Estoque estoq = new BLL.Estoque();

            estoq.Quantidade = Convert.ToInt32(this.txtQuantidade.Text);
            estoq.Data = DateTime.ParseExact(this.txtcompra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            estoq.Idforn = Convert.ToInt32(cbofornecedor.SelectedValue);
            estoq.Nome1 = this.txtNome.Text.Trim();

            switch (Operação)
            {
                case 0:
                    estoq.IncluirEstoque();

                    MessageBox.Show("Estoque Cadastrado");

                    LimparCampos();
                    break;

                case 1:
                    estoq.Idest = Convert.ToInt32(this.txtidestoq.Text);
                    estoq.Alterar();

                    MessageBox.Show("Estoque Alterado");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estoque.ConsultarEstoque es = new Estoque.ConsultarEstoque();
            this.Hide();
            es.Show();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtidestoq_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void cbofornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void fornecedorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void fornecedorBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void fornecedorBindingSource2_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void produtoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void produtoBindingSource2_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void produtoBindingSource3_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}