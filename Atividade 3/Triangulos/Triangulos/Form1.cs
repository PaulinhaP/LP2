using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double A, B, C;

            if(!double.TryParse(txtA.Text, out A) || !double.TryParse(txtB.Text, out B) || !double.TryParse(txtC.Text, out C))
                MessageBox.Show("Os valores devem ser numéricos.");
            else
            {
                if(A < (B + C) && A > Math.Abs(B - C) && B < (A + C) && B > Math.Abs(A - C) && C < (A + B) && C > Math.Abs(A - B))
                {
                    if(A == B && B == C)
                        MessageBox.Show("O triângulo é equilátero, pois possui todos os lados iguais!");
                    else if(A == B || A == C || C == B)
                        MessageBox.Show("O triângulo é isóceles, pois possui dois lados iguais!");
                    else
                        MessageBox.Show("O triângulo é escaleno, pois todos os lados são diferentes!");
                }
                else
                    MessageBox.Show("Os valores não formam um triângulo!");
            }
        }
    }
}
