using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesoideal2
{
    public partial class Form1 : Form
    {

        double altura, correctPeso, initialPeso;
        public Form1()
        {
            InitializeComponent();
        }


        private double calculate(double altura)
        {
            if (radioButton1.Checked)
            {
                correctPeso = ((62.1 * altura) - 44.7);
            }

            else if (radioButton2.Checked)
            {
                correctPeso = ((72.7 * altura) - 58);
            }

            else
            {
                MessageBox.Show("Acho que você se esqueceu de selecionar seu genêro");
            }
            return correctPeso;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(maskedTextBox3.Text, out altura)) && (double.TryParse(maskedTextBox2.Text, out correctPeso)))
            {
                correctPeso = Math.Round((calculate(altura)), 2);

                MessageBox.Show("Seu peso ideal é " + correctPeso.ToString() + "Kg");

                if (initialPeso < correctPeso)
                {
                    MessageBox.Show("Você está abaixo do IMC, alimente - se melhor");
                }

                else if (initialPeso == correctPeso)
                {
                    MessageBox.Show("Muito bem, você está no seu IMC");
                }

                else
                {
                    MessageBox.Show("Você está acima do peso, alimente - se menos");
                }
            }

            else
            {
                MessageBox.Show("Verifique se todos os campos estão corretos");
            }
        }
    }
}
