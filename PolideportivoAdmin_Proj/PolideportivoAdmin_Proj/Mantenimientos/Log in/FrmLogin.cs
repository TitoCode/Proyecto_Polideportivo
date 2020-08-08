using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Mantenimientos.Administración;
using PolideportivoAdmin_Proj.Mantenimientos.Entrenador;
using PolideportivoAdmin_Proj.Mantenimientos.Gerencia;

namespace PolideportivoAdmin_Proj
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        ClsConexion x = new ClsConexion();
        int ID_TIPO_USUARIO;

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("No se han completado los campos", "PRECAUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO = '" + TxtUsuario.Text + "' AND PASSWORD = '" + TxtPassword.Text + "' ;";
                    OdbcCommand Query_Validacion = new OdbcCommand(Consulta, x.conexion());
                    OdbcDataReader Lector = Query_Validacion.ExecuteReader();

                    
                    
                    if (Lector.HasRows == true)
                    {
                        OdbcCommand Login = new OdbcCommand(Consulta, x.conexion());
                        ID_TIPO_USUARIO = Convert.ToInt32(Login.ExecuteScalar());

                        if (ID_TIPO_USUARIO == 1)
                        {
                            TxtUsuario.Clear();
                            TxtPassword.Clear();
                            BtnIngreso.Focus();
                            Form Formulario = new FrmGerencia(); 
                            this.Hide();
                            Formulario.ShowDialog();
                            this.Show();

                        }
                        else if (ID_TIPO_USUARIO == 2)
                        {
                            TxtUsuario.Clear();
                            TxtPassword.Clear();
                            BtnIngreso.Focus();
                            Form Formulario = new FrmAdmin();
                            this.Hide();
                            Formulario.ShowDialog();
                            this.Show();

                        }
                        else if (ID_TIPO_USUARIO == 3)
                        {
                            TxtUsuario.Clear();
                            TxtPassword.Clear();
                            BtnIngreso.Focus();
                            Form Formulario = new FrmEntrenador(); 
                            this.Hide();
                            Formulario.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtPassword.Clear();
                            TxtUsuario.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtPassword.Clear();
                        TxtUsuario.Focus();
                    }
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
}
