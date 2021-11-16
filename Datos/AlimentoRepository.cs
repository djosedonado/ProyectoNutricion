using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AlimentoRepository
    {
        private readonly SqlConnection connection;

        public AlimentoRepository(ConnectionDB connectionDB)
        {
            connection = connectionDB.connectionDB;
        }


        public List<Alimento> ConsultarTodo()
        {
            List<Alimento> alimentos = new List<Alimento>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select * from Alimento";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Alimento alimento = DataReaderMapToAlimento(dataReader);
                        alimentos.Add(alimento);
                    }
                }
            }
            return alimentos;
        }

        public Alimento DataReaderMapToAlimento(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Alimento alimento = new Alimento();
            alimento.IdAlimentos = (string)dataReader["idAlimento"];
            return alimento;
        }

    }
}
