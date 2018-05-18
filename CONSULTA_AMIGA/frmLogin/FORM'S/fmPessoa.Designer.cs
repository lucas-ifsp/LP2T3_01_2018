namespace frmLogin
{
    partial class fmPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPessoa));
            this.panel2Pessoa = new System.Windows.Forms.Panel();
            this.groupBoxPessoaAnimais = new System.Windows.Forms.GroupBox();
            this.btnPessoaRefresh = new System.Windows.Forms.Button();
            this.btnPessoaAnimal = new System.Windows.Forms.Button();
            this.dataGridViewPessoaAnimais = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESPÉCIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBoxPessoaDados = new System.Windows.Forms.GroupBox();
            this.lbCpfInvalido = new System.Windows.Forms.Label();
            this.lbCpfValido = new System.Windows.Forms.Label();
            this.maskPessoaCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskPessoaTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskPessoaCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskPessoaNasc = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxPessoaSexo = new System.Windows.Forms.GroupBox();
            this.radBtnPessoaMasculino = new System.Windows.Forms.RadioButton();
            this.radBtnPessoaFeminino = new System.Windows.Forms.RadioButton();
            this.grBoxPessoaEndereco = new System.Windows.Forms.GroupBox();
            this.txtPessoaCep = new System.Windows.Forms.TextBox();
            this.txtPessoaBairro = new System.Windows.Forms.TextBox();
            this.lbPessoaBairro = new System.Windows.Forms.Label();
            this.comboBoxPessoaEstado = new System.Windows.Forms.ComboBox();
            this.lbPessoaCep = new System.Windows.Forms.Label();
            this.txtPessoaCidade = new System.Windows.Forms.TextBox();
            this.lbPessoaEstado = new System.Windows.Forms.Label();
            this.txtPessoaNumero = new System.Windows.Forms.TextBox();
            this.lbPessoaNumero = new System.Windows.Forms.Label();
            this.lbPessoaCidade = new System.Windows.Forms.Label();
            this.lbPessoaRua = new System.Windows.Forms.Label();
            this.txtPessoaRua = new System.Windows.Forms.TextBox();
            this.txtPessoaNome = new System.Windows.Forms.TextBox();
            this.lbPessoaCelular = new System.Windows.Forms.Label();
            this.lbPessoaTelefone = new System.Windows.Forms.Label();
            this.lbPessoaNasc = new System.Windows.Forms.Label();
            this.lbPessoaNome = new System.Windows.Forms.Label();
            this.lbPessoaCpf = new System.Windows.Forms.Label();
            this.btnPessoaRemover = new System.Windows.Forms.Button();
            this.btnPessoaAlterar = new System.Windows.Forms.Button();
            this.btnPessoaProcurar = new System.Windows.Forms.Button();
            this.btnPessoaCadastrar = new System.Windows.Forms.Button();
            this.lbPessoaVoltar = new System.Windows.Forms.Label();
            this.panel1Pessoa = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbSair = new System.Windows.Forms.Label();
            this.btnPessoaVoltar = new System.Windows.Forms.Button();
            this.panel2Pessoa.SuspendLayout();
            this.groupBoxPessoaAnimais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoaAnimais)).BeginInit();
            this.grBoxPessoaDados.SuspendLayout();
            this.groupBoxPessoaSexo.SuspendLayout();
            this.grBoxPessoaEndereco.SuspendLayout();
            this.panel1Pessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2Pessoa
            // 
            this.panel2Pessoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2Pessoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2Pessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2Pessoa.Controls.Add(this.groupBoxPessoaAnimais);
            this.panel2Pessoa.Controls.Add(this.grBoxPessoaDados);
            this.panel2Pessoa.Location = new System.Drawing.Point(212, 12);
            this.panel2Pessoa.Name = "panel2Pessoa";
            this.panel2Pessoa.Size = new System.Drawing.Size(605, 555);
            this.panel2Pessoa.TabIndex = 0;
            // 
            // groupBoxPessoaAnimais
            // 
            this.groupBoxPessoaAnimais.Controls.Add(this.btnPessoaRefresh);
            this.groupBoxPessoaAnimais.Controls.Add(this.btnPessoaAnimal);
            this.groupBoxPessoaAnimais.Controls.Add(this.dataGridViewPessoaAnimais);
            this.groupBoxPessoaAnimais.Location = new System.Drawing.Point(15, 387);
            this.groupBoxPessoaAnimais.Name = "groupBoxPessoaAnimais";
            this.groupBoxPessoaAnimais.Size = new System.Drawing.Size(571, 152);
            this.groupBoxPessoaAnimais.TabIndex = 20;
            this.groupBoxPessoaAnimais.TabStop = false;
            this.groupBoxPessoaAnimais.Text = "Animais";
            // 
            // btnPessoaRefresh
            // 
            this.btnPessoaRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPessoaRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaRefresh.Image = global::frmLogin.Properties.Resources._1480491657_reload;
            this.btnPessoaRefresh.Location = new System.Drawing.Point(522, 81);
            this.btnPessoaRefresh.Name = "btnPessoaRefresh";
            this.btnPessoaRefresh.Size = new System.Drawing.Size(43, 38);
            this.btnPessoaRefresh.TabIndex = 52;
            this.btnPessoaRefresh.UseVisualStyleBackColor = true;
            this.btnPessoaRefresh.Click += new System.EventHandler(this.btnPessoaRefresh_Click);
            // 
            // btnPessoaAnimal
            // 
            this.btnPessoaAnimal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPessoaAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaAnimal.Image = global::frmLogin.Properties.Resources._1475757417_cat;
            this.btnPessoaAnimal.Location = new System.Drawing.Point(522, 37);
            this.btnPessoaAnimal.Name = "btnPessoaAnimal";
            this.btnPessoaAnimal.Size = new System.Drawing.Size(43, 38);
            this.btnPessoaAnimal.TabIndex = 51;
            this.btnPessoaAnimal.UseVisualStyleBackColor = true;
            this.btnPessoaAnimal.Click += new System.EventHandler(this.btnPessoaAnimal_Click);
            // 
            // dataGridViewPessoaAnimais
            // 
            this.dataGridViewPessoaAnimais.AllowUserToAddRows = false;
            this.dataGridViewPessoaAnimais.AllowUserToDeleteRows = false;
            this.dataGridViewPessoaAnimais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPessoaAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoaAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.ESPÉCIE,
            this.Raça,
            this.Nascimento});
            this.dataGridViewPessoaAnimais.Location = new System.Drawing.Point(24, 28);
            this.dataGridViewPessoaAnimais.Name = "dataGridViewPessoaAnimais";
            this.dataGridViewPessoaAnimais.ReadOnly = true;
            this.dataGridViewPessoaAnimais.Size = new System.Drawing.Size(492, 98);
            this.dataGridViewPessoaAnimais.TabIndex = 20;
            this.dataGridViewPessoaAnimais.DoubleClick += new System.EventHandler(this.dataGridViewPessoaAnimais_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // ESPÉCIE
            // 
            this.ESPÉCIE.HeaderText = "ESPÉCIE";
            this.ESPÉCIE.Name = "ESPÉCIE";
            this.ESPÉCIE.ReadOnly = true;
            // 
            // Raça
            // 
            this.Raça.HeaderText = "RAÇA";
            this.Raça.Name = "Raça";
            this.Raça.ReadOnly = true;
            // 
            // Nascimento
            // 
            this.Nascimento.HeaderText = "NASCIMENTO";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.ReadOnly = true;
            // 
            // grBoxPessoaDados
            // 
            this.grBoxPessoaDados.Controls.Add(this.lbCpfInvalido);
            this.grBoxPessoaDados.Controls.Add(this.lbCpfValido);
            this.grBoxPessoaDados.Controls.Add(this.maskPessoaCelular);
            this.grBoxPessoaDados.Controls.Add(this.maskPessoaTelefone);
            this.grBoxPessoaDados.Controls.Add(this.maskPessoaCpf);
            this.grBoxPessoaDados.Controls.Add(this.maskPessoaNasc);
            this.grBoxPessoaDados.Controls.Add(this.groupBoxPessoaSexo);
            this.grBoxPessoaDados.Controls.Add(this.grBoxPessoaEndereco);
            this.grBoxPessoaDados.Controls.Add(this.txtPessoaNome);
            this.grBoxPessoaDados.Controls.Add(this.lbPessoaCelular);
            this.grBoxPessoaDados.Controls.Add(this.lbPessoaTelefone);
            this.grBoxPessoaDados.Controls.Add(this.lbPessoaNasc);
            this.grBoxPessoaDados.Controls.Add(this.lbPessoaNome);
            this.grBoxPessoaDados.Controls.Add(this.lbPessoaCpf);
            this.grBoxPessoaDados.Location = new System.Drawing.Point(15, 22);
            this.grBoxPessoaDados.Name = "grBoxPessoaDados";
            this.grBoxPessoaDados.Size = new System.Drawing.Size(571, 350);
            this.grBoxPessoaDados.TabIndex = 0;
            this.grBoxPessoaDados.TabStop = false;
            this.grBoxPessoaDados.Text = "Dados";
            // 
            // lbCpfInvalido
            // 
            this.lbCpfInvalido.AutoSize = true;
            this.lbCpfInvalido.ForeColor = System.Drawing.Color.Red;
            this.lbCpfInvalido.Location = new System.Drawing.Point(212, 55);
            this.lbCpfInvalido.Name = "lbCpfInvalido";
            this.lbCpfInvalido.Size = new System.Drawing.Size(83, 13);
            this.lbCpfInvalido.TabIndex = 54;
            this.lbCpfInvalido.Text = "CPF INVÁLIDO!";
            // 
            // lbCpfValido
            // 
            this.lbCpfValido.AutoSize = true;
            this.lbCpfValido.ForeColor = System.Drawing.Color.Green;
            this.lbCpfValido.Location = new System.Drawing.Point(212, 55);
            this.lbCpfValido.Name = "lbCpfValido";
            this.lbCpfValido.Size = new System.Drawing.Size(72, 13);
            this.lbCpfValido.TabIndex = 53;
            this.lbCpfValido.Text = "CPF VÁLIDO!";
            // 
            // maskPessoaCelular
            // 
            this.maskPessoaCelular.Location = new System.Drawing.Point(379, 105);
            this.maskPessoaCelular.Mask = "(99) 00000-0000";
            this.maskPessoaCelular.Name = "maskPessoaCelular";
            this.maskPessoaCelular.Size = new System.Drawing.Size(171, 20);
            this.maskPessoaCelular.TabIndex = 5;
            // 
            // maskPessoaTelefone
            // 
            this.maskPessoaTelefone.Location = new System.Drawing.Point(379, 52);
            this.maskPessoaTelefone.Mask = "(99) 0000-0000";
            this.maskPessoaTelefone.Name = "maskPessoaTelefone";
            this.maskPessoaTelefone.Size = new System.Drawing.Size(171, 20);
            this.maskPessoaTelefone.TabIndex = 4;
            // 
            // maskPessoaCpf
            // 
            this.maskPessoaCpf.Location = new System.Drawing.Point(23, 52);
            this.maskPessoaCpf.Mask = "000,000,000-00";
            this.maskPessoaCpf.Name = "maskPessoaCpf";
            this.maskPessoaCpf.Size = new System.Drawing.Size(183, 20);
            this.maskPessoaCpf.TabIndex = 1;
            this.maskPessoaCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskPessoaCpf_KeyUp);
            // 
            // maskPessoaNasc
            // 
            this.maskPessoaNasc.Location = new System.Drawing.Point(23, 159);
            this.maskPessoaNasc.Mask = "00/00/0000";
            this.maskPessoaNasc.Name = "maskPessoaNasc";
            this.maskPessoaNasc.Size = new System.Drawing.Size(183, 20);
            this.maskPessoaNasc.TabIndex = 3;
            // 
            // groupBoxPessoaSexo
            // 
            this.groupBoxPessoaSexo.Controls.Add(this.radBtnPessoaMasculino);
            this.groupBoxPessoaSexo.Controls.Add(this.radBtnPessoaFeminino);
            this.groupBoxPessoaSexo.Location = new System.Drawing.Point(226, 143);
            this.groupBoxPessoaSexo.Name = "groupBoxPessoaSexo";
            this.groupBoxPessoaSexo.Size = new System.Drawing.Size(339, 36);
            this.groupBoxPessoaSexo.TabIndex = 6;
            this.groupBoxPessoaSexo.TabStop = false;
            this.groupBoxPessoaSexo.Text = "Sexo";
            // 
            // radBtnPessoaMasculino
            // 
            this.radBtnPessoaMasculino.AutoSize = true;
            this.radBtnPessoaMasculino.Location = new System.Drawing.Point(79, 13);
            this.radBtnPessoaMasculino.Name = "radBtnPessoaMasculino";
            this.radBtnPessoaMasculino.Size = new System.Drawing.Size(73, 17);
            this.radBtnPessoaMasculino.TabIndex = 6;
            this.radBtnPessoaMasculino.TabStop = true;
            this.radBtnPessoaMasculino.Text = "Masculino";
            this.radBtnPessoaMasculino.UseVisualStyleBackColor = true;
            // 
            // radBtnPessoaFeminino
            // 
            this.radBtnPessoaFeminino.AutoSize = true;
            this.radBtnPessoaFeminino.Location = new System.Drawing.Point(196, 13);
            this.radBtnPessoaFeminino.Name = "radBtnPessoaFeminino";
            this.radBtnPessoaFeminino.Size = new System.Drawing.Size(67, 17);
            this.radBtnPessoaFeminino.TabIndex = 7;
            this.radBtnPessoaFeminino.TabStop = true;
            this.radBtnPessoaFeminino.Text = "Feminino";
            this.radBtnPessoaFeminino.UseVisualStyleBackColor = true;
            // 
            // grBoxPessoaEndereco
            // 
            this.grBoxPessoaEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxPessoaEndereco.Controls.Add(this.txtPessoaCep);
            this.grBoxPessoaEndereco.Controls.Add(this.txtPessoaBairro);
            this.grBoxPessoaEndereco.Controls.Add(this.lbPessoaBairro);
            this.grBoxPessoaEndereco.Controls.Add(this.comboBoxPessoaEstado);
            this.grBoxPessoaEndereco.Controls.Add(this.lbPessoaCep);
            this.grBoxPessoaEndereco.Controls.Add(this.txtPessoaCidade);
            this.grBoxPessoaEndereco.Controls.Add(this.lbPessoaEstado);
            this.grBoxPessoaEndereco.Controls.Add(this.txtPessoaNumero);
            this.grBoxPessoaEndereco.Controls.Add(this.lbPessoaNumero);
            this.grBoxPessoaEndereco.Controls.Add(this.lbPessoaCidade);
            this.grBoxPessoaEndereco.Controls.Add(this.lbPessoaRua);
            this.grBoxPessoaEndereco.Controls.Add(this.txtPessoaRua);
            this.grBoxPessoaEndereco.Location = new System.Drawing.Point(6, 200);
            this.grBoxPessoaEndereco.Name = "grBoxPessoaEndereco";
            this.grBoxPessoaEndereco.Size = new System.Drawing.Size(559, 144);
            this.grBoxPessoaEndereco.TabIndex = 8;
            this.grBoxPessoaEndereco.TabStop = false;
            this.grBoxPessoaEndereco.Text = "Endereço";
            // 
            // txtPessoaCep
            // 
            this.txtPessoaCep.Location = new System.Drawing.Point(220, 95);
            this.txtPessoaCep.Name = "txtPessoaCep";
            this.txtPessoaCep.Size = new System.Drawing.Size(135, 20);
            this.txtPessoaCep.TabIndex = 12;
            this.txtPessoaCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPessoaCep_KeyDown);
            this.txtPessoaCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPessoaCep_KeyUp);
            // 
            // txtPessoaBairro
            // 
            this.txtPessoaBairro.Location = new System.Drawing.Point(18, 95);
            this.txtPessoaBairro.Name = "txtPessoaBairro";
            this.txtPessoaBairro.Size = new System.Drawing.Size(182, 20);
            this.txtPessoaBairro.TabIndex = 11;
            // 
            // lbPessoaBairro
            // 
            this.lbPessoaBairro.AutoSize = true;
            this.lbPessoaBairro.Location = new System.Drawing.Point(15, 79);
            this.lbPessoaBairro.Name = "lbPessoaBairro";
            this.lbPessoaBairro.Size = new System.Drawing.Size(34, 13);
            this.lbPessoaBairro.TabIndex = 32;
            this.lbPessoaBairro.Text = "Bairro";
            // 
            // comboBoxPessoaEstado
            // 
            this.comboBoxPessoaEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPessoaEstado.FormattingEnabled = true;
            this.comboBoxPessoaEstado.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxPessoaEstado.Location = new System.Drawing.Point(373, 94);
            this.comboBoxPessoaEstado.Name = "comboBoxPessoaEstado";
            this.comboBoxPessoaEstado.Size = new System.Drawing.Size(171, 21);
            this.comboBoxPessoaEstado.TabIndex = 13;
            // 
            // lbPessoaCep
            // 
            this.lbPessoaCep.AutoSize = true;
            this.lbPessoaCep.Location = new System.Drawing.Point(217, 79);
            this.lbPessoaCep.Name = "lbPessoaCep";
            this.lbPessoaCep.Size = new System.Drawing.Size(28, 13);
            this.lbPessoaCep.TabIndex = 42;
            this.lbPessoaCep.Text = "CEP";
            // 
            // txtPessoaCidade
            // 
            this.txtPessoaCidade.Location = new System.Drawing.Point(373, 41);
            this.txtPessoaCidade.Name = "txtPessoaCidade";
            this.txtPessoaCidade.Size = new System.Drawing.Size(171, 20);
            this.txtPessoaCidade.TabIndex = 10;
            // 
            // lbPessoaEstado
            // 
            this.lbPessoaEstado.AutoSize = true;
            this.lbPessoaEstado.Location = new System.Drawing.Point(370, 79);
            this.lbPessoaEstado.Name = "lbPessoaEstado";
            this.lbPessoaEstado.Size = new System.Drawing.Size(40, 13);
            this.lbPessoaEstado.TabIndex = 40;
            this.lbPessoaEstado.Text = "Estado";
            // 
            // txtPessoaNumero
            // 
            this.txtPessoaNumero.Location = new System.Drawing.Point(220, 41);
            this.txtPessoaNumero.Name = "txtPessoaNumero";
            this.txtPessoaNumero.Size = new System.Drawing.Size(135, 20);
            this.txtPessoaNumero.TabIndex = 9;
            // 
            // lbPessoaNumero
            // 
            this.lbPessoaNumero.AutoSize = true;
            this.lbPessoaNumero.Location = new System.Drawing.Point(217, 25);
            this.lbPessoaNumero.Name = "lbPessoaNumero";
            this.lbPessoaNumero.Size = new System.Drawing.Size(44, 13);
            this.lbPessoaNumero.TabIndex = 38;
            this.lbPessoaNumero.Text = "Número";
            // 
            // lbPessoaCidade
            // 
            this.lbPessoaCidade.AutoSize = true;
            this.lbPessoaCidade.Location = new System.Drawing.Point(370, 25);
            this.lbPessoaCidade.Name = "lbPessoaCidade";
            this.lbPessoaCidade.Size = new System.Drawing.Size(40, 13);
            this.lbPessoaCidade.TabIndex = 30;
            this.lbPessoaCidade.Text = "Cidade";
            // 
            // lbPessoaRua
            // 
            this.lbPessoaRua.AutoSize = true;
            this.lbPessoaRua.Location = new System.Drawing.Point(15, 25);
            this.lbPessoaRua.Name = "lbPessoaRua";
            this.lbPessoaRua.Size = new System.Drawing.Size(27, 13);
            this.lbPessoaRua.TabIndex = 26;
            this.lbPessoaRua.Text = "Rua";
            // 
            // txtPessoaRua
            // 
            this.txtPessoaRua.Location = new System.Drawing.Point(18, 41);
            this.txtPessoaRua.Name = "txtPessoaRua";
            this.txtPessoaRua.Size = new System.Drawing.Size(182, 20);
            this.txtPessoaRua.TabIndex = 8;
            // 
            // txtPessoaNome
            // 
            this.txtPessoaNome.Location = new System.Drawing.Point(24, 105);
            this.txtPessoaNome.Name = "txtPessoaNome";
            this.txtPessoaNome.Size = new System.Drawing.Size(337, 20);
            this.txtPessoaNome.TabIndex = 2;
            // 
            // lbPessoaCelular
            // 
            this.lbPessoaCelular.AutoSize = true;
            this.lbPessoaCelular.Location = new System.Drawing.Point(376, 89);
            this.lbPessoaCelular.Name = "lbPessoaCelular";
            this.lbPessoaCelular.Size = new System.Drawing.Size(39, 13);
            this.lbPessoaCelular.TabIndex = 29;
            this.lbPessoaCelular.Text = "Celular";
            // 
            // lbPessoaTelefone
            // 
            this.lbPessoaTelefone.AutoSize = true;
            this.lbPessoaTelefone.Location = new System.Drawing.Point(376, 36);
            this.lbPessoaTelefone.Name = "lbPessoaTelefone";
            this.lbPessoaTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbPessoaTelefone.TabIndex = 28;
            this.lbPessoaTelefone.Text = "Telefone";
            // 
            // lbPessoaNasc
            // 
            this.lbPessoaNasc.AutoSize = true;
            this.lbPessoaNasc.Location = new System.Drawing.Point(20, 143);
            this.lbPessoaNasc.Name = "lbPessoaNasc";
            this.lbPessoaNasc.Size = new System.Drawing.Size(89, 13);
            this.lbPessoaNasc.TabIndex = 101;
            this.lbPessoaNasc.Text = "Data Nascimento";
            // 
            // lbPessoaNome
            // 
            this.lbPessoaNome.AutoSize = true;
            this.lbPessoaNome.Location = new System.Drawing.Point(20, 89);
            this.lbPessoaNome.Name = "lbPessoaNome";
            this.lbPessoaNome.Size = new System.Drawing.Size(35, 13);
            this.lbPessoaNome.TabIndex = 26;
            this.lbPessoaNome.Text = "Nome";
            // 
            // lbPessoaCpf
            // 
            this.lbPessoaCpf.AutoSize = true;
            this.lbPessoaCpf.Location = new System.Drawing.Point(21, 36);
            this.lbPessoaCpf.Name = "lbPessoaCpf";
            this.lbPessoaCpf.Size = new System.Drawing.Size(27, 13);
            this.lbPessoaCpf.TabIndex = 25;
            this.lbPessoaCpf.Text = "CPF";
            // 
            // btnPessoaRemover
            // 
            this.btnPessoaRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPessoaRemover.Location = new System.Drawing.Point(16, 112);
            this.btnPessoaRemover.Name = "btnPessoaRemover";
            this.btnPessoaRemover.Size = new System.Drawing.Size(164, 50);
            this.btnPessoaRemover.TabIndex = 15;
            this.btnPessoaRemover.Text = "Remover";
            this.btnPessoaRemover.UseVisualStyleBackColor = true;
            this.btnPessoaRemover.Click += new System.EventHandler(this.btnPessoaRemover_Click);
            // 
            // btnPessoaAlterar
            // 
            this.btnPessoaAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPessoaAlterar.Location = new System.Drawing.Point(16, 44);
            this.btnPessoaAlterar.Name = "btnPessoaAlterar";
            this.btnPessoaAlterar.Size = new System.Drawing.Size(164, 50);
            this.btnPessoaAlterar.TabIndex = 14;
            this.btnPessoaAlterar.Text = "Alterar";
            this.btnPessoaAlterar.UseVisualStyleBackColor = true;
            this.btnPessoaAlterar.Click += new System.EventHandler(this.btnPessoaAlterar_Click);
            // 
            // btnPessoaProcurar
            // 
            this.btnPessoaProcurar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPessoaProcurar.Location = new System.Drawing.Point(16, 112);
            this.btnPessoaProcurar.Name = "btnPessoaProcurar";
            this.btnPessoaProcurar.Size = new System.Drawing.Size(164, 50);
            this.btnPessoaProcurar.TabIndex = 18;
            this.btnPessoaProcurar.Text = "Procurar";
            this.btnPessoaProcurar.UseVisualStyleBackColor = true;
            this.btnPessoaProcurar.Click += new System.EventHandler(this.btnPessoaProcurar_Click);
            // 
            // btnPessoaCadastrar
            // 
            this.btnPessoaCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPessoaCadastrar.Location = new System.Drawing.Point(16, 44);
            this.btnPessoaCadastrar.Name = "btnPessoaCadastrar";
            this.btnPessoaCadastrar.Size = new System.Drawing.Size(164, 50);
            this.btnPessoaCadastrar.TabIndex = 17;
            this.btnPessoaCadastrar.Text = "Cadastrar";
            this.btnPessoaCadastrar.UseVisualStyleBackColor = true;
            this.btnPessoaCadastrar.Click += new System.EventHandler(this.btnPessoaCadastrar_Click);
            // 
            // lbPessoaVoltar
            // 
            this.lbPessoaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPessoaVoltar.AutoSize = true;
            this.lbPessoaVoltar.Location = new System.Drawing.Point(11, 485);
            this.lbPessoaVoltar.Name = "lbPessoaVoltar";
            this.lbPessoaVoltar.Size = new System.Drawing.Size(34, 13);
            this.lbPessoaVoltar.TabIndex = 50;
            this.lbPessoaVoltar.Text = "Voltar";
            // 
            // panel1Pessoa
            // 
            this.panel1Pessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1Pessoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1Pessoa.Controls.Add(this.btnPessoaAlterar);
            this.panel1Pessoa.Controls.Add(this.btnPessoaRemover);
            this.panel1Pessoa.Controls.Add(this.btnPessoaCadastrar);
            this.panel1Pessoa.Controls.Add(this.btnPessoaProcurar);
            this.panel1Pessoa.Controls.Add(this.btnSair);
            this.panel1Pessoa.Controls.Add(this.lbSair);
            this.panel1Pessoa.Controls.Add(this.lbPessoaVoltar);
            this.panel1Pessoa.Controls.Add(this.btnPessoaVoltar);
            this.panel1Pessoa.Location = new System.Drawing.Point(15, 12);
            this.panel1Pessoa.Name = "panel1Pessoa";
            this.panel1Pessoa.Size = new System.Drawing.Size(207, 555);
            this.panel1Pessoa.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(3, 503);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 49);
            this.btnSair.TabIndex = 55;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSair.AutoSize = true;
            this.lbSair.Location = new System.Drawing.Point(9, 487);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(34, 13);
            this.lbSair.TabIndex = 56;
            this.lbSair.Text = "  Sair ";
            // 
            // btnPessoaVoltar
            // 
            this.btnPessoaVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPessoaVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPessoaVoltar.BackgroundImage")));
            this.btnPessoaVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPessoaVoltar.Location = new System.Drawing.Point(3, 503);
            this.btnPessoaVoltar.Name = "btnPessoaVoltar";
            this.btnPessoaVoltar.Size = new System.Drawing.Size(50, 49);
            this.btnPessoaVoltar.TabIndex = 16;
            this.btnPessoaVoltar.UseVisualStyleBackColor = true;
            this.btnPessoaVoltar.Click += new System.EventHandler(this.btnPessoaVoltar_Click);
            // 
            // fmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(829, 579);
            this.Controls.Add(this.panel2Pessoa);
            this.Controls.Add(this.panel1Pessoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmPessoa";
            this.Text = "Pessoa";
            this.Load += new System.EventHandler(this.fmPessoa_Load);
            this.panel2Pessoa.ResumeLayout(false);
            this.groupBoxPessoaAnimais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoaAnimais)).EndInit();
            this.grBoxPessoaDados.ResumeLayout(false);
            this.grBoxPessoaDados.PerformLayout();
            this.groupBoxPessoaSexo.ResumeLayout(false);
            this.groupBoxPessoaSexo.PerformLayout();
            this.grBoxPessoaEndereco.ResumeLayout(false);
            this.grBoxPessoaEndereco.PerformLayout();
            this.panel1Pessoa.ResumeLayout(false);
            this.panel1Pessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2Pessoa;
        private System.Windows.Forms.Label lbPessoaVoltar;
        private System.Windows.Forms.Button btnPessoaAlterar;
        private System.Windows.Forms.Button btnPessoaProcurar;
        private System.Windows.Forms.Button btnPessoaCadastrar;
        private System.Windows.Forms.Button btnPessoaRemover;
        private System.Windows.Forms.GroupBox grBoxPessoaEndereco;
        private System.Windows.Forms.TextBox txtPessoaBairro;
        private System.Windows.Forms.Label lbPessoaBairro;
        private System.Windows.Forms.TextBox txtPessoaCidade;
        private System.Windows.Forms.Label lbPessoaCidade;
        private System.Windows.Forms.TextBox txtPessoaRua;
        private System.Windows.Forms.Label lbPessoaRua;
        private System.Windows.Forms.GroupBox grBoxPessoaDados;
        private System.Windows.Forms.GroupBox groupBoxPessoaSexo;
        private System.Windows.Forms.RadioButton radBtnPessoaMasculino;
        private System.Windows.Forms.RadioButton radBtnPessoaFeminino;
        private System.Windows.Forms.TextBox txtPessoaNome;
        private System.Windows.Forms.Label lbPessoaCelular;
        private System.Windows.Forms.Label lbPessoaTelefone;
        private System.Windows.Forms.Label lbPessoaNasc;
        private System.Windows.Forms.Label lbPessoaNome;
        private System.Windows.Forms.Label lbPessoaCpf;
        private System.Windows.Forms.TextBox txtPessoaCep;
        private System.Windows.Forms.Label lbPessoaCep;
        private System.Windows.Forms.ComboBox comboBoxPessoaEstado;
        private System.Windows.Forms.Label lbPessoaEstado;
        private System.Windows.Forms.TextBox txtPessoaNumero;
        private System.Windows.Forms.Label lbPessoaNumero;
        private System.Windows.Forms.GroupBox groupBoxPessoaAnimais;
        private System.Windows.Forms.DataGridView dataGridViewPessoaAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESPÉCIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raça;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.MaskedTextBox maskPessoaCelular;
        private System.Windows.Forms.MaskedTextBox maskPessoaTelefone;
        private System.Windows.Forms.MaskedTextBox maskPessoaCpf;
        private System.Windows.Forms.MaskedTextBox maskPessoaNasc;
        private System.Windows.Forms.Label lbCpfValido;
        private System.Windows.Forms.Label lbCpfInvalido;
        private System.Windows.Forms.Panel panel1Pessoa;
        private System.Windows.Forms.Button btnPessoaVoltar;
        private System.Windows.Forms.Button btnPessoaAnimal;
        private System.Windows.Forms.Button btnPessoaRefresh;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbSair;
    }
}