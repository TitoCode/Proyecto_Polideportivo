using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases.ClsAdmin;

namespace PolideportivoAdmin_Proj.Mantenimientos
{
    public partial class FrmAdminCalendario : Form
    {
        public FrmAdminCalendario()
        {
            InitializeComponent();
        }

        ClsMantenimientosAdmin Admin = new ClsMantenimientosAdmin();

        private void Tmr_Calendario_Tick(object sender, EventArgs e)
        {
            Admin.ListadoPartidos(Dgv_Calendario);
        }

        private void Btn_Ayuda_Calendario_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas_Admin/AyudasAdmin.chm", "pg_0028.html");
        }
    }
}
