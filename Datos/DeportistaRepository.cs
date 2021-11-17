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
                command.CommandText = @"Insert into Deportista (Identificacion, TipoIdentificacion, Nombre, Apellido, Sexo, Edad, Telefono, Deporte, Peso, Altura) 
                                                values ( @Identificacion, @TipoIdentificacion, @Nombre, @Apellido, @Sexo, @Edad, @Telefono, @Deporte, @Peso, @Altura)"; ;
                command.Parameters.Add(new SqlParameter("@Identificacion", deportista.Identificacion));
                command.Parameters.Add(new SqlParameter("@TipoIdentificacion", deportista.TipoIdentificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", deportista.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", deportista.Apellidó));
                command.Parameters.Add(new SqlParameter("@Sexo", deportista.Sexo));
                command.Parameters.Add(new SqlParameter("@Edad", deportista.Edad));
                command.Parameters.Add(new SqlParameter("Telefono", deportista.Telefono));
                command.Parameters.Add(new SqlParameter("@Deporte", deportista.Deporte));
                command.Parameters.Add(new SqlParameter("@Peso", deportista.Peso));
                command.Parameters.Add(new SqlParameter("@Altura", deportista.Altura));
                var fila = command.ExecuteNonQuery();
            }
        }

        public List<Deportista> Consultar()
        {
            List<Deportista> deportistas = new List<Deportista>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Deportista";
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
                    deportista.Deporte = dataReader.GetString(7);
                    deportista.Peso = dataReader.GetDouble(8);
                    deportista.Altura = dataReader.GetDouble(9);
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
                        deportista.Deporte = dataReader.GetString(7);
                        deportista.Peso = dataReader.GetDouble(8);
                        deportista.Altura = dataReader.GetDouble(9);
                        return deportista;
                    }
                }
                dataReader.Close();
            }
            return null;
        }


    }
}
