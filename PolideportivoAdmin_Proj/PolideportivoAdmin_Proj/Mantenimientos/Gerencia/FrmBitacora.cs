using PolideportivoAdmin_Proj.Clases.ClsUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        ClsMantenimientoBitacora Bitacora = new ClsMantenimientoBitacora();

        private void Tmr_Bitacora_Tick(object sender, EventArgs e)
        {
            Bitacora.MostrarBitacora(Dgv_Bitacora);
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas_Admin/AyudasAdmin.chm", "pg_0011.html");
        }
    }
}
