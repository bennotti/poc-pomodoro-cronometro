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
        private IList<ArquivoTaskDto> _arquivos;

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

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                MessageBox.Show("Informe a pasta das tarefas!");
                return;
            }
            _arquivos = new List<ArquivoTaskDto>();
            string[] arquivos = Directory.GetFiles(txtDiretorio.Text, "*.json");
            foreach (string arquivo in arquivos)
            {
                _arquivos.Add(new ArquivoTaskDto
                {
                    Nome = Path.GetFileNameWithoutExtension(arquivo),
                    Situacao = "Pendente"
                });
            }

            dgvArquivos.DataSource = new BindingList<ArquivoTaskDto>(_arquivos);
            dgvArquivos.Enabled = true;
            btnRemover.Enabled = true;
            btnMarcarComoConcluido.Enabled = true;
            gbFiltro.Enabled = true;
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            txtDiretorio.Text = String.Empty;
        }
    }
}
