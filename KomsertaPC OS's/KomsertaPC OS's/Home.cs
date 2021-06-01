using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomsertaPC_OS_s
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            var form = new CadastroCliente();
            form.Show();

        }

        private void Ordens_Serviço_Click(object sender, EventArgs e)
        {
            CadastroOS form = new CadastroOS();
            form.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
