using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PolideportivoAdmin_Proj.Clases.ClsGerencia
{
    class ClsMantenimientoEstadisticas
    {
        ClsConexion conexion = new ClsConexion();
        public (ArrayList Usuarios, ArrayList logs) GraficoBitacora()
        {
            ArrayList Usuarios = new ArrayList();
            ArrayList Logs = new ArrayList();
            try
            {
                string BuscarDatoEmpleado = "SELECT ID_USUARIO_FK, COUNT(ID_USUARIO_FK) FROM BITACORA GROUP BY ID_USUARIO_FK;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();
                while (Lector.Read())
                {
                    Usuarios.Add(Lector.GetString(0));
                    Logs.Add(Lector.GetString(1));
                }
                return (Usuarios, Logs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (Usuarios, Logs);
            }
        }
    }
}
