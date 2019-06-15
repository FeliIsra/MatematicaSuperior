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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void BinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PolarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OperacionesAvanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fasoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void binomialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void polarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void operacionesAvanzadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void nCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAngulo1.TextLength != 0 && txtAngulo2.TextLength != 0 
                && txtFrecuencia1.TextLength != 0 && txtFrecuencia2.TextLength != 0
                && txtAmp1.TextLength != 0 && txtAmp2.TextLength != 0)
            {
                Fasor fasor1 = new Fasor(comboBox1.SelectedText,
                                        Convert.ToDouble(txtAmp1.Text),
                                        Convert.ToDouble(txtFrecuencia1.Text),
                                        Convert.ToDouble(txtAngulo1.Text));

                Fasor fasor2 = new Fasor(comboBox2.SelectedText,
                                        Convert.ToDouble(txtAmp2.Text),
                                        Convert.ToDouble(txtFrecuencia2.Text),
                                        Convert.ToDouble(txtAngulo2.Text));

                Fasor resultado = fasor1.sumaDeFasores(fasor1, fasor2);
                if (resultado.getTipo != "no")
                {
                    lblRes.Text = resultado.getAmplitud.ToString() + resultado.getTipo.ToString() +"( "+ resultado.getAmplitud.ToString() + "t + "+  resultado.getAngulo + " )";
                }
                else
                {
                    MessageBox.Show("Operacion no valida");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
