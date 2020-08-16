using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Clases.ClsCampeonato
{
    public class ClsCampeonato
    {
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

        public Partido[,] Campeonato(int No_Equipo)
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

        public void IngresoPartidos(Partido[,] Rondas, ref Form FrmPartidos)
        {
            for(int i =0; i < Rondas.GetLength(0); i++)
            {
                for(int j =0; j < Rondas.GetLength(1); j++)
                {
                    //textBoxContent.Text += "   " + (1 + Rondas[i, j].Local) + "-" + (1 + Rondas[i, j].Visitante);
                }
            }
        }


    }
}
