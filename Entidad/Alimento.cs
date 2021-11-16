using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Alimento
    {
        public Alimento()
        {
            Carbohidratos = 0;
            Proteinas = 0;
            Liquidos = 0;
            Calorias = 0;
        }

        public Alimento(string idAlimento, string nombreAlimento, decimal caloria, decimal carbohidratos, decimal proteinas, decimal liquidos)
        {

        }

        public string IdAlimentos { get; set; }
        public string NombreAlimento { get; set; }
        public decimal Calorias { get; set; }
        public decimal Carbohidratos { get; set; }
        public decimal Proteinas { get; set; }
        public decimal Liquidos { get; set; }
        public string IdDietas { get; set; }
    }
}
