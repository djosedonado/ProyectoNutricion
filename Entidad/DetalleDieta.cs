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
            
        }

        /*public string idDetalleDieta { get; set; }
        public int Porcion { get; set; }
        public string nombrePlantilla { get; set; }
        public string categoria { get; set; }
        public string ingredientes{ get; set; }
        public List<Dieta> dietas { get; set; }
        public List<Alimento> alimentos { get; set; }*/
        public string IdAlimentos { get; set; }
        public string IdDietas { get; set; }
        public Alimento alimento { get; set; }

        /*public void agregarAlimentos(Alimento alimento)
        {
            alimento.IdDietas = idDetalleDieta;
            alimentos.Add(alimento);
        }*/
    }
}
