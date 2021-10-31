using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class Dieta : Deportista
    {
        public Dieta()
        {
            GastoEnergeticoDiario = 0;
            AcciónDinámicaEspecíficaAlimentos = 0.1;
        }
        
        public double AcciónDinámicaEspecíficaAlimentos { get; set; }
        public double GastoEnergeticoDiario { get; set; }

        public abstract void CalculoPorSexo();

    }
}
