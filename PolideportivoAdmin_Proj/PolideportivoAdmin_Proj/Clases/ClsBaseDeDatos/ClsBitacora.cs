using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos
{
    class ClsBitacora
    {
        ClsConexion Conexion = new ClsConexion();
        public void IngresoBitacora(int Proceso, string Usuario, string Sql)
        {

            IPHostEntry host;
            string localIP = "?";
            string strHostName = Dns.GetHostName();
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();

                }
            }

            try
            {

                int ID_Bitacora;
<<<<<<< HEAD
                string Correlativo = "SELECT IFNULL(MAX(ID_EMPLEADO),0) +1 FROM EMPLEADO";
=======
                string Correlativo = "SELECT IFNULL(MAX(ID_BITACORA),0) +1 FROM BITACORA";
>>>>>>> 40c72b332eb58c736b501476b87b7d30d725482b
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, Conexion.conexion());
                ID_Bitacora = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();



<<<<<<< HEAD
                string InsertarBitacora = "INSERT INTO BITACORA (ID_BITACORA, HOSTNAME, FECHA, ID_USUARIO_FK, IP_ADDRESS, CONSULTA, ID_PROCESO_FK) VALUES ('" + ID_Bitacora + "','" + strHostName + "'," + DateTime.Now + ",'" + Usuario + "','" + localIP + "','" + Sql + "','" + Proceso + "')";
=======
                string InsertarBitacora = "INSERT INTO BITACORA (ID_BITACORA, HOSTNAME, FECHA, ID_USUARIO_FK, IP_ADDRESS, CONSULTA, ID_PROCESO_FK) VALUES ('" + ID_Bitacora + "','" + strHostName + "','" + DateTime.Now + "','" + Usuario + "','" + localIP + "','" + Sql + "','" + Proceso + "')";
>>>>>>> 40c72b332eb58c736b501476b87b7d30d725482b
                
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarBitacora, Conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();

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
