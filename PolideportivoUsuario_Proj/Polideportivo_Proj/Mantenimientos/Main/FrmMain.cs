using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo_Proj
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnListadoE_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PtbSlider1.Visible == true) {

                PtbSlider1.Visible = false;
                PtbSlider2.Visible = true;

            }else if (PtbSlider2.Visible == true) {

                PtbSlider2.Visible = false;
                PtbSlider3.Visible = true;

            }else if (PtbSlider3.Visible == true){

                PtbSlider3.Visible = false;
                PtbSlider1.Visible = true;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {

        }
    }
}
