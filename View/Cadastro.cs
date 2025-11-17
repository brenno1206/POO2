using Fintech.Controller;
using Fintech.Controller;
using Fintech.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fintech.View
{
    public partial class Cadastro : Form
    {
        private FintechController _fintechController;
        public Cadastro(FintechController fintechController)
        {
            InitializeComponent();
            _fintechController = fintechController;
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            string Nome = textBoxNome.Text;
            string Login = TextBoxLogin.Text;
            string Senha = TextBoxSenha.Text;

            Banco? bancoSelecionado = null;
            if (radioButtonBradesco.Checked)
            {
                bancoSelecionado = _fintechController.ObterBancoPorNome("Bradesco");
            }
            else if (radioButtonNubank.Checked)
            {
                bancoSelecionado = _fintechController.ObterBancoPorNome("Nubank");
            }
            else if (radioButtonBanestes.Checked)
            {
                bancoSelecionado = _fintechController.ObterBancoPorNome("Banestes");
            }
            else if (radioButtonBancoB.Checked)
            {
                bancoSelecionado = _fintechController.ObterBancoPorNome("Banco do Brasil");
            }
            else
            {
                MessageBox.Show("Por favor, selecione um banco.");
                return;
            }


            var (sucesso, mensagem) = _fintechController.CadastrarCliente(Nome, Login, Senha, bancoSelecionado.Id);

            if (sucesso)
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); 
            }
            else
            {
                MessageBox.Show(mensagem, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
