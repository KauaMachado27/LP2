using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLoops
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnVazios_Click(object sender, EventArgs e)
        {
            int espaços = 0;
            for (var i = 0; i < rchtxtFrase.TextLength; i++)
            {
                if (Char.IsWhiteSpace(rchtxtFrase.Text[i]))
                {
                    espaços++;
                }
                i++;
            }
            MessageBox.Show($"O número de espaços brancos é: {espaços}");
        
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int tamanho = rchtxtFrase.TextLength;
            int contaR = 0;
            int i = 0;
            while (i < tamanho)
            {
                if (Char.IsLetter(rchtxtFrase.Text[i]))
                {
                    if (rchtxtFrase.Text[i] == 'R') {
                        contaR++;
                    }
                    if (rchtxtFrase.Text[i] == 'r')
                    {
                        contaR++;
                    }
                }
                i++;
            }
            MessageBox.Show($"Quantidade de letras R é: {contaR}");
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int i = 1;
            int pares = 0;
            foreach( char elementos in rchtxtFrase.Text)
            {

                if (rchtxtFrase.Text[i - 1]== rchtxtFrase.Text[i])
                {
                    pares++;
                }
                i++;
            }
            MessageBox.Show($"Quantidade de pares é: {pares}");
        }
    }
}
