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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string invertido = "" , texto = "", comAcentos = "ÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜÃÕÇÝÑ", semAcentos = "AEIOUAEIOUAEIOUAEIOUAOCYN";

            texto = txtTexto.Text;
            if(texto == "")
            {
                MessageBox.Show("Necessário digitar alguma informação para continuar.", "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                texto = texto.ToUpper(); //Tudo em maiúsculo
                texto = texto.Replace(" ", ""); //Tira os espaços
                for (int i = 0; i < comAcentos.Length; i++)
                {
                    texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString()); //Tira acentos
                }
                Array caracteres = texto.ToArray();
                Array.Reverse(caracteres);
                foreach (char caracter in caracteres)
                invertido += caracter.ToString();

                if(invertido == texto)
                {
                    MessageBox.Show("Esta frase é um palíndromo, ou seja, \né idêntica se lida de trás para frente.", "Palíndromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Esta frase NÃO é um palíndromo, ou seja, \nNÃO é idêntica se lida de trás para frente.", "Não é Palíndromo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
