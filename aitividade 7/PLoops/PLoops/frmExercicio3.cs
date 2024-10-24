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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            txtFrase.Text = txtFrase.Text.Replace(" ", "").ToUpper();
            char[] vetor = txtFrase.Text.ToCharArray();
            Array.Reverse(vetor);
            string auxiliar = new string(vetor);
         

            if(txtFrase.Text == auxiliar)
            {
                MessageBox.Show("É palíndromo");
            }
            else
            {
                MessageBox.Show("Não é palíndromo");
            }
        }
    }
}
