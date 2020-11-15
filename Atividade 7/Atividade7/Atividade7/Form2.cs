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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "" || txtN.Text == "0")
            {
                MessageBox.Show("Valores inválidos");
                txtN.Clear();
                txtH.Clear();
            }
            else
            {
                try
                {
                    

                    Double h = 0;
                    int n = int.Parse(txtN.Text);
                    for (Double i = 1; i <= n; i++)
                    {
                        h = h + 1 / i;



                    }

                    txtH.Text = h.ToString();
                }
                catch {
                    MessageBox.Show("Valores inválidos");
                    txtN.Clear();
                    txtH.Clear();
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
