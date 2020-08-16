using PolideportivoAdmin_Proj.Clases.ClsEntrenador;
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
    public partial class FrmEntrenador_Jugador : Form
    {
        public FrmEntrenador_Jugador()
        {
            InitializeComponent();
            
        }

        ClsJugador Jugador = new ClsJugador();
        ClsMantenimientosJugador Entrenador = new ClsMantenimientosJugador();
        ClsConexion conexion = new ClsConexion();

        private void Btn_Fotografia_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ingresar_Entrenador_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Fotografia_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Fotografia = new OpenFileDialog();
            Fotografia.Filter = "Imagenes |*.jpg; *.png";
            Fotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Fotografia.Title = "Seleccionar Imagen";

            if (Fotografia.ShowDialog() == DialogResult.OK)
            {
                Ptb_Foto.Image = Image.FromFile(Fotografia.FileName);
            }
        }

        private void Btn_CambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fotografia = new OpenFileDialog();
            Fotografia.Filter = "Imagenes |*.jpg; *.png";
            Fotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Fotografia.Title = "Seleccionar Imagen";

            if (Fotografia.ShowDialog() == DialogResult.OK)
            {
                Ptb_Foto_Modificar.Image = Image.FromFile(Fotografia.FileName);
            }
        }

        private void Btn_Ingresar_Jugador_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            int Posicion = Cmb_Posiciones_Ingreso.SelectedIndex + 1;
            Entrenador.IngresoJugador(Txt_Ingreso_Nombre1.Text, Txt_Ingreso_Nombre2.Text, Txt_Ingreso_Apellido1.Text, Txt_Ingreso_Apellido2.Text, Dtp_FechaNacimiento_Ingreso.Value.Date.ToString(), aByte, Posicion);
        }

        private void Btn_Modificar_Buscar_Jugador_Click(object sender, EventArgs e)
        {
            Jugador = Entrenador.BusquedaIDEntrenador(Txt_Modificar_Id.Text);
            Txt_Modificar_Nombre1.Text = Jugador.Nombre1;
            Txt_Modificar_Nombre2.Text = Jugador.Nombre2;
            Txt_Modificar_Apellido1.Text = Jugador.Apellido1;
            Txt_Modificar_Apellido2.Text = Jugador.Apellido2;
            Dtp_Modificar_Fdn.Text = Jugador.FechaNacimiento;
            Cmb_Posicion_Modificar.Text = Jugador.Id_Posicion;
        }

        private void Btn_Modificar_Jugador_Click(object sender, EventArgs e)
        {
            Entrenador.ModificarJugador(Txt_Modificar_Id.Text, Txt_Modificar_Nombre1.Text, Txt_Modificar_Nombre2.Text, Txt_Modificar_Apellido1.Text, Txt_Modificar_Apellido2.Text);
        }

        private void Btn_Eliminar_Buscar_Jugador_Click(object sender, EventArgs e)
        {
            Jugador = Entrenador.BusquedaIDEntrenador(Txt_Eliminar_Id.Text);
            Txt_Eliminar_Nombre1.Text = Jugador.Nombre1;
            Txt_Eliminar_Nombre2.Text = Jugador.Nombre2;
            Txt_Eliminar_Apellido1.Text = Jugador.Apellido1;
            Txt_Eliminar_Apellido2.Text = Jugador.Apellido2;
            Dtp_Eliminar_Fdn.Text = Jugador.FechaNacimiento;
            Txt_Posicion_Eliminar.Text = Jugador.Id_Posicion;
        }

        private void Btn_Eliminar_Jugador_Click(object sender, EventArgs e)
        {
            Entrenador.EliminarJugador(Txt_Eliminar_Id.Text);
        }
        private void DatosCbx_Posicion()
        {
            try
            {

                string CargarTipoJugador = "SELECT * FROM TIPO_JUGADOR";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarTipoJugador, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_Posiciones_Ingreso.DataSource = Datos;
                Cmb_Posiciones_Ingreso.DisplayMember = "NOMBRE_POSICION";
                Cmb_Posiciones_Ingreso.ResetText();

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

        private void FrmEntrenador_Jugador_Load(object sender, EventArgs e)
        {
            DatosCbx_Posicion();
        }
    }
}
