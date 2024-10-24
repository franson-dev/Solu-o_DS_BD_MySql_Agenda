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
    public partial class frmListaPessoas : Form
    {
        public frmListaPessoas()
        {
            InitializeComponent();
        }

        private void frmListaPessoas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
