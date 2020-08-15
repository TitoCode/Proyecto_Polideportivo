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

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            int TipoUsuario;
            if (TxtUsuario.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("No se han completado los campos", "PRECAUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TipoUsuario = Logeo.IngresoLogin(TxtUsuario.Text, TxtPassword.Text);

                if (TipoUsuario == 1)
                {
                    //Bitacora.IngresoBitacora(int Proceso, string Usuario, string Sql);
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

                    FrmAdmin Formulario = new FrmAdmin();
                    //Formulario.Lbl_Usuario.Text = TxtUsuario.Text;
                    //Formulario.Lbl_Puesto.Text = "Gerente Administrativo";
                    //ClsLog.UserID = TxtUsuario.Text;
                    TxtUsuario.Clear();
                    TxtPassword.Clear();
                    BtnIngreso.Focus();
                    this.Hide();
                    Formulario.ShowDialog();
                    this.Show();
                }

                if (TipoUsuario == 3)
                {
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
                    MessageBox.Show("Usuario o Contraseña Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Clear();
                    TxtUsuario.Focus();
                }

                if (TipoUsuario == 5)
                {
                    MessageBox.Show("Usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Clear();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                }

                if (TipoUsuario == 0)
                {
                    MessageBox.Show("Intentelo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Clear();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                }

            }                            
        }
    }   
}
