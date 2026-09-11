namespace TCCTH.Fornecedor
{
    partial class ConsultarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFornecedor));
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.txtPesquisarForn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForn
            // 
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Location = new System.Drawing.Point(18, 152);
            this.dgvForn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.RowHeadersWidth = 62;
            this.dgvForn.Size = new System.Drawing.Size(975, 323);
            this.dgvForn.TabIndex = 0;
            this.dgvForn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellContentClick);
            // 
            // txtPesquisarForn
            // 
            this.txtPesquisarForn.Location = new System.Drawing.Point(405, 42);
            this.txtPesquisarForn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisarForn.Name = "txtPesquisarForn";
            this.txtPesquisarForn.Size = new System.Drawing.Size(178, 26);
            this.txtPesquisarForn.TabIndex = 1;
            this.txtPesquisarForn.TextChanged += new System.EventHandler(this.txtPesquisarForn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar Fornecedor";
            // 
            // btnSair1
            // 
            this.btnSair1.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.btnSair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnSair1.Location = new System.Drawing.Point(878, 557);
            this.btnSair1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(116, 112);
            this.btnSair1.TabIndex = 9;
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCCTH.Properties.Resources.eraser;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(656, 557);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 112);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TCCTH.Properties.Resources.edit___Copia;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEditar.Location = new System.Drawing.Point(468, 557);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 112);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::TCCTH.Properties.Resources.search1;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnPesquisar.Location = new System.Drawing.Point(300, 557);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 112);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::TCCTH.Properties.Resources.add___Copia;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnAdicionar.Location = new System.Drawing.Point(123, 557);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 112);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(878, 18);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 31);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 37;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(916, 18);
            this.Fechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(30, 31);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 36;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // ConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1023, 702);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPesquisarForn);
            this.Controls.Add(this.dgvForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fornecedor";
            this.Load += new System.EventHandler(this.ConsultarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.TextBox txtPesquisarForn;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
    }
}