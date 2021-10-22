using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Dieta
    {
        public string codigoAlimento { get; set; }
        public double Porcion { get; set; }
        public DateTime TiempoDieta { get; set; }
        public double CalortiaDiaria { get; set; }

        public void CalcularCaloriasDiarias()
        {

        }
    }
}
