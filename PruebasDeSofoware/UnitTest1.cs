using Entidad;
using Logica;
using Presentacion;
using Datos;
using System.Collections.Generic;

namespace PruebasDeSofoware
{
    public class Tests
    {
        serviceDeportista service;
        Deportista deportista;
        [SetUp]
        public void Setup()
        {
            deportista = new Deportista();
            service = new serviceDeportista(CadenaConexion.ConnectionString);
        }

        [Test]
        public void PruebaRegistro()
        {
            deportista.Identificacion = "1063600273";
            deportista.TipoIdentificacion = "cedula de cidadania";
            deportista.Nombre = "danilo";
            deportista.Apellidó = "donado";
            deportista.Fecha_Nacimiento = DateTime.Now;
            deportista.Telefono = "3166047782";
            deportista.Sexo = "M";
            deportista.Correo = "DJOSEDONADO@UNICESAR.EDU.CO";
            deportista.Peso = 63.2;
            deportista.Altura = 175.2;
            deportista.Deporte = "FUTBALL";
            deportista.TermogenesisActividadFisica = "LEVE";
            deportista.FechaEgreso = DateTime.Now;

            var respuestaBD = service.Guardar(deportista);
            var expected = "Paciente Registrado";
            Assert.AreEqual(expected, respuestaBD);
            Assert.Pass();
        }
    }
}