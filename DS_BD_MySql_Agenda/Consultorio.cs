using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_BD_MySql_Agenda
{
    public partial class Consultorio : Form
    {
        public Consultorio()
        {
            InitializeComponent();
        }

        private void Consultorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela "dataSet_Agenda.Pessoa". Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string vFiltro = "";
            vFiltro = cmbColuna.Text;

            switch (cmbCondicao.Text)
            {
                case "Todos":
                    vFiltro = "";
                    break;

                case "Igual a":

                    break;

                case "Contém":
                    vFiltro += $" like '%{txtValor1.Text}%'";
                    break;

                case "Termina":

                    break;

                case "Começa":

                    break;

                case "Esteja entre":

                    break;
            }


        }
    }
}
