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
    public partial class OperacionesBasicas : Form
    {
        bool esBin1;
        public OperacionesBasicas()
        {
            InitializeComponent();
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedItem.ToString() == "Binomial")
            {
                esBin1 = true;
                lblA1.Text = "Ingrese a";
                lblB1.Text = "Ingrese b";
            }
            if (cmb1.SelectedItem.ToString() == "Polar")
            {
                esBin = false;
                lblA1.Text = "Ingrese Modulo";
                lblB1.Text = "Ingrese Argumento";
            }
        }

        private void OperacionesBasicas_Load(object sender, EventArgs e)
        {
            esBin = true;
        }

        private void Cmb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
