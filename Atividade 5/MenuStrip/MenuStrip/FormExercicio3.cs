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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >=0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length -
                    posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, ""); //faz o mesmo q está acima
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); //arrey é tipo matriz
            Array.Reverse(arr); //inverte a palavra no arrey
            s = "";
            foreach (char c in arr) //(tipovariável nomevariável in grupovariável)
                s = s + c.ToString();
            MessageBox.Show(s);

            //ou
            /*string ss = txtPalavra1.Text;
            char[] arr1 = ss.ToCharArray();
            Array.Reverse(arr1);
            ss = new string(arr1);
            MessageBox.Show(ss);
            */
        }
    }
}
