using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KomsertaPC_OS_s
{
    public partial class ListagemOS : Form
    {
        private ListagemOS()
        {
            InitializeComponent();
        }

        public static ListagemOS listarPago()
        {
            var formListagem = new ListagemOS();

            foreach (Ordem_Serviço ordem in OSRepositorio.ordens)
            {
                if (ordem.Pago.Equals(true))
                {
                    var row = new string[] { ordem.Id.ToString(), ordem.Cliente.Nome, ordem.Item, ordem.Descrição, ordem.Entrada.ToString(), ordem.Valor.ToString(), ordem.Pago.ToString(), ordem.Saída.ToString() };
                    var item = new ListViewItem(row);
                    item.Tag = ordem;
                    formListagem.osListView.Items.Add(item);
                }
                
            }
            return formListagem;
        }

        public static ListagemOS listarNaoPago()
        {
            var formListagem = new ListagemOS();

            foreach (Ordem_Serviço ordem in OSRepositorio.ordens)
            {
                if (ordem.Pago.Equals(false))
                {
                    var row = new string[] { ordem.Id.ToString(), ordem.Cliente.Nome, ordem.Item, ordem.Descrição, ordem.Entrada.ToString(), ordem.Valor.ToString(), ordem.Pago.ToString(), ordem.Saída.ToString() };
                    var item = new ListViewItem(row);
                    item.Tag = ordem;
                    formListagem.osListView.Items.Add(item);
                }

            }
            return formListagem;
        }


        public static ListagemOS listarComSaida()
        {
            var formListagem = new ListagemOS();

            foreach (Ordem_Serviço ordem in OSRepositorio.ordens)
            {
                if (!ordem.Saída.Equals(null))
                {
                    var row = new string[] { ordem.Id.ToString(), ordem.Cliente.Nome, ordem.Item, ordem.Descrição, ordem.Entrada.ToString(), ordem.Valor.ToString(), ordem.Pago.ToString(), ordem.Saída.ToString() };
                    var item = new ListViewItem(row);
                    item.Tag = ordem;
                    formListagem.osListView.Items.Add(item);
                }

            }
            return formListagem;
        }


        public static ListagemOS listarSemSaida()
        {
            var formListagem = new ListagemOS();

            foreach (Ordem_Serviço ordem in OSRepositorio.ordens)
            {
                if (ordem.Saída.Equals(null))
                {
                    var row = new string[] { ordem.Id.ToString(), ordem.Cliente.Nome, ordem.Item, ordem.Descrição, ordem.Entrada.ToString(), ordem.Valor.ToString(), ordem.Pago.ToString(), ordem.Saída.ToString() };
                    var item = new ListViewItem(row);
                    item.Tag = ordem;
                    formListagem.osListView.Items.Add(item);
                }

            }
            return formListagem;
        }

        private void osListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListagemOS_Load(object sender, EventArgs e)
        {

        }
    }
}
