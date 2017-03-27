namespace paivaVersao0
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbusuario = new MetroFramework.Controls.MetroComboBox();
            this.txtsenha = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(200, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(190, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // cbbusuario
            // 
            this.cbbusuario.FormattingEnabled = true;
            this.cbbusuario.ItemHeight = 23;
            this.cbbusuario.Location = new System.Drawing.Point(263, 55);
            this.cbbusuario.Name = "cbbusuario";
            this.cbbusuario.Size = new System.Drawing.Size(316, 29);
            this.cbbusuario.TabIndex = 14;
            this.cbbusuario.UseSelectable = true;
            // 
            // txtsenha
            // 
            // 
            // 
            // 
            this.txtsenha.CustomButton.Image = null;
            this.txtsenha.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txtsenha.CustomButton.Name = "";
            this.txtsenha.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtsenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsenha.CustomButton.TabIndex = 1;
            this.txtsenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsenha.CustomButton.UseSelectable = true;
            this.txtsenha.CustomButton.Visible = false;
            this.txtsenha.Lines = new string[0];
            this.txtsenha.Location = new System.Drawing.Point(264, 97);
            this.txtsenha.MaxLength = 32767;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsenha.SelectedText = "";
            this.txtsenha.SelectionLength = 0;
            this.txtsenha.SelectionStart = 0;
            this.txtsenha.ShortcutsEnabled = true;
            this.txtsenha.Size = new System.Drawing.Size(313, 29);
            this.txtsenha.TabIndex = 15;
            this.txtsenha.UseSelectable = true;
            this.txtsenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(294, 158);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 44);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Entrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(428, 158);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(92, 44);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Sair";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 271);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.cbbusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Opacity = 0.8D;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbbusuario;
        private MetroFramework.Controls.MetroTextBox txtsenha;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}