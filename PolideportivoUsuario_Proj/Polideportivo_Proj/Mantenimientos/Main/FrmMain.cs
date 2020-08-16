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
using System.Data.SqlClient;

namespace Polideportivo_Proj
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        ClsConexion conexion = new ClsConexion();

        private void BtnListadoJ_Click(object sender, EventArgs e)
        {
            DgvUsuario.Columns.Clear();
            OdbcCommand CmdJugadores = new OdbcCommand("Select CONCAT(ju.NOMBRE1, ' ', ju.NOMBRE2, ' ', ju.APELLIDO1, ' ' , ju.APELLIDO2)as 'Jugador' , eq.NOMBRE_EQUIPO as 'Equipo', tipo.NOMBRE_POSICION as 'Posicion' , est.NOMBRE_ESTADO as 'Estado de jugador' from jugador as ju, equipo as eq, tipo_jugador as tipo, estado_jugador as est WHERE ju.ID_EQUIPO_FK = eq.ID_EQUIPO AND ju.ID_POSICION_FK = tipo.ID_TIPO_JUGADOR AND ju.ID_ESTADO_JUGADOR_FK = est.ID_ESTADO_JUGADOR ", conexion.conexion());
            OdbcDataAdapter Adaptador = new OdbcDataAdapter();
            Adaptador.SelectCommand = CmdJugadores;
            DataTable tablaJugador = new DataTable();
            Adaptador.Fill(tablaJugador);
            DgvUsuario.DataSource = tablaJugador;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {

        }

        private void BtnListadoE_Click(object sender, EventArgs e)
        {
            DgvUsuario.Columns.Clear();
            OdbcCommand CmdEquipo = new OdbcCommand("Select eq.NOMBRE_EQUIPO as 'Nombre del Equipo' , CONCAT(NOMBRE1, ' ',APELLIDO1) as 'Entrenador' , dep.NOMBRE_DEPORTE as 'Deporte' from equipo as eq, entrenador as ent, tipo_deporte as dep where eq.ID_ENTRENADOR_FK = ent.ID_ENTRENADOR and eq.ID_TIPO_DEPORTE__FK = dep.ID_TIPO_DEPORTE ", conexion.conexion());
            OdbcDataAdapter Adaptador = new OdbcDataAdapter();
            Adaptador.SelectCommand = CmdEquipo;
            DataTable tablaEquipo = new DataTable();
            Adaptador.Fill(tablaEquipo);
            DgvUsuario.DataSource = tablaEquipo;
        }
    }
}
