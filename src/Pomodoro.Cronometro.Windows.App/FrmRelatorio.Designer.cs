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
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btnAbrirCaminho = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnMarcarComoConcluido = new System.Windows.Forms.Button();
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.arquivoTaskDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQntParadasLongas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQntParadasCurtas = new System.Windows.Forms.TextBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPomodoroAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPomodoroMes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPomodoroSemana = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPomodoro14Dias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPomodoro7Dias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPomodoroDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtParadaAno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParadaMes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParadaSemana = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtParada14Dias = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtParada7Dias = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtParadaDia = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.arquivoTaskDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiretorio);
            this.groupBox1.Controls.Add(this.btnAbrirCaminho);
            this.groupBox1.Controls.Add(this.btnCarregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasta com tarefas";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiretorio.Location = new System.Drawing.Point(6, 23);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(287, 23);
            this.txtDiretorio.TabIndex = 18;
            // 
            // btnAbrirCaminho
            // 
            this.btnAbrirCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCaminho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaminho.Image = global::Pomodoro.Cronometro.Windows.App.Properties.Resources.abrir;
            this.btnAbrirCaminho.Location = new System.Drawing.Point(299, 22);
            this.btnAbrirCaminho.Name = "btnAbrirCaminho";
            this.btnAbrirCaminho.Size = new System.Drawing.Size(38, 23);
            this.btnAbrirCaminho.TabIndex = 17;
            this.btnAbrirCaminho.UseVisualStyleBackColor = true;
            this.btnAbrirCaminho.Click += new System.EventHandler(this.btnAbrirCaminho_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Location = new System.Drawing.Point(343, 22);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 16;
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
            this.groupBox2.Size = new System.Drawing.Size(424, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivos";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(6, 231);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 18;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnMarcarComoConcluido
            // 
            this.btnMarcarComoConcluido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcarComoConcluido.Enabled = false;
            this.btnMarcarComoConcluido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarComoConcluido.Location = new System.Drawing.Point(239, 231);
            this.btnMarcarComoConcluido.Name = "btnMarcarComoConcluido";
            this.btnMarcarComoConcluido.Size = new System.Drawing.Size(179, 23);
            this.btnMarcarComoConcluido.TabIndex = 17;
            this.btnMarcarComoConcluido.Text = "Marcar como concluido";
            this.btnMarcarComoConcluido.UseVisualStyleBackColor = true;
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
            this.dgvArquivos.Size = new System.Drawing.Size(412, 203);
            this.dgvArquivos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQntParadasLongas);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtQntParadasCurtas);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtQntPomodoro);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtQntNaoConcluidas);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtQntConcluidas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQntArquivos);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metricas";
            // 
            // txtQntParadasLongas
            // 
            this.txtQntParadasLongas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntParadasLongas.Location = new System.Drawing.Point(281, 81);
            this.txtQntParadasLongas.Name = "txtQntParadasLongas";
            this.txtQntParadasLongas.PlaceholderText = "0";
            this.txtQntParadasLongas.ReadOnly = true;
            this.txtQntParadasLongas.Size = new System.Drawing.Size(137, 23);
            this.txtQntParadasLongas.TabIndex = 29;
            this.txtQntParadasLongas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtQntParadasCurtas
            // 
            this.txtQntParadasCurtas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQntParadasCurtas.Location = new System.Drawing.Point(142, 81);
            this.txtQntParadasCurtas.Name = "txtQntParadasCurtas";
            this.txtQntParadasCurtas.PlaceholderText = "0";
            this.txtQntParadasCurtas.ReadOnly = true;
            this.txtQntParadasCurtas.Size = new System.Drawing.Size(133, 23);
            this.txtQntParadasCurtas.TabIndex = 27;
            this.txtQntParadasCurtas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtQntPomodoro.TabIndex = 25;
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
            this.txtQntNaoConcluidas.TabIndex = 17;
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
            this.txtQntConcluidas.TabIndex = 15;
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
            this.txtQntArquivos.TabIndex = 1;
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
            this.btnFechar.Location = new System.Drawing.Point(798, 407);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPomodoroAno);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPomodoroMes);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPomodoroSemana);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtPomodoro14Dias);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtPomodoro7Dias);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtPomodoroDia);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 115);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métricas - tempo pomodoro";
            // 
            // txtPomodoroAno
            // 
            this.txtPomodoroAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPomodoroAno.Location = new System.Drawing.Point(280, 81);
            this.txtPomodoroAno.Name = "txtPomodoroAno";
            this.txtPomodoroAno.PlaceholderText = "0 dia, 00:00:00";
            this.txtPomodoroAno.ReadOnly = true;
            this.txtPomodoroAno.Size = new System.Drawing.Size(137, 23);
            this.txtPomodoroAno.TabIndex = 35;
            this.txtPomodoroAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total ano";
            // 
            // txtPomodoroMes
            // 
            this.txtPomodoroMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPomodoroMes.Location = new System.Drawing.Point(141, 81);
            this.txtPomodoroMes.Name = "txtPomodoroMes";
            this.txtPomodoroMes.PlaceholderText = "0 dia, 00:00:00";
            this.txtPomodoroMes.ReadOnly = true;
            this.txtPomodoroMes.Size = new System.Drawing.Size(133, 23);
            this.txtPomodoroMes.TabIndex = 33;
            this.txtPomodoroMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total mês";
            // 
            // txtPomodoroSemana
            // 
            this.txtPomodoroSemana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPomodoroSemana.Location = new System.Drawing.Point(6, 81);
            this.txtPomodoroSemana.Name = "txtPomodoroSemana";
            this.txtPomodoroSemana.PlaceholderText = "0 dia, 00:00:00";
            this.txtPomodoroSemana.ReadOnly = true;
            this.txtPomodoroSemana.Size = new System.Drawing.Size(129, 23);
            this.txtPomodoroSemana.TabIndex = 31;
            this.txtPomodoroSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total semana";
            // 
            // txtPomodoro14Dias
            // 
            this.txtPomodoro14Dias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPomodoro14Dias.Location = new System.Drawing.Point(280, 37);
            this.txtPomodoro14Dias.Name = "txtPomodoro14Dias";
            this.txtPomodoro14Dias.PlaceholderText = "0 dia, 00:00:00";
            this.txtPomodoro14Dias.ReadOnly = true;
            this.txtPomodoro14Dias.Size = new System.Drawing.Size(137, 23);
            this.txtPomodoro14Dias.TabIndex = 29;
            this.txtPomodoro14Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total ultimos 14 dias";
            // 
            // txtPomodoro7Dias
            // 
            this.txtPomodoro7Dias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPomodoro7Dias.Location = new System.Drawing.Point(141, 37);
            this.txtPomodoro7Dias.Name = "txtPomodoro7Dias";
            this.txtPomodoro7Dias.PlaceholderText = "0 dia, 00:00:00";
            this.txtPomodoro7Dias.ReadOnly = true;
            this.txtPomodoro7Dias.Size = new System.Drawing.Size(133, 23);
            this.txtPomodoro7Dias.TabIndex = 27;
            this.txtPomodoro7Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total ultimos 7 dias";
            // 
            // txtPomodoroDia
            // 
            this.txtPomodoroDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPomodoroDia.Location = new System.Drawing.Point(6, 37);
            this.txtPomodoroDia.Name = "txtPomodoroDia";
            this.txtPomodoroDia.PlaceholderText = "00:00:00";
            this.txtPomodoroDia.ReadOnly = true;
            this.txtPomodoroDia.Size = new System.Drawing.Size(129, 23);
            this.txtPomodoroDia.TabIndex = 25;
            this.txtPomodoroDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total dia";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtParadaAno);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtParadaMes);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtParadaSemana);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtParada14Dias);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtParada7Dias);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtParadaDia);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(448, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 115);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Métricas - tempo paradas";
            // 
            // txtParadaAno
            // 
            this.txtParadaAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParadaAno.Location = new System.Drawing.Point(280, 81);
            this.txtParadaAno.Name = "txtParadaAno";
            this.txtParadaAno.PlaceholderText = "0 dia, 00:00:00";
            this.txtParadaAno.ReadOnly = true;
            this.txtParadaAno.Size = new System.Drawing.Size(137, 23);
            this.txtParadaAno.TabIndex = 47;
            this.txtParadaAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Total ano";
            // 
            // txtParadaMes
            // 
            this.txtParadaMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParadaMes.Location = new System.Drawing.Point(141, 81);
            this.txtParadaMes.Name = "txtParadaMes";
            this.txtParadaMes.PlaceholderText = "0 dia, 00:00:00";
            this.txtParadaMes.ReadOnly = true;
            this.txtParadaMes.Size = new System.Drawing.Size(133, 23);
            this.txtParadaMes.TabIndex = 45;
            this.txtParadaMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Total mês";
            // 
            // txtParadaSemana
            // 
            this.txtParadaSemana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParadaSemana.Location = new System.Drawing.Point(6, 81);
            this.txtParadaSemana.Name = "txtParadaSemana";
            this.txtParadaSemana.PlaceholderText = "0 dia, 00:00:00";
            this.txtParadaSemana.ReadOnly = true;
            this.txtParadaSemana.Size = new System.Drawing.Size(129, 23);
            this.txtParadaSemana.TabIndex = 43;
            this.txtParadaSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "Total semana";
            // 
            // txtParada14Dias
            // 
            this.txtParada14Dias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParada14Dias.Location = new System.Drawing.Point(280, 37);
            this.txtParada14Dias.Name = "txtParada14Dias";
            this.txtParada14Dias.PlaceholderText = "0 dia, 00:00:00";
            this.txtParada14Dias.ReadOnly = true;
            this.txtParada14Dias.Size = new System.Drawing.Size(137, 23);
            this.txtParada14Dias.TabIndex = 41;
            this.txtParada14Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 15);
            this.label16.TabIndex = 40;
            this.label16.Text = "Total ultimos 14 dias";
            // 
            // txtParada7Dias
            // 
            this.txtParada7Dias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParada7Dias.Location = new System.Drawing.Point(141, 37);
            this.txtParada7Dias.Name = "txtParada7Dias";
            this.txtParada7Dias.PlaceholderText = "0 dia, 00:00:00";
            this.txtParada7Dias.ReadOnly = true;
            this.txtParada7Dias.Size = new System.Drawing.Size(133, 23);
            this.txtParada7Dias.TabIndex = 39;
            this.txtParada7Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(141, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "Total ultimos 7 dias";
            // 
            // txtParadaDia
            // 
            this.txtParadaDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParadaDia.Location = new System.Drawing.Point(6, 37);
            this.txtParadaDia.Name = "txtParadaDia";
            this.txtParadaDia.PlaceholderText = "00:00:00";
            this.txtParadaDia.ReadOnly = true;
            this.txtParadaDia.Size = new System.Drawing.Size(129, 23);
            this.txtParadaDia.TabIndex = 37;
            this.txtParadaDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "Total dia";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtNomeArquivo);
            this.gbFiltro.Controls.Add(this.label21);
            this.gbFiltro.Controls.Add(this.btnFiltrar);
            this.gbFiltro.Controls.Add(this.txtDataFinal);
            this.gbFiltro.Controls.Add(this.label20);
            this.gbFiltro.Controls.Add(this.txtDataInicio);
            this.gbFiltro.Controls.Add(this.label19);
            this.gbFiltro.Enabled = false;
            this.gbFiltro.Location = new System.Drawing.Point(12, 75);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(424, 74);
            this.gbFiltro.TabIndex = 19;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeArquivo.Location = new System.Drawing.Point(170, 37);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(165, 23);
            this.txtNomeArquivo.TabIndex = 26;
            this.txtNomeArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(170, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 15);
            this.label21.TabIndex = 25;
            this.label21.Text = "Nome arquivo";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(342, 36);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 24;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFinal.Location = new System.Drawing.Point(88, 37);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.PlaceholderText = "00/00/0000";
            this.txtDataFinal.Size = new System.Drawing.Size(76, 23);
            this.txtDataFinal.TabIndex = 23;
            this.txtDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(88, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 15);
            this.label20.TabIndex = 22;
            this.label20.Text = "Data final";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataInicio.Location = new System.Drawing.Point(6, 37);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.PlaceholderText = "00/00/0000";
            this.txtDataInicio.Size = new System.Drawing.Size(76, 23);
            this.txtDataInicio.TabIndex = 21;
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 20;
            this.label19.Text = "Data inicio";
            // 
            // arquivoTaskDtoBindingSource1
            // 
            this.arquivoTaskDtoBindingSource1.DataSource = typeof(Pomodoro.Cronometro.Windows.App.Dtos.ArquivoTaskDto);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 442);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arquivoTaskDtoBindingSource1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPomodoroAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPomodoroMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPomodoroSemana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPomodoro14Dias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPomodoro7Dias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPomodoroDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtParadaAno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParadaMes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParadaSemana;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtParada14Dias;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtParada7Dias;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtParadaDia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.BindingSource arquivoTaskDtoBindingSource;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource arquivoTaskDtoBindingSource1;
    }
}