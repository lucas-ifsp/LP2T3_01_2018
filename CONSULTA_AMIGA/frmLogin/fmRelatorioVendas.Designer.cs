namespace frmLogin
{
    partial class fmRelatorioVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRelatorioVendas));
            this.crystalReportViewerVendas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVendas1 = new frmLogin.CrystalReportVendas();
            this.SuspendLayout();
            // 
            // crystalReportViewerVendas
            // 
            this.crystalReportViewerVendas.ActiveViewIndex = 0;
            this.crystalReportViewerVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVendas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVendas.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVendas.Name = "crystalReportViewerVendas";
            this.crystalReportViewerVendas.ReportSource = this.CrystalReportVendas1;
            this.crystalReportViewerVendas.Size = new System.Drawing.Size(898, 617);
            this.crystalReportViewerVendas.TabIndex = 0;
            // 
            // fmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 617);
            this.Controls.Add(this.crystalReportViewerVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmRelatorioVendas";
            this.Load += new System.EventHandler(this.fmRelatorioVendas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVendas;
        private CrystalReportVendas CrystalReportVendas1;
    }
}