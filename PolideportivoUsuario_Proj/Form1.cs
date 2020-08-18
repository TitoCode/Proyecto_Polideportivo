using MaterialSkin.Controls;
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
using System.Data.Odbc;
using System.Data.SqlClient;
using Polideportivo_Proj;
using System.Collections;

namespace PolideportivoUsuario_Proj
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        ClsConexion conexion = new ClsConexion();
        public FrmMain()
        {
            
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue700, Primary.Cyan100, Accent.Cyan100, TextShade.WHITE);
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
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

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
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
    }
}
