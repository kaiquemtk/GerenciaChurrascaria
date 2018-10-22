using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCTH.Estoque
{
    public partial class ConsultarEstoque : Form
    {
        public ConsultarEstoque()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastrarEstoque cad = new CadastrarEstoque();
            
            
        }
    }
}
