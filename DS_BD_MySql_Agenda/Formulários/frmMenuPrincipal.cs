using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_BD_MySql_Agenda.Formulários
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void listaDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaPessoas objVisualiza = new frmListaPessoas();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }

        private void consutarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultorio objConsulta = new Consultorio();
            objConsulta.MdiParent = this;
            objConsulta.Show();
        }

        private void cadastrarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadastro = new frmCadPessoas();
            objCadastro.MdiParent = this;
            objCadastro.Show();
        }
    }
}
