using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;


namespace PolideportivoAdmin_Proj.Clases.ClsUsuario
{


    class ClsNuevoUsuario
    {



        ClsConexion Conexion = new ClsConexion();

        public int comprobarUsuario(string Usuario)
        {
            
            string SentenciaSql;
            try
            {
                string Consulta = "SELECT * FROM USUARIO WHERE ID_USUARIO = '" + Usuario + ";";
                OdbcCommand Query_Validacion = new OdbcCommand(Consulta, Conexion.conexion());
                OdbcDataReader Lector = Query_Validacion.ExecuteReader();
                SentenciaSql = Consulta;
                if (Lector.HasRows)
                {
                    return 1;
                }
                else {
                    return 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

    }


}