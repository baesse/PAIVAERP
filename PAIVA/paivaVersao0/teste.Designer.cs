namespace paivaVersao0
{
    partial class frmPgFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GRIDFUNCIONARIOPAGAR = new MetroFramework.Controls.MetroGrid();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valordevido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorapagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datadopagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDFUNCIONARIOPAGAR)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRIDFUNCIONARIOPAGAR
            // 
            this.GRIDFUNCIONARIOPAGAR.AllowUserToResizeRows = false;
            this.GRIDFUNCIONARIOPAGAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDFUNCIONARIOPAGAR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRIDFUNCIONARIOPAGAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRIDFUNCIONARIOPAGAR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRIDFUNCIONARIOPAGAR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRIDFUNCIONARIOPAGAR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDFUNCIONARIOPAGAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDFUNCIONARIOPAGAR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Column1,
            this.Descricao,
            this.Referencia,
            this.Categoria,
            this.Valordevido,
            this.Valorapagar,
            this.Datadopagamento});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRIDFUNCIONARIOPAGAR.DefaultCellStyle = dataGridViewCellStyle5;
            this.GRIDFUNCIONARIOPAGAR.EnableHeadersVisualStyles = false;
            this.GRIDFUNCIONARIOPAGAR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GRIDFUNCIONARIOPAGAR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRIDFUNCIONARIOPAGAR.Location = new System.Drawing.Point(23, 63);
            this.GRIDFUNCIONARIOPAGAR.Name = "GRIDFUNCIONARIOPAGAR";
            this.GRIDFUNCIONARIOPAGAR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRIDFUNCIONARIOPAGAR.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GRIDFUNCIONARIOPAGAR.RowHeadersVisible = false;
            this.GRIDFUNCIONARIOPAGAR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRIDFUNCIONARIOPAGAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRIDFUNCIONARIOPAGAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRIDFUNCIONARIOPAGAR.Size = new System.Drawing.Size(958, 365);
            this.GRIDFUNCIONARIOPAGAR.TabIndex = 10;
            this.GRIDFUNCIONARIOPAGAR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDFUNCIONARIOPAGAR_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nomeFornecedor";
            this.Column1.HeaderText = "Nome do funcionario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descricaoLancamento";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Valordevido
            // 
            this.Valordevido.DataPropertyName = "valor";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valordevido.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valordevido.HeaderText = "Valor devido";
            this.Valordevido.Name = "Valordevido";
            this.Valordevido.ReadOnly = true;
            // 
            // Valorapagar
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valorapagar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valorapagar.HeaderText = "Valor a pagar";
            this.Valorapagar.Name = "Valorapagar";
            // 
            // Datadopagamento
            // 
            this.Datadopagamento.DataPropertyName = "datapagamento";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Datadopagamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.Datadopagamento.HeaderText = "Data do pagamento";
            this.Datadopagamento.Name = "Datadopagamento";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.metroButton3);
            this.groupBox4.Controls.Add(this.metroButton2);
            this.groupBox4.Controls.Add(this.lblvalortotal);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.metroComboBox1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(23, 431);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(958, 113);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(608, 43);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(102, 23);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Pagar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(482, 42);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 23);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Calcular Total";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalortotal.ForeColor = System.Drawing.Color.Black;
            this.lblvalortotal.Location = new System.Drawing.Point(400, 50);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(36, 16);
            this.lblvalortotal.TabIndex = 5;
            this.lblvalortotal.Text = "0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(377, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Valor total a pagar";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(141, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(138, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Alterar a data de todos os pagamentos";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(9, 42);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Conta";
            // 
            // frmPgFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 564);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GRIDFUNCIONARIOPAGAR);
            this.Name = "frmPgFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagamento de funcionarios";
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDFUNCIONARIOPAGAR)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GRIDFUNCIONARIOPAGAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valordevido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorapagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datadopagamento;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label lblvalortotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label11;
    }
}