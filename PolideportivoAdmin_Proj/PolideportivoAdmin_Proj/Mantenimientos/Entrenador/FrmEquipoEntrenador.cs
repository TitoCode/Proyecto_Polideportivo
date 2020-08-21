using PolideportivoAdmin_Proj.Clases.ClsEntrenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos.Entrenador
{
    public partial class FrmEquipoEntrenador : Form
    {
        public FrmEquipoEntrenador()
        {
            InitializeComponent();
        }

        ClsMantenimientosJugador Entrenador = new ClsMantenimientosJugador();

        private void FrmEquipoEntrenador_Load(object sender, EventArgs e)
        {
            Entrenador.BusquedaEquipos(Dgv_Equipos);
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas_Admin/AyudasAdmin.chm", "pg_0032.html");
        }
    }
}
