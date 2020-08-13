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
    public partial class FrmAdminEntrenador : Form
    {
        public FrmAdminEntrenador()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();

        private void FmrAdminEntrenador_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Ingresar_Entrenador_Click(object sender, EventArgs e)
        {
            try
            {
                string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + Txt_Ingreso_Id_Usuario.Text + "','" + Txt_Ingreso_Password.Text + "'," + 2 + ")";
                string InsertarEntrenador = "INSERT INTO ENTRENADOR (NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO, ID_USUARIO_FK) VALUES ('"
                    + Txt_Ingreso_Nombre1_Entrenador.Text + "','" + Txt_Ingreso_Nombre2_Entrenador.Text + "','" + Txt_Ingreso_Apellido1_Entrenador.Text +
                   "','" + Txt_Ingreso_Apellido2_Entrenador.Text + "','" + Dtp_Ingreso_Fdn_Entrenador.Text + "','" + Txt_Ingreso_Id_Usuario.Text + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(InsertarUsuario, conexion.conexion());
                Query_Validacion1.ExecuteNonQuery();
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarEntrenador, conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO ENTRENADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//Fin Try 
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Fin Catch
        }

        private void Btn_Modificar_Buscar_Entrenador_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    string BuscarDatoTelefono = "SELECT * FROM USUARIO WHERE ID_USUARIO ='" + Txt_Eliminar_Nombre1_Entrenador.Text + "'";
            //    string BuscarDatoEmpleado = "SELECT * FROM ENTRENADOR WHERE NOMBRE1 ='" + Txt_IDEmpleado.Text + "'";

            //    OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoTelefono, conexion.conexion());
            //    OdbcCommand Query_Busqueda2 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());

            //    OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();
            //    OdbcDataReader Lector2 = Query_Busqueda2.ExecuteReader();

            //    if (Lector1.HasRows == true && Lector2.HasRows == true)
            //    {
            //        while (Lector1.Read())
            //        {
            //            Lbl_IDTelefono.Text = Lector1.GetString(0);
            //            Txt_Telefono.Text = Lector1.GetString(1);

            //        }

            //        while (Lector2.Read())
            //        {

            //            Txt_Nombre1.Text = Lector2.GetString(1);
            //            Txt_Nombre2.Text = Lector2.GetString(2);
            //            Txt_Apellido1.Text = Lector2.GetString(3);
            //            Txt_Apellido2.Text = Lector2.GetString(4);
            //            Txt_Email.Text = Lector2.GetString(5);
            //            Txt_Direccion.Text = Lector2.GetString(7);
            //            Txt_FechaNacimiento.Text = Lector2.GetString(8);
            //            Txt_NIT.Text = Lector2.GetString(9);
            //            Txt_DPI.Text = Lector2.GetString(10);
            //            Lbl_IDUsuario.Text = Lector2.GetString(11);
            //            Txt_FechaContrato.Text = Lector2.GetString(12);


            //        }

            //        string BuscarDatoUsuario = "SELECT * FROM USUARIO WHERE ID_USUARIO ='" + Lbl_IDUsuario.Text + "'";
            //        OdbcCommand Query_Busqueda3 = new OdbcCommand(BuscarDatoUsuario, conexion.conexion());
            //        OdbcDataReader Lector3 = Query_Busqueda3.ExecuteReader();

            //        while (Lector3.Read())
            //        {

            //            Txt_Usuario.Text = Lector3.GetString(0);
            //            Txt_Password.Text = Lector3.GetString(1);

            //        }

            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error al ejecutar SQL: " +
            //        System.Environment.NewLine + System.Environment.NewLine +
            //        ex.GetType().ToString() + System.Environment.NewLine +
            //        ex.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void Btn_Modificar_Entrenador_Click(object sender, EventArgs e)
        {
            try
            {
                string ModificarEntrenador = "UPDATE ENTRENADOR SET NOMBRE1='" + Txt_Modificar_Nombre1_Entrenador.Text + "', NOMBRE2='" + Txt_Modificar_Nombre2_Entrenador.Text +
                    "', APELLIDO1='" + Txt_Modificar_Apellido1_Entrenador.Text + "', APELLIDO2='" + Txt_Modificar_Apellido2_Entrenador.Text + "', FECHA_NACIMIENTO='" + Dtp_Modificar_Fdn_Entrenador.Text + "'";
                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO='" + Txt_Modificar_Usuario_Entrenador.Text + "', PASSWORD='" + Txt_Modificar_Password_Entrenador.Text + "' WHERE ID_USUARIO='" + Txt_Modificar_Usuario_Entrenador.Text + "'";
                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarEntrenador, conexion.conexion());
                OdbcCommand Query_UPDATE2 = new OdbcCommand(ModificarUsuario, conexion.conexion());

                Query_UPDATE1.ExecuteNonQuery();
                Query_UPDATE2.ExecuteNonQuery();

                MessageBox.Show("Modificación Exitosa", "FORMULARIO EMPLEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
