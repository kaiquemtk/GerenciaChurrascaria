namespace TCCTH.Produto
{
    partial class ConsultarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProdutos));
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesquisaprod = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproduto
            // 
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Location = new System.Drawing.Point(12, 125);
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.Size = new System.Drawing.Size(609, 189);
            this.dgvproduto.TabIndex = 0;
            this.dgvproduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduto_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Produto";
            // 
            // txtpesquisaprod
            // 
            this.txtpesquisaprod.Location = new System.Drawing.Point(321, 62);
            this.txtpesquisaprod.Name = "txtpesquisaprod";
            this.txtpesquisaprod.Size = new System.Drawing.Size(108, 20);
            this.txtpesquisaprod.TabIndex = 5;
            this.txtpesquisaprod.TextChanged += new System.EventHandler(this.txtpesquisaprod_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TCCTH.Properties.Resources.power_icon_icons_com_53620__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.button3.Location = new System.Drawing.Point(449, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 70);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.button2.Location = new System.Drawing.Point(546, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TCCTH.Properties.Resources.add___Copia;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Location = new System.Drawing.Point(366, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 70);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(578, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 37;
            this.Minimizar.TabStop = false;
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(604, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 36;
            this.Fechar.TabStop = false;
            // 
            // ConsultarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(633, 401);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.txtpesquisaprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProdutos";
            this.Load += new System.EventHandler(this.ConsultarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesquisaprod;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
    }
}