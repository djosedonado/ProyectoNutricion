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


    }
}
