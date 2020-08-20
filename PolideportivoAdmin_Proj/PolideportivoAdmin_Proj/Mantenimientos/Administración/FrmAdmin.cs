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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "¿Está seguro que desea salir? Esta acción cerrará su sesión.", "Cerrar Sesión", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
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
            Btn_Campeonato.BackColor = Color.White;
            Btn_Campeonato.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.ForeColor = Color.White;
            Btn_Calendario.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Calendario.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_TablaPosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaPosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmAdminCampeonato());  
        }

        private void Btn_Entrenador_Click(object sender, EventArgs e)
        {
            Btn_Entrenador.BackColor = Color.White;
            Btn_Entrenador.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Campeonato.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Campeonato.ForeColor = Color.White;
            Btn_Calendario.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Calendario.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_TablaPosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaPosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmAdminEntrenador());
        }

        private void Btn_Calendario_Click(object sender, EventArgs e)
        {
            Btn_Calendario.BackColor = Color.White;
            Btn_Calendario.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.ForeColor = Color.White;
            Btn_Campeonato.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Campeonato.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_TablaPosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaPosiciones.ForeColor = Color.White;
        }

        private void Btn_Equipo_Click(object sender, EventArgs e)
        {
            Btn_Equipo.BackColor = Color.White;
            Btn_Equipo.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.ForeColor = Color.White;
            Btn_Calendario.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Calendario.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Campeonato.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Campeonato.ForeColor = Color.White;
            Btn_TablaPosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaPosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmAdminEquipo());
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Btn_Inicio.BackColor = Color.White;
            Btn_Inicio.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.ForeColor = Color.White;
            Btn_Calendario.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Calendario.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_Campeonato.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Campeonato.ForeColor = Color.White;
            Btn_TablaPosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaPosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmBase());
        }

        private void Btn_TablaPosiciones_Click(object sender, EventArgs e)
        {
            Btn_TablaPosiciones.BackColor = Color.White;
            Btn_TablaPosiciones.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Entrenador.ForeColor = Color.White;
            Btn_Calendario.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Calendario.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_Campeonato.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Campeonato.ForeColor = Color.White;
        }
    }
}
