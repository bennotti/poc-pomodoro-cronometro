namespace Pomodoro.Cronometro.Windows.App
{
    partial class FrmRelatorio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btnAbrirCaminho = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnMarcarComoConcluido = new System.Windows.Forms.Button();
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquivoTaskDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.arquivoTaskDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalTempoParada = new System.Windows.Forms.TextBox();
            this.txtQntParadasLongas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalTempoPomodoro = new System.Windows.Forms.TextBox();
            this.txtQntParadasCurtas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQntPomodoro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQntNaoConcluidas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQntConcluidas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQntArquivos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiretorio);
            this.groupBox1.Controls.Add(this.btnAbrirCaminho);
            this.groupBox1.Controls.Add(this.btnCarregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarefas";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Diretório";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiretorio.Location = new System.Drawing.Point(6, 37);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(368, 23);
            this.txtDiretorio.TabIndex = 0;
            // 
            // btnAbrirCaminho
            // 
            this.btnAbrirCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCaminho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaminho.Image = global::Pomodoro.Cronometro.Windows.App.Properties.Resources.abrir;
            this.btnAbrirCaminho.Location = new System.Drawing.Point(380, 37);
            this.btnAbrirCaminho.Name = "btnAbrirCaminho";
            this.btnAbrirCaminho.Size = new System.Drawing.Size(38, 23);
            this.btnAbrirCaminho.TabIndex = 1;
            this.btnAbrirCaminho.UseVisualStyleBackColor = true;
            this.btnAbrirCaminho.Click += new System.EventHandler(this.btnAbrirCaminho_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Location = new System.Drawing.Point(343, 66);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 28);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnMarcarComoConcluido);
            this.groupBox2.Controls.Add(this.dgvArquivos);
            this.groupBox2.Location = new System.Drawing.Point(448, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivos";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(6, 239);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnMarcarComoConcluido
            // 
            this.btnMarcarComoConcluido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcarComoConcluido.Enabled = false;
            this.btnMarcarComoConcluido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarComoConcluido.Location = new System.Drawing.Point(239, 239);
            this.btnMarcarComoConcluido.Name = "btnMarcarComoConcluido";
            this.btnMarcarComoConcluido.Size = new System.Drawing.Size(179, 23);
            this.btnMarcarComoConcluido.TabIndex = 2;
            this.btnMarcarComoConcluido.Text = "Marcar como concluido";
            this.btnMarcarComoConcluido.UseVisualStyleBackColor = true;
            this.btnMarcarComoConcluido.Click += new System.EventHandler(this.btnMarcarComoConcluido_Click);
            // 
            // dgvArquivos
            // 
            this.dgvArquivos.AllowUserToAddRows = false;
            this.dgvArquivos.AllowUserToDeleteRows = false;
            this.dgvArquivos.AllowUserToResizeColumns = false;
            this.dgvArquivos.AllowUserToResizeRows = false;
            this.dgvArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArquivos.AutoGenerateColumns = false;
            this.dgvArquivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvArquivos.DataSource = this.arquivoTaskDtoBindingSource1;
            this.dgvArquivos.Enabled = false;
            this.dgvArquivos.Location = new System.Drawing.Point(6, 22);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.ReadOnly = true;
            this.dgvArquivos.RowHeadersVisible = false;
            this.dgvArquivos.RowTemplate.Height = 25;
            this.dgvArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArquivos.Size = new System.Drawing.Size(412, 211);
            this.dgvArquivos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn2.FillWeight = 20F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // arquivoTaskDtoBindingSource1
            // 
            this.arquivoTaskDtoBindingSource1.DataSource = typeof(Pomodoro.Cronometro.Windows.App.Dtos.ArquivoTaskDto);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalTempoParada);
            this.groupBox3.Controls.Add(this.txtQntParadasLongas);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTotalTempoPomodoro);
            this.groupBox3.Controls.Add(this.txtQntParadasCurtas);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtQntPomodoro);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtQntNaoConcluidas);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtQntConcluidas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQntArquivos);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 159);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metricas";
            // 
            // txtTotalTempoParada
            // 
            this.txtTotalTempoParada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTempoParada.Location = new System.Drawing.Point(214, 125);
            this.txtTotalTempoParada.Name = "txtTotalTempoParada";
            this.txtTotalTempoParada.PlaceholderText = "0 dias, 00:00:00";
            this.txtTotalTempoParada.ReadOnly = true;
            this.txtTotalTempoParada.Size = new System.Drawing.Size(204, 23);
            this.txtTotalTempoParada.TabIndex = 7;
            this.txtTotalTempoParada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQntParadasLongas
            // 
            this.txtQntParadasLongas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntParadasLongas.Location = new System.Drawing.Point(281, 81);
            this.txtQntParadasLongas.Name = "txtQntParadasLongas";
            this.txtQntParadasLongas.PlaceholderText = "0";
            this.txtQntParadasLongas.ReadOnly = true;
            this.txtQntParadasLongas.Size = new System.Drawing.Size(137, 23);
            this.txtQntParadasLongas.TabIndex = 5;
            this.txtQntParadasLongas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total paradas";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Qnt. paradas longas";
            // 
            // txtTotalTempoPomodoro
            // 
            this.txtTotalTempoPomodoro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTempoPomodoro.Location = new System.Drawing.Point(6, 125);
            this.txtTotalTempoPomodoro.Name = "txtTotalTempoPomodoro";
            this.txtTotalTempoPomodoro.PlaceholderText = "0 dias, 00:00:00";
            this.txtTotalTempoPomodoro.ReadOnly = true;
            this.txtTotalTempoPomodoro.Size = new System.Drawing.Size(202, 23);
            this.txtTotalTempoPomodoro.TabIndex = 6;
            this.txtTotalTempoPomodoro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQntParadasCurtas
            // 
            this.txtQntParadasCurtas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntParadasCurtas.Location = new System.Drawing.Point(142, 81);
            this.txtQntParadasCurtas.Name = "txtQntParadasCurtas";
            this.txtQntParadasCurtas.PlaceholderText = "0";
            this.txtQntParadasCurtas.ReadOnly = true;
            this.txtQntParadasCurtas.Size = new System.Drawing.Size(133, 23);
            this.txtQntParadasCurtas.TabIndex = 4;
            this.txtQntParadasCurtas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total pomodoro";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(142, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Qnt. paradas curtas";
            // 
            // txtQntPomodoro
            // 
            this.txtQntPomodoro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntPomodoro.Location = new System.Drawing.Point(6, 81);
            this.txtQntPomodoro.Name = "txtQntPomodoro";
            this.txtQntPomodoro.PlaceholderText = "0";
            this.txtQntPomodoro.ReadOnly = true;
            this.txtQntPomodoro.Size = new System.Drawing.Size(130, 23);
            this.txtQntPomodoro.TabIndex = 3;
            this.txtQntPomodoro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Qnt. de pomodoros";
            // 
            // txtQntNaoConcluidas
            // 
            this.txtQntNaoConcluidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntNaoConcluidas.Location = new System.Drawing.Point(281, 37);
            this.txtQntNaoConcluidas.Name = "txtQntNaoConcluidas";
            this.txtQntNaoConcluidas.PlaceholderText = "0";
            this.txtQntNaoConcluidas.ReadOnly = true;
            this.txtQntNaoConcluidas.Size = new System.Drawing.Size(137, 23);
            this.txtQntNaoConcluidas.TabIndex = 2;
            this.txtQntNaoConcluidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Qnt. não concluidas";
            // 
            // txtQntConcluidas
            // 
            this.txtQntConcluidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntConcluidas.Location = new System.Drawing.Point(142, 37);
            this.txtQntConcluidas.Name = "txtQntConcluidas";
            this.txtQntConcluidas.PlaceholderText = "0";
            this.txtQntConcluidas.ReadOnly = true;
            this.txtQntConcluidas.Size = new System.Drawing.Size(133, 23);
            this.txtQntConcluidas.TabIndex = 1;
            this.txtQntConcluidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Qnt. concluidas";
            // 
            // txtQntArquivos
            // 
            this.txtQntArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntArquivos.Location = new System.Drawing.Point(6, 37);
            this.txtQntArquivos.Name = "txtQntArquivos";
            this.txtQntArquivos.PlaceholderText = "0";
            this.txtQntArquivos.ReadOnly = true;
            this.txtQntArquivos.Size = new System.Drawing.Size(130, 23);
            this.txtQntArquivos.TabIndex = 0;
            this.txtQntArquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qnt. de arquivos";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(798, 287);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 322);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatorio";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRelatorio_FormClosing);
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Button btnAbrirCaminho;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnMarcarComoConcluido;
        private System.Windows.Forms.DataGridView dgvArquivos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtQntNaoConcluidas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQntConcluidas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQntArquivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQntParadasLongas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQntParadasCurtas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQntPomodoro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalTempoPomodoro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.BindingSource arquivoTaskDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource arquivoTaskDtoBindingSource1;
        private System.Windows.Forms.TextBox txtTotalTempoParada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}