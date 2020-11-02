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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            String a = txtnumero1.Text;
            String b = txtNumero2.Text;
            Random rdn = new Random();
          
                try
                {
                    int aInt = Convert.ToInt32(a);
                    int bInt = Convert.ToInt32(b);

                if (bInt > aInt)
                {
                    int r = rdn.Next(aInt, bInt);
                    MessageBox.Show("Valor sorteado: " + r.ToString());
                }
                else {
                    MessageBox.Show("Intervalo inválido");
                }
                
                }
                catch
                {
                    MessageBox.Show("Os valores precisam ser númericos");
                }
            
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
