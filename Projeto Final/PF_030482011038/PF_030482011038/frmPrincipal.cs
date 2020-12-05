using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_030482011038
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro frmCidade = new frmCadastro();
            frmCidade.MdiParent = this;
            frmCidade.WindowState = FormWindowState.Maximized;
            frmCidade.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                
                conexao = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD_PF_LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmAbout"];

            if (fc != null)
                fc.Close();


            frmAbout frm = new frmAbout();
           
            frm.Show();
        }
    }
}
