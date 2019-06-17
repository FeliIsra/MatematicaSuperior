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
                lbl_resultado.Text = "Conversion: " +  "[    " + Math.Round(miNum.getModulo(),2).ToString() + " , " + Math.Round((arg),2).ToString() + " π" + "]";
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
                Complex miNum = new Complex(0, 0);
                miNum.setPolar(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
                miNum.polarToBinomial();
                lbl_resultado.Text = "Conversion: " + Math.Round(miNum.getA(),2).ToString() + " + " + Math.Round(miNum.getB(),2).ToString() + " j";
            }
        }

     

        private void OperacionesAvanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void fasoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void OperacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones_Basicas op_basicas = new Operaciones_Basicas();
            op_basicas.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda help = new Ayuda();
            help.Show();
            this.Hide();
        }
    }
}
