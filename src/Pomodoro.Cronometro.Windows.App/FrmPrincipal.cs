using Pomodoro.Cronometro.Windows.App.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro.Cronometro.Windows.App
{
    public enum TipoExecucaoCronometro
    {
        Nenhum = 0,
        Pomodoro = 1,
        ParadaCurta = 2,
        ParadaLonga = 3,
    }
    public enum TipoExecucaoTempo
    {
        Segundos = 0,
        Minutos = 1,
        Horas = 2,
    }
    public partial class FrmPrincipal : Form
    {
        TipoExecucaoCronometro _tipoExecucao = TipoExecucaoCronometro.Nenhum;
        bool _cronometroLigado = false;
        string _valorCronometro = "00:00";
        DateTime? _dataGatilhoInicio = null;
        DateTime? _dataAlvoFim = null;
        TimeSpan? _cronometro = null;

        int _qntPomodoros = 0;
        int _qntParadasCurtas = 0;
        int _qntParadasLongas = 0;

        private readonly SpeechSynthesizer _synthesizer = null;
        PromptBuilder _builder = null;
        private readonly FrmConfiguracao _frmConfiguracao;

        string _textoConclusao = "Você chegou ao seu destino.";
        int _tempoPomodoro = 25;
        int _tempoParadaCurta = 5;
        int _tempoParadaLonga = 15;
        TipoExecucaoTempo _tipoTempoPomodoro = TipoExecucaoTempo.Minutos;
        TipoExecucaoTempo _tipoTempoParadaCurta = TipoExecucaoTempo.Minutos;
        TipoExecucaoTempo _tipoTempoParadaLonga = TipoExecucaoTempo.Minutos;

        public FrmPrincipal(FrmConfiguracao frmConfiguracao)
        {
            InitializeComponent();

            _synthesizer = new SpeechSynthesizer();
            _synthesizer.SetOutputToDefaultAudioDevice();
            _synthesizer.Rate = 3;
            _synthesizer.Volume = 100;
            _builder = new PromptBuilder();
            _builder.StartVoice(new CultureInfo("pt-BR"));
            _builder.AppendText(_textoConclusao);
            _builder.EndVoice();
            _frmConfiguracao = frmConfiguracao;
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            var response = _frmConfiguracao.ShowDialog(new ConfiguracaoCronometroDto {
                TextoConclusao = _textoConclusao,
                TempoPomodoro = _tempoPomodoro,
                TempoParadaCurta = _tempoParadaCurta,
                TempoParadaLonga = _tempoParadaLonga,
                IndexTipoTempoPomodoro = (int)_tipoTempoPomodoro,
                IndexTipoTempoParadaCurta = (int)_tipoTempoParadaCurta,
                IndexTipoTempoParadaLonga = (int)_tipoTempoParadaLonga,
            });

            if (response == DialogResult.OK) {
                _tempoPomodoro = _frmConfiguracao.TempoPomodoro;
                _tempoParadaCurta = _frmConfiguracao.TempoParadaCurta;
                _tempoParadaLonga = _frmConfiguracao.TempoParadaLonga;

                _tipoTempoPomodoro = (TipoExecucaoTempo)_frmConfiguracao.TipoTempoPomodoro;
                _tipoTempoParadaCurta = (TipoExecucaoTempo)_frmConfiguracao.TipoTempoParadaCurta;
                _tipoTempoParadaLonga = (TipoExecucaoTempo)_frmConfiguracao.TipoTempoParadaLonga;

                _textoConclusao = _frmConfiguracao.TextoConclusao;

                _builder = new PromptBuilder();
                _builder.StartVoice(new CultureInfo("pt-BR"));
                _builder.AppendText(_textoConclusao);
                _builder.EndVoice();
            }
        }

        void ConcluirCronometro()
        {
            if (ckbSpeakWhenFinish.Checked && _synthesizer != null && _builder != null)
            {
                _synthesizer.Speak(_builder);
            }

            switch(_tipoExecucao) {
                case TipoExecucaoCronometro.Pomodoro: {
                    _qntPomodoros += 1;
                    break;
                }
                case TipoExecucaoCronometro.ParadaCurta: {
                    _qntParadasCurtas += 1;
                    break;
                }
                case TipoExecucaoCronometro.ParadaLonga: {
                    _qntParadasLongas += 1;
                    break;
                }
                default:
                {
                    break;
                }
            }
            btnReiniciar.Enabled = true;
            ZerarInformacoes();
        }

        void FormatarValorCronometro(TipoExecucaoTempo tipo)
        {
            switch (tipo)
            {
                case TipoExecucaoTempo.Segundos:
                case TipoExecucaoTempo.Minutos:
                    {
                        _valorCronometro = $"{_cronometro?.Minutes:00}:{_cronometro?.Seconds:00}";
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _valorCronometro = $"{_cronometro?.Hours:00}:{_cronometro?.Minutes:00}:{_cronometro?.Seconds:00}";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void ProcessaCronometro() {
            if (!_cronometroLigado) {
                lblCronometro.Text = _valorCronometro;
                return;
            }

            if (_dataGatilhoInicio.HasValue && _dataAlvoFim.HasValue) {
                DateTime currentTime = DateTime.Now;

                if (_dataAlvoFim.Value > currentTime) {
                    _cronometro = _dataAlvoFim.Value.Subtract(currentTime);
                    switch(_tipoExecucao) {
                        case TipoExecucaoCronometro.Pomodoro: {
                            FormatarValorCronometro(_tipoTempoPomodoro);
                            break;
                        }
                        case TipoExecucaoCronometro.ParadaCurta: {
                            FormatarValorCronometro(_tipoTempoParadaCurta);
                            break;
                        }
                        case TipoExecucaoCronometro.ParadaLonga: {
                            FormatarValorCronometro(_tipoTempoParadaLonga);
                            break;
                        }
                        default: {
                            break;
                        }
                    }
                } else {
                    ConcluirCronometro();
                }
            }

            lblCronometro.Text = _valorCronometro;
        }

        void AtualizaInfoDia()
        {
            lblDiaSemana.Text = DateTime.Now.ToString("dddd",
                        new CultureInfo("pt-BR"));
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss",
                        new CultureInfo("pt-BR"));
            lblDiaMes.Text = DateTime.Now.ToString("dd/MM",
                        new CultureInfo("pt-BR"));
            lblAno.Text = DateTime.Now.ToString("yyyy",
                        new CultureInfo("pt-BR"));

            lblResumoContadores.Text = $@"{_qntPomodoros} pomodoros | {_qntParadasCurtas} paradas curtas | {_qntParadasLongas} paradas longas";

            lblTotalTempo.Text = $@"00:00:00 Tempo total pomodoro | 00:00:00 Tempo total Paradas";

            ProcessaCronometro();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            AtualizaInfoDia();
            //Application.DoEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaInfoDia();
            tmrHora.Enabled = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            _dataGatilhoInicio = DateTime.Now;
            switch (_tipoTempoPomodoro)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        _dataAlvoFim = DateTime.Now.AddSeconds(_tempoPomodoro);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        _dataAlvoFim = DateTime.Now.AddMinutes(_tempoPomodoro);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _dataAlvoFim = DateTime.Now.AddHours(_tempoPomodoro);
                        break;
                    }
                default: {
                    break;
                }
            }
            _tipoExecucao = TipoExecucaoCronometro.Pomodoro;
            _cronometroLigado = true;
            btnParar.Enabled = true;
            btnIniciar.Enabled = false;
            btnIniciarParadaCurta.Enabled = false;
            btnIniciarParadaLonga.Enabled = false;
            btnReiniciar.Enabled = false;
            btnConfiguracao.Enabled = false;
        }

        private void btnIniciarParadaCurta_Click(object sender, EventArgs e)
        {
            _dataGatilhoInicio = DateTime.Now;
            switch (_tipoTempoParadaCurta)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        _dataAlvoFim = DateTime.Now.AddSeconds(_tempoParadaCurta);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        _dataAlvoFim = DateTime.Now.AddMinutes(_tempoParadaCurta);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _dataAlvoFim = DateTime.Now.AddHours(_tempoParadaCurta);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            _tipoExecucao = TipoExecucaoCronometro.ParadaCurta;
            _cronometroLigado = true;
            btnParar.Enabled = true;
            btnIniciar.Enabled = false;
            btnIniciarParadaCurta.Enabled = false;
            btnIniciarParadaLonga.Enabled = false;
            btnReiniciar.Enabled = false;
            btnConfiguracao.Enabled = false;
        }

        private void btnIniciarParadaLonga_Click(object sender, EventArgs e)
        {
            _dataGatilhoInicio = DateTime.Now;

            switch (_tipoTempoParadaLonga)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        _dataAlvoFim = DateTime.Now.AddSeconds(_tempoParadaLonga);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        _dataAlvoFim = DateTime.Now.AddMinutes(_tempoParadaLonga);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _dataAlvoFim = DateTime.Now.AddHours(_tempoParadaLonga);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            _tipoExecucao = TipoExecucaoCronometro.ParadaLonga;
            _cronometroLigado = true;
            btnParar.Enabled = true;
            btnIniciar.Enabled = false;
            btnIniciarParadaCurta.Enabled = false;
            btnIniciarParadaLonga.Enabled = false;
            btnReiniciar.Enabled = false;
            btnConfiguracao.Enabled = false;
        }

        private void btnParar_Click(object sender, EventArgs e) {
            _cronometroLigado = false;
            btnZerar.Enabled = true;
            btnContinuar.Enabled = true;
            btnParar.Enabled = false;
            if (_qntPomodoros > 0 || _qntParadasCurtas > 0 || _qntParadasLongas > 0) {
                btnReiniciar.Enabled = true;
            }
        }

        void ZerarInformacoes()
        {
            _cronometroLigado = false;
            _valorCronometro = "00:00";
            btnIniciar.Enabled = true;
            btnIniciarParadaCurta.Enabled = true;
            btnIniciarParadaLonga.Enabled = true;
            btnContinuar.Enabled = false;
            btnParar.Enabled = false;
            btnZerar.Enabled = false;
            _dataGatilhoInicio = null;
            _dataAlvoFim = null;
            btnConfiguracao.Enabled = true;
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            ZerarInformacoes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = ckbAlwaysOnTop.Checked;
            this._frmConfiguracao.TopMost = ckbAlwaysOnTop.Checked;
            Application.DoEvents();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (_cronometro.HasValue) {
                _dataGatilhoInicio = DateTime.Now;
                _dataAlvoFim = DateTime.Now.Add(_cronometro.Value);
            }
            _cronometroLigado = true;
            btnContinuar.Enabled = false;
            btnZerar.Enabled = false;
            btnParar.Enabled = true;
            btnReiniciar.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente limpar os registros?", "Pomodoro cronometro",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            _qntParadasCurtas = 0;
            _qntParadasLongas = 0;
            _qntPomodoros = 0;

            btnReiniciar.Enabled = false;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Pomodoro cronometro",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

    }
}
