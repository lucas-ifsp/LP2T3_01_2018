namespace frmLogin
{
    partial class fmExtratoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmExtratoConsulta));
            this.crystalReportViewerExtratoConsulta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportExtratoConsulta1 = new frmLogin.CrystalReportExtratoConsulta();
            this.SuspendLayout();
            // 
            // crystalReportViewerExtratoConsulta
            // 
            this.crystalReportViewerExtratoConsulta.ActiveViewIndex = 0;
            this.crystalReportViewerExtratoConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerExtratoConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerExtratoConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerExtratoConsulta.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerExtratoConsulta.Name = "crystalReportViewerExtratoConsulta";
            this.crystalReportViewerExtratoConsulta.ReportSource = this.CrystalReportExtratoConsulta1;
            this.crystalReportViewerExtratoConsulta.Size = new System.Drawing.Size(702, 594);
            this.crystalReportViewerExtratoConsulta.TabIndex = 0;
            // 
            // fmExtratoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 594);
            this.Controls.Add(this.crystalReportViewerExtratoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmExtratoConsulta";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerExtratoConsulta;
        private CrystalReportExtratoConsulta CrystalReportExtratoConsulta1;
    }
}