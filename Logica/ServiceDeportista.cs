using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using Entidad;

namespace Logica
{
    public class ServiceDeportista
    {
        private readonly ConnectionDB connection;
        private readonly DeportistaRepository deportistaRepository;
        public ServiceDeportista(string connectionDB)
        {
            connection = new ConnectionDB(connectionDB);
            deportistaRepository = new DeportistaRepository(connection);
        }

        public string Guardar(Deportista deportista)
        {
            try
            {
                connection.open();
                if (deportistaRepository.BuscarPorIdentificacion(deportista.Identificacion)==null)
                {
                    deportistaRepository.Guardar(deportista);
                    return $"Se guardaron los datos sactifactoriamente";
                }
                else
                {
                    return $"La identificacion que desea registrar ya esta guardada";
                }

            }catch(Exception e)
            {
                return $"Error de aplicacion: {e.Message}";
            }
            finally 
            { 
                connection.close(); 
            }
        }

        public ConsultarDeportistaRespuesta ConsultarTodo()
        {
            ConsultarDeportistaRespuesta respuesta = new ConsultarDeportistaRespuesta();
            try
            {
                connection.open();
                respuesta.Deportistas = deportistaRepository.Consultar();
                connection.close();
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
            finally
            {
                connection.close();
            }
        }


    }

    public class ConsultarDeportistaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje  { get; set; }
        public IList<Deportista> Deportistas { get; set; }
    }
}
