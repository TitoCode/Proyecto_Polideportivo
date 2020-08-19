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

        private void Rdb_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Todos.Checked == true) { 
                Gpb_Campeonato_Tipo_Tct.Visible = true; 
                Rdb_Ida.Visible = true; 
                Rdb_IdaVuelta.Visible = true; 
                Lbl_Campeonato_Ida.Visible = true; 
                Lbl_Campeonato_Ida_Vuelta.Visible = true; 
                Nud_Cantidad_Todos.Visible = true;
                Cmb_Equipos.Visible = false;
                Gpb_TipoCampeonato.Size = new Size(318, 232);
            }
            else 
            {
                Gpb_TipoCampeonato.Size = new Size(318, 128);
                Gpb_Campeonato_Tipo_Tct.Visible = false;
                Rdb_Ida.Visible = false;
                Rdb_IdaVuelta.Visible = false;
                Lbl_Campeonato_Ida.Visible = false;
                Lbl_Campeonato_Ida_Vuelta.Visible = false;
                Nud_Cantidad_Todos.Visible = false;
                Cmb_Equipos.Visible = true;
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

                Cmb_Crear_Deporte.DataSource = Datos;
                Cmb_Crear_Deporte.DisplayMember = "NOMBRE_DEPORTE";
                Cmb_Crear_Deporte.ResetText();

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

                string CargarTipoDeporte = "SELECT * FROM SEDE_POLIDEPORTIVO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarTipoDeporte, conexion.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                DataTable Datos = new DataTable();

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Cmb_Crear_Sede.DataSource = Datos;
                Cmb_Crear_Sede.DisplayMember = "NOMBRE_SEDE";
                Cmb_Crear_Sede.ResetText();

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
        }

        private void Btn_IngresoEquipo_Click(object sender, EventArgs e)
        {
            Equipo = Admin.BusquedaIDEquipo(Txt_IdEquipo.Text);

            if (Grid_Equipos.RowCount > 0)
            {
                // Primero averigua si el registro existe:
                bool existe = false;
                for (int i = 0; i < Grid_Equipos.RowCount; i++)
                {
                    if (Convert.ToInt16(Grid_Equipos.Rows[i].Cells["Clm_NoEquipo"].Value) == Convert.ToInt16(Txt_IdEquipo.Text))
                    {
                        MessageBox.Show("El Equipo ya esta ingresado");
                        existe = true;
                        break;
                    }
                }
                if (existe == false)
                {
                    IDs_Equipos.Add(Convert.ToInt32(Txt_IdEquipo.Text));
                    DataGridViewRow row = (DataGridViewRow)Grid_Equipos.Rows[0].Clone();
                    row.Cells[0].Value = Txt_IdEquipo.Text;
                    row.Cells[1].Value = Equipo.Nombre;
                    Grid_Equipos.Rows.Add(row);
                }
            }
            Txt_IdEquipo.Text = "";
            Txt_IdEquipo.Focus();
        }

        private void Btn_Ingresar_Campeonato_Click(object sender, EventArgs e)
        {
            int Sede, Deporte;
            Deporte = Cmb_Crear_Deporte.SelectedIndex + 1;
            Sede = Cmb_Crear_Sede.SelectedIndex + 1;

            if (Rdb_Eliminatoria.Checked == true)
            {
                

                if (Convert.ToInt32(Grid_Equipos.RowCount - 1) != Convert.ToInt32(Cmb_Equipos.SelectedItem))
                {
                    MessageBox.Show("Ingrese la cantidad correcta de equipos para el campeonato." + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
                else
                {
                    int ID_Campeonato, No_Equipos;
                    No_Equipos = Convert.ToInt32(Cmb_Equipos.SelectedItem);
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

            else if (Rdb_Todos.Checked == true)
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
            if (Rdb_Eliminatoria.Checked == true) { Lbl_Crear_Cantidad_Equipos.Visible = true; Cmb_Equipos.Visible = true; }
            else { Lbl_Crear_Cantidad_Equipos.Visible = false; Cmb_Equipos.Visible = false; }
        }

        private void Eliminatoria_Directa() 
        {
            string Marcador = "";
            int ID_Partido;
            string Fecha = DateTime.Today.AddHours(12).ToString();

            try 
            {
                int ID_Campeonato;
                //string Correlativo2 = "SELECT ID_CAMPEONATO, NOMBRE_CAMPEONATO FROM CAMPEONATO WHERE NOMBRE_CAMPEONATO=" + Txt_Crear_Campeonato.Text;
                string Correlativo2 = "SELECT MAX(ID_CAMPEONATO) FROM CAMPEONATO";
                OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                for (int i = 0; i < Convert.ToInt32(Cmb_Equipos.SelectedItem); i += 2)
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
