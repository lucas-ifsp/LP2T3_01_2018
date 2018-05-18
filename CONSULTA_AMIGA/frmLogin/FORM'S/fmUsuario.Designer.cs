namespace frmLogin
{
    partial class fmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmUsuario));
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.btnUsuarioCancelar = new System.Windows.Forms.Button();
            this.labelUsuarioNovaSenha = new System.Windows.Forms.Label();
            this.btnUsuarioAlterar = new System.Windows.Forms.Button();
            this.textUsuarioNovaSenha = new System.Windows.Forms.TextBox();
            this.labelUsuarioPerguntaSecreta = new System.Windows.Forms.Label();
            this.textUsuarioPerguntaSecreta = new System.Windows.Forms.TextBox();
            this.labelUsuarioSenhaAtual = new System.Windows.Forms.Label();
            this.textUsuarioSenhaAtual = new System.Windows.Forms.TextBox();
            this.lbDoacaoDoador = new System.Windows.Forms.Label();
            this.panelUsuario.SuspendLayout();
            this.groupBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUsuario.Controls.Add(this.groupBoxUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(12, 12);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(388, 331);
            this.panelUsuario.TabIndex = 0;
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxUsuario.Controls.Add(this.btnUsuarioCancelar);
            this.groupBoxUsuario.Controls.Add(this.labelUsuarioNovaSenha);
            this.groupBoxUsuario.Controls.Add(this.btnUsuarioAlterar);
            this.groupBoxUsuario.Controls.Add(this.textUsuarioNovaSenha);
            this.groupBoxUsuario.Controls.Add(this.labelUsuarioPerguntaSecreta);
            this.groupBoxUsuario.Controls.Add(this.textUsuarioPerguntaSecreta);
            this.groupBoxUsuario.Controls.Add(this.labelUsuarioSenhaAtual);
            this.groupBoxUsuario.Controls.Add(this.textUsuarioSenhaAtual);
            this.groupBoxUsuario.Controls.Add(this.lbDoacaoDoador);
            this.groupBoxUsuario.Location = new System.Drawing.Point(18, 22);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(351, 278);
            this.groupBoxUsuario.TabIndex = 0;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Alterar Senha";
            // 
            // btnUsuarioCancelar
            // 
            this.btnUsuarioCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsuarioCancelar.Location = new System.Drawing.Point(181, 202);
            this.btnUsuarioCancelar.Name = "btnUsuarioCancelar";
            this.btnUsuarioCancelar.Size = new System.Drawing.Size(111, 59);
            this.btnUsuarioCancelar.TabIndex = 5;
            this.btnUsuarioCancelar.Text = "Cancelar";
            this.btnUsuarioCancelar.UseVisualStyleBackColor = true;
            this.btnUsuarioCancelar.Click += new System.EventHandler(this.btnUsuarioCancelar_Click);
            // 
            // labelUsuarioNovaSenha
            // 
            this.labelUsuarioNovaSenha.AutoSize = true;
            this.labelUsuarioNovaSenha.Location = new System.Drawing.Point(18, 75);
            this.labelUsuarioNovaSenha.Name = "labelUsuarioNovaSenha";
            this.labelUsuarioNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.labelUsuarioNovaSenha.TabIndex = 47;
            this.labelUsuarioNovaSenha.Text = "Nova Senha";
            // 
            // btnUsuarioAlterar
            // 
            this.btnUsuarioAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsuarioAlterar.Location = new System.Drawing.Point(54, 202);
            this.btnUsuarioAlterar.Name = "btnUsuarioAlterar";
            this.btnUsuarioAlterar.Size = new System.Drawing.Size(111, 59);
            this.btnUsuarioAlterar.TabIndex = 4;
            this.btnUsuarioAlterar.Text = "Alterar";
            this.btnUsuarioAlterar.UseVisualStyleBackColor = true;
            this.btnUsuarioAlterar.Click += new System.EventHandler(this.btnUsuarioAlterar_Click);
            // 
            // textUsuarioNovaSenha
            // 
            this.textUsuarioNovaSenha.Location = new System.Drawing.Point(21, 91);
            this.textUsuarioNovaSenha.Name = "textUsuarioNovaSenha";
            this.textUsuarioNovaSenha.PasswordChar = '•';
            this.textUsuarioNovaSenha.Size = new System.Drawing.Size(307, 20);
            this.textUsuarioNovaSenha.TabIndex = 2;
            // 
            // labelUsuarioPerguntaSecreta
            // 
            this.labelUsuarioPerguntaSecreta.AutoSize = true;
            this.labelUsuarioPerguntaSecreta.Location = new System.Drawing.Point(18, 126);
            this.labelUsuarioPerguntaSecreta.Name = "labelUsuarioPerguntaSecreta";
            this.labelUsuarioPerguntaSecreta.Size = new System.Drawing.Size(90, 13);
            this.labelUsuarioPerguntaSecreta.TabIndex = 45;
            this.labelUsuarioPerguntaSecreta.Text = "Pergunta Secreta";
            // 
            // textUsuarioPerguntaSecreta
            // 
            this.textUsuarioPerguntaSecreta.Location = new System.Drawing.Point(21, 142);
            this.textUsuarioPerguntaSecreta.Name = "textUsuarioPerguntaSecreta";
            this.textUsuarioPerguntaSecreta.Size = new System.Drawing.Size(307, 20);
            this.textUsuarioPerguntaSecreta.TabIndex = 3;
            // 
            // labelUsuarioSenhaAtual
            // 
            this.labelUsuarioSenhaAtual.AutoSize = true;
            this.labelUsuarioSenhaAtual.Location = new System.Drawing.Point(18, 25);
            this.labelUsuarioSenhaAtual.Name = "labelUsuarioSenhaAtual";
            this.labelUsuarioSenhaAtual.Size = new System.Drawing.Size(65, 13);
            this.labelUsuarioSenhaAtual.TabIndex = 43;
            this.labelUsuarioSenhaAtual.Text = "Senha Atual";
            // 
            // textUsuarioSenhaAtual
            // 
            this.textUsuarioSenhaAtual.Location = new System.Drawing.Point(21, 41);
            this.textUsuarioSenhaAtual.Name = "textUsuarioSenhaAtual";
            this.textUsuarioSenhaAtual.PasswordChar = '•';
            this.textUsuarioSenhaAtual.Size = new System.Drawing.Size(307, 20);
            this.textUsuarioSenhaAtual.TabIndex = 1;
            // 
            // lbDoacaoDoador
            // 
            this.lbDoacaoDoador.AutoSize = true;
            this.lbDoacaoDoador.Location = new System.Drawing.Point(12, 36);
            this.lbDoacaoDoador.Name = "lbDoacaoDoador";
            this.lbDoacaoDoador.Size = new System.Drawing.Size(0, 13);
            this.lbDoacaoDoador.TabIndex = 41;
            // 
            // fmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(410, 355);
            this.Controls.Add(this.panelUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmUsuario";
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.fmUsuario_Load);
            this.panelUsuario.ResumeLayout(false);
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.TextBox textUsuarioSenhaAtual;
        private System.Windows.Forms.Label lbDoacaoDoador;
        private System.Windows.Forms.Button btnUsuarioAlterar;
        private System.Windows.Forms.Label labelUsuarioPerguntaSecreta;
        private System.Windows.Forms.TextBox textUsuarioPerguntaSecreta;
        private System.Windows.Forms.Label labelUsuarioSenhaAtual;
        private System.Windows.Forms.Button btnUsuarioCancelar;
        private System.Windows.Forms.Label labelUsuarioNovaSenha;
        private System.Windows.Forms.TextBox textUsuarioNovaSenha;
    }
}