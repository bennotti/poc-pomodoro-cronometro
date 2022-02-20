namespace Pomodoro.Cronometro.Windows.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnIniciarPomodoro = new System.Windows.Forms.Button();
            this.btnIniciarParadaCurta = new System.Windows.Forms.Button();
            this.btnIniciarParadaLonga = new System.Windows.Forms.Button();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.lblResumoContadores = new System.Windows.Forms.Label();
            this.lblTotalTempo = new System.Windows.Forms.Label();
            this.lblDiaMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.ckbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.ckbSpeakWhenFinish = new System.Windows.Forms.CheckBox();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.ckbConcluida = new System.Windows.Forms.CheckBox();
            this.btnAddPomodoro = new System.Windows.Forms.Button();
            this.btnMinusPomodoro = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarPomodoro
            // 
            this.btnIniciarPomodoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIniciarPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPomodoro.Location = new System.Drawing.Point(12, 235);
            this.btnIniciarPomodoro.Name = "btnIniciarPomodoro";
            this.btnIniciarPomodoro.Size = new System.Drawing.Size(131, 37);
            this.btnIniciarPomodoro.TabIndex = 1;
            this.btnIniciarPomodoro.Text = "Iniciar pomodoro";
            this.btnIniciarPomodoro.UseVisualStyleBackColor = true;
            this.btnIniciarPomodoro.Click += new System.EventHandler(this.btnIniciarPomodoro_Click);
            // 
            // btnIniciarParadaCurta
            // 
            this.btnIniciarParadaCurta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIniciarParadaCurta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarParadaCurta.Location = new System.Drawing.Point(149, 235);
            this.btnIniciarParadaCurta.Name = "btnIniciarParadaCurta";
            this.btnIniciarParadaCurta.Size = new System.Drawing.Size(131, 37);
            this.btnIniciarParadaCurta.TabIndex = 2;
            this.btnIniciarParadaCurta.Text = "Iniciar parada curta";
            this.btnIniciarParadaCurta.UseVisualStyleBackColor = true;
            this.btnIniciarParadaCurta.Click += new System.EventHandler(this.btnIniciarParadaCurta_Click);
            // 
            // btnIniciarParadaLonga
            // 
            this.btnIniciarParadaLonga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIniciarParadaLonga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarParadaLonga.Location = new System.Drawing.Point(286, 235);
            this.btnIniciarParadaLonga.Name = "btnIniciarParadaLonga";
            this.btnIniciarParadaLonga.Size = new System.Drawing.Size(131, 37);
            this.btnIniciarParadaLonga.TabIndex = 3;
            this.btnIniciarParadaLonga.Text = "Iniciar parada longa";
            this.btnIniciarParadaLonga.UseVisualStyleBackColor = true;
            this.btnIniciarParadaLonga.Click += new System.EventHandler(this.btnIniciarParadaLonga_Click);
            // 
            // lblCronometro
            // 
            this.lblCronometro.Font = new System.Drawing.Font("Segoe UI", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCronometro.Location = new System.Drawing.Point(12, 9);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(403, 128);
            this.lblCronometro.TabIndex = 3;
            this.lblCronometro.Text = "00:00";
            this.lblCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResumoContadores
            // 
            this.lblResumoContadores.Location = new System.Drawing.Point(70, 9);
            this.lblResumoContadores.Name = "lblResumoContadores";
            this.lblResumoContadores.Size = new System.Drawing.Size(347, 23);
            this.lblResumoContadores.TabIndex = 4;
            this.lblResumoContadores.Text = "0 pomodoros | 0 paradas curtas | 0 paradas longas";
            this.lblResumoContadores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTempo
            // 
            this.lblTotalTempo.Location = new System.Drawing.Point(12, 114);
            this.lblTotalTempo.Name = "lblTotalTempo";
            this.lblTotalTempo.Size = new System.Drawing.Size(405, 23);
            this.lblTotalTempo.TabIndex = 5;
            this.lblTotalTempo.Text = "00:00:00 Tempo total pomodoro | 00:00:00 Tempo total Paradas";
            this.lblTotalTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiaMes
            // 
            this.lblDiaMes.AutoSize = true;
            this.lblDiaMes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiaMes.Location = new System.Drawing.Point(12, 72);
            this.lblDiaMes.Name = "lblDiaMes";
            this.lblDiaMes.Size = new System.Drawing.Size(47, 20);
            this.lblDiaMes.TabIndex = 6;
            this.lblDiaMes.Text = "00/00";
            this.lblDiaMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAno.Location = new System.Drawing.Point(12, 92);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 20);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "2022";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaSemana.Location = new System.Drawing.Point(12, 55);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(61, 17);
            this.lblDiaSemana.TabIndex = 8;
            this.lblDiaSemana.Text = "Segunda";
            this.lblDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(288, 307);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(39, 31);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZerar.Enabled = false;
            this.btnZerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerar.Location = new System.Drawing.Point(149, 307);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(131, 31);
            this.btnZerar.TabIndex = 7;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParar.Enabled = false;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Location = new System.Drawing.Point(12, 307);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(131, 31);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(12, 38);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 17);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrHora
            // 
            this.tmrHora.Interval = 200;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // ckbAlwaysOnTop
            // 
            this.ckbAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbAlwaysOnTop.AutoSize = true;
            this.ckbAlwaysOnTop.Checked = true;
            this.ckbAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAlwaysOnTop.Location = new System.Drawing.Point(12, 347);
            this.ckbAlwaysOnTop.Name = "ckbAlwaysOnTop";
            this.ckbAlwaysOnTop.Size = new System.Drawing.Size(101, 19);
            this.ckbAlwaysOnTop.TabIndex = 11;
            this.ckbAlwaysOnTop.Text = "Always on top";
            this.ckbAlwaysOnTop.UseVisualStyleBackColor = true;
            this.ckbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(342, 344);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinuar.Enabled = false;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(12, 278);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(354, 23);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // ckbSpeakWhenFinish
            // 
            this.ckbSpeakWhenFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbSpeakWhenFinish.AutoSize = true;
            this.ckbSpeakWhenFinish.Checked = true;
            this.ckbSpeakWhenFinish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSpeakWhenFinish.Location = new System.Drawing.Point(119, 347);
            this.ckbSpeakWhenFinish.Name = "ckbSpeakWhenFinish";
            this.ckbSpeakWhenFinish.Size = new System.Drawing.Size(121, 19);
            this.ckbSpeakWhenFinish.TabIndex = 12;
            this.ckbSpeakWhenFinish.Text = "Speak when finish";
            this.ckbSpeakWhenFinish.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracao.Image")));
            this.btnConfiguracao.Location = new System.Drawing.Point(372, 278);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(45, 23);
            this.btnConfiguracao.TabIndex = 5;
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(333, 307);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(39, 31);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(378, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(39, 31);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "json";
            this.saveDialog.Filter = "Json File | *.json";
            this.saveDialog.Title = "Salvar tarefa";
            // 
            // openDialog
            // 
            this.openDialog.FileName = "*.json";
            this.openDialog.Filter = "Json File | *.json|All files (*.*)|*.*";
            this.openDialog.Title = "Abrir tarefa";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(33, 140);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderText = "Descrição da tarefa";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(384, 89);
            this.txtDescricao.TabIndex = 0;
            // 
            // ckbConcluida
            // 
            this.ckbConcluida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbConcluida.AutoSize = true;
            this.ckbConcluida.Location = new System.Drawing.Point(12, 178);
            this.ckbConcluida.Name = "ckbConcluida";
            this.ckbConcluida.Size = new System.Drawing.Size(15, 14);
            this.ckbConcluida.TabIndex = 15;
            this.ckbConcluida.UseVisualStyleBackColor = true;
            this.ckbConcluida.CheckedChanged += new System.EventHandler(this.ckbConcluida_CheckedChanged);
            // 
            // btnAddPomodoro
            // 
            this.btnAddPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPomodoro.Location = new System.Drawing.Point(12, 9);
            this.btnAddPomodoro.Name = "btnAddPomodoro";
            this.btnAddPomodoro.Size = new System.Drawing.Size(23, 23);
            this.btnAddPomodoro.TabIndex = 16;
            this.btnAddPomodoro.Text = "+";
            this.btnAddPomodoro.UseVisualStyleBackColor = true;
            this.btnAddPomodoro.Click += new System.EventHandler(this.btnAddPomodoro_Click);
            // 
            // btnMinusPomodoro
            // 
            this.btnMinusPomodoro.Enabled = false;
            this.btnMinusPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusPomodoro.Location = new System.Drawing.Point(41, 9);
            this.btnMinusPomodoro.Name = "btnMinusPomodoro";
            this.btnMinusPomodoro.Size = new System.Drawing.Size(23, 23);
            this.btnMinusPomodoro.TabIndex = 17;
            this.btnMinusPomodoro.Text = "-";
            this.btnMinusPomodoro.UseVisualStyleBackColor = true;
            this.btnMinusPomodoro.Click += new System.EventHandler(this.btnMinusPomodoro_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Location = new System.Drawing.Point(261, 344);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorio.TabIndex = 13;
            this.btnRelatorio.Text = "Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 371);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnMinusPomodoro);
            this.Controls.Add(this.btnAddPomodoro);
            this.Controls.Add(this.ckbConcluida);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnConfiguracao);
            this.Controls.Add(this.ckbSpeakWhenFinish);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.ckbAlwaysOnTop);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiaMes);
            this.Controls.Add(this.lblTotalTempo);
            this.Controls.Add(this.lblResumoContadores);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnIniciarParadaLonga);
            this.Controls.Add(this.btnIniciarParadaCurta);
            this.Controls.Add(this.btnIniciarPomodoro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Cronometro";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPomodoro;
        private System.Windows.Forms.Button btnIniciarParadaCurta;
        private System.Windows.Forms.Button btnIniciarParadaLonga;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Label lblResumoContadores;
        private System.Windows.Forms.Label lblTotalTempo;
        private System.Windows.Forms.Label lblDiaMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.CheckBox ckbAlwaysOnTop;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.CheckBox ckbSpeakWhenFinish;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.CheckBox ckbConcluida;
        private System.Windows.Forms.Button btnAddPomodoro;
        private System.Windows.Forms.Button btnMinusPomodoro;
        private System.Windows.Forms.Button btnRelatorio;
    }
}
