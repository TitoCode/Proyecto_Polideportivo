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
            try 
            {
                string BuscarEntrenador = "SELECT E.ID_ENTRENADOR, E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2,  E.FECHA_NACIMIENTO, E.ID_USUARIO_FK, U.PASSWORD," +
                " TU.NOMBRE_TIPO FROM ENTRENADOR AS E, USUARIO AS U, TIPO_USUARIO AS TU" +
                " WHERE U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO ='" + Txt_Modificar_Usuario_Entrenador.Text + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEntrenador, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true) 
                {
                    while (Lector1.Read())
                    {
                        Txt_Modificar_Id_Entenador.Text = Lector1.GetString(0);
                        Txt_Modificar_Nombre1_Entrenador.Text = Lector1.GetString(1);
                        Txt_Modificar_Nombre2_Entrenador.Text = Lector1.GetString(2);
                        Txt_Modificar_Apellido1_Entrenador.Text = Lector1.GetString(3);
                        Txt_Modificar_Apellido2_Entrenador.Text = Lector1.GetString(4);
                        Dtp_Modificar_Fdn_Entrenador.Value.ToString(Lector1.GetString(5));
                        Txt_Modificar_Usuario_Entrenador.Text = Lector1.GetString(6);
                        Txt_Modificar_Password_Entrenador.Text = Lector1.GetString(7);
                        Txt_Modificar_Tipo_Usuario_Entrenador.Text = Lector1.GetString(8);
                    }//fin while
                }//fin if
            } //fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// fin catch
            
        }

        private void Btn_Modificar_Entrenador_Click(object sender, EventArgs e)
        {
            try 
            {
                string ModificarEntrenador = "UPDATE ENTRENADOR SET NOMBRE1='" + Txt_Modificar_Nombre1_Entrenador.Text + "', NOMBRE2='" + Txt_Modificar_Nombre2_Entrenador.Text +
                                          "', APELLIDO1='" + Txt_Modificar_Apellido1_Entrenador.Text + "', APELLIDO2='" + Txt_Modificar_Apellido2_Entrenador.Text +
                                          "', FECHA_NACIMIENTO='" + Dtp_Modificar_Fdn_Entrenador.Text +
                                          "' WHERE ID_ENTRENADOR='" + Txt_Modificar_Id_Entenador.Text + "'";

                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO='" + Txt_Modificar_Usuario_Entrenador.Text + "', PASSWORD='" + Txt_Modificar_Password_Entrenador.Text +
                                          "' WHERE ID_USUARIO='" + Txt_Modificar_Usuario_Entrenador.Text + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarEntrenador, conexion.conexion());
                OdbcCommand Query_UPDATE2 = new OdbcCommand(ModificarUsuario, conexion.conexion());

                Query_UPDATE1.ExecuteNonQuery();
                Query_UPDATE2.ExecuteNonQuery();

                MessageBox.Show("Entrenador modificado con éxito.", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_Eliminar_Buscar_Entrenador_Click(object sender, EventArgs e)
        {
            try
            {
                string BuscarEntrenador = "SELECT E.ID_ENTRENADOR, E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2,  E.FECHA_NACIMIENTO, E.ID_USUARIO_FK, U.PASSWORD," +
                " TU.NOMBRE_TIPO FROM ENTRENADOR AS E, USUARIO AS U, TIPO_USUARIO AS TU" +
                " WHERE E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO ='" + Txt_Eliminar_Usuario_Entrenador + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEntrenador, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Txt_Eliminar_Usuario_Entrenador.Text = Lector1.GetString(0);
                        Txt_Eliminar_Nombre1_Entrenador.Text = Lector1.GetString(1);
                        Txt_Eliminar_Nombre2_Entrenador.Text = Lector1.GetString(2);
                        Txt_Eliminar_Apellido1_Entrenador.Text = Lector1.GetString(3);
                        Txt_Eliminar_Apellido2_Entrenador.Text = Lector1.GetString(4);
                        Dtp_Eliminar_Fdn_Entrenador.Value.ToString(Lector1.GetString(5));
                        Txt_Eliminar_Usuario_Entrenador.Text = Lector1.GetString(6);
                        Txt_Eliminar_Password_Entrenador.Text = Lector1.GetString(7);
                        Txt_Eliminar_Tipo_Usuario_Entrenador.Text = Lector1.GetString(8);
                    }//fin while
                }//fin if
            } //fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// fin catch
        }

        private void Btn_Eliminar_Entrenador_Click(object sender, EventArgs e)
        {
            try
            {

                string EliminarEntrenador = "UPDATE ENTRENADOR SET ID_ESTADO_ENTRNADOR_FK = '" + 2 + "' WHERE ID_EMPLEADO= " + Txt_Eliminar_Id_Entrenador + "'";
                string EliminarUsuario = "UPDATE USUARIO SET ID_TIPO_USUARIO_FK = '" + 4 + "' WHERE ID_USUARIO='" + Txt_Eliminar_Usuario_Entrenador + "'";

                OdbcCommand Query_DELETE2 = new OdbcCommand(EliminarEntrenador, conexion.conexion());
                OdbcCommand Query_DELETE3 = new OdbcCommand(EliminarUsuario, conexion.conexion());

                Query_DELETE2.ExecuteNonQuery();
                Query_DELETE3.ExecuteNonQuery();

                MessageBox.Show("Eliminación Exitosa", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
