namespace paivaVersao0
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Menu = new MetroFramework.Controls.MetroTile();
            this.barrainfo = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.abrecontrole = new MetroFramework.Controls.MetroTile();
            this.abreagenda = new MetroFramework.Controls.MetroTile();
            this.abrecontrolefinanceiro = new MetroFramework.Controls.MetroTile();
            this.abrecontrolepedidos = new MetroFramework.Controls.MetroTile();
            this.abreralatorio = new MetroFramework.Controls.MetroTile();
            this.novopedido = new MetroFramework.Controls.MetroTile();
            this.abrecadastro = new MetroFramework.Controls.MetroTile();
            this.alertanotificacao = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1429, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            // 
            // Menu
            // 
            this.Menu.ActiveControl = null;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu.Location = new System.Drawing.Point(20, 60);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1223, 55);
            this.Menu.TabIndex = 48;
            this.Menu.Text = "Menu Principal";
            this.Menu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Menu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Menu.UseCustomBackColor = true;
            this.Menu.UseCustomForeColor = true;
            this.Menu.UseSelectable = true;
            this.Menu.UseStyleColors = true;
            this.Menu.UseTileImage = true;
            this.Menu.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // barrainfo
            // 
            this.barrainfo.ActiveControl = null;
            this.barrainfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barrainfo.ForeColor = System.Drawing.SystemColors.Control;
            this.barrainfo.Location = new System.Drawing.Point(20, 567);
            this.barrainfo.Name = "barrainfo";
            this.barrainfo.Size = new System.Drawing.Size(1223, 55);
            this.barrainfo.TabIndex = 51;
            this.barrainfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.barrainfo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.barrainfo.UseCustomBackColor = true;
            this.barrainfo.UseCustomForeColor = true;
            this.barrainfo.UseSelectable = true;
            this.barrainfo.UseStyleColors = true;
            this.barrainfo.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(937, 471);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(207, 140);
            this.metroTile2.TabIndex = 57;
            this.metroTile2.Text = "Lembrete";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::paivaVersao0.Properties.Resources.circular_clock;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(518, 471);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(205, 140);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile1.TabIndex = 56;
            this.metroTile1.Text = "Comercial";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::paivaVersao0.Properties.Resources.business_affiliate_network;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // abrecontrole
            // 
            this.abrecontrole.ActiveControl = null;
            this.abrecontrole.Location = new System.Drawing.Point(516, 298);
            this.abrecontrole.Name = "abrecontrole";
            this.abrecontrole.Size = new System.Drawing.Size(207, 141);
            this.abrecontrole.Style = MetroFramework.MetroColorStyle.Purple;
            this.abrecontrole.TabIndex = 55;
            this.abrecontrole.Text = "Controle";
            this.abrecontrole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abrecontrole.TileImage = global::paivaVersao0.Properties.Resources.management;
            this.abrecontrole.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abrecontrole.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.abrecontrole.UseSelectable = true;
            this.abrecontrole.UseTileImage = true;
            this.abrecontrole.Click += new System.EventHandler(this.abrecontrole_Click);
            this.abrecontrole.MouseLeave += new System.EventHandler(this.metroTile2_MouseLeave);
            this.abrecontrole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile2_MouseMove);
            // 
            // abreagenda
            // 
            this.abreagenda.ActiveControl = null;
            this.abreagenda.Location = new System.Drawing.Point(123, 470);
            this.abreagenda.Name = "abreagenda";
            this.abreagenda.Size = new System.Drawing.Size(207, 141);
            this.abreagenda.Style = MetroFramework.MetroColorStyle.Brown;
            this.abreagenda.TabIndex = 54;
            this.abreagenda.Text = "Mapa diario";
            this.abreagenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abreagenda.TileImage = global::paivaVersao0.Properties.Resources.contract;
            this.abreagenda.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abreagenda.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.abreagenda.UseSelectable = true;
            this.abreagenda.UseTileImage = true;
            this.abreagenda.Click += new System.EventHandler(this.abreagenda_Click);
            this.abreagenda.MouseLeave += new System.EventHandler(this.metroTile5_MouseLeave);
            this.abreagenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile5_MouseMove);
            // 
            // abrecontrolefinanceiro
            // 
            this.abrecontrolefinanceiro.ActiveControl = null;
            this.abrecontrolefinanceiro.Location = new System.Drawing.Point(937, 298);
            this.abrecontrolefinanceiro.Name = "abrecontrolefinanceiro";
            this.abrecontrolefinanceiro.Size = new System.Drawing.Size(207, 141);
            this.abrecontrolefinanceiro.Style = MetroFramework.MetroColorStyle.Red;
            this.abrecontrolefinanceiro.TabIndex = 53;
            this.abrecontrolefinanceiro.Text = "Controle financeiro";
            this.abrecontrolefinanceiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abrecontrolefinanceiro.TileImage = global::paivaVersao0.Properties.Resources.increasing_chart;
            this.abrecontrolefinanceiro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abrecontrolefinanceiro.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.abrecontrolefinanceiro.UseSelectable = true;
            this.abrecontrolefinanceiro.UseTileImage = true;
            this.abrecontrolefinanceiro.Click += new System.EventHandler(this.abrecontrolefinanceiro_Click);
            this.abrecontrolefinanceiro.MouseLeave += new System.EventHandler(this.metroTile4_MouseLeave);
            this.abrecontrolefinanceiro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile4_MouseMove);
            // 
            // abrecontrolepedidos
            // 
            this.abrecontrolepedidos.ActiveControl = null;
            this.abrecontrolepedidos.Location = new System.Drawing.Point(937, 121);
            this.abrecontrolepedidos.Name = "abrecontrolepedidos";
            this.abrecontrolepedidos.Size = new System.Drawing.Size(207, 141);
            this.abrecontrolepedidos.Style = MetroFramework.MetroColorStyle.Lime;
            this.abrecontrolepedidos.TabIndex = 52;
            this.abrecontrolepedidos.Text = "Controle de pedidos";
            this.abrecontrolepedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abrecontrolepedidos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.abrecontrolepedidos.TileImage = global::paivaVersao0.Properties.Resources.approve_invoice__1_;
            this.abrecontrolepedidos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abrecontrolepedidos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.abrecontrolepedidos.UseSelectable = true;
            this.abrecontrolepedidos.UseTileImage = true;
            this.abrecontrolepedidos.Click += new System.EventHandler(this.abrecontrolepedidos_Click);
            this.abrecontrolepedidos.Enter += new System.EventHandler(this.abrecontrolepedidos_Enter);
            this.abrecontrolepedidos.MouseLeave += new System.EventHandler(this.Agenda_MouseLeave);
            this.abrecontrolepedidos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Agenda_MouseMove);
            // 
            // abreralatorio
            // 
            this.abreralatorio.ActiveControl = null;
            this.abreralatorio.Location = new System.Drawing.Point(123, 298);
            this.abreralatorio.Name = "abreralatorio";
            this.abreralatorio.Size = new System.Drawing.Size(207, 141);
            this.abreralatorio.Style = MetroFramework.MetroColorStyle.Green;
            this.abreralatorio.TabIndex = 50;
            this.abreralatorio.Text = "Relatórios";
            this.abreralatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abreralatorio.TileImage = global::paivaVersao0.Properties.Resources.business_presentation__1_;
            this.abreralatorio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abreralatorio.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.abreralatorio.UseSelectable = true;
            this.abreralatorio.UseTileImage = true;
            this.abreralatorio.Click += new System.EventHandler(this.metroTile3_Click);
            this.abreralatorio.MouseLeave += new System.EventHandler(this.metroTile3_MouseLeave);
            this.abreralatorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile3_MouseMove);
            // 
            // novopedido
            // 
            this.novopedido.ActiveControl = null;
            this.novopedido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.novopedido.Location = new System.Drawing.Point(516, 121);
            this.novopedido.Name = "novopedido";
            this.novopedido.Size = new System.Drawing.Size(207, 141);
            this.novopedido.Style = MetroFramework.MetroColorStyle.Teal;
            this.novopedido.TabIndex = 46;
            this.novopedido.Text = "Novo pedido";
            this.novopedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.novopedido.TileImage = global::paivaVersao0.Properties.Resources.approve_invoice;
            this.novopedido.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.novopedido.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.novopedido.UseSelectable = true;
            this.novopedido.UseTileImage = true;
            this.novopedido.Click += new System.EventHandler(this.novopedido_Click);
            this.novopedido.MouseLeave += new System.EventHandler(this.novopedido_MouseLeave);
            this.novopedido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.novopedido_MouseMove);
            // 
            // abrecadastro
            // 
            this.abrecadastro.ActiveControl = null;
            this.abrecadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.abrecadastro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.abrecadastro.ForeColor = System.Drawing.Color.Black;
            this.abrecadastro.Location = new System.Drawing.Point(123, 121);
            this.abrecadastro.Name = "abrecadastro";
            this.abrecadastro.Size = new System.Drawing.Size(207, 141);
            this.abrecadastro.Style = MetroFramework.MetroColorStyle.Orange;
            this.abrecadastro.TabIndex = 45;
            this.abrecadastro.Text = "Novo cadastro";
            this.abrecadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abrecadastro.TileImage = global::paivaVersao0.Properties.Resources.id_card__1_;
            this.abrecadastro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abrecadastro.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.abrecadastro.UseCustomBackColor = true;
            this.abrecadastro.UseSelectable = true;
            this.abrecadastro.UseTileImage = true;
            this.abrecadastro.UseWaitCursor = true;
            this.abrecadastro.Click += new System.EventHandler(this.abrecadastro_Click);
            this.abrecadastro.MouseLeave += new System.EventHandler(this.abrecadastro_MouseLeave);
            this.abrecadastro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.abrecadastro_MouseMove);
            // 
            // alertanotificacao
            // 
            this.alertanotificacao.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 51);
            this.button1.TabIndex = 58;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.abrecontrole);
            this.Controls.Add(this.abreagenda);
            this.Controls.Add(this.abrecontrolefinanceiro);
            this.Controls.Add(this.abrecontrolepedidos);
            this.Controls.Add(this.barrainfo);
            this.Controls.Add(this.abreralatorio);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.novopedido);
            this.Controls.Add(this.abrecadastro);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTile abrecadastro;
        private MetroFramework.Controls.MetroTile novopedido;
        private MetroFramework.Controls.MetroTile Menu;
        private MetroFramework.Controls.MetroTile abreralatorio;
        private MetroFramework.Controls.MetroTile barrainfo;
        private MetroFramework.Controls.MetroTile abrecontrolepedidos;
        private MetroFramework.Controls.MetroTile abrecontrolefinanceiro;
        private MetroFramework.Controls.MetroTile abreagenda;
        private MetroFramework.Controls.MetroTile abrecontrole;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.Timer alertanotificacao;
        private System.Windows.Forms.Button button1;
    }
}

