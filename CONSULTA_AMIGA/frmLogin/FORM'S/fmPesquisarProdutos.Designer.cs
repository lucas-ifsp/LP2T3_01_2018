namespace frmLogin
{
    partial class fmPesquisarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisarProdutos));
            this.panelPesqProdutosResultado = new System.Windows.Forms.Panel();
            this.btnPesqProdutosRefresh = new System.Windows.Forms.Button();
            this.lbPesqProdutosVoltar = new System.Windows.Forms.Label();
            this.groupBoxPesquisaProdutosResultado = new System.Windows.Forms.GroupBox();
            this.lbPesqProdutosNome = new System.Windows.Forms.Label();
            this.txtPesqProdutosNome = new System.Windows.Forms.TextBox();
            this.dataGridViewPesqProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesqProdutosVoltar = new System.Windows.Forms.Button();
            this.panelPesqProdutosResultado.SuspendLayout();
            this.groupBoxPesquisaProdutosResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPesqProdutosResultado
            // 
            this.panelPesqProdutosResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPesqProdutosResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPesqProdutosResultado.Controls.Add(this.btnPesqProdutosRefresh);
            this.panelPesqProdutosResultado.Controls.Add(this.lbPesqProdutosVoltar);
            this.panelPesqProdutosResultado.Controls.Add(this.groupBoxPesquisaProdutosResultado);
            this.panelPesqProdutosResultado.Controls.Add(this.btnPesqProdutosVoltar);
            this.panelPesqProdutosResultado.Location = new System.Drawing.Point(13, 14);
            this.panelPesqProdutosResultado.Name = "panelPesqProdutosResultado";
            this.panelPesqProdutosResultado.Size = new System.Drawing.Size(749, 583);
            this.panelPesqProdutosResultado.TabIndex = 0;
            // 
            // btnPesqProdutosRefresh
            // 
            this.btnPesqProdutosRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesqProdutosRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqProdutosRefresh.Image = global::frmLogin.Properties.Resources._1480491657_reload;
            this.btnPesqProdutosRefresh.Location = new System.Drawing.Point(694, 479);
            this.btnPesqProdutosRefresh.Name = "btnPesqProdutosRefresh";
            this.btnPesqProdutosRefresh.Size = new System.Drawing.Size(43, 38);
            this.btnPesqProdutosRefresh.TabIndex = 55;
            this.btnPesqProdutosRefresh.UseVisualStyleBackColor = true;
            this.btnPesqProdutosRefresh.Click += new System.EventHandler(this.btnPesqProdutosRefresh_Click);
            // 
            // lbPesqProdutosVoltar
            // 
            this.lbPesqProdutosVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPesqProdutosVoltar.AutoSize = true;
            this.lbPesqProdutosVoltar.Location = new System.Drawing.Point(18, 504);
            this.lbPesqProdutosVoltar.Name = "lbPesqProdutosVoltar";
            this.lbPesqProdutosVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbPesqProdutosVoltar.TabIndex = 9;
            this.lbPesqProdutosVoltar.Text = "Voltar";
            // 
            // groupBoxPesquisaProdutosResultado
            // 
            this.groupBoxPesquisaProdutosResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesquisaProdutosResultado.Controls.Add(this.lbPesqProdutosNome);
            this.groupBoxPesquisaProdutosResultado.Controls.Add(this.txtPesqProdutosNome);
            this.groupBoxPesquisaProdutosResultado.Controls.Add(this.dataGridViewPesqProdutos);
            this.groupBoxPesquisaProdutosResultado.Location = new System.Drawing.Point(12, 17);
            this.groupBoxPesquisaProdutosResultado.Name = "groupBoxPesquisaProdutosResultado";
            this.groupBoxPesquisaProdutosResultado.Size = new System.Drawing.Size(725, 456);
            this.groupBoxPesquisaProdutosResultado.TabIndex = 0;
            this.groupBoxPesquisaProdutosResultado.TabStop = false;
            this.groupBoxPesquisaProdutosResultado.Text = "Resultado";
            // 
            // lbPesqProdutosNome
            // 
            this.lbPesqProdutosNome.AutoSize = true;
            this.lbPesqProdutosNome.Location = new System.Drawing.Point(21, 29);
            this.lbPesqProdutosNome.Name = "lbPesqProdutosNome";
            this.lbPesqProdutosNome.Size = new System.Drawing.Size(35, 13);
            this.lbPesqProdutosNome.TabIndex = 30;
            this.lbPesqProdutosNome.Text = "Nome";
            // 
            // txtPesqProdutosNome
            // 
            this.txtPesqProdutosNome.Location = new System.Drawing.Point(24, 45);
            this.txtPesqProdutosNome.Name = "txtPesqProdutosNome";
            this.txtPesqProdutosNome.Size = new System.Drawing.Size(297, 20);
            this.txtPesqProdutosNome.TabIndex = 1;
            this.txtPesqProdutosNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesqProdutosNome_KeyUp);
            // 
            // dataGridViewPesqProdutos
            // 
            this.dataGridViewPesqProdutos.AllowUserToAddRows = false;
            this.dataGridViewPesqProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewPesqProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesqProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesqProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesqProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Tipo,
            this.Nome,
            this.Marca,
            this.PrecoCusto,
            this.PrecoVenda,
            this.Estoque,
            this.Dosagem});
            this.dataGridViewPesqProdutos.Location = new System.Drawing.Point(6, 89);
            this.dataGridViewPesqProdutos.Name = "dataGridViewPesqProdutos";
            this.dataGridViewPesqProdutos.ReadOnly = true;
            this.dataGridViewPesqProdutos.Size = new System.Drawing.Size(713, 361);
            this.dataGridViewPesqProdutos.TabIndex = 10;
            this.dataGridViewPesqProdutos.DoubleClick += new System.EventHandler(this.dataGridViewPesqProdutos_DoubleClick);
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
            // PrecoCusto
            // 
            this.PrecoCusto.HeaderText = "CUSTO";
            this.PrecoCusto.Name = "PrecoCusto";
            this.PrecoCusto.ReadOnly = true;
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.HeaderText = "VENDA";
            this.PrecoVenda.Name = "PrecoVenda";
            this.PrecoVenda.ReadOnly = true;
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
            // btnPesqProdutosVoltar
            // 
            this.btnPesqProdutosVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesqProdutosVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqProdutosVoltar.BackgroundImage")));
            this.btnPesqProdutosVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqProdutosVoltar.Location = new System.Drawing.Point(12, 520);
            this.btnPesqProdutosVoltar.Name = "btnPesqProdutosVoltar";
            this.btnPesqProdutosVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnPesqProdutosVoltar.TabIndex = 3;
            this.btnPesqProdutosVoltar.UseVisualStyleBackColor = true;
            this.btnPesqProdutosVoltar.Click += new System.EventHandler(this.btnPesqAnimaisVoltar_Click);
            // 
            // fmPesquisarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(774, 610);
            this.Controls.Add(this.panelPesqProdutosResultado);
            this.Name = "fmPesquisarProdutos";
            this.Text = "Pesquisar Produto";
            this.panelPesqProdutosResultado.ResumeLayout(false);
            this.panelPesqProdutosResultado.PerformLayout();
            this.groupBoxPesquisaProdutosResultado.ResumeLayout(false);
            this.groupBoxPesquisaProdutosResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPesqProdutosResultado;
        private System.Windows.Forms.Label lbPesqProdutosVoltar;
        private System.Windows.Forms.GroupBox groupBoxPesquisaProdutosResultado;
        private System.Windows.Forms.Label lbPesqProdutosNome;
        private System.Windows.Forms.TextBox txtPesqProdutosNome;
        private System.Windows.Forms.DataGridView dataGridViewPesqProdutos;
        private System.Windows.Forms.Button btnPesqProdutosVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosagem;
        private System.Windows.Forms.Button btnPesqProdutosRefresh;
    }
}