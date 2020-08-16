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
    public partial class FrmAdminCampeonato : Form
    {
        public FrmAdminCampeonato()
        {
            InitializeComponent();
        }

        private void Rdb_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Todos.Checked == true) { Gpb_Campeonato_Tipo_Tct.Visible = true; Rdb_Ida.Visible = true; Rdb_IdaVuelta.Visible = true; Lbl_Campeonato_Ida.Visible = true; Lbl_Campeonato_Ida_Vuelta.Visible = true; Lbl_Crear_Cantidad_Equipos.Visible = true; Nud_Cantidad_Todos.Visible = true; }
            else { Gpb_Campeonato_Tipo_Tct.Visible = false; Rdb_Ida.Visible = false; Rdb_IdaVuelta.Visible = false; Lbl_Campeonato_Ida.Visible = false; Lbl_Campeonato_Ida_Vuelta.Visible = false; Lbl_Crear_Cantidad_Equipos.Visible = false; Nud_Cantidad_Todos.Visible = false; }
        }
    }
}
