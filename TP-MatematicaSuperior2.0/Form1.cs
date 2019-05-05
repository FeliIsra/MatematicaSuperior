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

        Complex operando1 = new Complex();
        Complex operando2 = new Complex();

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
                Complex miNum = new Complex();
                miNum.setBinomial(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
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
                Complex miNum = new Complex();
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

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!operando1.isEmpty() && !operando2.isEmpty() )
            {
                operando1.sumBinom(operando2);
                lbl_resultado.Text = Math.Round(operando1.getA()).ToString("N3") + " + " + Math.Round(operando1.getB()).ToString("N3") + " j";
                
            }
            else
            {
                MessageBox.Show("NO SE HA CARGADO BIEN UNO DE LOS DOS OPERANDOS");
            }
            operando1 = new Complex();
            operando2 = new Complex();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("COMPLETE ALGUNO DE LOS DOS PARA PODER OBTENER EL PRIMER OPERANDO");
                }
                else
                {
                    operando1.setPolar(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
                    operando1.polarToBinomial();
                }
            }
            else
            {
                if ((textBox1.Text != "" || textBox2.Text != "" )&& (textBox3.Text != "" || textBox4.Text != ""))
                {
                    MessageBox.Show("SOLO SE PUEDE COMPLETAR UNO DE LOS DOS");
                }
                else
                {
                    operando1.setBinomial(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btnUsar2_Click(object sender, EventArgs e)
        {
            if (txtBinomReal.Text == "" || txtBinomImg.Text == "")
            {
                if (txtPolMod.Text == "" || txtPolArg.Text == "")
                {
                    MessageBox.Show("COMPLETE ALGUNO DE LOS DOS PARA PODER OBTENER EL SEGUNDO OPERANDO");
                }
                else
                {
                    operando2.setPolar(Convert.ToDouble(txtPolMod.Text), Convert.ToDouble(txtPolArg.Text));
                    operando2.polarToBinomial();
                }
            }
            else
            {
                if ((txtBinomReal.Text != "" || txtBinomImg.Text != "" )&& (txtPolMod.Text != "" || txtPolArg.Text != ""))
                {
                    MessageBox.Show("SOLO SE PUEDE COMPLETAR UNO DE LOS DOS");
                }
                else
                {
                    operando2.setBinomial(Convert.ToDouble(txtBinomReal.Text), Convert.ToDouble(txtBinomImg.Text));
                }
            }
            txtBinomImg.Text = "";
            txtBinomReal.Text = "";
            txtPolArg.Text = "";
            txtPolMod.Text = "";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!operando1.isEmpty() && !operando2.isEmpty())
            {
                operando1.resBinom(operando2);
                lbl_resultado.Text = Math.Round(operando1.getA()).ToString("N3") + " + " + Math.Round(operando1.getB()).ToString("N3") + " j";
                
            }
            else
            {
                MessageBox.Show("NO SE HA CARGADO BIEN UNO DE LOS DOS OPERANDOS");
            }
            operando1 = new Complex();
            operando2 = new Complex();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (!operando1.isEmpty() && !operando2.isEmpty())
            {
                operando1.prodBinom(operando2);
                lbl_resultado.Text = Math.Round(operando1.getA()).ToString("N3") + " + " + Math.Round(operando1.getB()).ToString("N3") + " j";
                
            }
            else
            {
                MessageBox.Show("NO SE HA CARGADO BIEN UNO DE LOS DOS OPERANDOS");
            }
            operando1 = new Complex();
            operando2 = new Complex();
        }



    }
}
