using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Funcionario
{
    public partial class Consulta : Form
    {
        private DataTable dtFuncionarios = new DataTable();

        public Consulta()
        {
            InitializeComponent();

            // Conecta o evento TextChanged caso não esteja ligado no Designer
            this.txtPesquisarFunc.TextChanged += new System.EventHandler(this.txtPesquisarFunc_TextChanged);

            CarregarGridInicial();
        }

        private byte Operaçao;

        public byte Operaçao1
        {
            get { return Operaçao; }
            set { Operaçao = value; }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            CarregarGridInicial();
        }

        // Carrega todos os dados uma vez para a tabela local
        private void CarregarGridInicial()
        {
            try
            {
                BLL.Funcionario func = new BLL.Funcionario();
                DataSet ds = func.ListarFuncionario("");
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtFuncionarios = ds.Tables[0];
                    dgv.DataSource = dtFuncionarios;
                    FormatarColunasGrid();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    BLL.Funcionario func = new BLL.Funcionario();
                    DataSet ds = func.ListarFuncionario("%");
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        dtFuncionarios = ds.Tables[0];
                        dgv.DataSource = dtFuncionarios;
                        FormatarColunasGrid();
                    }
                }
                catch { }
            }
        }

        // Filtra instantaneamente em tempo real conforme você digita
        private void txtPesquisarFunc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtFuncionarios != null && dtFuncionarios.Rows.Count > 0)
                {
                    DataView dv = new DataView(dtFuncionarios);
                    string texto = txtPesquisarFunc.Text.Trim().Replace("'", "''");

                    if (!string.IsNullOrEmpty(texto))
                    {
                        // Filtra pelo nome em tempo real
                        dv.RowFilter = $"nome LIKE '%{texto}%'";
                    }
                    else
                    {
                        dv.RowFilter = "";
                    }

                    dgv.DataSource = dv;
                    FormatarColunasGrid();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    BLL.Funcionario func = new BLL.Funcionario();
                    this.dgv.DataSource = func.ListarFuncionario(this.txtPesquisarFunc.Text.Trim().ToUpper()).Tables[0];
                    FormatarColunasGrid();
                }
                catch { }
            }
        }

        // Mantido para compatibilidade
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarFunc_TextChanged(sender, e);
        }

        private void CarregarGrid()
        {
            CarregarGridInicial();
        }

        private void FormatarColunasGrid()
        {
            if (dgv.Columns.Count > 0)
            {
                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    switch (coluna.Name.ToLower())
                    {
                        case "id_funcionario":
                        case "id":
                            coluna.HeaderText = "Código";
                            break;
                        case "nome":
                            coluna.HeaderText = "Nome Completo";
                            break;
                        case "cpf":
                            coluna.HeaderText = "CPF";
                            break;
                        case "rg":
                            coluna.HeaderText = "RG";
                            break;
                        case "data_nascimento":
                            coluna.HeaderText = "Data de Nascimento";
                            break;
                        case "sexo":
                            coluna.HeaderText = "Sexo";
                            break;
                        case "telefone":
                            coluna.HeaderText = "Telefone";
                            break;
                        case "celular":
                            coluna.HeaderText = "Celular";
                            break;
                        case "email":
                            coluna.HeaderText = "E-mail";
                            break;
                        case "cep":
                            coluna.HeaderText = "CEP";
                            break;
                        case "numero":
                            coluna.HeaderText = "Número";
                            break;
                        case "complemento":
                            coluna.HeaderText = "Complemento";
                            break;
                        case "status_func":
                            coluna.HeaderText = "Status";
                            break;
                        case "salario":
                            coluna.HeaderText = "Salário";
                            break;
                        case "id_cargo":
                            coluna.HeaderText = "Cód. Cargo";
                            break;
                        case "logradouro":
                            coluna.HeaderText = "Endereço";
                            break;
                        case "cidade":
                            coluna.HeaderText = "Cidade";
                            break;
                        case "bairro":
                            coluna.HeaderText = "Bairro";
                            break;
                        case "uf":
                            coluna.HeaderText = "UF";
                            break;
                    }
                }

                // Esconde a coluna do código de forma segura
                if (dgv.Columns["id_funcionario"] != null)
                {
                    dgv.Columns["id_funcionario"].Visible = false;
                }
                else if (dgv.Columns["id"] != null)
                {
                    dgv.Columns["id"].Visible = false;
                }

                // Esconde a coluna de status (controle interno, não precisa aparecer pro usuário)
                if (dgv.Columns["status_func"] != null)
                {
                    dgv.Columns["status_func"].Visible = false;
                }

                // Esconde colunas secundárias, que só são necessárias ao editar o cadastro,
                // não para localizar rapidamente um funcionário na lista
                string[] colunasParaEsconder = { "rg", "data_nascimento", "sexo", "cep", "numero", "complemento", "telefone", "id_cargo" };
                foreach (string nomeColuna in colunasParaEsconder)
                {
                    if (dgv.Columns[nomeColuna] != null)
                    {
                        dgv.Columns[nomeColuna].Visible = false;
                    }
                }

                EstilizarGrid();
            }
        }

        private void EstilizarGrid()
        {
            // Aparência geral
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.Gainsboro;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowTemplate.Height = 32;

            // Cabeçalho
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 46, 41); // marrom escuro, mesma paleta do sistema
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Linhas
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 180, 140); // tom claro, mesma paleta
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Padding = new Padding(4);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario.Consulta gyg = new Funcionario.Consulta();
            Funcionario.CadastroDeFuncionario cadastro = new Funcionario.CadastroDeFuncionario();

            this.Close();
            this.Hide();
            cadastro.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu princ = new Modelos.NovoMenu();
            this.Hide();
            princ.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Funcionario.CadastroDeFuncionario func = new Funcionario.CadastroDeFuncionario();
            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                if (dgv.CurrentRow != null)
                {
                    func.Codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells["id_funcionario"].Value);
                }
                func.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);
                func.Show();
                func.Text = "Alterar Cadastro De Funcionario";

                if (sender == this.btnPesquisar)
                {
                    func.txtBairro1.Enabled = false;
                    func.txtCelular1.Enabled = false;
                    func.txtCep1.Enabled = false;
                    func.txtCidade1.Enabled = false;
                    func.txtCpf.Enabled = false;
                    func.txtEndereço1.Enabled = false;
                    func.cbocargo.Enabled = false;
                    func.txtNome1.Enabled = false;
                    func.txtNumero1.Enabled = false;
                    func.txtRg1.Enabled = false;
                    func.txtSalario1.Enabled = false;
                    func.txtTelefone1.Enabled = false;
                    func.txtUf1.Enabled = false;
                    func.txtComplemento.Enabled = false;
                    func.txtDataNasc.Enabled = false;
                    func.txtEmail.Enabled = false;
                    func.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Consulta);
                    func.Text = "Consultar Cadastro De Funcionario";
                }
            }

            this.Hide();
            func.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario.CadastroDeFuncionario func = new Funcionario.CadastroDeFuncionario();

            if (dgv.CurrentRow != null)
            {
                func.Codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells["id_funcionario"].Value);
            }
            func.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);
            this.Hide();
            func.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                BLL.Funcionario func = new BLL.Funcionario();
                func.IdFuncionario = Convert.ToInt32(this.dgv.CurrentRow.Cells["id_funcionario"].Value);
                func.excluir();
                CarregarGridInicial();
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGridInicial();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dgv.SelectAll();
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