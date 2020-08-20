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
using System.Xml;

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
        ClsDatosCampeonato DatosCampeonato = new ClsDatosCampeonato();
        ClsPartido DatosPartido = new ClsPartido();

        List<int> IDs_Equipos = new List<int>();

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

        
        private void FrmAdminCampeonato_Load(object sender, EventArgs e)
        {
            MostrarDeporte();
            MostrarSede();
            MostrarEstadoPartido();
            MostrarFalta();
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
                    Campeonato.IngresoCampeonato(Txt_Crear_Campeonato.Text, No_Equipos, Sede, Deporte, DateTime.Today.ToString(), IDs_Equipos);
                    Campeonato.Eliminatoria_Directa(No_Equipos, IDs_Equipos);
                    MessageBox.Show("Ingreso correcto de Campeonato" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            else if (Rbtn_Todos.Checked == true)
            {
                int No_Equipos = (int)Nud_Cantidad_Todos.Value;
                Campeonato.CampeonatoTvT(Campeonato.TipoCampeonato(No_Equipos), IDs_Equipos, Txt_Crear_Campeonato.Text, No_Equipos, Sede, Deporte, DateTime.Now.ToString());
                MessageBox.Show("Ingreso correcto de Campeonato" + MessageBoxButtons.OK + MessageBoxIcon.Error);
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

        private void Btn_Modificar_Buscar_Campeonato_Click(object sender, EventArgs e)
        {
            DatosCampeonato = Campeonato.BusquedaCampeonato(Txt_Modificar_Id_Campeonato.Text);
            Txt_Modificar_Nombre_Campeonato.Text = DatosCampeonato.Nombre;
            Txt_Modificar_Cantidad_Equipos_Campeonato.Text = DatosCampeonato.No_Equipos;
            Cbx_Modificar_Sede_Campeonato.Text = DatosCampeonato.Sede;
            Txt_Modificar_Deporte_Campeonato.Text = DatosCampeonato.Deporte;
            Dtp_Modificar_Fecha_Campeonato.Text = DatosCampeonato.FechaCreacion;
        }

        private void Btn_Modificar_Campeonato_Click(object sender, EventArgs e)
        {
            int Sede = Cbx_Modificar_Sede_Campeonato.SelectedIndex + 1;
            Campeonato.ModificarCampeonato(Sede);
        }

        private void Btn_Buscar_Partido_Click(object sender, EventArgs e)
        {
            DatosPartido = Campeonato.BuscarPartido(Txt_Modificar_Id_Partido.Text);
            Txt_Modificar_Nombre_Campeonato_Partido.Text = DatosPartido.NombreCampeonato;
            Txt_Modificar_Local_Partido.Text = DatosPartido.Local;
            Txt_Modificar_Visitante_Partido.Text = DatosPartido.Visitante;
            Txt_Modificar_MarcadorLocal.Text = DatosPartido.MarcadorLocal;
            Txt_Modificar_MarcadorVisitante.Text = DatosPartido.MarcadorVisitante;
            Cbx_Modificar_Estado_Partido.Text = DatosPartido.Estado;
            Dtp_Modificar_Fecha_Partido.Text = DatosPartido.FechaPartido;
        }

        private void Btn_Agregar_Falta_Click(object sender, EventArgs e)
        {
            int Falta = Cbx_Falta.SelectedIndex + 1;
            Campeonato.DetalleFalta(Txt_IDPartido_Control.Text, Falta, Txt_FaltaJugador.Text, Rtxt_Descripcion_Falta.Text);
        }

        private void Btn_Agregar_Anotacion_Click(object sender, EventArgs e)
        {
            string Fecha = "";
            Fecha += Dtp_Hora_Anotacion.Value.Date.ToShortDateString();
            Fecha += " ";
            Fecha += Dtp_Hora_Anotacion.Value.Hour.ToString();
            Fecha += ":";
            Fecha += Dtp_Hora_Anotacion.Value.Minute.ToString();
            Fecha += ":";
            Fecha += Dtp_Hora_Anotacion.Value.Second.ToString();
            Campeonato.DetalleJugador(Txt_IDPartido_Control.Text, Txt_AnotacionJugador.Text, Txt_Anotacion.Text, Fecha);
        }

        private void Tmr_ListadoCampeonatos_Tick(object sender, EventArgs e)
        {
            Campeonato.ListadoCampeonatos(Dgv_ListadoCampeonatos);
        }

        private void Btn_Modificar_Partido_Click(object sender, EventArgs e)
        {
            string Fecha = "";
            Fecha += Dtp_Hora_Anotacion.Value.Date.ToShortDateString();
            Fecha += " ";
            Fecha += Dtp_Hora_Anotacion.Value.Hour.ToString();
            Fecha += ":";
            Fecha += Dtp_Hora_Anotacion.Value.Minute.ToString();
            Fecha += ":";
            Fecha += Dtp_Hora_Anotacion.Value.Second.ToString();
            int Local = Convert.ToInt32(Txt_Modificar_MarcadorLocal.Text);
            int Visitante = Convert.ToInt32(Txt_Modificar_MarcadorVisitante.Text);
            int Estado = Cbx_Modificar_Estado_Partido.SelectedIndex + 1;
            Campeonato.ModificarPartido(Txt_Modificar_Id_Partido.Text, Fecha, Local, Visitante, Estado);
        }

        private void Btn_Buscar_PartidoControl_Click(object sender, EventArgs e)
        {
            Campeonato.ListadoJugadoresPartido(Dgv_Jugadores, Txt_IDPartido_Control.Text);
        }
    }
}
