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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Visible = false;
           // button2.Visible = false;
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("COMPLETE AMBOS CAMPOS");
            }
            else
            {
                Complex miNum = new Complex(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                miNum.binomialToPolar();
                double arg = miNum.getArgumento() / Math.PI;
                lbl_resultado.Text = "[    " + miNum.getModulo().ToString("N2") + " , " + (arg).ToString("N2") + " π" + "]";
            }
           // textBox1.Text = "";
           // textBox2.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("COMPLETE AMBOS CAMPOS");
            }
            else
            {
                Complex miNum = new Complex(0,0);
                miNum.setPolar(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
                miNum.polarToBinomial();
                lbl_resultado.Text = Math.Round(miNum.getA()).ToString("N3") + " + " + Math.Round(miNum.getB()).ToString("N3") + " j";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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
    }
}
