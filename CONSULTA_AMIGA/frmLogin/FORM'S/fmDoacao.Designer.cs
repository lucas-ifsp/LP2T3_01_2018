namespace frmLogin
{
    partial class fmDoacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDoacao));
            this.panelDoacao = new System.Windows.Forms.Panel();
            this.groupBoxDoacao = new System.Windows.Forms.GroupBox();
            this.txtDoacaoValor = new System.Windows.Forms.TextBox();
            this.maskDoacaoRS = new System.Windows.Forms.MaskedTextBox();
            this.maskDoacaoData = new System.Windows.Forms.MaskedTextBox();
            this.lbDoacaoValor = new System.Windows.Forms.Label();
            this.comboBoxDoacaoPagamento = new System.Windows.Forms.ComboBox();
            this.txtDoacaoDoador = new System.Windows.Forms.TextBox();
            this.lbDoacaoDoador = new System.Windows.Forms.Label();
            this.groupBoxDoacaoObservacoes = new System.Windows.Forms.GroupBox();
            this.txtDoacaoObservacoes = new System.Windows.Forms.TextBox();
            this.lbDoacaoPagamento = new System.Windows.Forms.Label();
            this.lbDoacaoData = new System.Windows.Forms.Label();
            this.btnDoacaoCancelar = new System.Windows.Forms.Button();
            this.btnDoacaoRegistrar = new System.Windows.Forms.Button();
            this.panelDoacao.SuspendLayout();
            this.groupBoxDoacao.SuspendLayout();
            this.groupBoxDoacaoObservacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDoacao
            // 
            this.panelDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDoacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDoacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDoacao.Controls.Add(this.groupBoxDoacao);
            this.panelDoacao.Controls.Add(this.btnDoacaoCancelar);
            this.panelDoacao.Controls.Add(this.btnDoacaoRegistrar);
            this.panelDoacao.Location = new System.Drawing.Point(14, 12);
            this.panelDoacao.Name = "panelDoacao";
            this.panelDoacao.Size = new System.Drawing.Size(292, 423);
            this.panelDoacao.TabIndex = 0;
            // 
            // groupBoxDoacao
            // 
            this.groupBoxDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDoacao.Controls.Add(this.txtDoacaoValor);
            this.groupBoxDoacao.Controls.Add(this.maskDoacaoRS);
            this.groupBoxDoacao.Controls.Add(this.maskDoacaoData);
            this.groupBoxDoacao.Controls.Add(this.lbDoacaoValor);
            this.groupBoxDoacao.Controls.Add(this.comboBoxDoacaoPagamento);
            this.groupBoxDoacao.Controls.Add(this.txtDoacaoDoador);
            this.groupBoxDoacao.Controls.Add(this.lbDoacaoDoador);
            this.groupBoxDoacao.Controls.Add(this.groupBoxDoacaoObservacoes);
            this.groupBoxDoacao.Controls.Add(this.lbDoacaoPagamento);
            this.groupBoxDoacao.Controls.Add(this.lbDoacaoData);
            this.groupBoxDoacao.Location = new System.Drawing.Point(25, 13);
            this.groupBoxDoacao.Name = "groupBoxDoacao";
            this.groupBoxDoacao.Size = new System.Drawing.Size(244, 311);
            this.groupBoxDoacao.TabIndex = 0;
            this.groupBoxDoacao.TabStop = false;
            this.groupBoxDoacao.Text = "Dados";
            // 
            // txtDoacaoValor
            // 
            this.txtDoacaoValor.Location = new System.Drawing.Point(148, 100);
            this.txtDoacaoValor.Name = "txtDoacaoValor";
            this.txtDoacaoValor.Size = new System.Drawing.Size(82, 20);
            this.txtDoacaoValor.TabIndex = 3;
            this.txtDoacaoValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoacaoValor_KeyDown);
            this.txtDoacaoValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDoacaoValor_KeyUp);
            // 
            // maskDoacaoRS
            // 
            this.maskDoacaoRS.Location = new System.Drawing.Point(128, 100);
            this.maskDoacaoRS.Mask = "$";
            this.maskDoacaoRS.Name = "maskDoacaoRS";
            this.maskDoacaoRS.Size = new System.Drawing.Size(28, 20);
            this.maskDoacaoRS.TabIndex = 45;
            // 
            // maskDoacaoData
            // 
            this.maskDoacaoData.Location = new System.Drawing.Point(14, 100);
            this.maskDoacaoData.Mask = "00/00/0000";
            this.maskDoacaoData.Name = "maskDoacaoData";
            this.maskDoacaoData.Size = new System.Drawing.Size(97, 20);
            this.maskDoacaoData.TabIndex = 2;
            this.maskDoacaoData.ValidatingType = typeof(System.DateTime);
            // 
            // lbDoacaoValor
            // 
            this.lbDoacaoValor.AutoSize = true;
            this.lbDoacaoValor.Location = new System.Drawing.Point(125, 84);
            this.lbDoacaoValor.Name = "lbDoacaoValor";
            this.lbDoacaoValor.Size = new System.Drawing.Size(31, 13);
            this.lbDoacaoValor.TabIndex = 44;
            this.lbDoacaoValor.Text = "Valor";
            // 
            // comboBoxDoacaoPagamento
            // 
            this.comboBoxDoacaoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoacaoPagamento.FormattingEnabled = true;
            this.comboBoxDoacaoPagamento.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Dinheiro",
            "Cheque"});
            this.comboBoxDoacaoPagamento.Location = new System.Drawing.Point(15, 150);
            this.comboBoxDoacaoPagamento.Name = "comboBoxDoacaoPagamento";
            this.comboBoxDoacaoPagamento.Size = new System.Drawing.Size(215, 21);
            this.comboBoxDoacaoPagamento.TabIndex = 4;
            // 
            // txtDoacaoDoador
            // 
            this.txtDoacaoDoador.Location = new System.Drawing.Point(15, 52);
            this.txtDoacaoDoador.Name = "txtDoacaoDoador";
            this.txtDoacaoDoador.Size = new System.Drawing.Size(215, 20);
            this.txtDoacaoDoador.TabIndex = 1;
            // 
            // lbDoacaoDoador
            // 
            this.lbDoacaoDoador.AutoSize = true;
            this.lbDoacaoDoador.Location = new System.Drawing.Point(12, 36);
            this.lbDoacaoDoador.Name = "lbDoacaoDoador";
            this.lbDoacaoDoador.Size = new System.Drawing.Size(42, 13);
            this.lbDoacaoDoador.TabIndex = 41;
            this.lbDoacaoDoador.Text = "Doador";
            // 
            // groupBoxDoacaoObservacoes
            // 
            this.groupBoxDoacaoObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDoacaoObservacoes.Controls.Add(this.txtDoacaoObservacoes);
            this.groupBoxDoacaoObservacoes.Location = new System.Drawing.Point(6, 197);
            this.groupBoxDoacaoObservacoes.Name = "groupBoxDoacaoObservacoes";
            this.groupBoxDoacaoObservacoes.Size = new System.Drawing.Size(232, 108);
            this.groupBoxDoacaoObservacoes.TabIndex = 5;
            this.groupBoxDoacaoObservacoes.TabStop = false;
            this.groupBoxDoacaoObservacoes.Text = "Observações";
            // 
            // txtDoacaoObservacoes
            // 
            this.txtDoacaoObservacoes.Location = new System.Drawing.Point(16, 28);
            this.txtDoacaoObservacoes.Multiline = true;
            this.txtDoacaoObservacoes.Name = "txtDoacaoObservacoes";
            this.txtDoacaoObservacoes.Size = new System.Drawing.Size(200, 66);
            this.txtDoacaoObservacoes.TabIndex = 5;
            // 
            // lbDoacaoPagamento
            // 
            this.lbDoacaoPagamento.AutoSize = true;
            this.lbDoacaoPagamento.Location = new System.Drawing.Point(11, 134);
            this.lbDoacaoPagamento.Name = "lbDoacaoPagamento";
            this.lbDoacaoPagamento.Size = new System.Drawing.Size(61, 13);
            this.lbDoacaoPagamento.TabIndex = 27;
            this.lbDoacaoPagamento.Text = "Pagamento";
            // 
            // lbDoacaoData
            // 
            this.lbDoacaoData.AutoSize = true;
            this.lbDoacaoData.Location = new System.Drawing.Point(11, 84);
            this.lbDoacaoData.Name = "lbDoacaoData";
            this.lbDoacaoData.Size = new System.Drawing.Size(30, 13);
            this.lbDoacaoData.TabIndex = 25;
            this.lbDoacaoData.Text = "Data";
            // 
            // btnDoacaoCancelar
            // 
            this.btnDoacaoCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoacaoCancelar.Location = new System.Drawing.Point(153, 342);
            this.btnDoacaoCancelar.Name = "btnDoacaoCancelar";
            this.btnDoacaoCancelar.Size = new System.Drawing.Size(116, 59);
            this.btnDoacaoCancelar.TabIndex = 7;
            this.btnDoacaoCancelar.Text = "Cancelar";
            this.btnDoacaoCancelar.UseVisualStyleBackColor = true;
            this.btnDoacaoCancelar.Click += new System.EventHandler(this.btnAnimaisProcurar_Click);
            // 
            // btnDoacaoRegistrar
            // 
            this.btnDoacaoRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoacaoRegistrar.Location = new System.Drawing.Point(25, 342);
            this.btnDoacaoRegistrar.Name = "btnDoacaoRegistrar";
            this.btnDoacaoRegistrar.Size = new System.Drawing.Size(111, 59);
            this.btnDoacaoRegistrar.TabIndex = 6;
            this.btnDoacaoRegistrar.Text = "Registrar";
            this.btnDoacaoRegistrar.UseVisualStyleBackColor = true;
            this.btnDoacaoRegistrar.Click += new System.EventHandler(this.btnDoacaoRegistrar_Click);
            // 
            // fmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(318, 445);
            this.Controls.Add(this.panelDoacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmDoacao";
            this.Text = "Doação";
            this.panelDoacao.ResumeLayout(false);
            this.groupBoxDoacao.ResumeLayout(false);
            this.groupBoxDoacao.PerformLayout();
            this.groupBoxDoacaoObservacoes.ResumeLayout(false);
            this.groupBoxDoacaoObservacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDoacao;
        private System.Windows.Forms.GroupBox groupBoxDoacao;
        private System.Windows.Forms.TextBox txtDoacaoDoador;
        private System.Windows.Forms.Label lbDoacaoDoador;
        private System.Windows.Forms.GroupBox groupBoxDoacaoObservacoes;
        private System.Windows.Forms.TextBox txtDoacaoObservacoes;
        private System.Windows.Forms.Label lbDoacaoPagamento;
        private System.Windows.Forms.Label lbDoacaoData;
        private System.Windows.Forms.Button btnDoacaoCancelar;
        private System.Windows.Forms.Button btnDoacaoRegistrar;
        private System.Windows.Forms.ComboBox comboBoxDoacaoPagamento;
        private System.Windows.Forms.TextBox txtDoacaoValor;
        private System.Windows.Forms.Label lbDoacaoValor;
        private System.Windows.Forms.MaskedTextBox maskDoacaoData;
        private System.Windows.Forms.MaskedTextBox maskDoacaoRS;
    }
}