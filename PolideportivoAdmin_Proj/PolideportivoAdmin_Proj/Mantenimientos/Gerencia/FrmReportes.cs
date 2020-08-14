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

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

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
                HojaExcel.Cells[1, 1] = "Prueba 1";
                HojaExcel.Cells[1, 2] = "Prueba 2";

                //Formato a las celdas A1, B1 para que esten en Negrita y centrados
                HojaExcel.get_Range("A1", "B1").Font.Bold = true;
                HojaExcel.get_Range("A1", "B1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;//alineacion al centro
                HojaExcel.get_Range("A1", "B1").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic); //Borde
                HojaExcel.get_Range("A1", "B1").Interior.ColorIndex = 44;

                //Ciclos para recorrer todo el datagridView y obtener sus datos
                for (int Fila = 0; Fila < Dgv_DatosReporte.Rows.Count - 1; Fila++)
                {
                    //Variable para colocar datos debajo del encabezado
                    int DatosExcel = Fila + 2;
                    for (int Column = 0; Column < Dgv_DatosReporte.Rows[Fila].Cells.Count; Column++)
                    {
                        string Datos = Dgv_DatosReporte.Rows[Fila].Cells[Column].Value.ToString();
                        HojaExcel.get_Range("A" + DatosExcel, "B" + DatosExcel).Value2 = Datos;
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
                Generar_Reportes();
            }
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            Dgv_DatosReporte.Rows.Add("Nombre1", "Apellido1");
            Dgv_DatosReporte.Rows.Add("Nombre2", "Apellido2");
            Dgv_DatosReporte.Rows.Add("Nombre3", "Apellido3");
            Dgv_DatosReporte.Rows.Add("Nombre4", "Apellido4");
        }
    }
}
