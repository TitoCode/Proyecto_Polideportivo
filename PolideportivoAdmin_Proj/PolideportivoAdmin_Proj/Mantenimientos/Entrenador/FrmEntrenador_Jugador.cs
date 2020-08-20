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
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases;

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
        ClsBitacora Bitacora = new ClsBitacora();

        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null;

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
            
             
            int notExecute=1;
            if (Txt_Ingreso_Nombre1.Text == "" || Txt_Ingreso_Nombre2.Text == "" || Txt_Ingreso_Apellido1.Text == "" || Txt_Ingreso_Apellido2.Text == "" ) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                
                    DateTime fecharNac = Dtp_FechaNacimiento_Ingreso.Value.Date;
                    var diasNac = (DateTime.Now - fecharNac).TotalDays;

                    if (MessageBox.Show("¿Desea agregar un nuevo jugador?", "JUGADOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {
                        if (diasNac > 36500)
                        {
                            MessageBox.Show("ADVERTENCIA: Edad erronea, no puede ingresar una edad mayor a 100 años.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            notExecute = 0;
                        }

                        switch (notExecute)
                        {
                            case 1:
                                UsuarioActivo = ClsDatos.UserId;
                                TipoProceso = 10;
                                SenSql1 = "INSERT INTO JUGADOR (ID_JUGADOR, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO, ID_EQUIPO_FK, FOTO_JUGADOR, ID_POSICION_FK, ID_ESTADO_JUGADOR_FK) VALUES (" +
                                    " ID_Jugador + , + Nombre1 + , + Nombre2 + , + Apellido1 + , + Apellido2 + , + FechaNacimiento + , + ClsDatos.EquipoId + , + Foto + , + Posicion + , + 1 + )";

                                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                                MemoryStream ms = new MemoryStream();
                                Ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
                                byte[] aByte = ms.ToArray();
                                int Posicion = Cmb_Posiciones_Ingreso.SelectedIndex + 1;
                                Entrenador.IngresoJugador(Txt_Ingreso_Nombre1.Text, Txt_Ingreso_Nombre2.Text, Txt_Ingreso_Apellido1.Text, Txt_Ingreso_Apellido2.Text, Dtp_FechaNacimiento_Ingreso.Value.Date.ToString(), aByte, Posicion);
                                Txt_Ingreso_Nombre1.Text = "";
                                Txt_Ingreso_Nombre2.Text = "";
                                Txt_Ingreso_Apellido1.Text = "";
                                Txt_Ingreso_Apellido2.Text = "";
                                break;
                            default:
                                break;
                        }
                    }
                
            }
             

        }

        private void Btn_Modificar_Buscar_Jugador_Click(object sender, EventArgs e)
        {
            if (Txt_Modificar_Id.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                Jugador = Entrenador.BusquedaIDJugador(Txt_Modificar_Id.Text);
                Txt_Modificar_Nombre1.Text = Jugador.Nombre1;
                Txt_Modificar_Nombre2.Text = Jugador.Nombre2;
                Txt_Modificar_Apellido1.Text = Jugador.Apellido1;
                Txt_Modificar_Apellido2.Text = Jugador.Apellido2;
                Dtp_Modificar_Fdn.Text = Jugador.FechaNacimiento;
                Cmb_Posicion_Modificar.Text = Jugador.Id_Posicion;
                Btn_Modificar_Jugador.Enabled = true;
            }
        }

        private void Btn_Modificar_Jugador_Click(object sender, EventArgs e)
        {
            if (Txt_Modificar_Nombre1.Text == "" || Txt_Modificar_Nombre2.Text == "" || Txt_Modificar_Apellido1.Text == "" || Txt_Modificar_Apellido2.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (MessageBox.Show("¿Desea modificar el jugador?", "JUGADOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 11;
                    SenSql1 = "UPDATE JUGADOR SET NOMBRE1= + Nombre1 + , NOMBRE2= + Nombre2 " +
                                                  ", APELLIDO1= + Apellido1 + , APELLIDO2= + Apellido2 " +
                                                   "WHERE ID_JUGADOR= + ID_Jugador + ";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                    int Posicion = Cmb_Posicion_Modificar.SelectedIndex + 1;
                    Entrenador.ModificarJugador(Txt_Modificar_Id.Text, Txt_Modificar_Nombre1.Text, Txt_Modificar_Nombre2.Text, Txt_Modificar_Apellido1.Text, Txt_Modificar_Apellido2.Text, Posicion);
                    Txt_Modificar_Nombre1.Text = "";
                    Txt_Modificar_Nombre2.Text = "";
                    Txt_Modificar_Apellido1.Text = "";
                    Txt_Modificar_Apellido2.Text = "";
                    Btn_Modificar_Jugador.Enabled = false;
                }
            }
        }

        private void Btn_Eliminar_Buscar_Jugador_Click(object sender, EventArgs e)
        {
            if (Txt_Eliminar_Id.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                Jugador = Entrenador.BusquedaIDJugador(Txt_Eliminar_Id.Text);
                Txt_Eliminar_Nombre1.Text = Jugador.Nombre1;
                Txt_Eliminar_Nombre2.Text = Jugador.Nombre2;
                Txt_Eliminar_Apellido1.Text = Jugador.Apellido1;
                Txt_Eliminar_Apellido2.Text = Jugador.Apellido2;
                Dtp_Eliminar_Fdn.Text = Jugador.FechaNacimiento;
                Txt_Posicion_Eliminar.Text = Jugador.Id_Posicion;
                Btn_Eliminar_Jugador.Enabled = true;
            }
        }

        private void Btn_Eliminar_Jugador_Click(object sender, EventArgs e)
        {

            
                if (MessageBox.Show("¿Desea eliminar el jugador?", "JUGADOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 12;
                    SenSql1 = "UPDATE JUGADOR SET ID_ESTADO_JUGADOR_FK =  + 3 +  WHERE ID_JUGADOR=  + Id_Jugador + ";

                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                    Entrenador.EliminarJugador(Txt_Eliminar_Id.Text);
                    Btn_Eliminar_Jugador.Enabled = false;
                }
            
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
                Cmb_Posicion_Modificar.DataSource = Datos;
                Cmb_Posicion_Modificar.DisplayMember = "NOMBRE_POSICION";
                Cmb_Posicion_Modificar.ResetText();

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

        private void Tmr_Jugadores_Tick(object sender, EventArgs e)
        {
            Entrenador.ListaEquipo(Dgw_Listado);
        }
        private void numero(object sender, KeyPressEventArgs e)
        {
            ClsValidarKeyPress.Numeros(e);
        }

        private void letra(object sender, KeyPressEventArgs e)
        {
            ClsValidarKeyPress.Letras(e);
        }

    }
}
