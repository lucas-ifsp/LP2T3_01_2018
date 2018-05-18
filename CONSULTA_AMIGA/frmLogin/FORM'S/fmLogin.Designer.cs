namespace frmLogin
{
    partial class fmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelMenuPergunta = new System.Windows.Forms.Panel();
            this.labelLoginVoltar = new System.Windows.Forms.Label();
            this.btnLoginVoltar = new System.Windows.Forms.Button();
            this.labelLonginPerguntaSecreta = new System.Windows.Forms.Label();
            this.textBoxLoginPergunta = new System.Windows.Forms.TextBox();
            this.linkLabelLoginEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnLoginCancelar = new System.Windows.Forms.Button();
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelMenuPergunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLogin.Controls.Add(this.panelMenuPergunta);
            this.panelLogin.Controls.Add(this.linkLabelLoginEsqueceuSenha);
            this.panelLogin.Controls.Add(this.labelLoginSenha);
            this.panelLogin.Controls.Add(this.txtSenhaLogin);
            this.panelLogin.Controls.Add(this.btnLoginCancelar);
            this.panelLogin.Controls.Add(this.btnLoginEntrar);
            this.panelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLogin.Location = new System.Drawing.Point(12, 16);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(239, 230);
            this.panelLogin.TabIndex = 0;
            // 
            // panelMenuPergunta
            // 
            this.panelMenuPergunta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuPergunta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMenuPergunta.Controls.Add(this.labelLoginVoltar);
            this.panelMenuPergunta.Controls.Add(this.btnLoginVoltar);
            this.panelMenuPergunta.Controls.Add(this.labelLonginPerguntaSecreta);
            this.panelMenuPergunta.Controls.Add(this.textBoxLoginPergunta);
            this.panelMenuPergunta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMenuPergunta.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPergunta.Name = "panelMenuPergunta";
            this.panelMenuPergunta.Size = new System.Drawing.Size(239, 230);
            this.panelMenuPergunta.TabIndex = 5;
            // 
            // labelLoginVoltar
            // 
            this.labelLoginVoltar.AutoSize = true;
            this.labelLoginVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLoginVoltar.Location = new System.Drawing.Point(12, 162);
            this.labelLoginVoltar.Name = "labelLoginVoltar";
            this.labelLoginVoltar.Size = new System.Drawing.Size(34, 13);
            this.labelLoginVoltar.TabIndex = 47;
            this.labelLoginVoltar.Text = "Voltar";
            // 
            // btnLoginVoltar
            // 
            this.btnLoginVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginVoltar.BackgroundImage")));
            this.btnLoginVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginVoltar.Location = new System.Drawing.Point(3, 178);
            this.btnLoginVoltar.Name = "btnLoginVoltar";
            this.btnLoginVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnLoginVoltar.TabIndex = 45;
            this.btnLoginVoltar.UseVisualStyleBackColor = true;
            this.btnLoginVoltar.Click += new System.EventHandler(this.btnSaldoVoltar_Click);
            // 
            // labelLonginPerguntaSecreta
            // 
            this.labelLonginPerguntaSecreta.AutoSize = true;
            this.labelLonginPerguntaSecreta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLonginPerguntaSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLonginPerguntaSecreta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLonginPerguntaSecreta.Location = new System.Drawing.Point(12, 52);
            this.labelLonginPerguntaSecreta.Name = "labelLonginPerguntaSecreta";
            this.labelLonginPerguntaSecreta.Size = new System.Drawing.Size(122, 18);
            this.labelLonginPerguntaSecreta.TabIndex = 1;
            this.labelLonginPerguntaSecreta.Text = "Pergunta Secreta";
            // 
            // textBoxLoginPergunta
            // 
            this.textBoxLoginPergunta.Enabled = false;
            this.textBoxLoginPergunta.Location = new System.Drawing.Point(15, 74);
            this.textBoxLoginPergunta.Multiline = true;
            this.textBoxLoginPergunta.Name = "textBoxLoginPergunta";
            this.textBoxLoginPergunta.Size = new System.Drawing.Size(214, 39);
            this.textBoxLoginPergunta.TabIndex = 0;
            this.textBoxLoginPergunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabelLoginEsqueceuSenha
            // 
            this.linkLabelLoginEsqueceuSenha.AutoSize = true;
            this.linkLabelLoginEsqueceuSenha.Location = new System.Drawing.Point(122, 58);
            this.linkLabelLoginEsqueceuSenha.Name = "linkLabelLoginEsqueceuSenha";
            this.linkLabelLoginEsqueceuSenha.Size = new System.Drawing.Size(104, 13);
            this.linkLabelLoginEsqueceuSenha.TabIndex = 4;
            this.linkLabelLoginEsqueceuSenha.TabStop = true;
            this.linkLabelLoginEsqueceuSenha.Text = "Esqueceu a Senha?";
            this.linkLabelLoginEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLoginSenha.Location = new System.Drawing.Point(24, 34);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(54, 18);
            this.labelLoginSenha.TabIndex = 1;
            this.labelLoginSenha.Text = "Senha:";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(84, 35);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '•';
            this.txtSenhaLogin.Size = new System.Drawing.Size(142, 20);
            this.txtSenhaLogin.TabIndex = 0;
            this.txtSenhaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoginCancelar
            // 
            this.btnLoginCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoginCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginCancelar.Location = new System.Drawing.Point(74, 153);
            this.btnLoginCancelar.Name = "btnLoginCancelar";
            this.btnLoginCancelar.Size = new System.Drawing.Size(91, 42);
            this.btnLoginCancelar.TabIndex = 3;
            this.btnLoginCancelar.Text = "Cancelar";
            this.btnLoginCancelar.UseVisualStyleBackColor = false;
            this.btnLoginCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoginEntrar.Location = new System.Drawing.Point(74, 105);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(91, 42);
            this.btnLoginEntrar.TabIndex = 2;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = true;
            this.btnLoginEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmLogin
            // 
            this.AcceptButton = this.btnLoginEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(263, 255);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "fmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fmLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelMenuPergunta.ResumeLayout(false);
            this.panelMenuPergunta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLoginEntrar;
        private System.Windows.Forms.Label labelLoginSenha;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnLoginCancelar;
        private System.Windows.Forms.LinkLabel linkLabelLoginEsqueceuSenha;
        private System.Windows.Forms.Panel panelMenuPergunta;
        private System.Windows.Forms.Label labelLonginPerguntaSecreta;
        private System.Windows.Forms.TextBox textBoxLoginPergunta;
        private System.Windows.Forms.Button btnLoginVoltar;
        private System.Windows.Forms.Label labelLoginVoltar;
    }
}

