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
    public partial class ConsultarProdutos : Form
    {
        public ConsultarProdutos()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu prin = new Modelos.NovoMenu();
            this.Hide();
            prin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto.CadastroDeProdutos produ = new CadastroDeProdutos();
            produ.Show();
        }

        private void ConsultarProdutos_Load(object sender, EventArgs e)
        {

        }


        private void CarregarGrid()
        {

            BLL.Produto prod = new BLL.Produto();

            this.dgvproduto.DataSource = prod.ListarProduto(this.txtpesquisaprod.Text.Trim().ToUpper()).Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL.Produto prod = new BLL.Produto();
            prod.Idprodu = Convert.ToInt32(this.dgvproduto.CurrentRow.Cells[0].Value);
            prod.excluir();
            CarregarGrid();
        }

        private void dgvproduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtpesquisaprod_TextChanged(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection(@"Server=DANILO-PC\SQLEXPRESS; Database = CHURRASTRABALHO ;User Id=sa; Password=123456;");
                SqlCommand cmd = new SqlCommand("select * from Produto where status_produto = 1", conn);



                conn.Open();



                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);

                DataView dv = new DataView(dt);



                dv.RowFilter = "nome  like'" + txtpesquisaprod.Text + "%'";


                dgvproduto.DataSource = dv;

                conn.Close();
            }
        }
    }
}
