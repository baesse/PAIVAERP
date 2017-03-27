namespace paivaVersao0
{
    partial class frmcontrolepedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontrolepedidos));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoPedido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbclientes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtRazaoSocial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbbEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtcpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnBuscaCodigo = new MetroFramework.Controls.MetroTile();
            this.cadpedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.txtNomeCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TABELA = new MetroFramework.Controls.MetroGrid();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atenderpedido = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cadpedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Código do pedido:";
            // 
            // txtCodigoPedido
            // 
            // 
            // 
            // 
            this.txtCodigoPedido.CustomButton.Image = null;
            this.txtCodigoPedido.CustomButton.Location = new System.Drawing.Point(35, 1);
            this.txtCodigoPedido.CustomButton.Name = "";
            this.txtCodigoPedido.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCodigoPedido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoPedido.CustomButton.TabIndex = 1;
            this.txtCodigoPedido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoPedido.CustomButton.UseSelectable = true;
            this.txtCodigoPedido.CustomButton.Visible = false;
            this.txtCodigoPedido.Lines = new string[0];
            this.txtCodigoPedido.Location = new System.Drawing.Point(151, 115);
            this.txtCodigoPedido.MaxLength = 32767;
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.PasswordChar = '\0';
            this.txtCodigoPedido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoPedido.SelectedText = "";
            this.txtCodigoPedido.SelectionLength = 0;
            this.txtCodigoPedido.SelectionStart = 0;
            this.txtCodigoPedido.ShortcutsEnabled = true;
            this.txtCodigoPedido.Size = new System.Drawing.Size(63, 29);
            this.txtCodigoPedido.TabIndex = 1;
            this.txtCodigoPedido.UseSelectable = true;
            this.txtCodigoPedido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoPedido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(272, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Nome do cliente:";
            // 
            // cbbclientes
            // 
            this.cbbclientes.FormattingEnabled = true;
            this.cbbclientes.ItemHeight = 23;
            this.cbbclientes.Location = new System.Drawing.Point(388, 115);
            this.cbbclientes.Name = "cbbclientes";
            this.cbbclientes.Size = new System.Drawing.Size(334, 29);
            this.cbbclientes.TabIndex = 5;
            this.cbbclientes.UseSelectable = true;
            this.cbbclientes.SelectedIndexChanged += new System.EventHandler(this.cbbclientes_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 177);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Razão Social:";
            // 
            // txtRazaoSocial
            // 
            // 
            // 
            // 
            this.txtRazaoSocial.CustomButton.Image = null;
            this.txtRazaoSocial.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtRazaoSocial.CustomButton.Name = "";
            this.txtRazaoSocial.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRazaoSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazaoSocial.CustomButton.TabIndex = 1;
            this.txtRazaoSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRazaoSocial.CustomButton.UseSelectable = true;
            this.txtRazaoSocial.CustomButton.Visible = false;
            this.txtRazaoSocial.Lines = new string[0];
            this.txtRazaoSocial.Location = new System.Drawing.Point(128, 167);
            this.txtRazaoSocial.MaxLength = 32767;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.PasswordChar = '\0';
            this.txtRazaoSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazaoSocial.SelectedText = "";
            this.txtRazaoSocial.SelectionLength = 0;
            this.txtRazaoSocial.SelectionStart = 0;
            this.txtRazaoSocial.ShortcutsEnabled = true;
            this.txtRazaoSocial.Size = new System.Drawing.Size(245, 29);
            this.txtRazaoSocial.TabIndex = 7;
            this.txtRazaoSocial.UseSelectable = true;
            this.txtRazaoSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRazaoSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 234);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Cidade:";
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(96, 224);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(245, 29);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(504, 234);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Estado:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.ItemHeight = 23;
            this.cbbEstado.Items.AddRange(new object[] {
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
            this.cbbEstado.Location = new System.Drawing.Point(561, 224);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(76, 29);
            this.cbbEstado.TabIndex = 14;
            this.cbbEstado.UseSelectable = true;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // txtcpfcnpj
            // 
            this.txtcpfcnpj.Location = new System.Drawing.Point(504, 173);
            this.txtcpfcnpj.Mask = "000.000.000-00";
            this.txtcpfcnpj.Name = "txtcpfcnpj";
            this.txtcpfcnpj.Size = new System.Drawing.Size(114, 20);
            this.txtcpfcnpj.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "CPF/CNPJ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(347, 224);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(55, 32);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile3.TabIndex = 19;
            this.metroTile3.TileImage = global::paivaVersao0.Properties.Resources.document__1_3;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(624, 173);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(40, 29);
            this.metroTile2.TabIndex = 16;
            this.metroTile2.TileImage = global::paivaVersao0.Properties.Resources.document__1_2;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(379, 165);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(51, 31);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.TileImage = global::paivaVersao0.Properties.Resources.document__1_1;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnBuscaCodigo
            // 
            this.btnBuscaCodigo.ActiveControl = null;
            this.btnBuscaCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscaCodigo.Location = new System.Drawing.Point(220, 115);
            this.btnBuscaCodigo.Name = "btnBuscaCodigo";
            this.btnBuscaCodigo.Size = new System.Drawing.Size(46, 29);
            this.btnBuscaCodigo.Style = MetroFramework.MetroColorStyle.White;
            this.btnBuscaCodigo.TabIndex = 2;
            this.btnBuscaCodigo.TileImage = global::paivaVersao0.Properties.Resources.document__1_1;
            this.btnBuscaCodigo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscaCodigo.UseSelectable = true;
            this.btnBuscaCodigo.UseTileImage = true;
            this.btnBuscaCodigo.Click += new System.EventHandler(this.btnBuscaCodigo_Click);
            // 
            // cadpedidoBindingSource
            // 
            this.cadpedidoBindingSource.DataMember = "cadpedido";
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(1079, 115);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(51, 31);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile4.TabIndex = 23;
            this.metroTile4.TileImage = global::paivaVersao0.Properties.Resources.document__1_1;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // txtNomeCliente
            // 
            // 
            // 
            // 
            this.txtNomeCliente.CustomButton.Image = null;
            this.txtNomeCliente.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtNomeCliente.CustomButton.Name = "";
            this.txtNomeCliente.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeCliente.CustomButton.TabIndex = 1;
            this.txtNomeCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeCliente.CustomButton.UseSelectable = true;
            this.txtNomeCliente.CustomButton.Visible = false;
            this.txtNomeCliente.Lines = new string[0];
            this.txtNomeCliente.Location = new System.Drawing.Point(828, 115);
            this.txtNomeCliente.MaxLength = 32767;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PasswordChar = '\0';
            this.txtNomeCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeCliente.SelectedText = "";
            this.txtNomeCliente.SelectionLength = 0;
            this.txtNomeCliente.SelectionStart = 0;
            this.txtNomeCliente.ShortcutsEnabled = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(245, 29);
            this.txtNomeCliente.TabIndex = 22;
            this.txtNomeCliente.UseSelectable = true;
            this.txtNomeCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeCliente.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(736, 125);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Razão Social:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // TABELA
            // 
            this.TABELA.AllowUserToResizeRows = false;
            this.TABELA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABELA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TABELA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TABELA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TABELA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABELA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TABELA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABELA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nomecliente,
            this.razaosocial,
            this.datapedido,
            this.urgencia,
            this.solicitante,
            this.Atenderpedido});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TABELA.DefaultCellStyle = dataGridViewCellStyle3;
            this.TABELA.EnableHeadersVisualStyles = false;
            this.TABELA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TABELA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TABELA.Location = new System.Drawing.Point(14, 276);
            this.TABELA.Name = "TABELA";
            this.TABELA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABELA.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TABELA.RowHeadersVisible = false;
            this.TABELA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TABELA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABELA.Size = new System.Drawing.Size(1168, 361);
            this.TABELA.TabIndex = 24;
            this.TABELA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABELA_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo do pedido";
            this.Codigo.Name = "Codigo";
            // 
            // nomecliente
            // 
            this.nomecliente.DataPropertyName = "nomecliente";
            this.nomecliente.HeaderText = "Nome do cliente";
            this.nomecliente.Name = "nomecliente";
            // 
            // razaosocial
            // 
            this.razaosocial.DataPropertyName = "razaosocial";
            this.razaosocial.HeaderText = "Razão social";
            this.razaosocial.Name = "razaosocial";
            // 
            // datapedido
            // 
            this.datapedido.DataPropertyName = "datapedido";
            this.datapedido.HeaderText = "Data do pedido";
            this.datapedido.Name = "datapedido";
            // 
            // urgencia
            // 
            this.urgencia.DataPropertyName = "urgencia";
            this.urgencia.HeaderText = "Urgencia";
            this.urgencia.Name = "urgencia";
            // 
            // solicitante
            // 
            this.solicitante.DataPropertyName = "solicitante";
            this.solicitante.HeaderText = "Solicitante";
            this.solicitante.Name = "solicitante";
            // 
            // Atenderpedido
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = "Abrir formulario de resposta";
            this.Atenderpedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.Atenderpedido.HeaderText = "Atender Pedido";
            this.Atenderpedido.Name = "Atenderpedido";
            this.Atenderpedido.Text = "Abrir";
            this.Atenderpedido.ToolTipText = "ads";
            // 
            // frmcontrolepedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 652);
            this.Controls.Add(this.TABELA);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcpfcnpj);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbbclientes);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnBuscaCodigo);
            this.Controls.Add(this.txtCodigoPedido);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcontrolepedidos";
            this.Text = "Buscar Pedidos";
            this.Load += new System.EventHandler(this.frmcontrolepedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadpedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABELA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCodigoPedido;
      
        private System.Windows.Forms.BindingSource cadpedidoBindingSource;
      
        private MetroFramework.Controls.MetroTile btnBuscaCodigo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbbclientes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtRazaoSocial;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbbEstado;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.MaskedTextBox txtcpfcnpj;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTextBox txtNomeCliente;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid TABELA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitante;
        private System.Windows.Forms.DataGridViewButtonColumn Atenderpedido;
    }
}