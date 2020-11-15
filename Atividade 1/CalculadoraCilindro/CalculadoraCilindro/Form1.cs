using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
                double raio = double.Parse(txtRaio.Text);
                double altura = double.Parse(txtAlt.Text);

                double calculo = Math.PI * (raio * raio ) * 2 * altura;

                txtVolume.Text = calculo.ToString("N2");

            } catch {
                MessageBox.Show("Valores Inválidos");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
