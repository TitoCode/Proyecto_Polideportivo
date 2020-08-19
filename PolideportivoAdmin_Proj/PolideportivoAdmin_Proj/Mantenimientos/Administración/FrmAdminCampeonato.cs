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

<<<<<<< HEAD
        private void Rdb_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Todos.Checked == true) { Gpb_Campeonato_Tipo_Tct.Visible = true; Rdb_Ida.Visible = true; Rdb_IdaVuelta.Visible = true; Lbl_Campeonato_Ida.Visible = true; Lbl_Campeonato_Ida_Vuelta.Visible = true; Lbl_Crear_Cantidad_Equipos.Visible = true; Nud_Cantidad_Todos.Visible = true; }
            else { Gpb_Campeonato_Tipo_Tct.Visible = false; Rdb_Ida.Visible = false; Rdb_IdaVuelta.Visible = false; Lbl_Campeonato_Ida.Visible = false; Lbl_Campeonato_Ida_Vuelta.Visible = false; Lbl_Crear_Cantidad_Equipos.Visible = false; Nud_Cantidad_Todos.Visible = false; }

=======
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
        }

        private void Btn_Ingresar_Campeonato_Click(object sender, EventArgs e)
        {
            int No_Equipos = (int)Nud_Cantidad_Todos.Value;
            int Sede, Deporte;
            Sede = Cmb_Crear_Sede.SelectedIndex + 1;
            Deporte = Cmb_Crear_Deporte.SelectedIndex + 1;
            Campeonato.CampeonatoTvT(Campeonato.TipoCampeonato(No_Equipos), IDs_Equipos, Txt_Crear_Campeonato.Text,No_Equipos,Sede,Deporte,DateTime.Now.ToString());
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
        }
    }
}
