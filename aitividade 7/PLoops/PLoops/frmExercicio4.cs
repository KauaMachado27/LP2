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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnSalarioBruto_Click(object sender, EventArgs e)
        {
            double Salario, Gratificacao, SalarioB, Producao, B, C, D;
            B = 0;
            C = 0;
            D = 0;


            if (!double.TryParse(txtProducao.Text, out Producao))
            {
                MessageBox.Show("Produção inválida");
                txtProducao.Focus();
            }
            if (!double.TryParse(txtGratificacao.Text, out Gratificacao))
            {
                MessageBox.Show("Gratificação inválida");
                txtGratificacao.Focus();
            }
            if (!double.TryParse(txtSalario.Text, out Salario))
            {
                MessageBox.Show("Salário inválido");
                txtSalario.Focus();
            }
            else
            {
                if (Producao >= 100)
                    B = 1;
                if (Producao >= 120)
                    C = 1;
                if (Producao >= 150)
                {
                    B = 1;
                    C = 1;
                    D = 1;
                   
                }
                double X = (0.05 * B) + (0.1 * C) + (0.1 * D);
                SalarioB = Salario + Salario * X + Gratificacao;

                if (SalarioB > 7000 || Producao >= 150 || Gratificacao != 0)
                {
                
                }
                else if (SalarioB > 7000)
                {
                    SalarioB = 7000;
                }
                MessageBox.Show($"O Salário Bruto é: {SalarioB}");
            }
        }
    }
}
