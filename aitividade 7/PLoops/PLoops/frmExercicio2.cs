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
    public partial class frmExercicio2 : Form
    {
        int NumeroN;
        
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroN.Text, out NumeroN)) 
            {
                MessageBox.Show("Número N inválido");
                txtNumeroN.Focus();
            }
            else
            {
                double H = 0;
                for (double i =1; i <= NumeroN;i++)
                {
                    H += 1 / i;
                }
                MessageBox.Show($"O número H é: {H}");
            }
        }
    }
}
