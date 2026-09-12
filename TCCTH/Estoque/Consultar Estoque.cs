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
        public ConsultarEstoque()
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
            CadastrarEstoque estoq = new CadastrarEstoque();
            //fornec.Show();
            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                estoq.Codigo = Convert.ToInt32(this.dgvestoqu.CurrentRow.Cells[0].Value);
                estoq.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);
                // func.txtNomeProduto.Enabled = false;
                //func.bAlterarPrato.Visible = true;
                //fornec.Show();
                estoq.Text = "Alterar Cadastro De Estoque";

                if (sender == this.btnPesquisar)
                {

                    estoq.txtQuantidade.Enabled = false;
                    estoq.txtcompra.Enabled = false;
                    estoq.cbofornecedor.Enabled = false;
                    estoq.cboproduto.Enabled = false;
                    estoq.txtNome.Enabled = false;

                    estoq.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Consulta);
                    estoq.Text = "Consultar Cadastro De Estoque";

                    estoq.Show();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarEstoque_Load(object sender, EventArgs e)
        {

        }


        private void CarregarGrid()
        {

            BLL.Estoque func = new BLL.Estoque();

            this.dgvestoqu.DataSource = func.ListarEstoque(this.txtpesqest.Text.Trim().ToUpper()).Tables[0];

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CadastrarEstoque est = new CadastrarEstoque();
            est.txtidestoq.Text = Convert.ToString(this.dgvestoqu.CurrentRow.Cells[0].Value);
            est.Codigo = Convert.ToInt32(this.dgvestoqu.CurrentRow.Cells[0].Value);
            est.Operação = Convert.ToByte(BLL.ValidarCPF.Operação.Alteracao);




            est.Show();
            this.Hide();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
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
            {
                SqlConnection conn = new SqlConnection(@"Server=DANILO-PC\SQLEXPRESS; Database = CHURRASTRABALHO ;User Id=sa; Password=123456;");
                SqlCommand cmd = new SqlCommand("select * from Estoque where status_estoque = 1", conn);



                conn.Open();



                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);

                DataView dv = new DataView(dt);



                dv.RowFilter = "Nome like'" + txtpesqest.Text + "%'";


                dgvestoqu.DataSource = dv;

                conn.Close();
            }
        }
    }
}
        

