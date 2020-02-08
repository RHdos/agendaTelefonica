using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaTelefonica
{
    public partial class agendaTelefonica : Form
    {
        public agendaTelefonica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adicionarContatoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            adicionarContato add = new adicionarContato();
            add.Show();
        }

        private void buscarContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarContato add = new buscarContato();
            add.Show();
        }
    }
}
