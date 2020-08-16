using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases;

namespace PolideportivoAdmin_Proj.Mantenimientos.Entrenador
{
    public partial class FrmEntrenador_Jugador : Form
    {
        public FrmEntrenador_Jugador()
        {
            InitializeComponent();
        }

        ClsBitacora Bitacora = new ClsBitacora();
        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null;


        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {

            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 10;
            SenSql1 = "INSERT INTO JUGADOR (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ( + Usuario + , + Password + , + TipoUsuario + )";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
           



        }
    }
}
