using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MatematicaSuperior2._0
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void NCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void BinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones_Basicas op_basicas = new Operaciones_Basicas();
            op_basicas.Show();
            this.Hide();
        }

        private void OperacionesAvanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void FasoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda help = new Ayuda();
            help.Show();
            this.Hide();
        }
    }
}
