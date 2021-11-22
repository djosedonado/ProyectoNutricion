using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Dieta
    {
        public Dieta()
        {
            AcciónDinámicaEspecíficaAlimentos=0;
        }

        public string IdDieta { get; set; }
        public double AcciónDinámicaEspecíficaAlimentos { get; set; }
        public string RecomendacionNutriccional { get; set; }
        public string RecomendacionAlimentaria { get; set; }
        public string DiasAplicados { get; set; }
        public List<DetalleDieta> detalleDietas { get; set; }

        public void MetodoAccinDinamicaEspecificaAlimentos()
        {
            AcciónDinámicaEspecíficaAlimentos = 0.1;
        }

        public void agregarDetalleDieta(DetalleDieta detalleDieta)
        {
            detalleDieta.idDetalleDieta = IdDieta;
            detalleDietas.Add(detalleDieta);
        }

    }
}
