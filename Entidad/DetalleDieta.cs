using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleDieta
    {
        public DetalleDieta()
        {
            cantidad = 0;
        }
        public string idDetalleDieta{get;set;}
        public int cantidad { get; set; }
        public List<Dieta> dietas { get; set }
        public List<Alimento> alimentos { get; set; }

        public void agregarAlimentos(Alimento alimento)
        {
            alimento.IdDietas = idDetalleDieta;
            alimentos.Add(alimento);
        }
    }
}
