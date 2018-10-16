namespace Whatever_Music
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.ESenha = new System.Windows.Forms.LinkLabel();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Alba Super", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Whatever Music\'s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(102, 162);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(102, 260);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(203, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // ESenha
            // 
            this.ESenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ESenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ESenha.AutoSize = true;
            this.ESenha.Font = new System.Drawing.Font("Alba", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESenha.Location = new System.Drawing.Point(12, 519);
            this.ESenha.Name = "ESenha";
            this.ESenha.Size = new System.Drawing.Size(96, 21);
            this.ESenha.TabIndex = 3;
            this.ESenha.TabStop = true;
            this.ESenha.Text = "Esqueci a Senha";
            // 
            // txtCSenha
            // 
            this.txtCSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCSenha.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSenha.Location = new System.Drawing.Point(102, 336);
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.PasswordChar = '*';
            this.txtCSenha.Size = new System.Drawing.Size(203, 23);
            this.txtCSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(74)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(136)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Alba", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrar.Location = new System.Drawing.Point(143, 422);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(127, 44);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alba Super", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Alba Super", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Alba Super", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(200)))), ((int)(((byte)(74)))));
            this.BackgroundImage = global::Whatever_Music.Properties.Resources.Fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtCSenha);
            this.Controls.Add(this.ESenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.LinkLabel ESenha;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

