using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos.Entrenador
{
    public partial class FrmEntrenador : Form
    {
        public FrmEntrenador()
        {
            InitializeComponent();
        }

        private void FrmEntrenador_Load(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.Pnl_Contenedor.Controls.Count > 0)
                this.Pnl_Contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pnl_Contenedor.Controls.Add(fh);
            this.Pnl_Contenedor.Tag = fh;
            fh.Show();
        }

        private void Btn_IngresoJugadores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEntrenador_Jugador());
        }
    }
}
