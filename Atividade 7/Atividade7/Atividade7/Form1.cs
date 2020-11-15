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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            if (rchText.Text.Length <= 100)
            {
                int cont = 0;
                int HaveSpace = 0;
                String text = rchText.Text;
                while (cont < rchText.Text.Length)
                {
                    if (char.IsWhiteSpace(text[cont]))
                    {
                        HaveSpace++;
                    }
                    cont++;
                }

                MessageBox.Show("O texto possui " + HaveSpace + " Espaços em branco");
            }
            else {
                MessageBox.Show("O tamanho máximo de leitura é 100 caracteres");
            }

            
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {

            if (rchText.Text.Length <= 100)
            {
                int letterR = 0;
                foreach (char c in rchText.Text.ToUpper())
                {
                    if (c == 'R')
                    {
                        letterR++;
                    }
                }

                MessageBox.Show("o texto possui " + letterR + " letras R");
            }
            else
            {
                MessageBox.Show("O tamanho máximo de leitura é 100 caracteres");
            }


          
        }

        private void btnPar_Click(object sender, EventArgs e)
        {



            if (rchText.Text.Length <= 100)
            {
                int cont = 1;
                int par = 0;
                String text = rchText.Text;
                while (cont < text.Length)
                {
                    if (text[cont] == text[cont - 1])
                    {
                        par++;
                    }
                    cont++;
                }
                MessageBox.Show("No texto há " + par + " pares de letras");
            }
            else
            {
                MessageBox.Show("O tamanho máximo de leitura é 100 caracteres");
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
