using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH.Web
{
    public partial class ConsultarFale : Form
    {
        public ConsultarFale()
        {
            InitializeComponent();
            CarregarGrid();
            btnEditar.Visible = false;
        }



        
        private void CarregarGrid()
        {

            BLL.Web web = new BLL.Web();

            this.dgvForn.DataSource = web.ListarFale(this.txtPesquisarForn.Text.Trim().ToUpper()).Tables[0];

        }

        private void ConsultarFale_Load(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Web.Mensagem func = new Mensagem();
            if (sender == this.btnEditar || sender == this.btnPesquisar)
            {
                func.Codigo = Convert.ToInt32(this.dgvForn.CurrentRow.Cells[0].Value);
                func.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Alteracao);
                
               
                func.Show();
                func.Text = "Alterar";
                {

                    func.txtNome1.Enabled = false;
                    func.txtmensagem.Enabled = false;
                    func.txtemail.Enabled = false;
                    
                    
                    func.Operação = Convert.ToByte(BLL.Funcoesgerais.Operação.Consulta);
                    func.Text = "Consultar Mensagem";
                



                }
            }

            // var b = (Button)sender;
            //func.Size = new System.Drawing.Size(914, 725);
            this.Hide();
            func.Show();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu men = new Modelos.NovoMenu();
            this.Hide();
            men.Show();
        }
    }
}
