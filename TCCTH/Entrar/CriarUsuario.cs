using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TCCTH.Entrar
{
    public partial class CriarUsuario : Form
    {
        public CriarUsuario()
        {
            InitializeComponent();
            Carregarcombocargo();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar(object sender, EventArgs e)
        {
            txtUsuario1.Clear();
            txtSenha.Clear();
            
        }
        

        private void CriarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet5.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter2.Fill(this.cHURRASTRABALHODataSet5.Funcionario);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet2.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter1.Fill(this.cHURRASTRABALHODataSet2.Funcionario);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet1.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.cHURRASTRABALHODataSet1.Funcionario);

        }


        private Boolean validarcampos()
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Campo Email é requerido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Verifique a senha por favor!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }







        private void nada(object sender, EventArgs e)
        {
            
            
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {




        }

        private void Carregarcombocargo()
        {

            try
            {
                BLL.Funcionario Carg = new BLL.Funcionario();
                this.cboFuncionario.DataSource = Carg.ListarFuncionario("").Tables[0];
                this.cboFuncionario.DisplayMember = "nome";
                this.cboFuncionario.ValueMember = "Id_Funcionario";
                cboFuncionario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CriarUsuario_Load_1(object sender, EventArgs e)
        {
            // Linhas antigas de TableAdapter comentadas:
            // this.nivelDeAcessoTableAdapter1.Fill(...);
            // this.funcionarioTableAdapter4.Fill(...);
            // this.nivelDeAcessoTableAdapter.Fill(...);

            // 1. Limpa qualquer ligação de dados antiga do comboBox2
            comboBox2.DataSource = null;

            // 2. Preenche com os níveis de acesso manualmente
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Administrador");
            comboBox2.Items.Add("Comum");
            comboBox2.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            BLL.Funcionario func = new BLL.Funcionario();
            switch (operação)
            {

                case 0:


                    if (txtUsuario1.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Usuario não preenchido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.BackColor = Color.NavajoWhite;
                        return;

                    }

                    if (txtSenha.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Senha não preenchido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSenha1.BackColor = Color.NavajoWhite;
                        return;

                    }

                  


                    func.Usuario = this.txtUsuario1.Text.ToString();
                    func.SenhaLogin = this.txtSenha.Text.ToString();
                    func.Id = Convert.ToInt32(cboFuncionario.SelectedValue);
                    func.Idnivelacesso = Convert.ToInt32(comboBox2.SelectedValue);


                    

                    func.incluirLogin();



                    MessageBox.Show("Login Cadastrado");





                    break;
            }

        }
    
        private void button6_Click(object sender, EventArgs e)
        {
            Modelos.Principal pr = new Modelos.Principal();
            pr.Show();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu menu = new Modelos.NovoMenu();
            this.Hide();
            menu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.txtSenha.PasswordChar = '\0';


            }
            else
            {
                this.txtSenha.PasswordChar = '*';
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter4.FillBy(this.cHURRASTRABALHODataSet22.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter4.FillBy1(this.cHURRASTRABALHODataSet22.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
    }

