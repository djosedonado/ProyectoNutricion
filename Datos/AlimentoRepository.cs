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

        public void Guardar(Alimento alimento)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText= @"insert into 
                    Alimento(idAlimento,NombreAlimento,Caloria,Carbohidratos,Proteinas,Liquidos) 
                    values(@idAlimento,@NombreAlimento,@Caloria,@Carbohidratos,@Proteinas,@Liquidos)";
                command.Parameters.AddWithValue("@idAlimento", alimento.IdAlimentos);
                command.Parameters.AddWithValue("@NombreAlimento", alimento.NombreAlimento);
                command.Parameters.AddWithValue("@Caloria", alimento.Calorias);
                command.Parameters.AddWithValue("@Carbohidratos", alimento.Carbohidratos);
                command.Parameters.AddWithValue("@Proteinas", alimento.Proteinas);
                command.Parameters.AddWithValue("@Liquidos", alimento.Liquidos);
                var fila = command.ExecuteNonQuery();
            }
        }

        public List<Alimento> ConsultarTodo()
        {
            List<Alimento> alimentos = new List<Alimento>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select *from Alimento";
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
            alimento.NombreAlimento = (string)dataReader["NombreAlimento"];
            alimento.Calorias = (decimal)dataReader["Caloria"];
            alimento.Carbohidratos = (decimal)dataReader["Carbohidratos"];
            alimento.Proteinas = (decimal)dataReader["Proteinas"];
            alimento.Liquidos = (decimal)dataReader["Liquidos"];
            return alimento;
        }


        public Alimento BuscarIdAlimento(string idAlimento)
        {
            SqlDataReader dataReader;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Alimento where idAlimento=@idAlimento";
                command.Parameters.AddWithValue("@idAlimento", idAlimento);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToAlimento(dataReader);
            }
        }


    }
}
