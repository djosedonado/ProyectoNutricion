using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class dietaRepository
    {
        private readonly SqlConnection connection;

        public dietaRepository(ConnectionDB connectionDB)
        {
            connection = connectionDB.connectionDB;
        }

        public List<Dieta> Consultar()
        {
            List<Dieta> dietas = new List<Dieta>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select *from Dieta";

            }
            return dietas;
        }

        private Dieta MapearDieta(SqlDataReader reader)
        {
            if (!reader.HasRows) return null;
            Dieta dieta = new Dieta();
            dieta.IdDieta = (string)reader[0];

            return dieta; 
        }

    }
}
