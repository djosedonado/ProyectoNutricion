using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Deportista : Persona
    {
        public Deportista()
        {

        }
        public string TipoDeporte { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string HorasPracticas { get; set; }
    }
}
