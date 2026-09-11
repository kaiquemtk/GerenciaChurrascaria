using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TCCTH.Produto
{
    public partial class CadastroDeProdutos : Form
    {
        public CadastroDeProdutos()
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





        private void CarregarCampos(object o, EventArgs e)
        {
           
            try
            {

                // CarregarCampos();


                if (Operação != Convert.ToByte(BLL.Funcoesgerais.Operação.Inclusao))
                {
                    BLL.Produto produto = new BLL.Produto();
                    SqlDataReader dr;

                    produto.Idprodu = codigo;
                    dr = produto.Consultar();

                    if (dr.Read())
                    {
                        this.txtnome.Text = dr["nome"].ToString();
                        this.txtdesc.Text = dr["descriçao"].ToString();
                        this.txtdatacadas.Text = dr["data_cadastro"].ToString();
                        this.txtquantidade.Text = dr["qtde_estoque_minimo"].ToString();



                    }
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Source, ex.Message);
            }

        }






        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Produto prod = new BLL.Produto();
            switch (Operação)
            {
                case 0:
                    prod.Nome = this.txtnome.Text.ToString();
                    prod.Descri = this.txtdesc.Text.ToString();
                    prod.Datacadast = Convert.ToDateTime(this.txtdatacadas.Text);
                    prod.Quantidade1 = Convert.ToInt32(this.txtquantidade.Text);



                    prod.IncluirProduto();



                    MessageBox.Show("Produto Cadastrado");


                    break;


                case 1:
                    prod.Nome = this.txtnome.Text.ToString();
                    prod.Descri = this.txtdesc.Text.ToString();
                    prod.Datacadast = Convert.ToDateTime(this.txtdatacadas.Text);
                    prod.Quantidade1 = Convert.ToInt32(this.txtquantidade.Text);





                    prod.Alterar();

                    MessageBox.Show("Fornecedor Alterado");






                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produto.ConsultarProdutos cons = new ConsultarProdutos();
            cons.Show();
            


        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void txtdatacadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }
    }
}
