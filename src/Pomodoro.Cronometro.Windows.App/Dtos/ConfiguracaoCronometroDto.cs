using System;
using System.Collections.Generic;
using System.Text;

namespace Pomodoro.Cronometro.Windows.App.Dtos
{
    public class ConfiguracaoCronometroDto
    {
        public string TextoConclusao { get; set; }
        public int TempoPomodoro { get; set; }
        /// <summary>
        /// 0 - segundos
        /// 1 - minutos
        /// 2 - horas
        /// </summary>
        public int IndexTipoTempoPomodoro { get; set; }
        public int TempoParadaCurta { get; set; }
        /// <summary>
        /// 0 - segundos
        /// 1 - minutos
        /// 2 - horas
        /// </summary>
        public int IndexTipoTempoParadaCurta { get; set; }
        public int TempoParadaLonga { get; set; }
        /// <summary>
        /// 0 - segundos
        /// 1 - minutos
        /// 2 - horas
        /// </summary>
        public int IndexTipoTempoParadaLonga { get; set; }
    }
}
