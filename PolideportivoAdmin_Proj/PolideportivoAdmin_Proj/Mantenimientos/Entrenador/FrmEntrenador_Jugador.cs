using PolideportivoAdmin_Proj.Clases;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
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

        ClsBitacora Bitacora = new ClsBitacora();
        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null, SenSql2 = null;

        ClsJugador Jugador = new ClsJugador();
        ClsMantenimientosJugador Entrenador = new ClsMantenimientosJugador();
        ClsConexion conexion = new ClsConexion();

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


        private void Btn_Ingresar_Jugador_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 10;
            SenSql1 = "INSERT INTO JUGADOR (ID_JUGADOR, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO, ID_EQUIPO_FK, FOTO_JUGADOR, ID_POSICION_FK, ID_ESTADO_JUGADOR_FK) VALUES ("+
                     " ID_Jugador + , + Nombre1 + , + Nombre2 + , + Apellido1 + , + Apellido2 + , + FechaNacimiento + , + ClsDatos.EquipoId + , + Foto + , + Posicion + , + 1 + )";
            
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            
            MemoryStream ms = new MemoryStream();
            Ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            int Posicion = Cmb_Posiciones_Ingreso.SelectedIndex + 1;
            Entrenador.IngresoJugador(Txt_Ingreso_Nombre1.Text, Txt_Ingreso_Nombre2.Text, Txt_Ingreso_Apellido1.Text, Txt_Ingreso_Apellido2.Text, Dtp_FechaNacimiento_Ingreso.Value.Date.ToString(), aByte, Posicion);
        }

        private void Btn_Modificar_Jugador_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 11;
            SenSql1 = "UPDATE JUGADOR SET NOMBRE1= + Nombre1 + , NOMBRE2= + Nombre2 "+
                                          ", APELLIDO1= + Apellido1 + , APELLIDO2= + Apellido2 "+
                                           "WHERE ID_JUGADOR= + ID_Jugador + ";
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
          

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
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 12;
            SenSql1 = "UPDATE JUGADOR SET ID_ESTADO_JUGADOR_FK =  + 3 +  WHERE ID_JUGADOR=  + Id_Jugador + ";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);


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

        private void Btn_Ingresar_Jugador_Click_1(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            int Posicion = Cmb_Posiciones_Ingreso.SelectedIndex + 1;
            Entrenador.IngresoJugador(Txt_Ingreso_Nombre1.Text, Txt_Ingreso_Nombre2.Text, Txt_Ingreso_Apellido1.Text, Txt_Ingreso_Apellido2.Text, Dtp_FechaNacimiento_Ingreso.Value.Date.ToString(), aByte, Posicion);
        }

        private void Btn_Fotografia_Click(object sender, EventArgs e)
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

        private void Btn_Modificar_Jugador_Click_1(object sender, EventArgs e)
        {
            Jugador = Entrenador.BusquedaIDEntrenador(Txt_Modificar_Id.Text);
            Txt_Modificar_Nombre1.Text = Jugador.Nombre1;
            Txt_Modificar_Nombre2.Text = Jugador.Nombre2;
            Txt_Modificar_Apellido1.Text = Jugador.Apellido1;
            Txt_Modificar_Apellido2.Text = Jugador.Apellido2;
            Dtp_Modificar_Fdn.Text = Jugador.FechaNacimiento;
            Cmb_Posicion_Modificar.Text = Jugador.Id_Posicion;
        }

        private void Btn_CambiarFoto_Click_1(object sender, EventArgs e)
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

        private void Btn_Modificar_Buscar_Jugador_Click_1(object sender, EventArgs e)
        {
            Entrenador.ModificarJugador(Txt_Modificar_Id.Text, Txt_Modificar_Nombre1.Text, Txt_Modificar_Nombre2.Text, Txt_Modificar_Apellido1.Text, Txt_Modificar_Apellido2.Text);
        }

        private void Btn_Eliminar_Buscar_Jugador_Click_1(object sender, EventArgs e)
        {
            Jugador = Entrenador.BusquedaIDEntrenador(Txt_Eliminar_Id.Text);
            Txt_Eliminar_Nombre1.Text = Jugador.Nombre1;
            Txt_Eliminar_Nombre2.Text = Jugador.Nombre2;
            Txt_Eliminar_Apellido1.Text = Jugador.Apellido1;
            Txt_Eliminar_Apellido2.Text = Jugador.Apellido2;
            Dtp_Eliminar_Fdn.Text = Jugador.FechaNacimiento;
            Txt_Posicion_Eliminar.Text = Jugador.Id_Posicion;
        }

        private void Btn_Eliminar_Jugador_Click_1(object sender, EventArgs e)
        {
            Entrenador.EliminarJugador(Txt_Eliminar_Id.Text);
        }

        private void FrmEntrenador_Jugador_Load(object sender, EventArgs e)
        {
            DatosCbx_Posicion();
        }
    }
}
