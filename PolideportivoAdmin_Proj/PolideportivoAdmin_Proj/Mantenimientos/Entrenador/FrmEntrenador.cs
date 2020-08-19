using PolideportivoAdmin_Proj.Clases;
using PolideportivoAdmin_Proj.Mantenimientos.Gerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        ClsConexion Conexion = new ClsConexion();
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
        private void FrmEntrenador_Load(object sender, EventArgs e)
        {
            //MostrarFotografia();
            AbrirFormEnPanel(new FrmBase());
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
            Btn_IngresoJugadores.BackColor = Color.White;
            Btn_IngresoJugadores.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_TablaDePosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaDePosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmEntrenador_Jugador());
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Btn_Inicio.BackColor = Color.White;
            Btn_Inicio.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_IngresoJugadores.BackColor = Color.FromArgb(10, 37, 73);
            Btn_IngresoJugadores.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_TablaDePosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaDePosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmBase());
        }

        private void Btn_Equipo_Click(object sender, EventArgs e)
        {
            Btn_Equipo.BackColor = Color.White;
            Btn_Equipo.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_IngresoJugadores.BackColor = Color.FromArgb(10, 37, 73);
            Btn_IngresoJugadores.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            Btn_TablaDePosiciones.BackColor = Color.FromArgb(10, 37, 73);
            Btn_TablaDePosiciones.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmEquipoEntrenador());
        }

        private void Btn_TablaDePosiciones_Click(object sender, EventArgs e)
        {
            Btn_TablaDePosiciones.BackColor = Color.White;
            Btn_TablaDePosiciones.ForeColor = Color.FromArgb(10, 37, 73);
            Btn_IngresoJugadores.BackColor = Color.FromArgb(10, 37, 73);
            Btn_IngresoJugadores.ForeColor = Color.White;
            Btn_Equipo.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Equipo.ForeColor = Color.White;
            Btn_Inicio.BackColor = Color.FromArgb(10, 37, 73);
            Btn_Inicio.ForeColor = Color.White;
            AbrirFormEnPanel(new FrmTablaDePosiciones());
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
            string BuscarDatoEmpleado = "SELECT FOTO_ENTRENADOR FROM ENTRENADOR WHERE ID_USUARIO_FK ='" + ClsDatos.UserId + "'";

            OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, Conexion.conexion());
            OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();
            if (Lector.Read())
            {
                byte[] avatarByte = (byte[])Lector["FOTO_ENTRENADOR"];
                return avatarByte;
            }
            return null;
        }

    }
}
