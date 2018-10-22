using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TCCTH.Funcionario
{
    public partial class Consulta : Form
    {
        public Consulta()
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            {
                SqlConnection conn = new SqlConnection(@"Server=DANILO-PC\SQLEXPRESS; Database = CHURRASCARIA ;User Id=churras; Password=123456;");
                SqlCommand cmd = new SqlCommand("select * from Funcionario where status_Func = 1", conn);



                conn.Open();



                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);

                DataView dv = new DataView(dt);



                dv.RowFilter = "nome  like'" + txtPesquisarFunc.Text + "%'";
                

                dgv.DataSource = dv;

                conn.Close();
            }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid() {

            BLL.Funcionario func = new BLL.Funcionario();

            this.dgv.DataSource = func.ListarFuncionario(this.txtPesquisarFunc.Text.Trim().ToUpper()).Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario.Consulta gyg = new Funcionario.Consulta();
            Funcionario.CadastroDeFuncionario cadastro = new Funcionario.CadastroDeFuncionario();

            //Funcionario.Consulta gyg = new Funcionario.Consulta();
            this.Close();
            cadastro.Show();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            
            Modelos.Principal princ = new Modelos.Principal();
            princ.Show();
            Hide();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            Funcionario.CadastroDeFuncionario func = new Funcionario.CadastroDeFuncionario();
            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                func.Codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                func.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Alteracao);
                // func.txtNomeProduto.Enabled = false;
                //func.bAlterarPrato.Visible = true;
                func.Show();
                func.Text = "Alterar Cadastro De Funcionario";

                if (sender == this.btnPesquisar)
                {

                    func.txtBairro1.Enabled = false;
                    func.txtCelular1.Enabled = false;
                    func.txtCep1.Enabled = false;
                    func.txtCidade1.Enabled = false;
                    func.txtCpf.Enabled = false;
                    func.txtEndereço1.Enabled = false;
                    func.cbocargo.Enabled = false;
                    func.txtNome1.Enabled = false;
                    func.txtNumero1.Enabled = false;
                    func.txtRg1.Enabled = false;
                    func.txtSalario1.Enabled = false;
                    func.txtTelefone1.Enabled = false;
                    func.txtUf1.Enabled = false;
                    func.txtComplemento.Enabled = false;
                    func.txtDataNasc.Enabled = false;
                    func.txtEmail.Enabled = false;
                    func.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Consulta);
                    func.Text = "Consultar Cadastro De Funcionario";




                }
            }

           // var b = (Button)sender;
            //func.Size = new System.Drawing.Size(914, 725);
            func.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario.CadastroDeFuncionario func = new Funcionario.CadastroDeFuncionario();

            func.Codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            func.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Alteracao);
            // func.txtNomeProduto.Enabled = false;
            //func.bAlterarPrato.Visible = true;
            func.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            BLL.Funcionario func = new BLL.Funcionario();
            func.IdFuncionario = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            func.excluir();
            CarregarGrid();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
    }
    

