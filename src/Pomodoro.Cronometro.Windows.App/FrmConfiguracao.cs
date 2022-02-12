using Pomodoro.Cronometro.Windows.App.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pomodoro.Cronometro.Windows.App
{
    public partial class FrmConfiguracao : Form
    {
        public string TextoConclusao
        {
            get
            {
                return txtConclusao.Text;
            }
        }
        public int TempoPomodoro
        {
            get
            {
                return (int)txtTempoPomodoro.Value;
            }
        }
        public int TempoParadaCurta
        {
            get
            {
                return (int)txtTempoParadaCurta.Value;
            }
        }
        public int TempoParadaLonga
        {
            get
            {
                return (int)txtTempoParadaLonga.Value;
            }
        }

        public int TipoTempoPomodoro
        {
            get
            {
                return cbxTempoPomodoro.SelectedIndex;
            }
        }

        public int TipoTempoParadaCurta
        {
            get
            {
                return cbxTempoParadaCurta.SelectedIndex;
            }
        }

        public int TipoTempoParadaLonga
        {
            get
            {
                return cbxTempoParadaLonga.SelectedIndex;
            }
        }

        public FrmConfiguracao()
        {
            InitializeComponent();
        }

        private void btnSalvarFechar_Click(object sender, EventArgs e)
        {
            var valorText = txtConclusao.Text.Trim();
            if (string.IsNullOrEmpty(valorText))
            {
                MessageBox.Show("Informe o texto de conclusão.", "Pomodoro cronometro");
                return;
            }
            this.Close();
        }

        private void btnCancelarFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DialogResult ShowDialog(ConfiguracaoCronometroDto config)
        {
            cbxTempoParadaCurta.SelectedIndex = config.IndexTipoTempoParadaCurta;
            cbxTempoParadaLonga.SelectedIndex = config.IndexTipoTempoParadaLonga;
            cbxTempoPomodoro.SelectedIndex = config.IndexTipoTempoPomodoro;

            ValidarIndexTempoPomodoro();
            ValidarIndexTempoParadaCurta();
            ValidarIndexTempoParadaLonga();

            txtTempoPomodoro.Value = config.TempoPomodoro;
            txtTempoParadaCurta.Value = config.TempoParadaCurta;
            txtTempoParadaLonga.Value = config.TempoParadaLonga;

            txtConclusao.Text = config.TextoConclusao;

            return base.ShowDialog();
        }

        void ValidarIndexTempoParadaLonga()
        {
            switch (cbxTempoParadaLonga.SelectedIndex)
            {
                case 0:
                case 1:
                    {
                        txtTempoParadaLonga.Maximum = 60;
                        break;
                    }
                case 2:
                    {
                        txtTempoParadaLonga.Maximum = 24;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void ValidarIndexTempoParadaCurta()
        {
            switch (cbxTempoParadaCurta.SelectedIndex)
            {
                case 0:
                case 1:
                    {
                        txtTempoParadaCurta.Maximum = 60;
                        break;
                    }
                case 2:
                    {
                        txtTempoParadaCurta.Maximum = 24;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void ValidarIndexTempoPomodoro()
        {
            switch (cbxTempoPomodoro.SelectedIndex)
            {
                case 0:
                case 1:
                    {
                        txtTempoPomodoro.Maximum = 60;
                        break;
                    }
                case 2:
                    {
                        txtTempoPomodoro.Maximum = 24;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void cbxTempoPomodoro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarIndexTempoPomodoro();
        }

        private void cbxTempoParadaCurta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarIndexTempoParadaCurta();
        }

        private void cbxTempoParadaLonga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarIndexTempoParadaLonga();
        }
    }
}
