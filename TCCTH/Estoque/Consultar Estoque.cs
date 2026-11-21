using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Estoque
{
    public partial class ConsultarEstoque : Form
    {
        private const int EstoqueBaixo = 10;

        private DataTable tabela;
        private DataView vista;
        private Label lblResumo;
        private byte Operaçao;

        public ConsultarEstoque()
        {
            InitializeComponent();

            dgvestoqu.Left = 20;
            dgvestoqu.Width = this.ClientSize.Width - 40;

            CriarResumo();
            dgvestoqu.CellFormatting += dgvestoqu_CellFormatting;
            CarregarGrid();
        }

        public byte Operaçao1
        {
            get { return Operaçao; }
            set { Operaçao = value; }
        }

        private void CriarResumo()
        {
            lblResumo = new Label();
            lblResumo.AutoSize = true;
            lblResumo.BackColor = Color.Transparent;
            lblResumo.ForeColor = Color.White;
            lblResumo.Font = new Font("Bookman Old Style", 9.75F);
            lblResumo.Location = new Point(dgvestoqu.Left, dgvestoqu.Bottom + 6);
            this.Controls.Add(lblResumo);
        }

        private void CarregarGrid()
        {
            BLL.Estoque est = new BLL.Estoque();

            tabela = est.ListarEstoqueCompleto().Tables[0];
            tabela.Columns.Add("situacao", typeof(string));

            foreach (DataRow linha in tabela.Rows)
            {
                linha["situacao"] = CalcularSituacao(Convert.ToInt32(linha["quantidade"]));
            }

            vista = new DataView(tabela);
            dgvestoqu.DataSource = vista;

            FormatarGrid();
            FiltrarGrid();
        }

        private string CalcularSituacao(int quantidade)
        {
            if (quantidade <= 0)
            {
                return "Zerado";
            }

            if (quantidade <= EstoqueBaixo)
            {
                return "Baixo";
            }

            return "Normal";
        }

        private void FormatarGrid()
        {
            EstiloGrid.Aplicar(dgvestoqu);

            dgvestoqu.Columns["Id_Estoque"].Visible = false;
            dgvestoqu.Columns["Nome"].HeaderText = "Nome";
            dgvestoqu.Columns["fornecedor"].HeaderText = "Fornecedor";
            dgvestoqu.Columns["fornecedor"].DefaultCellStyle.NullValue = "-";
            dgvestoqu.Columns["quantidade"].HeaderText = "Quantidade";
            dgvestoqu.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvestoqu.Columns["data"].HeaderText = "Data da Compra";
            dgvestoqu.Columns["data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvestoqu.Columns["situacao"].HeaderText = "Situação";
            dgvestoqu.Columns["situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private string EscaparFiltro(string texto)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in texto)
            {
                if (c == '*' || c == '%' || c == '[' || c == ']')
                {
                    sb.Append('[').Append(c).Append(']');
                }
                else if (c == '\'')
                {
                    sb.Append("''");
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        private void FiltrarGrid()
        {
            if (vista == null) return;

            string texto = EscaparFiltro(txtpesqest.Text.Trim());
            vista.RowFilter = "Nome like '%" + texto + "%' OR fornecedor like '%" + texto + "%'";

            AtualizarResumo();
        }

        private void AtualizarResumo()
        {
            int itens = 0;
            int unidades = 0;
            int baixos = 0;

            foreach (DataRowView linha in vista)
            {
                itens++;
                unidades += Convert.ToInt32(linha["quantidade"]);

                if (linha["situacao"].ToString() != "Normal")
                {
                    baixos++;
                }
            }

            lblResumo.Text = "Itens: " + itens + "   |   Unidades: " + unidades + "   |   Baixo ou zerado: " + baixos;
        }

        private void dgvestoqu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = dgvestoqu.Rows[e.RowIndex];
            string situacao = Convert.ToString(linha.Cells["situacao"].Value);

            if (situacao == "Zerado")
            {
                linha.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 205);
            }
            else if (situacao == "Baixo")
            {
                linha.DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 190);
            }
            else
            {
                linha.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastrarEstoque cad = new CadastrarEstoque();
            this.Hide();
            cad.Show();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu pr = new Modelos.NovoMenu();
            this.Hide();
            pr.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (this.dgvestoqu.CurrentRow == null) return;

            CadastrarEstoque estoq = new CadastrarEstoque();

            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                estoq.Codigo = Convert.ToInt32(this.dgvestoqu.CurrentRow.Cells[0].Value);
                estoq.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);
                estoq.Text = "Alterar Cadastro De Estoque";

                if (sender == this.btnPesquisar)
                {
                    estoq.txtQuantidade.Enabled = false;
                    estoq.txtcompra.Enabled = false;
                    estoq.cbofornecedor.Enabled = false;
                    estoq.txtNome.Enabled = false;

                    estoq.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Consulta);
                    estoq.Text = "Consultar Cadastro De Estoque";

                    estoq.Show();
                    this.Hide();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvestoqu.CurrentRow == null) return;

            CadastrarEstoque est = new CadastrarEstoque();
            est.txtidestoq.Text = Convert.ToString(this.dgvestoqu.CurrentRow.Cells[0].Value);
            est.Codigo = Convert.ToInt32(this.dgvestoqu.CurrentRow.Cells[0].Value);
            est.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);

            est.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.dgvestoqu.CurrentRow == null) return;

            BLL.Estoque ex = new BLL.Estoque();
            ex.Idest = Convert.ToInt32(this.dgvestoqu.CurrentRow.Cells[0].Value);
            ex.excluir();
            CarregarGrid();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpesqest_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ConsultarEstoque_Load(object sender, EventArgs e)
        {
        }
    }
}