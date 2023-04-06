using Entidad;
using Logica;
using Microsoft.NET.Sdk;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace PruebasDeSofoware
{
    public class PruebasUnitaria
    {
        serviceDeportista serviceDeportista;
        serviceAlimento serviceAlimento = new serviceAlimento("Data Source=DONADO\\SQLEXPRESS;Initial Catalog=Nutrisoft;Integrated Security=True");
        Deportista deportista;
        Alimento alimento = new Alimento();
        
        [SetUp]
        public void PruebasNunit()
        {

        }

        [Test]
        public void PruebaRegistro()
        {
            deportista.Identificacion = "1023848272";
            deportista.TipoIdentificacion = "cedula de cidadania";
            deportista.Nombre = "Jose";
            deportista.Apellidó = "Alfredo";
            deportista.Fecha_Nacimiento = DateTime.Now;
            deportista.Telefono = "3155648962";
            deportista.Sexo = "M";
            deportista.Correo = "josealfredo@gmail.com";
            deportista.Peso = 66.2;
            deportista.Altura = 170.1;
            deportista.Deporte = "Natacion";
            deportista.TermogenesisActividadFisica = "Extrema";
            deportista.FechaEgreso = DateTime.Now;

            var respuestaBD = serviceDeportista.Guardar(deportista);
            var expected = "Paciente Registrado";
            Assert.That(respuestaBD, Is.EqualTo(expected));
            Assert.Pass();
        }

        [Test]
        public void registerAliemnt()
        {
            alimento.IdAlimentos = "102";
            alimento.NombreAlimento = "Pan de ajo";
            alimento.Calorias = 12;
            alimento.Liquidos = 12;
            alimento.Proteinas = 12;
            alimento.Carbohidratos = 12;

            var respuestaBD = serviceAlimento.Guardar(alimento);
            var expected = "Se guardaron los datos de satisfactoriamente";
            Assert.That(respuestaBD, Is.EqualTo(expected));
            Assert.Pass();
        }

        [Test]
        public void RegistrarPlantilla()
        {

        }

    }
}