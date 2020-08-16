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
using PolideportivoAdmin_Proj.Clases.ClsAdmin;
using System.IO;
using System.Drawing.Imaging;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases;

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdminEntrenador : Form
    {
        public FrmAdminEntrenador()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();
        ClsMantenimientosAdmin Admin = new ClsMantenimientosAdmin();
        ClsEntrenador Entrenador = new ClsEntrenador();

        ClsBitacora Bitacora = new ClsBitacora();
        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null, SenSql2 = null;

        private void FmrAdminEntrenador_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Ingresar_Entrenador_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 6;
            SenSql1 = "INSERT INTO USUARIO (ID_USUARIO, PASSWORD, ID_TIPO_USUARIO_FK) VALUES ( + Usuario + , + Password + , + 2 + )";

            SenSql2 = "INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE1, NOMBRE2, APELLIDO1, APELLIDO2, CORREO, ID_TIPO_PUESTO, DIRECCION, TELEFONO, FECHA_NACIMIENTO, NIT, DPI, ID_USUARIO_FK, FECHA_CONTRATO, ID_ESTADO_EMPLEADO_FK) VALUES ( + ID_Empleado + , + Nombre1 + , + Nombre2 + , + Apellido1 " +
                ", + Apellido2 + , + Email + , + TipoPuesto + , + Direccion + ,  + Telefono + ,  + FechaNacimiento + , + NIT + , + DPI + , + Usuario + , + FechaContrato + , + 1 + )";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

            MemoryStream ms = new MemoryStream();
            Ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            Admin.IngresoEntrenador(Txt_Ingreso_Id_Usuario.Text, Txt_Ingreso_Password.Text, Txt_Ingreso_Nombre1_Entrenador.Text, Txt_Ingreso_Nombre2_Entrenador.Text, Txt_Ingreso_Apellido1_Entrenador.Text, Txt_Ingreso_Apellido2_Entrenador.Text, Dtp_FechaNacimiento_Ingreso.Value.Date.ToString(), aByte);
         }

        private void Btn_Modificar_Buscar_Entrenador_Click(object sender, EventArgs e)
        {
            Entrenador = Admin.BusquedaIDEntrenador(Txt_Modificar_Id_Entenador.Text);
            Txt_Modificar_Nombre1_Entrenador.Text = Entrenador.Nombre1;
            Txt_Modificar_Nombre2_Entrenador.Text = Entrenador.Nombre2;
            Txt_Modificar_Apellido1_Entrenador.Text = Entrenador.Apellido1;
            Txt_Modificar_Apellido2_Entrenador.Text = Entrenador.Apellido2;
            Dtp_Modificar_Fdn_Entrenador.Text = Entrenador.FechaNacimiento;
            Txt_Modificar_Usuario_Entrenador.Text = Entrenador.ID_Usuario;
            Txt_Modificar_Password_Entrenador.Text = Entrenador.Pasword;
            Txt_Modificar_Tipo_Usuario_Entrenador.Text = Entrenador.TipoUsuario;

        }

        private void Btn_Modificar_Entrenador_Click(object sender, EventArgs e)
        {

            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 4;
            SenSql1 = "UPDATE ENTRENADOR SET NOMBRE1= + Nombre1 + , NOMBRE2= + Nombre2 "+
                                          ", APELLIDO1= + Apellido1 + , APELLIDO2= + Apellido2 "+
                                          " WHERE ID_ENTRENADOR= + ID_Entrenador ";

            SenSql2 = "UPDATE USUARIO SET ID_USUARIO= + Usuario + , PASSWORD= + Password "+
                                          " WHERE ID_USUARIO= + Usuario  ";
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

            Admin.ModificarEntrenador(Txt_Modificar_Id_Entenador.Text, Txt_Modificar_Usuario_Entrenador.Text, Txt_Modificar_Password_Entrenador.Text, Txt_Modificar_Nombre1_Entrenador.Text, Txt_Modificar_Nombre2_Entrenador.Text, Txt_Modificar_Apellido1_Entrenador.Text, Txt_Modificar_Apellido2_Entrenador.Text);
        }

        private void Btn_Eliminar_Buscar_Entrenador_Click(object sender, EventArgs e)
        {
            Entrenador = Admin.BusquedaIDEntrenador(Txt_Eliminar_Id_Entrenador.Text);
            Txt_Eliminar_Nombre1_Entrenador.Text = Entrenador.Nombre1;
            Txt_Eliminar_Nombre2_Entrenador.Text = Entrenador.Nombre2;
            Txt_Eliminar_Apellido1_Entrenador.Text = Entrenador.Apellido1;
            Txt_Eliminar_Apellido2_Entrenador.Text = Entrenador.Apellido2;
            Dtp_Eliminar_Fdn_Entrenador.Text = Entrenador.FechaNacimiento;
            Txt_Eliminar_Usuario_Entrenador.Text = Entrenador.ID_Usuario;
            Txt_Eliminar_Password_Entrenador.Text = Entrenador.Pasword;
            Txt_Eliminar_Tipo_Usuario_Entrenador.Text = Entrenador.TipoUsuario;
                   
        }

        private void Btn_Eliminar_Entrenador_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 5;
            SenSql1 = "UPDATE ENTRENADOR SET ID_ESTADO_ENTRENADOR_FK =  + 2 +  WHERE ID_ENTRENADOR=  + Id_Entrenador + ";

            SenSql2 = "UPDATE USUARIO SET ID_TIPO_USUARIO_FK =  + 4 +  WHERE ID_USUARIO= + Usuario + ";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

            Admin.EliminarEntrenador(Txt_Eliminar_Usuario_Entrenador.Text, Txt_Eliminar_Id_Entrenador.Text);
        }

        private void Btn_Fotografia_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fotografia = new OpenFileDialog();
            Fotografia.Filter = "Imagenes |*.jpg; *.png";
            Fotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Fotografia.Title = "Seleccionar Imagen";

            if (Fotografia.ShowDialog() == DialogResult.OK)
            {
                Ptb_Foto.Image = Image.FromFile(Fotografia.FileName);
            }
        }

        private void Btn_CambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fotografia = new OpenFileDialog();
            Fotografia.Filter = "Imagenes |*.jpg; *.png";
            Fotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Fotografia.Title = "Seleccionar Imagen";

            if (Fotografia.ShowDialog() == DialogResult.OK)
            {
                Ptb_Foto_Modificar.Image = Image.FromFile(Fotografia.FileName);
            }
        }
    }
}
