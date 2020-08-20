using System;
using System.Collections.Generic;
using System.Data;
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
        ClsEquipo Equipo = new ClsEquipo();
        public void IngresoEntrenador(string Usuario, string Password, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNacimiento, byte[] Foto)
        {
            try
            {
                int ID_Entrenador;
                string Correlativo = "SELECT IFNULL(MAX(ID_ENTRENADOR),0) +1 FROM ENTRENADOR";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                ID_Entrenador = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

                string InsertarUsuario = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ('" + Usuario + "','" + Password + "'," + 3 + ")";
                string InsertarEntrenador = "INSERT INTO ENTRENADOR (ID_ENTRENADOR, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO, ID_USUARIO_FK, FOTO_ENTRENADOR, ID_ESTADO_ENTRENADOR_FK) VALUES ('"
                    + ID_Entrenador + "','"+ Nombre1 + "','" + Nombre2 + "','" + Apellido1 + "','" + Apellido2 + "','" + FechaNacimiento + "','" + Usuario + "','" + Foto + "', '"+ 1 +"')";
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

                string ModificarUsuario = "UPDATE USUARIO SET ID_USUARIO ='" + Usuario + "', PASSWORD = '" + Password +"' WHERE ID_USUARIO='" + Usuario + "'";

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
                                " WHERE U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_ENTRENADOR ='" + ID_Entrenador + "'AND E.ID_USUARIO_FK = U.ID_USUARIO";

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
                else
                {
                    MessageBox.Show("ERROR: El codigo de entrenador no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public void IngresoEquipo(int ID_Entrenador, int ID_TipoDeporte, string Nombre)
        {
            try
            {
                int ID_Equipo;
                string Correlativo = "SELECT IFNULL(MAX(ID_EQUIPO),0) +1 FROM EQUIPO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                ID_Equipo = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                string InsertarEquipo = "INSERT INTO EQUIPO (ID_EQUIPO, NOMBRE_EQUIPO, ID_ENTRENADOR_FK, ID_TIPO_DEPORTE__FK, ID_ESTADO_EQUIPO_FK)" +
                    "VALUES('" + ID_Equipo + "','" + Nombre + "','" + ID_Entrenador + "','" + ID_TipoDeporte + "','" + 1 + "')";

                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarEquipo, conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO EQUIPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ModificarEquipo(string Nombre, string Id_Equipo)
        {
            try
            {
                string ModificarEquipo = "UPDATE EQUIPO SET NOMBRE_EQUIPO='" + Nombre + "' WHERE ID_EQUIPO='" + Id_Equipo + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarEquipo, conexion.conexion());
                Query_UPDATE1.ExecuteNonQuery();

                MessageBox.Show("Equipo modificado con éxito.", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void EliminarEquipo(string Id_Equipo)
        {
            try
            {
                string EliminarEquipos = "UPDATE EQUIPO SET ID_ESTADO_EQUIPO_FK='" + 3 + "' WHERE ID_EQUIPO='" + Id_Equipo + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(EliminarEquipos, conexion.conexion());
                Query_UPDATE1.ExecuteNonQuery();

                MessageBox.Show("Equipo eliminado con éxito.", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public ClsEquipo BusquedaIDEquipo(string ID_Equipo)
        {
            string NombreCompletoEntrenador;
            try
            {
                string BuscarEquipos = "SELECT E.NOMBRE_EQUIPO, EN.NOMBRE1, EN.NOMBRE2, EN.APELLIDO1, EN.APELLIDO2, " +
                    "TP.NOMBRE_DEPORTE FROM EQUIPO AS E, ENTRENADOR AS EN, TIPO_DEPORTE AS TP" +
                    " WHERE ID_EQUIPO ='" + ID_Equipo+ "' AND E.ID_ENTRENADOR_FK = EN.ID_ENTRENADOR and tp.ID_TIPO_DEPORTE = E.ID_TIPO_DEPORTE__FK";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarEquipos, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        NombreCompletoEntrenador = "";
                        NombreCompletoEntrenador += Lector1.GetString(1) + " ";
                        NombreCompletoEntrenador += Lector1.GetString(2) + " ";
                        NombreCompletoEntrenador += Lector1.GetString(3) + " ";
                        NombreCompletoEntrenador += Lector1.GetString(4);
                        Equipo.ID_Entrenador = NombreCompletoEntrenador;
                        Equipo.Nombre = Lector1.GetString(0);
                        Equipo.ID_TipoDeporte = Lector1.GetString(5);
                    }
                }
                else {
                    MessageBox.Show("ERROR: El codigo del equipo no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                return Equipo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Equipo;
            }

        }

        public void ListadoEntrenadores(DataGridView Listado)
        {

            try
            {

                string MostrarEntrenadores = "SELECT E.ID_ENTRENADOR, E.NOMBRE1 'PRIMER NOMBRE', E.NOMBRE2 'SEGUNDO NOMBRE', E.APELLIDO1 'PRIMER APELLIDO', E.APELLIDO2 'SEGUNDO APELLIDO', E.ID_USUARIO_FK 'Usuario Del Empleado', ES.NOMBRE_ESTADO " +
                    "FROM ENTRENADOR AS E, ESTADO_EMPLEADO AS ES"+
                    " WHERE E.ID_ESTADO_ENTRENADOR_FK = ES.ID_ESTADO_EMPLEADO;";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarEntrenadores, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);
                Listado.DataSource = tabla;

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

        public void ListadoEquipos(DataGridView Listado)
        {

            try
            {

                string MostrarEquipos = "SELECT EQ.ID_EQUIPO, EQ.NOMBRE_EQUIPO AS 'NOMBRE DEL EQUIPO', concat(E.NOMBRE1, ' ' , E.NOMBRE2, ' ' , E.APELLIDO1, ' ' , E.APELLIDO2) AS 'NOMBRE DEL ENTRENADOR', T.NOMBRE_DEPORTE 'DEPORTE', ES.NOMBRE_ESTADO " +
                    "FROM EQUIPO AS EQ, ENTRENADOR AS E, TIPO_DEPORTE AS T, ESTADO_EQUIPO AS ES" +
                    " WHERE EQ.ID_ENTRENADOR_FK = E.ID_ENTRENADOR AND EQ.ID_TIPO_DEPORTE__FK = T.ID_TIPO_DEPORTE AND EQ.ID_ESTADO_EQUIPO_FK = ES.ID_ESTADO_EQUIPO;";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarEquipos, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);
                Listado.DataSource = tabla;

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
