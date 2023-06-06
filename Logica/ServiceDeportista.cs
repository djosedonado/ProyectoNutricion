using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Logica
{
    public class serviceDeportista
    {
        private readonly deportistaRepository deportistaRepository;
        public serviceDeportista()
        {
            deportistaRepository = new deportistaRepository();
        }

        public string Guardar(Deportista deportista)
        {
            try
            {
                string mensajeEmail = string.Empty;
                CorreoService correo = new CorreoService();
                deportista.CalculoGastoEnergeticoDiario();
                deportistaRepository.connection.Open();
                deportistaRepository.Guardar(deportista);
                return "Paciente Registrado";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { deportistaRepository.connection.Close(); }
        }

        public ConsultarClienteRespuesta ConsultarTodos()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            try
            {
                deportistaRepository.connection.Open() ;
                respuesta.Deportistas = deportistaRepository.Consultar();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Deportistas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { deportistaRepository.connection.Close(); }
        }
        //Metodo guardar Dieta
        public string GuardarDieta(Dieta dieta)
        {
            try
            {
                deportistaRepository.connection.Open();
                deportistaRepository.GuardarRecomendaciones(dieta);
                return "DATOS GUARDADOS";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { deportistaRepository.connection.Close(); }
        }

        //Metodo Buscar por id
        public ConsultarClienteRespuesta BuscarPorId(string id)
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            try
            {
                deportistaRepository.connection.connectionDB.Open();
                respuesta.Deportistas = deportistaRepository.FiltrarPorId(id);
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Deportistas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception)
            {
                return null;
            }
            finally { deportistaRepository.connection.connectionDB.Close(); }
        }
        //Metodo de Busqueda por Nombre
        public ConsultarClienteRespuesta BuscarPorNombre(string nombre)
        {
            ConsultarClienteRespuesta respose = new ConsultarClienteRespuesta();
            try
            {
                deportistaRepository.connection.connectionDB.Open();
                respose.Deportistas = deportistaRepository.FiltrarPorNombre(nombre);
                respose.Mensaje = (respose.Deportistas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                respose.Error = false;
                return respose;
            }
            catch (Exception)
            {

                throw;
            }
            finally { deportistaRepository.connection.connectionDB.Close(); }
        }

    }


    public class ConsultarDeportistaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Deportista> Deportistas { get; set; }
    }

    public class ConsultarDeportista
    {
        public List<Deportista> Deportistas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultarDeportista(List<Deportista> deportistas)
        {
            Deportistas = deportistas;
            Error = false;
        }

        public ConsultarDeportista(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }

    public class ConsultarClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Deportista> Deportistas { get; set; }
    }

}
