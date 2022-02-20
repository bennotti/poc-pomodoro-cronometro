using Newtonsoft.Json;
using Pomodoro.Cronometro.Windows.App.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        void CarregarArquivos()
        {
            _relatorioDocumentDto = new RelatorioDocumentDto();
            _arquivosTask = new List<ArquivoTaskDto>();
            _arquivosJson = Directory.GetFiles(txtDiretorio.Text, "*.json");

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

            CarregarArquivos();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            txtDiretorio.Text = String.Empty;
        }
    }
}
