namespace Aula_06_Ex_01
{
    partial class Form1
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
            this.lbLargura = new System.Windows.Forms.Label();
            this.lbComprimento = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbPrecoTotal = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbResultadoPreco = new System.Windows.Forms.Label();
            this.lbResultadoArea = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPreco = new System.Windows.Forms.Button();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLargura.Location = new System.Drawing.Point(70, 20);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(91, 23);
            this.lbLargura.TabIndex = 0;
            this.lbLargura.Text = "Largura:";
            // 
            // lbComprimento
            // 
            this.lbComprimento.AutoSize = true;
            this.lbComprimento.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComprimento.Location = new System.Drawing.Point(11, 58);
            this.lbComprimento.Name = "lbComprimento";
            this.lbComprimento.Size = new System.Drawing.Size(150, 23);
            this.lbComprimento.TabIndex = 1;
            this.lbComprimento.Text = "Comprimento:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(92, 98);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(69, 23);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço:";
            // 
            // lbPrecoTotal
            // 
            this.lbPrecoTotal.AutoSize = true;
            this.lbPrecoTotal.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoTotal.Location = new System.Drawing.Point(37, 138);
            this.lbPrecoTotal.Name = "lbPrecoTotal";
            this.lbPrecoTotal.Size = new System.Drawing.Size(124, 23);
            this.lbPrecoTotal.TabIndex = 3;
            this.lbPrecoTotal.Text = "Preço Total:";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.Location = new System.Drawing.Point(101, 177);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(60, 23);
            this.lbArea.TabIndex = 4;
            this.lbArea.Text = "Área:";
            // 
            // lbResultadoPreco
            // 
            this.lbResultadoPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResultadoPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResultadoPreco.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoPreco.Location = new System.Drawing.Point(166, 141);
            this.lbResultadoPreco.Name = "lbResultadoPreco";
            this.lbResultadoPreco.Size = new System.Drawing.Size(604, 23);
            this.lbResultadoPreco.TabIndex = 5;
            // 
            // lbResultadoArea
            // 
            this.lbResultadoArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResultadoArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResultadoArea.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoArea.Location = new System.Drawing.Point(166, 181);
            this.lbResultadoArea.Name = "lbResultadoArea";
            this.lbResultadoArea.Size = new System.Drawing.Size(604, 23);
            this.lbResultadoArea.TabIndex = 6;
            // 
            // btnArea
            // 
            this.btnArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArea.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(502, 224);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(117, 64);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Calcular Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPreco
            // 
            this.btnPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreco.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreco.Location = new System.Drawing.Point(653, 224);
            this.btnPreco.Name = "btnPreco";
            this.btnPreco.Size = new System.Drawing.Size(117, 64);
            this.btnPreco.TabIndex = 8;
            this.btnPreco.Text = "Calcular Preço";
            this.btnPreco.UseVisualStyleBackColor = true;
            this.btnPreco.Click += new System.EventHandler(this.btnPreco_Click);
            // 
            // txtLargura
            // 
            this.txtLargura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLargura.Location = new System.Drawing.Point(167, 22);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(603, 22);
            this.txtLargura.TabIndex = 9;
            // 
            // txtComprimento
            // 
            this.txtComprimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprimento.Location = new System.Drawing.Point(167, 60);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(603, 22);
            this.txtComprimento.TabIndex = 10;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Location = new System.Drawing.Point(167, 100);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(603, 22);
            this.txtPreco.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 304);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.btnPreco);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lbResultadoArea);
            this.Controls.Add(this.lbResultadoPreco);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbPrecoTotal);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbComprimento);
            this.Controls.Add(this.lbLargura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.Label lbComprimento;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbPrecoTotal;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbResultadoPreco;
        private System.Windows.Forms.Label lbResultadoArea;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPreco;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtPreco;
    }
}

