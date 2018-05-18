namespace frmLogin
{
    partial class fmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConsulta));
            this.panel2Consulta = new System.Windows.Forms.Panel();
            this.grBoxConsulta = new System.Windows.Forms.GroupBox();
            this.lbCpfInvalido = new System.Windows.Forms.Label();
            this.lbCpfValido = new System.Windows.Forms.Label();
            this.maskConsultaData = new System.Windows.Forms.MaskedTextBox();
            this.maskConsultaHorario = new System.Windows.Forms.MaskedTextBox();
            this.maskConsultaCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtConsultaReceita = new System.Windows.Forms.TextBox();
            this.lbConsultaObservacoes = new System.Windows.Forms.Label();
            this.txtConsultaVeterinario = new System.Windows.Forms.TextBox();
            this.txtConsultaObservacoes = new System.Windows.Forms.TextBox();
            this.comboBoxConsultaTipo = new System.Windows.Forms.ComboBox();
            this.lbConsultaCRMV = new System.Windows.Forms.Label();
            this.txtConsultaAnimal = new System.Windows.Forms.TextBox();
            this.lbConsultaReceita = new System.Windows.Forms.Label();
            this.lbConsultaData = new System.Windows.Forms.Label();
            this.txtConsultaDiagnostico = new System.Windows.Forms.TextBox();
            this.lbConsultaDiagnostico = new System.Windows.Forms.Label();
            this.lbConsultaTipo = new System.Windows.Forms.Label();
            this.lbConsultaAnimal = new System.Windows.Forms.Label();
            this.lbConsultaCpf = new System.Windows.Forms.Label();
            this.lbConsultaHorario = new System.Windows.Forms.Label();
            this.btnConsultaRemover = new System.Windows.Forms.Button();
            this.btnConsultaAlterar = new System.Windows.Forms.Button();
            this.btnConsultaProcurar = new System.Windows.Forms.Button();
            this.btnConsultaCadastrar = new System.Windows.Forms.Button();
            this.lbConsultaVoltar = new System.Windows.Forms.Label();
            this.btnConsultaVoltar = new System.Windows.Forms.Button();
            this.panel1PConsulta = new System.Windows.Forms.Panel();
            this.lbSair = new System.Windows.Forms.Label();
            this.btnConsultaImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2Consulta.SuspendLayout();
            this.grBoxConsulta.SuspendLayout();
            this.panel1PConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2Consulta
            // 
            this.panel2Consulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2Consulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2Consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2Consulta.Controls.Add(this.grBoxConsulta);
            this.panel2Consulta.Location = new System.Drawing.Point(211, 11);
            this.panel2Consulta.Name = "panel2Consulta";
            this.panel2Consulta.Size = new System.Drawing.Size(608, 573);
            this.panel2Consulta.TabIndex = 0;
            // 
            // grBoxConsulta
            // 
            this.grBoxConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBoxConsulta.Controls.Add(this.lbCpfInvalido);
            this.grBoxConsulta.Controls.Add(this.lbCpfValido);
            this.grBoxConsulta.Controls.Add(this.maskConsultaData);
            this.grBoxConsulta.Controls.Add(this.maskConsultaHorario);
            this.grBoxConsulta.Controls.Add(this.maskConsultaCpf);
            this.grBoxConsulta.Controls.Add(this.txtConsultaReceita);
            this.grBoxConsulta.Controls.Add(this.lbConsultaObservacoes);
            this.grBoxConsulta.Controls.Add(this.txtConsultaVeterinario);
            this.grBoxConsulta.Controls.Add(this.txtConsultaObservacoes);
            this.grBoxConsulta.Controls.Add(this.comboBoxConsultaTipo);
            this.grBoxConsulta.Controls.Add(this.lbConsultaCRMV);
            this.grBoxConsulta.Controls.Add(this.txtConsultaAnimal);
            this.grBoxConsulta.Controls.Add(this.lbConsultaReceita);
            this.grBoxConsulta.Controls.Add(this.lbConsultaData);
            this.grBoxConsulta.Controls.Add(this.txtConsultaDiagnostico);
            this.grBoxConsulta.Controls.Add(this.lbConsultaDiagnostico);
            this.grBoxConsulta.Controls.Add(this.lbConsultaTipo);
            this.grBoxConsulta.Controls.Add(this.lbConsultaAnimal);
            this.grBoxConsulta.Controls.Add(this.lbConsultaCpf);
            this.grBoxConsulta.Controls.Add(this.lbConsultaHorario);
            this.grBoxConsulta.Location = new System.Drawing.Point(20, 14);
            this.grBoxConsulta.Name = "grBoxConsulta";
            this.grBoxConsulta.Size = new System.Drawing.Size(569, 543);
            this.grBoxConsulta.TabIndex = 0;
            this.grBoxConsulta.TabStop = false;
            this.grBoxConsulta.Text = "Consulta";
            // 
            // lbCpfInvalido
            // 
            this.lbCpfInvalido.AutoSize = true;
            this.lbCpfInvalido.ForeColor = System.Drawing.Color.Red;
            this.lbCpfInvalido.Location = new System.Drawing.Point(232, 66);
            this.lbCpfInvalido.Name = "lbCpfInvalido";
            this.lbCpfInvalido.Size = new System.Drawing.Size(83, 13);
            this.lbCpfInvalido.TabIndex = 58;
            this.lbCpfInvalido.Text = "CPF INVÁLIDO!";
            // 
            // lbCpfValido
            // 
            this.lbCpfValido.AutoSize = true;
            this.lbCpfValido.ForeColor = System.Drawing.Color.Green;
            this.lbCpfValido.Location = new System.Drawing.Point(232, 66);
            this.lbCpfValido.Name = "lbCpfValido";
            this.lbCpfValido.Size = new System.Drawing.Size(72, 13);
            this.lbCpfValido.TabIndex = 57;
            this.lbCpfValido.Text = "CPF VÁLIDO!";
            // 
            // maskConsultaData
            // 
            this.maskConsultaData.Location = new System.Drawing.Point(342, 63);
            this.maskConsultaData.Mask = "00/00/0000";
            this.maskConsultaData.Name = "maskConsultaData";
            this.maskConsultaData.Size = new System.Drawing.Size(199, 20);
            this.maskConsultaData.TabIndex = 3;
            // 
            // maskConsultaHorario
            // 
            this.maskConsultaHorario.Location = new System.Drawing.Point(302, 120);
            this.maskConsultaHorario.Mask = "00:00";
            this.maskConsultaHorario.Name = "maskConsultaHorario";
            this.maskConsultaHorario.Size = new System.Drawing.Size(239, 20);
            this.maskConsultaHorario.TabIndex = 4;
            this.maskConsultaHorario.ValidatingType = typeof(System.DateTime);
            // 
            // maskConsultaCpf
            // 
            this.maskConsultaCpf.Location = new System.Drawing.Point(26, 63);
            this.maskConsultaCpf.Mask = "000,000,000-00";
            this.maskConsultaCpf.Name = "maskConsultaCpf";
            this.maskConsultaCpf.Size = new System.Drawing.Size(199, 20);
            this.maskConsultaCpf.TabIndex = 1;
            this.maskConsultaCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskConsultaCpf_KeyUp);
            // 
            // txtConsultaReceita
            // 
            this.txtConsultaReceita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConsultaReceita.Location = new System.Drawing.Point(26, 343);
            this.txtConsultaReceita.Multiline = true;
            this.txtConsultaReceita.Name = "txtConsultaReceita";
            this.txtConsultaReceita.Size = new System.Drawing.Size(517, 63);
            this.txtConsultaReceita.TabIndex = 8;
            // 
            // lbConsultaObservacoes
            // 
            this.lbConsultaObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsultaObservacoes.AutoSize = true;
            this.lbConsultaObservacoes.Location = new System.Drawing.Point(23, 432);
            this.lbConsultaObservacoes.Name = "lbConsultaObservacoes";
            this.lbConsultaObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lbConsultaObservacoes.TabIndex = 32;
            this.lbConsultaObservacoes.Text = "Observações";
            // 
            // txtConsultaVeterinario
            // 
            this.txtConsultaVeterinario.Location = new System.Drawing.Point(302, 178);
            this.txtConsultaVeterinario.Name = "txtConsultaVeterinario";
            this.txtConsultaVeterinario.Size = new System.Drawing.Size(239, 20);
            this.txtConsultaVeterinario.TabIndex = 6;
            this.txtConsultaVeterinario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsultaVeterinario_KeyDown);
            this.txtConsultaVeterinario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsultaVeterinario_KeyUp);
            // 
            // txtConsultaObservacoes
            // 
            this.txtConsultaObservacoes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConsultaObservacoes.Location = new System.Drawing.Point(26, 448);
            this.txtConsultaObservacoes.Multiline = true;
            this.txtConsultaObservacoes.Name = "txtConsultaObservacoes";
            this.txtConsultaObservacoes.Size = new System.Drawing.Size(517, 63);
            this.txtConsultaObservacoes.TabIndex = 9;
            // 
            // comboBoxConsultaTipo
            // 
            this.comboBoxConsultaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsultaTipo.FormattingEnabled = true;
            this.comboBoxConsultaTipo.Items.AddRange(new object[] {
            "",
            "Rotina",
            "Retorno",
            "Cirurgia"});
            this.comboBoxConsultaTipo.Location = new System.Drawing.Point(26, 177);
            this.comboBoxConsultaTipo.Name = "comboBoxConsultaTipo";
            this.comboBoxConsultaTipo.Size = new System.Drawing.Size(239, 21);
            this.comboBoxConsultaTipo.TabIndex = 5;
            // 
            // lbConsultaCRMV
            // 
            this.lbConsultaCRMV.AutoSize = true;
            this.lbConsultaCRMV.Location = new System.Drawing.Point(299, 161);
            this.lbConsultaCRMV.Name = "lbConsultaCRMV";
            this.lbConsultaCRMV.Size = new System.Drawing.Size(103, 13);
            this.lbConsultaCRMV.TabIndex = 44;
            this.lbConsultaCRMV.Text = "Veterinário ( CRMV )";
            // 
            // txtConsultaAnimal
            // 
            this.txtConsultaAnimal.Location = new System.Drawing.Point(26, 120);
            this.txtConsultaAnimal.Name = "txtConsultaAnimal";
            this.txtConsultaAnimal.Size = new System.Drawing.Size(239, 20);
            this.txtConsultaAnimal.TabIndex = 2;
            // 
            // lbConsultaReceita
            // 
            this.lbConsultaReceita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsultaReceita.AutoSize = true;
            this.lbConsultaReceita.Location = new System.Drawing.Point(23, 327);
            this.lbConsultaReceita.Name = "lbConsultaReceita";
            this.lbConsultaReceita.Size = new System.Drawing.Size(44, 13);
            this.lbConsultaReceita.TabIndex = 30;
            this.lbConsultaReceita.Text = "Receita";
            // 
            // lbConsultaData
            // 
            this.lbConsultaData.AutoSize = true;
            this.lbConsultaData.Location = new System.Drawing.Point(339, 47);
            this.lbConsultaData.Name = "lbConsultaData";
            this.lbConsultaData.Size = new System.Drawing.Size(30, 13);
            this.lbConsultaData.TabIndex = 25;
            this.lbConsultaData.Text = "Data";
            // 
            // txtConsultaDiagnostico
            // 
            this.txtConsultaDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConsultaDiagnostico.Location = new System.Drawing.Point(26, 240);
            this.txtConsultaDiagnostico.Multiline = true;
            this.txtConsultaDiagnostico.Name = "txtConsultaDiagnostico";
            this.txtConsultaDiagnostico.Size = new System.Drawing.Size(517, 63);
            this.txtConsultaDiagnostico.TabIndex = 7;
            // 
            // lbConsultaDiagnostico
            // 
            this.lbConsultaDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsultaDiagnostico.AutoSize = true;
            this.lbConsultaDiagnostico.Location = new System.Drawing.Point(23, 224);
            this.lbConsultaDiagnostico.Name = "lbConsultaDiagnostico";
            this.lbConsultaDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lbConsultaDiagnostico.TabIndex = 26;
            this.lbConsultaDiagnostico.Text = "Diagnóstico";
            // 
            // lbConsultaTipo
            // 
            this.lbConsultaTipo.AutoSize = true;
            this.lbConsultaTipo.Location = new System.Drawing.Point(23, 161);
            this.lbConsultaTipo.Name = "lbConsultaTipo";
            this.lbConsultaTipo.Size = new System.Drawing.Size(28, 13);
            this.lbConsultaTipo.TabIndex = 29;
            this.lbConsultaTipo.Text = "Tipo";
            // 
            // lbConsultaAnimal
            // 
            this.lbConsultaAnimal.AutoSize = true;
            this.lbConsultaAnimal.Location = new System.Drawing.Point(23, 104);
            this.lbConsultaAnimal.Name = "lbConsultaAnimal";
            this.lbConsultaAnimal.Size = new System.Drawing.Size(38, 13);
            this.lbConsultaAnimal.TabIndex = 28;
            this.lbConsultaAnimal.Text = "Animal";
            // 
            // lbConsultaCpf
            // 
            this.lbConsultaCpf.AutoSize = true;
            this.lbConsultaCpf.Location = new System.Drawing.Point(23, 47);
            this.lbConsultaCpf.Name = "lbConsultaCpf";
            this.lbConsultaCpf.Size = new System.Drawing.Size(104, 13);
            this.lbConsultaCpf.TabIndex = 27;
            this.lbConsultaCpf.Text = "Responsável ( CPF )";
            // 
            // lbConsultaHorario
            // 
            this.lbConsultaHorario.AutoSize = true;
            this.lbConsultaHorario.Location = new System.Drawing.Point(299, 104);
            this.lbConsultaHorario.Name = "lbConsultaHorario";
            this.lbConsultaHorario.Size = new System.Drawing.Size(41, 13);
            this.lbConsultaHorario.TabIndex = 26;
            this.lbConsultaHorario.Text = "Horário";
            // 
            // btnConsultaRemover
            // 
            this.btnConsultaRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultaRemover.Location = new System.Drawing.Point(19, 118);
            this.btnConsultaRemover.Name = "btnConsultaRemover";
            this.btnConsultaRemover.Size = new System.Drawing.Size(164, 50);
            this.btnConsultaRemover.TabIndex = 13;
            this.btnConsultaRemover.Text = "Remover";
            this.btnConsultaRemover.UseVisualStyleBackColor = true;
            this.btnConsultaRemover.Click += new System.EventHandler(this.btnConsultaRemover_Click);
            // 
            // btnConsultaAlterar
            // 
            this.btnConsultaAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultaAlterar.Location = new System.Drawing.Point(19, 47);
            this.btnConsultaAlterar.Name = "btnConsultaAlterar";
            this.btnConsultaAlterar.Size = new System.Drawing.Size(164, 50);
            this.btnConsultaAlterar.TabIndex = 12;
            this.btnConsultaAlterar.Text = "Alterar";
            this.btnConsultaAlterar.UseVisualStyleBackColor = true;
            this.btnConsultaAlterar.Click += new System.EventHandler(this.btnConsultaAlterar_Click);
            // 
            // btnConsultaProcurar
            // 
            this.btnConsultaProcurar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultaProcurar.Location = new System.Drawing.Point(19, 118);
            this.btnConsultaProcurar.Name = "btnConsultaProcurar";
            this.btnConsultaProcurar.Size = new System.Drawing.Size(164, 50);
            this.btnConsultaProcurar.TabIndex = 11;
            this.btnConsultaProcurar.Text = "Procurar";
            this.btnConsultaProcurar.UseVisualStyleBackColor = true;
            this.btnConsultaProcurar.Click += new System.EventHandler(this.btnConsultaProcurar_Click);
            // 
            // btnConsultaCadastrar
            // 
            this.btnConsultaCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultaCadastrar.Location = new System.Drawing.Point(19, 47);
            this.btnConsultaCadastrar.Name = "btnConsultaCadastrar";
            this.btnConsultaCadastrar.Size = new System.Drawing.Size(164, 50);
            this.btnConsultaCadastrar.TabIndex = 10;
            this.btnConsultaCadastrar.Text = "Cadastrar";
            this.btnConsultaCadastrar.UseVisualStyleBackColor = true;
            this.btnConsultaCadastrar.Click += new System.EventHandler(this.btnConsultaCadastrar_Click);
            // 
            // lbConsultaVoltar
            // 
            this.lbConsultaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbConsultaVoltar.AutoSize = true;
            this.lbConsultaVoltar.Location = new System.Drawing.Point(9, 505);
            this.lbConsultaVoltar.Name = "lbConsultaVoltar";
            this.lbConsultaVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbConsultaVoltar.TabIndex = 20;
            this.lbConsultaVoltar.Text = "Voltar";
            // 
            // btnConsultaVoltar
            // 
            this.btnConsultaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsultaVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaVoltar.BackgroundImage")));
            this.btnConsultaVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultaVoltar.Location = new System.Drawing.Point(3, 521);
            this.btnConsultaVoltar.Name = "btnConsultaVoltar";
            this.btnConsultaVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnConsultaVoltar.TabIndex = 14;
            this.btnConsultaVoltar.UseVisualStyleBackColor = true;
            this.btnConsultaVoltar.Click += new System.EventHandler(this.btnConsultaVoltar_Click);
            // 
            // panel1PConsulta
            // 
            this.panel1PConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1PConsulta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1PConsulta.Controls.Add(this.lbSair);
            this.panel1PConsulta.Controls.Add(this.btnConsultaImprimir);
            this.panel1PConsulta.Controls.Add(this.btnSair);
            this.panel1PConsulta.Controls.Add(this.btnConsultaAlterar);
            this.panel1PConsulta.Controls.Add(this.lbConsultaVoltar);
            this.panel1PConsulta.Controls.Add(this.btnConsultaRemover);
            this.panel1PConsulta.Controls.Add(this.btnConsultaVoltar);
            this.panel1PConsulta.Controls.Add(this.btnConsultaCadastrar);
            this.panel1PConsulta.Controls.Add(this.btnConsultaProcurar);
            this.panel1PConsulta.Location = new System.Drawing.Point(12, 11);
            this.panel1PConsulta.Name = "panel1PConsulta";
            this.panel1PConsulta.Size = new System.Drawing.Size(201, 573);
            this.panel1PConsulta.TabIndex = 52;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSair.AutoSize = true;
            this.lbSair.Location = new System.Drawing.Point(9, 505);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(34, 13);
            this.lbSair.TabIndex = 54;
            this.lbSair.Text = "  Sair ";
            // 
            // btnConsultaImprimir
            // 
            this.btnConsultaImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultaImprimir.Location = new System.Drawing.Point(19, 436);
            this.btnConsultaImprimir.Name = "btnConsultaImprimir";
            this.btnConsultaImprimir.Size = new System.Drawing.Size(164, 50);
            this.btnConsultaImprimir.TabIndex = 21;
            this.btnConsultaImprimir.Text = "Imprimir";
            this.btnConsultaImprimir.UseVisualStyleBackColor = true;
            this.btnConsultaImprimir.Click += new System.EventHandler(this.btnConsultaImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(3, 521);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 49);
            this.btnSair.TabIndex = 53;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // fmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(831, 595);
            this.Controls.Add(this.panel1PConsulta);
            this.Controls.Add(this.panel2Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmConsulta";
            this.Text = "Consulta";
            this.panel2Consulta.ResumeLayout(false);
            this.grBoxConsulta.ResumeLayout(false);
            this.grBoxConsulta.PerformLayout();
            this.panel1PConsulta.ResumeLayout(false);
            this.panel1PConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2Consulta;
        private System.Windows.Forms.GroupBox grBoxConsulta;
        private System.Windows.Forms.TextBox txtConsultaAnimal;
        private System.Windows.Forms.Label lbConsultaTipo;
        private System.Windows.Forms.Label lbConsultaAnimal;
        private System.Windows.Forms.Label lbConsultaCpf;
        private System.Windows.Forms.Label lbConsultaHorario;
        private System.Windows.Forms.Label lbConsultaData;
        private System.Windows.Forms.TextBox txtConsultaObservacoes;
        private System.Windows.Forms.Label lbConsultaObservacoes;
        private System.Windows.Forms.Label lbConsultaReceita;
        private System.Windows.Forms.TextBox txtConsultaDiagnostico;
        private System.Windows.Forms.Label lbConsultaDiagnostico;
        private System.Windows.Forms.Button btnConsultaRemover;
        private System.Windows.Forms.Button btnConsultaAlterar;
        private System.Windows.Forms.Button btnConsultaProcurar;
        private System.Windows.Forms.Button btnConsultaCadastrar;
        private System.Windows.Forms.Label lbConsultaVoltar;
        private System.Windows.Forms.Button btnConsultaVoltar;
        private System.Windows.Forms.TextBox txtConsultaReceita;
        private System.Windows.Forms.ComboBox comboBoxConsultaTipo;
        private System.Windows.Forms.Label lbConsultaCRMV;
        private System.Windows.Forms.MaskedTextBox maskConsultaCpf;
        private System.Windows.Forms.MaskedTextBox maskConsultaHorario;
        private System.Windows.Forms.MaskedTextBox maskConsultaData;
        private System.Windows.Forms.TextBox txtConsultaVeterinario;
        private System.Windows.Forms.Label lbCpfInvalido;
        private System.Windows.Forms.Label lbCpfValido;
        private System.Windows.Forms.Panel panel1PConsulta;
        private System.Windows.Forms.Button btnConsultaImprimir;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Button btnSair;
    }
}