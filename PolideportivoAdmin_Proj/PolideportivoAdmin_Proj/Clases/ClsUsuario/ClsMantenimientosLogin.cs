using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsUsuario
{
    class ClsMantenimientosLogin
    {
        ClsConexion Conexion = new ClsConexion();
        
        public int IngresoLogin(string Usuario, string Password)
        {
            int ID_TIPO_USUARIO;
            try
            {               
                string Consulta = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO = '" + Usuario + "' AND PASSWORD = '" + Password + "' ;";
                OdbcCommand Query_Validacion = new OdbcCommand(Consulta, Conexion.conexion());
                OdbcDataReader Lector = Query_Validacion.ExecuteReader();

                if (Lector.HasRows == true)
                {
                    OdbcCommand Login = new OdbcCommand(Consulta, Conexion.conexion());
                    ID_TIPO_USUARIO = Convert.ToInt32(Login.ExecuteScalar());

                    if (ID_TIPO_USUARIO == 1){
                        return 1;
                    }else if (ID_TIPO_USUARIO == 2){
                        return 2;
                    }else if (ID_TIPO_USUARIO == 3){
                        return 3;
                    }else{
                        return 4;
                    }

                }else{
                    return 5;
                }
            }catch (Exception ex){
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
