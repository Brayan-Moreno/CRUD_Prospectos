using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Prospectos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroProspecto registro = new RegistroProspecto();
            this.Hide();
            registro.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ListadoProspectos listado = new ListadoProspectos();
            this.Hide();
            listado.Show();
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            EvaluacionProspecto evaluar = new EvaluacionProspecto();
            this.Hide();
            evaluar.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
