namespace frmLogin
{
    partial class fmExtratoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmExtratoVenda));
            this.crystalReportViewerExtratoVenda = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportExtratoVenda1 = new frmLogin.CrystalReportExtratoVenda();
            this.SuspendLayout();
            // 
            // crystalReportViewerExtratoVenda
            // 
            this.crystalReportViewerExtratoVenda.ActiveViewIndex = 0;
            this.crystalReportViewerExtratoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerExtratoVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerExtratoVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerExtratoVenda.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerExtratoVenda.Name = "crystalReportViewerExtratoVenda";
            this.crystalReportViewerExtratoVenda.ReportSource = this.CrystalReportExtratoVenda1;
            this.crystalReportViewerExtratoVenda.Size = new System.Drawing.Size(658, 507);
            this.crystalReportViewerExtratoVenda.TabIndex = 0;
            // 
            // fmExtratoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 507);
            this.Controls.Add(this.crystalReportViewerExtratoVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmExtratoVenda";
            this.Load += new System.EventHandler(this.fmExtratoVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerExtratoVenda;
        private CrystalReportExtratoVenda CrystalReportExtratoVenda1;
    }
}