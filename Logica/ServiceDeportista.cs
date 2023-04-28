using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Logica
{
    public class serviceDeportista
    {
        public deportistaRepository deportistaRepository;
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
                if (deportistaRepository.BuscarPorIdentificacion(deportista.Identificacion) == null)
                {
                    deportistaRepository.Guardar(deportista);
                    //return $"Se guardaron los datos de satisfactoriamente";
                    return "Paciente Registrado";
                }
                else
                {
                    return $"El Paciente con esta identificacion {deportista.Identificacion}  ya Existe en la Base de datos";
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { deportistaRepository.connection.Close(); }
        }

        public string Modificar(Deportista deportista, string id)
        {
            try
            {
                deportistaRepository.connection.Open();
                if (deportistaRepository.BuscarPorIdentificacion(id) != null)
                {
                    deportistaRepository.connection.Close();
                    deportistaRepository.connection.Open();
                    deportista.CalculoGastoEnergeticoDiario();
                    deportistaRepository.EditarDeportista(deportista, id);
                    return $"Se Modificó a la Persona con idnetificacion {id}";
                }
                return $"No se encontró a la persona con Identificacion {id}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                deportistaRepository.connection.Close();
            }


        }

        public string Eliminar(string id)
        {
            try
            {
                deportistaRepository.connection.Open();
                if (deportistaRepository.BuscarPorIdentificacion(id) != null)
                {
                    deportistaRepository.connection.Close();
                    deportistaRepository.connection.Open();
                    deportistaRepository.EliminarDieta(id);
                    deportistaRepository.connection.Close();
                    deportistaRepository.connection.Open();
                    deportistaRepository.EliminarDeportista(id);
                    return $"Se Eliminado a la Persona con idnetificacion {id}";
                }
                return $"No se encontró a la persona con Identificacion {id}";
            }
            catch (Exception e) 
            {

                return "Se presentó el siguiente error:" + e.Message;
            }
            finally { deportistaRepository.connection.Close() ; }
        }

        public ConsultarDeportistaRespuesta ConsultarTodos()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            Deportista deportista = new Deportista();
            try
            {
                
                deportistaRepository.connection.Open();
                respuesta.Deportistas = deportistaRepository.consultarTodo();
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

        public ConsultarDeportistaRespuesta consultarPorIdentificacion(string identificacion)
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            try
            {
                deportistaRepository.connection.Open();
                respuesta.Deportistas = deportistaRepository.consultarPorIdentificacion(identificacion);
                deportistaRepository.connection.Close();
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

        public ConsultarDeportista BuscarPorNombreService(string nombre)
        {
            try
            {
                deportistaRepository.connection.Open();
                return new ConsultarDeportista(deportistaRepository.FiltrarPorNombre(nombre));
            }
            catch(Exception e)
            {

                return new ConsultarDeportista("Se presento el siguiente Error: " + e.Message);
            }
            finally { deportistaRepository.connection.Close(); }
        }

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

}
