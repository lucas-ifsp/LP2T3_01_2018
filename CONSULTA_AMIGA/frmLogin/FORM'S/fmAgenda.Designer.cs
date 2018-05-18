namespace frmLogin
{
    partial class fmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAgenda));
            this.panelAgenda = new System.Windows.Forms.Panel();
            this.btnAgendaAlterar = new System.Windows.Forms.Button();
            this.btnAgendaRemover = new System.Windows.Forms.Button();
            this.btnAgendaAgendar = new System.Windows.Forms.Button();
            this.grBoxPessoaDados = new System.Windows.Forms.GroupBox();
            this.maskAgendaHorario = new System.Windows.Forms.MaskedTextBox();
            this.maskAgendaData = new System.Windows.Forms.MaskedTextBox();
            this.lbAgendaAnimal = new System.Windows.Forms.Label();
            this.txtAgendaAnimal = new System.Windows.Forms.TextBox();
            this.comboBoxAgendaTipo = new System.Windows.Forms.ComboBox();
            this.dateTimeAgenda = new System.Windows.Forms.DateTimePicker();
            this.lbAgendaResponsavel = new System.Windows.Forms.Label();
            this.txtAgendaResponsavel = new System.Windows.Forms.TextBox();
            this.lbAgendaTipo = new System.Windows.Forms.Label();
            this.lbAgendaHorario = new System.Windows.Forms.Label();
            this.lbAgendaData = new System.Windows.Forms.Label();
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsável = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAgendaVoltar = new System.Windows.Forms.Label();
            this.btnAgendaVoltar = new System.Windows.Forms.Button();
            this.panelAgenda.SuspendLayout();
            this.grBoxPessoaDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAgenda
            // 
            this.panelAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAgenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAgenda.Controls.Add(this.btnAgendaAlterar);
            this.panelAgenda.Controls.Add(this.btnAgendaRemover);
            this.panelAgenda.Controls.Add(this.btnAgendaAgendar);
            this.panelAgenda.Controls.Add(this.grBoxPessoaDados);
            this.panelAgenda.Controls.Add(this.lbAgendaVoltar);
            this.panelAgenda.Controls.Add(this.btnAgendaVoltar);
            this.panelAgenda.Location = new System.Drawing.Point(9, 11);
            this.panelAgenda.Name = "panelAgenda";
            this.panelAgenda.Size = new System.Drawing.Size(697, 534);
            this.panelAgenda.TabIndex = 0;
            // 
            // btnAgendaAlterar
            // 
            this.btnAgendaAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgendaAlterar.Location = new System.Drawing.Point(317, 452);
            this.btnAgendaAlterar.Name = "btnAgendaAlterar";
            this.btnAgendaAlterar.Size = new System.Drawing.Size(105, 64);
            this.btnAgendaAlterar.TabIndex = 8;
            this.btnAgendaAlterar.Text = "Alterar";
            this.btnAgendaAlterar.UseVisualStyleBackColor = true;
            this.btnAgendaAlterar.Click += new System.EventHandler(this.btnAgendaAlterar_Click);
            // 
            // btnAgendaRemover
            // 
            this.btnAgendaRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgendaRemover.Location = new System.Drawing.Point(461, 452);
            this.btnAgendaRemover.Name = "btnAgendaRemover";
            this.btnAgendaRemover.Size = new System.Drawing.Size(105, 64);
            this.btnAgendaRemover.TabIndex = 9;
            this.btnAgendaRemover.Text = "Remover";
            this.btnAgendaRemover.UseVisualStyleBackColor = true;
            this.btnAgendaRemover.Click += new System.EventHandler(this.btnAgendaRemover_Click);
            // 
            // btnAgendaAgendar
            // 
            this.btnAgendaAgendar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgendaAgendar.Location = new System.Drawing.Point(176, 452);
            this.btnAgendaAgendar.Name = "btnAgendaAgendar";
            this.btnAgendaAgendar.Size = new System.Drawing.Size(105, 64);
            this.btnAgendaAgendar.TabIndex = 7;
            this.btnAgendaAgendar.Text = "Agendar";
            this.btnAgendaAgendar.UseVisualStyleBackColor = true;
            this.btnAgendaAgendar.Click += new System.EventHandler(this.btnAgendaAgendar_Click);
            // 
            // grBoxPessoaDados
            // 
            this.grBoxPessoaDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxPessoaDados.Controls.Add(this.maskAgendaHorario);
            this.grBoxPessoaDados.Controls.Add(this.maskAgendaData);
            this.grBoxPessoaDados.Controls.Add(this.lbAgendaAnimal);
            this.grBoxPessoaDados.Controls.Add(this.txtAgendaAnimal);
            this.grBoxPessoaDados.Controls.Add(this.comboBoxAgendaTipo);
            this.grBoxPessoaDados.Controls.Add(this.dateTimeAgenda);
            this.grBoxPessoaDados.Controls.Add(this.lbAgendaResponsavel);
            this.grBoxPessoaDados.Controls.Add(this.txtAgendaResponsavel);
            this.grBoxPessoaDados.Controls.Add(this.lbAgendaTipo);
            this.grBoxPessoaDados.Controls.Add(this.lbAgendaHorario);
            this.grBoxPessoaDados.Controls.Add(this.lbAgendaData);
            this.grBoxPessoaDados.Controls.Add(this.dataGridViewAgenda);
            this.grBoxPessoaDados.Location = new System.Drawing.Point(12, 19);
            this.grBoxPessoaDados.Name = "grBoxPessoaDados";
            this.grBoxPessoaDados.Size = new System.Drawing.Size(672, 417);
            this.grBoxPessoaDados.TabIndex = 0;
            this.grBoxPessoaDados.TabStop = false;
            this.grBoxPessoaDados.Text = "Agenda";
            // 
            // maskAgendaHorario
            // 
            this.maskAgendaHorario.Location = new System.Drawing.Point(24, 92);
            this.maskAgendaHorario.Mask = "00:00";
            this.maskAgendaHorario.Name = "maskAgendaHorario";
            this.maskAgendaHorario.Size = new System.Drawing.Size(165, 20);
            this.maskAgendaHorario.TabIndex = 3;
            this.maskAgendaHorario.ValidatingType = typeof(System.DateTime);
            // 
            // maskAgendaData
            // 
            this.maskAgendaData.Location = new System.Drawing.Point(24, 42);
            this.maskAgendaData.Mask = "00/00/0000";
            this.maskAgendaData.Name = "maskAgendaData";
            this.maskAgendaData.Size = new System.Drawing.Size(165, 20);
            this.maskAgendaData.TabIndex = 1;
            // 
            // lbAgendaAnimal
            // 
            this.lbAgendaAnimal.AutoSize = true;
            this.lbAgendaAnimal.Location = new System.Drawing.Point(407, 76);
            this.lbAgendaAnimal.Name = "lbAgendaAnimal";
            this.lbAgendaAnimal.Size = new System.Drawing.Size(38, 13);
            this.lbAgendaAnimal.TabIndex = 44;
            this.lbAgendaAnimal.Text = "Animal";
            // 
            // txtAgendaAnimal
            // 
            this.txtAgendaAnimal.Location = new System.Drawing.Point(410, 92);
            this.txtAgendaAnimal.Name = "txtAgendaAnimal";
            this.txtAgendaAnimal.Size = new System.Drawing.Size(169, 20);
            this.txtAgendaAnimal.TabIndex = 5;
            // 
            // comboBoxAgendaTipo
            // 
            this.comboBoxAgendaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgendaTipo.FormattingEnabled = true;
            this.comboBoxAgendaTipo.Items.AddRange(new object[] {
            "",
            "Rotina",
            "Retorno",
            "Cirurgia"});
            this.comboBoxAgendaTipo.Location = new System.Drawing.Point(214, 91);
            this.comboBoxAgendaTipo.Name = "comboBoxAgendaTipo";
            this.comboBoxAgendaTipo.Size = new System.Drawing.Size(172, 21);
            this.comboBoxAgendaTipo.TabIndex = 4;
            // 
            // dateTimeAgenda
            // 
            this.dateTimeAgenda.Location = new System.Drawing.Point(410, 42);
            this.dateTimeAgenda.Name = "dateTimeAgenda";
            this.dateTimeAgenda.Size = new System.Drawing.Size(244, 20);
            this.dateTimeAgenda.TabIndex = 11;
            this.dateTimeAgenda.ValueChanged += new System.EventHandler(this.dateTimeAgenda_ValueChanged);
            // 
            // lbAgendaResponsavel
            // 
            this.lbAgendaResponsavel.AutoSize = true;
            this.lbAgendaResponsavel.Location = new System.Drawing.Point(211, 26);
            this.lbAgendaResponsavel.Name = "lbAgendaResponsavel";
            this.lbAgendaResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lbAgendaResponsavel.TabIndex = 23;
            this.lbAgendaResponsavel.Text = "Responsável";
            // 
            // txtAgendaResponsavel
            // 
            this.txtAgendaResponsavel.Location = new System.Drawing.Point(214, 42);
            this.txtAgendaResponsavel.Name = "txtAgendaResponsavel";
            this.txtAgendaResponsavel.Size = new System.Drawing.Size(172, 20);
            this.txtAgendaResponsavel.TabIndex = 2;
            // 
            // lbAgendaTipo
            // 
            this.lbAgendaTipo.AutoSize = true;
            this.lbAgendaTipo.Location = new System.Drawing.Point(211, 76);
            this.lbAgendaTipo.Name = "lbAgendaTipo";
            this.lbAgendaTipo.Size = new System.Drawing.Size(28, 13);
            this.lbAgendaTipo.TabIndex = 25;
            this.lbAgendaTipo.Text = "Tipo";
            // 
            // lbAgendaHorario
            // 
            this.lbAgendaHorario.AutoSize = true;
            this.lbAgendaHorario.Location = new System.Drawing.Point(21, 76);
            this.lbAgendaHorario.Name = "lbAgendaHorario";
            this.lbAgendaHorario.Size = new System.Drawing.Size(41, 13);
            this.lbAgendaHorario.TabIndex = 24;
            this.lbAgendaHorario.Text = "Horário";
            // 
            // lbAgendaData
            // 
            this.lbAgendaData.AutoSize = true;
            this.lbAgendaData.Location = new System.Drawing.Point(21, 26);
            this.lbAgendaData.Name = "lbAgendaData";
            this.lbAgendaData.Size = new System.Drawing.Size(30, 13);
            this.lbAgendaData.TabIndex = 22;
            this.lbAgendaData.Text = "Data";
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.AllowUserToAddRows = false;
            this.dataGridViewAgenda.AllowUserToDeleteRows = false;
            this.dataGridViewAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Horário,
            this.Tipo,
            this.Responsável,
            this.Animal});
            this.dataGridViewAgenda.Location = new System.Drawing.Point(0, 145);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.ReadOnly = true;
            this.dataGridViewAgenda.Size = new System.Drawing.Size(672, 272);
            this.dataGridViewAgenda.TabIndex = 6;
            this.dataGridViewAgenda.DoubleClick += new System.EventHandler(this.dataGridViewAgenda_DoubleClick);
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
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
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
            // lbAgendaVoltar
            // 
            this.lbAgendaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAgendaVoltar.AutoSize = true;
            this.lbAgendaVoltar.Location = new System.Drawing.Point(9, 465);
            this.lbAgendaVoltar.Name = "lbAgendaVoltar";
            this.lbAgendaVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbAgendaVoltar.TabIndex = 20;
            this.lbAgendaVoltar.Text = "Voltar";
            // 
            // btnAgendaVoltar
            // 
            this.btnAgendaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgendaVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgendaVoltar.BackgroundImage")));
            this.btnAgendaVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendaVoltar.Location = new System.Drawing.Point(3, 481);
            this.btnAgendaVoltar.Name = "btnAgendaVoltar";
            this.btnAgendaVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnAgendaVoltar.TabIndex = 10;
            this.btnAgendaVoltar.UseVisualStyleBackColor = true;
            this.btnAgendaVoltar.Click += new System.EventHandler(this.btnAgendaVoltar_Click);
            // 
            // fmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(714, 556);
            this.Controls.Add(this.panelAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmAgenda";
            this.Text = "Agenda";
            this.panelAgenda.ResumeLayout(false);
            this.panelAgenda.PerformLayout();
            this.grBoxPessoaDados.ResumeLayout(false);
            this.grBoxPessoaDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgenda;
        private System.Windows.Forms.GroupBox grBoxPessoaDados;
        private System.Windows.Forms.Label lbAgendaVoltar;
        private System.Windows.Forms.Button btnAgendaVoltar;
        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsável;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.DateTimePicker dateTimeAgenda;
        private System.Windows.Forms.Label lbAgendaResponsavel;
        private System.Windows.Forms.TextBox txtAgendaResponsavel;
        private System.Windows.Forms.Label lbAgendaTipo;
        private System.Windows.Forms.Label lbAgendaHorario;
        private System.Windows.Forms.Label lbAgendaData;
        private System.Windows.Forms.Label lbAgendaAnimal;
        private System.Windows.Forms.TextBox txtAgendaAnimal;
        private System.Windows.Forms.ComboBox comboBoxAgendaTipo;
        private System.Windows.Forms.Button btnAgendaRemover;
        private System.Windows.Forms.Button btnAgendaAgendar;
        private System.Windows.Forms.Button btnAgendaAlterar;
        private System.Windows.Forms.MaskedTextBox maskAgendaHorario;
        private System.Windows.Forms.MaskedTextBox maskAgendaData;
    }
}