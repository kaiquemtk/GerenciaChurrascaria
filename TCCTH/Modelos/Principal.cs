using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Modelos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
          
        }

        public Principal(string valor)
        {
            InitializeComponent();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            

        }

        private void cadastroDeFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario.Consulta consultafuncionario = new Funcionario.Consulta();
            consultafuncionario.Show();
            
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fornecedor.ConsultarFornecedor consultarforne = new Fornecedor.ConsultarFornecedor();
            consultarforne.Show();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.ConsultarEstoque consultarEstoq = new Estoque.ConsultarEstoque();
            consultarEstoq.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrar.CriarUsuario criaruser = new Entrar.CriarUsuario();
            criaruser.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Funcionario.Consulta consultafuncionario = new Funcionario.Consulta();
            this.Hide();
            consultafuncionario.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fornecedor.ConsultarFornecedor consultarforne = new Fornecedor.ConsultarFornecedor();
            this.Hide();
            consultarforne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Estoque.ConsultarEstoque consultarEstoq = new Estoque.ConsultarEstoque();
            this.Hide();
            consultarEstoq.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
            
        }

       

        private void lblHora_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Administraçao.ConsultaDeContas contas = new Administraçao.ConsultaDeContas();
            this.Hide();
            contas.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           Produto.ConsultarProdutos prod = new Produto.ConsultarProdutos();
            this.Hide();
            prod.Show();
        }

        private void btncardapio_Click(object sender, EventArgs e)
        {
            Cardapio.ConsultaDeCardapio show = new Cardapio.ConsultaDeCardapio();
            show.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fechamento.Caixa caixa = new Fechamento.Caixa();
            this.Hide();
            caixa.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
