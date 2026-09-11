namespace TCCTH.Web
{
    partial class ConsultarFale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFale));
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarForn = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
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
            this.dgvForn.Location = new System.Drawing.Point(11, 116);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.Size = new System.Drawing.Size(539, 210);
            this.dgvForn.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar Data";
            // 
            // txtPesquisarForn
            // 
            this.txtPesquisarForn.Location = new System.Drawing.Point(243, 38);
            this.txtPesquisarForn.Name = "txtPesquisarForn";
            this.txtPesquisarForn.Size = new System.Drawing.Size(120, 20);
            this.txtPesquisarForn.TabIndex = 41;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(115, 344);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCCTH.Properties.Resources.eraser;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(243, 355);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 73);
            this.btnExcluir.TabIndex = 45;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSair1
            // 
            this.btnSair1.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.btnSair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnSair1.Location = new System.Drawing.Point(489, 359);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(77, 73);
            this.btnSair1.TabIndex = 44;
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::TCCTH.Properties.Resources.search1;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnPesquisar.Location = new System.Drawing.Point(384, 355);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 73);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(520, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 39;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(546, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 38;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // ConsultarFale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(584, 444);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisarForn);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarFale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarFale";
            this.Load += new System.EventHandler(this.ConsultarFale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisarForn;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
    }
}