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
        ClsPartido DatosPartido = new ClsPartido();

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
                
                string MarcadorLocal = "0";
                string MarcadorVisitante = "0";
                int ID_Partido;
                string Correlativo1 = "SELECT IFNULL(MAX(ID_PARTIDO),0) +1 FROM PARTIDO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo1, conexion.conexion());
                ID_Partido = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                int ID_Campeonato;
                string Correlativo2 = "SELECT MAX(ID_CAMPEONATO) FROM CAMPEONATO";
                OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                string InsertarPartido = "INSERT INTO PARTIDO (ID_PARTIDO, ID_CAMPEONATO_FK, FECHA_PARTIDO, ID_LOCAL, ID_VISITANTE, MARCADOR_LOCAL, MARCADOR_VISITANTE, ID_ESTADO_PARTIDO_FK)" +
                    "VALUES('" + ID_Partido + "','" + ID_Campeonato + "','" + fecha + "','" + local + "','" + visitante + "','" + MarcadorLocal + "','" + MarcadorVisitante + "','" + 1 + "')";

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
            string MarcadorLocal = "0";
            string MarcadorVisitante = "0";
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

                    string InsertarPartido = "INSERT INTO PARTIDO (ID_PARTIDO, ID_CAMPEONATO_FK, FECHA_PARTIDO, ID_LOCAL, ID_VISITANTE, MARCADOR_LOCAL, MARCADOR_VISITANTE, ID_ESTADO_PARTIDO_FK)" +
                   "VALUES('" + ID_Partido + "','" + ID_Campeonato + "','" + Fecha + "','" + IDs_Equipos[i] + "','" + IDs_Equipos[i + 1] + "','" + MarcadorLocal + "','" + MarcadorVisitante + "','" + 1 + "')";
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

        public void ModificarCampeonato(int Sede)
        {
            try
            {
                string ModificarCampeonato = "UPDATE CAMPEONATO SET ID_SEDE_POLI_FK='" + Sede + "'";
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

        public ClsPartido BuscarPartido(string ID_Partido)
        {
            try
            {
                string BuscarPartido = "SELECT C.NOMBRE_CAMPEONATO, P.FECHA_PARTIDO, P.MARCADOR_LOCAL, P.MARCADOR_VISITANTE, EP.NOMBRE_ESTADO " +
                    "FROM PARTIDO AS P, CAMPEONATO AS C, ESTADO_PARTIDO AS EP " +
                    "WHERE P.ID_CAMPEONATO_FK = C.ID_CAMPEONATO AND P.ID_ESTADO_PARTIDO_FK = EP.ID_ESTADO AND P.ID_PARTIDO ='" + ID_Partido + "'";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarPartido, conexion.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {                  
                    while (Lector1.Read())
                    {
                        DatosPartido.NombreCampeonato = Lector1.GetString(0);
                        DatosPartido.FechaPartido = Lector1.GetString(1);
                        DatosPartido.MarcadorLocal = Lector1.GetString(2);
                        DatosPartido.MarcadorVisitante = Lector1.GetString(3);
                        DatosPartido.Estado = Lector1.GetString(4);
                    }

                    string BuscarLocal = "SELECT E.NOMBRE_EQUIPO " +
                        "FROM PARTIDO AS P, EQUIPO AS E " +
                        "WHERE P.ID_LOCAL = E.ID_EQUIPO AND P.ID_PARTIDO = '" + ID_Partido + "'";
                    OdbcCommand Query_Busqueda2 = new OdbcCommand(BuscarLocal, conexion.conexion());
                    OdbcDataReader Lector2 = Query_Busqueda2.ExecuteReader();

                    if (Lector2.HasRows == true)
                    {
                        while (Lector2.Read())
                        {
                            DatosPartido.Local = Lector2.GetString(0);
                        }

                        string BuscarVisitante = "SELECT E.NOMBRE_EQUIPO " +
                        "FROM PARTIDO AS P, EQUIPO AS E " +
                        "WHERE P.ID_VISITANTE = E.ID_EQUIPO AND P.ID_PARTIDO = '" + ID_Partido + "'";
                        OdbcCommand Query_Busqueda3 = new OdbcCommand(BuscarVisitante, conexion.conexion());
                        OdbcDataReader Lector3 = Query_Busqueda3.ExecuteReader();

                        if (Lector3.HasRows == true)
                        {
                            while (Lector3.Read())
                            {
                                DatosPartido.Visitante = Lector3.GetString(0);
                            }
                        }

                    }    

                }
                return DatosPartido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DatosPartido;
            }
        }

        public void ListadoJugadoresPartido(DataGridView Listado, string ID_Partido)
        {
            try
            {
                string MostrarJugadores = "SELECT J.ID_JUGADOR, concat(J.NOMBRE1, ' ' , J.NOMBRE2, ' ' , J.APELLIDO1, ' ' , J.APELLIDO2) AS 'Nombre Completo Del Jugador' " +
                                "FROM JUGADOR AS J, EQUIPO AS E, PARTIDO AS P " +
                                "WHERE P.ID_LOCAL = E.ID_EQUIPO AND P.ID_PARTIDO ='" + ID_Partido + "'";

                OdbcCommand Query_SELECT = new OdbcCommand(MostrarJugadores, conexion.conexion());
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

        public void DetalleFalta(string ID_Partido, int ID_Falta, string ID_Jugador, string Descripcion)
        {
            try
            {
                int ID_DetalleFalta;
                string Correlativo1 = "SELECT IFNULL(MAX(ID_DETALLE_FALTA),0) +1 FROM DETALLE_FALTA";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo1, conexion.conexion());
                ID_DetalleFalta = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                int ID_Campeonato;
                string Correlativo2 = "SELECT ID_CAMPEONATO_FK FROM PARTIDO" +
                    " WHERE ID_PARTIDO = '" + ID_Partido + "'";
                OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                string InsertarDetallePartido = "INSERT INTO DETALLE_FALTA (ID_DETALLE_FALTA, ID_FALTA_FK, ID_PARTIDO_FK, ID_JUGADOR_FK, ID_CAMPEONATO_FK, DESCRIPCION_FALTA) " +
                    "VALUES('" + ID_DetalleFalta + "','" + ID_Falta + "','" + ID_Partido + "','" + ID_Jugador + "','" + ID_Campeonato + "','" + Descripcion + "')";

                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarDetallePartido, conexion.conexion());
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

        public void DetalleJugador(string ID_Partido, string ID_Jugador, string Anotacion, string Fecha)
        {
            try
            {
                int ID_DetalleJugador;
                string Correlativo1 = "SELECT IFNULL(MAX(ID_DETALLE_JUGADOR),0) +1 FROM DETALLE_JUGADOR";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo1, conexion.conexion());
                ID_DetalleJugador = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                int ID_Campeonato;
                string Correlativo2 = "SELECT ID_CAMPEONATO_FK FROM PARTIDO" +
                    " WHERE ID_PARTIDO = '" + ID_Partido + "'";
                OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, conexion.conexion());
                ID_Campeonato = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                string InsertarDetallePartido = "INSERT INTO DETALLE_JUGADOR (ID_DETALLE_JUGADOR, ID_PARTIDO_FK, ID_CAMPEONATO_FK, ID_JUGADOR_PARTIDO_FK, ANOTACION, FECHA_PARTIDO) " +
                    "VALUES('" + ID_DetalleJugador + "','" + ID_Partido + "','" + ID_Campeonato + "','" + ID_Jugador + "','" + Anotacion + "','" + Fecha + "')";

                OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarDetallePartido, conexion.conexion());
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

        public void ModificarPartido(string ID_Partido, string Fecha, int Local, int Visitante, int Estado)
        {
            if(Estado != 2)
            {
                try
                {
                    string ModificarPartido = "UPDATE PARTIDO SET FECHA_PARTIDO ='" + Fecha + "', MARCADOR_LOCAL ='" + Local + "', MARCADOR_VISITANTE ='" + Visitante + "', ID_ESTADO_PARTIDO_FK ='" + Estado + "' WHERE ID_PARTIDO='" + ID_Partido + "'";
                    OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarPartido, conexion.conexion());
                    Query_UPDATE1.ExecuteNonQuery();

                    int PuntosLocal;
                    string Puntos1 = "SELECT PUNTOS_TORNEO " +
                        "FROM EQUIPO_CAMPEONATO AS EC, EQUIPO AS E, PARTIDO AS P " +
                        "WHERE EC.ID_EQUIPO_FK = E.ID_EQUIPO AND P.ID_LOCAL = E.ID_EQUIPO AND P.ID_PARTIDO ='" + ID_Partido + "'";
                    OdbcCommand Query_Validacion1 = new OdbcCommand(Puntos1, conexion.conexion());
                    PuntosLocal = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                    int PuntosVisitante;
                    string Puntos2 = "SELECT PUNTOS_TORNEO " +
                        "FROM EQUIPO_CAMPEONATO AS EC, EQUIPO AS E, PARTIDO AS P " +
                        "WHERE EC.ID_EQUIPO_FK = E.ID_EQUIPO AND P.ID_VISITANTE = E.ID_EQUIPO AND P.ID_PARTIDO ='" + ID_Partido + "'";
                    OdbcCommand Query_Validacion2 = new OdbcCommand(Puntos2, conexion.conexion());
                    PuntosVisitante = Convert.ToInt32(Query_Validacion2.ExecuteScalar());

                    int ID_Local;
                    string Corelativo1 = "SELECT ID_EQUIPO_FK " +
                        "FROM EQUIPO_CAMPEONATO AS EC, EQUIPO AS E, PARTIDO AS P " +
                        "WHERE EC.ID_EQUIPO_FK = E.ID_EQUIPO AND P.ID_LOCAL = E.ID_EQUIPO AND P.ID_PARTIDO ='" + ID_Partido + "'";
                    OdbcCommand Query_Validacion3 = new OdbcCommand(Corelativo1, conexion.conexion());
                    ID_Local = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                    int ID_Visitante;
                    string Correlativo2 = "SELECT ID_EQUIPO_FK " +
                        "FROM EQUIPO_CAMPEONATO AS EC, EQUIPO AS E, PARTIDO AS P " +
                        "WHERE EC.ID_EQUIPO_FK = E.ID_EQUIPO AND P.ID_VISITANTE = E.ID_EQUIPO AND P.ID_PARTIDO ='" + ID_Partido + "'";
                    OdbcCommand Query_Validacion4 = new OdbcCommand(Correlativo2, conexion.conexion());
                    ID_Visitante = Convert.ToInt32(Query_Validacion4.ExecuteScalar());

                    if (Local > Visitante)
                    {
                        PuntosLocal = PuntosLocal + 3;

                    }
                    else if (Visitante > Local)
                    {
                        PuntosVisitante = PuntosVisitante + 3;
                    }
                    else
                    {
                        PuntosLocal = PuntosLocal + 0;
                        PuntosVisitante = PuntosVisitante + 0;
                    }

                    string ModificarLocal = "UPDATE EQUIPO_CAMPEONATO SET PUNTOS_TORNEO ='" + PuntosLocal + "' WHERE ID_EQUIPO_FK='" + ID_Local + "'";
                    OdbcCommand Query_UPDATE2 = new OdbcCommand(ModificarLocal, conexion.conexion());
                    Query_UPDATE2.ExecuteNonQuery();

                    string ModificarVisitante = "UPDATE EQUIPO_CAMPEONATO SET PUNTOS_TORNEO ='" + PuntosVisitante + "' WHERE ID_EQUIPO_FK='" + ID_Visitante + "'";
                    OdbcCommand Query_UPDATE3 = new OdbcCommand(ModificarVisitante, conexion.conexion());
                    Query_UPDATE3.ExecuteNonQuery();

                    MessageBox.Show("Equipo modificado con éxito.", "FORMULARIO PARTIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                try
                {
                    string ModificarPartido = "UPDATE PARTIDO SET FECHA_PARTIDO ='" + Fecha + "', MARCADOR_LOCAL ='" + Local + "', MARCADOR_VISITANTE ='" + Visitante + "', ID_ESTADO_PARTIDO_FK ='" + Estado + "' WHERE ID_PARTIDO='" + ID_Partido + "'";
                    OdbcCommand Query_UPDATE1 = new OdbcCommand(ModificarPartido, conexion.conexion());
                    Query_UPDATE1.ExecuteNonQuery();

                    MessageBox.Show("Equipo modificado con éxito.", "FORMULARIO PARTIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
