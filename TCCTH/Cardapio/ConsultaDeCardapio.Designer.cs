namespace TCCTH.Cardapio
{
    partial class ConsultaDeCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDeCardapio));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Buscar";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(121, 85);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtpesquisar.TabIndex = 29;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(12, 137);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(296, 348);
            this.dgv.TabIndex = 28;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcardapio_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCCTH.Properties.Resources.eraser;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(357, 297);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 73);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::TCCTH.Properties.Resources.add___Copia;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnAdicionar.Location = new System.Drawing.Point(357, 206);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(74, 73);
            this.btnAdicionar.TabIndex = 32;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button3.Location = new System.Drawing.Point(356, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 73);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(385, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 35;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(411, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 34;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cardapio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConsultaDeCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(443, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaDeCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NADA";
            this.Load += new System.EventHandler(this.ConsultaDeCardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Label label2;
    }
}