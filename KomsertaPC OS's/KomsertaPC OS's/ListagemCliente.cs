using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KomsertaPC_OS_s
{
    public partial class ListagemClientes : Form
    {
        public ListagemClientes()
        {
            InitializeComponent();
        }

        private void ListagemCliente_Load(object sender, EventArgs e)
        {
            foreach (Cliente cliente in ClienteRepositorio.clientes)
            {
                var row = new string[] { cliente.Nome, cliente.Cpf, cliente.Telefone };
                var item = new ListViewItem(row);
                item.Tag = cliente;
                clienteListView.Items.Add(item);
            }

        }
        private void clienteListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
