using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double descontoINSS = 0;
            double descontoIRPF = 0;
            double salarioLiquido = 0;
            double salarioBruto = 0;
            double salarioFamilia = 0;
            double numeroFilhos = 0;

            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Nome não pode estar vazio!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                if(!double.TryParse(mskSalario.Text, out salarioBruto) 
                    || !double.TryParse(txtFilhos.Text, out numeroFilhos))
                {
                    MessageBox.Show("Salário bruto e número de filhos devem ser númericos!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //INSS
                    if(salarioBruto <= 1045)
                    {
                        txtAliquotaINSS.Text = "7,5%";
                        descontoINSS = 0.075 * salarioBruto;
                    }
                    else if (salarioBruto <= 2089.6)
                    {
                        txtAliquotaINSS.Text = "9%";
                        descontoINSS = 0.09 * salarioBruto;
                    }
                    else if (salarioBruto <= 3134.4)
                    {
                        txtAliquotaINSS.Text = "12%";
                        descontoINSS = 0.12 * salarioBruto;
                    }
                    else
                    {
                        txtAliquotaINSS.Text = "14%";
                        descontoINSS = 0.14 * salarioBruto;
                    }

                    txtDescINSS.Text = descontoINSS.ToString("N2");

                    //IRPF
                    if (salarioBruto <= 1903.98)
                        txtAliquotaIRPF.Text = "0";

                    else if (salarioBruto <= 2826.65)
                    {
                        txtAliquotaIRPF.Text = "7.5%";
                        descontoIRPF = (salarioBruto * 7.5 / 100);
                    }
                    else if (salarioBruto <= 3751.05)
                    {
                        txtAliquotaIRPF.Text = "15%";
                        descontoIRPF = (salarioBruto * 15 / 100);
                    }
                    else if (salarioBruto <= 4664.68)
                    {
                        txtAliquotaIRPF.Text = "22.5%";
                        descontoIRPF = (salarioBruto * 22.5 / 100);
                    }
                    else
                    {
                        txtAliquotaIRPF.Text = "27.5";
                        descontoIRPF = ((27.5 / 100) * salarioBruto);
                    }

                    txtDescIRPF.Text = descontoIRPF.ToString("N2");

                    //SALÁRIO FAMÍLIA
                    if(numeroFilhos > 0)
                    {
                        if (salarioBruto <= 435.52)
                            salarioFamilia = (22.33 * numeroFilhos);
                        else if (salarioBruto <= 654.61)
                            salarioFamilia = (15.74 * numeroFilhos);
                        else
                            salarioFamilia = 0;
                    }
                    salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
                    txtSalFamilia.Text = salarioFamilia.ToString("N2");
                    txtSalLiquido.Text = salarioLiquido.ToString("N2");

                    //variável = condição ? se verdadeiro : se falso
                    lblDados.Text = "Os descontos do salário " + (rbnFeminino.Checked ? "da Sra. " : "do Sr. ") + 
                        txtNome.Text + "\n" + " que é " + (ckbCasado.Checked ? "Casado(a)" : "Solteiro(a)") + 
                        " e que tem " + Convert.ToString(numeroFilhos) + " filho(s) são:";
                }

        }
    }
}
