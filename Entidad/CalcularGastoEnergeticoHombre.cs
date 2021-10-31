using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CalcularGastoEnergeticoHombre : Dieta
    {
        public override void CalculoPorSexo()
        {
            GastoEnergeticoDiario = (66.5 + (13.75 * Peso) + (5.08 * Altura) - (6.78 * Edad) + AcciónDinámicaEspecíficaAlimentos + ActividadFisica);
        }
    }
}
