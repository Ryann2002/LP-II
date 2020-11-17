using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030482011038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
            //Final RA = 8
            double[,] meses = new double[8, 4];
            string valorSemana;
            double totMes = 0;
            double totTotal = 0;
            

            for (int mes = 0; mes < 8; mes++)
            {

                for (int semana = 0; semana < 4; semana++)
                {
                    valorSemana = Interaction.InputBox("Insira o valor recebido na semana " + (semana + 1)  + " do mes " + (mes + 1), "Digite os valores", "0");
                    double valor;
                    try {
                        valor = Double.Parse(valorSemana);
                        meses[mes, semana] = valor;
                        totMes += valor;
                        totTotal += valor;

                    } catch {

                        MessageBox.Show("Valor Inválido");
                        valor = 0;
                    }

                    lbxResults.BeginUpdate();

                    lbxResults.Items.Add("Total do mes: " + (mes + 1) + " semana " + (semana + 1) + " = " + String.Format("{0:C2}", valor));

                    lbxResults.EndUpdate();
                }

                lbxResults.BeginUpdate();

                lbxResults.Items.Add(">> Total do mês: "  + String.Format("{0:C2}", totMes));
                lbxResults.Items.Add("-----------------------------------");
                lbxResults.EndUpdate();
                totMes = 0;

            }




            lbxResults.BeginUpdate();

            lbxResults.Items.Add(">> Total Geral: " + String.Format("{0:C2}", totTotal));
            lbxResults.Items.Add("-----------------------------------");
            lbxResults.EndUpdate();
            totTotal = 0;


        }
    }
}
