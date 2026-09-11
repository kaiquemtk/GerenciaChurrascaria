using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCCTH.Fechamento
{
    public partial class Caixa : Form
    {

        

        public Caixa(string valor)
        {
            InitializeComponent();
            txtidfuncionario.Text = valor;
            CarregarGrid();
            CarregarGrid2();
            //carregar();
            txtitem.Enabled = false;
            txtvalor.Enabled = false;
            txtidfuncionario.Visible = false;
            txtnumerocomanda.Visible = false;
            txtidcardapio.Visible = false;
            txtPes.Visible = false;
            

            

        }
        public Caixa()
        {
            InitializeComponent();
            CarregarGrid();
            CarregarGrid2();
            txtidcardapio.Visible = false;
            txtitem.Enabled = false;
            txtvalor.Enabled = false;

           // carregar();

        }


        private string valortota;

       

        






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


        private string subtrair;

        public string Subtrair
        {
            get
            {
                return subtrair;
            }

            set
            {
                subtrair = value;
            }
        }

        public string Valortota
        {
            get
            {
                return valortota;
            }

            set
            {
                valortota = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }





        private void CarregarGrid()
        {

            BLL.Pedido pediu = new BLL.Pedido();

            this.dgvlistarcardapio.DataSource = pediu.ListarCardapio(this.txtpesqui.Text.Trim().ToUpper()).Tables[0];



        }

        private void CarregarGrid2()
        {

            BLL.Pedido pediu = new BLL.Pedido();

            this.dgvlistarpedido.DataSource = pediu.ListarPedido(this.txtPes.Text.Trim().ToUpper()).Tables[0];



        }




        //private void carregar() {
           // BLL.Funcionario log = new BLL.Funcionario();
            //SqlDataReader dr;
           // log.IdFuncionario = Convert.ToInt32(txtidfuncionario.Text);
           // dr = log.Consultar();
            //if (dr.Read())
            

            
            //{
               // lblFuncionario.Text = dr["nome"].ToString();


           // }
      //  }
        private void Caixa_Load(object sender, EventArgs e)
        {


            

            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet17.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter1.Fill(this.cHURRASTRABALHODataSet17.Funcionario);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet16.FormaDePagamento' table. You can move, or remove it, as needed.
            this.formaDePagamentoTableAdapter1.Fill(this.cHURRASTRABALHODataSet16.FormaDePagamento);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet15.Cardapio' table. You can move, or remove it, as needed.
            this.cardapioTableAdapter.Fill(this.cHURRASTRABALHODataSet15.Cardapio);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet14.FormaDePagamento' table. You can move, or remove it, as needed.
            this.formaDePagamentoTableAdapter.Fill(this.cHURRASTRABALHODataSet14.FormaDePagamento);
            // TODO: This line of code loads data into the 'cHURRASTRABALHODataSet10.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.cHURRASTRABALHODataSet10.Funcionario);



        }

        
            
        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {
            Modelos.NovoMenu menu = new Modelos.NovoMenu();
            this.Hide();
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BLL.Fechamento fech = new BLL.Fechamento();
            BLL.Fechamento fe = new BLL.Fechamento();
            




            switch (Operação)
            {
                case 0:


                    if (txttotal.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Valor a pagar vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtpago.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Valor pago  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    fech.ValoraPagar = this.txttotal.Text.Replace(",", ".").Replace("R$", "");
                    fech.ValorRecebido = this.txtpago.Text.Replace(",", ".");
                    fech.Troco= this.txttroco.Text.Replace(".", "");
                    fech.CaixaRecebeu = this.txtpagar.Text.Replace(".", ",");

                    fech.IdFuncionario = Convert.ToInt32(cbofuncionario.SelectedValue);

                    
                    


                        fech.RegistrarFechamento();


                    BLL.Fechamento fe123 = new BLL.Fechamento();
                    //dgvlistarpedido.SelectAll();
                    
                    

                    //TODO - percorrer os itens da lista com laço de repetição
                    for(int x = 0; x < dgvlistarpedido.RowCount; x++)
                    {
                        fe123.Idcomanda = Convert.ToInt32(this.dgvlistarpedido.Rows[x].Cells[0].Value);
                        fe123.excluir();
                        
                    }
                    CarregarGrid2();


                    break;


            }
        }


        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtpago_Leave(object sender, EventArgs e)
        {

        }

        private void txtpagar_Enter(object sender, EventArgs e)
        {
            subtrair = Convert.ToString(Convert.ToDouble(txttotal.Text) - (Convert.ToDouble(txtpago.Text)));
            this.txtpagar.Text = subtrair;
        }

        private void txttroco_Click(object sender, EventArgs e)
        {
            if (txtpago.Text == string.Empty)
            {
                MessageBox.Show("Não existe entrada de caixa "); return;
            }
            else
            {
                decimal res = 0;
                decimal positivo = 0;
                decimal negativo = 0;
                positivo = Convert.ToDecimal(txtpago.Text);
                negativo = Convert.ToDecimal(txttotal.Text);
                res = positivo - negativo;
                txttroco.Text = Convert.ToString(res);
            }
        }

        private void txtpagar_Click(object sender, EventArgs e)
        {
            subtrair = Convert.ToString(Convert.ToDecimal(txttotal.Text) - (Convert.ToDecimal(txtpago.Text.Replace(".",""))));
            this.txtpagar.Text = subtrair;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcard_DoubleClick(object sender, EventArgs e)
        {
            txtidcardapio.Text = dgvlistarcardapio.CurrentRow.Cells[0].Value.ToString();
            txtitem.Text = dgvlistarcardapio.CurrentRow.Cells[1].Value.ToString();
            txtvalor.Text = dgvlistarcardapio.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtlimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvlistarcardapio.RowCount; i++)
            {
                dgvlistarcardapio.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            valortota = Convert.ToString(Convert.ToDouble(txtvalor.Text) * (Convert.ToDouble(txtquantidade.Text)));
            this.txtsomado.Text = String.Format("{0, 0:N2}", Convert.ToDouble(valortota));
        }
        
        private void txttotal_Click(object sender, EventArgs e)
        {
            BLL.Pedido pedido = new BLL.Pedido();

            double total = 0;
            foreach (DataGridViewRow row in dgvlistarpedido.Rows)
            {
                total += Convert.ToDouble(row.Cells["Valor"].Value);
            }
            txttotal.Text =String.Format("{0,0:N2}",Convert.ToDouble(total));
           
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {


            BLL.Pedido pedido = new BLL.Pedido();

            switch (Operação)
            {
                case 0:



                    if (txtitem.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Item  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtvalor.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Valor  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtquantidade.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Quantidade  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtsomado.Text == string.Empty)
                    {
                        MessageBox.Show("Campo Valor Unitario  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                   
                    pedido.Quantidade = Convert.ToInt32(this.txtquantidade.Text);
                    pedido.Idfuncionario = Convert.ToInt32(this.cbofuncionario.SelectedValue);
                    pedido.Idcardapio = Convert.ToInt32(this.txtidcardapio.Text);
                    pedido.Idformade = Convert.ToInt32(cboFormadepaga.SelectedValue);
                    pedido.Total = this.txtsomado.Text.Replace(",", ".").Replace("R$", "");
                    
                    





                    // pedido.Horacomand = Convert.ToDateTime(this.txthorario.Text);




                    pedido.IncluirCardapio();



                    CarregarGrid();
                    CarregarGrid2();






                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BLL.Fechamento fe = new BLL.Fechamento();
            fe.IdFuncionario = Convert.ToInt32(this.dgvlistarpedido.CurrentRow.Cells[0].Value);
            fe.excluir();
            CarregarGrid();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dgvlistarpedido.SelectAll();
        }

        private void txtquantidade_Leave(object sender, EventArgs e)
        {

        }

        private void txtsomado_Leave(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Convert.ToDecimal(txttotal.Text);
            Convert.ToDecimal(txtpago.Text);
            Convert.ToDecimal(txtpagar.Text);
            Convert.ToDecimal(txttroco.Text);

            if (Convert.ToDouble(txtpagar.Text)==0)
            {
                if (Convert.ToDecimal(txtpago.Text) >= Convert.ToDecimal(txttotal.Text))
                {
                    txttroco.Text = Convert.ToString(Convert.ToDecimal(txtpago.Text) - Convert.ToDecimal(txttotal.Text));
                    txtpago.Text = "0";
                }
                else if (Convert.ToDecimal(txtpago.Text) < Convert.ToDecimal(txttotal.Text))
                {
                    txtpagar.Text = Convert.ToString(Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtpago.Text));
                    txtpago.Text = "0";
                }
            }
            else
            {
                if (Convert.ToDouble(txtpago.Text)>= Convert.ToDouble(txtpagar.Text))
                {
                    txttroco.Text = Convert.ToString(Convert.ToDouble(txtpago.Text) - Convert.ToDouble(txtpagar.Text));
                    txtpagar.Text = "0";
                    txtpago.Text = "0";
                }
                else if (Convert.ToDouble(txtpago.Text) < Convert.ToDouble(txtpagar.Text))
                {
                    txtpagar.Text = Convert.ToString(Convert.ToDouble(txtpagar.Text) - Convert.ToDouble(txtpago.Text));
                    txtpago.Text = "0";
                }

            }



        }

        private void dgvlistarpedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtidfuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpesqui_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS; Database = CHURRASTRABALHO ;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select * from Cardapio where status_cardap = 1", conn);

            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            DataView dv = new DataView(dt);

            dv.RowFilter = "nome like '" + txtpesqui.Text + "%'";

            dgvlistarcardapio.DataSource = dv;

            conn.Close();
        }
    }
    }
    
