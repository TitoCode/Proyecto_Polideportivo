using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolideportivoAdmin_Proj.Mantenimientos.Gerencia;
using PolideportivoAdmin_Proj.Clases;
using PolideportivoAdmin_Proj.Clases.ClsUsuario;
using PolideportivoAdmin_Proj.Clases.ClsBaseDeDatos;
using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using System.Data.Odbc;
using System.Diagnostics;
using SpreadsheetLight;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;


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
        ClsReportes Reporte = new ClsReportes();

        string UsuarioActivo = null;
        int TipoProceso;
        string SenSql1 = null;

 

        void GenerarExcel_8Colmn(DataGridView Dgv){
            Process Proceso = new Process();
            SLDocument LlenadoDocumento = new SLDocument();
            SLStyle FormatoDocumento = new SLStyle();
            FormatoDocumento.Font.FontSize = 10;
            FormatoDocumento.Font.Bold = true;
            if (Dgv.Rows.Count > 0){
                string Ruta = "";
                
                if(Sfd_GuardarExcel.ShowDialog() == DialogResult.OK){
                    Ruta = Sfd_GuardarExcel.FileName;
                    try
                    {
                        int recorre = 1;
                        foreach(DataGridViewColumn column in Dgv.Columns){

                            LlenadoDocumento.SetCellValue(1, recorre, column.HeaderText.ToString());
                            LlenadoDocumento.SetCellStyle(1, recorre, FormatoDocumento);
                            LlenadoDocumento.SetColumnWidth(recorre, 25);
                            recorre++;
                        }
                        int llenado = 2;
                        foreach(DataGridViewRow row in Dgv.Rows){
                            LlenadoDocumento.SetCellValue(llenado, 1, row.Cells[0].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 2, row.Cells[1].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 3, row.Cells[2].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 4, row.Cells[3].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 5, row.Cells[4].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 6, row.Cells[5].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 7, row.Cells[6].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 8, row.Cells[7].Value.ToString());
                            llenado++;
                        }

                        LlenadoDocumento.AutoFitColumn(1, 10);
                        LlenadoDocumento.AutoFitRow(1, 10000);
                        LlenadoDocumento.SaveAs(Ruta);
                        
                        MessageBox.Show("Se ha guardado Correctamente \nA Continuación se abrirá el Reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte_";
                        Proceso.StartInfo.FileName = Ruta;
                        Proceso.Start();
                    }catch(Exception){
                        MessageBox.Show("La acción no se ha podido completar debido a que tiene abierto el archivo Excel" +
                            "\nCierre el archivo y vuelva a intentarlo.", "Guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte";
                    }

                }//fin if

            }else{
                MessageBox.Show("Aún No se ha Generado una Busqueda", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//fin metodo


        void GenerarExcel_5Colmn(DataGridView Dgv)
        {
            Process Proceso = new Process();
            SLDocument LlenadoDocumento = new SLDocument();
            SLStyle FormatoDocumento = new SLStyle();
            FormatoDocumento.Font.FontSize = 10;
            FormatoDocumento.Font.Bold = true;
            if (Dgv.Rows.Count > 0)
            {
                string Ruta = "";

                if (Sfd_GuardarExcel.ShowDialog() == DialogResult.OK)
                {
                    Ruta = Sfd_GuardarExcel.FileName;
                    try
                    {
                        int recorre = 1;
                        foreach (DataGridViewColumn column in Dgv.Columns)
                        {

                            LlenadoDocumento.SetCellValue(1, recorre, column.HeaderText.ToString());
                            LlenadoDocumento.SetCellStyle(1, recorre, FormatoDocumento);
                            LlenadoDocumento.SetColumnWidth(recorre, 25);
                            recorre++;
                        }
                        int llenado = 2;
                        foreach (DataGridViewRow row in Dgv.Rows)
                        {
                            LlenadoDocumento.SetCellValue(llenado, 1, row.Cells[0].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 2, row.Cells[1].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 3, row.Cells[2].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 4, row.Cells[3].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 5, row.Cells[4].Value.ToString());
                            llenado++;
                        }

                        LlenadoDocumento.AutoFitColumn(1, 10);
                        LlenadoDocumento.AutoFitRow(1, 10000);
                        LlenadoDocumento.SaveAs(Ruta);

                        MessageBox.Show("Se ha guardado Correctamente \nA Continuación se abrirá el Reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte_";
                        Proceso.StartInfo.FileName = Ruta;
                        Proceso.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("La acción no se ha podido completar debido a que tiene abierto el archivo Excel" +
                            "\nCierre el archivo y vuelva a intentarlo.", "Guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte";
                    }

                }

            }else{
                MessageBox.Show("Aún No se ha Generado una Busqueda", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//fin metodo

        void GenerarExcel_4Colmn(DataGridView Dgv)
        {
            Process Proceso = new Process();
            SLDocument LlenadoDocumento = new SLDocument();
            SLStyle FormatoDocumento = new SLStyle();
            FormatoDocumento.Font.FontSize = 10;
            FormatoDocumento.Font.Bold = true;
            if (Dgv.Rows.Count > 0)
            {
                string Ruta = "";

                if (Sfd_GuardarExcel.ShowDialog() == DialogResult.OK)
                {
                    Ruta = Sfd_GuardarExcel.FileName;
                    try
                    {
                        int recorre = 1;
                        foreach (DataGridViewColumn column in Dgv.Columns)
                        {

                            LlenadoDocumento.SetCellValue(1, recorre, column.HeaderText.ToString());
                            LlenadoDocumento.SetCellStyle(1, recorre, FormatoDocumento);
                            LlenadoDocumento.SetColumnWidth(recorre, 25);
                            recorre++;
                        }
                        int llenado = 2;
                        foreach (DataGridViewRow row in Dgv.Rows)
                        {
                            LlenadoDocumento.SetCellValue(llenado, 1, row.Cells[0].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 2, row.Cells[1].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 3, row.Cells[2].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 4, row.Cells[3].Value.ToString());
                            llenado++;
                        }

                        LlenadoDocumento.AutoFitColumn(1, 10);
                        LlenadoDocumento.AutoFitRow(1, 10000);
                        LlenadoDocumento.SaveAs(Ruta);

                        MessageBox.Show("Se ha guardado Correctamente \nA Continuación se abrirá el Reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte_";
                        Proceso.StartInfo.FileName = Ruta;
                        Proceso.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("La acción no se ha podido completar debido a que tiene abierto el archivo Excel" +
                            "\nCierre el archivo y vuelva a intentarlo.", "Guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte";
                    }

                }

            }else{
                MessageBox.Show("Aún No se ha Generado una Busqueda", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//fin metodo

        void GenerarExcel_3Colmn(DataGridView Dgv)
        {
            Process Proceso = new Process();
            SLDocument LlenadoDocumento = new SLDocument();
            SLStyle FormatoDocumento = new SLStyle();
            FormatoDocumento.Font.FontSize = 10;
            FormatoDocumento.Font.Bold = true;
            if (Dgv.Rows.Count > 0)
            {
                string Ruta = "";

                if (Sfd_GuardarExcel.ShowDialog() == DialogResult.OK)
                {
                    Ruta = Sfd_GuardarExcel.FileName;
                    try
                    {
                        int recorre = 1;
                        foreach (DataGridViewColumn column in Dgv.Columns)
                        {

                            LlenadoDocumento.SetCellValue(1, recorre, column.HeaderText.ToString());
                            LlenadoDocumento.SetCellStyle(1, recorre, FormatoDocumento);
                            LlenadoDocumento.SetColumnWidth(recorre, 25);
                            recorre++;
                        }
                        int llenado = 2;
                        foreach (DataGridViewRow row in Dgv.Rows)
                        {
                            LlenadoDocumento.SetCellValue(llenado, 1, row.Cells[0].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 2, row.Cells[1].Value.ToString());
                            LlenadoDocumento.SetCellValue(llenado, 3, row.Cells[2].Value.ToString());
                            llenado++;
                        }

                        LlenadoDocumento.AutoFitColumn(1, 10);
                        LlenadoDocumento.AutoFitRow(1, 10000);
                        LlenadoDocumento.SaveAs(Ruta);

                        MessageBox.Show("Se ha guardado Correctamente \nA Continuación se abrirá el Reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte_";
                        Proceso.StartInfo.FileName = Ruta;
                        Proceso.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("La acción no se ha podido completar debido a que tiene abierto el archivo Excel" +
                            "\nCierre el archivo y vuelva a intentarlo.", "Guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Sfd_GuardarExcel.FileName = "Reporte";
                    }

                }//fin if

            }else{
                MessageBox.Show("Aún No se ha Generado una Busqueda", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//fin metodo



        private void FrmReportes_Load(object sender, EventArgs e)
        {

            Reporte.Reporte_Jugador(Dgv_Jugadores);
            Reporte.Reporte_Suspendidos(Dgv_Suspendidos);
            Reporte.Partidos_Campeonato(Dgv_Resultados);
        }

        private void Btn_ReporteJugador_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 15;
            SenSql1 = "SELECT J.NOMBRE1, J.NOMBRE2, J.APELLIDO1, J.APELLIDO2, J.FECHA_NACIMIENTO, E.NOMBRE_EQUIPO ,TP.NOMBRE_POSICION, EJ.NOMBRE_ESTADO FROM JUGADOR AS J, EQUIPO AS E, TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO";
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

            GenerarExcel_8Colmn(Dgv_Jugadores);

        }

        private void Btn_ReporteJugadoresSuspendidos_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 15;
            SenSql1 = "SELECT J.NOMBRE1, J.APELLIDO1, E.NOMBRE_EQUIPO ,TP.NOMBRE_POSICION FROM JUGADOR AS J, EQUIPO AS E, TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO AND EJ.ID_ESTADO_JUGADOR = + 2 + ";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

            GenerarExcel_4Colmn(Dgv_Suspendidos);

        }

        private void Btn_ReporteResultadosPartidos_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 15;
            SenSql1 = "SELECT P.ID_PARTIDO, C.NOMBRE_CAMPEONATO, P.MARCADOR FROM PARTIDO AS P, CAMPEONATO AS C WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

            GenerarExcel_3Colmn(Dgv_Resultados);

        }

        private void Btn_ReportePosicionesCampeonato_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 15;
            SenSql1 = "SELECT C.NOMBRE_CAMPEONATO, E.NOMBRE_EQUIPO, EC.PUNTOS_TORNEO FROM EQUIPO AS E, EQUIPO_CAMPEONATO AS EC, CAMPEONATO AS C WHERE EC.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND EC.ID_EQUIPO_FK = E.ID_EQUIPO AND C.ID_CAMPEONATO =+ Campeonato +  ORDER BY PUNTOS_TORNEO desc";

            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

            GenerarExcel_3Colmn(Dgv_Posiciones);
        }

        private void Btn_ReporteEquiposCampeonato_Click(object sender, EventArgs e)
        {

            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 15;
            SenSql1 = "SELECT EC.ID_DETALLE_CAMPEONATO, C.NOMBRE_CAMPEONATO, E.NOMBRE_EQUIPO FROM EQUIPO AS E, EQUIPO_CAMPEONATO AS EC, CAMPEONATO AS C WHERE EC.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND EC.ID_EQUIPO_FK = E.ID_EQUIPO AND C.ID_CAMPEONATO = + Id_Campeonato + ";
            //Se llama a la clase de Bitacora.
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);
            //Se llama al método para generar el Reporte en Excel.
            GenerarExcel_3Colmn(Dgv_EquiposCampeonatos);

        }

        private void Btn_ReporteJugadoresEquipo_Click(object sender, EventArgs e)
        {
            UsuarioActivo = ClsDatos.UserId;
            TipoProceso = 15;
            SenSql1 = "SELECT J.ID_JUGADOR, J.NOMBRE1, J.APELLIDO1,TP.NOMBRE_POSICION ,EJ.NOMBRE_ESTADO FROM TIPO_JUGADOR AS TP, ESTADO_JUGADOR AS EJ, JUGADOR AS J, EQUIPO AS E WHERE J.ID_POSICION_FK = TP.ID_TIPO_JUGADOR AND J.ID_ESTADO_JUGADOR_FK = EJ.ID_ESTADO_JUGADOR AND J.ID_EQUIPO_FK = E.ID_EQUIPO AND E.ID_EQUIPO = + Id_Equipo + ";
            Bitacora.IngresoBitacora(TipoProceso, UsuarioActivo, SenSql1);

            GenerarExcel_5Colmn(Dgv_JugadoresEquipo);
        }

        private void Btn_BuscarCampeonato_Click(object sender, EventArgs e)
        {

            if(Txt_IdCampeonatoPosicion.Text == ""){
                MessageBox.Show("No ha Completado el Campo del ID", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                Reporte.Posiciones_Campeonato(Dgv_Posiciones, Txt_IdCampeonatoPosicion.Text);
                Txt_IdCampeonatoPosicion.Clear();
            }
            

        }

        private void Btn_Busqueda_Campeonato_Click(object sender, EventArgs e)
        {
            if (Txt_IdEquipo.Text == ""){
                MessageBox.Show("No ha Completado el Campo del ID", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                Reporte.Jugador_Equipo(Dgv_JugadoresEquipo, Txt_IdEquipo.Text);
                Txt_IdEquipo.Clear();
            }
            

           

        }

        private void Btn_BusquedaCampeonato_Click(object sender, EventArgs e)
        {
            if (Txt_IdEquipoCampeonato.Text == "")
            {
                MessageBox.Show("No ha Completado el Campo del ID", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                Reporte.Equipos_Campeonato(Dgv_EquiposCampeonatos, Txt_IdEquipoCampeonato.Text);
                Txt_IdEquipoCampeonato.Clear();
            }
            

        }
    }

}