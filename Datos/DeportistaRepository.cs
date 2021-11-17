using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class DeportistaRepository
    {
        SqlConnection connection;

        public DeportistaRepository(ConnectionDB connectionDB)
        {
            connection = connectionDB.connectionDB;
        }


        public void Guardar(Deportista deportista)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "";
                var fila = command.ExecuteNonQuery();
            }
        }

        public List<Deportista> Consultar()
        {
            List<Deportista> deportistas = new List<Deportista>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Alimento";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Deportista deportista = new Deportista();
                    deportista.Identificacion = dataReader.GetString(0);
                    deportista.TipoIdentificacion = dataReader.GetString(1);
                    deportista.Nombre = dataReader.GetString(2);
                    deportista.Apellidó = dataReader.GetString(3);
                    deportista.Edad = dataReader.GetInt32(4);
                    deportista.Sexo = dataReader.GetString(5);
                    deportista.Telefono = dataReader.GetString(6);
                    deportista.Peso = dataReader.GetDouble(7);
                    deportista.Altura = dataReader.GetDouble(8);
                    deportistas.Add(deportista);
                }
                dataReader.Close();
            }
            return deportistas;
        }

        public Deportista BuscarPorIdentificacion(string identificacion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Deportista where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Deportista deportista = new Deportista();
                        deportista.Identificacion = dataReader.GetString(0);
                        deportista.TipoIdentificacion = dataReader.GetString(1);
                        deportista.Nombre = dataReader.GetString(2);
                        deportista.Apellidó = dataReader.GetString(3);
                        deportista.Edad = dataReader.GetInt32(4);
                        deportista.Sexo = dataReader.GetString(5);
                        deportista.Telefono = dataReader.GetString(6);
                        deportista.Peso = dataReader.GetDouble(7);
                        deportista.Altura = dataReader.GetDouble(8);
                        return deportista;
                    }
                }
                dataReader.Close();
            }
            return null;
        }


    }
}
