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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIniciarParadaCurta = new System.Windows.Forms.Button();
            this.btnIniciarParadaLonga = new System.Windows.Forms.Button();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.lblResumoContadores = new System.Windows.Forms.Label();
            this.lblTotalTempo = new System.Windows.Forms.Label();
            this.lblDiaMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.ckbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.ckbSpeakWhenFinish = new System.Windows.Forms.CheckBox();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(12, 140);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 37);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar pomodoro";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIniciarParadaCurta
            // 
            this.btnIniciarParadaCurta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarParadaCurta.Location = new System.Drawing.Point(149, 140);
            this.btnIniciarParadaCurta.Name = "btnIniciarParadaCurta";
            this.btnIniciarParadaCurta.Size = new System.Drawing.Size(131, 37);
            this.btnIniciarParadaCurta.TabIndex = 1;
            this.btnIniciarParadaCurta.Text = "Iniciar parada curta";
            this.btnIniciarParadaCurta.UseVisualStyleBackColor = true;
            this.btnIniciarParadaCurta.Click += new System.EventHandler(this.btnIniciarParadaCurta_Click);
            // 
            // btnIniciarParadaLonga
            // 
            this.btnIniciarParadaLonga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarParadaLonga.Location = new System.Drawing.Point(286, 140);
            this.btnIniciarParadaLonga.Name = "btnIniciarParadaLonga";
            this.btnIniciarParadaLonga.Size = new System.Drawing.Size(131, 37);
            this.btnIniciarParadaLonga.TabIndex = 2;
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
            this.lblResumoContadores.Location = new System.Drawing.Point(12, 9);
            this.lblResumoContadores.Name = "lblResumoContadores";
            this.lblResumoContadores.Size = new System.Drawing.Size(405, 23);
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
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Location = new System.Drawing.Point(286, 212);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(131, 31);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Limpar tudo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Enabled = false;
            this.btnZerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerar.Location = new System.Drawing.Point(149, 212);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(131, 31);
            this.btnZerar.TabIndex = 9;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Location = new System.Drawing.Point(12, 212);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(131, 31);
            this.btnParar.TabIndex = 11;
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
            this.ckbAlwaysOnTop.AutoSize = true;
            this.ckbAlwaysOnTop.Location = new System.Drawing.Point(12, 252);
            this.ckbAlwaysOnTop.Name = "ckbAlwaysOnTop";
            this.ckbAlwaysOnTop.Size = new System.Drawing.Size(101, 19);
            this.ckbAlwaysOnTop.TabIndex = 13;
            this.ckbAlwaysOnTop.Text = "Always on top";
            this.ckbAlwaysOnTop.UseVisualStyleBackColor = true;
            this.ckbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(342, 249);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Enabled = false;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(12, 183);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(352, 23);
            this.btnContinuar.TabIndex = 15;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // ckbSpeakWhenFinish
            // 
            this.ckbSpeakWhenFinish.AutoSize = true;
            this.ckbSpeakWhenFinish.Location = new System.Drawing.Point(119, 252);
            this.ckbSpeakWhenFinish.Name = "ckbSpeakWhenFinish";
            this.ckbSpeakWhenFinish.Size = new System.Drawing.Size(121, 19);
            this.ckbSpeakWhenFinish.TabIndex = 16;
            this.ckbSpeakWhenFinish.Text = "Speak when finish";
            this.ckbSpeakWhenFinish.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracao.Image")));
            this.btnConfiguracao.Location = new System.Drawing.Point(370, 183);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(45, 23);
            this.btnConfiguracao.TabIndex = 18;
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 276);
            this.Controls.Add(this.btnConfiguracao);
            this.Controls.Add(this.ckbSpeakWhenFinish);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.ckbAlwaysOnTop);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiaMes);
            this.Controls.Add(this.lblTotalTempo);
            this.Controls.Add(this.lblResumoContadores);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnIniciarParadaLonga);
            this.Controls.Add(this.btnIniciarParadaCurta);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Cronometro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIniciarParadaCurta;
        private System.Windows.Forms.Button btnIniciarParadaLonga;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Label lblResumoContadores;
        private System.Windows.Forms.Label lblTotalTempo;
        private System.Windows.Forms.Label lblDiaMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.CheckBox ckbAlwaysOnTop;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.CheckBox ckbSpeakWhenFinish;
        private System.Windows.Forms.Button btnConfiguracao;
    }
}
