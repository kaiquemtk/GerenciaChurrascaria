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
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha1.Clear();
            txtSenha1.Clear();
        }
    }
}
