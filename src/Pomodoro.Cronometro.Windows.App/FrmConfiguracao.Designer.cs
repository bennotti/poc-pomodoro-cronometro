namespace Pomodoro.Cronometro.Windows.App
{
    partial class FrmConfiguracao
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
            this.btnSalvarFechar = new System.Windows.Forms.Button();
            this.btnCancelarFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConclusao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTempoPomodoro = new System.Windows.Forms.ComboBox();
            this.cbxTempoParadaCurta = new System.Windows.Forms.ComboBox();
            this.cbxTempoParadaLonga = new System.Windows.Forms.ComboBox();
            this.txtTempoPomodoro = new System.Windows.Forms.NumericUpDown();
            this.txtTempoParadaCurta = new System.Windows.Forms.NumericUpDown();
            this.txtTempoParadaLonga = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoPomodoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoParadaCurta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoParadaLonga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarFechar
            // 
            this.btnSalvarFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarFechar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFechar.Location = new System.Drawing.Point(283, 167);
            this.btnSalvarFechar.Name = "btnSalvarFechar";
            this.btnSalvarFechar.Size = new System.Drawing.Size(116, 23);
            this.btnSalvarFechar.TabIndex = 15;
            this.btnSalvarFechar.Text = "Salvar e fechar";
            this.btnSalvarFechar.UseVisualStyleBackColor = true;
            this.btnSalvarFechar.Click += new System.EventHandler(this.btnSalvarFechar_Click);
            // 
            // btnCancelarFechar
            // 
            this.btnCancelarFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFechar.Location = new System.Drawing.Point(12, 167);
            this.btnCancelarFechar.Name = "btnCancelarFechar";
            this.btnCancelarFechar.Size = new System.Drawing.Size(116, 23);
            this.btnCancelarFechar.TabIndex = 16;
            this.btnCancelarFechar.Text = "Cancelar e fechar";
            this.btnCancelarFechar.UseVisualStyleBackColor = true;
            this.btnCancelarFechar.Click += new System.EventHandler(this.btnCancelarFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtConclusao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 149);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txtConclusao
            // 
            this.txtConclusao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConclusao.Location = new System.Drawing.Point(133, 117);
            this.txtConclusao.Name = "txtConclusao";
            this.txtConclusao.Size = new System.Drawing.Size(248, 23);
            this.txtConclusao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frase conclusão";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxTempoPomodoro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxTempoParadaCurta, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxTempoParadaLonga, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTempoPomodoro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTempoParadaCurta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTempoParadaLonga, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo pomodoro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo parada curta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo parada longa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxTempoPomodoro
            // 
            this.cbxTempoPomodoro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempoPomodoro.FormattingEnabled = true;
            this.cbxTempoPomodoro.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbxTempoPomodoro.Location = new System.Drawing.Point(257, 3);
            this.cbxTempoPomodoro.Name = "cbxTempoPomodoro";
            this.cbxTempoPomodoro.Size = new System.Drawing.Size(121, 23);
            this.cbxTempoPomodoro.TabIndex = 6;
            this.cbxTempoPomodoro.SelectedIndexChanged += new System.EventHandler(this.cbxTempoPomodoro_SelectedIndexChanged);
            // 
            // cbxTempoParadaCurta
            // 
            this.cbxTempoParadaCurta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempoParadaCurta.FormattingEnabled = true;
            this.cbxTempoParadaCurta.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbxTempoParadaCurta.Location = new System.Drawing.Point(257, 33);
            this.cbxTempoParadaCurta.Name = "cbxTempoParadaCurta";
            this.cbxTempoParadaCurta.Size = new System.Drawing.Size(121, 23);
            this.cbxTempoParadaCurta.TabIndex = 7;
            this.cbxTempoParadaCurta.SelectedIndexChanged += new System.EventHandler(this.cbxTempoParadaCurta_SelectedIndexChanged);
            // 
            // cbxTempoParadaLonga
            // 
            this.cbxTempoParadaLonga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempoParadaLonga.FormattingEnabled = true;
            this.cbxTempoParadaLonga.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbxTempoParadaLonga.Location = new System.Drawing.Point(257, 63);
            this.cbxTempoParadaLonga.Name = "cbxTempoParadaLonga";
            this.cbxTempoParadaLonga.Size = new System.Drawing.Size(121, 23);
            this.cbxTempoParadaLonga.TabIndex = 8;
            this.cbxTempoParadaLonga.SelectedIndexChanged += new System.EventHandler(this.cbxTempoParadaLonga_SelectedIndexChanged);
            // 
            // txtTempoPomodoro
            // 
            this.txtTempoPomodoro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempoPomodoro.Location = new System.Drawing.Point(130, 3);
            this.txtTempoPomodoro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTempoPomodoro.Name = "txtTempoPomodoro";
            this.txtTempoPomodoro.Size = new System.Drawing.Size(121, 23);
            this.txtTempoPomodoro.TabIndex = 9;
            this.txtTempoPomodoro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTempoParadaCurta
            // 
            this.txtTempoParadaCurta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempoParadaCurta.Location = new System.Drawing.Point(130, 33);
            this.txtTempoParadaCurta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTempoParadaCurta.Name = "txtTempoParadaCurta";
            this.txtTempoParadaCurta.Size = new System.Drawing.Size(121, 23);
            this.txtTempoParadaCurta.TabIndex = 10;
            this.txtTempoParadaCurta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTempoParadaLonga
            // 
            this.txtTempoParadaLonga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempoParadaLonga.Location = new System.Drawing.Point(130, 63);
            this.txtTempoParadaLonga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTempoParadaLonga.Name = "txtTempoParadaLonga";
            this.txtTempoParadaLonga.Size = new System.Drawing.Size(121, 23);
            this.txtTempoParadaLonga.TabIndex = 11;
            this.txtTempoParadaLonga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelarFechar);
            this.Controls.Add(this.btnSalvarFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pomodoro Cronometro - Configuração";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoPomodoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoParadaCurta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoParadaLonga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarFechar;
        private System.Windows.Forms.Button btnCancelarFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTempoPomodoro;
        private System.Windows.Forms.ComboBox cbxTempoParadaCurta;
        private System.Windows.Forms.ComboBox cbxTempoParadaLonga;
        private System.Windows.Forms.NumericUpDown txtTempoPomodoro;
        private System.Windows.Forms.NumericUpDown txtTempoParadaCurta;
        private System.Windows.Forms.NumericUpDown txtTempoParadaLonga;
        private System.Windows.Forms.TextBox txtConclusao;
        private System.Windows.Forms.Label label4;
    }
}