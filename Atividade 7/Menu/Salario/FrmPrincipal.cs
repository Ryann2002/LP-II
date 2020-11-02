using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou o colar");
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frnExercicio2"];

            if (fc != null)
                fc.Close();
            Frnexercicio2 frmExercicio2 = new Frnexercicio2();
            frmExercicio2.MdiParent = this;
            frmExercicio2.Show();
            frmExercicio2.WindowState = FormWindowState.Maximized;
            
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio3"];

            if (fc != null)
                fc.Close();
            FrmExercicio3 frmExercicio3 = new FrmExercicio3();
            frmExercicio3.MdiParent = this;
            frmExercicio3.Show();
            frmExercicio3.WindowState = FormWindowState.Maximized;
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio4"];

            if (fc != null)
                fc.Close();
            FrmExercicio4 frmExercicio4 = new FrmExercicio4();
            frmExercicio4.MdiParent = this;
            frmExercicio4.Show();
            frmExercicio4.WindowState = FormWindowState.Maximized;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio5"];

            if (fc != null)
                fc.Close();
            FrmExercicio5 frmExercicio5 = new FrmExercicio5();
            frmExercicio5.MdiParent = this;
            frmExercicio5.Show();
            frmExercicio5.WindowState = FormWindowState.Maximized;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frnForm = this;
            frnForm.Close();
        }
    }
}
