namespace frmLogin
{
    partial class fmSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSaldo));
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.groupBoxSaldo = new System.Windows.Forms.GroupBox();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.txtSaldoVendas = new System.Windows.Forms.TextBox();
            this.txtSaldoDocaoes = new System.Windows.Forms.TextBox();
            this.lbSaldoTotal = new System.Windows.Forms.Label();
            this.lbSaldoVendas = new System.Windows.Forms.Label();
            this.lbSaldoDoacoes = new System.Windows.Forms.Label();
            this.lbDoacaoDoador = new System.Windows.Forms.Label();
            this.lbSaldoVoltar = new System.Windows.Forms.Label();
            this.btnSaldoVoltar = new System.Windows.Forms.Button();
            this.panelSaldo.SuspendLayout();
            this.groupBoxSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSaldo
            // 
            this.panelSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSaldo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSaldo.Controls.Add(this.groupBoxSaldo);
            this.panelSaldo.Controls.Add(this.lbSaldoVoltar);
            this.panelSaldo.Controls.Add(this.btnSaldoVoltar);
            this.panelSaldo.Location = new System.Drawing.Point(15, 13);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(268, 212);
            this.panelSaldo.TabIndex = 0;
            // 
            // groupBoxSaldo
            // 
            this.groupBoxSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxSaldo.Controls.Add(this.txtSaldoTotal);
            this.groupBoxSaldo.Controls.Add(this.txtSaldoVendas);
            this.groupBoxSaldo.Controls.Add(this.txtSaldoDocaoes);
            this.groupBoxSaldo.Controls.Add(this.lbSaldoTotal);
            this.groupBoxSaldo.Controls.Add(this.lbSaldoVendas);
            this.groupBoxSaldo.Controls.Add(this.lbSaldoDoacoes);
            this.groupBoxSaldo.Controls.Add(this.lbDoacaoDoador);
            this.groupBoxSaldo.Location = new System.Drawing.Point(12, 3);
            this.groupBoxSaldo.Name = "groupBoxSaldo";
            this.groupBoxSaldo.Size = new System.Drawing.Size(244, 133);
            this.groupBoxSaldo.TabIndex = 0;
            this.groupBoxSaldo.TabStop = false;
            this.groupBoxSaldo.Text = "Saldo Atual";
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Enabled = false;
            this.txtSaldoTotal.Location = new System.Drawing.Point(91, 88);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.Size = new System.Drawing.Size(91, 20);
            this.txtSaldoTotal.TabIndex = 51;
            // 
            // txtSaldoVendas
            // 
            this.txtSaldoVendas.Enabled = false;
            this.txtSaldoVendas.Location = new System.Drawing.Point(91, 62);
            this.txtSaldoVendas.Name = "txtSaldoVendas";
            this.txtSaldoVendas.Size = new System.Drawing.Size(91, 20);
            this.txtSaldoVendas.TabIndex = 50;
            // 
            // txtSaldoDocaoes
            // 
            this.txtSaldoDocaoes.Enabled = false;
            this.txtSaldoDocaoes.Location = new System.Drawing.Point(91, 36);
            this.txtSaldoDocaoes.Name = "txtSaldoDocaoes";
            this.txtSaldoDocaoes.Size = new System.Drawing.Size(91, 20);
            this.txtSaldoDocaoes.TabIndex = 49;
            // 
            // lbSaldoTotal
            // 
            this.lbSaldoTotal.AutoSize = true;
            this.lbSaldoTotal.Location = new System.Drawing.Point(51, 91);
            this.lbSaldoTotal.Name = "lbSaldoTotal";
            this.lbSaldoTotal.Size = new System.Drawing.Size(34, 13);
            this.lbSaldoTotal.TabIndex = 47;
            this.lbSaldoTotal.Text = "Total:";
            // 
            // lbSaldoVendas
            // 
            this.lbSaldoVendas.AutoSize = true;
            this.lbSaldoVendas.Location = new System.Drawing.Point(42, 65);
            this.lbSaldoVendas.Name = "lbSaldoVendas";
            this.lbSaldoVendas.Size = new System.Drawing.Size(46, 13);
            this.lbSaldoVendas.TabIndex = 45;
            this.lbSaldoVendas.Text = "Vendas:";
            // 
            // lbSaldoDoacoes
            // 
            this.lbSaldoDoacoes.AutoSize = true;
            this.lbSaldoDoacoes.Location = new System.Drawing.Point(35, 39);
            this.lbSaldoDoacoes.Name = "lbSaldoDoacoes";
            this.lbSaldoDoacoes.Size = new System.Drawing.Size(53, 13);
            this.lbSaldoDoacoes.TabIndex = 43;
            this.lbSaldoDoacoes.Text = "Doações:";
            // 
            // lbDoacaoDoador
            // 
            this.lbDoacaoDoador.AutoSize = true;
            this.lbDoacaoDoador.Location = new System.Drawing.Point(12, 36);
            this.lbDoacaoDoador.Name = "lbDoacaoDoador";
            this.lbDoacaoDoador.Size = new System.Drawing.Size(0, 13);
            this.lbDoacaoDoador.TabIndex = 41;
            // 
            // lbSaldoVoltar
            // 
            this.lbSaldoVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSaldoVoltar.AutoSize = true;
            this.lbSaldoVoltar.Location = new System.Drawing.Point(9, 144);
            this.lbSaldoVoltar.Name = "lbSaldoVoltar";
            this.lbSaldoVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbSaldoVoltar.TabIndex = 44;
            this.lbSaldoVoltar.Text = "Voltar";
            // 
            // btnSaldoVoltar
            // 
            this.btnSaldoVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaldoVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaldoVoltar.BackgroundImage")));
            this.btnSaldoVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaldoVoltar.Location = new System.Drawing.Point(3, 160);
            this.btnSaldoVoltar.Name = "btnSaldoVoltar";
            this.btnSaldoVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnSaldoVoltar.TabIndex = 1;
            this.btnSaldoVoltar.UseVisualStyleBackColor = true;
            this.btnSaldoVoltar.Click += new System.EventHandler(this.btnPessoaVoltar_Click);
            // 
            // fmSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(295, 237);
            this.Controls.Add(this.panelSaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmSaldo";
            this.Text = "Saldo";
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.groupBoxSaldo.ResumeLayout(false);
            this.groupBoxSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.Label lbSaldoVoltar;
        private System.Windows.Forms.Button btnSaldoVoltar;
        private System.Windows.Forms.GroupBox groupBoxSaldo;
        private System.Windows.Forms.Label lbSaldoTotal;
        private System.Windows.Forms.Label lbSaldoVendas;
        private System.Windows.Forms.Label lbSaldoDoacoes;
        private System.Windows.Forms.Label lbDoacaoDoador;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.TextBox txtSaldoVendas;
        private System.Windows.Forms.TextBox txtSaldoDocaoes;
    }
}