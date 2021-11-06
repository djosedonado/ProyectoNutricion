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
        public List<Alimentos> alimentos { get; set; }

        public void agregarAlimentos(string idAlimento,string nombreAlimento,double Caloria,double Carbohidratos,double proteinas,double liquidos)
        {
            Alimentos alimento = new Alimentos(idAlimento,nombreAlimento,Caloria,Carbohidratos,proteinas,liquidos);
            alimento.IdDietas = IdDieta;
            alimentos.Add(alimento);
        }
    }
}
