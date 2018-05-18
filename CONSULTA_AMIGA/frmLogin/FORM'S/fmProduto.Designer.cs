namespace frmLogin
{
    partial class fmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmProduto));
            this.panel2Produto = new System.Windows.Forms.Panel();
            this.grBoxProdutoDados = new System.Windows.Forms.GroupBox();
            this.txtProdutoPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtProdutoPrecoCusto = new System.Windows.Forms.TextBox();
            this.maskProdutoRSVenda = new System.Windows.Forms.MaskedTextBox();
            this.maskProdutoRSCusto = new System.Windows.Forms.MaskedTextBox();
            this.txtProdutoDosagem = new System.Windows.Forms.TextBox();
            this.txtProdutoDescricao = new System.Windows.Forms.TextBox();
            this.lbProdutoDosagem = new System.Windows.Forms.Label();
            this.lbProdutoDescricao = new System.Windows.Forms.Label();
            this.lbProdutoPrecoVenda = new System.Windows.Forms.Label();
            this.txtProdutoMarca = new System.Windows.Forms.TextBox();
            this.lbProdutoMarca = new System.Windows.Forms.Label();
            this.groupBoxProdutoTipo = new System.Windows.Forms.GroupBox();
            this.radBtnProdutoVacina = new System.Windows.Forms.RadioButton();
            this.radBtnProdutoGeral = new System.Windows.Forms.RadioButton();
            this.radBtnProdutoMedicamento = new System.Windows.Forms.RadioButton();
            this.txtProdutoQuantidade = new System.Windows.Forms.TextBox();
            this.txtProdutoCodigo = new System.Windows.Forms.TextBox();
            this.txtProdutoNome = new System.Windows.Forms.TextBox();
            this.lbProdutoQuantidade = new System.Windows.Forms.Label();
            this.lbProdutoPrecoCusto = new System.Windows.Forms.Label();
            this.lbProdutoNome = new System.Windows.Forms.Label();
            this.lbProdutoCodigo = new System.Windows.Forms.Label();
            this.btnProdutoRemover = new System.Windows.Forms.Button();
            this.btnProdutoAlterar = new System.Windows.Forms.Button();
            this.btnProdutoProcurar = new System.Windows.Forms.Button();
            this.btnProdutoCadastrar = new System.Windows.Forms.Button();
            this.lbProdutoVoltar = new System.Windows.Forms.Label();
            this.btnProdutoVoltar = new System.Windows.Forms.Button();
            this.panel1Produto = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbSair = new System.Windows.Forms.Label();
            this.panel2Produto.SuspendLayout();
            this.grBoxProdutoDados.SuspendLayout();
            this.groupBoxProdutoTipo.SuspendLayout();
            this.panel1Produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2Produto
            // 
            this.panel2Produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2Produto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2Produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2Produto.Controls.Add(this.grBoxProdutoDados);
            this.panel2Produto.Location = new System.Drawing.Point(210, 12);
            this.panel2Produto.Name = "panel2Produto";
            this.panel2Produto.Size = new System.Drawing.Size(607, 556);
            this.panel2Produto.TabIndex = 0;
            // 
            // grBoxProdutoDados
            // 
            this.grBoxProdutoDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoPrecoVenda);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoPrecoCusto);
            this.grBoxProdutoDados.Controls.Add(this.maskProdutoRSVenda);
            this.grBoxProdutoDados.Controls.Add(this.maskProdutoRSCusto);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoDosagem);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoDescricao);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoDosagem);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoDescricao);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoPrecoVenda);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoMarca);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoMarca);
            this.grBoxProdutoDados.Controls.Add(this.groupBoxProdutoTipo);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoQuantidade);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoCodigo);
            this.grBoxProdutoDados.Controls.Add(this.txtProdutoNome);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoQuantidade);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoPrecoCusto);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoNome);
            this.grBoxProdutoDados.Controls.Add(this.lbProdutoCodigo);
            this.grBoxProdutoDados.Location = new System.Drawing.Point(35, 28);
            this.grBoxProdutoDados.Name = "grBoxProdutoDados";
            this.grBoxProdutoDados.Size = new System.Drawing.Size(537, 498);
            this.grBoxProdutoDados.TabIndex = 0;
            this.grBoxProdutoDados.TabStop = false;
            this.grBoxProdutoDados.Text = "Dados";
            // 
            // txtProdutoPrecoVenda
            // 
            this.txtProdutoPrecoVenda.Location = new System.Drawing.Point(324, 207);
            this.txtProdutoPrecoVenda.Name = "txtProdutoPrecoVenda";
            this.txtProdutoPrecoVenda.Size = new System.Drawing.Size(168, 20);
            this.txtProdutoPrecoVenda.TabIndex = 9;
            this.txtProdutoPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoPrecoVenda_KeyDown);
            this.txtProdutoPrecoVenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdutoPrecoVenda_KeyUp);
            // 
            // txtProdutoPrecoCusto
            // 
            this.txtProdutoPrecoCusto.Location = new System.Drawing.Point(324, 158);
            this.txtProdutoPrecoCusto.Name = "txtProdutoPrecoCusto";
            this.txtProdutoPrecoCusto.Size = new System.Drawing.Size(168, 20);
            this.txtProdutoPrecoCusto.TabIndex = 8;
            this.txtProdutoPrecoCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoPrecoCusto_KeyDown);
            this.txtProdutoPrecoCusto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdutoPrecoCusto_KeyUp);
            // 
            // maskProdutoRSVenda
            // 
            this.maskProdutoRSVenda.Location = new System.Drawing.Point(304, 207);
            this.maskProdutoRSVenda.Mask = "$";
            this.maskProdutoRSVenda.Name = "maskProdutoRSVenda";
            this.maskProdutoRSVenda.Size = new System.Drawing.Size(48, 20);
            this.maskProdutoRSVenda.TabIndex = 45;
            // 
            // maskProdutoRSCusto
            // 
            this.maskProdutoRSCusto.Location = new System.Drawing.Point(304, 158);
            this.maskProdutoRSCusto.Mask = "$";
            this.maskProdutoRSCusto.Name = "maskProdutoRSCusto";
            this.maskProdutoRSCusto.Size = new System.Drawing.Size(21, 20);
            this.maskProdutoRSCusto.TabIndex = 44;
            // 
            // txtProdutoDosagem
            // 
            this.txtProdutoDosagem.Location = new System.Drawing.Point(304, 253);
            this.txtProdutoDosagem.Name = "txtProdutoDosagem";
            this.txtProdutoDosagem.Size = new System.Drawing.Size(188, 20);
            this.txtProdutoDosagem.TabIndex = 10;
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Location = new System.Drawing.Point(45, 316);
            this.txtProdutoDescricao.Multiline = true;
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(447, 135);
            this.txtProdutoDescricao.TabIndex = 11;
            // 
            // lbProdutoDosagem
            // 
            this.lbProdutoDosagem.AutoSize = true;
            this.lbProdutoDosagem.Location = new System.Drawing.Point(301, 236);
            this.lbProdutoDosagem.Name = "lbProdutoDosagem";
            this.lbProdutoDosagem.Size = new System.Drawing.Size(52, 13);
            this.lbProdutoDosagem.TabIndex = 32;
            this.lbProdutoDosagem.Text = "Dosagem";
            // 
            // lbProdutoDescricao
            // 
            this.lbProdutoDescricao.AutoSize = true;
            this.lbProdutoDescricao.Location = new System.Drawing.Point(42, 300);
            this.lbProdutoDescricao.Name = "lbProdutoDescricao";
            this.lbProdutoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbProdutoDescricao.TabIndex = 43;
            this.lbProdutoDescricao.Text = "Descrição";
            // 
            // lbProdutoPrecoVenda
            // 
            this.lbProdutoPrecoVenda.AutoSize = true;
            this.lbProdutoPrecoVenda.Location = new System.Drawing.Point(301, 191);
            this.lbProdutoPrecoVenda.Name = "lbProdutoPrecoVenda";
            this.lbProdutoPrecoVenda.Size = new System.Drawing.Size(84, 13);
            this.lbProdutoPrecoVenda.TabIndex = 41;
            this.lbProdutoPrecoVenda.Text = "Preço de Venda";
            // 
            // txtProdutoMarca
            // 
            this.txtProdutoMarca.Location = new System.Drawing.Point(45, 207);
            this.txtProdutoMarca.Name = "txtProdutoMarca";
            this.txtProdutoMarca.Size = new System.Drawing.Size(222, 20);
            this.txtProdutoMarca.TabIndex = 6;
            // 
            // lbProdutoMarca
            // 
            this.lbProdutoMarca.AutoSize = true;
            this.lbProdutoMarca.Location = new System.Drawing.Point(42, 191);
            this.lbProdutoMarca.Name = "lbProdutoMarca";
            this.lbProdutoMarca.Size = new System.Drawing.Size(37, 13);
            this.lbProdutoMarca.TabIndex = 39;
            this.lbProdutoMarca.Text = "Marca";
            // 
            // groupBoxProdutoTipo
            // 
            this.groupBoxProdutoTipo.Controls.Add(this.radBtnProdutoVacina);
            this.groupBoxProdutoTipo.Controls.Add(this.radBtnProdutoGeral);
            this.groupBoxProdutoTipo.Controls.Add(this.radBtnProdutoMedicamento);
            this.groupBoxProdutoTipo.Location = new System.Drawing.Point(45, 41);
            this.groupBoxProdutoTipo.Name = "groupBoxProdutoTipo";
            this.groupBoxProdutoTipo.Size = new System.Drawing.Size(447, 36);
            this.groupBoxProdutoTipo.TabIndex = 1;
            this.groupBoxProdutoTipo.TabStop = false;
            this.groupBoxProdutoTipo.Text = "Tipo";
            // 
            // radBtnProdutoVacina
            // 
            this.radBtnProdutoVacina.AutoSize = true;
            this.radBtnProdutoVacina.Location = new System.Drawing.Point(318, 13);
            this.radBtnProdutoVacina.Name = "radBtnProdutoVacina";
            this.radBtnProdutoVacina.Size = new System.Drawing.Size(58, 17);
            this.radBtnProdutoVacina.TabIndex = 3;
            this.radBtnProdutoVacina.Text = "Vacina";
            this.radBtnProdutoVacina.UseVisualStyleBackColor = true;
            this.radBtnProdutoVacina.Click += new System.EventHandler(this.radBtnProdutoVacina_Click);
            // 
            // radBtnProdutoGeral
            // 
            this.radBtnProdutoGeral.AutoSize = true;
            this.radBtnProdutoGeral.Checked = true;
            this.radBtnProdutoGeral.Location = new System.Drawing.Point(71, 13);
            this.radBtnProdutoGeral.Name = "radBtnProdutoGeral";
            this.radBtnProdutoGeral.Size = new System.Drawing.Size(50, 17);
            this.radBtnProdutoGeral.TabIndex = 1;
            this.radBtnProdutoGeral.TabStop = true;
            this.radBtnProdutoGeral.Text = "Geral";
            this.radBtnProdutoGeral.UseVisualStyleBackColor = true;
            this.radBtnProdutoGeral.CheckedChanged += new System.EventHandler(this.radBtnProdutoGeral_CheckedChanged);
            // 
            // radBtnProdutoMedicamento
            // 
            this.radBtnProdutoMedicamento.AutoSize = true;
            this.radBtnProdutoMedicamento.Location = new System.Drawing.Point(176, 13);
            this.radBtnProdutoMedicamento.Name = "radBtnProdutoMedicamento";
            this.radBtnProdutoMedicamento.Size = new System.Drawing.Size(89, 17);
            this.radBtnProdutoMedicamento.TabIndex = 2;
            this.radBtnProdutoMedicamento.Text = "Medicamento";
            this.radBtnProdutoMedicamento.UseVisualStyleBackColor = true;
            this.radBtnProdutoMedicamento.Click += new System.EventHandler(this.radBtnProdutoMedicamento_Click);
            // 
            // txtProdutoQuantidade
            // 
            this.txtProdutoQuantidade.Location = new System.Drawing.Point(45, 252);
            this.txtProdutoQuantidade.Name = "txtProdutoQuantidade";
            this.txtProdutoQuantidade.Size = new System.Drawing.Size(222, 20);
            this.txtProdutoQuantidade.TabIndex = 7;
            this.txtProdutoQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoQuantidade_KeyDown);
            this.txtProdutoQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdutoQuantidade_KeyUp);
            // 
            // txtProdutoCodigo
            // 
            this.txtProdutoCodigo.Enabled = false;
            this.txtProdutoCodigo.Location = new System.Drawing.Point(45, 109);
            this.txtProdutoCodigo.Name = "txtProdutoCodigo";
            this.txtProdutoCodigo.Size = new System.Drawing.Size(188, 20);
            this.txtProdutoCodigo.TabIndex = 4;
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.Location = new System.Drawing.Point(45, 158);
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(222, 20);
            this.txtProdutoNome.TabIndex = 5;
            // 
            // lbProdutoQuantidade
            // 
            this.lbProdutoQuantidade.AutoSize = true;
            this.lbProdutoQuantidade.Location = new System.Drawing.Point(42, 236);
            this.lbProdutoQuantidade.Name = "lbProdutoQuantidade";
            this.lbProdutoQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbProdutoQuantidade.TabIndex = 29;
            this.lbProdutoQuantidade.Text = "Quantidade";
            // 
            // lbProdutoPrecoCusto
            // 
            this.lbProdutoPrecoCusto.AutoSize = true;
            this.lbProdutoPrecoCusto.Location = new System.Drawing.Point(301, 142);
            this.lbProdutoPrecoCusto.Name = "lbProdutoPrecoCusto";
            this.lbProdutoPrecoCusto.Size = new System.Drawing.Size(80, 13);
            this.lbProdutoPrecoCusto.TabIndex = 28;
            this.lbProdutoPrecoCusto.Text = "Preço de Custo";
            // 
            // lbProdutoNome
            // 
            this.lbProdutoNome.AutoSize = true;
            this.lbProdutoNome.Location = new System.Drawing.Point(42, 142);
            this.lbProdutoNome.Name = "lbProdutoNome";
            this.lbProdutoNome.Size = new System.Drawing.Size(35, 13);
            this.lbProdutoNome.TabIndex = 27;
            this.lbProdutoNome.Text = "Nome";
            // 
            // lbProdutoCodigo
            // 
            this.lbProdutoCodigo.AutoSize = true;
            this.lbProdutoCodigo.Location = new System.Drawing.Point(42, 93);
            this.lbProdutoCodigo.Name = "lbProdutoCodigo";
            this.lbProdutoCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbProdutoCodigo.TabIndex = 26;
            this.lbProdutoCodigo.Text = "Código";
            // 
            // btnProdutoRemover
            // 
            this.btnProdutoRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProdutoRemover.Location = new System.Drawing.Point(22, 117);
            this.btnProdutoRemover.Name = "btnProdutoRemover";
            this.btnProdutoRemover.Size = new System.Drawing.Size(159, 51);
            this.btnProdutoRemover.TabIndex = 13;
            this.btnProdutoRemover.Text = "Remover";
            this.btnProdutoRemover.UseVisualStyleBackColor = true;
            this.btnProdutoRemover.Click += new System.EventHandler(this.btnProdutoRemover_Click);
            // 
            // btnProdutoAlterar
            // 
            this.btnProdutoAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProdutoAlterar.Location = new System.Drawing.Point(22, 48);
            this.btnProdutoAlterar.Name = "btnProdutoAlterar";
            this.btnProdutoAlterar.Size = new System.Drawing.Size(159, 51);
            this.btnProdutoAlterar.TabIndex = 12;
            this.btnProdutoAlterar.Text = "Alterar";
            this.btnProdutoAlterar.UseVisualStyleBackColor = true;
            this.btnProdutoAlterar.Click += new System.EventHandler(this.btnProdutoAlterar_Click);
            // 
            // btnProdutoProcurar
            // 
            this.btnProdutoProcurar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProdutoProcurar.Location = new System.Drawing.Point(22, 117);
            this.btnProdutoProcurar.Name = "btnProdutoProcurar";
            this.btnProdutoProcurar.Size = new System.Drawing.Size(159, 51);
            this.btnProdutoProcurar.TabIndex = 15;
            this.btnProdutoProcurar.Text = "Procurar";
            this.btnProdutoProcurar.UseVisualStyleBackColor = true;
            this.btnProdutoProcurar.Click += new System.EventHandler(this.btnProdutoProcurar_Click);
            // 
            // btnProdutoCadastrar
            // 
            this.btnProdutoCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProdutoCadastrar.Location = new System.Drawing.Point(22, 48);
            this.btnProdutoCadastrar.Name = "btnProdutoCadastrar";
            this.btnProdutoCadastrar.Size = new System.Drawing.Size(159, 51);
            this.btnProdutoCadastrar.TabIndex = 14;
            this.btnProdutoCadastrar.Text = "Cadastrar";
            this.btnProdutoCadastrar.UseVisualStyleBackColor = true;
            this.btnProdutoCadastrar.Click += new System.EventHandler(this.btnProdutoCadastrar_Click);
            // 
            // lbProdutoVoltar
            // 
            this.lbProdutoVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProdutoVoltar.AutoSize = true;
            this.lbProdutoVoltar.Location = new System.Drawing.Point(9, 488);
            this.lbProdutoVoltar.Name = "lbProdutoVoltar";
            this.lbProdutoVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbProdutoVoltar.TabIndex = 52;
            this.lbProdutoVoltar.Text = "Voltar";
            // 
            // btnProdutoVoltar
            // 
            this.btnProdutoVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProdutoVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutoVoltar.BackgroundImage")));
            this.btnProdutoVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdutoVoltar.Location = new System.Drawing.Point(3, 504);
            this.btnProdutoVoltar.Name = "btnProdutoVoltar";
            this.btnProdutoVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnProdutoVoltar.TabIndex = 16;
            this.btnProdutoVoltar.UseVisualStyleBackColor = true;
            this.btnProdutoVoltar.Click += new System.EventHandler(this.btnProdutoVoltar_Click);
            // 
            // panel1Produto
            // 
            this.panel1Produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1Produto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1Produto.Controls.Add(this.btnSair);
            this.panel1Produto.Controls.Add(this.lbSair);
            this.panel1Produto.Controls.Add(this.btnProdutoRemover);
            this.panel1Produto.Controls.Add(this.lbProdutoVoltar);
            this.panel1Produto.Controls.Add(this.btnProdutoVoltar);
            this.panel1Produto.Controls.Add(this.btnProdutoAlterar);
            this.panel1Produto.Controls.Add(this.btnProdutoProcurar);
            this.panel1Produto.Controls.Add(this.btnProdutoCadastrar);
            this.panel1Produto.Location = new System.Drawing.Point(12, 12);
            this.panel1Produto.Name = "panel1Produto";
            this.panel1Produto.Size = new System.Drawing.Size(201, 556);
            this.panel1Produto.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(3, 504);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 49);
            this.btnSair.TabIndex = 57;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSair.AutoSize = true;
            this.lbSair.Location = new System.Drawing.Point(9, 488);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(34, 13);
            this.lbSair.TabIndex = 58;
            this.lbSair.Text = "  Sair ";
            // 
            // fmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(829, 580);
            this.Controls.Add(this.panel1Produto);
            this.Controls.Add(this.panel2Produto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.fmProduto_Load);
            this.panel2Produto.ResumeLayout(false);
            this.grBoxProdutoDados.ResumeLayout(false);
            this.grBoxProdutoDados.PerformLayout();
            this.groupBoxProdutoTipo.ResumeLayout(false);
            this.groupBoxProdutoTipo.PerformLayout();
            this.panel1Produto.ResumeLayout(false);
            this.panel1Produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2Produto;
        private System.Windows.Forms.GroupBox grBoxProdutoDados;
        private System.Windows.Forms.GroupBox groupBoxProdutoTipo;
        private System.Windows.Forms.RadioButton radBtnProdutoGeral;
        private System.Windows.Forms.RadioButton radBtnProdutoMedicamento;
        private System.Windows.Forms.TextBox txtProdutoQuantidade;
        private System.Windows.Forms.TextBox txtProdutoPrecoCusto;
        private System.Windows.Forms.TextBox txtProdutoCodigo;
        private System.Windows.Forms.TextBox txtProdutoNome;
        private System.Windows.Forms.Label lbProdutoQuantidade;
        private System.Windows.Forms.Label lbProdutoPrecoCusto;
        private System.Windows.Forms.Label lbProdutoNome;
        private System.Windows.Forms.Label lbProdutoCodigo;
        private System.Windows.Forms.Button btnProdutoRemover;
        private System.Windows.Forms.Button btnProdutoAlterar;
        private System.Windows.Forms.Button btnProdutoProcurar;
        private System.Windows.Forms.Button btnProdutoCadastrar;
        private System.Windows.Forms.Label lbProdutoVoltar;
        private System.Windows.Forms.Button btnProdutoVoltar;
        private System.Windows.Forms.TextBox txtProdutoPrecoVenda;
        private System.Windows.Forms.Label lbProdutoPrecoVenda;
        private System.Windows.Forms.TextBox txtProdutoMarca;
        private System.Windows.Forms.Label lbProdutoMarca;
        private System.Windows.Forms.RadioButton radBtnProdutoVacina;
        private System.Windows.Forms.TextBox txtProdutoDosagem;
        private System.Windows.Forms.Label lbProdutoDosagem;
        private System.Windows.Forms.TextBox txtProdutoDescricao;
        private System.Windows.Forms.Label lbProdutoDescricao;
        private System.Windows.Forms.MaskedTextBox maskProdutoRSCusto;
        private System.Windows.Forms.MaskedTextBox maskProdutoRSVenda;
        private System.Windows.Forms.Panel panel1Produto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbSair;
    }
}