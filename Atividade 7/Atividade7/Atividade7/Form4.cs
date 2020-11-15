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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioB, salarioL, gratificacao;
            int prod;

            try
            {
                prod = int.Parse(txtProd.Text);
                salarioL = double.Parse(txtSal.Text);
                gratificacao = double.Parse(txtGrat.Text);

                int b = 0, c = 0, d = 0;

                if (prod >= 100)
                {
                    b = 1;
                }

                if (prod >= 120) {
                    c = 1;
                }

                if (prod >= 150) {
                    d = 1;
                }

                salarioB = salarioL + salarioL * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                if (salarioB > 7000)
                {
                    if (prod >= 150 && gratificacao > 0)
                        MessageBox.Show("Osalário bruto é: " + salarioB);

                    else
                        MessageBox.Show("Dados incoerentes");

                }
                else {
                    MessageBox.Show("Osalário bruto é: " + salarioB);
                }
            }
            catch {
                MessageBox.Show("Valores inválidos");
            }
        }
    }
}
