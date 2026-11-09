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
    public partial class CadastroDeContas : Form
    {
        private Int32 codigo;
        private Int32 _Operação;
        private ComboBox cboFuncionario;
        private Label lblFuncionario;

        public CadastroDeContas()
        {
            InitializeComponent();
            txtIdcontas.Visible = false;
            txtpagamento.Visible = false;
            lblpagamento.Visible = false;
            CriarComboFuncionario();
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Operação
        {
            get { return _Operação; }
            set { _Operação = value; }
        }

        private void CriarComboFuncionario()
        {
            Control pai = txtdata.Parent;

            lblFuncionario = new Label();
            lblFuncionario.AutoSize = true;
            lblFuncionario.BackColor = Color.Transparent;
            lblFuncionario.ForeColor = Color.White;
            lblFuncionario.Font = lblpagamento.Font;
            lblFuncionario.Text = "Funcionário Responsável";
            lblFuncionario.Location = new Point(lblpagamento.Left, txtdata.Top - 28);

            cboFuncionario = new ComboBox();
            cboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncionario.FlatStyle = FlatStyle.Flat;
            cboFuncionario.Size = new Size(200, 21);
            cboFuncionario.Location = new Point(lblpagamento.Left, txtdata.Top);

            try
            {
                BLL.Funcionario func = new BLL.Funcionario();
                cboFuncionario.DataSource = func.ListarFuncionario("").Tables[0];
                cboFuncionario.DisplayMember = "nome";
                cboFuncionario.ValueMember = "id_funcionario";
                cboFuncionario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pai.Controls.Add(lblFuncionario);
            pai.Controls.Add(cboFuncionario);
            lblFuncionario.BringToFront();
            cboFuncionario.BringToFront();
        }

        private void CarregarCampos(object o, EventArgs e)
        {
            try
            {
                if (Operação != Convert.ToByte(BLL.ValidarCPF.Operação.Inclusao))
                {
                    BLL.PagarContas pag = new BLL.PagarContas();
                    SqlDataReader dr;

                    pag.Idconta = codigo;
                    dr = pag.Consultar();

                    if (dr.Read())
                    {
                        this.txtnome.Text = dr["nome_conta"].ToString();
                        this.txtvalor.Text = Convert.ToDecimal(dr["valor"]).ToString("F2");
                        this.txtpagamento.Text = dr["data_pagamento"].ToString();
                        this.txtdata.Text = dr["data_vencimento"].ToString();

                        if (dr["Id_Funcionario"] != DBNull.Value)
                        {
                            this.cboFuncionario.SelectedValue = Convert.ToInt32(dr["Id_Funcionario"]);
                        }

                        if (Operação == Convert.ToByte(BLL.ValidarCPF.Operação.Consulta))
                        {
                            this.cboFuncionario.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.PagarContas cont = new BLL.PagarContas();
            BLL.PagarContas alter = new BLL.PagarContas();

            if (cboFuncionario.SelectedValue == null)
            {
                MessageBox.Show("Selecione o funcionário responsável!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);

            switch (Operação)
            {
                case 0:
                    if (txtdata.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Data vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtnome.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtvalor.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Valor vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cont.Nome = this.txtnome.Text.ToString();
                    cont.Data = this.txtdata.Text.ToString();
                    cont.Valor = this.txtvalor.Text.ToString().Replace(",", ".");
                    cont.DataDoPagamento = this.txtpagamento.Text.ToString().Replace("/", "");
                    cont.Idfuncionario = funcionario;

                    cont.IncluirConta();

                    MessageBox.Show("Conta Cadastrada");

                    txtnome.Clear();
                    txtdata.Clear();
                    txtvalor.Clear();
                    txtpagamento.Clear();
                    cboFuncionario.SelectedIndex = -1;
                    break;

                case 1:
                    alter.Idconta = Convert.ToInt32(this.txtIdcontas.Text);
                    alter.Nome = this.txtnome.Text.ToString();
                    alter.Data = this.txtdata.Text.ToString();
                    alter.Valor = this.txtvalor.Text.ToString().Replace(",", ".");
                    alter.DataDoPagamento = this.txtpagamento.Text.ToString().Replace("/", "");
                    alter.Idfuncionario = funcionario;

                    alter.Alterar();

                    MessageBox.Show("Conta Alterada");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administraçao.ConsultaDeContas cons = new Administraçao.ConsultaDeContas();
            cons.Show();
            this.Close();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        private void txtdata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        private void txtpagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') e.Handled = true;
            if (e.KeyChar == ',' && txtvalor.Text.Contains(",")) e.Handled = true;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}