namespace paivaVersao0
{
    partial class frmcontrole
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novo_Usuario = new System.Windows.Forms.GroupBox();
            this.txtNomeUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValidaSenha = new MetroFramework.Controls.MetroTextBox();
            this.cbbTipoAcesso = new MetroFramework.Controls.MetroComboBox();
            this.menuStrip1.SuspendLayout();
            this.novo_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuarioToolStripMenuItem,
            this.alterarValoresToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // novoUsuarioToolStripMenuItem
            // 
            this.novoUsuarioToolStripMenuItem.Name = "novoUsuarioToolStripMenuItem";
            this.novoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoUsuarioToolStripMenuItem.Text = "Novo usuario";
            this.novoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuarioToolStripMenuItem_Click);
            // 
            // alterarValoresToolStripMenuItem
            // 
            this.alterarValoresToolStripMenuItem.Name = "alterarValoresToolStripMenuItem";
            this.alterarValoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarValoresToolStripMenuItem.Text = "Alterar valores";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // novo_Usuario
            // 
            this.novo_Usuario.Controls.Add(this.cbbTipoAcesso);
            this.novo_Usuario.Controls.Add(this.txtValidaSenha);
            this.novo_Usuario.Controls.Add(this.label4);
            this.novo_Usuario.Controls.Add(this.button1);
            this.novo_Usuario.Controls.Add(this.label3);
            this.novo_Usuario.Controls.Add(this.label2);
            this.novo_Usuario.Controls.Add(this.label1);
            this.novo_Usuario.Controls.Add(this.txtSenha);
            this.novo_Usuario.Controls.Add(this.txtNomeUsuario);
            this.novo_Usuario.Location = new System.Drawing.Point(22, 104);
            this.novo_Usuario.Name = "novo_Usuario";
            this.novo_Usuario.Size = new System.Drawing.Size(297, 336);
            this.novo_Usuario.TabIndex = 2;
            this.novo_Usuario.TabStop = false;
            this.novo_Usuario.Text = "Novo Usuario";
            // 
            // txtNomeUsuario
            // 
            // 
            // 
            // 
            this.txtNomeUsuario.CustomButton.Image = null;
            this.txtNomeUsuario.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtNomeUsuario.CustomButton.Name = "";
            this.txtNomeUsuario.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeUsuario.CustomButton.TabIndex = 1;
            this.txtNomeUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeUsuario.CustomButton.UseSelectable = true;
            this.txtNomeUsuario.CustomButton.Visible = false;
            this.txtNomeUsuario.Lines = new string[0];
            this.txtNomeUsuario.Location = new System.Drawing.Point(121, 19);
            this.txtNomeUsuario.MaxLength = 32767;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.SelectionLength = 0;
            this.txtNomeUsuario.SelectionStart = 0;
            this.txtNomeUsuario.ShortcutsEnabled = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(159, 29);
            this.txtNomeUsuario.TabIndex = 0;
            this.txtNomeUsuario.UseSelectable = true;
            this.txtNomeUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeUsuario.Leave += new System.EventHandler(this.txtNomeUsuario_Leave);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(121, 75);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(159, 29);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Acesso:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir Senha:";
            // 
            // txtValidaSenha
            // 
            // 
            // 
            // 
            this.txtValidaSenha.CustomButton.Image = null;
            this.txtValidaSenha.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtValidaSenha.CustomButton.Name = "";
            this.txtValidaSenha.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtValidaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValidaSenha.CustomButton.TabIndex = 1;
            this.txtValidaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValidaSenha.CustomButton.UseSelectable = true;
            this.txtValidaSenha.CustomButton.Visible = false;
            this.txtValidaSenha.Lines = new string[0];
            this.txtValidaSenha.Location = new System.Drawing.Point(121, 131);
            this.txtValidaSenha.MaxLength = 32767;
            this.txtValidaSenha.Name = "txtValidaSenha";
            this.txtValidaSenha.PasswordChar = '\0';
            this.txtValidaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValidaSenha.SelectedText = "";
            this.txtValidaSenha.SelectionLength = 0;
            this.txtValidaSenha.SelectionStart = 0;
            this.txtValidaSenha.ShortcutsEnabled = true;
            this.txtValidaSenha.Size = new System.Drawing.Size(159, 29);
            this.txtValidaSenha.TabIndex = 8;
            this.txtValidaSenha.UseSelectable = true;
            this.txtValidaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValidaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbTipoAcesso
            // 
            this.cbbTipoAcesso.FormattingEnabled = true;
            this.cbbTipoAcesso.ItemHeight = 23;
            this.cbbTipoAcesso.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbbTipoAcesso.Location = new System.Drawing.Point(122, 189);
            this.cbbTipoAcesso.Name = "cbbTipoAcesso";
            this.cbbTipoAcesso.Size = new System.Drawing.Size(158, 29);
            this.cbbTipoAcesso.TabIndex = 9;
            this.cbbTipoAcesso.UseSelectable = true;
            // 
            // frmcontrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 576);
            this.Controls.Add(this.novo_Usuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmcontrole";
            this.Text = "Gerente do sistema";
            this.Load += new System.EventHandler(this.frmcontrole_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.novo_Usuario.ResumeLayout(false);
            this.novo_Usuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarValoresToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox novo_Usuario;
        private MetroFramework.Controls.MetroComboBox cbbTipoAcesso;
        private MetroFramework.Controls.MetroTextBox txtValidaSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtNomeUsuario;
    }
}