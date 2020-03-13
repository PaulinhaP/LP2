using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtAltura.Clear();
            txtVolume.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verifyR, verifyA, volume;

            if ((double.TryParse(txtRaio.Text, out verifyR) && double.TryParse(txtAltura.Text, out verifyA)))
            {
                volume = Math.PI * Math.Pow(verifyR, 2) * verifyA;
                txtVolume.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Dados inválidos! Digite um valor válido!");
        }
    }
}
