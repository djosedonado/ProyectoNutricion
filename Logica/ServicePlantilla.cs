using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data.SqlClient;

namespace Logica
{
    public class ServicePlantilla
    {
        private readonly PlantillaRepository repository;
        private readonly ConnectionDB connection;

        public ServicePlantilla(string connectionDB)
        {
            connection = new ConnectionDB(connectionDB);
            repository = new PlantillaRepository(connection);
        }


        public string Guardar(Plantilla plantilla)
        {
            try
            {
                connection.open();
                repository.Guardar(plantilla);
                return $"Se guardaron los datos de satisfactoriamente";

            }
            catch(Exception e)
            {
                return $"Error al guardar los datos {e.Message}";
            }
            finally { connection.close(); }
        }

        public ConsultarRespuestaPlantilla Consultar()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            try
            {
                connection.open();
                respuesta.Plantillas = repository.Consultar();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Plantillas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch(Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
        }

    }

    public class ConsultarRespuestaPlantilla
    {
        public List<Plantilla> Plantillas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
    }

}
