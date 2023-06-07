using Entidad;
using Logica;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebasAlimentos
    {
        serviceAlimento service;
        Alimento alimento;
        [SetUp]
        public void Setup()
        {
            service = new serviceAlimento();
            alimento = new Alimento();
        }
        //Agregar Alimento
        [Test]
        public void TestAgregarAlimentos()
        {
            alimento.IdAlimentos = "127";
            alimento.NombreAlimento = "ARINA";
            alimento.Carbohidratos = 23;
            alimento.Proteinas = 21;
            alimento.Calorias = 25;
            alimento.Liquidos = 3;
            string result = service.Guardar(alimento);
            string esperado = "Alimento Guardado";
            Assert.AreEqual(esperado,result);
            Assert.Pass();
        }

    }
}
