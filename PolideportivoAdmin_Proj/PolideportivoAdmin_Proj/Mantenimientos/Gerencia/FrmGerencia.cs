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
           
            try
            {
                
                string ObtenerCombo = "Select ID_TIPO_PUESTO, NOMBRE_PUESTO FROM TIPO_PUESTO";
                DataTable llenado = new DataTable();
                OdbcCommand Query_Validacion = new OdbcCommand(ObtenerCombo, conex.conexion());
                OdbcDataReader Lector = Query_Validacion.ExecuteReader();
                
                Cmb_TipoUsuario.DisplayMember = "NOMBRE_PUESTO";
                Cmb_TipoUsuario.ValueMember = "ID_TIPO_PUESTO";
                Cmb_TipoUsuario.SelectedValue = Lector;
             


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
              
               string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + Txt_NomUsuario.Text + "','" + Txt_Password.Text + "'," + Cmb_TipoUsuario.Text+ ")";
               
               string InsertarEmpleado = "INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, CORREO,ID_TIPO_PUESTO, DIRECCION, FECHA_NACIMIENTO,NIT,DPI,ID_USUARIO_FK) VALUES ('"+ID_Empleado.Text+"','" + Txt_Nombre1.Text + "','" + Txt_Nombre2.Text + "','" + Txt_Apellido1.Text + 
               "','"+Txt_Apellido2.Text+"','"+Txt_Correo.Text+"','"+ Cmb_TipoPuesto.Text+ "','"+Txt_Direccion.Text+"','"+Txt_FechaNac.Text+"','"+Txt_Nit.Text+"','"+Txt_DPI.Text+"','"+ Txt_NomUsuario.Text+"')";
               string InsertarTelefono = "INSERT INTO TELEFONO (ID_TELEFONO, ID_EMPLEADO_FK) VALUES ('" + Txt_Telefono.Text + "','" + ID_Empleado.Text + "')";
                
                OdbcCommand Query_Validacion1 = new OdbcCommand(InsertarUsuario, conex.conexion());
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarEmpleado, conex.conexion());
                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarTelefono, conex.conexion());
               

                OdbcDataReader Lector1 = Query_Validacion1.ExecuteReader();
                OdbcDataReader Lector2 = Query_Validacion2.ExecuteReader();
                OdbcDataReader Lector3 = Query_Validacion3.ExecuteReader();
               

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
           //Llenado Manual Combo Cmb_TipoUsuario
           Cmb_TipoUsuario.Items.Add("3");
           Cmb_TipoUsuario.Items.Add("2");
           Cmb_TipoUsuario.Items.Add("1");
            //Conversion();
            //Llenado Manual Combo Cmb_TipoPuesto
            Cmb_TipoPuesto.Items.Add("1");
            Cmb_TipoPuesto.Items.Add("2");
            Cmb_TipoPuesto.Items.Add("3");
            Cmb_TipoPuesto.Items.Add("4");
            Cmb_TipoPuesto.Items.Add("5");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                string InsertarPuesto = "INSERT INTO TIPO_PUESTO (ID_TIPO_PUESTO, NOMBRE_PUESTO, SALARIO) VALUES ('" + textBox1.Text + "','" + Txt_NomPuesto.Text + "','" + Txt_Salario.Text + "')";
            OdbcCommand Query_Validacion4 = new OdbcCommand(InsertarPuesto, conex.conexion());
            OdbcDataReader Lector4 = Query_Validacion4.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//fin del try*/

        }
    }
}
