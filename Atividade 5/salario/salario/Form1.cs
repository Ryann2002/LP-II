using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{


    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salBruto = 0;
            double salLiquido = 0 ;
            double salFam = 0;
            double nFilhos = 0;
            double descInss = 0;
            double descIrpf = 0;


            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("O nome do funcionário não pode ser vazio!");
            }
            else {
                try {
                    salBruto = double.Parse(textSalBruto.Text);
                    nFilhos = double.Parse(textFilhos.Text);
                    if (salBruto < 0)
                    {
                        MessageBox.Show("O Salário bruto deve ser maior que 0");
                    }
                    else {
                        if (salBruto <= 800.47)
                        {
                            textINSS.Text = "7,65%";
                            descInss = 0.0765 * salBruto;
                        }
                        else if (salBruto <= 1050)
                        {
                            textINSS.Text = "8,65%";
                            descInss = 0.0865 * salBruto;
                        }
                        else if (salBruto <= 1400.77)
                        {
                            textINSS.Text = "9,00%";
                            descInss = 0.09 * salBruto;
                        }
                        else if (salBruto <= 2800.56)
                        {
                            textINSS.Text = "11,00%";
                            descInss = 0.11 * salBruto;
                        }
                        else {
                            textINSS.Text = "teto";
                            descInss = 308.71;
                        }

                        mskDescINSS.Text = descInss.ToString("N2");
                        ///----------------------------------------------------


                        if (salBruto <= 1257.12)
                        {
                            textIRPF.Text = "Isento";
                            descIrpf = 0;
                        }
                        else if (salBruto <= 2512.08)
                        {
                            textIRPF.Text = "15,00%";
                            descIrpf = 0.15 * salBruto;
                        }
                        else
                        {
                            textIRPF.Text = "27,5%";
                            descIrpf = 0.275 * salBruto;
                        }

                        mskDescIRPF.Text = descIrpf.ToString("N2");
                        ///----------------------------------------------------


                            if (salBruto <= 435.52)
                            {
                                salFam = 22.33 * nFilhos;
                            }
                            else if (salBruto <= 654.61) {
                                salFam = 15.74 * nFilhos;
                            }
                            else {
                                salFam = 0;
                            }

                        textSalFamilia.Text = salFam.ToString("N2");
                        salLiquido = salBruto - descInss - descIrpf + salFam;
                        textSalLiquido.Text = salLiquido.ToString("N2");

                        lblDados.Visible = true;
                        
                        lblDados.Text = "Os descontos do salário" + (rbnM.Checked ? " do Sr. " : " da Sra. ") + txtNome.Text + (rbtCasado.Checked ? ", Casado(a) " : ", Solteiro(a) ") +"\n" + "e com " + Convert.ToString(nFilhos) + " filho(s) são: ";
                    }

                } catch { 
                    MessageBox.Show("O Salário bruto e o número de filhos devem ser númericos!"); }
            }
        }

        private void mskSalBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
