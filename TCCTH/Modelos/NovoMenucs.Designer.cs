namespace TCCTH.Modelos
{
    partial class NovoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoMenu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.txtidlogin = new System.Windows.Forms.TextBox();
            this.txtidlog = new System.Windows.Forms.TextBox();
            this.MenuDeCima = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncardapio = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.MenuDeCima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.btncardapio);
            this.MenuVertical.Controls.Add(this.btnConta);
            this.MenuVertical.Controls.Add(this.btnFornecedor);
            this.MenuVertical.Controls.Add(this.btnEstoque);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btnFuncionario);
            this.MenuVertical.Controls.Add(this.txtidlogin);
            this.MenuVertical.Controls.Add(this.txtidlog);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(51, 486);
            this.MenuVertical.TabIndex = 0;
            // 
            // txtidlogin
            // 
            this.txtidlogin.Location = new System.Drawing.Point(12, 131);
            this.txtidlogin.Multiline = true;
            this.txtidlogin.Name = "txtidlogin";
            this.txtidlogin.Size = new System.Drawing.Size(21, 26);
            this.txtidlogin.TabIndex = 3;
            // 
            // txtidlog
            // 
            this.txtidlog.Location = new System.Drawing.Point(27, 183);
            this.txtidlog.Multiline = true;
            this.txtidlog.Name = "txtidlog";
            this.txtidlog.Size = new System.Drawing.Size(21, 20);
            this.txtidlog.TabIndex = 2;
            // 
            // MenuDeCima
            // 
            this.MenuDeCima.Controls.Add(this.Minimizar);
            this.MenuDeCima.Controls.Add(this.Restaurar);
            this.MenuDeCima.Controls.Add(this.Maximizar);
            this.MenuDeCima.Controls.Add(this.Fechar);
            this.MenuDeCima.Controls.Add(this.pictureBox1);
            this.MenuDeCima.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuDeCima.Location = new System.Drawing.Point(51, 0);
            this.MenuDeCima.Name = "MenuDeCima";
            this.MenuDeCima.Size = new System.Drawing.Size(762, 44);
            this.MenuDeCima.TabIndex = 1;
            this.MenuDeCima.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuDeCima_Paint);
            this.MenuDeCima.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuDeCima_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(233, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 115);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo";
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackgroundImage = global::TCCTH.Properties.Resources.ae12ae;
            this.btnMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensagem.Location = new System.Drawing.Point(726, 394);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(75, 70);
            this.btnMensagem.TabIndex = 4;
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(731, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 61);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(680, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 5;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(706, 3);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(20, 20);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 2;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(706, 3);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(20, 20);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(732, 3);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 4;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Criar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btncardapio
            // 
            this.btncardapio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncardapio.FlatAppearance.BorderSize = 0;
            this.btncardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncardapio.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncardapio.ForeColor = System.Drawing.Color.White;
            this.btncardapio.Image = ((System.Drawing.Image)(resources.GetObject("btncardapio.Image")));
            this.btncardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncardapio.Location = new System.Drawing.Point(3, 404);
            this.btncardapio.Name = "btncardapio";
            this.btncardapio.Size = new System.Drawing.Size(178, 48);
            this.btncardapio.TabIndex = 7;
            this.btncardapio.Text = "Cardapio";
            this.btncardapio.UseVisualStyleBackColor = true;
            this.btncardapio.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnConta
            // 
            this.btnConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConta.FlatAppearance.BorderSize = 0;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.ForeColor = System.Drawing.Color.White;
            this.btnConta.Image = ((System.Drawing.Image)(resources.GetObject("btnConta.Image")));
            this.btnConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConta.Location = new System.Drawing.Point(3, 357);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(164, 41);
            this.btnConta.TabIndex = 4;
            this.btnConta.Text = "Contas";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.Location = new System.Drawing.Point(3, 265);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(197, 41);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(3, 312);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(175, 41);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Caixa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(3, 171);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(215, 41);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionarios";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // NovoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(813, 486);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuDeCima);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.NovoMenu_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.MenuDeCima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel MenuDeCima;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Minimizar;
        public System.Windows.Forms.TextBox txtidlog;
        public System.Windows.Forms.TextBox txtidlogin;
        public System.Windows.Forms.Button btnFuncionario;
        public System.Windows.Forms.Button btnConta;
        public System.Windows.Forms.Button btnFornecedor;
        public System.Windows.Forms.Button btnEstoque;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btncardapio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMensagem;
    }
}