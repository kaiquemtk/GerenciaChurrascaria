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
    public partial class ConsultarFornecedor : Form
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private byte Operaçao;

        public byte Operaçao1
        {
            get
            {
                return Operaçao;
            }

            set
            {
                Operaçao = value;
            }
        }

        private void CarregarGrid()
        {

            BLL.Fornecedor func = new BLL.Fornecedor();

            this.dgvForn.DataSource = func.ListarFornecedor(this.txtPesquisarForn.Text.Trim().ToUpper()).Tables[0];

            EstilizarGrid();
        }

        private void EstilizarGrid()
        {
            // Aparência geral
            dgvForn.BorderStyle = BorderStyle.None;
            dgvForn.BackgroundColor = Color.White;
            dgvForn.GridColor = Color.Gainsboro;
            dgvForn.EnableHeadersVisualStyles = false;
            dgvForn.RowHeadersVisible = false;
            dgvForn.AllowUserToAddRows = false;
            dgvForn.AllowUserToResizeRows = false;
            dgvForn.ReadOnly = true;
            dgvForn.MultiSelect = false;
            dgvForn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvForn.RowTemplate.Height = 32;

            // Cabeçalho
            dgvForn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 46, 41); // marrom escuro, combinando com a tela de login
            dgvForn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvForn.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvForn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvForn.ColumnHeadersHeight = 36;
            dgvForn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Linhas
            dgvForn.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvForn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 180, 140); // tom claro, mesma paleta
            dgvForn.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvForn.DefaultCellStyle.Padding = new Padding(4);
            dgvForn.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Nomes de coluna mais amigáveis (só se as colunas já existirem)
            RenomearColuna("Id_Fornecedor", "Código");
            RenomearColuna("email", "E-mail");
            RenomearColuna("nome_fantasia", "Nome Fantasia");
            RenomearColuna("numero", "Número");
            RenomearColuna("cnpj", "CNPJ");
            RenomearColuna("complemento", "Complemento");
            RenomearColuna("contato", "Contato");
            RenomearColuna("cep", "CEP");

            // Largura mínima pra colunas de texto curto não ficarem espremidas
            if (dgvForn.Columns["Id_Fornecedor"] != null)
                dgvForn.Columns["Id_Fornecedor"].FillWeight = 40;

            // Esconde a coluna de código (continua acessível via Cells[0].Value no código)
            if (dgvForn.Columns["Id_Fornecedor"] != null)
                dgvForn.Columns["Id_Fornecedor"].Visible = false;

            // Esconde a coluna de status (controle interno, não precisa aparecer pro usuário)
            if (dgvForn.Columns["status_fornec"] != null)
                dgvForn.Columns["status_fornec"].Visible = false;
        }

        private void RenomearColuna(string nomeOriginal, string novoTitulo)
        {
            if (dgvForn.Columns.Contains(nomeOriginal))
            {
                dgvForn.Columns[nomeOriginal].HeaderText = novoTitulo;
            }
        }

        private void ConsultarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu prin = new Modelos.NovoMenu();
            this.Hide();
            prin.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor.CadastroFornecedor cadastrofornec = new Fornecedor.CadastroFornecedor();
            this.Hide();
            cadastrofornec.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Fornecedor.CadastroFornecedor fornec = new Fornecedor.CadastroFornecedor();
            //fornec.Show();
            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                fornec.Codigo = Convert.ToInt32(this.dgvForn.CurrentRow.Cells[0].Value);
                fornec.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Alteracao);
                // func.txtNomeProduto.Enabled = false;
                //func.bAlterarPrato.Visible = true;
                //fornec.Show();
                fornec.Text = "Alterar Cadastro De Fornecedor";

                if (sender == this.btnPesquisar)
                {

                    fornec.txtNome.Enabled = false;
                    fornec.txtCep1.Enabled = false;
                    fornec.txtCidade.Enabled = false;
                    fornec.txtCNPJ.Enabled = false;
                    fornec.txtComplemento.Enabled = false;
                    fornec.txtContato.Enabled = false;
                    fornec.txtEmail.Enabled = false;
                    fornec.txtEndereço.Enabled = false;
                    fornec.txtNumero.Enabled = false;
                    fornec.txtUF.Enabled = false;
                    fornec.txtBairro.Enabled = false;
                    fornec.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Consulta);
                    fornec.Text = "Consultar Cadastro De Fornecedor";
                }

            }
            this.Hide();
            fornec.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor.CadastroFornecedor func = new Fornecedor.CadastroFornecedor();
            func.txtIdFornec.Text = Convert.ToString(this.dgvForn.CurrentRow.Cells[0].Value);
            func.Codigo = Convert.ToInt32(this.dgvForn.CurrentRow.Cells[0].Value);
            func.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Alteracao);
            // func.txtNomeProduto.Enabled = false;
            //func.bAlterarPrato.Visible = true;
            this.Hide();
            func.Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            BLL.Fornecedor func = new BLL.Fornecedor();
            func.Idfornecedor1 = Convert.ToInt32(this.dgvForn.CurrentRow.Cells[0].Value);
            func.excluir();
            CarregarGrid();
        }

        private void dgvForn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisarForn_TextChanged(object sender, EventArgs e)
        {
            {
                DAO.ConexaoString c = new DAO.ConexaoString();
                SqlConnection conn = new SqlConnection(DAO.ConexaoString.Caminho);
                SqlCommand cmd = new SqlCommand("select * from Fornecedor where status_fornec = 1", conn);



                conn.Open();



                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);

                DataView dv = new DataView(dt);



                dv.RowFilter = "nome_fantasia like'" + txtPesquisarForn.Text + "%'";


                dgvForn.DataSource = dv;

                EstilizarGrid();

                conn.Close();
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
    }
}