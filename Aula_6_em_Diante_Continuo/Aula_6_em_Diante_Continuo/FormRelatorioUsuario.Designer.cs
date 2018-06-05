namespace Aula_6_em_Diante_Continuo
{
    partial class FormRelatorioUsuario
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
            this.crvUsuarios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioUsuarios1 = new Aula_6_em_Diante_Continuo.RelatorioUsuarios();
            this.SuspendLayout();
            // 
            // crvUsuarios
            // 
            this.crvUsuarios.ActiveViewIndex = 0;
            this.crvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.crvUsuarios.Name = "crvUsuarios";
            this.crvUsuarios.ReportSource = this.RelatorioUsuarios1;
            this.crvUsuarios.Size = new System.Drawing.Size(1086, 569);
            this.crvUsuarios.TabIndex = 0;
            this.crvUsuarios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 569);
            this.Controls.Add(this.crvUsuarios);
            this.Name = "FormRelatorioUsuario";
            this.Text = "FormRelatorioUsuario";
            this.Load += new System.EventHandler(this.FormRelatorioUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUsuarios;
        private RelatorioUsuarios RelatorioUsuarios1;
    }
}