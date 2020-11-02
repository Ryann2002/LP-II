using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadosDoTriangulo
{
    public partial class Form1 : Form
    {

        double a, b, c;
        bool invalid = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Text = "".ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Math.Abs(double.Parse(textBox1.Text));
                b = Math.Abs(double.Parse(textBox2.Text));
                c = Math.Abs(double.Parse(textBox3.Text));

            }
            catch
            {
                MessageBox.Show("Dados inválidos");
            }

            if (a != 0 || b != 0 || c != 0) {
                

                if (a < Math.Abs(b - c) || a > Math.Abs(b + c))
                {
                    invalid = true;
                }
                else if (b < Math.Abs(a - c) || b > Math.Abs(a + c))
                {
                    invalid = true;
                }
                else if (c < Math.Abs(a - b) || c > Math.Abs(a + b))
                {
                    invalid = true;
                }

                if (invalid)
                {
                    if (a == b && b == c && c == a)
                    {
                        textBox4.Text = "Equilátero";
                    }
                    else if (a != b && b != c && c != a)
                    {
                        textBox4.Text = "Escaleno";
                    }
                    else
                    {
                        textBox4.Text = "Isóceles";
                    }
                }
                else
                {
                    MessageBox.Show("Os dados informados não seguem a regra do triângulo");
                }
            }
            else
            {
                MessageBox.Show("Os lados de um triângulo não podem ser zero");
            }




        }
    }
}
