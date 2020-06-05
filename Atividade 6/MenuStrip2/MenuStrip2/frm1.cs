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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            
            int x = 0;

            if (rchTexto.Text == "")
                MessageBox.Show("Necessário digitar alguma informação para continuar.", "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < rchTexto.Text.Length; i++)
                {
                    if (rchTexto.Text[i] == ' ')
                    {
                        x++;
                    }
                }
                if (x < 1)
                {
                    MessageBox.Show("Esta frase não possui nenhum espaço em branco.");
                }
                else if (x == 1)
                {
                    MessageBox.Show("Esta frase possui " + x + " espaço em branco.");
                }
                else
                    MessageBox.Show("Esta frase possui " + x + " espaços em branco.");
            }
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (rchTexto.Text == "")
                MessageBox.Show("Necessário digitar alguma informação para continuar.", "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < rchTexto.Text.Length; i++)
                {
                    if (rchTexto.Text[i] == 'R' || rchTexto.Text[i] == 'r')
                    {
                        x++;
                    }
                }
                if (x < 1)
                {
                    MessageBox.Show("Esta frase não possui letras R.");
                }
                else if (x == 1)
                {
                    MessageBox.Show("Esta frase possui " + x + " R.");
                }
                else
                    MessageBox.Show("Esta frase possui " + x + " Rs.");
            }
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int x = 0, i = 0, j = 1;
            string caracter = rchTexto.Text;

            if (rchTexto.Text == "")
                MessageBox.Show("Necessário digitar alguma informação para continuar.", "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                while (i < rchTexto.Text.Length)
                {
                    if (j < rchTexto.Text.Length)
                    {
                        if (rchTexto.Text[i] == rchTexto.Text[j])
                        {
                            x++;
                        }
                        j++;
                    }
                    else
                        break;
                    i++;
                }
                if (x < 1)
                {
                    MessageBox.Show("Esta frase não possui nenhum par de letras.");
                }
                else if (x == 1)
                {
                    MessageBox.Show("Esta frase possui " + x + " par de letras.");
                }
                else
                    MessageBox.Show("Esta frase possui " + x + " pares de letras.");
            }
        }
    }
}
