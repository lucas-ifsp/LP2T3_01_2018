namespace frmLogin
{
    partial class fmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRelatorios));
            this.panelRelatorios = new System.Windows.Forms.Panel();
            this.btnRelatoriosDoacoesImprimir = new System.Windows.Forms.Button();
            this.grBoxRelatorios = new System.Windows.Forms.GroupBox();
            this.groupBoxRelatoriosResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewRelatoriosItensVenda = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRelatoriosVendas = new System.Windows.Forms.DataGridView();
            this.Código_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamentoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRelatoriosDoacoes = new System.Windows.Forms.DataGridView();
            this.DataDoacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDoacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRelatoriosConsultas = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsável = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnóstico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observações = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRelatoriosDoacoes = new System.Windows.Forms.Button();
            this.btnRelatoriosVendas = new System.Windows.Forms.Button();
            this.btnRelatoriosConsultas = new System.Windows.Forms.Button();
            this.lbRelatoriosVoltar = new System.Windows.Forms.Label();
            this.btnRelatoriosVoltar = new System.Windows.Forms.Button();
            this.btnRelatoriosVendasImprimir = new System.Windows.Forms.Button();
            this.btnRelatoriosConsultasImprimir = new System.Windows.Forms.Button();
            this.panelRelatorios.SuspendLayout();
            this.grBoxRelatorios.SuspendLayout();
            this.groupBoxRelatoriosResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosDoacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRelatorios
            // 
            this.panelRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRelatorios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRelatorios.Controls.Add(this.btnRelatoriosConsultasImprimir);
            this.panelRelatorios.Controls.Add(this.btnRelatoriosVendasImprimir);
            this.panelRelatorios.Controls.Add(this.btnRelatoriosDoacoesImprimir);
            this.panelRelatorios.Controls.Add(this.grBoxRelatorios);
            this.panelRelatorios.Controls.Add(this.lbRelatoriosVoltar);
            this.panelRelatorios.Controls.Add(this.btnRelatoriosVoltar);
            this.panelRelatorios.Location = new System.Drawing.Point(10, 12);
            this.panelRelatorios.Name = "panelRelatorios";
            this.panelRelatorios.Size = new System.Drawing.Size(1038, 730);
            this.panelRelatorios.TabIndex = 0;
            // 
            // btnRelatoriosDoacoesImprimir
            // 
            this.btnRelatoriosDoacoesImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatoriosDoacoesImprimir.Location = new System.Drawing.Point(878, 661);
            this.btnRelatoriosDoacoesImprimir.Name = "btnRelatoriosDoacoesImprimir";
            this.btnRelatoriosDoacoesImprimir.Size = new System.Drawing.Size(137, 59);
            this.btnRelatoriosDoacoesImprimir.TabIndex = 52;
            this.btnRelatoriosDoacoesImprimir.Text = "Imprimir";
            this.btnRelatoriosDoacoesImprimir.UseVisualStyleBackColor = true;
            this.btnRelatoriosDoacoesImprimir.Click += new System.EventHandler(this.btnRelatoriosDoacoesImprimir_Click);
            // 
            // grBoxRelatorios
            // 
            this.grBoxRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxRelatorios.Controls.Add(this.groupBoxRelatoriosResultado);
            this.grBoxRelatorios.Controls.Add(this.btnRelatoriosDoacoes);
            this.grBoxRelatorios.Controls.Add(this.btnRelatoriosVendas);
            this.grBoxRelatorios.Controls.Add(this.btnRelatoriosConsultas);
            this.grBoxRelatorios.Location = new System.Drawing.Point(21, 20);
            this.grBoxRelatorios.Name = "grBoxRelatorios";
            this.grBoxRelatorios.Size = new System.Drawing.Size(994, 629);
            this.grBoxRelatorios.TabIndex = 0;
            this.grBoxRelatorios.TabStop = false;
            this.grBoxRelatorios.Text = "Relatórios";
            // 
            // groupBoxRelatoriosResultado
            // 
            this.groupBoxRelatoriosResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRelatoriosResultado.Controls.Add(this.dataGridViewRelatoriosItensVenda);
            this.groupBoxRelatoriosResultado.Controls.Add(this.dataGridViewRelatoriosVendas);
            this.groupBoxRelatoriosResultado.Controls.Add(this.dataGridViewRelatoriosDoacoes);
            this.groupBoxRelatoriosResultado.Controls.Add(this.dataGridViewRelatoriosConsultas);
            this.groupBoxRelatoriosResultado.Location = new System.Drawing.Point(6, 121);
            this.groupBoxRelatoriosResultado.Name = "groupBoxRelatoriosResultado";
            this.groupBoxRelatoriosResultado.Size = new System.Drawing.Size(982, 502);
            this.groupBoxRelatoriosResultado.TabIndex = 4;
            this.groupBoxRelatoriosResultado.TabStop = false;
            this.groupBoxRelatoriosResultado.Text = "Resultado";
            // 
            // dataGridViewRelatoriosItensVenda
            // 
            this.dataGridViewRelatoriosItensVenda.AllowUserToAddRows = false;
            this.dataGridViewRelatoriosItensVenda.AllowUserToDeleteRows = false;
            this.dataGridViewRelatoriosItensVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRelatoriosItensVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelatoriosItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatoriosItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Marca,
            this.Tipo,
            this.Preço,
            this.Dosagem});
            this.dataGridViewRelatoriosItensVenda.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewRelatoriosItensVenda.Name = "dataGridViewRelatoriosItensVenda";
            this.dataGridViewRelatoriosItensVenda.ReadOnly = true;
            this.dataGridViewRelatoriosItensVenda.Size = new System.Drawing.Size(982, 470);
            this.dataGridViewRelatoriosItensVenda.TabIndex = 51;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "PRODUTO";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
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
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "PREÇO";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // Dosagem
            // 
            this.Dosagem.HeaderText = "DOSAGEM";
            this.Dosagem.Name = "Dosagem";
            this.Dosagem.ReadOnly = true;
            // 
            // dataGridViewRelatoriosVendas
            // 
            this.dataGridViewRelatoriosVendas.AllowUserToAddRows = false;
            this.dataGridViewRelatoriosVendas.AllowUserToDeleteRows = false;
            this.dataGridViewRelatoriosVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRelatoriosVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelatoriosVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatoriosVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código_Venda,
            this.DataVenda,
            this.Consumidor,
            this.FormaPagamentoVenda,
            this.Desconto,
            this.ValorTotal});
            this.dataGridViewRelatoriosVendas.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewRelatoriosVendas.Name = "dataGridViewRelatoriosVendas";
            this.dataGridViewRelatoriosVendas.ReadOnly = true;
            this.dataGridViewRelatoriosVendas.Size = new System.Drawing.Size(982, 470);
            this.dataGridViewRelatoriosVendas.TabIndex = 50;
            this.dataGridViewRelatoriosVendas.DoubleClick += new System.EventHandler(this.dataGridViewRelatoriosVendas_DoubleClick);
            // 
            // Código_Venda
            // 
            this.Código_Venda.HeaderText = "CÓDIGO";
            this.Código_Venda.Name = "Código_Venda";
            this.Código_Venda.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.HeaderText = "DATA";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // Consumidor
            // 
            this.Consumidor.HeaderText = "CONSUMIDOR";
            this.Consumidor.Name = "Consumidor";
            this.Consumidor.ReadOnly = true;
            // 
            // FormaPagamentoVenda
            // 
            this.FormaPagamentoVenda.HeaderText = "PAGAMENTO";
            this.FormaPagamentoVenda.Name = "FormaPagamentoVenda";
            this.FormaPagamentoVenda.ReadOnly = true;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "DESCONTO";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "VALOR TOTAL";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // dataGridViewRelatoriosDoacoes
            // 
            this.dataGridViewRelatoriosDoacoes.AllowUserToAddRows = false;
            this.dataGridViewRelatoriosDoacoes.AllowUserToDeleteRows = false;
            this.dataGridViewRelatoriosDoacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRelatoriosDoacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelatoriosDoacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatoriosDoacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataDoacao,
            this.Doador,
            this.ValorDoacao,
            this.FormaPagamento,
            this.Observacoes});
            this.dataGridViewRelatoriosDoacoes.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewRelatoriosDoacoes.Name = "dataGridViewRelatoriosDoacoes";
            this.dataGridViewRelatoriosDoacoes.ReadOnly = true;
            this.dataGridViewRelatoriosDoacoes.Size = new System.Drawing.Size(982, 470);
            this.dataGridViewRelatoriosDoacoes.TabIndex = 4;
            // 
            // DataDoacao
            // 
            this.DataDoacao.HeaderText = "DATA";
            this.DataDoacao.Name = "DataDoacao";
            this.DataDoacao.ReadOnly = true;
            // 
            // Doador
            // 
            this.Doador.HeaderText = "DOADOR";
            this.Doador.Name = "Doador";
            this.Doador.ReadOnly = true;
            // 
            // ValorDoacao
            // 
            this.ValorDoacao.HeaderText = "VALOR";
            this.ValorDoacao.Name = "ValorDoacao";
            this.ValorDoacao.ReadOnly = true;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.HeaderText = "FORMA DE PAGAMENTO";
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.ReadOnly = true;
            // 
            // Observacoes
            // 
            this.Observacoes.HeaderText = "OBSERVAÇÕES";
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            // 
            // dataGridViewRelatoriosConsultas
            // 
            this.dataGridViewRelatoriosConsultas.AllowUserToAddRows = false;
            this.dataGridViewRelatoriosConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewRelatoriosConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRelatoriosConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelatoriosConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatoriosConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Hora,
            this.Responsável,
            this.Animal,
            this.Diagnóstico,
            this.Receita,
            this.Observações});
            this.dataGridViewRelatoriosConsultas.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewRelatoriosConsultas.Name = "dataGridViewRelatoriosConsultas";
            this.dataGridViewRelatoriosConsultas.ReadOnly = true;
            this.dataGridViewRelatoriosConsultas.Size = new System.Drawing.Size(982, 470);
            this.dataGridViewRelatoriosConsultas.TabIndex = 3;
            // 
            // Data
            // 
            this.Data.HeaderText = "DATA";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "HORA";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Responsável
            // 
            this.Responsável.HeaderText = "RESPONSÁVEL";
            this.Responsável.Name = "Responsável";
            this.Responsável.ReadOnly = true;
            // 
            // Animal
            // 
            this.Animal.HeaderText = "ANIMAL";
            this.Animal.Name = "Animal";
            this.Animal.ReadOnly = true;
            // 
            // Diagnóstico
            // 
            this.Diagnóstico.HeaderText = "DIAGNÓSTICO";
            this.Diagnóstico.Name = "Diagnóstico";
            this.Diagnóstico.ReadOnly = true;
            // 
            // Receita
            // 
            this.Receita.HeaderText = "RECEITA";
            this.Receita.Name = "Receita";
            this.Receita.ReadOnly = true;
            // 
            // Observações
            // 
            this.Observações.HeaderText = "OBSERVAÇÕES";
            this.Observações.Name = "Observações";
            this.Observações.ReadOnly = true;
            // 
            // btnRelatoriosDoacoes
            // 
            this.btnRelatoriosDoacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRelatoriosDoacoes.Location = new System.Drawing.Point(378, 43);
            this.btnRelatoriosDoacoes.Name = "btnRelatoriosDoacoes";
            this.btnRelatoriosDoacoes.Size = new System.Drawing.Size(234, 43);
            this.btnRelatoriosDoacoes.TabIndex = 2;
            this.btnRelatoriosDoacoes.Text = "Doações ";
            this.btnRelatoriosDoacoes.UseVisualStyleBackColor = true;
            this.btnRelatoriosDoacoes.Click += new System.EventHandler(this.btnRelatoriosDoacoes_Click);
            // 
            // btnRelatoriosVendas
            // 
            this.btnRelatoriosVendas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRelatoriosVendas.Location = new System.Drawing.Point(667, 43);
            this.btnRelatoriosVendas.Name = "btnRelatoriosVendas";
            this.btnRelatoriosVendas.Size = new System.Drawing.Size(234, 43);
            this.btnRelatoriosVendas.TabIndex = 3;
            this.btnRelatoriosVendas.Text = "Vendas ";
            this.btnRelatoriosVendas.UseVisualStyleBackColor = true;
            this.btnRelatoriosVendas.Click += new System.EventHandler(this.btnRelatoriosVendas_Click);
            // 
            // btnRelatoriosConsultas
            // 
            this.btnRelatoriosConsultas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRelatoriosConsultas.Location = new System.Drawing.Point(86, 43);
            this.btnRelatoriosConsultas.Name = "btnRelatoriosConsultas";
            this.btnRelatoriosConsultas.Size = new System.Drawing.Size(234, 43);
            this.btnRelatoriosConsultas.TabIndex = 1;
            this.btnRelatoriosConsultas.Text = "Consultas ";
            this.btnRelatoriosConsultas.UseVisualStyleBackColor = true;
            this.btnRelatoriosConsultas.Click += new System.EventHandler(this.btnRelatoriosConsultas_Click);
            // 
            // lbRelatoriosVoltar
            // 
            this.lbRelatoriosVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRelatoriosVoltar.AutoSize = true;
            this.lbRelatoriosVoltar.Location = new System.Drawing.Point(9, 661);
            this.lbRelatoriosVoltar.Name = "lbRelatoriosVoltar";
            this.lbRelatoriosVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbRelatoriosVoltar.TabIndex = 70;
            this.lbRelatoriosVoltar.Text = "Voltar";
            // 
            // btnRelatoriosVoltar
            // 
            this.btnRelatoriosVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRelatoriosVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatoriosVoltar.BackgroundImage")));
            this.btnRelatoriosVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatoriosVoltar.Location = new System.Drawing.Point(3, 677);
            this.btnRelatoriosVoltar.Name = "btnRelatoriosVoltar";
            this.btnRelatoriosVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnRelatoriosVoltar.TabIndex = 4;
            this.btnRelatoriosVoltar.UseVisualStyleBackColor = true;
            this.btnRelatoriosVoltar.Click += new System.EventHandler(this.btnPessoaVoltar_Click);
            // 
            // btnRelatoriosVendasImprimir
            // 
            this.btnRelatoriosVendasImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatoriosVendasImprimir.Location = new System.Drawing.Point(878, 661);
            this.btnRelatoriosVendasImprimir.Name = "btnRelatoriosVendasImprimir";
            this.btnRelatoriosVendasImprimir.Size = new System.Drawing.Size(137, 59);
            this.btnRelatoriosVendasImprimir.TabIndex = 71;
            this.btnRelatoriosVendasImprimir.Text = "Imprimir";
            this.btnRelatoriosVendasImprimir.UseVisualStyleBackColor = true;
            this.btnRelatoriosVendasImprimir.Click += new System.EventHandler(this.btnRelatoriosVendasImprimir_Click);
            // 
            // btnRelatoriosConsultasImprimir
            // 
            this.btnRelatoriosConsultasImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatoriosConsultasImprimir.Location = new System.Drawing.Point(878, 661);
            this.btnRelatoriosConsultasImprimir.Name = "btnRelatoriosConsultasImprimir";
            this.btnRelatoriosConsultasImprimir.Size = new System.Drawing.Size(137, 59);
            this.btnRelatoriosConsultasImprimir.TabIndex = 72;
            this.btnRelatoriosConsultasImprimir.Text = "Imprimir";
            this.btnRelatoriosConsultasImprimir.UseVisualStyleBackColor = true;
            this.btnRelatoriosConsultasImprimir.Click += new System.EventHandler(this.btnRelatoriosConsultasImprimir_Click);
            // 
            // fmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1060, 754);
            this.Controls.Add(this.panelRelatorios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmRelatorios";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.fmRelatorios_Load);
            this.panelRelatorios.ResumeLayout(false);
            this.panelRelatorios.PerformLayout();
            this.grBoxRelatorios.ResumeLayout(false);
            this.groupBoxRelatoriosResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosDoacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatoriosConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRelatorios;
        private System.Windows.Forms.GroupBox grBoxRelatorios;
        private System.Windows.Forms.Button btnRelatoriosConsultas;
        private System.Windows.Forms.Label lbRelatoriosVoltar;
        private System.Windows.Forms.Button btnRelatoriosVoltar;
        private System.Windows.Forms.GroupBox groupBoxRelatoriosResultado;
        private System.Windows.Forms.Button btnRelatoriosDoacoes;
        private System.Windows.Forms.Button btnRelatoriosVendas;
        private System.Windows.Forms.DataGridView dataGridViewRelatoriosConsultas;
        private System.Windows.Forms.DataGridView dataGridViewRelatoriosDoacoes;
        private System.Windows.Forms.DataGridView dataGridViewRelatoriosVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDoacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDoacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsável;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnóstico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observações;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamentoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridView dataGridViewRelatoriosItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosagem;
        private System.Windows.Forms.Button btnRelatoriosDoacoesImprimir;
        private System.Windows.Forms.Button btnRelatoriosVendasImprimir;
        private System.Windows.Forms.Button btnRelatoriosConsultasImprimir;
    }
}