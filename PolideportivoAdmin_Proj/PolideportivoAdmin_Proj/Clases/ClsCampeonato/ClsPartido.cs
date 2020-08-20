using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAdmin_Proj.Clases.ClsCampeonato
{
    public class ClsPartido
    {
        public string ID_Partido { get; set; }
        public string NombreCampeonato { get; set; }
        public string Local { get; set; }
        public string Visitante { get; set; }
        public string MarcadorLocal { get; set; }
        public string MarcadorVisitante { get; set; }
        public string Estado { get; set; }
        public string FechaPartido { get; set; }
    }
}
