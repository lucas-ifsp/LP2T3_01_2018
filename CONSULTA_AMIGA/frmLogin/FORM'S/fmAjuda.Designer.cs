namespace frmLogin
{
    partial class fmAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAjuda));
            this.panelAjuda = new System.Windows.Forms.Panel();
            this.lbAjudaVoltar = new System.Windows.Forms.Label();
            this.btnAjudaVoltar = new System.Windows.Forms.Button();
            this.groupBoxAjuda = new System.Windows.Forms.GroupBox();
            this.groupBoxAjuda2 = new System.Windows.Forms.GroupBox();
            this.labelAjuda = new System.Windows.Forms.Label();
            this.panelAjuda.SuspendLayout();
            this.groupBoxAjuda.SuspendLayout();
            this.groupBoxAjuda2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAjuda
            // 
            this.panelAjuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAjuda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAjuda.Controls.Add(this.lbAjudaVoltar);
            this.panelAjuda.Controls.Add(this.btnAjudaVoltar);
            this.panelAjuda.Controls.Add(this.groupBoxAjuda);
            this.panelAjuda.Location = new System.Drawing.Point(10, 12);
            this.panelAjuda.Name = "panelAjuda";
            this.panelAjuda.Size = new System.Drawing.Size(388, 331);
            this.panelAjuda.TabIndex = 0;
            // 
            // lbAjudaVoltar
            // 
            this.lbAjudaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAjudaVoltar.AutoSize = true;
            this.lbAjudaVoltar.Location = new System.Drawing.Point(9, 263);
            this.lbAjudaVoltar.Name = "lbAjudaVoltar";
            this.lbAjudaVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbAjudaVoltar.TabIndex = 28;
            this.lbAjudaVoltar.Text = "Voltar";
            // 
            // btnAjudaVoltar
            // 
            this.btnAjudaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjudaVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjudaVoltar.BackgroundImage")));
            this.btnAjudaVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjudaVoltar.Location = new System.Drawing.Point(3, 279);
            this.btnAjudaVoltar.Name = "btnAjudaVoltar";
            this.btnAjudaVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnAjudaVoltar.TabIndex = 1;
            this.btnAjudaVoltar.UseVisualStyleBackColor = true;
            this.btnAjudaVoltar.Click += new System.EventHandler(this.btnAjudaVoltar_Click);
            // 
            // groupBoxAjuda
            // 
            this.groupBoxAjuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAjuda.Controls.Add(this.groupBoxAjuda2);
            this.groupBoxAjuda.Location = new System.Drawing.Point(18, 22);
            this.groupBoxAjuda.Name = "groupBoxAjuda";
            this.groupBoxAjuda.Size = new System.Drawing.Size(351, 235);
            this.groupBoxAjuda.TabIndex = 0;
            this.groupBoxAjuda.TabStop = false;
            this.groupBoxAjuda.Text = "Sobre";
            // 
            // groupBoxAjuda2
            // 
            this.groupBoxAjuda2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAjuda2.Controls.Add(this.labelAjuda);
            this.groupBoxAjuda2.Location = new System.Drawing.Point(24, 49);
            this.groupBoxAjuda2.Name = "groupBoxAjuda2";
            this.groupBoxAjuda2.Size = new System.Drawing.Size(307, 119);
            this.groupBoxAjuda2.TabIndex = 0;
            this.groupBoxAjuda2.TabStop = false;
            // 
            // labelAjuda
            // 
            this.labelAjuda.AutoSize = true;
            this.labelAjuda.Location = new System.Drawing.Point(6, 16);
            this.labelAjuda.Name = "labelAjuda";
            this.labelAjuda.Size = new System.Drawing.Size(300, 91);
            this.labelAjuda.TabIndex = 0;
            this.labelAjuda.Text = resources.GetString("labelAjuda.Text");
            // 
            // fmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(410, 356);
            this.Controls.Add(this.panelAjuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmAjuda";
            this.Text = "Ajuda";
            this.panelAjuda.ResumeLayout(false);
            this.panelAjuda.PerformLayout();
            this.groupBoxAjuda.ResumeLayout(false);
            this.groupBoxAjuda2.ResumeLayout(false);
            this.groupBoxAjuda2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAjuda;
        private System.Windows.Forms.GroupBox groupBoxAjuda;
        private System.Windows.Forms.Label lbAjudaVoltar;
        private System.Windows.Forms.Button btnAjudaVoltar;
        private System.Windows.Forms.GroupBox groupBoxAjuda2;
        private System.Windows.Forms.Label labelAjuda;
    }
}