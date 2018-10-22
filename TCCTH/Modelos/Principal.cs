using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH.Modelos
{
    public partial class Principal : Form
    {
        public Principal()
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
            consultafuncionario.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fornecedor.ConsultarFornecedor consultarforne = new Fornecedor.ConsultarFornecedor();
            consultarforne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Estoque.ConsultarEstoque consultarEstoq = new Estoque.ConsultarEstoque();
            consultarEstoq.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Dispose();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
           
        }
    }
}
