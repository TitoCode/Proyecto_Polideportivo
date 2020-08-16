﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsEntrenador
{
    class ClsMantenimientosJugador
    {
        ClsConexion conexion = new ClsConexion();
        ClsJugador Jugador = new ClsJugador();
        public void IngresoJugador(string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNacimiento, byte[] Foto, int Posicion)
        {
            try
            {
                int ID_Jugador;
                string Correlativo = "SELECT IFNULL(MAX(ID_JUGADOR),0) +1 FROM JUGADOR";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                ID_Jugador = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

                
                string InsertarJugador = "INSERT INTO JUGADOR (ID_JUGADOR, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO, ID_EQUIPO_FK, FOTO_JUGADOR, ID_POSICION_FK, ID_ESTADO_JUGADOR_FK) VALUES ('"
                    + ID_Jugador + "','" + Nombre1 + "','" + Nombre2 + "','" + Apellido1 + "','" + Apellido2 + "','" + FechaNacimiento + "','" + ClsDatos.EquipoId + "','" + Foto + "','" + Posicion + "','" + 1 + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarJugador, conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();
                

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public ClsJugador BusquedaIDEntrenador(string ID_Jugador)
        {
            try
            {
                string BuscarJugador = "SELECT J.NOMBRE1, J.NOMBRE2, J.APELLIDO1, J.APELLIDO2, J.FECHA_NACIMIENTO, T.NOMBRE_POSICION" +
                                " FROM JUGADOR AS J, TIPO_JUGADOR AS T" +
                                " WHERE J.ID_POSICION_FK = T.ID_TIPO_JUGADOR AND J.ID_JUGADOR ='" + ID_Jugador + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarJugador, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        Jugador.Nombre1 = Lector.GetString(0);
                        Jugador.Nombre2 = Lector.GetString(1);
                        Jugador.Apellido1 = Lector.GetString(2);
                        Jugador.Apellido2 = Lector.GetString(3);
                        Jugador.FechaNacimiento = Lector.GetString(4);
                        Jugador.Id_Posicion = Lector.GetString(5);
                    }
                }
                return Jugador;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Jugador;
            }

        }

        public void ModificarJugador(string ID_Jugador,string Nombre1, string Nombre2, string Apellido1, string Apellido2)
        {
            try
            {
                string ModificarJugador = "UPDATE JUGADOR SET NOMBRE1='" + Nombre1 + "', NOMBRE2='" + Nombre2 +
                                          "', APELLIDO1='" + Apellido1 + "', APELLIDO2='" + Apellido2 +
                                          "' WHERE ID_JUGADOR='" + ID_Jugador + "'";

                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarJugador, conexion.conexion());

                Query_UPDATE1.ExecuteNonQuery();

                MessageBox.Show("Jugador modificado con éxito.", "FORMULARIO JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void EliminarJugador(string Id_Jugador)
        {
            try
            {

                string EliminarEntrenador = "UPDATE JUGADOR SET ID_ESTADO_JUGADOR_FK = '" + 3 + "' WHERE ID_JUGADOR= '" + Id_Jugador + "'";

                OdbcCommand Query_DELETE1 = new OdbcCommand(EliminarEntrenador, conexion.conexion());

                Query_DELETE1.ExecuteNonQuery();

                MessageBox.Show("Eliminación Exitosa", "FORMULARIO JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
