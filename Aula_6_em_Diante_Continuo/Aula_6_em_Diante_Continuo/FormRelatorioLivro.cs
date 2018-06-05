using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo
{
    public partial class FormRelatorioLivro : Form
    {
        public FormRelatorioLivro()
        {
            InitializeComponent();
        }

        private void FormRelatorioLivro_Load(object sender, EventArgs e)
        {
            LivroDAO lDAO = new LivroDAO();
            List<Livro> livros = lDAO.List("");


            RelatorioAcervo relAcervo = new RelatorioAcervo();
            relAcervo.SetDataSource(livros);
            crvLivros.ReportSource = relAcervo;
        }
    }
}
