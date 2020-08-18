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
            MostrarFotografia();
        }

        private void Btn_Empleado_Click(object sender, EventArgs e)
        {
            Btn_Empleado.BackColor = Color.White;
            Btn_Empleado.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Reporte.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Reporte.ForeColor = Color.White;
            Btn_Estadistica.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Estadistica.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmEmpleados());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Btn_Reporte.BackColor = Color.White;
            Btn_Reporte.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Empleado.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Empleado.ForeColor = Color.White;
            Btn_Estadistica.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Estadistica.ForeColor = Color.White;
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
            Btn_Inicio.BackColor = Color.White;
            Btn_Inicio.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Reporte.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Reporte.ForeColor = Color.White;
            Btn_Empleado.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Empleado.ForeColor = Color.White;
            Btn_Estadistica.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Estadistica.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmBase());
        }

        public void MostrarFotografia()
        {
            byte[] Imagen = SqlaByte();
            MemoryStream ms = new MemoryStream(Imagen);
            ms.Position = 0;
            Image devolverImagen = Image.FromStream(ms);
            Ptb_FotoUsuario.Image = devolverImagen;
        }

        
        private byte[] SqlaByte()
        {
            string BuscarDatoEmpleado = "SELECT FOTOGRAFIA FROM EMPLEADO WHERE ID_EMPLEADO ='" + 1 + "'";

            OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, Conexion.conexion());
            OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();
            if (Lector.Read())
            {
                byte[] avatarByte = (byte[])Lector["FOTOGRAFIA"];
                return avatarByte;
            }
            return null;
        }

        private void Btn_Estadistica_Click(object sender, EventArgs e)
        {
            Btn_Estadistica.BackColor = Color.White;
            Btn_Estadistica.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Reporte.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Reporte.ForeColor = Color.White;
            Btn_Empleado.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Empleado.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmEstadisticas());
        }
    }
}
