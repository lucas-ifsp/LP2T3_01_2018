namespace Aula_6_em_Diante_Continuo.ViewController
{
    partial class FormDevolucao
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
            this.panelUsuario = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbNomeResult = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.panelEmprestimos = new System.Windows.Forms.GroupBox();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelUsuario.SuspendLayout();
            this.panelEmprestimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.Controls.Add(this.txtCPF);
            this.panelUsuario.Controls.Add(this.lbNomeResult);
            this.panelUsuario.Controls.Add(this.lbCPF);
            this.panelUsuario.Controls.Add(this.lbNome);
            this.panelUsuario.Location = new System.Drawing.Point(3, 12);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(816, 106);
            this.panelUsuario.TabIndex = 2;
            this.panelUsuario.TabStop = false;
            this.panelUsuario.Text = "Usuário";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(63, 31);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(138, 22);
            this.txtCPF.TabIndex = 4;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // lbNomeResult
            // 
            this.lbNomeResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNomeResult.Location = new System.Drawing.Point(63, 66);
            this.lbNomeResult.Name = "lbNomeResult";
            this.lbNomeResult.Size = new System.Drawing.Size(747, 24);
            this.lbNomeResult.TabIndex = 3;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(19, 33);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(38, 17);
            this.lbCPF.TabIndex = 0;
            this.lbCPF.Text = "CPF:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(8, 67);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 17);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // panelEmprestimos
            // 
            this.panelEmprestimos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmprestimos.Controls.Add(this.dgvEmprestimos);
            this.panelEmprestimos.Location = new System.Drawing.Point(3, 125);
            this.panelEmprestimos.Name = "panelEmprestimos";
            this.panelEmprestimos.Size = new System.Drawing.Size(816, 301);
            this.panelEmprestimos.TabIndex = 3;
            this.panelEmprestimos.TabStop = false;
            this.panelEmprestimos.Text = "Emprestimos";
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AllowUserToDeleteRows = false;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clTitulo,
            this.clAutor,
            this.clDataEmprestimo,
            this.clDataDevolucao});
            this.dgvEmprestimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmprestimos.Location = new System.Drawing.Point(3, 18);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.RowHeadersVisible = false;
            this.dgvEmprestimos.RowTemplate.Height = 24;
            this.dgvEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimos.Size = new System.Drawing.Size(810, 280);
            this.dgvEmprestimos.TabIndex = 0;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            // 
            // clTitulo
            // 
            this.clTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTitulo.HeaderText = "Título";
            this.clTitulo.Name = "clTitulo";
            this.clTitulo.ReadOnly = true;
            // 
            // clAutor
            // 
            this.clAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clAutor.FillWeight = 50F;
            this.clAutor.HeaderText = "Autor";
            this.clAutor.Name = "clAutor";
            this.clAutor.ReadOnly = true;
            // 
            // clDataEmprestimo
            // 
            this.clDataEmprestimo.HeaderText = "Data Empréstimo";
            this.clDataEmprestimo.Name = "clDataEmprestimo";
            this.clDataEmprestimo.ReadOnly = true;
            // 
            // clDataDevolucao
            // 
            this.clDataDevolucao.HeaderText = "Data Devolução";
            this.clDataDevolucao.Name = "clDataDevolucao";
            this.clDataDevolucao.ReadOnly = true;
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.Controls.Add(this.btnDevolver);
            this.panelBtn.Controls.Add(this.btnFechar);
            this.panelBtn.Location = new System.Drawing.Point(3, 432);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(816, 59);
            this.panelBtn.TabIndex = 7;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolver.Location = new System.Drawing.Point(624, 11);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(89, 40);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(729, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 40);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 491);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelEmprestimos);
            this.Controls.Add(this.panelUsuario);
            this.Name = "FormDevolucao";
            this.Text = "Devolução de Livros";
            this.Activated += new System.EventHandler(this.FormDevolucao_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDevolucao_FormClosing);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelEmprestimos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelUsuario;
        private System.Windows.Forms.Label lbNomeResult;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox panelEmprestimos;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataDevolucao;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}