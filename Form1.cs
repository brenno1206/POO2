using Fintech.Controller;
using Fintech.Entities;
using Fintech.View;
using System.Threading.Tasks;

namespace Fintech
{
    public partial class Form1 : Form
    {
        private readonly FintechController _fintechController;
        public Form1()
        {
            InitializeComponent();
            _fintechController = new();

        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string senha = TextBoxSenha.Text;
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

            bool loginSucesso = _fintechController.Login(login, senha, bancoSelecionado.Id);

            if (loginSucesso)
            {
                MessageBox.Show($"Bem-vindo, {_fintechController.ClienteLogado.Nome}!");
                this.Hide();
                using (Contas contas = new Contas(_fintechController))
                {
                    contas.ShowDialog();
                }
                _fintechController.Deslogar();
                TextBoxLogin.Text = "";
                TextBoxSenha.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Login, senha ou banco incorretos.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (View.Cadastro cadastro = new(_fintechController))
            {
                cadastro.ShowDialog();
            }

            this.Show();
        }
    }
}
