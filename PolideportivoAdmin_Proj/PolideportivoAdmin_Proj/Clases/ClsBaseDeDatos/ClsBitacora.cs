using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases;

namespace PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos
{
    class ClsBitacora
    {
        ClsConexion Conexion = new ClsConexion();
        string Nombre_Proceso;

        public void IngresoBitacora(int Proceso, string Usuario, string Sql)
        {
            
            IPHostEntry host;
            string localIP = "?";

            string UsuarioActivo = ClsDatos.UserId;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();

                }
            }



            switch (Proceso)
            {
                case 1: Nombre_Proceso = "Modificar_Empleado"; break;
                case 2: Nombre_Proceso = "Eliminar_Empleado"; break;
                case 3: Nombre_Proceso = "Insertar_Empleado"; break;
                case 4: Nombre_Proceso = "Modificar_Entrenador"; break;
                case 5: Nombre_Proceso = "Eliminar_Entrenador"; break;
                case 6: Nombre_Proceso = "Insertar_Entrenador"; break;
                case 7: Nombre_Proceso = "Modificar_Partido"; break;
                case 8: Nombre_Proceso = "Eliminar_Partido"; break;
                case 9: Nombre_Proceso = "Insertar_Partido"; break;
                case 10: Nombre_Proceso = "Insertar_Jugador"; break;
                case 11: Nombre_Proceso = "Modificar_Jugador"; break;
                case 12: Nombre_Proceso = "Borrar_Jugador"; break;
                case 13: Nombre_Proceso = "Ingreso_Login"; break;
                case 14: Nombre_Proceso = "Intento_de_Ingreso"; break;
                case 15: Nombre_Proceso = "Creacion_Reporte"; break;
            }


            try
            {

                int ID_Bitacora;

                string Correlativo = "SELECT IFNULL(MAX(ID_BITACORA),0) +1 FROM BITACORA";

                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, Conexion.conexion());
                ID_Bitacora = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

                string InsertarBitacora = "INSERT INTO BITACORA (ID_BITACORA, HOSTNAME, FECHA, ID_USUARIO_FK, IP_ADDRESS, CONSULTA, ID_PROCESO_FK) VALUES ('" + ID_Bitacora + "','" + Convert.ToString(host.HostName) + "','" + Convert.ToString(DateTime.Now) + "','" + UsuarioActivo + "','" + localIP + "','" + Sql + "','" + Proceso + "')";


                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarBitacora, Conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();

                StreamWriter fichero = File.AppendText("Bitacora.txt");
                //El archivo se guarda en la carpeta bin/debug del proyecto

                fichero.WriteLine("LOG IP: " + localIP + " Usuario: " + UsuarioActivo + " Sentencia Sql: " + Sql + " Proceso: " + Nombre_Proceso + " PC: " + Convert.ToString(host.HostName) +
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
