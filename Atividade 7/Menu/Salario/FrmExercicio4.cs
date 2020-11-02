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
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contador_Click(object sender, EventArgs e)
        {
            int numbersIn = 0;
            for (var i = 0; i < rchTxt1.Text.Length; i++)
            {
                if (char.IsNumber(rchTxt1.Text[i])) {
                    numbersIn += 1;
                }
                   
            }

            MessageBox.Show("Existem " + numbersIn.ToString()+ " números neste texto");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i<rchTxt1.Text.Length) {
                if (char.IsWhiteSpace(rchTxt1.Text[i]))
                {
                    MessageBox.Show("O primeiro espaço em branco fica na posição: " + i.ToString());
                    break;
                }
                else {
                    i++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (char a in rchTxt1.Text) {
                if (char.IsLetter(a)) {
                    i++;
                }
            }

            MessageBox.Show("Texto com: " + i + " letras");
        }
    }
}
