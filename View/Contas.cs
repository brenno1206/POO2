using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fintech.Controller;
using Fintech.Entities;

namespace Fintech.View
{
    public partial class Contas : Form
    {
        private readonly FintechController _fintechController;

        private ContaCorrente? _contaCorrente;
        private ContaPoupanca? _contaPoupanca;

        public Contas(FintechController fintechController)
        {
            _fintechController = fintechController;
            InitializeComponent();
            AtualizarUI();
        }

        private void Contas_Load(object sender, EventArgs e)
        {
            AtualizarUI();
        }

        private void AtualizarUI()
        {
            (_contaCorrente, _contaPoupanca) = _fintechController.ObterContasDoCliente();

            label1.Text = $"Olá, {_fintechController.ClienteLogado?.Nome}. Suas contas no {_fintechController.BancoDaSessao?.Nome}:";

            if (_contaCorrente != null)
            {
                button1.Visible = true;
                button1.Text = $"Conta Corrente\nNº: {_contaCorrente.Id}\nSaldo: {_contaCorrente.Saldo:C}";
                button3.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button3.Visible = true;
            }

            if (_contaPoupanca != null)
            {
                button2.Visible = true;
                button2.Text = $"Conta Poupança\nNº: {_contaPoupanca.Id}\nSaldo: {_contaPoupanca.Saldo:C}";
                button4.Visible = false;
            }
            else
            {
                button2.Visible = false;
                button4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_contaCorrente == null) return;

            _fintechController.SelecionarConta(_contaCorrente.Id);
            MessageBox.Show($"Conta Corrente Nº {_contaCorrente.Id} selecionada!");

            this.Hide();
            using (var ContaTransacoes = new ContaTransacoes(_fintechController))
            {
                ContaTransacoes.ShowDialog();
            }
            AtualizarUI();
            this.Show();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            var (sucesso, msg) = _fintechController.CriarContaCorrente();
            MessageBox.Show(msg);

            if (sucesso)
            {
                AtualizarUI();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var (sucesso, msg) = _fintechController.CriarContaPoupanca();
            MessageBox.Show(msg);
            if (sucesso)
            {
                AtualizarUI();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_contaPoupanca == null) return;

            _fintechController.SelecionarConta(_contaPoupanca.Id);
            MessageBox.Show($"Conta Poupança Nº {_contaPoupanca.Id} selecionada!");
            this.Hide();
            using (var ContaTransacoes = new ContaTransacoes(_fintechController))
            {
                ContaTransacoes.ShowDialog();
            }
            AtualizarUI();
            this.Show();
        }
    }
}