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
            role = 0;
            CalcularEdad();
        }
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }  
        public string Nombre { get; set; }
        public string Apellidó { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        public string password { get; set; }
        public int role { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public void CalcularEdad()
        {
            Edad = DateTime.Now.Year;
        }
    }
}
