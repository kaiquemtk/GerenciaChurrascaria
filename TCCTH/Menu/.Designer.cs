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
            this.button1 = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.txtidlogin = new System.Windows.Forms.TextBox();
            this.txtidlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.Fechar);
            this.MenuVertical.Controls.Add(this.Minimizar);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.btnConta);
            this.MenuVertical.Controls.Add(this.btnFornecedor);
            this.MenuVertical.Controls.Add(this.btnEstoque);
            this.MenuVertical.Controls.Add(this.btnFuncionario);
            this.MenuVertical.Controls.Add(this.txtidlogin);
            this.MenuVertical.Controls.Add(this.txtidlog);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(1184, 579);
            this.MenuVertical.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "  Criar usuario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.btnConta.Location = new System.Drawing.Point(-2, 448);
            this.btnConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(350, 68);
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
            this.btnFornecedor.Location = new System.Drawing.Point(0, 249);
            this.btnFornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(350, 80);
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
            this.btnEstoque.Location = new System.Drawing.Point(0, 357);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(352, 72);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.button3_Click);
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
            this.btnFuncionario.Location = new System.Drawing.Point(-2, 78);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(356, 72);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionarios";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidlogin
            // 
            this.txtidlogin.Location = new System.Drawing.Point(94, 471);
            this.txtidlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidlogin.Multiline = true;
            this.txtidlogin.Name = "txtidlogin";
            this.txtidlogin.Size = new System.Drawing.Size(30, 38);
            this.txtidlogin.TabIndex = 3;
            // 
            // txtidlog
            // 
            this.txtidlog.Location = new System.Drawing.Point(165, 480);
            this.txtidlog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidlog.Multiline = true;
            this.txtidlog.Name = "txtidlog";
            this.txtidlog.Size = new System.Drawing.Size(30, 29);
            this.txtidlog.TabIndex = 2;
            this.txtidlog.TextChanged += new System.EventHandler(this.txtidlog_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(413, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 173);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1062, 448);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 110);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1101, 5);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 31);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 24;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click_1);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(1139, 5);
            this.Fechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(30, 31);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 25;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click_1);
            // 
            // NovoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1191, 579);
            this.Controls.Add(this.MenuVertical);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPÉRIO";
            this.Load += new System.EventHandler(this.NovoMenu_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        public System.Windows.Forms.TextBox txtidlog;
        public System.Windows.Forms.TextBox txtidlogin;
        public System.Windows.Forms.Button btnFuncionario;
        public System.Windows.Forms.Button btnConta;
        public System.Windows.Forms.Button btnFornecedor;
        public System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
    }
}