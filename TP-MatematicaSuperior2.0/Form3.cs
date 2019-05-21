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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(0, 0);
            miComplex.setPolar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            miComplex.polarToBinomial();
            Complex miComplex2 = new Complex(0, 0);
            miComplex2.setPolar(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text));
            miComplex2.polarToBinomial();
            Complex resp = miComplex.addComplex(miComplex2);
            resp.binomialToPolar();
            label1.Text = "[" + resp.getModulo() + " , " + resp.getArgumento() + "]";
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(0, 0);
            miComplex.setPolar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            miComplex.polarToBinomial();
            Complex miComplex2 = new Complex(0, 0);
            miComplex2.setPolar(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text));
            miComplex2.polarToBinomial();
            Complex resp = miComplex.substractComplex(miComplex2);
            resp.binomialToPolar();
            label1.Text = "[" + resp.getModulo() + " , " + resp.getArgumento() + "]";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(0, 0);
            Complex miComplex2 = new Complex(0, 0);

            miComplex.setPolar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            miComplex2.setPolar(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text));
            miComplex.polarToBinomial();
            miComplex2.polarToBinomial();
            Complex resp =  miComplex.multiplyComplex(miComplex2);
            resp.binomialToPolar();
            label1.Text = "[" + resp.getModulo() + " , " + resp.getArgumento() + "]";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(0, 0);
            Complex miComplex2 = new Complex(0, 0);

            miComplex.setPolar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            miComplex.polarToBinomial();
            miComplex2.setPolar(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text));
            miComplex2.polarToBinomial();
            Complex resp = miComplex.divideComplex(miComplex2);
            resp.binomialToPolar();
            label1.Text = "[" + resp.getModulo() + " , " + resp.getArgumento() + "]";
        }

        private void ModoDeCalcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void BinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void NCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void OperacionesAvanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
