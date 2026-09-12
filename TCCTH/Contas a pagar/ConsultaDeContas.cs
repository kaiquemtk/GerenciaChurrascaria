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
        public ConsultaDeContas()
        {
            InitializeComponent();
        }

        private void ConsultaDeContas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }



        private void CarregarGrid()
        {

            BLL.PagarContas cont = new BLL.PagarContas();

            this.dgvconta.DataSource = cont.ListarContas(this.txtbuscarconta.Text.Trim().ToUpper()).Tables[0];

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
            // func.txtNomeProduto.Enabled = false;
            //func.bAlterarPrato.Visible = true;
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
            {
                SqlConnection conn = new SqlConnection(@"Server=DANILO-PC\SQLEXPRESS; Database = CHURRASTRABALHO ;User Id=sa; Password=123456;");
                SqlCommand cmd = new SqlCommand("select * from ContaPagar where status_conta = 1", conn);



                conn.Open();



                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);

                DataView dv = new DataView(dt);



                dv.RowFilter = "nome_conta  like'" + txtbuscarconta.Text + "%'";


                dgvconta.DataSource = dv;

                conn.Close();
            }
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
