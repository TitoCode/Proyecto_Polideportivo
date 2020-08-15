using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsAdmin
{
    
    class ClsMantenimientosAdmin
    {
        ClsConexion conexion = new ClsConexion();
        ClsEntrenador Entrenador = new ClsEntrenador();
        public void IngresoEntrenador(string Usuario, string Password, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNacimiento, byte[] Foto)
        {
            try
            {
                int ID_Entrenador;
                string Correlativo = "SELECT IFNULL(MAX(ID_ENTRENADOR),0) +1 FROM ENTRENADOR";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                ID_Entrenador = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

                string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + Usuario + "','" + Password + "'," + 2 + ")";
                string InsertarEntrenador = "INSERT INTO ENTRENADOR (ID_ENTRENADOR, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO, ID_USUARIO_FK, FOTO_ENTRENADOR) VALUES ('"
                    + ID_Entrenador + "','"+ Nombre1 + "','" + Nombre2 + "','" + Apellido1 + "','" + Apellido2 + "','" + FechaNacimiento + "','" + Usuario + "','" + Foto + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarUsuario, conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();
                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarEntrenador, conexion.conexion());
                Query_Validacion3.ExecuteNonQuery();

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

        public void ModificarEntrenador(string ID_Entrenador, string Usuario, string Password, string Nombre1, string Nombre2, string Apellido1, string Apellido2)
        {
            try
            {
                string ModificarEntrenador = "UPDATE ENTRENADOR SET NOMBRE1='" + Nombre1 + "', NOMBRE2='" + Nombre2 +
                                          "', APELLIDO1='" + Apellido1 + "', APELLIDO2='" + Apellido2 +
                                          "' WHERE ID_ENTRENADOR='" + ID_Entrenador + "'";

                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO='" + Usuario + "', PASSWORD='" + Password +
                                          "' WHERE ID_USUARIO='" + Usuario + "'";

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

        public ClsEntrenador BusquedaIDEntrenador(string ID_Entrenador)
        {
            try
            {
                string BuscarEntrenador = "SELECT E.ID_ENTRENADOR, E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2,  E.FECHA_NACIMIENTO, E.ID_USUARIO_FK, U.PASSWORD," +
                                " TU.NOMBRE_TIPO FROM ENTRENADOR AS E, USUARIO AS U, TIPO_USUARIO AS TU" +
                                " WHERE U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_ENTRENADOR ='" + ID_Entrenador + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEntrenador, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        Entrenador.ID_Entrenador = Lector.GetString(0);
                        Entrenador.Nombre1 = Lector.GetString(1);
                        Entrenador.Nombre2 = Lector.GetString(2);
                        Entrenador.Apellido1 = Lector.GetString(3);
                        Entrenador.Apellido2 = Lector.GetString(4);
                        Entrenador.FechaNacimiento = Lector.GetString(5);
                        Entrenador.ID_Usuario = Lector.GetString(6);
                        Entrenador.Pasword = Lector.GetString(7);
                        Entrenador.TipoUsuario = Lector.GetString(8);
                    }
                }
                return Entrenador;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Entrenador;
            }

        }

        public void EliminarEntrenador(string Usuario, string Id_Entrenador)
        {
            try
            {

                string EliminarEntrenador = "UPDATE ENTRENADOR SET ID_ESTADO_ENTRENADOR_FK = '" + 2 + "' WHERE ID_ENTRENADOR= '" + Id_Entrenador + "'";
                string EliminarUsuario = "UPDATE USUARIO SET ID_TIPO_USUARIO_FK = '" + 4 + "' WHERE ID_USUARIO='" + Usuario + "'";

                OdbcCommand Query_DELETE1 = new OdbcCommand(EliminarEntrenador, conexion.conexion());
                OdbcCommand Query_DELETE2 = new OdbcCommand(EliminarUsuario, conexion.conexion());

                Query_DELETE1.ExecuteNonQuery();
                Query_DELETE2.ExecuteNonQuery();

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

        //public void IngresoEquipo(string ID_Entrenador, string ID_TipoDeporte, string Nombre)
        //{
        //    try
        //    {
        //        int Id_Entrenador, Id_Tipo_Deporte;
        //        Id_Entrenador = Cbx_Crear_Entrenador.SelectedIndex + 1;
        //        Id_Tipo_Deporte = Cbx_Crear_Deporte.SelectedIndex + 1;

        //        int ID_Equipo;
        //        string Correlativo = "SELECT IFNULL(MAX(ID_EQUIPO),0) +1 FROM EQUIPO";
        //        OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
        //        ID_Equipo = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
        //        OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

        //        string InsertarEquipo = "INSERT INTO EQUIPO (ID_EQUIPO, NOMBRE_EQUIPO, ID_ENTRENADOR_FK, ID_TIPO_DEPORTE_FK, ID_ESTADO_EQUIPO_FK)" +
        //            "VALUES('" + ID_Equipo + "','" + Nombre + "','" + ID_Entrenador + "','" + ID_TipoDeporte + "','" + 1 + "')";

        //        OdbcCommand Query_Validacion1 = new OdbcCommand(InsertarEquipo, conexion.conexion());
        //        Query_Validacion1.ExecuteNonQuery();

        //        MessageBox.Show("Ingreso Exitoso", "FORMULARIO EQUIPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al ejecutar SQL: " +
        //        System.Environment.NewLine + System.Environment.NewLine +
        //        ex.GetType().ToString() + System.Environment.NewLine +
        //        ex.Message, "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void ModificarEquipo()
        //{
        //    try
        //    {
        //        string ModificarEquipo = "UPDATE EQUIPO SET NOMBRE_EQUIPO='" + Txt_Editar_Nombre_Equipo + "'ID_ENTRENADOR_FK='"
        //            + Cbx_Editar_Entrenador + "' ID_TIPO_DEPORTE_FK='" + Cbx_Editar_Deporte + "WHERE ID_EQUIPO=" + Txt_Modificar_Id_Equipo + "'";

        //        OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarEquipo, conexion.conexion());
        //        Query_UPDATE1.ExecuteNonQuery();

        //        MessageBox.Show("Equipo modificado con éxito.", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al ejecutar SQL: " +
        //        System.Environment.NewLine + System.Environment.NewLine +
        //        ex.GetType().ToString() + System.Environment.NewLine +
        //        ex.Message, "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void EliminarEquipo()
        //{
        //    try
        //    {
        //        string BuscarEquipos = "SELECT * FROM EQUIPOS" + " WHERE NOMBRE_EQUIPO =" + Txt_Eliminar_Nombre_Equipo.Text;

        //        OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEquipos, conexion.conexion());
        //        OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

        //        if (Lector1.HasRows == true)
        //        {
        //            while (Lector1.Read())
        //            {
        //                Txt_Eliminar_Id_Equipo.Text = Lector1.GetString(0);
        //                Txt_Eliminar_Nombre_Equipo.Text = Lector1.GetString(1);
        //                Cbx_Eliminar_Entrenador.Text = Lector1.GetString(2);
        //                Cbx_Eliminar_Deporte.Text = Lector1.GetString(3);
        //            }//fin while
        //        }//fin if
        //    }//fin try

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al ejecutar SQL: " +
        //        System.Environment.NewLine + System.Environment.NewLine +
        //        ex.GetType().ToString() + System.Environment.NewLine +
        //        ex.Message, "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }//fin catch
        //}

        //public void BusquedaIDEquipo(string ID_Equipo)
        //{
        //    try
        //    {
        //        string BuscarEquipos = "SELECT * FROM EQUIPO WHERE ID_EQUIPO =" + ID_Equipo;

        //        OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEquipos, conexion.conexion());
        //        OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

        //        if (Lector1.HasRows == true)
        //        {
        //            while (Lector1.Read())
        //            {
        //                Txt_Modificar_Id_Equipo.Text = Lector1.GetString(0);
        //                Txt_Editar_Nombre_Equipo.Text = Lector1.GetString(1);
        //                Cbx_Editar_Entrenador.Text = Lector1.GetString(2);
        //                Cbx_Editar_Deporte.Text = Lector1.GetString(3);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al ejecutar SQL: " +
        //        System.Environment.NewLine + System.Environment.NewLine +
        //        ex.GetType().ToString() + System.Environment.NewLine +
        //        ex.Message, "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
    }
}
