using Newtonsoft.Json;
using Pomodoro.Cronometro.Windows.App.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pomodoro.Cronometro.Windows.App
{
    public partial class FrmRelatorio : Form
    {
        private IList<ArquivoTaskDto> _arquivosTask;
        private IList<string> _arquivosJson;
        private RelatorioDocumentDto _relatorioDocumentDto;

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Pomodoro cronometro",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirCaminho_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = folderDialog.SelectedPath;
            }
        }

        TaskPomodoroJsonDto AbrirTaskFileJson(string arquivo)
        {
            var jsonString = File.ReadAllText(arquivo);
            return JsonConvert.DeserializeObject<TaskPomodoroJsonDto>(jsonString);
        }

        void AtualizarInfoTela()
        {
            txtQntArquivos.Text = _relatorioDocumentDto.QntArquivos.ToString();
            txtQntConcluidas.Text = _relatorioDocumentDto.QntConcluidos.ToString();
            txtQntNaoConcluidas.Text = _relatorioDocumentDto.QntPendentes.ToString();
            txtQntPomodoro.Text = _relatorioDocumentDto.QntPomodoro.ToString();
            txtQntParadasCurtas.Text = _relatorioDocumentDto.QntParadaCurta.ToString();
            txtQntParadasLongas.Text = _relatorioDocumentDto.QntParadaLonga.ToString();

            var totalTempoPomodoro = _relatorioDocumentDto.TotalTempoPomodoro;
            var valorTempoTotalPomodoro = string.Empty;
            if (totalTempoPomodoro.Days > 0){
                valorTempoTotalPomodoro = $"{totalTempoPomodoro.Days} dias, ";
            }

            valorTempoTotalPomodoro = $"{valorTempoTotalPomodoro}{totalTempoPomodoro.Hours:00}:{totalTempoPomodoro.Minutes:00}:{totalTempoPomodoro.Seconds:00}";
            
            var totalTempoParadas = _relatorioDocumentDto.TotalTempoParadas;
            var valorTempoTotalParada = string.Empty;
            if (totalTempoParadas.Days > 0)
            {
                valorTempoTotalParada = $"{totalTempoParadas.Days} dias, ";
            }
            valorTempoTotalParada = $"{valorTempoTotalParada}{totalTempoParadas.Hours:00}:{totalTempoParadas.Minutes:00}:{totalTempoParadas.Seconds:00}";

            txtTotalTempoPomodoro.Text = valorTempoTotalPomodoro;
            txtTotalTempoParada.Text = valorTempoTotalParada;
        }

        void CarregarArquivos()
        {
            _relatorioDocumentDto = new RelatorioDocumentDto();
            _arquivosTask = new List<ArquivoTaskDto>();
            _relatorioDocumentDto.QntArquivos = _arquivosJson.Count;

            foreach (string arquivo in _arquivosJson)
            {
                var taskDocument = AbrirTaskFileJson(arquivo);
                _arquivosTask.Add(new ArquivoTaskDto {
                    Nome = Path.GetFileNameWithoutExtension(arquivo),
                    Situacao = taskDocument.Concluida ? "Concluído" : "Pendente"
                });

                if (taskDocument.Concluida) {
                    _relatorioDocumentDto.QntConcluidos += 1;
                } else
                {
                    _relatorioDocumentDto.QntPendentes += 1;
                }

                _relatorioDocumentDto.QntPomodoro += taskDocument.TotalPomodoros;
                _relatorioDocumentDto.QntParadaCurta += taskDocument.TotalParadasCurtas;
                _relatorioDocumentDto.QntParadaLonga += taskDocument.TotalParadasLongas;

                _relatorioDocumentDto.TotalTempoPomodoro = _relatorioDocumentDto.TotalTempoPomodoro.Add(taskDocument.TotalTempoPomodoro);
                _relatorioDocumentDto.TotalTempoParadas = _relatorioDocumentDto.TotalTempoParadas.Add(taskDocument.TotalTempoParadas);
            }

            dgvArquivos.DataSource = new BindingList<ArquivoTaskDto>(_arquivosTask);
            dgvArquivos.Enabled = true;
            btnRemover.Enabled = true;
            btnMarcarComoConcluido.Enabled = true;
            //gbFiltro.Enabled = true;

            AtualizarInfoTela();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                MessageBox.Show("Informe a pasta das tarefas!");
                return;
            }
            
            _arquivosJson = Directory.GetFiles(txtDiretorio.Text, "*.json").ToList();

            CarregarArquivos();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            txtDiretorio.Text = String.Empty;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int rowindex = dgvArquivos.CurrentCell.RowIndex;
            _arquivosJson.RemoveAt(rowindex);
            CarregarArquivos();
        }

        private void btnMarcarComoConcluido_Click(object sender, EventArgs e)
        {
            int rowindex = dgvArquivos.CurrentCell.RowIndex;
            var arquivo = _arquivosJson[rowindex];
            var taskDocument = AbrirTaskFileJson(arquivo);
            taskDocument.Concluida = true;
            using (FileStream fs = File.Create(arquivo))
            {
                var stringJson = JsonConvert.SerializeObject(taskDocument, Formatting.Indented);
                byte[] info = new UTF8Encoding(true).GetBytes(stringJson);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            MessageBox.Show("Tarefa salva com sucesso!", "Pomodoro Cronometro");

            CarregarArquivos();
        }
    }
}
