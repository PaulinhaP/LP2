using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip2
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int N = 0;
            double H = 0;
            if (int.TryParse(txtNumero.Text, out N))
            {
                if (N <= 0)
                {
                    MessageBox.Show("Digite um número maior que zero.");
                }
                else
                {
                    double Nn = N;
                    while (N > 0)
                    {
                        H = H + (1 / Nn);
                        N--;
                        Nn--;
                        H = Math.Round(H, 2);
                    }
                    MessageBox.Show("O resultado da soma das frações é: " + H);
                }
            }
            else
                MessageBox.Show("Necessário digitar um número inteiro!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
