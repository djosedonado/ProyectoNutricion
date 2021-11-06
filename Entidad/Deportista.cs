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
            Peso = 0;
            Altura = 0;
            CaloriasDiarias = 0;
            MetabolismoBasal = 0;

        }
        public string Deporte { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string FechaEgreso { get; set; }
        public double CaloriasDiarias { get; set; }
        public double MetabolismoBasal { get; set; }
        public string TermogenesisActividadFisica { get; set; }
        public double ActividadFisica { get; set; }



        private void CalcularMetabolismoBasal()
        {
            MetabolismoBasal = 24 * Peso;
        }

        private void CalcularActividadFisica()
        {
            if (TermogenesisActividadFisica.Equals("Leve"))
            {
                ActividadFisica = 0.2;
            }

            if (TermogenesisActividadFisica.Equals("Moderada"))
            {
                ActividadFisica = 0.3;
            }
            if (TermogenesisActividadFisica.Equals("Intensa"))
            {
                ActividadFisica = 0.4;
            }
            if (TermogenesisActividadFisica.Equals("Extrema"))
            {
                ActividadFisica = 1;
            }
        }

    }
}
