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
    public partial class Form4 : Form
    {
        Double n;
        Complex pot;
        Complex raiz;
        Double arg;
        public bool esBin;
        public Form4()
        {
            InitializeComponent();
        }

    

        private void Form4_Load(object sender, EventArgs e)
        {
            esBin = true;
        }

        private void BtnCalcularPot_Click(object sender, EventArgs e)
        {
            lblRta.Text = "Respuesta: ";
            Complex miComplex = new Complex(0,0);
            if(txtN.Text == "" || txtA1.Text == "" || txtB1.Text == "")
            {                
                MessageBox.Show("Faltan datos");
            }
            else
            {
                n = Convert.ToInt32(txtN.Text);
                if (esBin)
                {
                    miComplex.setBinomial(Convert.ToDouble(txtA1.Text), Convert.ToDouble(txtB1.Text));
                    miComplex.binomialToPolar();
                    pot = miComplex.potencia(n);
                    pot.polarToBinomial();
                    lblRta.Text += Math.Round(pot.getA(),2).ToString() + " " + Math.Round(pot.getB(),2).ToString() + "j";
                }
                else
                {
                    miComplex.setPolar(Convert.ToDouble(txtA1.Text), Convert.ToDouble(txtB1.Text));
                    pot = miComplex.potencia(n);
                    arg = pot.getArgumento() / Math.PI;
                    lblRta.Text += "[" + Math.Round(pot.getModulo(),2) + " , " + Math.Round(arg,2) + " π" + "]";
                }

            }
           
            
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb1.SelectedItem.ToString() == "Binomial")
            {
                esBin = true;
                lblA1.Text = "Ingrese a";
                lblB1.Text = "Ingrese b";
            }
            if(cmb1.SelectedItem.ToString() == "Polar")
            {
                esBin = false;
                lblA1.Text = "Ingrese Modulo";
                lblB1.Text = "Ingrese Argumento";
            }
        }

        private void Cmb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnCalcularRaiz_Click(object sender, EventArgs e)
        {
            lblRta.Text = "Respuesta: ";
            Complex miComplex = new Complex(0, 0);
            if (txtN.Text == "" || txtA1.Text == "" || txtB1.Text == "")
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                n = Convert.ToInt32(txtN.Text);
                if (esBin)
                {
                    miComplex.setBinomial(Convert.ToDouble(txtA1.Text), Convert.ToDouble(txtB1.Text));
                    miComplex.binomialToPolar();
                    raiz = miComplex.raiz(n);
                    raiz.polarToBinomial();
                    lblRta.Text = Math.Round(raiz.getA(),2).ToString() + " + " + Math.Round(raiz.getB(),2).ToString() + " j";
                }
                else
                {
                    miComplex.setPolar(Convert.ToDouble(txtA1.Text), Convert.ToDouble(txtB1.Text));
                    raiz = miComplex.raiz(n);
                    arg = raiz.getArgumento() / Math.PI;
                    lblRta.Text += "[" + Math.Round(raiz.getModulo(),2).ToString() + " , " + Math.Round(arg,2).ToString() + " π" + "]";
                }

            }


        }

        private void BinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void PolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void NCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
