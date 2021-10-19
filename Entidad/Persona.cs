using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public Persona()
        {
            Edad = 0;
        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidó { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }


    }

}
