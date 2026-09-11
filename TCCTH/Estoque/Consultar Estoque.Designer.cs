namespace TCCTH.Estoque
{
    partial class ConsultarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEstoque));
            this.dgvestoqu = new System.Windows.Forms.DataGridView();
            this.txtpesqest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestoqu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvestoqu
            // 
            this.dgvestoqu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvestoqu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestoqu.Location = new System.Drawing.Point(12, 98);
            this.dgvestoqu.Name = "dgvestoqu";
            this.dgvestoqu.Size = new System.Drawing.Size(658, 225);
            this.dgvestoqu.TabIndex = 15;
            this.dgvestoqu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtpesqest
            // 
            this.txtpesqest.Location = new System.Drawing.Point(313, 46);
            this.txtpesqest.Name = "txtpesqest";
            this.txtpesqest.Size = new System.Drawing.Size(120, 20);
            this.txtpesqest.TabIndex = 16;
            this.txtpesqest.TextChanged += new System.EventHandler(this.txtpesqest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(166, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar Produto";
            // 
            // btnSair1
            // 
            this.btnSair1.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.btnSair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnSair1.Location = new System.Drawing.Point(591, 374);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(79, 73);
            this.btnSair1.TabIndex = 14;
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCCTH.Properties.Resources.eraser;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(457, 374);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 71);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TCCTH.Properties.Resources.edit___Copia;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEditar.Location = new System.Drawing.Point(330, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 73);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::TCCTH.Properties.Resources.search1;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnPesquisar.Location = new System.Drawing.Point(198, 372);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 73);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::TCCTH.Properties.Resources.add___Copia;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnAdicionar.Location = new System.Drawing.Point(67, 370);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(73, 73);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(509, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 37;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(570, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 36;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // ConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(682, 456);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpesqest);
            this.Controls.Add(this.dgvestoqu);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "ConsultarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Estoque";
            this.Load += new System.EventHandler(this.ConsultarEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestoqu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvestoqu;
        private System.Windows.Forms.TextBox txtpesqest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
    }
}