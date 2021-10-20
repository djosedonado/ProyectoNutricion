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
        public string HorasPracticas { get; set; }
        public double CaloriasDiarias { get; set; }
        public double CalcularMB { get; set; }

        public void MetabolismoBasal()
        {

            if (Sexo == "Femenino")
            {
                CalcularMB = 655 + (9.6 * Peso) + (1.8 * Altura) - (4.7 * Edad);
            }
            else if (Sexo == "Maculino")
            {
                CalcularMB = 66 + (13.7 * Peso) + (5 * Altura) - (6.5 * Edad);
            }
        }

        public void CalcularCalorias()
        {
            if (HorasPracticas == "Entre 1 y 3 veces a la semana")
            {
                CaloriasDiarias = CalcularMB * 1.375;
            }
            else if (HorasPracticas == "Entre 3 y 5 veces a la semana")
            {
                CaloriasDiarias = CalcularMB * 1.55;
            }
            else if (HorasPracticas == "Entre 6 y 7 veces a la semana")
            {
                CaloriasDiarias = CalcularMB * 1.725;
            }
            else if (HorasPracticas == "Entrenamiento fuerte y dos veces al dia")
            {
                CaloriasDiarias = CalcularMB * 1.9;
            }
        }
    }
}
