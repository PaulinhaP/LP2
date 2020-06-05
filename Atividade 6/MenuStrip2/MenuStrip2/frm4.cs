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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text, cargo = cmbCargo.Text;
            double salBrutoFinal = 0, salario = 0, gratific = 0;
            int producao = 0, B = 0, C = 0, D = 0;

            double.TryParse(mskSalario.Text, out salario);
            double.TryParse(mskGratificacao.Text, out gratific);
            int.TryParse(mskProducao.Text, out producao);

            if (nome == "" || cargo == "")
            {
                MessageBox.Show("Necessário preencher todas as informações!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (salario == 0)
            {
                MessageBox.Show("Necessário digitar um número maior que zero para continuar!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (producao >= 100)
                {
                    B++;
                }
                if (producao >= 120)
                {
                    C++;
                }
                if (producao >= 150)
                {
                    D++;
                }

                salBrutoFinal = salario + (salario * ((0.05 * B) + (0.1 * C) + (0.1 * D))) + gratific;

                if (salBrutoFinal > 7000 && producao >= 150 && gratific > 0)
                {
                    MessageBox.Show("O salário bruto de " + nome + " no cargo " + cmbCargo + " é: R$ " + salBrutoFinal);
                }
                else if (salBrutoFinal > 7000 && (producao < 150 || gratific <= 0))
                {
                    MessageBox.Show("O salário bruto de " + nome + " no cargo " + cmbCargo + " é: R$ 7.000,00");
                }
                else
                {
                    MessageBox.Show("O salário bruto de " + nome + " é: R$ " + salBrutoFinal);
                }
            }
        }
    }
}
