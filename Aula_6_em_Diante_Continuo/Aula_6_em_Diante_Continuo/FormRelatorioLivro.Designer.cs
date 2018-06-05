namespace Aula_6_em_Diante_Continuo
{
    partial class FormRelatorioLivro
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
            this.crvLivros = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioAcervo1 = new Aula_6_em_Diante_Continuo.RelatorioAcervo();
            this.SuspendLayout();
            // 
            // crvLivros
            // 
            this.crvLivros.ActiveViewIndex = 0;
            this.crvLivros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLivros.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLivros.Location = new System.Drawing.Point(0, 0);
            this.crvLivros.Name = "crvLivros";
            this.crvLivros.ReportSource = this.RelatorioAcervo1;
            this.crvLivros.Size = new System.Drawing.Size(1175, 508);
            this.crvLivros.TabIndex = 0;
            this.crvLivros.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormRelatorioLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 508);
            this.Controls.Add(this.crvLivros);
            this.Name = "FormRelatorioLivro";
            this.Text = "FormRelatorioLivro";
            this.Load += new System.EventHandler(this.FormRelatorioLivro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvLivros;
        private RelatorioAcervo RelatorioAcervo1;
    }
}