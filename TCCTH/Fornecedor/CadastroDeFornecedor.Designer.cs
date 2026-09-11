namespace TCCTH.Fornecedor
{
    partial class CadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFornecedor));
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdFornec = new System.Windows.Forms.TextBox();
            this.txtCep1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(112, 162);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(78, 22);
            this.txtCidade.TabIndex = 0;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(199, 160);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(112, 22);
            this.txtBairro.TabIndex = 1;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(317, 160);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(30, 22);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(30, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 22);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEndereço
            // 
            this.txtEndereço.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereço.Location = new System.Drawing.Point(286, 224);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(165, 22);
            this.txtEndereço.TabIndex = 7;
            this.txtEndereço.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereço_KeyPress);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(462, 224);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(106, 22);
            this.txtComplemento.TabIndex = 8;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComplemento_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(30, 270);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(353, 160);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(29, 22);
            this.txtUF.TabIndex = 11;
            this.txtUF.TextChanged += new System.EventHandler(this.txtUF_TextChanged);
            this.txtUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUF_KeyPress);
            this.txtUF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUF_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(282, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(313, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(108, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(453, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Complemento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(351, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(30, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cep";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(195, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(26, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "CNPJ";
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(174, 223);
            this.txtContato.Mask = "(99) 000-0000";
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(89, 22);
            this.txtContato.TabIndex = 22;
            this.txtContato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContato_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(170, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Contato";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(26, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(30, 223);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(128, 22);
            this.txtCNPJ.TabIndex = 26;
            this.txtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCNPJ_MaskInputRejected);
            this.txtCNPJ.Enter += new System.EventHandler(this.txtCNPJ_Enter);
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.NavajoWhite;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "id";
            // 
            // txtIdFornec
            // 
            this.txtIdFornec.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFornec.Location = new System.Drawing.Point(425, 201);
            this.txtIdFornec.Name = "txtIdFornec";
            this.txtIdFornec.Size = new System.Drawing.Size(78, 22);
            this.txtIdFornec.TabIndex = 35;
            // 
            // txtCep1
            // 
            this.txtCep1.Location = new System.Drawing.Point(30, 162);
            this.txtCep1.Mask = "00000-000";
            this.txtCep1.Name = "txtCep1";
            this.txtCep1.Size = new System.Drawing.Size(63, 20);
            this.txtCep1.TabIndex = 37;
            this.txtCep1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep1_KeyPress);
            this.txtCep1.Leave += new System.EventHandler(this.txtCep1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 262);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TCCTH.Properties.Resources.back;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button3.Location = new System.Drawing.Point(546, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TCCTH.Properties.Resources.eraser;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button2.Location = new System.Drawing.Point(457, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 74);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TCCTH.Properties.Resources.save;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button1.Location = new System.Drawing.Point(375, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 74);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(575, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 40;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(601, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 20);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 39;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(27, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 18);
            this.label14.TabIndex = 41;
            this.label14.Text = "Cadastro de Fornecedor";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(633, 401);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.txtCep1);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdFornec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Fornecedor";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtEndereço;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtUF;
        public System.Windows.Forms.MaskedTextBox txtContato;
        public System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtIdFornec;
        public System.Windows.Forms.MaskedTextBox txtCep1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Label label14;
    }
}