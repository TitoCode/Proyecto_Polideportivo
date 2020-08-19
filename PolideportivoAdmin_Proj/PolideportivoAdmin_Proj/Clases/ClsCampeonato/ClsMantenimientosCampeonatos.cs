using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsCampeonato
{
    class ClsMantenimientosCampeonatos
    {
        ClsConexion conexion = new ClsConexion();

        public void ListadoCampeonatos(DataGridView Listado)
        {

            try
            {

                string MostrarEquipos = "SELECT C.ID_CAMPEONATO, C.NOMBRE_CAMPEONATO AS 'NOMBRE DEL CAMPEONATO', T.NOMBRE_DEPORTE 'DEPORTE', S.NOMBRE_SEDE " +
                    "FROM CAMPEONATO AS C, SEDE_POLIDEPORTIVO AS S, TIPO_DEPORTE AS T" +
                    " WHERE C.ID_SEDE_POLI_FK = S.ID_SEDE AND C.ID_TIPO_DEPORTE_FK = T.ID_TIPO_DEPORTE;";

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
