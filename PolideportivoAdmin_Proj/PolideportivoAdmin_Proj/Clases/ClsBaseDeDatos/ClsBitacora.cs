using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.IO;
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
                string strHostName = Convert.ToString(host.HostName);
                string Correlativo = "SELECT IFNULL(MAX(ID_EMPLEADO),0) +1 FROM EMPLEADO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, Conexion.conexion());
                ID_Bitacora = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();



                string InsertarBitacora = "INSERT INTO BITACORA (ID_BITACORA, HOSTNAME, FECHA, ID_USUARIO_FK, IP_ADDRESS, CONSULTA, ID_PROCESO_FK) VALUES ('" + ID_Bitacora + "','" + Convert.ToString(host.HostName) + "','" + Convert.ToString(DateTime.Now) + "','" + Usuario + "','" + localIP + "','" + Sql + "','" + Proceso + "')";
                
                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarBitacora, Conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();

                StreamWriter fichero = File.AppendText("Bitacora.txt");
                //El archivo se guarda en la carpeta bin/debug del proyecto

                fichero.WriteLine("LOG IP: " + localIP + " Usuario: " + Usuario + " Sentencia Sql: " + Sql + " ID Proceso: " + Proceso + " PC: " + Convert.ToString(host.HostName) +
                " Fecha: " + DateTime.Now + " - " + Environment.NewLine);
                fichero.Close(); // Al cerrar el fichero nos aseguramos que no queda ningún dato por guardar




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
