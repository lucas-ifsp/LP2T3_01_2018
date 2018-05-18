namespace frmLogin
{
    partial class fmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmVenda));
            this.panelVenda = new System.Windows.Forms.Panel();
            this.grBoxVendaProdutosCadastrados = new System.Windows.Forms.GroupBox();
            this.txtVendaValorTotal = new System.Windows.Forms.TextBox();
            this.txtVendaDesconto = new System.Windows.Forms.TextBox();
            this.maskVendaRSDesconto = new System.Windows.Forms.MaskedTextBox();
            this.maskVendaRSTotal = new System.Windows.Forms.MaskedTextBox();
            this.lbVendaQuantidade = new System.Windows.Forms.Label();
            this.lbVendaDesconto = new System.Windows.Forms.Label();
            this.txtVendaQuantidade = new System.Windows.Forms.TextBox();
            this.dataGridViewVendaPesqProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVendaNome = new System.Windows.Forms.Label();
            this.txtVendaNomeProduto = new System.Windows.Forms.TextBox();
            this.lbVendaValorTotal = new System.Windows.Forms.Label();
            this.grBoxVenda = new System.Windows.Forms.GroupBox();
            this.txtVendaCodigo = new System.Windows.Forms.TextBox();
            this.lbVendaCodigo = new System.Windows.Forms.Label();
            this.maskVendaData = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxVendaPagamento = new System.Windows.Forms.ComboBox();
            this.lbVendaPagamento = new System.Windows.Forms.Label();
            this.dataGridViewVenda = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVendaConsumidor = new System.Windows.Forms.TextBox();
            this.lbVendaData = new System.Windows.Forms.Label();
            this.lbVendaConsumidor = new System.Windows.Forms.Label();
            this.btnVendaCancelar = new System.Windows.Forms.Button();
            this.btnVendaFinalizar = new System.Windows.Forms.Button();
            this.panelVenda.SuspendLayout();
            this.grBoxVendaProdutosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendaPesqProdutos)).BeginInit();
            this.grBoxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVenda
            // 
            this.panelVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVenda.Controls.Add(this.grBoxVendaProdutosCadastrados);
            this.panelVenda.Location = new System.Drawing.Point(15, 14);
            this.panelVenda.Name = "panelVenda";
            this.panelVenda.Size = new System.Drawing.Size(1037, 616);
            this.panelVenda.TabIndex = 0;
            // 
            // grBoxVendaProdutosCadastrados
            // 
            this.grBoxVendaProdutosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.txtVendaValorTotal);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.txtVendaDesconto);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.maskVendaRSDesconto);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.maskVendaRSTotal);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.lbVendaQuantidade);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.lbVendaDesconto);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.txtVendaQuantidade);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.dataGridViewVendaPesqProdutos);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.lbVendaNome);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.txtVendaNomeProduto);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.lbVendaValorTotal);
            this.grBoxVendaProdutosCadastrados.Controls.Add(this.grBoxVenda);
            this.grBoxVendaProdutosCadastrados.Location = new System.Drawing.Point(19, 15);
            this.grBoxVendaProdutosCadastrados.Name = "grBoxVendaProdutosCadastrados";
            this.grBoxVendaProdutosCadastrados.Size = new System.Drawing.Size(993, 579);
            this.grBoxVendaProdutosCadastrados.TabIndex = 0;
            this.grBoxVendaProdutosCadastrados.TabStop = false;
            this.grBoxVendaProdutosCadastrados.Text = "Produtos Cadastrados";
            // 
            // txtVendaValorTotal
            // 
            this.txtVendaValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVendaValorTotal.Enabled = false;
            this.txtVendaValorTotal.Location = new System.Drawing.Point(272, 549);
            this.txtVendaValorTotal.Name = "txtVendaValorTotal";
            this.txtVendaValorTotal.Size = new System.Drawing.Size(183, 20);
            this.txtVendaValorTotal.TabIndex = 35;
            // 
            // txtVendaDesconto
            // 
            this.txtVendaDesconto.Location = new System.Drawing.Point(39, 549);
            this.txtVendaDesconto.Name = "txtVendaDesconto";
            this.txtVendaDesconto.Size = new System.Drawing.Size(179, 20);
            this.txtVendaDesconto.TabIndex = 8;
            this.txtVendaDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendaDesconto_KeyDown);
            this.txtVendaDesconto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVendaDesconto_KeyUp);
            // 
            // maskVendaRSDesconto
            // 
            this.maskVendaRSDesconto.Location = new System.Drawing.Point(19, 549);
            this.maskVendaRSDesconto.Mask = "$";
            this.maskVendaRSDesconto.Name = "maskVendaRSDesconto";
            this.maskVendaRSDesconto.Size = new System.Drawing.Size(27, 20);
            this.maskVendaRSDesconto.TabIndex = 45;
            // 
            // maskVendaRSTotal
            // 
            this.maskVendaRSTotal.Enabled = false;
            this.maskVendaRSTotal.Location = new System.Drawing.Point(252, 549);
            this.maskVendaRSTotal.Mask = "$";
            this.maskVendaRSTotal.Name = "maskVendaRSTotal";
            this.maskVendaRSTotal.Size = new System.Drawing.Size(24, 20);
            this.maskVendaRSTotal.TabIndex = 45;
            // 
            // lbVendaQuantidade
            // 
            this.lbVendaQuantidade.AutoSize = true;
            this.lbVendaQuantidade.Location = new System.Drawing.Point(409, 32);
            this.lbVendaQuantidade.Name = "lbVendaQuantidade";
            this.lbVendaQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbVendaQuantidade.TabIndex = 39;
            this.lbVendaQuantidade.Text = "Quantidade";
            // 
            // lbVendaDesconto
            // 
            this.lbVendaDesconto.AutoSize = true;
            this.lbVendaDesconto.Location = new System.Drawing.Point(16, 533);
            this.lbVendaDesconto.Name = "lbVendaDesconto";
            this.lbVendaDesconto.Size = new System.Drawing.Size(53, 13);
            this.lbVendaDesconto.TabIndex = 46;
            this.lbVendaDesconto.Text = "Desconto";
            // 
            // txtVendaQuantidade
            // 
            this.txtVendaQuantidade.Location = new System.Drawing.Point(412, 48);
            this.txtVendaQuantidade.Name = "txtVendaQuantidade";
            this.txtVendaQuantidade.Size = new System.Drawing.Size(138, 20);
            this.txtVendaQuantidade.TabIndex = 3;
            this.txtVendaQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendaQuantidade_KeyDown);
            this.txtVendaQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVendaQuantidade_KeyUp);
            // 
            // dataGridViewVendaPesqProdutos
            // 
            this.dataGridViewVendaPesqProdutos.AllowUserToAddRows = false;
            this.dataGridViewVendaPesqProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewVendaPesqProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVendaPesqProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendaPesqProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendaPesqProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Tipo,
            this.Nome,
            this.Marca,
            this.PreçoVenda,
            this.Estoque,
            this.Dosagem});
            this.dataGridViewVendaPesqProdutos.Location = new System.Drawing.Point(19, 90);
            this.dataGridViewVendaPesqProdutos.Name = "dataGridViewVendaPesqProdutos";
            this.dataGridViewVendaPesqProdutos.ReadOnly = true;
            this.dataGridViewVendaPesqProdutos.Size = new System.Drawing.Size(953, 126);
            this.dataGridViewVendaPesqProdutos.TabIndex = 28;
            this.dataGridViewVendaPesqProdutos.DoubleClick += new System.EventHandler(this.dataGridViewVendaPesqProdutos_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CÓDIGO";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "MARCA";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // PreçoVenda
            // 
            this.PreçoVenda.HeaderText = "PREÇO";
            this.PreçoVenda.Name = "PreçoVenda";
            this.PreçoVenda.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "ESTOQUE";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // Dosagem
            // 
            this.Dosagem.HeaderText = "DOSAGEM";
            this.Dosagem.Name = "Dosagem";
            this.Dosagem.ReadOnly = true;
            // 
            // lbVendaNome
            // 
            this.lbVendaNome.AutoSize = true;
            this.lbVendaNome.Location = new System.Drawing.Point(16, 32);
            this.lbVendaNome.Name = "lbVendaNome";
            this.lbVendaNome.Size = new System.Drawing.Size(35, 13);
            this.lbVendaNome.TabIndex = 35;
            this.lbVendaNome.Text = "Nome";
            // 
            // txtVendaNomeProduto
            // 
            this.txtVendaNomeProduto.Location = new System.Drawing.Point(19, 48);
            this.txtVendaNomeProduto.Name = "txtVendaNomeProduto";
            this.txtVendaNomeProduto.Size = new System.Drawing.Size(365, 20);
            this.txtVendaNomeProduto.TabIndex = 1;
            this.txtVendaNomeProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVendaNomeProduto_KeyUp);
            // 
            // lbVendaValorTotal
            // 
            this.lbVendaValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVendaValorTotal.AutoSize = true;
            this.lbVendaValorTotal.Location = new System.Drawing.Point(249, 533);
            this.lbVendaValorTotal.Name = "lbVendaValorTotal";
            this.lbVendaValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lbVendaValorTotal.TabIndex = 34;
            this.lbVendaValorTotal.Text = "Valor Total";
            // 
            // grBoxVenda
            // 
            this.grBoxVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxVenda.Controls.Add(this.txtVendaCodigo);
            this.grBoxVenda.Controls.Add(this.lbVendaCodigo);
            this.grBoxVenda.Controls.Add(this.maskVendaData);
            this.grBoxVenda.Controls.Add(this.comboBoxVendaPagamento);
            this.grBoxVenda.Controls.Add(this.lbVendaPagamento);
            this.grBoxVenda.Controls.Add(this.dataGridViewVenda);
            this.grBoxVenda.Controls.Add(this.txtVendaConsumidor);
            this.grBoxVenda.Controls.Add(this.lbVendaData);
            this.grBoxVenda.Controls.Add(this.lbVendaConsumidor);
            this.grBoxVenda.Controls.Add(this.btnVendaCancelar);
            this.grBoxVenda.Controls.Add(this.btnVendaFinalizar);
            this.grBoxVenda.Location = new System.Drawing.Point(0, 230);
            this.grBoxVenda.Name = "grBoxVenda";
            this.grBoxVenda.Size = new System.Drawing.Size(993, 290);
            this.grBoxVenda.TabIndex = 4;
            this.grBoxVenda.TabStop = false;
            this.grBoxVenda.Text = "Venda";
            // 
            // txtVendaCodigo
            // 
            this.txtVendaCodigo.Enabled = false;
            this.txtVendaCodigo.Location = new System.Drawing.Point(19, 51);
            this.txtVendaCodigo.Name = "txtVendaCodigo";
            this.txtVendaCodigo.Size = new System.Drawing.Size(199, 20);
            this.txtVendaCodigo.TabIndex = 45;
            // 
            // lbVendaCodigo
            // 
            this.lbVendaCodigo.AutoSize = true;
            this.lbVendaCodigo.Location = new System.Drawing.Point(18, 35);
            this.lbVendaCodigo.Name = "lbVendaCodigo";
            this.lbVendaCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbVendaCodigo.TabIndex = 46;
            this.lbVendaCodigo.Text = "Código";
            // 
            // maskVendaData
            // 
            this.maskVendaData.Location = new System.Drawing.Point(19, 99);
            this.maskVendaData.Mask = "00/00/0000";
            this.maskVendaData.Name = "maskVendaData";
            this.maskVendaData.Size = new System.Drawing.Size(199, 20);
            this.maskVendaData.TabIndex = 5;
            this.maskVendaData.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxVendaPagamento
            // 
            this.comboBoxVendaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVendaPagamento.FormattingEnabled = true;
            this.comboBoxVendaPagamento.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Dinheiro",
            "Cheque"});
            this.comboBoxVendaPagamento.Location = new System.Drawing.Point(21, 202);
            this.comboBoxVendaPagamento.Name = "comboBoxVendaPagamento";
            this.comboBoxVendaPagamento.Size = new System.Drawing.Size(198, 21);
            this.comboBoxVendaPagamento.TabIndex = 7;
            // 
            // lbVendaPagamento
            // 
            this.lbVendaPagamento.AutoSize = true;
            this.lbVendaPagamento.Location = new System.Drawing.Point(17, 186);
            this.lbVendaPagamento.Name = "lbVendaPagamento";
            this.lbVendaPagamento.Size = new System.Drawing.Size(61, 13);
            this.lbVendaPagamento.TabIndex = 44;
            this.lbVendaPagamento.Text = "Pagamento";
            // 
            // dataGridViewVenda
            // 
            this.dataGridViewVenda.AllowUserToAddRows = false;
            this.dataGridViewVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.NomeVenda,
            this.Quantidade,
            this.ValorUnitário,
            this.ValorTotal});
            this.dataGridViewVenda.Location = new System.Drawing.Point(240, 19);
            this.dataGridViewVenda.Name = "dataGridViewVenda";
            this.dataGridViewVenda.ReadOnly = true;
            this.dataGridViewVenda.Size = new System.Drawing.Size(600, 256);
            this.dataGridViewVenda.TabIndex = 27;
            this.dataGridViewVenda.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewVenda_RowsRemoved);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "PRODUTO";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // NomeVenda
            // 
            this.NomeVenda.HeaderText = "NOME";
            this.NomeVenda.Name = "NomeVenda";
            this.NomeVenda.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "QUANTIDADE";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnitário
            // 
            this.ValorUnitário.HeaderText = "UNITÁRIO";
            this.ValorUnitário.Name = "ValorUnitário";
            this.ValorUnitário.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "TOTAL";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // txtVendaConsumidor
            // 
            this.txtVendaConsumidor.Location = new System.Drawing.Point(19, 152);
            this.txtVendaConsumidor.Name = "txtVendaConsumidor";
            this.txtVendaConsumidor.Size = new System.Drawing.Size(199, 20);
            this.txtVendaConsumidor.TabIndex = 6;
            // 
            // lbVendaData
            // 
            this.lbVendaData.AutoSize = true;
            this.lbVendaData.Location = new System.Drawing.Point(16, 83);
            this.lbVendaData.Name = "lbVendaData";
            this.lbVendaData.Size = new System.Drawing.Size(30, 13);
            this.lbVendaData.TabIndex = 25;
            this.lbVendaData.Text = "Data";
            // 
            // lbVendaConsumidor
            // 
            this.lbVendaConsumidor.AutoSize = true;
            this.lbVendaConsumidor.Location = new System.Drawing.Point(16, 136);
            this.lbVendaConsumidor.Name = "lbVendaConsumidor";
            this.lbVendaConsumidor.Size = new System.Drawing.Size(62, 13);
            this.lbVendaConsumidor.TabIndex = 26;
            this.lbVendaConsumidor.Text = "Consumidor";
            // 
            // btnVendaCancelar
            // 
            this.btnVendaCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendaCancelar.Location = new System.Drawing.Point(863, 215);
            this.btnVendaCancelar.Name = "btnVendaCancelar";
            this.btnVendaCancelar.Size = new System.Drawing.Size(109, 60);
            this.btnVendaCancelar.TabIndex = 10;
            this.btnVendaCancelar.Text = "Cancelar";
            this.btnVendaCancelar.UseVisualStyleBackColor = true;
            this.btnVendaCancelar.Click += new System.EventHandler(this.btnVendaCancelar_Click);
            // 
            // btnVendaFinalizar
            // 
            this.btnVendaFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendaFinalizar.Location = new System.Drawing.Point(863, 149);
            this.btnVendaFinalizar.Name = "btnVendaFinalizar";
            this.btnVendaFinalizar.Size = new System.Drawing.Size(109, 60);
            this.btnVendaFinalizar.TabIndex = 9;
            this.btnVendaFinalizar.Text = "Finalizar";
            this.btnVendaFinalizar.UseVisualStyleBackColor = true;
            this.btnVendaFinalizar.Click += new System.EventHandler(this.btnVendaFinalizar_Click);
            // 
            // fmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1066, 643);
            this.Controls.Add(this.panelVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.fmVenda_Load);
            this.panelVenda.ResumeLayout(false);
            this.grBoxVendaProdutosCadastrados.ResumeLayout(false);
            this.grBoxVendaProdutosCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendaPesqProdutos)).EndInit();
            this.grBoxVenda.ResumeLayout(false);
            this.grBoxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVenda;
        private System.Windows.Forms.DataGridView dataGridViewVenda;
        private System.Windows.Forms.GroupBox grBoxVendaProdutosCadastrados;
        private System.Windows.Forms.TextBox txtVendaConsumidor;
        private System.Windows.Forms.Label lbVendaConsumidor;
        private System.Windows.Forms.Label lbVendaData;
        private System.Windows.Forms.GroupBox grBoxVenda;
        private System.Windows.Forms.Button btnVendaCancelar;
        private System.Windows.Forms.Button btnVendaFinalizar;
        private System.Windows.Forms.TextBox txtVendaValorTotal;
        private System.Windows.Forms.Label lbVendaValorTotal;
        private System.Windows.Forms.DataGridView dataGridViewVendaPesqProdutos;
        private System.Windows.Forms.Label lbVendaNome;
        private System.Windows.Forms.TextBox txtVendaNomeProduto;
        private System.Windows.Forms.Label lbVendaQuantidade;
        private System.Windows.Forms.TextBox txtVendaQuantidade;
        private System.Windows.Forms.ComboBox comboBoxVendaPagamento;
        private System.Windows.Forms.Label lbVendaPagamento;
        private System.Windows.Forms.TextBox txtVendaDesconto;
        private System.Windows.Forms.Label lbVendaDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosagem;
        private System.Windows.Forms.MaskedTextBox maskVendaData;
        private System.Windows.Forms.MaskedTextBox maskVendaRSDesconto;
        private System.Windows.Forms.MaskedTextBox maskVendaRSTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.TextBox txtVendaCodigo;
        private System.Windows.Forms.Label lbVendaCodigo;
    }
}