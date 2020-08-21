using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases.ClsGerencia;

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdminTablaPosiciones : Form
    {
        public FrmAdminTablaPosiciones()
        {
            InitializeComponent();
        }

        ClsReportes Tabla = new ClsReportes();

        private void Btn_BuscarID_Click(object sender, EventArgs e)
        {
            if (Txt_IDCampeonato.Text == "")
            {
                MessageBox.Show("No ha Completado el Campo del ID", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tabla.Posiciones_Campeonato(Dgv_TablaPosiciones, Txt_IDCampeonato.Text);
                Txt_IDCampeonato.Clear();
            }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas_Admin/AyudasAdmin.chm", "pg_0029.html");
        }
    }
}
