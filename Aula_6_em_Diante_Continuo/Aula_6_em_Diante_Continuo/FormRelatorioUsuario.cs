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
    public partial class FormRelatorioUsuario: Form
    {
        public FormRelatorioUsuario()
        {
            InitializeComponent();
        }

        private void FormRelatorioUsuario_Load(object sender, EventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            List<Usuario> usuarios = dao.List("");

            RelatorioUsuarios relUsuarios = new RelatorioUsuarios();
            relUsuarios.SetDataSource(usuarios);

            crvUsuarios.ReportSource = relUsuarios;
        }
    }
}
