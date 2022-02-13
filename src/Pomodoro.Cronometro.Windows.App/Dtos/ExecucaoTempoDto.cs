using Pomodoro.Cronometro.Windows.App.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pomodoro.Cronometro.Windows.App.Dtos
{
    public class ExecucaoTempoDto
    {
        public TipoExecucaoTempo TipoExecucao { get; set; }
        public int Tempo { get; set; }
        public TimeSpan ValorTimeSpan { get; set; }
    }
}
