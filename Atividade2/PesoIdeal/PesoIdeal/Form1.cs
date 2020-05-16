using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, pesoAtual;
            double pesoIdeal;

            if(double.TryParse(mskAltura.Text, out altura) && double.TryParse(mskPeso.Text, out pesoAtual)) //TryParse converte
            {
                if(rbtFeminino.Checked)
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                else
                {
                    pesoIdeal = (72.7 * altura) - 58;
                }
                
                pesoIdeal = Math.Round(pesoIdeal, 2); //arredondando p/ 2 casas decimais
                MessageBox.Show(pesoIdeal.ToString());

                if(pesoAtual < pesoIdeal)
                {
                    MessageBox.Show("Você está abaixo do peso ideal! Pode comer mais massas e doces!", "Abaixo do Peso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(pesoAtual == pesoIdeal)
                {
                    MessageBox.Show("Você alcançou o peso ideal! Muito bem, continue assim!", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você está acima do peso ideal! Se atente ao que está comendo, talvez precise de um regime!", "Acima do Peso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Necessário preencher todas as informações.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
