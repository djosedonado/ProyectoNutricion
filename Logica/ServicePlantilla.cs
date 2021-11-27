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


            }catch(Exception e)
            {

            }
            finally { connection.close(); }
        }

    }

    public class ConsultarRespuesta
    {
        public List<Plantilla> Plantillas { get; set; }
    }

}
