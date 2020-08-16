using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsGerencia
{
    class ClsMantenimientosEmpleado
    {
        ClsConexion conexion = new ClsConexion();
        ClsGerencia Empleado = new ClsGerencia();

        public void IngresoEmpleado(string Usuario, string Password, int TipoUsuario, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string Email, int TipoPuesto, string Direccion, string Telefono, string FechaNacimiento, string NIT, string DPI, string FechaContrato )
        {

            try
            {

                int ID_Empleado;
                string Correlativo = "SELECT IFNULL(MAX(ID_EMPLEADO),0) +1 FROM EMPLEADO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                ID_Empleado = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();


                string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + Usuario + "','" + Password + "'," + TipoUsuario + ")";
                string InsertarEmpleado = "INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, CORREO, ID_TIPO_PUESTO, DIRECCION, TELEFONO, FECHA_NACIMIENTO, NIT, DPI, ID_USUARIO_FK, FECHA_CONTRATO, ID_ESTADO_EMPLEADO_FK) VALUES ('" + ID_Empleado + "','" + Nombre1 + "','" + Nombre2 + "','" + Apellido1 +
                "','" + Apellido2 + "','" + Email + "','" + TipoPuesto + "','" + Direccion + "', '"+ Telefono + "', '" + FechaNacimiento + "','" + NIT + "','" + DPI + "','" + Usuario + "','" + FechaContrato + "','" + 1 + "')";

                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarUsuario, conexion.conexion());
                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarEmpleado, conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();
                Query_Validacion3.ExecuteNonQuery();

                

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO EMPLEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void ModificarEmpleado(string Usuario, string Password, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string Email, string Direccion, int Telefono, int ID_Empleado)
        {
            try
            {

                string ModificarEmpleado = "UPDATE EMPLEADO SET NOMBRE1='" + Nombre1 + "', NOMBRE2='" + Nombre2 +
                                           "', APELLIDO1='" + Apellido1 + "', APELLIDO2='" + Apellido2 + "', CORREO='" + Email +
                                           "', DIRECCION='" + Direccion + "', TELEFONO ='"+ Telefono +"' WHERE ID_EMPLEADO='" + ID_Empleado + "'";

                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO='" + Usuario + "', PASSWORD='" + Password + 
                                          "' WHERE ID_USUARIO='" + Usuario + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarEmpleado, conexion.conexion());
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

        public void EliminarEmpleado(string Usuario, string ID_Empleado)
        {

            try
            {

                string EliminarEmpleado = "UPDATE EMPLEADO SET ID_ESTADO_EMPLEADO_FK = '" + 2 + "' WHERE ID_EMPLEADO= '" + ID_Empleado + "'";
                string EliminarUsuario = "UPDATE USUARIO SET ID_TIPO_USUARIO_FK = '" + 4 + "' WHERE ID_USUARIO='" + Usuario + "'";

                OdbcCommand Query_DELETE2 = new OdbcCommand(EliminarEmpleado, conexion.conexion());
                OdbcCommand Query_DELETE3 = new OdbcCommand(EliminarUsuario, conexion.conexion());

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

        public ClsGerencia BusquedaIDEmpleado(string ID_Empleado)
        {  

            try
            {
                
                string BuscarDatoEmpleado = "SELECT E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2, E.CORREO, T.NOMBRE_PUESTO, E.DIRECCION, E.TELEFONO, E.FECHA_NACIMIENTO, E.NIT, E.DPI, E.ID_USUARIO_FK, E.FECHA_CONTRATO, S.NOMBRE_ESTADO, U.PASSWORD, TU.NOMBRE_TIPO FROM EMPLEADO AS E, TIPO_PUESTO AS T, USUARIO AS U, ESTADO_EMPLEADO AS S, TIPO_USUARIO AS TU WHERE T.ID_TIPO_PUESTO = E.ID_TIPO_PUESTO AND S.ID_ESTADO_EMPLEADO = E.ID_ESTADO_EMPLEADO_FK AND E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_EMPLEADO ='" + ID_Empleado + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {

                    while (Lector1.Read())
                    {

                        Empleado.Nombre1 = Lector1.GetString(0);
                        Empleado.Nombre2 = Lector1.GetString(1);
                        Empleado.Apellido1 = Lector1.GetString(2);
                        Empleado.Apellido2 = Lector1.GetString(3);
                        Empleado.Email = Lector1.GetString(4);
                        Empleado.TipoPuesto = Lector1.GetString(5);
                        Empleado.Direccion = Lector1.GetString(6);
                        Empleado.Telefono = Lector1.GetString(7);
                        Empleado.FechaNacimiento = Lector1.GetString(8);
                        Empleado.NIT = Lector1.GetString(9);
                        Empleado.DPI = Lector1.GetString(10);
                        Empleado.ID_Usuario = Lector1.GetString(11);
                        Empleado.FechaContrato = Lector1.GetString(12);
                        Empleado.Estado_Empleado = Lector1.GetString(13);
                        Empleado.Pasword = Lector1.GetString(14);
                        Empleado.TipoUsuario = Lector1.GetString(15);

                    }

                }

                return Empleado;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return Empleado;
            }

        }

        public void ActualizarPerfil(string Usuario, string Password, byte[] Foto)
        {
            
            try
            {

                string CambiarFoto = "UPDATE EMPLEADO SET FOTOGRAFIA ='"+ Foto +"' WHERE ID_USUARIO_FK='" + Usuario + "'";
                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO='" + Usuario + "', PASSWORD='" + Password +
                                          "' WHERE ID_USUARIO='" + Usuario + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(CambiarFoto, conexion.conexion());
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
