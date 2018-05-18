using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class fmPesquisar : Form
    {
        public fmPesquisar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmPesquisar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            fmPesquisarPessoas pesqPessoas = new fmPesquisarPessoas();

            pesqPessoas.StartPosition = FormStartPosition.CenterScreen;

            pesqPessoas.Show();

            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmPesquisarAnimais pesqAnimais = new fmPesquisarAnimais();

            pesqAnimais.StartPosition = FormStartPosition.CenterScreen;

            pesqAnimais.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmPesquisarProdutos pesqProdutos = new fmPesquisarProdutos();

            pesqProdutos.StartPosition = FormStartPosition.CenterScreen;

            pesqProdutos.Show();

            this.Close();
        }

        private void btnPesquisarConsultas_Click(object sender, EventArgs e)
        {
            fmPesquisarConsultas pesqConsultas = new fmPesquisarConsultas();

            pesqConsultas.StartPosition = FormStartPosition.CenterScreen;

            pesqConsultas.Show();

            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
