namespace frmLogin
{
    partial class fmPesquisarConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisarConsultas));
            this.panelPesqConsultas = new System.Windows.Forms.Panel();
            this.btnPesqConsultasRefresh = new System.Windows.Forms.Button();
            this.lbPesqConsultasVoltar = new System.Windows.Forms.Label();
            this.groupBoxPesqConsultasResultado = new System.Windows.Forms.GroupBox();
            this.maskPesqConsultasResp = new System.Windows.Forms.MaskedTextBox();
            this.labelPesqConsultasResp = new System.Windows.Forms.Label();
            this.dataGridViewPesqConsultas = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsável = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesqConsultasVoltar = new System.Windows.Forms.Button();
            this.panelPesqConsultas.SuspendLayout();
            this.groupBoxPesqConsultasResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPesqConsultas
            // 
            this.panelPesqConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPesqConsultas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPesqConsultas.Controls.Add(this.btnPesqConsultasRefresh);
            this.panelPesqConsultas.Controls.Add(this.lbPesqConsultasVoltar);
            this.panelPesqConsultas.Controls.Add(this.groupBoxPesqConsultasResultado);
            this.panelPesqConsultas.Controls.Add(this.btnPesqConsultasVoltar);
            this.panelPesqConsultas.Location = new System.Drawing.Point(11, 13);
            this.panelPesqConsultas.Name = "panelPesqConsultas";
            this.panelPesqConsultas.Size = new System.Drawing.Size(749, 583);
            this.panelPesqConsultas.TabIndex = 0;
            // 
            // btnPesqConsultasRefresh
            // 
            this.btnPesqConsultasRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesqConsultasRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqConsultasRefresh.Image = global::frmLogin.Properties.Resources._1480491657_reload;
            this.btnPesqConsultasRefresh.Location = new System.Drawing.Point(694, 479);
            this.btnPesqConsultasRefresh.Name = "btnPesqConsultasRefresh";
            this.btnPesqConsultasRefresh.Size = new System.Drawing.Size(43, 38);
            this.btnPesqConsultasRefresh.TabIndex = 54;
            this.btnPesqConsultasRefresh.UseVisualStyleBackColor = true;
            this.btnPesqConsultasRefresh.Click += new System.EventHandler(this.btnPesqConsultasRefresh_Click);
            // 
            // lbPesqConsultasVoltar
            // 
            this.lbPesqConsultasVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPesqConsultasVoltar.AutoSize = true;
            this.lbPesqConsultasVoltar.Location = new System.Drawing.Point(18, 504);
            this.lbPesqConsultasVoltar.Name = "lbPesqConsultasVoltar";
            this.lbPesqConsultasVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbPesqConsultasVoltar.TabIndex = 9;
            this.lbPesqConsultasVoltar.Text = "Voltar";
            // 
            // groupBoxPesqConsultasResultado
            // 
            this.groupBoxPesqConsultasResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesqConsultasResultado.Controls.Add(this.maskPesqConsultasResp);
            this.groupBoxPesqConsultasResultado.Controls.Add(this.labelPesqConsultasResp);
            this.groupBoxPesqConsultasResultado.Controls.Add(this.dataGridViewPesqConsultas);
            this.groupBoxPesqConsultasResultado.Location = new System.Drawing.Point(12, 17);
            this.groupBoxPesqConsultasResultado.Name = "groupBoxPesqConsultasResultado";
            this.groupBoxPesqConsultasResultado.Size = new System.Drawing.Size(725, 456);
            this.groupBoxPesqConsultasResultado.TabIndex = 0;
            this.groupBoxPesqConsultasResultado.TabStop = false;
            this.groupBoxPesqConsultasResultado.Text = "Resultado";
            // 
            // maskPesqConsultasResp
            // 
            this.maskPesqConsultasResp.Location = new System.Drawing.Point(20, 45);
            this.maskPesqConsultasResp.Mask = "000,000,000-00";
            this.maskPesqConsultasResp.Name = "maskPesqConsultasResp";
            this.maskPesqConsultasResp.Size = new System.Drawing.Size(243, 20);
            this.maskPesqConsultasResp.TabIndex = 1;
            this.maskPesqConsultasResp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskPesqConsultasResp_KeyUp);
            // 
            // labelPesqConsultasResp
            // 
            this.labelPesqConsultasResp.AutoSize = true;
            this.labelPesqConsultasResp.Location = new System.Drawing.Point(17, 29);
            this.labelPesqConsultasResp.Name = "labelPesqConsultasResp";
            this.labelPesqConsultasResp.Size = new System.Drawing.Size(98, 13);
            this.labelPesqConsultasResp.TabIndex = 15;
            this.labelPesqConsultasResp.Text = "Responsável (CPF)";
            // 
            // dataGridViewPesqConsultas
            // 
            this.dataGridViewPesqConsultas.AllowUserToAddRows = false;
            this.dataGridViewPesqConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewPesqConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesqConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesqConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesqConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Horário,
            this.Responsável,
            this.Animal});
            this.dataGridViewPesqConsultas.Location = new System.Drawing.Point(6, 89);
            this.dataGridViewPesqConsultas.Name = "dataGridViewPesqConsultas";
            this.dataGridViewPesqConsultas.ReadOnly = true;
            this.dataGridViewPesqConsultas.Size = new System.Drawing.Size(713, 361);
            this.dataGridViewPesqConsultas.TabIndex = 3;
            this.dataGridViewPesqConsultas.DoubleClick += new System.EventHandler(this.dataGridViewPesqConsultas_DoubleClick);
            // 
            // Data
            // 
            this.Data.HeaderText = "DATA";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Horário
            // 
            this.Horário.HeaderText = "HORÁRIO";
            this.Horário.Name = "Horário";
            this.Horário.ReadOnly = true;
            // 
            // Responsável
            // 
            this.Responsável.HeaderText = "RESPONSÁVEL";
            this.Responsável.Name = "Responsável";
            this.Responsável.ReadOnly = true;
            // 
            // Animal
            // 
            this.Animal.HeaderText = "ANIMAL";
            this.Animal.Name = "Animal";
            this.Animal.ReadOnly = true;
            // 
            // btnPesqConsultasVoltar
            // 
            this.btnPesqConsultasVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesqConsultasVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqConsultasVoltar.BackgroundImage")));
            this.btnPesqConsultasVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqConsultasVoltar.Location = new System.Drawing.Point(12, 520);
            this.btnPesqConsultasVoltar.Name = "btnPesqConsultasVoltar";
            this.btnPesqConsultasVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnPesqConsultasVoltar.TabIndex = 4;
            this.btnPesqConsultasVoltar.UseVisualStyleBackColor = true;
            this.btnPesqConsultasVoltar.Click += new System.EventHandler(this.btnPesqConsultasVoltar_Click);
            // 
            // fmPesquisarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(771, 609);
            this.Controls.Add(this.panelPesqConsultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmPesquisarConsultas";
            this.Text = "Pesquisar Consultas";
            this.panelPesqConsultas.ResumeLayout(false);
            this.panelPesqConsultas.PerformLayout();
            this.groupBoxPesqConsultasResultado.ResumeLayout(false);
            this.groupBoxPesqConsultasResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPesqConsultas;
        private System.Windows.Forms.Label lbPesqConsultasVoltar;
        private System.Windows.Forms.GroupBox groupBoxPesqConsultasResultado;
        private System.Windows.Forms.Button btnPesqConsultasVoltar;
        private System.Windows.Forms.DataGridView dataGridViewPesqConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsável;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.Label labelPesqConsultasResp;
        private System.Windows.Forms.MaskedTextBox maskPesqConsultasResp;
        private System.Windows.Forms.Button btnPesqConsultasRefresh;
    }
}