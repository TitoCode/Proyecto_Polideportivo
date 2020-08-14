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
using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using PolideportivoAdmin_Proj.Mantenimientos.Gerencia;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmGerencia : Form
    {
        public FrmGerencia()
        {
            InitializeComponent();
            
        }

        private void FrmGerencia_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Empleado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEmpleados());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReportes());
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

    }
}
