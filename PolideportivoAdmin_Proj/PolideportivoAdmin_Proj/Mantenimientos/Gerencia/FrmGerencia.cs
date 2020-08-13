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

        ClsConexion conexion = new ClsConexion();

        private void FrmGerencia_Load(object sender, EventArgs e)
        {
            DatosCmb_TipoPuesto();
            DatosCmb_TipoUsuario();
        }

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {
            try
            {

                string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + Txt_Usuario.Text + "','" + Txt_Password.Text + "'," + Cmb_TipoUsuario.Text + ")";
                string InsertarEmpleado = "INSERT INTO EMPLEADO (NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, CORREO, ID_TIPO_PUESTO, DIRECCION, FECHA_NACIMIENTO, NIT, DPI, ID_USUARIO_FK, FECHA_CONTRATO) VALUES ('" + Txt_Nombre1.Text + "','" + Txt_Nombre2.Text + "','" + Txt_Apellido1.Text +
                "','" + Txt_Apellido2.Text + "','" + Txt_Email.Text + "','" + Cmb_TipoPuesto.Text + "','" + Txt_Direccion.Text + "','" + Txt_FechaNacimiento.Text + "','" + Txt_NIT.Text + "','" + Txt_DPI.Text + "','" + Txt_Usuario.Text + "','" + Txt_FechaContrato.Text + "')";

                OdbcCommand Query_Validacion1 = new OdbcCommand(InsertarUsuario, conexion.conexion());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarEmpleado, conexion.conexion());
                OdbcDataReader Ejecucion2 = Query_Validacion2.ExecuteReader();

                string ID_Empleado;
                string BusquedaID = "SELECT MAX(ID_EMPLEADO) FROM EMPLEADO ORDER BY ID_EMPLEADO DESC";
                OdbcCommand Query_Validacion3 = new OdbcCommand(BusquedaID, conexion.conexion());
                ID_Empleado = Convert.ToString(Query_Validacion3.ExecuteScalar());
                OdbcDataReader Ejecucion3 = Query_Validacion3.ExecuteReader();

                string InsertarTelefono = "INSERT INTO TELEFONO (TELEFONO, ID_EMPLEADO_FK) VALUES ('" + Txt_Telefono.Text + "'," + ID_Empleado + ")";
                OdbcCommand Query_Validacion4 = new OdbcCommand(InsertarTelefono, conexion.conexion());
                OdbcDataReader Ejecucion4 = Query_Validacion4.ExecuteReader();

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO EMPLEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Btn_EliminarEmpleado_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Seguro que quiere borrar este empleado?", "FORMULARIO EMPLEADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                Btn_EliminarEmpleado.Focus();
            }
            else
            {
                try
                {

                    string EliminarTelefono = "DELETE FROM TELEFONO WHERE ID_TELEFONO ='" + Lbl_IDTelefono.Text + "'";
                    string EliminarEmpleado = "DELETE FROM EMPLEADO WHERE ID_EMPLEADO=" + Txt_IDEmpleado.Text;
                    string EliminarUsuario = "DELETE FROM USUARIO WHERE ID_USUARIO='" + Lbl_IDUsuario.Text + "'";

                    OdbcCommand Query_DELETE1 = new OdbcCommand(EliminarTelefono, conexion.conexion());
                    OdbcCommand Query_DELETE2 = new OdbcCommand(EliminarEmpleado, conexion.conexion());
                    OdbcCommand Query_DELETE3 = new OdbcCommand(EliminarUsuario, conexion.conexion());

                    Query_DELETE1.ExecuteNonQuery();
                    Query_DELETE2.ExecuteNonQuery();
                    Query_DELETE3.ExecuteNonQuery();

                    MessageBox.Show("Eliminación Exitosa", "FORMULARIO EMPLEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            
            try
            {

                string ModificarTelefono = "UPDATE TELEFONO SET TELEFONO='" + Txt_Telefono.Text + "' WHERE ID_TELEFONO='" + Lbl_Telefono.Text + "'";
                string ModificarEmpleado = "UPDATE EMPLEADO SET NOMBRE1='" + Txt_Nombre1.Text + "', NOMBRE2='" + Txt_Nombre2.Text +
                    "', APELLIDO1='" + Txt_Apellido1.Text + "', APELLIDO2='" + Txt_Apellido2.Text + "', CORREO='" + Txt_Email.Text +
                    "', DIRECCION='" + Txt_Direccion.Text + "'WHERE ID_EMPLEADO='" + Txt_IDEmpleado.Text + "'";
                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO='" + Txt_Usuario.Text + "', PASSWORD='" + Txt_Password.Text + "' WHERE ID_USUARIO='" + Txt_Usuario.Text + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarTelefono, conexion.conexion());
                OdbcCommand Query_UPDATE2 = new OdbcCommand(ModificarEmpleado, conexion.conexion());
                OdbcCommand Query_UPDATE3 = new OdbcCommand(ModificarUsuario, conexion.conexion());

                Query_UPDATE1.ExecuteNonQuery();
                Query_UPDATE2.ExecuteNonQuery();
                Query_UPDATE3.ExecuteNonQuery();

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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                              
                string BuscarDatoTelefono = "SELECT * FROM TELEFONO WHERE ID_EMPLEADO_FK ='" + Txt_IDEmpleado.Text + "'";
                string BuscarDatoEmpleado = "SELECT * FROM EMPLEADO WHERE ID_EMPLEADO ='" + Txt_IDEmpleado.Text + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoTelefono, conexion.conexion());
                OdbcCommand Query_Busqueda2 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());

                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();
                OdbcDataReader Lector2 = Query_Busqueda2.ExecuteReader();

                if (Lector1.HasRows == true && Lector2.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Lbl_IDTelefono.Text = Lector1.GetString(0);
                        Txt_Telefono.Text = Lector1.GetString(1);

                    }

                    while (Lector2.Read())
                    {

                        Txt_Nombre1.Text = Lector2.GetString(1);
                        Txt_Nombre2.Text = Lector2.GetString(2);
                        Txt_Apellido1.Text = Lector2.GetString(3);
                        Txt_Apellido2.Text = Lector2.GetString(4);
                        Txt_Email.Text = Lector2.GetString(5);
                        Txt_Direccion.Text = Lector2.GetString(7);
                        Txt_FechaNacimiento.Text = Lector2.GetString(8);
                        Txt_NIT.Text = Lector2.GetString(9);
                        Txt_DPI.Text = Lector2.GetString(10);
                        Lbl_IDUsuario.Text = Lector2.GetString(11);
                        Txt_FechaContrato.Text = Lector2.GetString(12);


                    }

                    string BuscarDatoUsuario = "SELECT * FROM USUARIO WHERE ID_USUARIO ='" + Lbl_IDUsuario.Text + "'";
                    OdbcCommand Query_Busqueda3 = new OdbcCommand(BuscarDatoUsuario, conexion.conexion());
                    OdbcDataReader Lector3 = Query_Busqueda3.ExecuteReader();

                    while (Lector3.Read())
                    {

                        Txt_Usuario.Text = Lector3.GetString(0);
                        Txt_Password.Text = Lector3.GetString(1);

                    }

                }

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

        public void DatosCmb_TipoPuesto()
        {
            try
            {

                string CargaPuestos = "SELECT * FROM TIPO_PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_TipoPuesto.DataSource = Datos;
                Cmb_TipoPuesto.DisplayMember = "NOMBRE_PUESTO";
                Cmb_TipoPuesto.ResetText();

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

        public void DatosCmb_TipoUsuario()
        {
            try
            {

                string CargaTiposUsuario = "SELECT * FROM TIPO_USUARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTiposUsuario, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_TipoUsuario.DataSource = Datos;
                Cmb_TipoUsuario.DisplayMember = "NOMBRE_TIPO";
                Cmb_TipoUsuario.ResetText();

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

        private void Cmb_TipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Estadistica_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Empleado_Click(object sender, EventArgs e)
        {

        }
    }
}
