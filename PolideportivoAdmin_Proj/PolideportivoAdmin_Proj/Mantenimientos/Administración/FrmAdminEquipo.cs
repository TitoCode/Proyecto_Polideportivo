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

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdminEquipo : Form
    {
        public FrmAdminEquipo()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();

        private void FrmAdminEquipo_Load(object sender, EventArgs e)
        {
            DatosCbx_Equipos_Entrenador();
            DatosCbx_Tipo_Deporte();
        }

        private void Cmb_Crear_Entrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Btn_Ingresar_Equipo_Click(object sender, EventArgs e)
        {
            int Id_Entrenador, Id_Tipo_Deporte;
            Id_Entrenador = Cbx_Crear_Entrenador.SelectedIndex + 1;
            Id_Tipo_Deporte = Cbx_Crear_Deporte.SelectedIndex + 1;

            string InsertarEquipo = "INSERT INTO EQUIPO (NOMBRE_EQUIPO, ID_ENTRENADOR_FK, ID_TIPO_DEPORTE_FK)" +
                "VALUES('" + Txt_Crear_Nombre_Equipo +"','" + Id_Entrenador + "','" + Id_Tipo_Deporte + "')";

            OdbcCommand Query_Validacion1 = new OdbcCommand(InsertarEquipo, conexion.conexion());
            Query_Validacion1.ExecuteNonQuery();

            MessageBox.Show("Ingreso Exitoso", "FORMULARIO EQUIPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Cbx_Editar_Entrenador.Items.Add(NombreCompletoEntrenador);
                        Cbx_Eliminar_Entrenador.Items.Add(NombreCompletoEntrenador);
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

                Cbx_Editar_Deporte.DataSource = Datos;
                Cbx_Editar_Deporte.DisplayMember = "NOMBRE_DEPORTE";
                Cbx_Editar_Deporte.ResetText();

                Cbx_Eliminar_Deporte.DataSource = Datos;
                Cbx_Eliminar_Deporte.DisplayMember = "NOMBRE_DEPORTE";
                Cbx_Eliminar_Deporte.ResetText();

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
            try
            {
                string BuscarEquipos = "SELECT * FROM EQUIPOS" + " WHERE NOMBRE_EQUIPO =" + Txt_Editar_Nombre_Equipo.Text;

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEquipos, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Txt_Modificar_Id_Equipo.Text = Lector1.GetString(0);
                        Txt_Editar_Nombre_Equipo.Text = Lector1.GetString(1);
                        Cbx_Editar_Entrenador.Text = Lector1.GetString(2);
                        Cbx_Editar_Deporte.Text = Lector1.GetString(3);
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

        private void Btn_Modificar_Equipo_Click(object sender, EventArgs e)
        {
            try
            {
                string ModificarEquipo = "UPDATE EQUIPO SET NOMBRE_EQUIPO='" + Txt_Editar_Nombre_Equipo +"'ID_ENTRENADOR_FK='"
                    + Cbx_Editar_Entrenador + "' ID_TIPO_DEPORTE_FK='" + Cbx_Editar_Deporte +"WHERE ID_EQUIPO=" + Txt_Modificar_Id_Equipo + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarEquipo, conexion.conexion());
                Query_UPDATE1.ExecuteNonQuery();

                MessageBox.Show("Equipo modificado con éxito.", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_Eliminar_Equipo_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Eliminar_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string BuscarEquipos = "SELECT * FROM EQUIPOS" + " WHERE NOMBRE_EQUIPO =" + Txt_Eliminar_Nombre_Equipo.Text;

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEquipos, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Txt_Eliminar_Id_Equipo.Text = Lector1.GetString(0);
                        Txt_Eliminar_Nombre_Equipo.Text = Lector1.GetString(1);
                        Cbx_Eliminar_Entrenador.Text = Lector1.GetString(2);
                        Cbx_Eliminar_Deporte.Text = Lector1.GetString(3);
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
    }
}
