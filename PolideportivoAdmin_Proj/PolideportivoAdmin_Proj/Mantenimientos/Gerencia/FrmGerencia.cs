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

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmGerencia : Form
    {
        public FrmGerencia()
        {
            InitializeComponent();
        }
        ClsConexion conex = new ClsConexion();

        public void Conversion()
        {
            //Revisar
            try
            {
                
                string ObtenerCombo = "Select ID_TIPO_PUESTO, NOMBRE_PUESTO FROM TIPO_PUESTO";
                DataTable llenado = new DataTable();
                OdbcCommand Query_Validacion = new OdbcCommand(ObtenerCombo, conex.conexion());
                OdbcDataReader Lector = Query_Validacion.ExecuteReader();
                
                CmbTipoUsuario.DisplayMember = "NOMBRE_PUESTO";
                CmbTipoUsuario.ValueMember = "ID_TIPO_PUESTO";
                CmbTipoUsuario.SelectedValue = Lector;
                while (Lector.Read())
                {
                    string column = Lector["ColumnName"].ToString();
                    int columnValue = Convert.ToInt32(Lector["ColumnName"]);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//fin del try


        }
        private void button1_Click(object sender, EventArgs e)
        {

           
          try
           {
              
               string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + TxtNomUsuario.Text + "','" + TxtPassword.Text + "'," + CmbTipoUsuario.Text+ ")";
               string InsertarEmpleado = "INSERT INTO TIPO_PUESTO (NOMBRE_PUESTO, SALARIO) VALUES ('" + TxtNomPuesto.Text + "'," + TxtSalario.Text + ")";
               string InsertarTelefono = "INSERT INTO EMPLEADO (NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, CORREO, DIRECCION, FECHA_NACIMIENTO,NIT,DPI,ID_USUARIO_FK) VALUES ('" + TxtNombre1.Text + "','" + TxtNombre2.Text + "','" + TxtApellido1.Text + 
               "','"+TxtApellido2.Text+"','"+TxtCorreo.Text+"','"+TxtDireccion.Text+"','"+TxtFechaNac.Text+"','"+TxtNit.Text+"','"+TxtDPI.Text+"','"+ TxtNomUsuario.Text+"')";
               string InsertarTipoPuesto = "INSERT INTO TELEFONO (ID_TELEFONO, ID_EMPLEADO_FK) VALUES ('" + TxtTelefono.Text + "','" + TxtNomUsuario.Text + "')";

                OdbcCommand Query_Validacion1 = new OdbcCommand(InsertarUsuario, conex.conexion());
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarEmpleado, conex.conexion());
                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarTelefono, conex.conexion());
                OdbcCommand Query_Validacion4 = new OdbcCommand(InsertarTipoPuesto, conex.conexion());

                OdbcDataReader Lector1 = Query_Validacion1.ExecuteReader();
                OdbcDataReader Lector2 = Query_Validacion2.ExecuteReader();
                OdbcDataReader Lector3 = Query_Validacion3.ExecuteReader();
                OdbcDataReader Lector4 = Query_Validacion4.ExecuteReader();
            }
           catch (Exception ex){

               MessageBox.Show("Error al ejecutar SQL: " +
                   System.Environment.NewLine + System.Environment.NewLine +
                   ex.GetType().ToString() + System.Environment.NewLine +
                   ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

           }//fin del try


        }

        private void FrmGerencia_Load(object sender, EventArgs e)
        {
            CmbTipoUsuario.Items.Add("3");
            CmbTipoUsuario.Items.Add("2");
            CmbTipoUsuario.Items.Add("1");
           // Conversion();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
