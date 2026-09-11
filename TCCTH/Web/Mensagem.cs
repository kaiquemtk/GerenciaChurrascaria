using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TCCTH.Web
{
    public partial class Mensagem : Form
    {
        public Mensagem()
        {
            InitializeComponent();
            txtAssunto.Enabled = false;
        }


        private Int32 codigo;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
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

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void CarregarCampos(object o, EventArgs e)
        {
            try
            {

                // CarregarCampos();


                if (Operação != Convert.ToByte(BLL.Funcoesgerais.Operação.Inclusao))
                {
                    BLL.Web web = new BLL.Web();
                    SqlDataReader dr;

                    web.Idcontato = codigo;
                    dr = web.Consultar();

                    if (dr.Read())
                    {
                        this.txtNome1.Text = dr["nome"].ToString();
                        this.txtemail.Text = dr["email"].ToString();
                        this.txtmensagem.Text = dr["mensagem"].ToString();
                        this.txtAssunto.Text = dr["assunto"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Web.ConsultarFale cons = new Web.ConsultarFale();
            this.Hide();
            cons.Show();
        }
    }
        
    
}
