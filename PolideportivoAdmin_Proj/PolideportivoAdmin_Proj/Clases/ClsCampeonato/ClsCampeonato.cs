using System;
using System.Collections.Generic;
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
            IngresoCampeonato(nombre, No_Equipos, Sede, deporte, fecha);
            Console.WriteLine("IDA");
            DateTime Fecha = new DateTime();

            for (int i =0; i < Rondas.GetLength(0); i++)
            {
                Console.Write("Ronda " + (i + 1) + ": ");

                for (int j =0; j < Rondas.GetLength(1); j++)
                {
                    Console.Write("   " + (1 + Rondas[i, j].Local) + "-" + (1 + Rondas[i, j].Visitante));
                    IngresoPartido(DateTime.Today.AddHours(12).ToString(), IDs_Equipos[Rondas[i, j].Local], IDs_Equipos[Rondas[i, j].Visitante]);
                }
                Console.WriteLine();
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

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO PARTIDOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void IngresoCampeonato(string nombre, int No_Equipos, int Sede, int deporte, string fecha)
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

                MessageBox.Show("Ingreso Exitoso", "FORMULARIO CAMPEONATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
