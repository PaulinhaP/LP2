using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for(var x = 0; x <= rchTexto.Text.Length - 1; x++)
            {
                if (Char.IsNumber(rchTexto.Text[x]))
                    contador += 1;
            }

            MessageBox.Show("Caracteres numéricos: " + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while (x < rchTexto.Text.Length) //faça enquanto...
            {
                //if(rchTexto.Text[x] == ' ').... Ou 

                if(Char.IsWhiteSpace(rchTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco: " + (x + 1));
                    break; //sair da repetição
                }
                x += 1;
            }
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach(char c in rchTexto.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }
            MessageBox.Show("Caracteres alfabéticos: " + contador);
        }
    }
}
