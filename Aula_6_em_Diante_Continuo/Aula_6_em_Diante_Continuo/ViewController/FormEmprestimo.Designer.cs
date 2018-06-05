namespace Aula_6_em_Diante_Continuo.ViewController
{
    partial class FormEmprestimo
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
            this.panelAcervo = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAcervo = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.panelEmprestimo = new System.Windows.Forms.GroupBox();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.clCodigoEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTituloEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAutorEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.GroupBox();
            this.lbNomeResult = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panelAcervo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcervo)).BeginInit();
            this.panelEmprestimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcervo
            // 
            this.panelAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAcervo.Controls.Add(this.btnAdd);
            this.panelAcervo.Controls.Add(this.dgvAcervo);
            this.panelAcervo.Controls.Add(this.txtBuscar);
            this.panelAcervo.Controls.Add(this.lbBuscar);
            this.panelAcervo.Location = new System.Drawing.Point(6, 124);
            this.panelAcervo.Name = "panelAcervo";
            this.panelAcervo.Size = new System.Drawing.Size(777, 226);
            this.panelAcervo.TabIndex = 4;
            this.panelAcervo.TabStop = false;
            this.panelAcervo.Text = "Acervo";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(682, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.clDisponivel});
            this.dgvAcervo.Location = new System.Drawing.Point(3, 73);
            this.dgvAcervo.MultiSelect = false;
            this.dgvAcervo.Name = "dgvAcervo";
            this.dgvAcervo.ReadOnly = true;
            this.dgvAcervo.RowHeadersVisible = false;
            this.dgvAcervo.RowTemplate.Height = 24;
            this.dgvAcervo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAcervo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcervo.Size = new System.Drawing.Size(768, 147);
            this.dgvAcervo.TabIndex = 2;
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
            // clDisponivel
            // 
            this.clDisponivel.HeaderText = "Disponível";
            this.clDisponivel.Name = "clDisponivel";
            this.clDisponivel.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(69, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(596, 22);
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
            // panelEmprestimo
            // 
            this.panelEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmprestimo.Controls.Add(this.btnRemover);
            this.panelEmprestimo.Controls.Add(this.dgvEmprestimo);
            this.panelEmprestimo.Location = new System.Drawing.Point(6, 368);
            this.panelEmprestimo.Name = "panelEmprestimo";
            this.panelEmprestimo.Size = new System.Drawing.Size(777, 233);
            this.panelEmprestimo.TabIndex = 5;
            this.panelEmprestimo.TabStop = false;
            this.panelEmprestimo.Text = "Livros a Emprestar";
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            this.dgvEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigoEmprestimo,
            this.clTituloEmprestimo,
            this.clAutorEmprestimo});
            this.dgvEmprestimo.Location = new System.Drawing.Point(3, 31);
            this.dgvEmprestimo.MultiSelect = false;
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.RowHeadersVisible = false;
            this.dgvEmprestimo.RowTemplate.Height = 24;
            this.dgvEmprestimo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimo.Size = new System.Drawing.Size(771, 140);
            this.dgvEmprestimo.TabIndex = 0;
            // 
            // clCodigoEmprestimo
            // 
            this.clCodigoEmprestimo.HeaderText = "Código";
            this.clCodigoEmprestimo.Name = "clCodigoEmprestimo";
            this.clCodigoEmprestimo.ReadOnly = true;
            // 
            // clTituloEmprestimo
            // 
            this.clTituloEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTituloEmprestimo.HeaderText = "Título";
            this.clTituloEmprestimo.Name = "clTituloEmprestimo";
            this.clTituloEmprestimo.ReadOnly = true;
            // 
            // clAutorEmprestimo
            // 
            this.clAutorEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clAutorEmprestimo.FillWeight = 50F;
            this.clAutorEmprestimo.HeaderText = "Autor";
            this.clAutorEmprestimo.Name = "clAutorEmprestimo";
            this.clAutorEmprestimo.ReadOnly = true;
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.Controls.Add(this.btnFinalizar);
            this.panelBtn.Controls.Add(this.btnCancelar);
            this.panelBtn.Location = new System.Drawing.Point(9, 607);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(774, 59);
            this.panelBtn.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(679, 11);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(89, 40);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(583, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.Controls.Add(this.txtCPF);
            this.panelUsuario.Controls.Add(this.lbNomeResult);
            this.panelUsuario.Controls.Add(this.lbCPF);
            this.panelUsuario.Controls.Add(this.lbNome);
            this.panelUsuario.Location = new System.Drawing.Point(6, 12);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(777, 106);
            this.panelUsuario.TabIndex = 1;
            this.panelUsuario.TabStop = false;
            this.panelUsuario.Text = "Usuário";
            // 
            // lbNomeResult
            // 
            this.lbNomeResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNomeResult.Location = new System.Drawing.Point(63, 66);
            this.lbNomeResult.Name = "lbNomeResult";
            this.lbNomeResult.Size = new System.Drawing.Size(708, 24);
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
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(63, 30);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(138, 22);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(682, 183);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(89, 38);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 669);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelEmprestimo);
            this.Controls.Add(this.panelAcervo);
            this.Name = "FormEmprestimo";
            this.Text = "Emprestimo";
            this.Activated += new System.EventHandler(this.FormEmprestimo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmprestimo_FormClosing);
            this.Load += new System.EventHandler(this.FormEmprestimo_Load);
            this.panelAcervo.ResumeLayout(false);
            this.panelAcervo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcervo)).EndInit();
            this.panelEmprestimo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox panelAcervo;
        private System.Windows.Forms.DataGridView dgvAcervo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.GroupBox panelEmprestimo;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDisponivel;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigoEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTituloEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAutorEmprestimo;
        private System.Windows.Forms.GroupBox panelUsuario;
        private System.Windows.Forms.Label lbNomeResult;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnRemover;
    }
}