using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030481923047
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] Matriz = new double[7, 4];
            double valor, Total = 0;
            int mes = 0, sem = 0;
            string valorSem = "";



            while (mes < 7)
            {
                while (sem < 4)
                {
                    valorSem = Interaction.InputBox("Digite o valor total vendido na semana " + (sem + 1) + " do mês " + (mes + 1) + ": ", "Entrada de Dados");
                    if (valorSem == "")
                    {
                        break;
                    }
                    else if (!double.TryParse(valorSem, out valor))
                    {
                        MessageBox.Show("Digite um valor válido!");
                        sem--;
                    }
                    else
                    {
                        valor = Convert.ToDouble(valorSem);
                        Matriz[mes, sem] = valor;
                    }
                    sem++;
                }
                if (valorSem == "")
                {
                    break;
                }
                sem = 0;
                mes++;
            }
            sem = 0;
            mes = 0;

            while (mes < 7)
            {
                while (sem < 4)
                {

                    lbxTexto.Items.Add("Mês " + (mes + 1) + ", semana " + (sem + 1) + ": R$ " + (Matriz[mes, sem].ToString("N2")));
                    Total = Total + Matriz[mes, sem];
                    sem++;
                }

                lbxTexto.Items.Add("Total do mês " + (mes + 1) + ": R$ " + ((Matriz[mes, 0] + Matriz[mes, 1] + Matriz[mes, 2] + Matriz[mes, 3]).ToString("N2")));
                lbxTexto.Items.Add("*************************************");

                sem = 0;
                mes++;
            }
            lbxTexto.Items.Add("Total final: R$ " + (Total.ToString("N2")));
        }
    }
}
