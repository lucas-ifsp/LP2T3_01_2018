namespace frmLogin
{
    partial class fmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisar));
            this.panelPesquisar = new System.Windows.Forms.Panel();
            this.lbPesquisarVoltar = new System.Windows.Forms.Label();
            this.btnPesquisarVoltar = new System.Windows.Forms.Button();
            this.gboxPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisarConsultas = new System.Windows.Forms.Button();
            this.btnPesquisarProdutos = new System.Windows.Forms.Button();
            this.btnPesquisarAnimais = new System.Windows.Forms.Button();
            this.btnPesquisarPessoas = new System.Windows.Forms.Button();
            this.panelPesquisar.SuspendLayout();
            this.gboxPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPesquisar
            // 
            this.panelPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPesquisar.Controls.Add(this.lbPesquisarVoltar);
            this.panelPesquisar.Controls.Add(this.btnPesquisarVoltar);
            this.panelPesquisar.Controls.Add(this.gboxPesquisar);
            this.panelPesquisar.Location = new System.Drawing.Point(12, 12);
            this.panelPesquisar.Name = "panelPesquisar";
            this.panelPesquisar.Size = new System.Drawing.Size(485, 396);
            this.panelPesquisar.TabIndex = 0;
            // 
            // lbPesquisarVoltar
            // 
            this.lbPesquisarVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPesquisarVoltar.AutoSize = true;
            this.lbPesquisarVoltar.Location = new System.Drawing.Point(18, 318);
            this.lbPesquisarVoltar.Name = "lbPesquisarVoltar";
            this.lbPesquisarVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbPesquisarVoltar.TabIndex = 9;
            this.lbPesquisarVoltar.Text = "Voltar";
            // 
            // btnPesquisarVoltar
            // 
            this.btnPesquisarVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesquisarVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarVoltar.BackgroundImage")));
            this.btnPesquisarVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarVoltar.Location = new System.Drawing.Point(12, 334);
            this.btnPesquisarVoltar.Name = "btnPesquisarVoltar";
            this.btnPesquisarVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnPesquisarVoltar.TabIndex = 4;
            this.btnPesquisarVoltar.UseVisualStyleBackColor = true;
            this.btnPesquisarVoltar.Click += new System.EventHandler(this.button7_Click);
            // 
            // gboxPesquisar
            // 
            this.gboxPesquisar.Controls.Add(this.btnPesquisarConsultas);
            this.gboxPesquisar.Controls.Add(this.btnPesquisarProdutos);
            this.gboxPesquisar.Controls.Add(this.btnPesquisarAnimais);
            this.gboxPesquisar.Controls.Add(this.btnPesquisarPessoas);
            this.gboxPesquisar.Location = new System.Drawing.Point(12, 17);
            this.gboxPesquisar.Name = "gboxPesquisar";
            this.gboxPesquisar.Size = new System.Drawing.Size(460, 290);
            this.gboxPesquisar.TabIndex = 0;
            this.gboxPesquisar.TabStop = false;
            this.gboxPesquisar.Text = "Pesquisar";
            // 
            // btnPesquisarConsultas
            // 
            this.btnPesquisarConsultas.Location = new System.Drawing.Point(143, 215);
            this.btnPesquisarConsultas.Name = "btnPesquisarConsultas";
            this.btnPesquisarConsultas.Size = new System.Drawing.Size(183, 42);
            this.btnPesquisarConsultas.TabIndex = 4;
            this.btnPesquisarConsultas.Text = "Consultas";
            this.btnPesquisarConsultas.UseVisualStyleBackColor = true;
            this.btnPesquisarConsultas.Click += new System.EventHandler(this.btnPesquisarConsultas_Click);
            // 
            // btnPesquisarProdutos
            // 
            this.btnPesquisarProdutos.Location = new System.Drawing.Point(143, 155);
            this.btnPesquisarProdutos.Name = "btnPesquisarProdutos";
            this.btnPesquisarProdutos.Size = new System.Drawing.Size(183, 42);
            this.btnPesquisarProdutos.TabIndex = 3;
            this.btnPesquisarProdutos.Text = "Produtos";
            this.btnPesquisarProdutos.UseVisualStyleBackColor = true;
            this.btnPesquisarProdutos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPesquisarAnimais
            // 
            this.btnPesquisarAnimais.Location = new System.Drawing.Point(143, 94);
            this.btnPesquisarAnimais.Name = "btnPesquisarAnimais";
            this.btnPesquisarAnimais.Size = new System.Drawing.Size(183, 42);
            this.btnPesquisarAnimais.TabIndex = 2;
            this.btnPesquisarAnimais.Text = "Animais";
            this.btnPesquisarAnimais.UseVisualStyleBackColor = true;
            this.btnPesquisarAnimais.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPesquisarPessoas
            // 
            this.btnPesquisarPessoas.Location = new System.Drawing.Point(143, 33);
            this.btnPesquisarPessoas.Name = "btnPesquisarPessoas";
            this.btnPesquisarPessoas.Size = new System.Drawing.Size(183, 42);
            this.btnPesquisarPessoas.TabIndex = 1;
            this.btnPesquisarPessoas.Text = "Pessoas";
            this.btnPesquisarPessoas.UseVisualStyleBackColor = true;
            this.btnPesquisarPessoas.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(512, 420);
            this.Controls.Add(this.panelPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmPesquisar";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.fmPesquisar_Load);
            this.panelPesquisar.ResumeLayout(false);
            this.panelPesquisar.PerformLayout();
            this.gboxPesquisar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPesquisar;
        private System.Windows.Forms.GroupBox gboxPesquisar;
        private System.Windows.Forms.Button btnPesquisarProdutos;
        private System.Windows.Forms.Button btnPesquisarAnimais;
        private System.Windows.Forms.Button btnPesquisarPessoas;
        private System.Windows.Forms.Label lbPesquisarVoltar;
        private System.Windows.Forms.Button btnPesquisarVoltar;
        private System.Windows.Forms.Button btnPesquisarConsultas;
    }
}