using PolideportivoAdmin_Proj.Clases.ClsAdmin;
using PolideportivoAdmin_Proj.Clases.ClsCampeonato;
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

namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    public partial class FrmAdminCampeonato : Form
    {
        public FrmAdminCampeonato()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();
        ClsMantenimientosAdmin Admin = new ClsMantenimientosAdmin();
        ClsEquipo Equipo = new ClsEquipo();
        ClsCampeonato Campeonato = new ClsCampeonato();
        List<int> IDs_Equipos = new List<int>();

        int ID_Campeonato;

        private void Rdb_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Todos.Checked == true) { 
                Gbx_Campeonato_Tipo_Tct.Visible = true; 
                Rbtn_Ida.Visible = true; 
                Rbtn_IdaVuelta.Visible = true; 
                Lbl_Campeonato_Ida.Visible = true; 
                Lbl_Campeonato_Ida_Vuelta.Visible = true; 
                Nud_Cantidad_Todos.Visible = true;
                Cbx_Equipos.Visible = false;
                Gbx_TipoCampeonato.Size = new Size(318, 232);
            }
            else 
            {
                Gbx_TipoCampeonato.Size = new Size(318, 128);
                Gbx_Campeonato_Tipo_Tct.Visible = false;
                Rbtn_Ida.Visible = false;
                Rbtn_IdaVuelta.Visible = false;
                Lbl_Campeonato_Ida.Visible = false;
                Lbl_Campeonato_Ida_Vuelta.Visible = false;
                Nud_Cantidad_Todos.Visible = false;
                Cbx_Equipos.Visible = true;
            }

        }

        private void MostrarDeporte()
        {
            try
            {

                string CargarTipoDeporte = "SELECT * FROM TIPO_DEPORTE";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarTipoDeporte, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cbx_Crear_Deporte.DataSource = Datos;
                Cbx_Crear_Deporte.DisplayMember = "NOMBRE_DEPORTE";
                Cbx_Crear_Deporte.ResetText();

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

        private void MostrarSede()
        {
            try
            {

                string CargarSede = "SELECT * FROM SEDE_POLIDEPORTIVO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarSede, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cbx_Crear_Sede.DataSource = Datos;
                Cbx_Crear_Sede.DisplayMember = "NOMBRE_SEDE";
                Cbx_Crear_Sede.ResetText();

                Cbx_Modificar_Sede_Campeonato.DataSource = Datos;
                Cbx_Modificar_Sede_Campeonato.DisplayMember = "NOMBRE_SEDE";
                Cbx_Modificar_Sede_Campeonato.ResetText();

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

        private void MostrarEstadoPartido()
        {
            try
            {

                string CargarEstadosPartido = "SELECT NOMBRE_ESTADO FROM ESTADO_PARTIDO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarEstadosPartido, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cbx_Modificar_Estado_Partido.DataSource = Datos;
                Cbx_Modificar_Estado_Partido.DisplayMember = "NOMBRE_ESTADO";
                Cbx_Modificar_Estado_Partido.ResetText();

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

        private void DetalleCampeonato()
        {
            for (int i = 0; i < IDs_Equipos.Count; i++) 
            {
                try
                {
                    string Correlativo = "SELECT IFNULL(MAX(ID_DETALLE_CAMPEONATO),0) +1 FROM EQUIPO_CAMPEONATO";
                    OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                    int Id_Detalle_Campeonato = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                    OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();


                    string InsertarCampeonato = "INSERT INTO EQUIPO_CAMPEONATO (ID_DETALLE_CAMPEONATO, ID_CAMPEONATO_FK, ID_EQUIPO_FK, PUNTOS_TORNEO)"
                        + "VALUES('" + Id_Detalle_Campeonato + "','" + ID_Campeonato + "','" + IDs_Equipos[i] + "','" + 0 + "')";
                    OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarCampeonato, conexion.conexion());
                    Query_Validacion3.ExecuteNonQuery();

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

        private void MostrarFalta()
        {
            try
            {

                string CargarFalta = "SELECT NOMBRE FROM FALTA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarFalta, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cbx_Falta.DataSource = Datos;
                Cbx_Falta.DisplayMember = "NOMBRE";
                Cbx_Falta.ResetText();

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

        private void MostrarJugador()
        {
            string NombreJugador;
            try
            {

                string CargarJugador = "SELECT J.NOMBRE1, J.NOMBRE2, J.APELLIDO1, J.APELLIDO2 FROM JUGADOR AS J, EQUIPOS AS E, CAMPEONATO AS C, " +
                    "PARTIDO AS P WHERE (J.ID_EQUIPO_FK = E.ID_EQUIPO AND E.ID_TIPO_DEPORTE__FK = C.ID_TIPO_DEPORTE_FK " +
                    "C.ID_CAMPEONATO  = P.ID_CAMPEONATO_FK AND P.ID_LOCAL = E.ID_EQUIPO)";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarJugador, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cbx_Falta.DataSource = Datos;
                Cbx_Falta.DisplayMember = "NOMBRE";
                Cbx_Falta.ResetText();

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
        private void FrmAdminCampeonato_Load(object sender, EventArgs e)
        {
            MostrarDeporte();
            MostrarSede();
            MostrarEstadoPartido();
            MostrarFalta();
            MostrarJugador();
        }

        private void Btn_IngresoEquipo_Click(object sender, EventArgs e)
        {
            Equipo = Admin.BusquedaIDEquipo(Txt_IdEquipo.Text);

            if (Dgv_Equipos_Campeonato.RowCount > 0)
            {
                // Primero averigua si el registro existe:
                bool existe = false;
                for (int i = 0; i < Dgv_Equipos_Campeonato.RowCount; i++)
                {
                    if (Convert.ToInt16(Dgv_Equipos_Campeonato.Rows[i].Cells["Clm_NoEquipo"].Value) == Convert.ToInt16(Txt_IdEquipo.Text))
                    {
                        MessageBox.Show("El Equipo ya esta ingresado");
                        existe = true;
                        break;
                    }
                }
                if (existe == false)
                {
                    IDs_Equipos.Add(Convert.ToInt32(Txt_IdEquipo.Text));
                    DataGridViewRow row = (DataGridViewRow)Dgv_Equipos_Campeonato.Rows[0].Clone();
                    row.Cells[0].Value = Txt_IdEquipo.Text;
                    row.Cells[1].Value = Equipo.Nombre;
                    Dgv_Equipos_Campeonato.Rows.Add(row);
                }
            }
            Txt_IdEquipo.Text = "";
            Txt_IdEquipo.Focus();
        }

        private void Btn_Ingresar_Campeonato_Click(object sender, EventArgs e)
        {
            int Sede, Deporte;
            Deporte = Cbx_Crear_Deporte.SelectedIndex + 1;
            Sede = Cbx_Crear_Sede.SelectedIndex + 1;

            if (Rbtn_Eliminatoria.Checked == true)
            {
                

                if (Convert.ToInt32(Dgv_Equipos_Campeonato.RowCount - 1) != Convert.ToInt32(Cbx_Equipos.SelectedItem))
                {
                    MessageBox.Show("Ingrese la cantidad correcta de equipos para el campeonato." + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
                else
                {
                    int No_Equipos;
                    No_Equipos = Convert.ToInt32(Cbx_Equipos.SelectedItem);
                    try
                    {
                        string Correlativo = "SELECT IFNULL(MAX(ID_CAMPEONATO),0) +1 FROM CAMPEONATO";
                        OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                        ID_Campeonato = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                        OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();


                        string InsertarCampeonato = "INSERT INTO CAMPEONATO (ID_CAMPEONATO, NOMBRE_CAMPEONATO, CANTIDAD_EQUIPOS, ID_SEDE_POLI_FK, ID_TIPO_DEPORTE_FK, FECHA_CREACION)"
                            + "VALUES('" + ID_Campeonato + "','" + Txt_Crear_Campeonato.Text + "','" + No_Equipos + "','" + Sede + "','" + Deporte + "','" + DateTime.Today.ToString() + "')";
                        OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarCampeonato, conexion.conexion());
                        Query_Validacion3.ExecuteNonQuery();
                       
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error al ejecutar SQL: " +
                        System.Environment.NewLine + System.Environment.NewLine +
                        ex.GetType().ToString() + System.Environment.NewLine +
                        ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Eliminatoria_Directa();
                }
            }

            else if (Rbtn_Todos.Checked == true)
            {
                int No_Equipos = (int)Nud_Cantidad_Todos.Value;
                Campeonato.CampeonatoTvT(Campeonato.TipoCampeonato(No_Equipos), IDs_Equipos, Txt_Crear_Campeonato.Text, No_Equipos, Sede, Deporte, DateTime.Now.ToString());
            }

            else
            {
                MessageBox.Show("Selecciones el tipo de Campeonato." + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }

        }

        private void Nud_Cantidad_Todos_ValueChanged(object sender, EventArgs e)
        {
            Nud_Cantidad_Todos.Minimum = 2;
        }

        private void Rdb_Eliminatoria_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Eliminatoria.Checked == true) { Lbl_Crear_Cantidad_Equipos.Visible = true; Cbx_Equipos.Visible = true; }
            else { Lbl_Crear_Cantidad_Equipos.Visible = false; Cbx_Equipos.Visible = false; }
        }

        private void Eliminatoria_Directa() 
        {
            string Marcador = "";
            int ID_Partido;
            string Fecha = DateTime.Today.AddHours(12).ToString();

            try 
            {
                int ID_Campeonato;
                string Correlativo2 = "SELECT MAX(ID_CAMPEONATO) FROM CAMPEONATO";
                OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                for (int i = 0; i < Convert.ToInt32(Cbx_Equipos.SelectedItem); i += 2)
                {
                    string Correlativo1 = "SELECT IFNULL(MAX(ID_PARTIDO),0) +1 FROM PARTIDO";
                    OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo1, conexion.conexion());
                    ID_Partido = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                    string InsertarPartido = "INSERT INTO PARTIDO (ID_PARTIDO, ID_CAMPEONATO_FK, FECHA_PARTIDO, ID_LOCAL, ID_VISITANTE, MARCADOR, ID_ESTADO_PARTIDO_FK)" +
                   "VALUES('" + ID_Partido + "','" + ID_Campeonato + "','" + Fecha + "','" + IDs_Equipos[i] + "','" + IDs_Equipos[i+1] + "','" + Marcador + "','" + 1 + "')";
                    OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarPartido, conexion.conexion());
                    Query_Validacion3.ExecuteNonQuery();
                    Fecha = DateTime.Parse(Fecha).AddDays(5).ToString();
                }
                DetalleCampeonato();
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

        private void Btn_Modificar_Buscar_Campeonato_Click(object sender, EventArgs e)
        {
            try
            {
                string BuscarCampeonato = "SELECT C.NOMBRE_CAMPEONATO, C.CANTIDAD_EQUIPOS,C.FECHA_CREACION, " +
                    "SP.NOMBRE_SEDE, TD.NOMBRE_DEPORTE FROM CAMPEONATO AS C, SEDE_POLIDEPORTIVO AS SP, TIPO_DEPORTE AS TD" +
                    " WHERE C.ID_SEDE_POLI_FK = SP.ID_SEDE AND C.ID_TIPO_DEPORTE_FK = TD.ID_TIPO_DEPORTE AND C.ID_CAMPEONATO ='" + Txt_Modificar_Id_Campeonato.Text + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarCampeonato, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        Txt_Modificar_Nombre_Campeonato.Text = Lector.GetString(0);
                        Txt_Modificar_Cantidad_Equipos_Campeonato.Text = Lector.GetString(1);
                        Dtp_Modificar_Fecha_Campeonato.Text = Lector.GetString(2);
                        Cbx_Modificar_Sede_Campeonato.Text = Lector.GetString(3);
                        Txt_Modificar_Deporte_Campeonato.Text = Lector.GetString(4);
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

        private void Btn_Modificar_Campeonato_Click(object sender, EventArgs e)
        {
            try 
            {
                string ModificarCampeonato = "UPDATE CAMPEONATO SET ID_SEDE_POLI_FK='" + (Cbx_Modificar_Sede_Campeonato.SelectedIndex + 1) + "'";
                OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarCampeonato, conexion.conexion());
                Query_UPDATE1.ExecuteNonQuery();
                MessageBox.Show("Campeonato modificado con éxito.", "FORMULARIO ADMINNISTRACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Btn_Buscar_Partido_Click(object sender, EventArgs e)
        {
            try
            {
                int Id_Local, Id_visitante;
                string Local, Visitante;

                string BuscarLocal = "SELECT P.ID_LOCAL FROM PARTIDO AS P, CAMPEONATO AS C" +
                  " WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND P.ID_PARTIDO ='" + Txt_Modificar_Id_Partido.Text + "'";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarLocal, conexion.conexion());
                Id_Local = Convert.ToInt32(Query_Busqueda1.ExecuteScalar());

                string BuscarVisitante = "SELECT P.ID_VISITANTE FROM PARTIDO AS P, CAMPEONATO AS C" +
                  " WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND P.ID_PARTIDO ='" + Txt_Modificar_Id_Partido.Text + "'";
                OdbcCommand Query_Busqueda2 = new OdbcCommand(BuscarVisitante, conexion.conexion());
                Id_visitante = Convert.ToInt32(Query_Busqueda2.ExecuteScalar());

                string BuscarNombreLocal = "SELECT NOMBRE_EQUIPO FROM EQUIPO WHERE ID_EQUIPO ='" + Id_Local + "'";
                OdbcCommand Query_Busqueda3 = new OdbcCommand(BuscarNombreLocal, conexion.conexion());
                Local = Convert.ToString(Query_Busqueda3.ExecuteScalar());

                string BuscarNombreVisitante = "SELECT NOMBRE_EQUIPO FROM EQUIPO WHERE ID_EQUIPO ='" + Id_visitante + "'";
                OdbcCommand Query_Busqueda4 = new OdbcCommand(BuscarNombreVisitante, conexion.conexion());
                Visitante = Convert.ToString(Query_Busqueda4.ExecuteScalar());

                string BuscarPartido = "SELECT P.FECHA_PARTIDO, P.MARCADOR, " +
                    "C.NOMBRE_CAMPEONATO, EP.NOMBRE_ESTADO FROM PARTIDO AS P, CAMPEONATO AS C, ESTADO_PARTIDO AS EP " +
                    "WHERE C.ID_CAMPEONATO = P.ID_CAMPEONATO_FK AND P.ID_PARTIDO ='" + Txt_Modificar_Id_Partido.Text + "'";
                OdbcCommand Query_Busqueda5 = new OdbcCommand(BuscarPartido, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda5.ExecuteReader();

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        Dtp_Modificar_Fecha_Partido.Text = Lector.GetString(0);
                        Txt_Modificar_Marcador_Partido.Text = Lector.GetString(1);
                        Txt_Modificar_Nombre_Campeonato_Partido.Text = Lector.GetString(2);
                        Cbx_Modificar_Estado_Partido.Text = Lector.GetString(3);
                        Txt_Modificar_Local_Partido.Text =Local;
                        Txt_Modificar_Visitante_Partido.Text = Visitante;
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

        private void Btn_Agregar_Falta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Agregar_Anotacion_Click(object sender, EventArgs e)
        {

        }
    }
}
