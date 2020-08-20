using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        ClsMantenimientoEstadisticas Estadisticas = new ClsMantenimientoEstadisticas();
        ClsConexion conexion = new ClsConexion();

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            GraficoBitacora();
            ConteoSistema();
        }

        public void GraficoBitacora()
        {
            ArrayList Usuarios = new ArrayList();
            ArrayList Logs = new ArrayList();
            try
            {
                string BuscarDatoEmpleado = "SELECT ID_USUARIO_FK, COUNT(ID_USUARIO_FK) AS LOGS FROM BITACORA GROUP BY ID_USUARIO_FK ORDER BY LOGS ASC;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();
                while (Lector.Read())
                {
                    Usuarios.Add(Lector.GetString(0));
                    Logs.Add(Lector.GetString(1));
                }
                Graf_Bitacora.Series[0].Points.DataBindXY(Usuarios, Logs);
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

        public void ConteoSistema()
        {
            int Empleados, Entrenadores, Usuarios;
            try
            {
                string BuscarDatoEmpleado = "SELECT COUNT(ID_EMPLEADO) FROM EMPLEADO;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());
                Empleados = Convert.ToInt32(Query_Busqueda1.ExecuteScalar());

                string BuscarDatoEntrenadores = "SELECT COUNT(ID_ENTRENADOR) FROM ENTRENADOR";
                OdbcCommand Query_Busqueda2 = new OdbcCommand(BuscarDatoEntrenadores, conexion.conexion());
                Entrenadores = Convert.ToInt32(Query_Busqueda2.ExecuteScalar());

                string BuscarDatoUsuario = "SELECT COUNT(ID_USUARIO) FROM USUARIO;";
                OdbcCommand Query_Busqueda3 = new OdbcCommand(BuscarDatoUsuario, conexion.conexion());
                Usuarios = Convert.ToInt32(Query_Busqueda3.ExecuteScalar());

                Lbl_EstadisticasUsuarios.Text = Convert.ToString(Usuarios);
                Lbl_EstadisticasEmpleados.Text = Convert.ToString(Empleados);
                Lbl_EstadisticaEntrenadores.Text = Convert.ToString(Entrenadores);

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

        public void ConteoFutbol()
        {
            int Equipos, Campeonatos;
            try
            {
                string BuscarDatoEquipos = "SELECT COUNT(ID_EQUIPO) AS 'ToEquipos' FROM EQUIPO WHERE ID_TIPO_DEPORTE__FK = 1;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEquipos, conexion.conexion());
                Equipos = Convert.ToInt32(Query_Busqueda1.ExecuteScalar());

                string BuscarDatoCampeonatos = "SELECT COUNT(ID_CAMPEONATO) AS 'ToCampeonatos' FROM CAMPEONATO WHERE ID_TIPO_DEPORTE_FK = 1";
                OdbcCommand Query_Busqueda2 = new OdbcCommand(BuscarDatoCampeonatos, conexion.conexion());
                Campeonatos = Convert.ToInt32(Query_Busqueda2.ExecuteScalar());

                Lbl_EstadisticasUsuarios.Text = Convert.ToString(Usuarios);
                Lbl_EstadisticasEmpleados.Text = Convert.ToString(Empleados);
                Lbl_EstadisticaEntrenadores.Text = Convert.ToString(Entrenadores);

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
