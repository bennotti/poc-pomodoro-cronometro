using Pomodoro.Cronometro.Windows.App.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pomodoro.Cronometro.Windows.App.Dtos
{
    public sealed class TaskPomodoroJsonDto
    {
        public bool Concluida { get; set; }
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
        public string Descricao { get; set; }
        public int TotalPomodoros { get; set; }
        public int TotalParadasCurtas { get; set; }
        public int TotalParadasLongas { get; set; }
        public IList<ExecucaoTempoDto> ExecucoesPomodoro { get; set; } = new List<ExecucaoTempoDto>();
        public IList<ExecucaoTempoDto> ExecucoesParadasCurtas { get; set; } = new List<ExecucaoTempoDto>();
        public IList<ExecucaoTempoDto> ExecucoesParadasLongas { get; set; } = new List<ExecucaoTempoDto>();
        public TimeSpan TotalTempoPomodoro { get; set; }
        public TimeSpan TotalTempoParadas { get; set; }
        public int TempoPomodoro { get; set; } = 25;
        public int TempoParadaCurta { get; set; } = 5;
        public int TempoParadaLonga { get; set; } = 15;
        public string TextoConclusao { get; set; } = "Tempo concluído.";
        public TipoExecucaoTempo TipoTempoPomodoro { get; set; } = TipoExecucaoTempo.Minutos;
        public TipoExecucaoTempo TipoTempoParadaCurta { get; set; } = TipoExecucaoTempo.Minutos;
        public TipoExecucaoTempo TipoTempoParadaLonga { get; set; } = TipoExecucaoTempo.Minutos;
    }
}
