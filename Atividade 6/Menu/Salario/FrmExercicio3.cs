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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmExercicio3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = txtTexto2.Text.IndexOf(txtTexto1.Text);
            txtResult.Text = txtTexto2.Text.Substring(0, i) + txtTexto2.Text.Substring(i+txtTexto1.Text.Length);
            
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            char[] array = txtTexto1.Text.ToCharArray();
            Array.Reverse(array);

            MessageBox.Show(array.Length.ToString());

            for (int i = 0; i < array.Length; i++)
            {
                txtResult.Text += array[i];
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtTexto2.Text.Replace(txtTexto1.Text, "");
        }
    }
}
