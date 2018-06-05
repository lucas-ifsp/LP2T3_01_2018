namespace Aula_6_em_Diante_Continuo.ViewController
{
    partial class FormConsultaLivroUsuario
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
            this.panelAcervo = new System.Windows.Forms.GroupBox();
            this.dgvAcervo = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUsuario.SuspendLayout();
            this.panelAcervo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcervo)).BeginInit();
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
            this.panelUsuario.Location = new System.Drawing.Point(1, 2);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(754, 106);
            this.panelUsuario.TabIndex = 3;
            this.panelUsuario.TabStop = false;
            this.panelUsuario.Text = "Usuário";
            this.panelUsuario.Enter += new System.EventHandler(this.panelUsuario_Enter);
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
            this.lbNomeResult.Size = new System.Drawing.Size(685, 24);
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
            // panelAcervo
            // 
            this.panelAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAcervo.Controls.Add(this.dgvAcervo);
            this.panelAcervo.Controls.Add(this.txtBuscar);
            this.panelAcervo.Controls.Add(this.lbBuscar);
            this.panelAcervo.Location = new System.Drawing.Point(1, 114);
            this.panelAcervo.Name = "panelAcervo";
            this.panelAcervo.Size = new System.Drawing.Size(754, 226);
            this.panelAcervo.TabIndex = 5;
            this.panelAcervo.TabStop = false;
            this.panelAcervo.Text = "Livros Emprestados";
            // 
            // dgvAcervo
            // 
            this.dgvAcervo.AllowUserToAddRows = false;
            this.dgvAcervo.AllowUserToDeleteRows = false;
            this.dgvAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clTitulo,
            this.clAutor,
            this.clDataEmprestimo,
            this.clDevolucao,
            this.clSituacao});
            this.dgvAcervo.Location = new System.Drawing.Point(3, 73);
            this.dgvAcervo.MultiSelect = false;
            this.dgvAcervo.Name = "dgvAcervo";
            this.dgvAcervo.ReadOnly = true;
            this.dgvAcervo.RowHeadersVisible = false;
            this.dgvAcervo.RowTemplate.Height = 24;
            this.dgvAcervo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAcervo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcervo.Size = new System.Drawing.Size(745, 147);
            this.dgvAcervo.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(69, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(679, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(6, 33);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(56, 17);
            this.lbBuscar.TabIndex = 0;
            this.lbBuscar.Text = "Buscar:";
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.Controls.Add(this.btnFechar);
            this.panelBtn.Location = new System.Drawing.Point(4, 346);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(751, 59);
            this.panelBtn.TabIndex = 8;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(664, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 40);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            // clDevolucao
            // 
            this.clDevolucao.HeaderText = "Data Devolução";
            this.clDevolucao.Name = "clDevolucao";
            this.clDevolucao.ReadOnly = true;
            // 
            // clSituacao
            // 
            this.clSituacao.HeaderText = "Situação";
            this.clSituacao.Name = "clSituacao";
            this.clSituacao.ReadOnly = true;
            // 
            // FormConsultaLivroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 415);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelAcervo);
            this.Controls.Add(this.panelUsuario);
            this.Name = "FormConsultaLivroUsuario";
            this.Text = "Consulta de Livros Emprestados por Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultaLivroUsuario_FormClosing);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelAcervo.ResumeLayout(false);
            this.panelAcervo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcervo)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelUsuario;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbNomeResult;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox panelAcervo;
        private System.Windows.Forms.DataGridView dgvAcervo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSituacao;
    }
}