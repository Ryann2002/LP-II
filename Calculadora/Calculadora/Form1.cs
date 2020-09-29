using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double number1, number2;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Clear();
            textBox3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(textBox1.Text, out number1)) && (double.TryParse(textBox2.Text, out number2)))
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                    textBox3.Text = result.ToString();
                }

                else
                {
                    MessageBox.Show("Sinto muito, mas não existe divisão por zero!");
                }
            }
            else
                MessageBox.Show("Opa! números inválidos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(textBox1.Text, out number1)) && (double.TryParse(textBox2.Text, out number2)))
            {
                result = number1 * number2;
                textBox3.Text = result.ToString();
            }
            else
                MessageBox.Show("Opa! números inválidos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(textBox1.Text, out number1)) && (double.TryParse(textBox2.Text, out number2)))
            {
                result = number1 - number2;
                textBox3.Text = result.ToString();
            }
            else
                MessageBox.Show("Opa! números inválidos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(textBox1.Text, out number1)) && (double.TryParse(textBox2.Text, out number2)))
            {
                result = number1 + number2;
                textBox3.Text = result.ToString();
            }
            else
                MessageBox.Show("Opa! números inválidos");
        }
    }
}



