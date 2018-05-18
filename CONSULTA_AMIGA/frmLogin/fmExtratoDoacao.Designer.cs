namespace frmLogin
{
    partial class fmExtratoDoacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmExtratoDoacao));
            this.crystalReportViewerExtratoDoacao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportExtratoDoacao1 = new frmLogin.CrystalReportExtratoDoacao();
            this.SuspendLayout();
            // 
            // crystalReportViewerExtratoDoacao
            // 
            this.crystalReportViewerExtratoDoacao.ActiveViewIndex = 0;
            this.crystalReportViewerExtratoDoacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerExtratoDoacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerExtratoDoacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerExtratoDoacao.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerExtratoDoacao.Name = "crystalReportViewerExtratoDoacao";
            this.crystalReportViewerExtratoDoacao.ReportSource = this.CrystalReportExtratoDoacao1;
            this.crystalReportViewerExtratoDoacao.Size = new System.Drawing.Size(697, 551);
            this.crystalReportViewerExtratoDoacao.TabIndex = 0;
            // 
            // fmExtratoDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 551);
            this.Controls.Add(this.crystalReportViewerExtratoDoacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmExtratoDoacao";
            this.Load += new System.EventHandler(this.fmExtratoDoacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerExtratoDoacao;
        private CrystalReportExtratoDoacao CrystalReportExtratoDoacao1;
    }
}