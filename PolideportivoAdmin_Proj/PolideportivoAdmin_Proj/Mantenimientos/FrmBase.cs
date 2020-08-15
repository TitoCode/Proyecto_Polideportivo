using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void Tmr_HoraFecha_Tick(object sender, EventArgs e)
        {
            Lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss ");
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
