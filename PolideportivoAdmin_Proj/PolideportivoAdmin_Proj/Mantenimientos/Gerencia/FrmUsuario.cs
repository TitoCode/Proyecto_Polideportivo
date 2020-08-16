using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Clases;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        ClsMantenimientosEmpleado Ingreso = new ClsMantenimientosEmpleado();
        ClsBitacora Bitacora = new ClsBitacora();

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fotografia = new OpenFileDialog();
            Fotografia.Filter = "Imagenes |*.jpg; *.png";
            Fotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Fotografia.Title = "Seleccionar Imagen";

            if(Fotografia.ShowDialog() == DialogResult.OK)
            {
                Ptb_Foto.Image = Image.FromFile(Fotografia.FileName);
            }

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            string UsuarioActivo = ClsDatos.UserId;
            int TipoProceso = 1;
            string SenSql1 = "UPDATE EMPLEADO SET FOTOGRAFIA = + Foto +  WHERE ID_USUARIO_FK= + Usuario + ";

            string SenSql2 = "UPDATE USUARIO SET ID_USUARIO= + Usuario + , PASSWORD= + Password " +
                                           "WHERE ID_USUARIO= + Usuario + ";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);


            MemoryStream ms = new MemoryStream();
            Ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            Ingreso.ActualizarPerfil(Txt_Usuario.Text, Txt_Password.Text, aByte);
        }

    }
}
