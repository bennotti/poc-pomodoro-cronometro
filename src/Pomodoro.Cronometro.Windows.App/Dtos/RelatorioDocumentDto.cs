using System;
using System.Collections.Generic;
using System.Text;

namespace Pomodoro.Cronometro.Windows.App.Dtos
{
    public class RelatorioDocumentDto
    {
        public int QntArquivos { get; set; }
        public int QntConcluidos { get; set; }
        public int QntPendentes { get; set; }
        public int QntPomodoro { get; set; }
        public int QntParadaCurta { get; set; }
        public int QntParadaLonga { get; set; }

        public TimeSpan TotalTempoPomodoro { get; set; } = TimeSpan.Zero;
        public TimeSpan TotalTempoParadas { get; set; } = TimeSpan.Zero;
    }
}
