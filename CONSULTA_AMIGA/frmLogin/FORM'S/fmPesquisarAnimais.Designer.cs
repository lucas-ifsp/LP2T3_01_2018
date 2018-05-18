namespace frmLogin
{
    partial class fmPesquisarAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisarAnimais));
            this.panelResultado = new System.Windows.Forms.Panel();
            this.btnPesqAnimaisRefresh = new System.Windows.Forms.Button();
            this.lbPesqAnimaisVoltar = new System.Windows.Forms.Label();
            this.groupBoxPesquisarAnimaisResultado = new System.Windows.Forms.GroupBox();
            this.lbPesqAnimais = new System.Windows.Forms.Label();
            this.txtPesqAnimaisNome = new System.Windows.Forms.TextBox();
            this.dataGridViewPesqAnimais = new System.Windows.Forms.DataGridView();
            this.Responsável = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESPÉCIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesqAnimaisVoltar = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            this.groupBoxPesquisarAnimaisResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelResultado.Controls.Add(this.btnPesqAnimaisRefresh);
            this.panelResultado.Controls.Add(this.lbPesqAnimaisVoltar);
            this.panelResultado.Controls.Add(this.groupBoxPesquisarAnimaisResultado);
            this.panelResultado.Controls.Add(this.btnPesqAnimaisVoltar);
            this.panelResultado.Location = new System.Drawing.Point(12, 14);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(749, 583);
            this.panelResultado.TabIndex = 0;
            // 
            // btnPesqAnimaisRefresh
            // 
            this.btnPesqAnimaisRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesqAnimaisRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqAnimaisRefresh.Image = global::frmLogin.Properties.Resources._1480491657_reload;
            this.btnPesqAnimaisRefresh.Location = new System.Drawing.Point(694, 479);
            this.btnPesqAnimaisRefresh.Name = "btnPesqAnimaisRefresh";
            this.btnPesqAnimaisRefresh.Size = new System.Drawing.Size(43, 38);
            this.btnPesqAnimaisRefresh.TabIndex = 53;
            this.btnPesqAnimaisRefresh.UseVisualStyleBackColor = true;
            this.btnPesqAnimaisRefresh.Click += new System.EventHandler(this.btnPesqAnimaisRefresh_Click);
            // 
            // lbPesqAnimaisVoltar
            // 
            this.lbPesqAnimaisVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPesqAnimaisVoltar.AutoSize = true;
            this.lbPesqAnimaisVoltar.Location = new System.Drawing.Point(18, 504);
            this.lbPesqAnimaisVoltar.Name = "lbPesqAnimaisVoltar";
            this.lbPesqAnimaisVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbPesqAnimaisVoltar.TabIndex = 9;
            this.lbPesqAnimaisVoltar.Text = "Voltar";
            // 
            // groupBoxPesquisarAnimaisResultado
            // 
            this.groupBoxPesquisarAnimaisResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesquisarAnimaisResultado.Controls.Add(this.lbPesqAnimais);
            this.groupBoxPesquisarAnimaisResultado.Controls.Add(this.txtPesqAnimaisNome);
            this.groupBoxPesquisarAnimaisResultado.Controls.Add(this.dataGridViewPesqAnimais);
            this.groupBoxPesquisarAnimaisResultado.Location = new System.Drawing.Point(12, 17);
            this.groupBoxPesquisarAnimaisResultado.Name = "groupBoxPesquisarAnimaisResultado";
            this.groupBoxPesquisarAnimaisResultado.Size = new System.Drawing.Size(725, 456);
            this.groupBoxPesquisarAnimaisResultado.TabIndex = 0;
            this.groupBoxPesquisarAnimaisResultado.TabStop = false;
            this.groupBoxPesquisarAnimaisResultado.Text = "Resultado";
            // 
            // lbPesqAnimais
            // 
            this.lbPesqAnimais.AutoSize = true;
            this.lbPesqAnimais.Location = new System.Drawing.Point(19, 31);
            this.lbPesqAnimais.Name = "lbPesqAnimais";
            this.lbPesqAnimais.Size = new System.Drawing.Size(35, 13);
            this.lbPesqAnimais.TabIndex = 3;
            this.lbPesqAnimais.Text = "Nome";
            // 
            // txtPesqAnimaisNome
            // 
            this.txtPesqAnimaisNome.Location = new System.Drawing.Point(22, 47);
            this.txtPesqAnimaisNome.Name = "txtPesqAnimaisNome";
            this.txtPesqAnimaisNome.Size = new System.Drawing.Size(321, 20);
            this.txtPesqAnimaisNome.TabIndex = 1;
            this.txtPesqAnimaisNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesAnimaisEspecie_KeyUp);
            // 
            // dataGridViewPesqAnimais
            // 
            this.dataGridViewPesqAnimais.AllowUserToAddRows = false;
            this.dataGridViewPesqAnimais.AllowUserToDeleteRows = false;
            this.dataGridViewPesqAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesqAnimais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesqAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesqAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Responsável,
            this.NOME,
            this.ESPÉCIE,
            this.Raça,
            this.DataNasc,
            this.Sexo,
            this.Porte});
            this.dataGridViewPesqAnimais.Location = new System.Drawing.Point(6, 89);
            this.dataGridViewPesqAnimais.Name = "dataGridViewPesqAnimais";
            this.dataGridViewPesqAnimais.ReadOnly = true;
            this.dataGridViewPesqAnimais.Size = new System.Drawing.Size(713, 361);
            this.dataGridViewPesqAnimais.TabIndex = 10;
            this.dataGridViewPesqAnimais.DoubleClick += new System.EventHandler(this.dataGridViewPesqAnimais_DoubleClick);
            // 
            // Responsável
            // 
            this.Responsável.HeaderText = "RESPONSÁVEL";
            this.Responsável.Name = "Responsável";
            this.Responsável.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // ESPÉCIE
            // 
            this.ESPÉCIE.HeaderText = "ESPÉCIE";
            this.ESPÉCIE.Name = "ESPÉCIE";
            this.ESPÉCIE.ReadOnly = true;
            // 
            // Raça
            // 
            this.Raça.HeaderText = "RAÇA";
            this.Raça.Name = "Raça";
            this.Raça.ReadOnly = true;
            // 
            // DataNasc
            // 
            this.DataNasc.HeaderText = "NASCIMENTO";
            this.DataNasc.Name = "DataNasc";
            this.DataNasc.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Porte
            // 
            this.Porte.HeaderText = "PORTE";
            this.Porte.Name = "Porte";
            this.Porte.ReadOnly = true;
            // 
            // btnPesqAnimaisVoltar
            // 
            this.btnPesqAnimaisVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesqAnimaisVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqAnimaisVoltar.BackgroundImage")));
            this.btnPesqAnimaisVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqAnimaisVoltar.Location = new System.Drawing.Point(12, 520);
            this.btnPesqAnimaisVoltar.Name = "btnPesqAnimaisVoltar";
            this.btnPesqAnimaisVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnPesqAnimaisVoltar.TabIndex = 2;
            this.btnPesqAnimaisVoltar.UseVisualStyleBackColor = true;
            this.btnPesqAnimaisVoltar.Click += new System.EventHandler(this.btnPesqAnimaisVoltar_Click);
            // 
            // fmPesquisarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(773, 610);
            this.Controls.Add(this.panelResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmPesquisarAnimais";
            this.Text = "Pesquisar Animais";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.groupBoxPesquisarAnimaisResultado.ResumeLayout(false);
            this.groupBoxPesquisarAnimaisResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lbPesqAnimaisVoltar;
        private System.Windows.Forms.GroupBox groupBoxPesquisarAnimaisResultado;
        private System.Windows.Forms.Label lbPesqAnimais;
        private System.Windows.Forms.TextBox txtPesqAnimaisNome;
        private System.Windows.Forms.DataGridView dataGridViewPesqAnimais;
        private System.Windows.Forms.Button btnPesqAnimaisVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsável;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESPÉCIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raça;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porte;
        private System.Windows.Forms.Button btnPesqAnimaisRefresh;
    }
}