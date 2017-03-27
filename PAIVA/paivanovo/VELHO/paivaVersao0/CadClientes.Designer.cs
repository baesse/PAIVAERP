namespace paivaVersao0
{
    partial class CadClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadClientes));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cbbEstadoCobranca = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.CbbContatos = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbbTipoCalulo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CPFCNPJ = new MetroFramework.Controls.MetroLabel();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.txtFuncaoCargo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtDatadeNascimento = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.txtCepCobranca = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtCepEntrega = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.cbbEstadoEntrega = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoCobranca = new System.Windows.Forms.TextBox();
            this.txtBairroCobranca = new System.Windows.Forms.TextBox();
            this.txtCidadeCobranca = new System.Windows.Forms.TextBox();
            this.txtEnderecoEntrega = new System.Windows.Forms.TextBox();
            this.txtBairroEntrega = new System.Windows.Forms.TextBox();
            this.txtCidadeEntrega = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.novocontatotxt = new System.Windows.Forms.TextBox();
            this.novocontato = new System.Windows.Forms.Label();
            this.txtTelefoneFixoEntrega = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularEntreg = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularCobranca = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneFixoCobranca = new System.Windows.Forms.MaskedTextBox();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(279, 364);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(85, 19);
            this.metroLabel16.TabIndex = 72;
            this.metroLabel16.Text = "Telefone fixo:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(20, 365);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(54, 19);
            this.metroLabel15.TabIndex = 70;
            this.metroLabel15.Text = "Cidade:";
            // 
            // cbbEstadoCobranca
            // 
            this.cbbEstadoCobranca.Enabled = false;
            this.cbbEstadoCobranca.FormattingEnabled = true;
            this.cbbEstadoCobranca.ItemHeight = 23;
            this.cbbEstadoCobranca.Items.AddRange(new object[] {
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
            this.cbbEstadoCobranca.Location = new System.Drawing.Point(951, 307);
            this.cbbEstadoCobranca.Name = "cbbEstadoCobranca";
            this.cbbEstadoCobranca.Size = new System.Drawing.Size(90, 29);
            this.cbbEstadoCobranca.TabIndex = 64;
            this.cbbEstadoCobranca.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(902, 317);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(51, 19);
            this.metroLabel14.TabIndex = 65;
            this.metroLabel14.Text = "Estado:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(578, 316);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(48, 19);
            this.metroLabel12.TabIndex = 68;
            this.metroLabel12.Text = "Bairro:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(181, 316);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 66;
            this.metroLabel11.Text = "Endereço:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 317);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(36, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "CEP:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 407);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(315, 17);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Endereco de entrega é o mesmo do endereço de cobrança ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(582, 260);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(44, 19);
            this.metroLabel8.TabIndex = 83;
            this.metroLabel8.Text = "Email:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(263, 260);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 82;
            this.metroLabel7.Text = "Função ou Cargo:";
            // 
            // CbbContatos
            // 
            this.CbbContatos.Enabled = false;
            this.CbbContatos.FormattingEnabled = true;
            this.CbbContatos.ItemHeight = 23;
            this.CbbContatos.Location = new System.Drawing.Point(116, 250);
            this.CbbContatos.Name = "CbbContatos";
            this.CbbContatos.Size = new System.Drawing.Size(138, 29);
            this.CbbContatos.TabIndex = 80;
            this.CbbContatos.UseSelectable = true;
            this.CbbContatos.Leave += new System.EventHandler(this.cbbContato_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Contatos:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 113;
            this.metroLabel5.Text = "Código:";
            // 
            // cbbTipoCalulo
            // 
            this.cbbTipoCalulo.Enabled = false;
            this.cbbTipoCalulo.FormattingEnabled = true;
            this.cbbTipoCalulo.ItemHeight = 23;
            this.cbbTipoCalulo.Location = new System.Drawing.Point(802, 195);
            this.cbbTipoCalulo.Name = "cbbTipoCalulo";
            this.cbbTipoCalulo.Size = new System.Drawing.Size(122, 29);
            this.cbbTipoCalulo.TabIndex = 112;
            this.cbbTipoCalulo.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(695, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 111;
            this.metroLabel4.Text = "Tipo de calculo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(491, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 109;
            this.metroLabel3.Text = "Insc Est.:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 204);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 108;
            this.metroLabel2.Text = "Nome:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(423, 152);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 106;
            this.metroLabel1.Text = "Razão Social:";
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.AutoSize = true;
            this.CPFCNPJ.Location = new System.Drawing.Point(169, 153);
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.Size = new System.Drawing.Size(72, 19);
            this.CPFCNPJ.TabIndex = 104;
            this.CPFCNPJ.Text = "CPF/CNPJ:";
            this.CPFCNPJ.Click += new System.EventHandler(this.CPFCNPJ_Click);
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(247, 151);
            this.txtCpfCnpj.Mask = "00.00.00.00.0000-00";
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(161, 20);
            this.txtCpfCnpj.TabIndex = 116;
            this.txtCpfCnpj.Leave += new System.EventHandler(this.txtCpfCnpj_Leave_1);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(515, 151);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(526, 20);
            this.txtRazaoSocial.TabIndex = 117;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(74, 204);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(413, 20);
            this.txtNome.TabIndex = 118;
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Enabled = false;
            this.txtInscEstadual.Location = new System.Drawing.Point(547, 204);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(142, 20);
            this.txtInscEstadual.TabIndex = 119;
            // 
            // txtFuncaoCargo
            // 
            this.txtFuncaoCargo.Enabled = false;
            this.txtFuncaoCargo.Location = new System.Drawing.Point(383, 259);
            this.txtFuncaoCargo.Name = "txtFuncaoCargo";
            this.txtFuncaoCargo.Size = new System.Drawing.Size(189, 20);
            this.txtFuncaoCargo.TabIndex = 120;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(628, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 122;
            // 
            // txtDatadeNascimento
            // 
            this.txtDatadeNascimento.Enabled = false;
            this.txtDatadeNascimento.Location = new System.Drawing.Point(902, 258);
            this.txtDatadeNascimento.Mask = "00/00/0000";
            this.txtDatadeNascimento.Name = "txtDatadeNascimento";
            this.txtDatadeNascimento.Size = new System.Drawing.Size(110, 20);
            this.txtDatadeNascimento.TabIndex = 123;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(772, 259);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(128, 19);
            this.metroLabel26.TabIndex = 124;
            this.metroLabel26.Text = "Data de nascimento:";
            // 
            // txtCepCobranca
            // 
            this.txtCepCobranca.Enabled = false;
            this.txtCepCobranca.Location = new System.Drawing.Point(65, 316);
            this.txtCepCobranca.Mask = "00000-000";
            this.txtCepCobranca.Name = "txtCepCobranca";
            this.txtCepCobranca.Size = new System.Drawing.Size(110, 20);
            this.txtCepCobranca.TabIndex = 125;
            this.txtCepCobranca.Leave += new System.EventHandler(this.txtCepCobranca_Leave);
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(493, 362);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(54, 19);
            this.metroLabel27.TabIndex = 126;
            this.metroLabel27.Text = "Celular:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(487, 496);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(54, 19);
            this.metroLabel17.TabIndex = 141;
            this.metroLabel17.Text = "Celular:";
            // 
            // txtCepEntrega
            // 
            this.txtCepEntrega.Enabled = false;
            this.txtCepEntrega.Location = new System.Drawing.Point(65, 444);
            this.txtCepEntrega.Mask = "00000-000";
            this.txtCepEntrega.Name = "txtCepEntrega";
            this.txtCepEntrega.Size = new System.Drawing.Size(110, 20);
            this.txtCepEntrega.TabIndex = 140;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(23, 445);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(36, 19);
            this.metroLabel18.TabIndex = 128;
            this.metroLabel18.Text = "CEP:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(273, 496);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(85, 19);
            this.metroLabel19.TabIndex = 137;
            this.metroLabel19.Text = "Telefone fixo:";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(14, 495);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(54, 19);
            this.metroLabel20.TabIndex = 135;
            this.metroLabel20.Text = "Cidade:";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(181, 444);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(67, 19);
            this.metroLabel21.TabIndex = 131;
            this.metroLabel21.Text = "Endereço:";
            // 
            // cbbEstadoEntrega
            // 
            this.cbbEstadoEntrega.Enabled = false;
            this.cbbEstadoEntrega.FormattingEnabled = true;
            this.cbbEstadoEntrega.ItemHeight = 23;
            this.cbbEstadoEntrega.Items.AddRange(new object[] {
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
            this.cbbEstadoEntrega.Location = new System.Drawing.Point(915, 433);
            this.cbbEstadoEntrega.Name = "cbbEstadoEntrega";
            this.cbbEstadoEntrega.Size = new System.Drawing.Size(90, 29);
            this.cbbEstadoEntrega.TabIndex = 129;
            this.cbbEstadoEntrega.UseSelectable = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(858, 443);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(51, 19);
            this.metroLabel22.TabIndex = 130;
            this.metroLabel22.Text = "Estado:";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(529, 445);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(48, 19);
            this.metroLabel23.TabIndex = 133;
            this.metroLabel23.Text = "Bairro:";
            // 
            // txtEnderecoCobranca
            // 
            this.txtEnderecoCobranca.Enabled = false;
            this.txtEnderecoCobranca.Location = new System.Drawing.Point(252, 317);
            this.txtEnderecoCobranca.Name = "txtEnderecoCobranca";
            this.txtEnderecoCobranca.Size = new System.Drawing.Size(320, 20);
            this.txtEnderecoCobranca.TabIndex = 142;
            // 
            // txtBairroCobranca
            // 
            this.txtBairroCobranca.Enabled = false;
            this.txtBairroCobranca.Location = new System.Drawing.Point(632, 316);
            this.txtBairroCobranca.Name = "txtBairroCobranca";
            this.txtBairroCobranca.Size = new System.Drawing.Size(269, 20);
            this.txtBairroCobranca.TabIndex = 143;
            // 
            // txtCidadeCobranca
            // 
            this.txtCidadeCobranca.Enabled = false;
            this.txtCidadeCobranca.Location = new System.Drawing.Point(74, 364);
            this.txtCidadeCobranca.Name = "txtCidadeCobranca";
            this.txtCidadeCobranca.Size = new System.Drawing.Size(199, 20);
            this.txtCidadeCobranca.TabIndex = 144;
            // 
            // txtEnderecoEntrega
            // 
            this.txtEnderecoEntrega.Enabled = false;
            this.txtEnderecoEntrega.Location = new System.Drawing.Point(254, 444);
            this.txtEnderecoEntrega.Name = "txtEnderecoEntrega";
            this.txtEnderecoEntrega.Size = new System.Drawing.Size(269, 20);
            this.txtEnderecoEntrega.TabIndex = 147;
            // 
            // txtBairroEntrega
            // 
            this.txtBairroEntrega.Enabled = false;
            this.txtBairroEntrega.Location = new System.Drawing.Point(583, 443);
            this.txtBairroEntrega.Name = "txtBairroEntrega";
            this.txtBairroEntrega.Size = new System.Drawing.Size(269, 20);
            this.txtBairroEntrega.TabIndex = 148;
            // 
            // txtCidadeEntrega
            // 
            this.txtCidadeEntrega.Enabled = false;
            this.txtCidadeEntrega.Location = new System.Drawing.Point(74, 495);
            this.txtCidadeEntrega.Name = "txtCidadeEntrega";
            this.txtCidadeEntrega.Size = new System.Drawing.Size(193, 20);
            this.txtCidadeEntrega.TabIndex = 149;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(74, 153);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(89, 20);
            this.txtCodigo.TabIndex = 152;
            // 
            // novocontatotxt
            // 
            this.novocontatotxt.Location = new System.Drawing.Point(116, 259);
            this.novocontatotxt.Name = "novocontatotxt";
            this.novocontatotxt.Size = new System.Drawing.Size(138, 20);
            this.novocontatotxt.TabIndex = 156;
            // 
            // novocontato
            // 
            this.novocontato.AutoSize = true;
            this.novocontato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novocontato.Location = new System.Drawing.Point(17, 263);
            this.novocontato.Name = "novocontato";
            this.novocontato.Size = new System.Drawing.Size(93, 16);
            this.novocontato.TabIndex = 157;
            this.novocontato.Text = "Novo Contato:";
            this.novocontato.Click += new System.EventHandler(this.novocontato_Click);
            // 
            // txtTelefoneFixoEntrega
            // 
            this.txtTelefoneFixoEntrega.Location = new System.Drawing.Point(364, 494);
            this.txtTelefoneFixoEntrega.Mask = "(00)0000-0000";
            this.txtTelefoneFixoEntrega.Name = "txtTelefoneFixoEntrega";
            this.txtTelefoneFixoEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneFixoEntrega.TabIndex = 158;
            // 
            // txtCelularEntreg
            // 
            this.txtCelularEntreg.Location = new System.Drawing.Point(547, 494);
            this.txtCelularEntreg.Mask = "(00)00000-0000";
            this.txtCelularEntreg.Name = "txtCelularEntreg";
            this.txtCelularEntreg.Size = new System.Drawing.Size(100, 20);
            this.txtCelularEntreg.TabIndex = 159;
            // 
            // txtCelularCobranca
            // 
            this.txtCelularCobranca.Location = new System.Drawing.Point(553, 361);
            this.txtCelularCobranca.Mask = "(00)00000-0000";
            this.txtCelularCobranca.Name = "txtCelularCobranca";
            this.txtCelularCobranca.Size = new System.Drawing.Size(100, 20);
            this.txtCelularCobranca.TabIndex = 160;
            // 
            // txtTelefoneFixoCobranca
            // 
            this.txtTelefoneFixoCobranca.Location = new System.Drawing.Point(370, 361);
            this.txtTelefoneFixoCobranca.Mask = "(00)0000-0000";
            this.txtTelefoneFixoCobranca.Name = "txtTelefoneFixoCobranca";
            this.txtTelefoneFixoCobranca.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneFixoCobranca.TabIndex = 161;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Location = new System.Drawing.Point(20, 282);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(62, 23);
            this.btnNovoCadastro.TabIndex = 162;
            this.btnNovoCadastro.Text = "Salvar contato";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 550);
            this.Controls.Add(this.btnNovoCadastro);
            this.Controls.Add(this.txtTelefoneFixoCobranca);
            this.Controls.Add(this.txtCelularCobranca);
            this.Controls.Add(this.txtCelularEntreg);
            this.Controls.Add(this.txtTelefoneFixoEntrega);
            this.Controls.Add(this.novocontato);
            this.Controls.Add(this.novocontatotxt);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCidadeEntrega);
            this.Controls.Add(this.txtBairroEntrega);
            this.Controls.Add(this.txtEnderecoEntrega);
            this.Controls.Add(this.txtCidadeCobranca);
            this.Controls.Add(this.txtBairroCobranca);
            this.Controls.Add(this.txtEnderecoCobranca);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.txtCepEntrega);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.cbbEstadoEntrega);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.metroLabel23);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.txtCepCobranca);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.txtDatadeNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFuncaoCargo);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbbTipoCalulo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CPFCNPJ);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.CbbContatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.cbbEstadoCobranca);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadClientes";
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.CadClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroComboBox cbbEstadoCobranca;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.CheckBox checkBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox CbbContatos;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbbTipoCalulo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel CPFCNPJ;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.TextBox txtFuncaoCargo;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDatadeNascimento;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private System.Windows.Forms.MaskedTextBox txtCepCobranca;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.MaskedTextBox txtCepEntrega;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroComboBox cbbEstadoEntrega;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private System.Windows.Forms.TextBox txtEnderecoCobranca;
        private System.Windows.Forms.TextBox txtBairroCobranca;
        private System.Windows.Forms.TextBox txtCidadeCobranca;
        private System.Windows.Forms.TextBox txtEnderecoEntrega;
        private System.Windows.Forms.TextBox txtBairroEntrega;
        private System.Windows.Forms.TextBox txtCidadeEntrega;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.TextBox novocontatotxt;
        private System.Windows.Forms.Label novocontato;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixoEntrega;
        private System.Windows.Forms.MaskedTextBox txtCelularEntreg;
        private System.Windows.Forms.MaskedTextBox txtCelularCobranca;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixoCobranca;
        private System.Windows.Forms.Button btnNovoCadastro;
    }
}