using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAdmin_Proj.Clases.ClsEntrenador
{
    public class ClsJugador
    {
        public string ID_Jugador { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        public string ID_Equipo { get; set; }
        public string Id_Posicion { get; set; }
        public int EstadoJugador { get; set; }
    }
}
