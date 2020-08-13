using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
        }


        private void Btn_Entrenador_Click(object sender, EventArgs e)
        {
            Form Entrenador = new FrmAdminEntrenador();
            Entrenador.ShowDialog();
        }
    }
}
