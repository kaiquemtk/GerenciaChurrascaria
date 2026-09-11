namespace TCCTH.Modelos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroDeFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btncardapio = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cHURRASTRABALHODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHURRASTRABALHODataSet = new TCCTH.CHURRASTRABALHODataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHURRASTRABALHODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHURRASTRABALHODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionarioToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(775, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastroDeFuncionarioToolStripMenuItem
            // 
            this.cadastroDeFuncionarioToolStripMenuItem.AutoSize = false;
            this.cadastroDeFuncionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.cadastroDeFuncionarioToolStripMenuItem.Name = "cadastroDeFuncionarioToolStripMenuItem";
            this.cadastroDeFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.cadastroDeFuncionarioToolStripMenuItem.Text = "Funcionarios";
            this.cadastroDeFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionarioToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.usuarioToolStripMenuItem.Text = "Criar Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.AutoSize = false;
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.vendaToolStripMenuItem.Text = "Fechamento";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem});
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.novaToolStripMenuItem.Text = "Pedido";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastroDeFornecedor});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.estoqueToolStripMenuItem.Text = "Fornecedor";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // CadastroDeFornecedor
            // 
            this.CadastroDeFornecedor.Name = "CadastroDeFornecedor";
            this.CadastroDeFornecedor.Size = new System.Drawing.Size(121, 22);
            this.CadastroDeFornecedor.Text = "Cadastro";
            this.CadastroDeFornecedor.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.produtoToolStripMenuItem.Text = "Estoque";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.produtosToolStripMenuItem.Text = "Produto";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 424);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 102);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackgroundImage = global::TCCTH.Properties.Resources.fornecedor123;
            this.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnFornecedor.Location = new System.Drawing.Point(194, 97);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(112, 103);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TCCTH.Properties.Resources.caixaregistradora;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 93);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackgroundImage = global::TCCTH.Properties.Resources.issosim;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnEstoque.Location = new System.Drawing.Point(579, 30);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(112, 106);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConta
            // 
            this.btnConta.BackColor = System.Drawing.Color.White;
            this.btnConta.BackgroundImage = global::TCCTH.Properties.Resources.Banking_00017_A_icon_icons1;
            this.btnConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.ForeColor = System.Drawing.Color.Black;
            this.btnConta.Location = new System.Drawing.Point(678, 77);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(112, 97);
            this.btnConta.TabIndex = 7;
            this.btnConta.UseVisualStyleBackColor = false;
            this.btnConta.Click += new System.EventHandler(this.button6_Click);
            // 
            // btncardapio
            // 
            this.btncardapio.BackgroundImage = global::TCCTH.Properties.Resources.btnPedidosDeHoje;
            this.btncardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncardapio.Location = new System.Drawing.Point(654, 125);
            this.btncardapio.Name = "btncardapio";
            this.btncardapio.Size = new System.Drawing.Size(136, 183);
            this.btncardapio.TabIndex = 9;
            this.btncardapio.Text = "cardapio";
            this.btncardapio.UseVisualStyleBackColor = true;
            this.btncardapio.Click += new System.EventHandler(this.btncardapio_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.BackColor = System.Drawing.Color.White;
            this.btnproduto.BackgroundImage = global::TCCTH.Properties.Resources.ic_restaurant_menu_128_28738__1_;
            this.btnproduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnproduto.Location = new System.Drawing.Point(547, 227);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(112, 96);
            this.btnproduto.TabIndex = 8;
            this.btnproduto.UseVisualStyleBackColor = false;
            this.btnproduto.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TCCTH.Properties.Resources.exitsim;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(513, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 93);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackgroundImage = global::TCCTH.Properties.Resources.func2;
            this.btnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionario.Location = new System.Drawing.Point(83, 187);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(112, 93);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "6";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.cHURRASTRABALHODataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(312, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cHURRASTRABALHODataSetBindingSource
            // 
            this.cHURRASTRABALHODataSetBindingSource.DataSource = this.cHURRASTRABALHODataSet;
            this.cHURRASTRABALHODataSetBindingSource.Position = 0;
            // 
            // cHURRASTRABALHODataSet
            // 
            this.cHURRASTRABALHODataSet.DataSetName = "CHURRASTRABALHODataSet";
            this.cHURRASTRABALHODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(775, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btncardapio);
            this.Controls.Add(this.btnproduto);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Tan;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHURRASTRABALHODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHURRASTRABALHODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastroDeFornecedor;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        public System.Windows.Forms.Button btnFuncionario;
        public System.Windows.Forms.Button btnFornecedor;
        public System.Windows.Forms.Button btnEstoque;
        public System.Windows.Forms.Button btnConta;
        public System.Windows.Forms.Button btnproduto;
        public System.Windows.Forms.Button btncardapio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cHURRASTRABALHODataSetBindingSource;
        private CHURRASTRABALHODataSet cHURRASTRABALHODataSet;
    }
}