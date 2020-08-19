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

        
        ClsMantenimientosAdmin Admin = new ClsMantenimientosAdmin();
        ClsEntrenador Entrenador = new ClsEntrenador();
        ClsBitacora Bitacora = new ClsBitacora();
        ClsConexion conexion = new ClsConexion();

        string UsuarioActivo = null;
        int TipoProceso = 0;
        string SenSql1 = null, SenSql2 = null;

        private void FmrAdminEntrenador_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Ingresar_Entrenador_Click(object sender, EventArgs e)
        {
            int notExecute = 1;
            if (Txt_Ingreso_Password.Text == "" || Txt_Ingreso_Nombre1_Entrenador.Text == "" || Txt_Ingreso_Nombre2_Entrenador.Text == "" || Txt_Ingreso_Apellido1_Entrenador.Text == "" || Txt_Ingreso_Apellido2_Entrenador.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                DateTime fecharNac = Dtp_FechaNacimiento_Ingreso.Value.Date;
                var diasNac = (DateTime.Now - fecharNac).TotalDays;

                if (MessageBox.Show("¿Desea agregar un nuevo empleado?", "EMPLEADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                    if (diasNac > 36500)
                    {
                        MessageBox.Show("ADVERTENCIA: Edad erronea, no puede ingresar una edad mayor a 100 años.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        notExecute = 0;
                    }

                    switch (notExecute)
                    {

                        case 1:
                            string Consulta = "SELECT ID_TIPO_USUARIO_FK FROM USUARIO WHERE ID_USUARIO = '" + Txt_Ingreso_Id_Usuario.Text + "' ;";
                            OdbcCommand Query_Validacion = new OdbcCommand(Consulta, conexion.conexion());
                            OdbcDataReader Lector = Query_Validacion.ExecuteReader();
                            if (Lector.HasRows == true) { MessageBox.Show("ERROR: Usuario registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else
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
                                Txt_Ingreso_Password.Text = "";
                                Txt_Ingreso_Nombre1_Entrenador.Text = ""; 
                                Txt_Ingreso_Nombre2_Entrenador.Text = ""; 
                                Txt_Ingreso_Apellido1_Entrenador.Text = ""; 
                                Txt_Ingreso_Apellido2_Entrenador.Text = "";
                                Txt_Ingreso_Id_Usuario.Text = "";
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void Btn_Modificar_Buscar_Entrenador_Click(object sender, EventArgs e)
        {
            if (Txt_Modificar_Id_Entenador.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
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
                Btn_CambiarFoto.Enabled = true;
                Btn_Modificar_Entrenador.Enabled = true;
            }

        }

        private void Btn_Modificar_Entrenador_Click(object sender, EventArgs e)
        {
            if (Txt_Modificar_Usuario_Entrenador.Text == "" || Txt_Modificar_Password_Entrenador.Text == "" || Txt_Modificar_Nombre1_Entrenador.Text == "" || Txt_Modificar_Nombre2_Entrenador.Text == "" || Txt_Modificar_Apellido1_Entrenador.Text == "" || Txt_Modificar_Apellido2_Entrenador.Text == "" ) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (MessageBox.Show("¿Desea modificar un  entrenador?", "ENTRENADOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                        UsuarioActivo = ClsDatos.UserId;
                        TipoProceso = 4;
                        SenSql1 = "UPDATE ENTRENADOR SET NOMBRE1= + Nombre1 + , NOMBRE2= + Nombre2 " +
                                                      ", APELLIDO1= + Apellido1 + , APELLIDO2= + Apellido2 " +
                                                      " WHERE ID_ENTRENADOR= + ID_Entrenador ";

                        SenSql2 = "UPDATE USUARIO SET ID_USUARIO= + Usuario + , PASSWORD= + Password " +
                                                      " WHERE ID_USUARIO= + Usuario  ";
                        Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                        Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

                        Admin.ModificarEntrenador(Txt_Modificar_Id_Entenador.Text, Txt_Modificar_Usuario_Entrenador.Text, Txt_Modificar_Password_Entrenador.Text, Txt_Modificar_Nombre1_Entrenador.Text, Txt_Modificar_Nombre2_Entrenador.Text, Txt_Modificar_Apellido1_Entrenador.Text, Txt_Modificar_Apellido2_Entrenador.Text);
                        Txt_Modificar_Usuario_Entrenador.Text = "";
                        Txt_Modificar_Password_Entrenador.Text = "";
                        Txt_Modificar_Nombre1_Entrenador.Text = "";
                        Txt_Modificar_Nombre2_Entrenador.Text = "";
                        Txt_Modificar_Apellido1_Entrenador.Text = "";
                        Txt_Modificar_Apellido2_Entrenador.Text = "";
                        Txt_Modificar_Id_Entenador.Text = "";
                        Btn_CambiarFoto.Enabled = false;
                        Btn_Modificar_Entrenador.Enabled = false;
                    
                }
            }
        }

        private void Btn_Eliminar_Buscar_Entrenador_Click(object sender, EventArgs e)
        {
            if (Txt_Eliminar_Id_Entrenador.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
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
                    Btn_Eliminar_Entrenador.Enabled = true;

            }  
        }

        private void Btn_Eliminar_Entrenador_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar un  entrenador?", "ENTRENADOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
            else
            {
                UsuarioActivo = ClsDatos.UserId;
                TipoProceso = 5;
                SenSql1 = "UPDATE ENTRENADOR SET ID_ESTADO_ENTRENADOR_FK =  + 2 +  WHERE ID_ENTRENADOR=  + Id_Entrenador + ";

                SenSql2 = "UPDATE USUARIO SET ID_TIPO_USUARIO_FK =  + 4 +  WHERE ID_USUARIO= + Usuario + ";

                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql2);

                Admin.EliminarEntrenador(Txt_Eliminar_Usuario_Entrenador.Text, Txt_Eliminar_Id_Entrenador.Text);
                Txt_Eliminar_Nombre1_Entrenador.Text = "";
                Txt_Eliminar_Nombre2_Entrenador.Text = "";
                Txt_Eliminar_Apellido1_Entrenador.Text = "";
                Txt_Eliminar_Apellido2_Entrenador.Text = "";
                Txt_Eliminar_Usuario_Entrenador.Text = "";
                Txt_Eliminar_Password_Entrenador.Text = "";
                Txt_Eliminar_Tipo_Usuario_Entrenador.Text = "";
                Txt_Eliminar_Id_Entrenador.Text = "";
                Btn_Eliminar_Entrenador.Enabled = false;
            }
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
        private void numero(object sender, KeyPressEventArgs e)
        {
            ClsValidarKeyPress.Numeros(e);
        }

        private void Tmr_ListadoEntrenadores_Tick(object sender, EventArgs e)
        {
            Admin.ListadoEntrenadores(Dgw_Listado_Entrenadores);
        }

        private void letra(object sender, KeyPressEventArgs e)
        {
            ClsValidarKeyPress.Letras(e);
        }
    }
}
