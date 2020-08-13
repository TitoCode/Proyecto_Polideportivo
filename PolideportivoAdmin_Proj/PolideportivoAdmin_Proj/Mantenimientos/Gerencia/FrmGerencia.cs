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
using PolideportivoAdmin_Proj.Clases.ClsGerencia;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmGerencia : Form
    {
        public FrmGerencia()
        {
            InitializeComponent();
            
        }

        ClsConexion conexion = new ClsConexion();
        ClsMantenimientosEmpleado Ingreso = new ClsMantenimientosEmpleado();
        ClsGerencia Empleado = new ClsGerencia();

        private void FrmGerencia_Load(object sender, EventArgs e)
        {
            DatosCmb_TipoPuestoIngreso();
            DatosCmb_TipoPuestoModificar();
            DatosCmb_TipoUsuarioIngreso();
            DatosCmb_TipoUsuarioModificar();
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

                string CargaTiposUsuario = "SELECT * FROM TIPO_USUARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTiposUsuario, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_TipoUsuario_Ingreso.DataSource = Datos;
                Cmb_TipoUsuario_Ingreso.DisplayMember = "NOMBRE_TIPO";
                Cmb_TipoUsuario_Ingreso.ResetText();

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

        public void DatosCmb_TipoUsuarioModificar()
        {
            try
            {

                string CargaTiposUsuario = "SELECT * FROM TIPO_USUARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTiposUsuario, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

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
            int TipoUsuario, TipoPuesto;
            TipoUsuario = Cmb_TipoUsuario_Ingreso.SelectedIndex + 1;
            TipoPuesto = Cmb_TipoPuesto_Ingreso.SelectedIndex + 1;
            
            Ingreso.IngresoEmpleado(Txt_Usuario_Ingreso.Text, Txt_Password_Ingreso.Text, TipoUsuario, Txt_Nombre1_Ingreso.Text, Txt_Nombre2_Ingreso.Text, Txt_Apellido1_Ingreso.Text, Txt_Apellido2_Ingreso.Text, Txt_Email_Ingreso.Text, TipoPuesto, Txt_Direccion_Ingreso.Text, Txt_Telefono_Ingreso.Text, Dtp_FechaNacimiento_Ingreso.Value.ToString(), Txt_NIT_Ingreso.Text, Txt_DPI_Ingreso.Text, Dtp_FechaContrato_Ingreso.Value.ToString());

        }

        private void Btn_Buscar_Modificar_Click(object sender, EventArgs e)
        {
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
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            int ID_Empleado = Convert.ToInt32(Txt_Busqueda_Modificar.Text);
            int Telefono = Convert.ToInt32(Txt_Telefono_Modificar.Text);
            Ingreso.ModificarEmpleado(Txt_Usuario_Modificar.Text, Txt_Password_Modificar.Text, Txt_Nombre1_Modificar.Text, Txt_Nombre2_Modificar.Text, Txt_Apellido1_Modificar.Text, Txt_Apellido2_Modificar.Text, Txt_Email_Modificar.Text, Txt_Direccion_Modificar.Text, Telefono, ID_Empleado);

        }

        private void Btn_Empleado_Click(object sender, EventArgs e)
        {
            Tbc_Empleados.Visible = true;
        }

        private void Btn_Busqueda_Eliminar_Click(object sender, EventArgs e)
        {
            
            Empleado = Ingreso.BusquedaIDEmpleado(Txt_Busqueda_Eliminar.Text);
            Txt_Nombre1_Eliminar.Text = Empleado.Nombre1;
            Txt_Nombre2_Eliminar.Text = Empleado.Nombre2;
            Txt_Apellido1_Eliminar.Text = Empleado.Apellido1;
            Txt_Apellido2_Eliminar.Text = Empleado.Apellido2;
            Txt_Email_Eliminar.Text = Empleado.Email;
            Cmb_TipoPuesto_Eliminar.Text = Empleado.TipoPuesto;
            Txt_Direccion_Eliminar.Text = Empleado.Direccion;
            Txt_Telefono_Eliminar.Text = Empleado.Telefono;
            Dtp_FechaNacimiento_Eliminar.Text = Empleado.FechaNacimiento;
            Txt_NIT_Eliminar.Text = Empleado.NIT;
            Txt_DPI_Eliminar.Text = Empleado.DPI;
            Txt_Usuario_Eliminar.Text = Empleado.ID_Usuario;
            Dtp_FechaContrato_Eliminar.Text = Empleado.FechaContrato;
            Txt_Password_Eliminar.Text = Empleado.Pasword;
            Cmb_TipoUsuario_Eliminar.Text = Empleado.TipoUsuario;

        }
    }
}
