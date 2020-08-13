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
    }
}
