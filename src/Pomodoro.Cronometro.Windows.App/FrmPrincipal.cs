using Newtonsoft.Json;
using Pomodoro.Cronometro.Windows.App.Dtos;
using Pomodoro.Cronometro.Windows.App.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro.Cronometro.Windows.App
{
    public partial class FrmPrincipal : Form
    {
        private TaskPomodoroJsonDto _taskDocument;

        private bool _taskAlterada = false;
        private string _arquivoJson = string.Empty;

        TipoExecucaoCronometro _tipoExecucao = TipoExecucaoCronometro.Nenhum;
        bool _cronometroLigado = false;
        bool _cronometroParado = false;
        string _valorCronometro = "00:00";
        DateTime? _dataGatilhoInicio = null;
        DateTime? _dataAlvoFim = null;
        TimeSpan? _cronometro = null;

        private readonly SpeechSynthesizer _synthesizer = null;
        PromptBuilder _builder = null;
        private readonly FrmConfiguracao _frmConfiguracao;
        private readonly FrmRelatorio _frmRelatorio;

        public FrmPrincipal(FrmConfiguracao frmConfiguracao, FrmRelatorio frmRelatorio)
        {
            InitializeComponent();
            _taskDocument = new TaskPomodoroJsonDto();
            _synthesizer = new SpeechSynthesizer();
            _synthesizer.SetOutputToDefaultAudioDevice();
            _synthesizer.Rate = 3;
            _synthesizer.Volume = 100;
            _builder = new PromptBuilder();
            _builder.StartVoice(new CultureInfo("pt-BR"));
            _builder.AppendText(_taskDocument.TextoConclusao);
            _builder.EndVoice();
            _frmConfiguracao = frmConfiguracao;
            _frmRelatorio = frmRelatorio;
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            var response = _frmConfiguracao.ShowDialog(new ConfiguracaoCronometroDto {
                TextoConclusao = _taskDocument.TextoConclusao,
                TempoPomodoro = _taskDocument.TempoPomodoro,
                TempoParadaCurta = _taskDocument.TempoParadaCurta,
                TempoParadaLonga = _taskDocument.TempoParadaLonga,
                IndexTipoTempoPomodoro = (int)_taskDocument.TipoTempoPomodoro,
                IndexTipoTempoParadaCurta = (int)_taskDocument.TipoTempoParadaCurta,
                IndexTipoTempoParadaLonga = (int)_taskDocument.TipoTempoParadaLonga,
            });

            if (response == DialogResult.OK) {
                _taskDocument.TempoPomodoro = _frmConfiguracao.TempoPomodoro;
                _taskDocument.TempoParadaCurta = _frmConfiguracao.TempoParadaCurta;
                _taskDocument.TempoParadaLonga = _frmConfiguracao.TempoParadaLonga;

                _taskDocument.TipoTempoPomodoro = (TipoExecucaoTempo)_frmConfiguracao.TipoTempoPomodoro;
                _taskDocument.TipoTempoParadaCurta = (TipoExecucaoTempo)_frmConfiguracao.TipoTempoParadaCurta;
                _taskDocument.TipoTempoParadaLonga = (TipoExecucaoTempo)_frmConfiguracao.TipoTempoParadaLonga;

                _taskDocument.TextoConclusao = _frmConfiguracao.TextoConclusao;

                _builder = new PromptBuilder();
                _builder.StartVoice(new CultureInfo("pt-BR"));
                _builder.AppendText(_taskDocument.TextoConclusao);
                _builder.EndVoice();
            }
        }

        TimeSpan ObterTempo(TipoExecucaoTempo tipoTempo, int tempo) 
        {
            var response = new TimeSpan(0, 0, 0);
            switch (tipoTempo)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        response = new TimeSpan(0, 0, tempo);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        response = new TimeSpan(0, tempo, 0);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        response = new TimeSpan(tempo, 0, 0);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return response;
        }

        void ConcluirCronometro()
        {
            if (ckbSpeakWhenFinish.Checked && _synthesizer != null && _builder != null)
            {
                _synthesizer.Speak(_builder);
            }
            ContabilizarTempo();
            _taskAlterada = true;
            ZerarInformacoes();
        }

        void ContabilizarTempo()
        {
            ExecucaoTempoDto execucao;
            switch (_tipoExecucao)
            {
                case TipoExecucaoCronometro.Pomodoro:
                {
                    _taskDocument.TotalPomodoros += 1;
                    execucao = new ExecucaoTempoDto
                    {
                        TipoExecucao = _taskDocument.TipoTempoPomodoro,
                        Tempo = _taskDocument.TempoPomodoro,
                        ValorTimeSpan = ObterTempo(_taskDocument.TipoTempoPomodoro, _taskDocument.TempoPomodoro)
                    };
                    _taskDocument.TotalTempoPomodoro = _taskDocument.TotalTempoPomodoro.Add(
                        execucao.ValorTimeSpan
                    );
                    break;
                }
                case TipoExecucaoCronometro.ParadaCurta:
                {
                    _taskDocument.TotalParadasCurtas += 1;
                    execucao = new ExecucaoTempoDto
                    {
                        TipoExecucao = _taskDocument.TipoTempoParadaCurta,
                        Tempo = _taskDocument.TempoParadaCurta,
                        ValorTimeSpan = ObterTempo(_taskDocument.TipoTempoParadaCurta, _taskDocument.TempoParadaCurta)
                    };
                    _taskDocument.TotalTempoParadas = _taskDocument.TotalTempoParadas.Add(
                        execucao.ValorTimeSpan
                    );
                    break;
                }
                case TipoExecucaoCronometro.ParadaLonga:
                {
                    _taskDocument.TotalParadasLongas += 1;
                    execucao = new ExecucaoTempoDto
                    {
                        TipoExecucao = _taskDocument.TipoTempoParadaLonga,
                        Tempo = _taskDocument.TempoParadaLonga,
                        ValorTimeSpan = ObterTempo(_taskDocument.TipoTempoParadaLonga, _taskDocument.TempoParadaLonga)
                    };
                    _taskDocument.TotalTempoParadas = _taskDocument.TotalTempoParadas.Add(
                        execucao.ValorTimeSpan
                    );
                    break;
                }
                default:
                {
                    break;
                }
            }
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
                            FormatarValorCronometro(_taskDocument.TipoTempoPomodoro);
                            break;
                        }
                        case TipoExecucaoCronometro.ParadaCurta: {
                            FormatarValorCronometro(_taskDocument.TipoTempoParadaCurta);
                            break;
                        }
                        case TipoExecucaoCronometro.ParadaLonga: {
                            FormatarValorCronometro(_taskDocument.TipoTempoParadaLonga);
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

            lblResumoContadores.Text = $@"{_taskDocument.TotalPomodoros} pomodoros | {_taskDocument.TotalParadasCurtas} paradas curtas | {_taskDocument.TotalParadasLongas} paradas longas";

            var totalTempoPomodoro = _taskDocument.TotalTempoPomodoro;
            var valorTempoTotalPomodoro = $"{totalTempoPomodoro.Days} dias, {totalTempoPomodoro.Hours:00}:{totalTempoPomodoro.Minutes:00}:{totalTempoPomodoro.Seconds:00}";
            var totalTempoParadas = _taskDocument.TotalTempoParadas;
            var valorTempoTotalParada = $"{totalTempoParadas.Days} dias, {totalTempoParadas.Hours:00}:{totalTempoParadas.Minutes:00}:{totalTempoParadas.Seconds:00}";

            lblTotalTempo.Text = $@"{valorTempoTotalPomodoro} Total pomodoros | {valorTempoTotalParada} Total paradas";

            ProcessaCronometro();
        }

        void AtualizaComponentesCasoTaskConcluida()
        {
            txtDescricao.ReadOnly = _taskDocument.Concluida;
            btnIniciarPomodoro.Enabled = !_taskDocument.Concluida;
            btnIniciarParadaCurta.Enabled = !_taskDocument.Concluida;
            btnIniciarParadaLonga.Enabled = !_taskDocument.Concluida;
            btnAddPomodoro.Enabled = !_taskDocument.Concluida;
            btnMinusPomodoro.Enabled = !_taskDocument.Concluida;
        }

        void AtualizaComponentesComTaskDocument()
        {
            txtDescricao.Text = _taskDocument.Descricao;
            ckbConcluida.Checked = _taskDocument.Concluida;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            AtualizaInfoDia();

            if ((ckbAlwaysOnTop.Checked && !this.TopMost) || (ckbAlwaysOnTop.Checked && !this._frmConfiguracao.TopMost))
            {
                this.TopMost = ckbAlwaysOnTop.Checked;
                this._frmConfiguracao.TopMost = ckbAlwaysOnTop.Checked;
                this._frmRelatorio.TopMost = ckbAlwaysOnTop.Checked;
                Application.DoEvents();
            }

            if (!_cronometroLigado && !_cronometroParado)
            {
                if (_taskDocument.TotalPomodoros <= 0 && btnMinusPomodoro.Enabled)
                {
                    btnMinusPomodoro.Enabled = false;
                }
                else if (_taskDocument.TotalPomodoros > 0 && !btnMinusPomodoro.Enabled)
                {
                    btnMinusPomodoro.Enabled = true;
                }
            }

            if (!_taskDocument.Concluida) {
                if (!_taskAlterada) {
                    if (string.IsNullOrEmpty(_taskDocument.Descricao) && string.IsNullOrEmpty(txtDescricao.Text)) {
                        return;
                    }
                    if (_taskDocument.Descricao != txtDescricao.Text) {
                        _taskAlterada = true;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaInfoDia();
            tmrHora.Enabled = true;
            ckbConcluida.Checked = _taskDocument.Concluida;
        }

        private void btnIniciarPomodoro_Click(object sender, EventArgs e)
        {
            _dataGatilhoInicio = DateTime.Now;
            switch (_taskDocument.TipoTempoPomodoro)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        _dataAlvoFim = DateTime.Now.AddSeconds(_taskDocument.TempoPomodoro);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        _dataAlvoFim = DateTime.Now.AddMinutes(_taskDocument.TempoPomodoro);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _dataAlvoFim = DateTime.Now.AddHours(_taskDocument.TempoPomodoro);
                        break;
                    }
                default: {
                    break;
                }
            }
            _tipoExecucao = TipoExecucaoCronometro.Pomodoro;
            _cronometroLigado = true;
            btnParar.Enabled = true;
            btnIniciarPomodoro.Enabled = false;
            btnIniciarParadaCurta.Enabled = false;
            btnIniciarParadaLonga.Enabled = false;

            btnAddPomodoro.Enabled = false;
            btnMinusPomodoro.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAbrir.Enabled = false;
            btnSair.Enabled = false;
            btnConfiguracao.Enabled = false;
            ckbConcluida.Enabled = false;
            btnRelatorio.Enabled = false;

            this.MinimizeBox = false;
        }

        private void btnIniciarParadaCurta_Click(object sender, EventArgs e)
        {
            _dataGatilhoInicio = DateTime.Now;
            switch (_taskDocument.TipoTempoParadaCurta)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        _dataAlvoFim = DateTime.Now.AddSeconds(_taskDocument.TempoParadaCurta);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        _dataAlvoFim = DateTime.Now.AddMinutes(_taskDocument.TempoParadaCurta);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _dataAlvoFim = DateTime.Now.AddHours(_taskDocument.TempoParadaCurta);
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
            btnIniciarPomodoro.Enabled = false;
            btnIniciarParadaCurta.Enabled = false;
            btnIniciarParadaLonga.Enabled = false;

            btnAddPomodoro.Enabled = false;
            btnMinusPomodoro.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAbrir.Enabled = false;
            btnSair.Enabled = false;
            btnConfiguracao.Enabled = false;
            ckbConcluida.Enabled = false;
            btnRelatorio.Enabled = false;

            this.MinimizeBox = false;
        }

        private void btnIniciarParadaLonga_Click(object sender, EventArgs e)
        {
            _dataGatilhoInicio = DateTime.Now;

            switch (_taskDocument.TipoTempoParadaLonga)
            {
                case TipoExecucaoTempo.Segundos:
                    {
                        _dataAlvoFim = DateTime.Now.AddSeconds(_taskDocument.TempoParadaLonga);
                        break;
                    }
                case TipoExecucaoTempo.Minutos:
                    {
                        _dataAlvoFim = DateTime.Now.AddMinutes(_taskDocument.TempoParadaLonga);
                        break;
                    }
                case TipoExecucaoTempo.Horas:
                    {
                        _dataAlvoFim = DateTime.Now.AddHours(_taskDocument.TempoParadaLonga);
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
            btnIniciarPomodoro.Enabled = false;
            btnIniciarParadaCurta.Enabled = false;
            btnIniciarParadaLonga.Enabled = false;

            btnAddPomodoro.Enabled = false;
            btnMinusPomodoro.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAbrir.Enabled = false;
            btnSair.Enabled = false;
            btnConfiguracao.Enabled = false;
            ckbConcluida.Enabled = false;
            btnRelatorio.Enabled = false;

            this.MinimizeBox = false;
        }

        private void btnParar_Click(object sender, EventArgs e) {
            _cronometroLigado = false;
            _cronometroParado = true;
            btnZerar.Enabled = true;
            btnContinuar.Enabled = true;
            btnParar.Enabled = false;

            this.MinimizeBox = true;
        }

        void ZerarInformacoes()
        {
            _cronometroLigado = false;
            _cronometroParado = false;
            _valorCronometro = "00:00";
            btnIniciarPomodoro.Enabled = true;
            btnIniciarParadaCurta.Enabled = true;
            btnIniciarParadaLonga.Enabled = true;
            btnContinuar.Enabled = false;
            btnParar.Enabled = false;
            btnZerar.Enabled = false;
            _dataGatilhoInicio = null;
            _dataAlvoFim = null;
            btnConfiguracao.Enabled = true;
            ckbConcluida.Enabled = true;

            btnAddPomodoro.Enabled = true;
            if (_taskDocument.TotalPomodoros > 0) btnMinusPomodoro.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnAbrir.Enabled = true;
            btnSair.Enabled = true;
            ckbConcluida.Enabled = true;
            btnRelatorio.Enabled = true;

            this.MinimizeBox = true;
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            ZerarInformacoes();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (_cronometro.HasValue) {
                _dataGatilhoInicio = DateTime.Now;
                _dataAlvoFim = DateTime.Now.Add(_cronometro.Value);
            }
            _cronometroLigado = true;
            _cronometroParado = false;
            btnContinuar.Enabled = false;
            btnZerar.Enabled = false;
            btnParar.Enabled = true;
            btnNovo.Enabled = false;

            this.MinimizeBox = false;
        }

        DialogResult VerificarTarefaAlterada()
        {
            if (!_taskAlterada) return DialogResult.OK;
            var result = MessageBox.Show("Deseja salvar as alterações da tarefa atual?", "Pomodoro cronometro",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            return result;
        }

        DialogResult FluxoVerificarSalvarTarefaAtual()
        {
            var result = VerificarTarefaAlterada();
            switch(result)
            {
                case DialogResult.Yes:
                    {
                        return FluxoSalvarTarefa(false);
                    }
                default:
                {
                    return DialogResult.OK;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var result = FluxoVerificarSalvarTarefaAtual();

            if (result == DialogResult.Cancel) return;

            _taskDocument = new TaskPomodoroJsonDto {
                TempoPomodoro = _taskDocument.TempoPomodoro,
                TempoParadaCurta = _taskDocument.TempoParadaCurta,
                TempoParadaLonga = _taskDocument.TempoParadaLonga,
                TextoConclusao = _taskDocument.TextoConclusao,
                TipoTempoParadaCurta = _taskDocument.TipoTempoParadaCurta,
                TipoTempoParadaLonga = _taskDocument.TipoTempoParadaLonga,
                TipoTempoPomodoro = _taskDocument.TipoTempoPomodoro,
            };
            AtualizaComponentesComTaskDocument();
            _arquivoJson = String.Empty;
            _taskAlterada = false;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cronometroLigado)
            {
                e.Cancel = true;
                return;
            }

            var result = FluxoVerificarSalvarTarefaAtual();

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            result = MessageBox.Show("Deseja realmente sair?", "Pomodoro cronometro",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        DialogResult FluxoSalvarTarefa(bool mostrarMsgSucesso = true)
        {
            if (string.IsNullOrEmpty(_arquivoJson))
            {
                saveDialog.FileName = $"task-pomodoro-{DateTime.Now:ddMMyyyy}-{DateTime.Now:HHmmss}.json";
                if (saveDialog.ShowDialog() == DialogResult.OK) {
                    _arquivoJson = saveDialog.FileName;
                } else
                {
                    return DialogResult.Cancel;
                }
            }

            if (string.IsNullOrEmpty(_arquivoJson))
            {
                return DialogResult.Cancel;
            }

            _taskDocument.Descricao = txtDescricao.Text;

            using (FileStream fs = File.Create(_arquivoJson)) {
                var stringJson = JsonConvert.SerializeObject(_taskDocument, Formatting.Indented);
                byte[] info = new UTF8Encoding(true).GetBytes(stringJson);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            _taskAlterada = false;
            if (mostrarMsgSucesso) MessageBox.Show("Tarefa salva com sucesso!", "Pomodoro Cronometro");

            return DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            FluxoSalvarTarefa();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK) {
                _arquivoJson = openDialog.FileName;
            } else
            {
                return;
            }

            if (string.IsNullOrEmpty(_arquivoJson)) return;

            var jsonString = File.ReadAllText(_arquivoJson);
            _taskDocument = JsonConvert.DeserializeObject<TaskPomodoroJsonDto>(jsonString);

            AtualizaComponentesComTaskDocument();

            _taskAlterada = false;
        }

        private void ckbConcluida_CheckedChanged(object sender, EventArgs e)
        {
            _taskDocument.Concluida = ckbConcluida.Checked;
            AtualizaComponentesCasoTaskConcluida();
            _taskAlterada = true;
        }

        private void btnAddPomodoro_Click(object sender, EventArgs e)
        {
            _tipoExecucao = TipoExecucaoCronometro.Pomodoro;
            ContabilizarTempo();
            _taskAlterada = true;
        }

        private void btnMinusPomodoro_Click(object sender, EventArgs e)
        {
            _tipoExecucao = TipoExecucaoCronometro.Pomodoro;
            ContabilizarDiminuicaoTempo();
            _taskAlterada = true;
        }

        void ContabilizarDiminuicaoTempo()
        {
            if (_taskDocument.TotalPomodoros <= 0) return;
            ExecucaoTempoDto execucao;
            switch (_tipoExecucao)
            {
                case TipoExecucaoCronometro.Pomodoro:
                    {
                        _taskDocument.TotalPomodoros -= 1;
                        execucao = new ExecucaoTempoDto
                        {
                            TipoExecucao = _taskDocument.TipoTempoPomodoro,
                            Tempo = _taskDocument.TempoPomodoro,
                            ValorTimeSpan = ObterTempo(_taskDocument.TipoTempoPomodoro, _taskDocument.TempoPomodoro),
                            Tipo = TipoExecucaoTempoEnum.Removido
                        };
                        _taskDocument.TotalTempoPomodoro = _taskDocument.TotalTempoPomodoro.Subtract(
                            execucao.ValorTimeSpan
                        );
                        if (_taskDocument.TotalTempoPomodoro < TimeSpan.Zero)
                        {
                            _taskDocument.TotalTempoPomodoro = TimeSpan.Zero;
                            _taskDocument.TotalPomodoros = 0;
                        }
                        break;
                    }
                case TipoExecucaoCronometro.ParadaCurta:
                    {
                        _taskDocument.TotalParadasCurtas -= 1;
                        execucao = new ExecucaoTempoDto
                        {
                            TipoExecucao = _taskDocument.TipoTempoParadaCurta,
                            Tempo = _taskDocument.TempoParadaCurta,
                            ValorTimeSpan = ObterTempo(_taskDocument.TipoTempoParadaCurta, _taskDocument.TempoParadaCurta),
                            Tipo = TipoExecucaoTempoEnum.Removido
                        };
                        _taskDocument.TotalTempoParadas = _taskDocument.TotalTempoParadas.Subtract(
                            execucao.ValorTimeSpan
                        );
                        if (_taskDocument.TotalTempoParadas < TimeSpan.Zero)
                        {
                            _taskDocument.TotalTempoParadas = TimeSpan.Zero;
                            _taskDocument.TotalParadasCurtas = 0;
                        }
                        break;
                    }
                case TipoExecucaoCronometro.ParadaLonga:
                    {
                        _taskDocument.TotalParadasLongas -= 1;
                        execucao = new ExecucaoTempoDto
                        {
                            TipoExecucao = _taskDocument.TipoTempoParadaLonga,
                            Tempo = _taskDocument.TempoParadaLonga,
                            ValorTimeSpan = ObterTempo(_taskDocument.TipoTempoParadaLonga, _taskDocument.TempoParadaLonga),
                            Tipo = TipoExecucaoTempoEnum.Removido,
                        };
                        _taskDocument.TotalTempoParadas = _taskDocument.TotalTempoParadas.Subtract(
                            execucao.ValorTimeSpan
                        );
                        if (_taskDocument.TotalTempoParadas < TimeSpan.Zero)
                        {
                            _taskDocument.TotalTempoParadas = TimeSpan.Zero;
                            _taskDocument.TotalParadasLongas = 0;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            _frmRelatorio.ShowDialog();
        }
    }
}
