using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Dieta : Deportista
    {
        public Dieta()
        {
            GastoEnergeticoDiario = 0;
            AcciónDinámicaEspecíficaAlimentos = 0.1;
        }
        
        public double AcciónDinámicaEspecíficaAlimentos { get; set; }
        public double GastoEnergeticoDiario { get; set; }
        public string RecomendacionNutriccional { get; set; }
        public string RecomendacionAlimentaria { get; set; }
        public string FechaDietaAsignar { get; set; }
        public string IdDieta { get; set; }
        public string NombreDieta { get; set; }
        public void CalculoPorSexo()
        {
            if (Sexo=="Masculino")
            {
                GastoEnergeticoDiario = (66.5 + (13.75 * Peso) + (5.08 * Altura) - (6.78 * Edad) + AcciónDinámicaEspecíficaAlimentos + ActividadFisica);
            }
            else
            {
                if (Sexo=="Femenino")
                {
                    GastoEnergeticoDiario = (65.51 + (9.56 * Peso) + (1.85 * Altura) - (4.68 * Edad) + AcciónDinámicaEspecíficaAlimentos + ActividadFisica);
                }
                
            }
            
        }
    }
}
