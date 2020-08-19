using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases;


namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }


        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null, SenSql2 = null;
        

        ClsMantenimientosEmpleado Ingreso = new ClsMantenimientosEmpleado();
        ClsGerencia Empleado = new ClsGerencia();
        ClsConexion conexion = new ClsConexion();
        ClsBitacora Bitacora = new ClsBitacora();

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            DatosCmb_TipoPuestoIngreso();
            DatosCmb_TipoPuestoModificar();
            DatosCmb_TipoUsuarioIngreso();
            Ingreso.ListadoEmpleados(Dgw_Listado);
            Txt_DPI_Ingreso.MaxLength = 13;
            Txt_DPI_Modificar.MaxLength = 13;
            Txt_Telefono_Ingreso.MaxLength = 8;
            Txt_Telefono_Modificar.MaxLength = 8;

        }
        

        private void Btn_Buscar_Modificar_Click(object sender, EventArgs e)
        {
            
            
            if (Txt_Busqueda_Modificar.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                
                        Cmb_TipoUsuario_Modificar.Enabled = true;
                        Empleado = Ingreso.BusquedaIDEmpleado(Txt_Busqueda_Modificar.Text);
                        Txt_Nombre1_Modificar.Text = Empleado.Nombre1;
                        Txt_Nombre2_Modificar.Text = Empleado.Nombre2;
                        Txt_Apellido1_Modificar.Text = Empleado.Apellido1;
                        Txt_Apellido2_Modificar.Text = Empleado.Apellido2;
                        Txt_Email_Modificar.Text = Empleado.Email;
                        Cmb_TipoPuesto_Modificar.Text = Empleado.TipoPuesto;
                        Txt_Direccion_Modificar.Text = Empleado.Direccion;
                        Txt_Telefono_Modificar.Text = Empleado.Telefono;
                        Dtp_FechaNacimiento_Modificar.Text = Empleado.FechaNacimiento;
                        Txt_NIT_Modificar.Text = Empleado.NIT;
                        Txt_DPI_Modificar.Text = Empleado.DPI;
                        Txt_Usuario_Modificar.Text = Empleado.ID_Usuario;
                        Dtp_FechaContrato_Modificar.Text = Empleado.FechaContrato;
                        Txt_Password_Modificar.Text = Empleado.Pasword;
                        Cmb_TipoUsuario_Modificar.Text = Empleado.TipoUsuario;
                        Btn_Modificar.Enabled = true;
                   
            }
        }

        public void DatosCmb_TipoPuestoIngreso()
        {
            try
            {

                string CargaPuestos = "SELECT * FROM TIPO_PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_TipoPuesto_Ingreso.DataSource = Datos;
                Cmb_TipoPuesto_Ingreso.DisplayMember = "NOMBRE_PUESTO";
                Cmb_TipoPuesto_Ingreso.ResetText();

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

        public void DatosCmb_TipoPuestoModificar()
        {
            try
            {

                string CargaPuestos = "SELECT * FROM TIPO_PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_TipoPuesto_Modificar.DataSource = Datos;
                Cmb_TipoPuesto_Modificar.DisplayMember = "NOMBRE_PUESTO";
                Cmb_TipoPuesto_Modificar.ResetText();

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

        public void DatosCmb_TipoUsuarioIngreso()
        {
            try
            {

                string CargaTiposUsuario = "SELECT * FROM TIPO_USUARIO WHERE ID_TIPO_USUARIO=1 or ID_TIPO_USUARIO=2";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTiposUsuario, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_TipoUsuario_Ingreso.DataSource = Datos;
                Cmb_TipoUsuario_Ingreso.DisplayMember = "NOMBRE_TIPO";
                Cmb_TipoUsuario_Ingreso.ResetText();
                Cmb_TipoUsuario_Modificar.DataSource = Datos;
                Cmb_TipoUsuario_Modificar.DisplayMember = "NOMBRE_TIPO";
                Cmb_TipoUsuario_Modificar.ResetText();

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

       

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {

            int notExecute=1;
            if (Txt_Nombre1_Ingreso.Text == "" || Txt_Apellido1_Ingreso.Text == "" || Txt_Telefono_Ingreso.Text == "" || Txt_Email_Ingreso.Text == "" || Txt_Nombre2_Ingreso.Text == "" || Txt_Apellido2_Ingreso.Text == "" || Txt_Direccion_Ingreso.Text == "" || Txt_DPI_Ingreso.Text == "" || Txt_NIT_Ingreso.Text == "" || Txt_Usuario_Ingreso.Text == "" || Txt_Password_Ingreso.Text == "" || Cmb_TipoUsuario_Ingreso.SelectedItem == null || Cmb_TipoPuesto_Ingreso == null) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                DateTime fecharNac = Dtp_FechaNacimiento_Ingreso.Value.Date;
                var diasNac = (DateTime.Now - fecharNac).TotalDays;

                if (MessageBox.Show("¿Desea agregar un nuevo empleado?", "EMPLEADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                    if (Dtp_FechaContrato_Ingreso.Value.Date < Dtp_FechaNacimiento_Ingreso.Value.Date){
                    MessageBox.Show("ADVERTENCIA: La fecha de contratación no puede menor a la fecha de nacimiento.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    notExecute = 0;
                }
                if (diasNac > 36500) {
                    MessageBox.Show("ADVERTENCIA: Edad erronea, no puede ingresar una edad mayor a 100 años.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    notExecute = 0;
                }
                
                    switch (notExecute){

                        case 1:
                            string Consulta = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO = '" + Txt_Usuario_Ingreso.Text + "' ;";
                            OdbcCommand Query_Validacion = new OdbcCommand(Consulta, conexion.conexion());
                            OdbcDataReader Lector = Query_Validacion.ExecuteReader();
                            if (Lector.HasRows == true) { MessageBox.Show("ERROR: Usuario registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else
                            {
                                UsuarioActivo = ClsDatos.UserId;
                                TipoProceso = 3;
                                SenSql1 = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ( + Usuario + , + Password + , + TipoUsuario + )";

                                SenSql2 = "INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, CORREO, ID_TIPO_PUESTO, DIRECCION, TELEFONO, FECHA_NACIMIENTO, NIT, DPI, ID_USUARIO_FK, FECHA_CONTRATO, ID_ESTADO_EMPLEADO_FK) VALUES ( + ID_Empleado + , + Nombre1 + , + Nombre2 + , + Apellido1 " +
                                    ", + Apellido2 + , + Email + , + TipoPuesto + , + Direccion + ,  + Telefono + ,  + FechaNacimiento + , + NIT + , + DPI + , + Usuario + , + FechaContrato +)";

                                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

                                int TipoUsuario, TipoPuesto;
                                TipoUsuario = Cmb_TipoUsuario_Ingreso.SelectedIndex + 1;
                                TipoPuesto = Cmb_TipoPuesto_Ingreso.SelectedIndex + 1;

                                Ingreso.IngresoEmpleado(Txt_Usuario_Ingreso.Text, Txt_Password_Ingreso.Text, TipoUsuario, Txt_Nombre1_Ingreso.Text, Txt_Nombre2_Ingreso.Text, Txt_Apellido1_Ingreso.Text, Txt_Apellido2_Ingreso.Text, Txt_Email_Ingreso.Text, TipoPuesto, Txt_Direccion_Ingreso.Text, Txt_Telefono_Ingreso.Text, Dtp_FechaNacimiento_Ingreso.Value.Date.ToShortDateString(), Txt_NIT_Ingreso.Text, Txt_DPI_Ingreso.Text, Dtp_FechaContrato_Ingreso.Value.Date.ToShortDateString());
                                Txt_Nombre1_Ingreso.Text = ""; Txt_Apellido1_Ingreso.Text = ""; Txt_Telefono_Ingreso.Text = ""; Txt_Email_Ingreso.Text = ""; Txt_Nombre2_Ingreso.Text = ""; Txt_Apellido2_Ingreso.Text = ""; Txt_Direccion_Ingreso.Text = ""; Txt_DPI_Ingreso.Text = ""; Txt_NIT_Ingreso.Text = ""; Txt_Usuario_Ingreso.Text = ""; Txt_Password_Ingreso.Text = "";
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre1_Modificar.Text == "" || Txt_Apellido1_Modificar.Text == "" || Txt_Telefono_Modificar.Text == "" || Txt_Email_Modificar.Text == "" || Txt_Nombre2_Modificar.Text == "" || Txt_Apellido2_Modificar.Text == "" || Txt_Direccion_Modificar.Text == "" || Txt_DPI_Modificar.Text == "" || Txt_NIT_Modificar.Text == "" || Txt_Usuario_Modificar.Text == "" || Txt_Password_Modificar.Text == "" || Cmb_TipoUsuario_Modificar.SelectedItem == null || Cmb_TipoPuesto_Modificar == null) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                UsuarioActivo = ClsDatos.UserId;
                TipoProceso = 1;
                SenSql1 = "UPDATE EMPLEADO SET NOMBRE1= + Nombre1 + , NOMBRE2= + Nombre2 + , " +
                    "APELLIDO1= + Apellido1 + , APELLIDO2= + Apellido2 + , CORREO= + Email +, DIRECCION= + Direccion + , TELEFONO = + Telefono + " +
                    " WHERE ID_EMPLEADO= + ID_Empleado + ";

                SenSql2 = "UPDATE USUARIO SET ID_USUARIO = + Usuario + , PASSWORD= + Password + WHERE ID_USUARIO= + Usuario + ";
                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

                int ID_Empleado = Convert.ToInt32(Txt_Busqueda_Modificar.Text);
                int Telefono = Convert.ToInt32(Txt_Telefono_Modificar.Text);
                int TipoUsuario = Cmb_TipoUsuario_Modificar.SelectedIndex + 1;
                Ingreso.ModificarEmpleado(Txt_Usuario_Modificar.Text, Txt_Password_Modificar.Text, TipoUsuario, Txt_Nombre1_Modificar.Text, Txt_Nombre2_Modificar.Text, Txt_Apellido1_Modificar.Text, Txt_Apellido2_Modificar.Text, Txt_Email_Modificar.Text, Txt_Direccion_Modificar.Text, Telefono, ID_Empleado);
                Txt_Busqueda_Modificar.Text = ""; 
                Txt_Nombre1_Modificar.Text = ""; 
                Txt_Apellido1_Modificar.Text = ""; 
                Txt_Telefono_Modificar.Text = ""; 
                Txt_Email_Modificar.Text = ""; 
                Txt_Nombre2_Modificar.Text = ""; 
                Txt_Apellido2_Modificar.Text = ""; 
                Txt_Direccion_Modificar.Text = ""; 
                Txt_DPI_Modificar.Text = ""; 
                Txt_NIT_Modificar.Text = ""; 
                Txt_Usuario_Modificar.Text = "";
                Txt_Password_Modificar.Text = "";
                Btn_Modificar.Enabled = false;
            }
        }

        private void Btn_Busqueda_Eliminar_Click(object sender, EventArgs e)
        {
            if (Txt_Busqueda_Eliminar.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                Empleado = Ingreso.BusquedaIDEmpleado(Txt_Busqueda_Eliminar.Text);
                Txt_Nombre1_Eliminar.Text = Empleado.Nombre1;
                Txt_Nombre2_Eliminar.Text = Empleado.Nombre2;
                Txt_Apellido1_Eliminar.Text = Empleado.Apellido1;
                Txt_Apellido2_Eliminar.Text = Empleado.Apellido2;
                Txt_Email_Eliminar.Text = Empleado.Email;
                Txt_Eliminar_TipoPuesto.Text = Empleado.TipoPuesto;
                Txt_Direccion_Eliminar.Text = Empleado.Direccion;
                Txt_Telefono_Eliminar.Text = Empleado.Telefono;
                Dtp_FechaNacimiento_Eliminar.Text = Empleado.FechaNacimiento;//
                Txt_NIT_Eliminar.Text = Empleado.NIT;
                Txt_DPI_Eliminar.Text = Empleado.DPI;
                Txt_Usuario_Eliminar.Text = Empleado.ID_Usuario;
                Dtp_FechaContrato_Eliminar.Text = Empleado.FechaContrato;
                Txt_Password_Eliminar.Text = Empleado.Pasword;
                Txt_Eliminar_TipoUsuario.Text = Empleado.TipoUsuario;
                Btn_Eliminar.Enabled = true;
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 2;
            SenSql1 = "UPDATE EMPLEADO SET ID_ESTADO_EMPLEADO_FK =  + 2 +  WHERE ID_EMPLEADO= + ID_Empleado + ";
            SenSql2 = "UPDATE USUARIO SET ID_TIPO_USUARIO_FK = + 4 +  WHERE ID_USUARIO= + Usuario + ";
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

            Ingreso.EliminarEmpleado(Txt_Usuario_Eliminar.Text, Txt_Busqueda_Eliminar.Text);
            Txt_Busqueda_Eliminar.Text = ""; 
            Txt_Nombre1_Eliminar.Text = ""; 
            Txt_Nombre2_Eliminar.Text = ""; 
            Txt_Apellido1_Eliminar.Text = ""; 
            Txt_Apellido2_Eliminar.Text = ""; 
            Txt_Email_Eliminar.Text = ""; 
            Txt_Eliminar_TipoPuesto.Text = ""; 
            Txt_Direccion_Eliminar.Text = ""; 
            Txt_Telefono_Eliminar.Text = ""; 
            Dtp_FechaNacimiento_Eliminar.Text = ""; 
            Txt_NIT_Eliminar.Text = ""; 
            Txt_DPI_Eliminar.Text = ""; 
            Txt_Usuario_Eliminar.Text = ""; 
            Dtp_FechaContrato_Eliminar.Text = ""; 
            Txt_Password_Eliminar.Text = ""; 
            Txt_Eliminar_TipoUsuario.Text = "";
            Btn_Eliminar.Enabled = false;
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
