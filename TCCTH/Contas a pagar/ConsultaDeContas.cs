using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Administraçao
{
    public partial class ConsultaDeContas : Form
    {
        private DataTable tabela;
        private DataView vista;
        private Label lblResumo;
        private Button btnMarcarPaga;

        public ConsultaDeContas()
        {
            InitializeComponent();
        }

        private void ConsultaDeContas_Load(object sender, EventArgs e)
        {
            dgvconta.Left = 20;
            dgvconta.Width = this.ClientSize.Width - 40;

            CriarControlesNovos();
            dgvconta.CellFormatting += dgvconta_CellFormatting;
            CarregarGrid();
        }

        private void CriarControlesNovos()
        {
            lblResumo = new Label();
            lblResumo.AutoSize = true;
            lblResumo.BackColor = Color.Transparent;
            lblResumo.ForeColor = Color.White;
            lblResumo.Font = new Font("Bookman Old Style", 9.75F);
            lblResumo.Location = new Point(dgvconta.Left, dgvconta.Bottom + 6);
            this.Controls.Add(lblResumo);

            btnMarcarPaga = new Button();
            btnMarcarPaga.Text = "Marcar como paga";
            btnMarcarPaga.Size = new Size(150, 28);
            btnMarcarPaga.FlatStyle = FlatStyle.Flat;
            btnMarcarPaga.BackColor = Color.FromArgb(52, 190, 170);
            btnMarcarPaga.ForeColor = Color.White;
            btnMarcarPaga.Location = new Point(dgvconta.Right - btnMarcarPaga.Width, dgvconta.Top - btnMarcarPaga.Height - 8);
            btnMarcarPaga.Click += btnMarcarPaga_Click;
            this.Controls.Add(btnMarcarPaga);
        }

        private void CarregarGrid()
        {
            BLL.PagarContas cont = new BLL.PagarContas();

            tabela = cont.ListarContasCompleto().Tables[0];
            tabela.Columns.Add("situacao", typeof(string));

            foreach (DataRow linha in tabela.Rows)
            {
                linha["situacao"] = CalcularSituacao(linha);
            }

            vista = new DataView(tabela);
            dgvconta.DataSource = vista;

            FormatarGrid();
            FiltrarGrid();
        }

        private string CalcularSituacao(DataRow linha)
        {
            if (linha["data_pagamento"] != DBNull.Value && Convert.ToDateTime(linha["data_pagamento"]).Year > 1900)
            {
                return "Paga";
            }

            if (Convert.ToDateTime(linha["data_vencimento"]).Date < DateTime.Today)
            {
                return "Vencida";
            }

            return "Pendente";
        }

        private void FormatarGrid()
        {
            EstiloGrid.Aplicar(dgvconta);

            dgvconta.Columns["Id_ContaPagar"].Visible = false;
            dgvconta.Columns["data_vencimento"].HeaderText = "Vencimento";
            dgvconta.Columns["nome_conta"].HeaderText = "Nome";
            dgvconta.Columns["valor"].HeaderText = "Valor";
            dgvconta.Columns["valor"].DefaultCellStyle.Format = "C2";
            dgvconta.Columns["data_pagamento"].HeaderText = "Pagamento";
            dgvconta.Columns["funcionario"].HeaderText = "Funcionário";
            dgvconta.Columns["funcionario"].DefaultCellStyle.NullValue = "-";
            dgvconta.Columns["situacao"].HeaderText = "Situação";
        }

        private void FiltrarGrid()
        {
            if (vista == null) return;

            string texto = txtbuscarconta.Text.Trim().Replace("'", "''");
            vista.RowFilter = "nome_conta like '" + texto + "%'";

            AtualizarResumo();
        }

        private void AtualizarResumo()
        {
            decimal pendente = 0;
            decimal pago = 0;
            int vencidas = 0;

            foreach (DataRowView linha in vista)
            {
                decimal valor = Convert.ToDecimal(linha["valor"]);
                string situacao = linha["situacao"].ToString();

                if (situacao == "Paga")
                {
                    pago += valor;
                }
                else
                {
                    pendente += valor;
                }

                if (situacao == "Vencida")
                {
                    vencidas++;
                }
            }

            lblResumo.Text = "A pagar: " + pendente.ToString("C2") + "   |   Pago: " + pago.ToString("C2") + "   |   Vencidas: " + vencidas;
        }

        private void dgvconta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = dgvconta.Rows[e.RowIndex];
            string situacao = Convert.ToString(linha.Cells["situacao"].Value);

            if (situacao == "Vencida")
            {
                linha.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 205);
            }
            else if (situacao == "Paga")
            {
                linha.DefaultCellStyle.BackColor = Color.FromArgb(210, 240, 210);
            }
            else
            {
                linha.DefaultCellStyle.BackColor = Color.White;
            }

            if (dgvconta.Columns[e.ColumnIndex].Name == "data_pagamento" && e.Value is DateTime)
            {
                if (((DateTime)e.Value).Year <= 1900)
                {
                    e.Value = "-";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnMarcarPaga_Click(object sender, EventArgs e)
        {
            if (dgvconta.CurrentRow == null) return;

            if (Convert.ToString(dgvconta.CurrentRow.Cells["situacao"].Value) == "Paga")
            {
                MessageBox.Show("Essa conta já está paga.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BLL.PagarContas paga = new BLL.PagarContas();
            paga.Idconta = Convert.ToInt32(dgvconta.CurrentRow.Cells[0].Value);
            paga.MarcarComoPaga();

            CarregarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administraçao.CadastroDeContas contas = new Administraçao.CadastroDeContas();
            this.Hide();
            contas.Show();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Administraçao.CadastroDeContas cont = new Administraçao.CadastroDeContas();

            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                cont.Codigo = Convert.ToInt32(this.dgvconta.CurrentRow.Cells[0].Value);
                cont.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);

                cont.Text = "Alterar Cadastro De Conta";

                if (sender == this.btnPesquisar)
                {
                    cont.txtnome.Enabled = false;
                    cont.txtvalor.Enabled = false;
                    cont.txtdata.Enabled = false;
                    cont.txtpagamento.Enabled = false;

                    cont.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Consulta);
                    cont.Text = "Consultar Cadastro De Conta";
                }
            }

            this.Hide();
            cont.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Administraçao.CadastroDeContas edit = new Administraçao.CadastroDeContas();

            edit.txtIdcontas.Text = Convert.ToString(this.dgvconta.CurrentRow.Cells[0].Value);
            edit.Codigo = Convert.ToInt32(this.dgvconta.CurrentRow.Cells[0].Value);
            edit.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);

            this.Hide();
            edit.Show();
            edit.txtpagamento.Visible = true;
            edit.lblpagamento.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL.PagarContas paga = new BLL.PagarContas();
            paga.Idconta = Convert.ToInt32(this.dgvconta.CurrentRow.Cells[0].Value);
            paga.excluir();
            CarregarGrid();
        }

        private void butt_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu p = new Modelos.NovoMenu();
            this.Hide();
            p.Show();
        }

        private void txtbuscarconta_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}