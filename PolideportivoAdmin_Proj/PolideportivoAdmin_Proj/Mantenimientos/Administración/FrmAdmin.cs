using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Entreador_Click(object sender, EventArgs e)
        {
            Form Entrenador = new FrmAdminEntrenador();
            Entrenador.ShowDialog();
        }

        private void Btn_Equipo_Click(object sender, EventArgs e)
        {
            Form Equipo = new FrmAdminEquipo();
            Equipo.ShowDialog();
        }
    }
}
