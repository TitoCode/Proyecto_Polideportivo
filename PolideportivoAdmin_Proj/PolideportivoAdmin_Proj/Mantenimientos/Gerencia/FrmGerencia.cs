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
using PolideportivoAdmin_Proj.Clases.ClsUsuario;
using System.IO;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases;



namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmGerencia : Form
    {
        public FrmGerencia()
        {
            InitializeComponent();
            
        }

        ClsConexion Conexion = new ClsConexion();

        private void FrmGerencia_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmBase());
            //MostrarFotografia(Lbl_Usuario.Text);
        }

        private void Btn_Empleado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEmpleados());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReportes());
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

        private void Lblk_CambiarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuario());
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmBase());
        }

        public void MostrarFotografia(string Usuario)
        {
            try
            {

                string BuscarDatoEmpleado = "SELECT FOTOGRAFIA FROM EMPLEADO WHERE ID_EMPLEADO ='" + 1 + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, Conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();
                MessageBox.Show("No se han completado los campos");
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        MemoryStream ms = new MemoryStream((byte[])Lector["FOTOGRAFIA"]);
                        ms.Position = 0;
                        Ptb_FotoUsuario.BackgroundImage = Bitmap.FromStream(ms);
                    }
                    
                
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
