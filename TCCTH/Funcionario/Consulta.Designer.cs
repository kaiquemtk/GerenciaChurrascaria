namespace TCCTH.Funcionario
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.txtPesquisarFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisarFunc
            // 
            this.txtPesquisarFunc.Location = new System.Drawing.Point(310, 77);
            this.txtPesquisarFunc.Name = "txtPesquisarFunc";
            this.txtPesquisarFunc.Size = new System.Drawing.Size(110, 20);
            this.txtPesquisarFunc.TabIndex = 0;
            this.txtPesquisarFunc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Funcionario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 134);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(658, 185);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TCCTH.Properties.Resources.eraser;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button5.Location = new System.Drawing.Point(439, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 76);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::TCCTH.Properties.Resources.search1;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnPesquisar.Location = new System.Drawing.Point(214, 368);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 76);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TCCTH.Properties.Resources.edit___Copia;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEditar.Location = new System.Drawing.Point(320, 368);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 76);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TCCTH.Properties.Resources.add___Copia;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button2.Location = new System.Drawing.Point(89, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 76);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(586, 368);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 76);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(608, 12);
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
            this.Fechar.Location = new System.Drawing.Point(647, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 36;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(239, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Consultar Funcionario";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(682, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisarFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisarFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Label label2;
    }
}