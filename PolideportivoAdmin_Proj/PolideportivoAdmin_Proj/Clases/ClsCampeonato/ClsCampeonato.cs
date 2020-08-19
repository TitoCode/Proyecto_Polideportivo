using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsCampeonato
{
    public class ClsCampeonato
    {

        ClsConexion conexion = new ClsConexion();
        ClsDatosCampeonato Campeonato = new ClsDatosCampeonato();

        public class Partido
        {
            public int Local = -1;
            public int Visitante = -1;
        }

        private Partido[,] CampeonatoPar(int No_Equipos)
        {
            
            int No_Rondas = No_Equipos - 1;
            int No_PartidosPorRonda = No_Equipos / 2;

            Partido[,] Rondas = new Partido[No_Rondas, No_PartidosPorRonda];

            for(int i=0, k=0; i < No_Rondas; i++)
            {
                for(int j =0; j < No_PartidosPorRonda; j++)
                {
                    Rondas[i, j] = new Partido();
                    Rondas[i, j].Local = k;
                    k++;

                    if(k == No_Rondas) { k = 0; }
                }
            }

            for(int i = 0; i< No_Rondas; i++)
            {
                if (i % 2 == 0)
                {
                    Rondas[i, 0].Visitante = No_Equipos - 1;
                }
                else
                {
                    Rondas[i, 0].Visitante = Rondas[i, 0].Local;
                    Rondas[i, 0].Local = No_Equipos - 1;
                }
            }

            int EquipoCima = No_Equipos - 1;
            int EquipoImparCima = EquipoCima - 1;

            for(int i =0, k= EquipoImparCima; i < No_Rondas; i++)
            {
                for(int j = 1; j < No_PartidosPorRonda; j++)
                {
                    Rondas[i, j].Visitante = k;
                    k--;

                    if(k== -1) { k=EquipoImparCima; }
                }
            }

            return Rondas;

        }

        private Partido[,] CampeonatoImpar(int No_Equipos)
        {
            int No_Rondas = No_Equipos;
            int No_PartidosPorRonda = No_Equipos / 2;

            Partido[,] Rondas = new Partido[No_Rondas, No_PartidosPorRonda];

            for (int i = 0, k = 0; i < No_Rondas; i++)
            {
                for (int j = -1; j < No_PartidosPorRonda; j++)
                {
                    if(j >= 0)
                    {
                        Rondas[i, j] = new Partido();
                        Rondas[i, j].Local = k;
                    }
                    k++;
                    if (k == No_Rondas) { k = 0; }
                }
            }

            int EquipoCima = No_Equipos - 1;

            for (int i = 0, k = EquipoCima; i < No_Rondas; i++)
            {
                for (int j = 0; j < No_PartidosPorRonda; j++)
                {
                    Rondas[i, j].Visitante = k;
                    k--;
                    if (k == -1) { k = EquipoCima; }
                }
            }

            return Rondas;

        }

        public Partido[,] TipoCampeonato(int No_Equipo)
        {
            if(No_Equipo % 2 == 0)
            {
                return CampeonatoPar(No_Equipo);
            }
            else
            {
                return CampeonatoImpar(No_Equipo);
            }
        }

        public void CampeonatoTvT(Partido[,] Rondas, List<int> IDs_Equipos, string nombre, int No_Equipos, int Sede, int deporte, string fecha)
        {
            IngresoCampeonato(nombre, No_Equipos, Sede, deporte, fecha, IDs_Equipos);
            DateTime Fecha = new DateTime();

            for (int i =0; i < Rondas.GetLength(0); i++)
            {
                for (int j =0; j < Rondas.GetLength(1); j++)
                {
                    IngresoPartido(DateTime.Today.AddHours(12).ToString(), IDs_Equipos[Rondas[i, j].Local], IDs_Equipos[Rondas[i, j].Visitante]);
                }
                Fecha.AddDays(5);
            }
        }

        public void IngresoPartido(string fecha, int local, int visitante)
        {
            try
            {
                
                string Marcador = "";
                int ID_Partido;
                string Correlativo1 = "SELECT IFNULL(MAX(ID_PARTIDO),0) +1 FROM PARTIDO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo1, conexion.conexion());
                ID_Partido = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                int ID_Campeonato;
                string Correlativo2 = "SELECT MAX(ID_CAMPEONATO) FROM CAMPEONATO";
                OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                string InsertarPartido = "INSERT INTO PARTIDO (ID_PARTIDO, ID_CAMPEONATO_FK, FECHA_PARTIDO, ID_LOCAL, ID_VISITANTE, MARCADOR, ID_ESTADO_PARTIDO_FK)" +
                    "VALUES('" + ID_Partido + "','" + ID_Campeonato + "','" + fecha + "','" + local + "','" + visitante + "','" + Marcador + "','" + 1 + "')";

                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarPartido, conexion.conexion());
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

        public void IngresoCampeonato(string nombre, int No_Equipos, int Sede, int deporte, string fecha, List<int> IDs_Equipos)
        {
            try
            {
                int ID_Campeonato;
                string Correlativo = "SELECT IFNULL(MAX(ID_CAMPEONATO),0) +1 FROM CAMPEONATO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

                string InsertarCampeonato = "INSERT INTO CAMPEONATO (ID_CAMPEONATO, NOMBRE_CAMPEONATO, CANTIDAD_EQUIPOS, ID_SEDE_POLI_FK, ID_TIPO_DEPORTE_FK, FECHA_CREACION)" +
                    "VALUES('" + ID_Campeonato + "','" + nombre + "','" + No_Equipos + "','" + Sede + "','" + deporte + "','" + fecha + "')";

                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarCampeonato, conexion.conexion());
                Query_Validacion2.ExecuteNonQuery();

                DetalleCampeonato(IDs_Equipos, ID_Campeonato);
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

        public void ListadoCampeonatos(DataGridView Listado)
        {

            try
            {

                string MostrarEquipos = "SELECT C.ID_CAMPEONATO, C.NOMBRE_CAMPEONATO AS 'NOMBRE DEL CAMPEONATO', T.NOMBRE_DEPORTE 'DEPORTE', S.NOMBRE_SEDE " +
                    "FROM CAMPEONATO AS C, SEDE_POLIDEPORTIVO AS S, TIPO_DEPORTE AS T" +
                    " WHERE C.ID_SEDE_POLI_FK = S.ID_SEDE AND C.ID_TIPO_DEPORTE_FK = T.ID_TIPO_DEPORTE;";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarEquipos, conexion.conexion());
                OdbcDataAdapter Adaptador = new OdbcDataAdapter();
                Adaptador.SelectCommand = Query_SELECT;
                DataTable tabla = new DataTable();
                Adaptador.Fill(tabla);
                Listado.DataSource = tabla;

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

        public void Eliminatoria_Directa(int No_Equipos, List<int> IDs_Equipos)
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

                for (int i = 0; i < No_Equipos; i += 2)
                {
                    string Correlativo1 = "SELECT IFNULL(MAX(ID_PARTIDO),0) +1 FROM PARTIDO";
                    OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo1, conexion.conexion());
                    ID_Partido = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                    string InsertarPartido = "INSERT INTO PARTIDO (ID_PARTIDO, ID_CAMPEONATO_FK, FECHA_PARTIDO, ID_LOCAL, ID_VISITANTE, MARCADOR, ID_ESTADO_PARTIDO_FK)" +
                   "VALUES('" + ID_Partido + "','" + ID_Campeonato + "','" + Fecha + "','" + IDs_Equipos[i] + "','" + IDs_Equipos[i + 1] + "','" + Marcador + "','" + 1 + "')";
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

        private void DetalleCampeonato(List<int> IDs_Equipos, int ID_Campeonato)
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

        public DataTable MostrarJugador(int Local, int Visitante)
        {
            DataTable Datos = new DataTable();
            try
            {

                string CargarJugador = "SELECT concat(J.NOMBRE1, ' ' , J.NOMBRE2, ' ' , J.APELLIDO1, ' ' , J.APELLIDO2) AS 'NOMBRE' " +
                    "FROM JUGADOR AS J, EQUIPOS AS E, CAMPEONATO AS C, PARTIDO AS P " +
                    "WHERE J.ID_EQUIPO_FK = '" + Local + "' OR J.ID_EQUIPO_FK = '" + Visitante + "'";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargarJugador, conexion.conexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();   

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                return Datos;
                //Cbx_Falta.DataSource = Datos;
                //Cbx_Falta.DisplayMember = "NOMBRE";
                //Cbx_Falta.ResetText();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;

            }
        }

        public ClsDatosCampeonato BusquedaCampeonato(string ID_Campeonato)
        {
            try
            {
                string BuscarCampeonato = "SELECT C.NOMBRE_CAMPEONATO, C.CANTIDAD_EQUIPOS, C.FECHA_CREACION, SP.NOMBRE_SEDE, TD.NOMBRE_DEPORTE " +
                    "FROM CAMPEONATO AS C, SEDE_POLIDEPORTIVO AS SP, TIPO_DEPORTE AS TD" +
                    " WHERE C.ID_SEDE_POLI_FK = SP.ID_SEDE AND C.ID_TIPO_DEPORTE_FK = TD.ID_TIPO_DEPORTE AND C.ID_CAMPEONATO ='" + ID_Campeonato + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarCampeonato, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        Campeonato.Nombre = Lector.GetString(0);
                        Campeonato.No_Equipos = Lector.GetString(1);
                        Campeonato.FechaCreacion = Lector.GetString(2);
                        Campeonato.Sede = Lector.GetString(3);
                        Campeonato.Deporte = Lector.GetString(4);
                    }
                }
                return Campeonato;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Campeonato;
            }
        }


    }
}
