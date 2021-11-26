using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Plantilla
    {
        public string NombrePlantilla { get; set; }
        public int Porcion { get; set; }
        public string Categoria { get; set; }
        public string Ingrediente { get; set; }
        public List<DetallePlantilla> detallePlantillas { get; set; }
    }
}
