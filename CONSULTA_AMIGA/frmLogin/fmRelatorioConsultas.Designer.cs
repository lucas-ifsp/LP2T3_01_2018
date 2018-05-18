namespace frmLogin
{
    partial class fmRelatorioConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRelatorioConsultas));
            this.crystalReportViewerConsultas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportConsultas1 = new frmLogin.CrystalReportConsultas();
            this.SuspendLayout();
            // 
            // crystalReportViewerConsultas
            // 
            this.crystalReportViewerConsultas.ActiveViewIndex = 0;
            this.crystalReportViewerConsultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerConsultas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerConsultas.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerConsultas.Name = "crystalReportViewerConsultas";
            this.crystalReportViewerConsultas.ReportSource = this.CrystalReportConsultas1;
            this.crystalReportViewerConsultas.Size = new System.Drawing.Size(900, 620);
            this.crystalReportViewerConsultas.TabIndex = 0;
            // 
            // fmRelatorioConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.crystalReportViewerConsultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmRelatorioConsultas";
            this.Load += new System.EventHandler(this.fmRelatorioConsultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerConsultas;
        private CrystalReportConsultas CrystalReportConsultas1;
    }
}