using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Cardapio
{
    public partial class ConsultaDeCardapio : Form
    {
        public ConsultaDeCardapio()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void ConsultaDeCardapio_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cardapio.CadastroDeCardapio cada = new Cardapio.CadastroDeCardapio();
            this.Hide();
            cada.Show();
        }

        private void CarregarGrid()
        {

            BLL.Cardapio cardap = new BLL.Cardapio();

            this.dgv.DataSource = cardap.ListarCardapio(this.txtpesquisar.Text.Trim().ToUpper()).Tables[0];

        }

        private void dgvcardapio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu prin = new Modelos.NovoMenu();
            this.Hide();
            prin.Show();
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {

            {
                SqlConnection conn = new SqlConnection(@"Server=DANILO-PC\SQLEXPRESS; Database = CHURRASTRABALHO ;User Id=sa; Password=123456;");
                SqlCommand cmd = new SqlCommand("select * from Cardapio where status_cardap = 1", conn);



                conn.Open();



                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);

                DataView dv = new DataView(dt);



                dv.RowFilter = "nome  like'" + txtpesquisar.Text + "%'";


                dgv.DataSource = dv;

                conn.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            BLL.Cardapio carda = new BLL.Cardapio();
            carda.Idcardapio = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            carda.ExcluircCardapio();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
