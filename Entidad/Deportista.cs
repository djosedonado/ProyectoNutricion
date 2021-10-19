using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Deportista : Persona
    {
        public string TipoDeporte { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public DateTime HorasPracticas { get; set; }
    }
}
