using PolideportivoAdmin_Proj.Clases;
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
            AbrirFormEnPanel(new FrmBase());
        }

        public void AbrirFormEnPanel(object Formhijo)
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

        private void Btn_Campeonato_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAdminCampeonato());
        }

        private void Btn_Entrenador_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAdminEntrenador());
        }

        private void Btn_Calendario_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmBase());
        }

        private void Btn_Equipo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAdminEquipo());
        }

        private void Btn_Entreador_Click(object sender, EventArgs e)
        {
            Form Entrenador = new FrmAdminEntrenador();
            Entrenador.ShowDialog();
        }
    }
}
