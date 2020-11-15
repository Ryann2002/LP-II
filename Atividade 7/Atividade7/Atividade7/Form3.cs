using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            string myText = txtVerificar.Text.ToUpper().Replace(" ", "");
            char[] myArray = myText.ToCharArray();

            Array.Reverse(myArray);
            String myReversedText = "";

            foreach (char c in myArray) {
                myReversedText += c;
            }

            if (String.Compare(myText, myReversedText) == 0)
            {
                MessageBox.Show("É um palíndromo");
            }
            else {
                MessageBox.Show("não é um palíndromo");
            }
        }

        private void txtVerificar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
