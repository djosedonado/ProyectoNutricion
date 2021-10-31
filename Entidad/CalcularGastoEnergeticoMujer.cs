using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CalcularGastoEnergeticoMujer : Dieta
    {
        public override void CalculoPorSexo()
        {
            GastoEnergeticoDiario = (65.51 + (9.56 * Peso) + (1.85 * Altura) - (4.68 * Edad) + AcciónDinámicaEspecíficaAlimentos + ActividadFisica);
        }
    }
}
