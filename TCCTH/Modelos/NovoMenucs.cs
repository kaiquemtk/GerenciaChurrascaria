using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace TCCTH.Modelos
{
    public partial class NovoMenu : Form
    {
        public NovoMenu()
        {
            InitializeComponent();
            txtidlog.Visible = false;
            txtidlogin.Visible = false;
        }

        public NovoMenu(string valor)
        {
            InitializeComponent();
            txtidlogin.Text = valor;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void btnslide_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {

                MenuVertical.Width = 52;
            }
            else
                MenuVertical.Width = 250;
            {

            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    
        private void MenuDeCima_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MenuDeCima_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estoque.ConsultarEstoque consultarEstoq = new Estoque.ConsultarEstoque();
            this.Hide();
            consultarEstoq.Show();
        }

        private void AbrirForm(object formhijo)
        {
            
            
        }


        private void NovoMenu_Load(object sender, EventArgs e)
        {
            BLL.Login log = new BLL.Login();
            SqlDataReader dr;

            dr = log.Consultar();
            if (dr.Read())

            {
                this.txtidlog.Text = dr["Id_Funcionario"].ToString();
                this.txtidlogin.Text = dr["Id_Login"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario.Consulta consultafuncionario = new Funcionario.Consulta();
            NovoMenu form = new NovoMenu();
            this.Hide();
            consultafuncionario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fornecedor.ConsultarFornecedor consultarforne = new Fornecedor.ConsultarFornecedor();
            this.Hide();
            consultarforne.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fechamento.Caixa caixa1 = new Fechamento.Caixa(txtidlogin.Text);
            this.Hide();

            caixa1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administraçao.ConsultaDeContas contas = new Administraçao.ConsultaDeContas();
            this.Hide();
            contas.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cardapio.ConsultaDeCardapio show = new Cardapio.ConsultaDeCardapio();
            show.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Produto.ConsultarProdutos prod = new Produto.ConsultarProdutos();
            this.Hide();
            prod.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Entrar.CriarUsuario cria = new Entrar.CriarUsuario();
            this.Hide();
            cria.Show();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            Web.ConsultarFale fale = new Web.ConsultarFale();
            this.Hide();
            fale.Show();
        }
    }
}
