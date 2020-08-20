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
using PolideportivoAdmin_Proj.Clases.ClsAdmin;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases;

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdminEquipo : Form
    {
        public FrmAdminEquipo()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();
        ClsMantenimientosAdmin Admin = new ClsMantenimientosAdmin();
        ClsEquipo Equipo = new ClsEquipo();
        ClsBitacora Bitacora = new ClsBitacora();

        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null;


        private void FrmAdminEquipo_Load(object sender, EventArgs e)
        {
            DatosCbx_Equipos_Entrenador();
            DatosCbx_Tipo_Deporte();
        }

        private void Btn_Ingresar_Equipo_Click(object sender, EventArgs e)
        {
            if (Txt_Crear_Nombre_Equipo.Text == ""|| Cbx_Crear_Entrenador.SelectedItem==null|| Cbx_Crear_Deporte.SelectedItem == null) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                UsuarioActivo = ClsDatos.UserId;
                TipoProceso = 16;
                SenSql1 = "INSERT INTO EQUIPO (ID_EQUIPO, NOMBRE_EQUIPO, ID_ENTRENADOR_FK, ID_TIPO_DEPORTE__FK, ID_ESTADO_EQUIPO_FK)" +
                        "VALUES( + ID_Equipo + , + Nombre + , + ID_Entrenador + , + ID_TipoDeporte + , + 1 + )";
                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                int Id_Entrenador, Id_Tipo_Deporte;
                Id_Entrenador = Cbx_Crear_Entrenador.SelectedIndex + 1;
                Id_Tipo_Deporte = Cbx_Crear_Deporte.SelectedIndex + 1;

                Admin.IngresoEquipo(Id_Entrenador, Id_Tipo_Deporte, Txt_Crear_Nombre_Equipo.Text);
            }

        }

        private void DatosCbx_Equipos_Entrenador() 
        {
            string NombreCompletoEntrenador;
            try
            {

                string CargarEntrenadores = "SELECT NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2 FROM ENTRENADOR";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarEntrenadores, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true) 
                {
                    while (Lector1.Read())
                    {
                        NombreCompletoEntrenador = "";
                        NombreCompletoEntrenador += Lector1.GetString(0) + " ";
                        NombreCompletoEntrenador += Lector1.GetString(1) + " ";
                        NombreCompletoEntrenador += Lector1.GetString(2) + " ";
                        NombreCompletoEntrenador += Lector1.GetString(3);

                        Cbx_Crear_Entrenador.Items.Add(NombreCompletoEntrenador);

                    }//fin while
                }//fin if
            }//fin try
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//fin catch
        }
        private void DatosCbx_Tipo_Deporte()
        {
            try
            {

                string CargarTipoDeporte = "SELECT * FROM TIPO_DEPORTE";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarTipoDeporte, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cbx_Crear_Deporte.DataSource = Datos;
                Cbx_Crear_Deporte.DisplayMember = "NOMBRE_DEPORTE";
                Cbx_Crear_Deporte.ResetText();

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

        private void Btn_Editar_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Modificar_Id_Equipo.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                Equipo = Admin.BusquedaIDEquipo(Txt_Modificar_Id_Equipo.Text);
                Txt_Editar_Nombre_Equipo.Text = Equipo.Nombre;
                Txt_Editar_Deporte.Text = Equipo.ID_TipoDeporte;
                Txt_Editar_Entrenador.Text = Equipo.ID_Entrenador;
                Btn_Modificar_Equipo.Enabled = true;
            }

        }

        private void Btn_Modificar_Equipo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el equipo?", "EQUIPO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
            else
            {
                UsuarioActivo = ClsDatos.UserId;
                TipoProceso = 17;
                SenSql1 = "UPDATE EQUIPO SET NOMBRE_EQUIPO= + Nombre +  WHERE ID_EQUIPO= + Id_Equipo + ";
                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                int Id_Entrenador = Cbx_Crear_Entrenador.SelectedIndex + 1;
                Admin.ModificarEquipo(Txt_Editar_Nombre_Equipo.Text, Txt_Modificar_Id_Equipo.Text);
                Txt_Editar_Nombre_Equipo.Text = "";
                Txt_Modificar_Id_Equipo.Text = "";
                Btn_Modificar_Equipo.Enabled = false;
            }
        }

        private void Btn_Eliminar_Equipo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el equipo?", "EQUIPO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
            else
            {
                UsuarioActivo = ClsDatos.UserId;
                TipoProceso = 18;
                SenSql1 = "UPDATE EQUIPO SET ID_ESTADO_EQUIPO_FK= + 3 +  WHERE ID_EQUIPO= + Id_Equipo + ";

                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                Admin.EliminarEquipo(Txt_Eliminar_Id_Equipo.Text);

                Btn_Eliminar_Equipo.Enabled = true;
            }
        }

        private void Btn_Eliminar_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Eliminar_Id_Equipo.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                Equipo = Admin.BusquedaIDEquipo(Txt_Eliminar_Id_Equipo.Text);
                Txt_Eliminar_Nombre_Equipo.Text = Equipo.Nombre;
                Txt_Eliminar_Deporte.Text = Equipo.ID_TipoDeporte;
                Txt_Eliminar_Entrenador.Text = Equipo.ID_Entrenador;
                Btn_Eliminar_Equipo.Enabled = true;
            }
        }

        private void Tmr_ListadoEquipos_Tick(object sender, EventArgs e)
        {
            Admin.ListadoEquipos(Dgv_ListadoEquipos);
        }
    }
}
