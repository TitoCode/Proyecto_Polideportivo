using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
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
    class ClsReportes
    {

        ClsConexion conexion = new ClsConexion();
        ClsGerencia Empleado = new ClsGerencia();

        


        public void Reporte_Jugador(DataGridView Jugadores)
        {
            try
            {
                string Jugador = "SELECT J.NOMBRE1, J.NOMBRE2, J.APELLIDO1, J.APELLIDO2, J.FECHA_NACIMIENTO, E.NOMBRE_EQUIPO ,TP.NOMBRE_POSICION, EJ.NOMBRE_ESTADO FROM JUGADOR AS J, EQUIPO AS E, TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(Jugador, conexion.conexion());
                OdbcDataAdapter MostrarJugador = new OdbcDataAdapter();

                MostrarJugador.SelectCommand = Query_Busqueda1;
                DataTable tabla = new DataTable();
                MostrarJugador.Fill(tabla);
                Jugadores.DataSource = tabla;


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

        public void Reporte_Suspendidos(DataGridView Jugador_Suspendido)
        {

            try
            {
                string Suspendidos = "SELECT J.NOMBRE1, J.APELLIDO1, E.NOMBRE_EQUIPO ,TP.NOMBRE_POSICION FROM JUGADOR AS J, EQUIPO AS E, TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO AND EJ.ID_ESTADO_JUGADOR ='" + 2 + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(Suspendidos, conexion.conexion());
                OdbcDataAdapter MostrarSuspendidos = new OdbcDataAdapter();

                MostrarSuspendidos.SelectCommand = Query_Busqueda1;
                DataTable tabla = new DataTable();
                MostrarSuspendidos.Fill(tabla);
                Jugador_Suspendido.DataSource = tabla;
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

        public void Partidos_Campeonato(DataGridView Partidos)
        {

            try
            {
                string Resultados_Partidos = "SELECT P.ID_PARTIDO, C.NOMBRE_CAMPEONATO, concat(P.MARCADOR_LOCAL, '-', P.MARCADOR_VISITANTE) AS MARCADOR FROM PARTIDO AS P, CAMPEONATO AS C WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(Resultados_Partidos, conexion.conexion());
                OdbcDataAdapter MostrarPartidos = new OdbcDataAdapter();

                MostrarPartidos.SelectCommand = Query_Busqueda1;
                DataTable tabla = new DataTable();
                MostrarPartidos.Fill(tabla);
                Partidos.DataSource = tabla;
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

        public void Posiciones_Campeonato(DataGridView Posiciones, string Campeonato)
        {

            try
            {
                string Posiciones_Camp = "SELECT C.NOMBRE_CAMPEONATO, E.NOMBRE_EQUIPO, EC.PUNTOS_TORNEO FROM EQUIPO AS E, EQUIPO_CAMPEONATO AS EC, CAMPEONATO AS C WHERE EC.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND EC.ID_EQUIPO_FK = E.ID_EQUIPO AND C.ID_CAMPEONATO ='" + Campeonato + "' ORDER BY PUNTOS_TORNEO desc";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(Posiciones_Camp, conexion.conexion());
                OdbcDataAdapter PosicionesCampeonatos = new OdbcDataAdapter();

                PosicionesCampeonatos.SelectCommand = Query_Busqueda1;
                DataTable tabla = new DataTable();
                PosicionesCampeonatos.Fill(tabla);
                Posiciones.DataSource = tabla;

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

        public void Equipos_Campeonato(DataGridView Campeonatos, string Id_Campeonato)
        {

            try
            {
                string EquiposCampeonato = "SELECT EC.ID_DETALLE_CAMPEONATO, C.NOMBRE_CAMPEONATO, E.NOMBRE_EQUIPO FROM EQUIPO AS E, EQUIPO_CAMPEONATO AS EC, CAMPEONATO AS C WHERE EC.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND EC.ID_EQUIPO_FK = E.ID_EQUIPO AND C.ID_CAMPEONATO ='" + Id_Campeonato + "' ORDER BY ID_DETALLE_CAMPEONATO ASC ";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataAdapter EquiposCampeonatos = new OdbcDataAdapter();

                EquiposCampeonatos.SelectCommand = Query_Busqueda1;
                DataTable tabla = new DataTable();
                EquiposCampeonatos.Fill(tabla);
                Campeonatos.DataSource = tabla;

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

        public void Jugador_Equipo(DataGridView J_Equipos, string Id_Equipo)
        {

            try
            {
                string Jugadores_Equipo = "SELECT J.ID_JUGADOR, J.NOMBRE1, J.APELLIDO1,TP.NOMBRE_POSICION ,EJ.NOMBRE_ESTADO FROM TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ, JUGADOR AS J, EQUIPO AS E WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO AND E.ID_EQUIPO ='" + Id_Equipo + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(Jugadores_Equipo, conexion.conexion());
                OdbcDataAdapter JugadoresEquipos = new OdbcDataAdapter();

                JugadoresEquipos.SelectCommand = Query_Busqueda1;
                DataTable tabla = new DataTable();
                JugadoresEquipos.Fill(tabla);
                J_Equipos.DataSource = tabla;


           


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
