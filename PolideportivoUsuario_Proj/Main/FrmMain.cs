using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.Odbc;
using Polideportivo_Proj;

namespace PolideportivoUsuario_Proj
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager msManager;
        ClsConexion conexion = new ClsConexion();
        public FrmMain()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            msManager = MaterialSkinManager.Instance;
            msManager.AddFormToManage(this);
            msManager.Theme = MaterialSkinManager.Themes.DARK;
            msManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue700, Primary.Cyan100, Accent.Cyan100, TextShade.WHITE);
            
            LblLocal.Visible=false;
            LblVisitante.Visible = false;
            LsvLocal.Visible = false;
            LsvVisitante.Visible = false;
            LblMejorJugador.Visible = false;
            LsvMejorJugador.Visible = false;
            LblJugadoresSancionados.Visible = false;
            LsvSanciones.Visible = false;
            LblEncabezadoEstado.Visible = false;
            LblEstadoP.Visible = false;
            LblResultadoP.Visible = false;
            LblEncabezadoRP.Visible = false;

        }
        private void TmrInicio_Tick(object sender, EventArgs e)
        {

            Lbl_Hora.Text = DateTime.Now.ToString("hh:mm");
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();

        }

        

        private void BtnConsultaEquipo_Click(object sender, EventArgs e)
        {
            LsvEquipos.Items.Clear();
            OdbcCommand CmdEquipo = new OdbcCommand("Select eq.NOMBRE_EQUIPO as 'Nombre del Equipo' , CONCAT(NOMBRE1, ' ',APELLIDO1) as 'Entrenador' , dep.NOMBRE_DEPORTE as 'Deporte', est.NOMBRE_ESTADO from equipo as eq, entrenador as ent, tipo_deporte as dep, estado_equipo as est where eq.ID_ENTRENADOR_FK = ent.ID_ENTRENADOR and eq.ID_TIPO_DEPORTE__FK = dep.ID_TIPO_DEPORTE and eq.ID_ESTADO_EQUIPO_FK = est.ID_ESTADO_EQUIPO", conexion.conexion());
            OdbcDataAdapter Adaptador = new OdbcDataAdapter();
            Adaptador.SelectCommand = CmdEquipo;
            DataTable tablaEquipo = new DataTable();
            Adaptador.Fill(tablaEquipo);

            foreach (DataRow row in tablaEquipo.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < tablaEquipo.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                LsvEquipos.Items.Add(item);
            }
        }

        public void ListadoJugadoresPartidoLocales(string ID_Partido)
        {
            try
            {
                string MostrarJugadores = "SELECT J.ID_JUGADOR, concat(J.NOMBRE1, ' ' , J.NOMBRE2, ' ' , J.APELLIDO1, ' ' , J.APELLIDO2) " +
                       "AS 'Nombre Completo Del Jugador',e.NOMBRE_EQUIPO as 'Equipo', tj.NOMBRE_POSICION " +
                       "FROM JUGADOR AS J, EQUIPO AS E, PARTIDO AS P, tipo_jugador AS TJ " +
                       "WHERE P.ID_LOCAL = E.ID_EQUIPO AND P.ID_PARTIDO ='"+ ID_Partido + "' and j.ID_POSICION_FK = tj.ID_TIPO_JUGADOR";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarJugadores, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < tabla.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    LsvLocal.Items.Add(item);
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
        public void ListadoJugadoresPartidoVisitante(string ID_Partido)
        {
            try
            {
                string MostrarJugadores = "SELECT J.ID_JUGADOR, concat(J.NOMBRE1, ' ' , J.NOMBRE2, ' ' , J.APELLIDO1, ' ' , J.APELLIDO2) " +
                       "AS 'Nombre Completo Del Jugador',e.NOMBRE_EQUIPO as 'Equipo', tj.NOMBRE_POSICION " +
                       "FROM JUGADOR AS J, EQUIPO AS E, PARTIDO AS P, tipo_jugador AS TJ " +
                       "WHERE P.ID_VISITANTE = E.ID_EQUIPO AND P.ID_PARTIDO ='" + ID_Partido + "' and j.ID_POSICION_FK = tj.ID_TIPO_JUGADOR";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarJugadores, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < tabla.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    LsvVisitante.Items.Add(item);
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
        
        private void BtnConsultaJu_Click(object sender, EventArgs e)
        {
            LsvJugadores.Items.Clear();
            OdbcCommand CmdJugadores = new OdbcCommand("Select CONCAT(ju.NOMBRE1, ' ', ju.NOMBRE2, ' ', ju.APELLIDO1, ' ' , ju.APELLIDO2)as 'Jugador' , eq.NOMBRE_EQUIPO as 'Equipo', tipo.NOMBRE_POSICION as 'Posicion' , est.NOMBRE_ESTADO as 'Estado de jugador' from jugador as ju, equipo as eq, tipo_jugador as tipo, estado_jugador as est WHERE ju.ID_EQUIPO_FK = eq.ID_EQUIPO AND ju.ID_POSICION_FK = tipo.ID_TIPO_JUGADOR AND ju.ID_ESTADO_JUGADOR_FK = est.ID_ESTADO_JUGADOR ", conexion.conexion());
            OdbcDataAdapter Adaptador = new OdbcDataAdapter();
            Adaptador.SelectCommand = CmdJugadores;
            DataTable tablaJugador = new DataTable();
            Adaptador.Fill(tablaJugador);

            foreach (DataRow row in tablaJugador.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < tablaJugador.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                LsvJugadores.Items.Add(item);
            }
        }
        public void mejorJugador(string ID_Partido)
        {
            try
            {
                string MostrarJugadores = "SELECT concat(ju.NOMBRE1, ' ', ju.NOMBRE2, ' ', ju.APELLIDO1, ' ', ju.APELLIDO2)as 'jugador', SUM(ANOTACION) " +
                    "FROM jugador as ju, DETALLE_JUGADOR as det WHERE det.ID_PARTIDO_FK='"+ ID_Partido + 
                    "'  GROUP BY ID_JUGADOR_PARTIDO_FK  LIMIT 1";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarJugadores, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < tabla.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    LsvMejorJugador.Items.Add(item);
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
        public void estadoPartido(string ID_Partido)
        {
            try
            {
                string PARTIDO = "SELECT estp.NOMBRE_ESTADO FROM partido as p, estado_partido as estp " +
                    "WHERE p.ID_PARTIDO = '"+ ID_Partido + "' and p.ID_ESTADO_PARTIDO_FK = estp.ID_ESTADO";
                
                OdbcCommand Query_SELECT = new OdbcCommand(PARTIDO, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                OdbcDataReader estado = Query_SELECT.ExecuteReader();
                if (estado.Read()) {

                    LblEstadoP.Text = estado["NOMBRE_ESTADO"].ToString();
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
        public void jugadoresSancionados(string ID_Partido)
        {
            try
            {
                string MostrarJugadores = "SELECT CONCAT(J.NOMBRE1, ' ', J.NOMBRE2, ' ', J.APELLIDO1, ' ', J.APELLIDO2) " +
                    "AS 'Nombre Del Jugador', F.NOMBRE 'Falta Realizada' " +
                    "FROM DETALLE_FALTA AS DF, FALTA AS F, JUGADOR AS J, PARTIDO AS P " +
                    "WHERE DF.ID_FALTA_FK = F.ID_FALTA AND DF.ID_PARTIDO_FK = P.ID_PARTIDO " +
                    "AND DF.ID_JUGADOR_FK = J.ID_JUGADOR AND DF.ID_PARTIDO_FK = '"+ID_Partido+"'";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarJugadores, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < tabla.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    LsvSanciones.Items.Add(item);
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

        public void marcadorPartido(string ID_Partido)
        {
            try
            {
                string PARTIDO = "SELECT CONCAT('L: ', p.MARCADOR_LOCAL, '  V: ', p.MARCADOR_VISITANTE) as 'Marcador' " +
                    "FROM partido as p where p.ID_PARTIDO ='"+ ID_Partido + "'";

                OdbcCommand Query_SELECT = new OdbcCommand(PARTIDO, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                OdbcDataReader estado = Query_SELECT.ExecuteReader();
                if (estado.Read())
                {

                    LblResultadoP.Text = estado["Marcador"].ToString();
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


        private int validarTorneo(string id_torneo) {
            string validarTorneo = "SELECT * FROM partido as p WHERE p.ID_PARTIDO ='"+id_torneo+"' ";
            OdbcCommand Query_Busqueda1 = new OdbcCommand(validarTorneo, conexion.conexion());
            OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

            if (Lector1.HasRows == true)
            {
                LblBienvenida.Visible = false;
                LblLocal.Visible = true;
                LblVisitante.Visible = true;
                LsvLocal.Visible = true;
                LsvVisitante.Visible = true;
                LblMejorJugador.Visible = true;
                LsvMejorJugador.Visible = true;
                LblJugadoresSancionados.Visible = true;
                LsvSanciones.Visible = true;
                LblEncabezadoEstado.Visible = true;
                LblEstadoP.Visible = true;
                LblResultadoP.Visible = true;
                LblEncabezadoRP.Visible = true;
                return 1;
            }
            else
            {
                LblBienvenida.Visible = true;
                LblLocal.Visible = false;
                LblVisitante.Visible = false;
                LsvLocal.Visible = false;
                LsvVisitante.Visible = false;
                LblMejorJugador.Visible = false;
                LsvMejorJugador.Visible = false;
                LblJugadoresSancionados.Visible = false;
                LsvSanciones.Visible = false;
                LblEncabezadoEstado.Visible = false;
                LblEstadoP.Visible = false;
                LblResultadoP.Visible = false;
                LblEncabezadoRP.Visible = false;
                TxtBusquedaTorneo.Text = "";
                MessageBox.Show("ERROR: El codigo del empleado no es valido o no existe el partido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void BtnBusquedaTorneo_Click(object sender, EventArgs e)
        {
            
            LsvLocal.Items.Clear();
            LsvVisitante.Items.Clear();
            LsvMejorJugador.Items.Clear();
            LsvSanciones.Items.Clear();
            LblEstadoP.Text = "";
            LblResultadoP.Text = "";
            if (TxtBusquedaTorneo.Text=="") { 
                
                LblBienvenida.Visible = true;
                LblLocal.Visible = false;
                LblVisitante.Visible = false;
                LsvLocal.Visible = false;
                LsvVisitante.Visible = false;
                LblMejorJugador.Visible = false;
                LsvMejorJugador.Visible = false;
                LblJugadoresSancionados.Visible = false;
                LsvSanciones.Visible = false;
                LblEncabezadoEstado.Visible = false;
                LblEstadoP.Visible = false;
                LblResultadoP.Visible = false;
                LblEncabezadoRP.Visible = false;
                MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                int validar = validarTorneo(TxtBusquedaTorneo.Text.ToString());
                if (validar==1) {
                    ListadoJugadoresPartidoLocales(TxtBusquedaTorneo.Text.ToString());
                    ListadoJugadoresPartidoVisitante(TxtBusquedaTorneo.Text.ToString());
                    mejorJugador(TxtBusquedaTorneo.Text.ToString());
                    estadoPartido(TxtBusquedaTorneo.Text.ToString());
                    marcadorPartido(TxtBusquedaTorneo.Text.ToString());
                    jugadoresSancionados(TxtBusquedaTorneo.Text.ToString());
                    TxtBusquedaTorneo.Text = "";
                }
            }
        }
        public void ListadoPartidos()
        {

            try
            {

                string MostrarPartidos = "SELECT P.ID_PARTIDO AS 'No. Partido', C.NOMBRE_CAMPEONATO AS 'Nombre Del Campeonato', P.FECHA_PARTIDO AS 'Fecha Del Partido', E1.NOMBRE_EQUIPO AS 'Equipo Local', E2.NOMBRE_EQUIPO AS 'Equipo Visitante', concat(P.MARCADOR_LOCAL, '-' ,P.MARCADOR_VISITANTE) AS 'MARCADOR', EP.NOMBRE_ESTADO 'Estado Del Partido'" +
                    " FROM CAMPEONATO AS C, EQUIPO AS E, ESTADO_PARTIDO AS EP, PARTIDO AS P" +
                    " INNER JOIN EQUIPO E1 ON P.ID_LOCAL = E1.ID_EQUIPO" +
                    " INNER JOIN EQUIPO E2 ON P.ID_VISITANTE = E2.ID_EQUIPO" +
                    " WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND P.ID_ESTADO_PARTIDO_FK = EP.ID_ESTADO AND P.ID_LOCAL = E.ID_EQUIPO;";
                OdbcCommand Query_SELECT = new OdbcCommand(MostrarPartidos, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < tabla.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    LsvCalendario.Items.Add(item);
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

        private void TmrCalendario_Tick(object sender, EventArgs e)
        {
            LsvCalendario.Items.Clear();
            ListadoPartidos();
        }
    }
}
