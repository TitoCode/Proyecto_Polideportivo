using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using PolideportivoAdmin_Proj.Mantenimientos.Gerencia;
using PolideportivoAdmin_Proj.Clases;
using PolideportivoAdmin_Proj.Clases.ClsUsuario;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using System.Data.Odbc;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        ClsBitacora Bitacora = new ClsBitacora();
        ClsConexion conexion = new ClsConexion();
         
        string UsuarioActivo = null;
        int TipoProceso;
        string SenSql1 = null;

        public void Generar_Reportes()
        {

            Excel.Application AplicacionExcel;
            Excel.Workbook LibroExcel;
            Excel.Worksheet HojaExcel;

            try
            {

                //Inicia el excel y se obtiene el objeto Application
                AplicacionExcel = new Excel.Application();
                //InputBox para Colocarle un nombre al Nuevo Documento de Excel
                string NombreExcel = Microsoft.VisualBasic.Interaction.InputBox("Ingrese El nombre del Documento de Excel", "Nombre de Excel", "");
                //Sentencia para que aparezca el Documento Excel al presionar el Botón
                AplicacionExcel.Visible = true;
                object misValue = System.Reflection.Missing.Value;

                //Se crea un nuevo libro de trabajo
                LibroExcel = (Excel.Workbook)(AplicacionExcel.Workbooks.Add(Missing.Value));
                HojaExcel = (Excel.Worksheet)LibroExcel.ActiveSheet;

                //Nombres de Encabezados celda por celda
                HojaExcel.Cells[1, 1] = "ID JUGADOR";
                HojaExcel.Cells[1, 2] = "PRIMER NOMBRE";
                HojaExcel.Cells[1, 3] = "PRIMER APELLIDO";
                HojaExcel.Cells[1, 4] = "POSICION";
                HojaExcel.Cells[1, 5] = "ESTADO JUGADOR";


                //Formato a las celdas A1, B1 para que esten en Negrita y centrados
                HojaExcel.get_Range("A1", "E1").Font.Bold = true;
                HojaExcel.get_Range("A1", "E1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//alineacion al centro
                HojaExcel.get_Range("A1", "E1").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic); //Borde
                HojaExcel.get_Range("A1", "E1").Interior.ColorIndex = 44;

                //Ciclos para recorrer todo el datagridView y obtener sus datos
                for (int Fila = 0; Fila < Dgv_DatosReporte.Rows.Count - 1; Fila++)
                {
                    //Variable para colocar datos debajo del encabezado
                    int DatosExcel = Fila + 2;
                    for (int Column = 0; Column < Dgv_DatosReporte.Rows[Fila].Cells.Count; Column++)
                    {
                        string Datos = Dgv_DatosReporte.Rows[Fila].Cells[Column].Value.ToString();
                        HojaExcel.get_Range("A" + DatosExcel, "E" + DatosExcel).Value2 = Datos;
                    }
                }



                //Se indica la dirección donde se va a guardar el documento de Excel
                LibroExcel.SaveAs("C:\\Users\\TheVolts\\Proyecto_Polideportivo\\" + NombreExcel + ".xlsx", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                MessageBox.Show(errorMessage, "Error");
            }

        }
        private void Btn_Generar_Reporte_Click(object sender, EventArgs e)
        {
            
            if (Rbtn_Tipo1.Checked == false && Rbtn_Tipo2.Checked == false && Rbtn_Tipo3.Checked == false)
            {
                MessageBox.Show("No ha Seleccionado un Tipo de Reporte.");
            }else{

                UsuarioActivo = ClsDatos.UserId;
                TipoProceso = 15;
                SenSql1 = "CONSULTA PENDIENTE";
                Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
                Generar_Reportes();
            }
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try

            {
                //Equipos de cada campeonato. = equipo_campeonato
               // string BuscarDatoEmpleado = "SELECT E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2, E.CORREO, T.NOMBRE_PUESTO, E.DIRECCION, E.TELEFONO, E.FECHA_NACIMIENTO, E.NIT, E.DPI, E.ID_USUARIO_FK, E.FECHA_CONTRATO, S.NOMBRE_ESTADO, U.PASSWORD, TU.NOMBRE_TIPO FROM EMPLEADO AS E, TIPO_PUESTO AS T, USUARIO AS U, ESTADO_EMPLEADO AS S, TIPO_USUARIO AS TU WHERE T.ID_TIPO_PUESTO = E.ID_TIPO_PUESTO AND S.ID_ESTADO_EMPLEADO = E.ID_ESTADO_EMPLEADO_FK AND E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_EMPLEADO ='" + ID_Empleado + "'";
               //consulta para saber los equipos de cada campeonato segun id campeonato
                string EquiposCampeonato = "SELECT EC.ID_DETALLE_CAMPEONATO, C.NOMBRE_CAMPEONATO, E.NOMBRE_EQUIPO FROM EQUIPO AS E, EQUIPO_CAMPEONATO AS EC, CAMPEONATO AS C WHERE EC.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND EC.ID_EQUIPO_FK = E.ID_EQUIPO AND C.ID_CAMPEONATO ='" + textBox1.Text+"'";
                                                                                        
                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true) {
                    while (Lector1.Read())
                    {   
                            Dgv_DatosReporte.Rows.Add(Lector1.GetString(0), Lector1.GetString(1), Lector1.GetString(2));
                           
                    }

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

        private void button2_Click(object sender, EventArgs e)
        {

            try

            {
                //Equipos de cada campeonato. = equipo_campeonato
                // string BuscarDatoEmpleado = "SELECT E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2, E.CORREO, T.NOMBRE_PUESTO, E.DIRECCION, E.TELEFONO, E.FECHA_NACIMIENTO, E.NIT, E.DPI, E.ID_USUARIO_FK, E.FECHA_CONTRATO, S.NOMBRE_ESTADO, U.PASSWORD, TU.NOMBRE_TIPO FROM EMPLEADO AS E, TIPO_PUESTO AS T, USUARIO AS U, ESTADO_EMPLEADO AS S, TIPO_USUARIO AS TU WHERE T.ID_TIPO_PUESTO = E.ID_TIPO_PUESTO AND S.ID_ESTADO_EMPLEADO = E.ID_ESTADO_EMPLEADO_FK AND E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_EMPLEADO ='" + ID_Empleado + "'";
                //consulta para saber los datos de cada jugador por equipo
                string EquiposCampeonato = "SELECT J.ID_JUGADOR, J.NOMBRE1, J.APELLIDO2,TP.NOMBRE_POSICION ,EJ.NOMBRE_ESTADO FROM TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ, JUGADOR AS J, EQUIPO AS E WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO AND E.ID_EQUIPO ='" + textBox2.Text + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Dgv_DatosReporte.Rows.Add(Lector1.GetString(0), Lector1.GetString(1), Lector1.GetString(2), Lector1.GetString(3), Lector1.GetString(4));


                    }

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

        private void button3_Click(object sender, EventArgs e)
        {

            try

            {
               //consulta para saber los equipos de cada campeonato segun id campeonato
                string EquiposCampeonato = "SELECT C.NOMBRE_CAMPEONATO, E.NOMBRE_EQUIPO, EC.PUNTOS_TORNEO FROM EQUIPO AS E, EQUIPO_CAMPEONATO AS EC, CAMPEONATO AS C WHERE EC.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND EC.ID_EQUIPO_FK = E.ID_EQUIPO AND C.ID_CAMPEONATO ='" + textBox1.Text + "' ORDER BY PUNTOS_TORNEO desc";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Dgv_DatosReporte.Rows.Add(Lector1.GetString(0), Lector1.GetString(1), Lector1.GetString(2));

                    }

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

        private void button4_Click(object sender, EventArgs e)
        {

            try

            {

                //Equipos de cada campeonato. = equipo_campeonato
                // string BuscarDatoEmpleado = "SELECT E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2, E.CORREO, T.NOMBRE_PUESTO, E.DIRECCION, E.TELEFONO, E.FECHA_NACIMIENTO, E.NIT, E.DPI, E.ID_USUARIO_FK, E.FECHA_CONTRATO, S.NOMBRE_ESTADO, U.PASSWORD, TU.NOMBRE_TIPO FROM EMPLEADO AS E, TIPO_PUESTO AS T, USUARIO AS U, ESTADO_EMPLEADO AS S, TIPO_USUARIO AS TU WHERE T.ID_TIPO_PUESTO = E.ID_TIPO_PUESTO AND S.ID_ESTADO_EMPLEADO = E.ID_ESTADO_EMPLEADO_FK AND E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_EMPLEADO ='" + ID_Empleado + "'";
                //consulta para saber los equipos de cada campeonato segun id campeonato
                string EquiposCampeonato = "SELECT P.ID_PARTIDO, C.NOMBRE_CAMPEONATO, P.MARCADOR FROM PARTIDO AS P, CAMPEONATO AS C WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO";

               

                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Dgv_DatosReporte.Rows.Add(Lector1.GetString(0), Lector1.GetString(1), Lector1.GetString(2)
                            );

                    }

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

        private void button5_Click(object sender, EventArgs e)
        {

            try

            {

                //Equipos de cada campeonato. = equipo_campeonato
                // string BuscarDatoEmpleado = "SELECT E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2, E.CORREO, T.NOMBRE_PUESTO, E.DIRECCION, E.TELEFONO, E.FECHA_NACIMIENTO, E.NIT, E.DPI, E.ID_USUARIO_FK, E.FECHA_CONTRATO, S.NOMBRE_ESTADO, U.PASSWORD, TU.NOMBRE_TIPO FROM EMPLEADO AS E, TIPO_PUESTO AS T, USUARIO AS U, ESTADO_EMPLEADO AS S, TIPO_USUARIO AS TU WHERE T.ID_TIPO_PUESTO = E.ID_TIPO_PUESTO AND S.ID_ESTADO_EMPLEADO = E.ID_ESTADO_EMPLEADO_FK AND E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_EMPLEADO ='" + ID_Empleado + "'";
                //consulta para saber los equipos de cada campeonato segun id campeonato
                string EquiposCampeonato = "SELECT J.NOMBRE1, J.APELLIDO1, E.NOMBRE_EQUIPO ,TP.NOMBRE_POSICION FROM JUGADOR AS J, EQUIPO AS E, TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO AND EJ.ID_ESTADO_JUGADOR ='" +2+ "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Dgv_DatosReporte.Rows.Add(Lector1.GetString(0), Lector1.GetString(1), Lector1.GetString(2), Lector1.GetString(3));

                    }

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

        private void button6_Click(object sender, EventArgs e)
        {

            try

            {

                //Equipos de cada campeonato. = equipo_campeonato
                // string BuscarDatoEmpleado = "SELECT E.NOMBRE1, E.NOMBRE2, E.APELLIDO1, E.APELLIDO2, E.CORREO, T.NOMBRE_PUESTO, E.DIRECCION, E.TELEFONO, E.FECHA_NACIMIENTO, E.NIT, E.DPI, E.ID_USUARIO_FK, E.FECHA_CONTRATO, S.NOMBRE_ESTADO, U.PASSWORD, TU.NOMBRE_TIPO FROM EMPLEADO AS E, TIPO_PUESTO AS T, USUARIO AS U, ESTADO_EMPLEADO AS S, TIPO_USUARIO AS TU WHERE T.ID_TIPO_PUESTO = E.ID_TIPO_PUESTO AND S.ID_ESTADO_EMPLEADO = E.ID_ESTADO_EMPLEADO_FK AND E.ID_USUARIO_FK = U.ID_USUARIO AND U.ID_TIPO_USUARIO_FK = TU.ID_TIPO_USUARIO AND E.ID_EMPLEADO ='" + ID_Empleado + "'";
                //consulta para saber los equipos de cada campeonato segun id campeonato
                string EquiposCampeonato = "SELECT J.NOMBRE1, J.NOMBRE2, J.APELLIDO1, J.APELLIDO2, J.FECHA_NACIMIENTO, E.NOMBRE_EQUIPO ,TP.NOMBRE_POSICION, EJ.NOMBRE_ESTADO FROM JUGADOR AS J, EQUIPO AS E, TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(EquiposCampeonato, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {
                    while (Lector1.Read())
                    {
                        Dgv_DatosReporte.Rows.Add(Lector1.GetString(0), Lector1.GetString(1), Lector1.GetString(2), Lector1.GetString(3), Lector1.GetString(4), Lector1.GetString(5), Lector1.GetString(6), Lector1.GetString(7));

                    }

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
