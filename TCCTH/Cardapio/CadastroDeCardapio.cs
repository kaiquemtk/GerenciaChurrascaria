using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH.Cardapio
{
    public partial class CadastroDeCardapio : Form
    {
        public CadastroDeCardapio()
        {
            InitializeComponent();
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






        private void button2_Click(object sender, EventArgs e)
        {
            Cardapio.ConsultaDeCardapio ca = new Cardapio.ConsultaDeCardapio();
            this.Hide();
            ca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Cardapio cardap = new BLL.Cardapio();
           
            switch (Operação)
            {





                case 0:


                    if (txtnome.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtdesc.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Descrição vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtvalor.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Valor vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }










                    cardap.Nome = this.txtnome.Text.ToString();
                    cardap.Desc = this.txtdesc.Text.ToString();
                    cardap.Valor = this.txtvalor.Text.Replace(",",".");

                    





                        cardap.IncluirCardapio();
                    


                    MessageBox.Show("Item Cadastrado");


                    break;
            }
        }

        private void CadastroDeCardapio_Load(object sender, EventArgs e)
        {

        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
