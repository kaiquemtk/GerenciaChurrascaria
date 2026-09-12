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
    public partial class CadastroDeContas :Form 
    {
        public CadastroDeContas()
        {
            InitializeComponent();
            txtIdcontas.Visible = false;
            txtpagamento.Visible = false;
            lblpagamento.Visible = false;
            
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


        private void CarregarCampos(object o, EventArgs e)
        {
            try
            {

                // CarregarCampos();


                if (Operação != Convert.ToByte(BLL.ValidarCPF.Operação.Inclusao))
                {
                    BLL.PagarContas pag = new BLL.PagarContas();
                    SqlDataReader dr;

                    pag.Idconta = codigo;
                    dr = pag.Consultar();

                    if (dr.Read())
                    {
                        this.txtnome.Text = dr["nome_conta"].ToString();
                        this.txtvalor.Text = dr["valor"].ToString();
                        this.txtpagamento.Text = dr["data_pagamento"].ToString();
                        this.txtdata.Text = dr["data_vencimento"].ToString();

                        

                   
                        }
                    
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Source, ex.Message);
            }

        }






        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BLL.PagarContas cont = new BLL.PagarContas();
            BLL.PagarContas alter = new BLL.PagarContas();


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



                    

                        cont.IncluirConta();
                        






                    




                        MessageBox.Show("Conta Cadastrada");


                    break;

                    






                case 1:
                    alter.Idconta = Convert.ToInt32(this.txtIdcontas.Text);
                    alter.Nome = this.txtnome.Text.ToString();
                    alter.Data = this.txtdata.Text.ToString();
                    alter.Valor = this.txtvalor.Text.ToString().Replace(",", ".");
                    cont.DataDoPagamento = this.txtpagamento.Text.ToString().Replace("/", "");






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

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtdata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtpagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

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
