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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicío1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                MessageBox.Show("Forms já existe");
                Application.OpenForms["frmExercicio1"].BringToFront();
            }
            else
            {
                frmExercicio1 obj1 = new frmExercicio1();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Forms já existe");
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frmExercicio2 obj2 = new frmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                MessageBox.Show("Forms já existe");
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frmExercicio3 obj3 = new frmExercicio3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                MessageBox.Show("Forms já existe");
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frmExercicio4 obj4 = new frmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }
    }
}
