using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fintech.Controller; // 1. Adicionar o 'using' do Controller

namespace Fintech.View
{
    public partial class ContaTransacoes : Form
    {
        private readonly FintechController _fintechController;

        public ContaTransacoes(FintechController fintechController)
        {
            _fintechController = fintechController;
            InitializeComponent();
            AtualizarUI();
        }
        private void ContaTransacoes_Load(object sender, EventArgs e)
        {
            if (_fintechController.ClienteLogado == null || _fintechController.ContaSelecionada == null)
            {
                MessageBox.Show("Erro: Nenhum cliente ou conta selecionada. Fechando formulário.");
                this.Close();
                return;
            }

            radioButton1.Checked = true;

            AtualizarUI();
        }

        private void AtualizarUI()
        {
            label1.Text = $"Olá, {_fintechController.ClienteLogado?.Nome}";
            label8.Text = $"Saldo: {_fintechController.ContaSelecionada?.Saldo:C}";
            label9.Text = $"Número da Conta: {_fintechController.ContaSelecionada?.Id}";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Por favor, insira um valor positivo válido.");
                return;
            }

            (bool sucesso, string msg) resultado;

            if (radioButton1.Checked)
            {
                resultado = _fintechController.RealizarSaque(valor);
            }
            else if (radioButton2.Checked)
            {
                resultado = _fintechController.RealizarDeposito(valor);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma operação (Sacar ou Depositar).");
                return;
            }

            MessageBox.Show(resultado.msg);

            if (resultado.sucesso)
            {
                AtualizarUI();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int idContaDestino))
            {
                MessageBox.Show("Por favor, insira um Número de conta de destino válido.");
                return;
            }

            if (!decimal.TryParse(textBox3.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Por favor, insira um valor positivo válido para a transferência.");
                return;
            }

            var (sucesso, msg) = _fintechController.RealizarTransferencia(idContaDestino, valor);

            MessageBox.Show(msg);

            if (sucesso)
            {
                AtualizarUI();
            }
        }
    }
}