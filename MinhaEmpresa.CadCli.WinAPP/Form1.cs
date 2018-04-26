using Empresa.CadCli.Core.Data.EF.Repositorios;
using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.CadCli.WinAPP
{
    public partial class Form1 : Form
    {

        private readonly FuncionarioRepositorio _funcRepo = new FuncionarioRepositorio();

        public Form1()
        {
            InitializeComponent();
            AtualizarGrid();
            btnNovo.PerformClick();
        }

        private void AtualizarGrid()
        {
            dgvFuncionarios.DataSource = _funcRepo.ObterTodos();
            txtNome.Text = txtIdade.Text = "";
            txtNome.Focus();
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvFuncionarios.SelectedRows)
            {
                txtID.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtIdade.Text = row.Cells["Idade"].Value.ToString();
            }

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0")
            {
                var funcionario = new Funcionario(txtNome.Text, Convert.ToInt32(txtIdade.Text));
                _funcRepo.Adicionar(funcionario);
                MessageBox.Show("Funcionario Adicionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            else
            {
                var funcionario = _funcRepo.ObterPorId(Convert.ToInt32(txtID.Text));
                funcionario.nome = txtNome.Text;
                funcionario.idade = Convert.ToInt32(txtIdade.Text);
                _funcRepo.Atualizar(funcionario);
                MessageBox.Show("Funcionario Atualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var funcionario = _funcRepo.ObterPorId(Convert.ToInt32(txtID.Text));
            if (funcionario != null)
            {
                _funcRepo.Excluir(funcionario);
                MessageBox.Show("Funcionario Excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }
    }
}
