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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            Complex resp = miComplex.addComplex(new Complex(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text)));
            label1.Text = resp.getA() + " " + resp.getB() + "j";
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            Complex resp = miComplex.substractComplex(new Complex(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text)));
            label1.Text = resp.getA() + " " + resp.getB() + "j";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            Complex resp = miComplex.multiplyComplex(new Complex(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text)));
            label1.Text = resp.getA() + " " + resp.getB() + "j";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Complex miComplex = new Complex(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));
            Complex resp = miComplex.divideComplex(new Complex(Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text)));
            label1.Text = resp.getA() + " " + resp.getB() + "j";
        }


        private void PolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void NCOMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void OperacionesAvanzadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void EstructuraDeDatosYTransformacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void OperacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
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
