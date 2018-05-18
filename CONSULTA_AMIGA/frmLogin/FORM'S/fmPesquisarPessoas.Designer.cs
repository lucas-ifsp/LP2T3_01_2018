namespace frmLogin
{
    partial class fmPesquisarPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisarPessoas));
            this.dataGridViewPesqPessoas = new System.Windows.Forms.DataGridView();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPesqPessoas = new System.Windows.Forms.Panel();
            this.btnPesqPessoasRefresh = new System.Windows.Forms.Button();
            this.lbPesqPessoasVoltar = new System.Windows.Forms.Label();
            this.groupBoxPesqPessoasResultado = new System.Windows.Forms.GroupBox();
            this.lbPesPessoasNome = new System.Windows.Forms.Label();
            this.txtPesqPessoasNome = new System.Windows.Forms.TextBox();
            this.btnPesqPessoasVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqPessoas)).BeginInit();
            this.panelPesqPessoas.SuspendLayout();
            this.groupBoxPesqPessoasResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPesqPessoas
            // 
            this.dataGridViewPesqPessoas.AllowUserToAddRows = false;
            this.dataGridViewPesqPessoas.AllowUserToDeleteRows = false;
            this.dataGridViewPesqPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesqPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesqPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesqPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.NOME,
            this.Telefone,
            this.Celular,
            this.Cidade,
            this.Estado});
            this.dataGridViewPesqPessoas.Location = new System.Drawing.Point(6, 89);
            this.dataGridViewPesqPessoas.Name = "dataGridViewPesqPessoas";
            this.dataGridViewPesqPessoas.ReadOnly = true;
            this.dataGridViewPesqPessoas.Size = new System.Drawing.Size(713, 361);
            this.dataGridViewPesqPessoas.TabIndex = 10;
            this.dataGridViewPesqPessoas.DoubleClick += new System.EventHandler(this.dataGridViewPesqPessoas_DoubleClick);
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "TELEFONE";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "CELULAR";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "CIDADE";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // panelPesqPessoas
            // 
            this.panelPesqPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPesqPessoas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPesqPessoas.Controls.Add(this.btnPesqPessoasRefresh);
            this.panelPesqPessoas.Controls.Add(this.lbPesqPessoasVoltar);
            this.panelPesqPessoas.Controls.Add(this.groupBoxPesqPessoasResultado);
            this.panelPesqPessoas.Controls.Add(this.btnPesqPessoasVoltar);
            this.panelPesqPessoas.Location = new System.Drawing.Point(11, 13);
            this.panelPesqPessoas.Name = "panelPesqPessoas";
            this.panelPesqPessoas.Size = new System.Drawing.Size(749, 583);
            this.panelPesqPessoas.TabIndex = 0;
            // 
            // btnPesqPessoasRefresh
            // 
            this.btnPesqPessoasRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesqPessoasRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPessoasRefresh.Image = global::frmLogin.Properties.Resources._1480491657_reload;
            this.btnPesqPessoasRefresh.Location = new System.Drawing.Point(694, 479);
            this.btnPesqPessoasRefresh.Name = "btnPesqPessoasRefresh";
            this.btnPesqPessoasRefresh.Size = new System.Drawing.Size(43, 38);
            this.btnPesqPessoasRefresh.TabIndex = 55;
            this.btnPesqPessoasRefresh.UseVisualStyleBackColor = true;
            this.btnPesqPessoasRefresh.Click += new System.EventHandler(this.btnPesqPessoasRefresh_Click);
            // 
            // lbPesqPessoasVoltar
            // 
            this.lbPesqPessoasVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPesqPessoasVoltar.AutoSize = true;
            this.lbPesqPessoasVoltar.Location = new System.Drawing.Point(18, 504);
            this.lbPesqPessoasVoltar.Name = "lbPesqPessoasVoltar";
            this.lbPesqPessoasVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbPesqPessoasVoltar.TabIndex = 9;
            this.lbPesqPessoasVoltar.Text = "Voltar";
            // 
            // groupBoxPesqPessoasResultado
            // 
            this.groupBoxPesqPessoasResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesqPessoasResultado.Controls.Add(this.lbPesPessoasNome);
            this.groupBoxPesqPessoasResultado.Controls.Add(this.txtPesqPessoasNome);
            this.groupBoxPesqPessoasResultado.Controls.Add(this.dataGridViewPesqPessoas);
            this.groupBoxPesqPessoasResultado.Location = new System.Drawing.Point(12, 17);
            this.groupBoxPesqPessoasResultado.Name = "groupBoxPesqPessoasResultado";
            this.groupBoxPesqPessoasResultado.Size = new System.Drawing.Size(725, 456);
            this.groupBoxPesqPessoasResultado.TabIndex = 0;
            this.groupBoxPesqPessoasResultado.TabStop = false;
            this.groupBoxPesqPessoasResultado.Text = "Resultado";
            // 
            // lbPesPessoasNome
            // 
            this.lbPesPessoasNome.AutoSize = true;
            this.lbPesPessoasNome.Location = new System.Drawing.Point(15, 29);
            this.lbPesPessoasNome.Name = "lbPesPessoasNome";
            this.lbPesPessoasNome.Size = new System.Drawing.Size(35, 13);
            this.lbPesPessoasNome.TabIndex = 5;
            this.lbPesPessoasNome.Text = "Nome";
            // 
            // txtPesqPessoasNome
            // 
            this.txtPesqPessoasNome.Location = new System.Drawing.Point(18, 45);
            this.txtPesqPessoasNome.Name = "txtPesqPessoasNome";
            this.txtPesqPessoasNome.Size = new System.Drawing.Size(324, 20);
            this.txtPesqPessoasNome.TabIndex = 1;
            this.txtPesqPessoasNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesqPessoasNome_KeyUp);
            // 
            // btnPesqPessoasVoltar
            // 
            this.btnPesqPessoasVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesqPessoasVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqPessoasVoltar.BackgroundImage")));
            this.btnPesqPessoasVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqPessoasVoltar.Location = new System.Drawing.Point(12, 520);
            this.btnPesqPessoasVoltar.Name = "btnPesqPessoasVoltar";
            this.btnPesqPessoasVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnPesqPessoasVoltar.TabIndex = 2;
            this.btnPesqPessoasVoltar.UseVisualStyleBackColor = true;
            this.btnPesqPessoasVoltar.Click += new System.EventHandler(this.button7_Click);
            // 
            // fmPesquisarPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(772, 608);
            this.Controls.Add(this.panelPesqPessoas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmPesquisarPessoas";
            this.Text = "Pesquisar Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqPessoas)).EndInit();
            this.panelPesqPessoas.ResumeLayout(false);
            this.panelPesqPessoas.PerformLayout();
            this.groupBoxPesqPessoasResultado.ResumeLayout(false);
            this.groupBoxPesqPessoasResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPesqPessoas;
        private System.Windows.Forms.Panel panelPesqPessoas;
        private System.Windows.Forms.Label lbPesqPessoasVoltar;
        private System.Windows.Forms.GroupBox groupBoxPesqPessoasResultado;
        private System.Windows.Forms.Button btnPesqPessoasVoltar;
        private System.Windows.Forms.Label lbPesPessoasNome;
        private System.Windows.Forms.TextBox txtPesqPessoasNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnPesqPessoasRefresh;
    }
}