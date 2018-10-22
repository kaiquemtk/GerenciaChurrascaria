using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH.Fornecedor
{
    public partial class ConsultarFornecedor : Form
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor.txtLogradouro cadastrofornec = new Fornecedor.txtLogradouro();
            cadastrofornec.Show();
        }
    }
}
