namespace Aula_6_em_Diante_Continuo
{
    partial class formPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcervo = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmprestimo = new System.Windows.Forms.ToolStripMenuItem();
            this.miDevolucao = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistoricoLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistoricoUsuário = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.emprestimoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAcervo,
            this.miUsuario});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // miAcervo
            // 
            this.miAcervo.Name = "miAcervo";
            this.miAcervo.Size = new System.Drawing.Size(140, 26);
            this.miAcervo.Text = "Acervo";
            this.miAcervo.Click += new System.EventHandler(this.miAcervo_Click);
            // 
            // miUsuario
            // 
            this.miUsuario.Name = "miUsuario";
            this.miUsuario.Size = new System.Drawing.Size(140, 26);
            this.miUsuario.Text = "Usuários";
            this.miUsuario.Click += new System.EventHandler(this.miUsuario_Click);
            // 
            // emprestimoToolStripMenuItem
            // 
            this.emprestimoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmprestimo,
            this.miDevolucao,
            this.miHistorico});
            this.emprestimoToolStripMenuItem.Name = "emprestimoToolStripMenuItem";
            this.emprestimoToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.emprestimoToolStripMenuItem.Text = "Empréstimo";
            // 
            // miEmprestimo
            // 
            this.miEmprestimo.Name = "miEmprestimo";
            this.miEmprestimo.Size = new System.Drawing.Size(204, 26);
            this.miEmprestimo.Text = "Novo Empréstimo";
            this.miEmprestimo.Click += new System.EventHandler(this.miEmprestimo_Click);
            // 
            // miDevolucao
            // 
            this.miDevolucao.Name = "miDevolucao";
            this.miDevolucao.Size = new System.Drawing.Size(204, 26);
            this.miDevolucao.Text = "Devolução";
            this.miDevolucao.Click += new System.EventHandler(this.miDevolucao_Click);
            // 
            // miHistorico
            // 
            this.miHistorico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHistoricoLivro,
            this.miHistoricoUsuário});
            this.miHistorico.Name = "miHistorico";
            this.miHistorico.Size = new System.Drawing.Size(204, 26);
            this.miHistorico.Text = "Histórico";
            // 
            // miHistoricoLivro
            // 
            this.miHistoricoLivro.Name = "miHistoricoLivro";
            this.miHistoricoLivro.Size = new System.Drawing.Size(181, 26);
            this.miHistoricoLivro.Text = "Por Livro";
            // 
            // miHistoricoUsuário
            // 
            this.miHistoricoUsuário.Name = "miHistoricoUsuário";
            this.miHistoricoUsuário.Size = new System.Drawing.Size(181, 26);
            this.miHistoricoUsuário.Text = "Por Usuário";
            this.miHistoricoUsuário.Click += new System.EventHandler(this.miHistoricoUsuário_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula_6_em_Diante_Continuo.Properties.Resources.biblioteca;
            this.ClientSize = new System.Drawing.Size(1276, 846);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipal";
            this.Text = "Simploteca!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAcervo;
        private System.Windows.Forms.ToolStripMenuItem miUsuario;
        private System.Windows.Forms.ToolStripMenuItem emprestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEmprestimo;
        private System.Windows.Forms.ToolStripMenuItem miDevolucao;
        private System.Windows.Forms.ToolStripMenuItem miHistorico;
        private System.Windows.Forms.ToolStripMenuItem miHistoricoLivro;
        private System.Windows.Forms.ToolStripMenuItem miHistoricoUsuário;
    }
}

