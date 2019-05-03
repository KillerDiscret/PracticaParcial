using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Avion
    {
        public string CODIGOAVION { get; set; }
        public string TIPOAVION { get; set; }
        public int CAPACIDAD { get; set; }
        public List<Vuelo> VUELOS { get; set; }
    }
}
