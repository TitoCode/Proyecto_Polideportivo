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
using PolideportivoAdmin_Proj.Clases;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using PolideportivoAdmin_Proj.Clases.ClsUsuario;
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

        ClsMantenimientosLogin Logeo = new ClsMantenimientosLogin();
        ClsBitacora Bitacora = new ClsBitacora();


        string UsuarioActivo;
        int TipoProceso = 1;
        string SenSql1 = null;
        
        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            int TipoUsuario;
            if (TxtUsuario.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TipoUsuario = Logeo.IngresoLogin(TxtUsuario.Text, TxtPassword.Text);

                if (TipoUsuario == 1)
                {

                    ClsDatos.UserId = TxtUsuario.Text;
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 13;
                    SenSql1 = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO =  + Usuario +  AND PASSWORD =  + Password +  ;";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                    FrmGerencia Formulario = new FrmGerencia();
                    Formulario.Lbl_Usuario.Text = TxtUsuario.Text;
                    Formulario.Lbl_Puesto.Text = "Gerente Administrativo";
                    Formulario.Lbl_Password.Text = TxtPassword.Text;
                    TxtUsuario.Clear();
                    TxtPassword.Clear();
                    BtnIngreso.Focus();
                    this.Hide();
                    Formulario.ShowDialog();
                    this.Show();
                }

                if (TipoUsuario == 2)
                {

                    ClsDatos.UserId = TxtUsuario.Text;
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 13;
                    SenSql1 = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO =  + Usuario +  AND PASSWORD =  + Password +  ;";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                    FrmAdmin Formulario = new FrmAdmin();
                    //Formulario.Lbl_Usuario.Text = TxtUsuario.Text;
                    //Formulario.Lbl_Puesto.Text = "Gerente Administrativo";
                    
                    TxtUsuario.Clear();
                    TxtPassword.Clear();
                    BtnIngreso.Focus();
                    this.Hide();
                    Formulario.ShowDialog();
                    this.Show();
                }

                if (TipoUsuario == 3)
                {

                    ClsDatos.UserId = TxtUsuario.Text;
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 13;
                    SenSql1 = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO =  + Usuario +  AND PASSWORD =  + Password +  ;";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                    Logeo.IDEquipoEntrenador(TxtUsuario.Text);
                    FrmEntrenador Formulario = new FrmEntrenador();
                    //Formulario.Lbl_Usuario.Text = TxtUsuario.Text;
                    //Formulario.Lbl_Puesto.Text = "Gerente Administrativo";
                    TxtUsuario.Clear();
                    TxtPassword.Clear();
                    BtnIngreso.Focus();
                    this.Hide();
                    Formulario.ShowDialog();
                    this.Show();
                }

                if (TipoUsuario == 4)
                {


                    ClsDatos.UserId = TxtUsuario.Text;
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 13;
                    SenSql1 = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO =  + Usuario +  AND PASSWORD =  + Password +  ;";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                    MessageBox.Show("ERROR: Usuario Inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Clear();
                    TxtUsuario.Focus();
                }

                if (TipoUsuario == 5)
                {


                    ClsDatos.UserId = TxtUsuario.Text;
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 14;
                    SenSql1 = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO =  + Usuario +  AND PASSWORD =  + Password +  ;";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

                    MessageBox.Show("ADVERTENCIA: Usuario o contraseña incorrectos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtPassword.Clear();
                    TxtPassword.Focus();
                }

                if (TipoUsuario == 0)
                {

                    ClsDatos.UserId = TxtUsuario.Text;
                    UsuarioActivo = ClsDatos.UserId;
                    TipoProceso = 14;
                    SenSql1 = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO =  + Usuario +  AND PASSWORD =  + Password +  ;";
                    Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                    MessageBox.Show("Intentelo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Clear();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                }

            }                            
        }
    }   
}
