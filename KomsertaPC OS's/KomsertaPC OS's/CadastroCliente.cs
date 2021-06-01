using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KomsertaPC_OS_s
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            string nome = nomeText.Text;
            string cpf = cpfText.Text;
            string telefone = telefoneText.Text;

            Cliente cliente = new Cliente(nome, cpf, telefone);

            ClienteRepositorio.Adicionar(cliente);

            MessageBox.Show("Cadastrado com sucesso!");

        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            string cpf = cpfText.Text;

            if (ClienteRepositorio.Remover(cpf))
            {
                MessageBox.Show("Cadastro removido com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível remover o cadastro!");
            }

            
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var form = new ListagemClientes();
            form.Show();
        }
    }
}
