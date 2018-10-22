using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int Tentativas;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Tentativas++;

                if (Tentativas <= 3)
                {


                    bool resultadoPesquisa = false;
                    BLL.Login objLogin = new BLL.Login();

                    string usuario = txtNome.Text.ToUpper();

                    string senha = txtSenha.Text;



                    objLogin.Nome = usuario;
                    objLogin.Senha = senha;
                    resultadoPesquisa = objLogin.Logar(); if (resultadoPesquisa == true)
                    {
                        Modelos.Principal princip = new Modelos.Principal();
                        princip.Show();
                    }

                }
                else
                {
                            MessageBox.Show("USUÁRIO/SENHA INCORRETO OU VOCÊ NÃO TEM ACESSO AO SISTEMA");
                   // MessageBox.Show("");

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);

            } }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                
                
            }
        }
    }
    }
    
