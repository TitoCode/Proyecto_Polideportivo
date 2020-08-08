using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdminEquipo : Form
    {
        public FrmAdminEquipo()
        {
            InitializeComponent();
        }

        ClsConexion Conexion = new ClsConexion();

        private void FrmAdminEquipo_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_Crear_Entrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                string Consulta = "SELECT FROM  WHERE  = '" + .Text + "' AND  "' ;";
                OdbcCommand Query_Validacion = new OdbcCommand(Consulta, x.conexion());
                OdbcDataReader Lector = Query_Validacion.ExecuteReader();

                OdbcCommand  Comando = new OdbcCommand();
                Comando->Connection = Con;
                Comando->CommandText = "SELECT * FROM ESTADO_ODON";
                OdbcDataAdapter  GG = new OdbcDataAdapter();
                DataTable  Datos = new DataTable();

                GG->SelectCommand = Comando;
                GG->Fill(Datos);
                CmbOdonto->DataSource = Datos;
                CmbOdonto->DisplayMember = "NOMBRE";
                CmbOdonto->ResetText();
            }
            catch(Exception ex)
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
