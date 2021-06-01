using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KomsertaPC_OS_s
{
    public partial class CadastroOS : Form
    {
        public CadastroOS()
        {
            InitializeComponent();

            foreach (Cliente cliente in ClienteRepositorio.clientes)
            {
                clienteCBX.Items.Add(cliente.Nome);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saidaDate_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            if (clienteCBX.SelectedIndex > -1)
            {
                Ordem_Serviço ordem = new Ordem_Serviço();

                string nome = clienteCBX.SelectedItem.ToString();

                string item = itemText.Text;
                ordem.Item = item;
                string descricao = descricaoText.Text;
                ordem.Descrição = descricao;
                DateTime entrada = entradaDate.Value;
                ordem.Entrada = entrada;
                float valor = (float)valorNumber.Value;
                ordem.Valor = valor;

                if (pagoCKB.Checked)
                {
                    ordem.Pago = true;
                    if (saidaCKB.Checked)
                    {
                        DateTime saida = saidaDate.Value;
                        ordem.Saída = saida;
                    }

                }
                else
                {
                    ordem.Pago = false;

                }

                foreach (Cliente cliente in ClienteRepositorio.clientes)
                {
                    if (cliente.Nome.Equals(nome))
                    {
                        ordem.Cliente = cliente;
                        break;
                    }
                }
                OSRepositorio.Adicionar(ordem);
            }
            else
            {
                MessageBox.Show("Selecione ou Cadastre um Cliente antes!");
            }

        }

        private void Cliente_Click(object sender, EventArgs e)
        {

        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            if (listagemCBX.SelectedIndex.Equals(0))
            {
                var form = ListagemOS.listarPago();
                form.Show();

            }
            else if(listagemCBX.SelectedIndex.Equals(1))
            {
                var form = ListagemOS.listarNaoPago();
                form.Show();

            }
            else if(listagemCBX.SelectedIndex.Equals(2))
            {
                var form = ListagemOS.listarComSaida();
                form.Show();

            }
            else
            {
                var form = ListagemOS.listarSemSaida();
                form.Show();

            }


        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            int id = (int)idNumber.Value;

            if (OSRepositorio.Remover(id))
            {
                MessageBox.Show("Ordem removida com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível remover esta Ordem de Serviço!");
            }
        }

        private void CadastroOS_Load(object sender, EventArgs e)
        {

        }

        private void pagoCKB_CheckedChanged(object sender, EventArgs e)
        {
            if (pagoCKB.Checked)
            {
                saidaCKB.Enabled = true;
            }
            else
            {
                saidaCKB.Enabled = false;
                saidaCKB.Checked = false;
            }
        }
    }
}
