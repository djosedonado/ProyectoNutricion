using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class deportistaRepository
    {
        private readonly SqlConnection connection;

        public deportistaRepository(ConnectionDB connectionDB)
        {
            connection = connectionDB.connectionDB;
        }

        public void Guardar(Deportista deportista)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Deportista(identificacion,tipoIdentificacion,nombre,apellido,sexo,edad,telefono,peso,altura,deporte,pesoActual,fechaEgreso,caloriasDiarias,metabolismoBasal,termogenesisActividadFisica)
                                                        values(@identificacion,@tipoIdentificacion,@nombre,@apellido,@sexo,@edad,@telefono,@peso,@altura,@deporte,@pesoActual,@fechaEgreso,@caloriasDiarias,@metabolismoBasal,@termogenesisActividadFisica)";
                command.Parameters.Add(new SqlParameter("@identificacion", deportista.Identificacion));
                command.Parameters.Add(new SqlParameter("@tipoIdentificacion", deportista.TipoIdentificacion));
                command.Parameters.Add(new SqlParameter("@nombre", deportista.Nombre));
                command.Parameters.Add(new SqlParameter("@apellido", deportista.Apellidó));
                command.Parameters.Add(new SqlParameter("@sexo", deportista.Sexo));
                command.Parameters.Add(new SqlParameter("@edad", deportista.Sexo));
                command.Parameters.Add(new SqlParameter("@telefono", deportista.Telefono));
                command.Parameters.Add(new SqlParameter("@peso", deportista.Peso));
                command.Parameters.Add(new SqlParameter("@altura", deportista.Altura));
                command.Parameters.Add(new SqlParameter("@deporte", deportista.Deporte));
                command.Parameters.Add(new SqlParameter("@pesoActual",deportista.PesoActual));
                command.Parameters.Add(new SqlParameter("@fechaEgreso", deportista.FechaEgreso));
                command.Parameters.Add(new SqlParameter("@caloriasDiarias", deportista.CaloriasDiarias));
                command.Parameters.Add(new SqlParameter("@metabolismoBasal", deportista.MetabolismoBasal));
                command.Parameters.Add(new SqlParameter("@termogenesisActividadFisica", deportista.TermogenesisActividadFisica));
                var fila = command.ExecuteNonQuery();
            }
        }

        public List<Deportista> consultarTodo()
        {
            List<Deportista> deportistas = new List<Deportista>();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select identificacion,nombre,apellido from Deportista";
                var Reader = command.ExecuteReader();
                if (Reader.Read()){

                    Deportista deportista = MaperarDeportistas(Reader);
                    deportistas.Add(deportista);
                }
            }
                return deportistas;
        }

        public Deportista MaperarDeportistas(SqlDataReader Reader)
        {
            if (!Reader.HasRows) return null;
            Deportista deportista = new Deportista();
            deportista.Identificacion = (string)Reader["identificacion"];
            deportista.Nombre = (string)Reader["nombre"];
            deportista.Apellidó = (string)Reader["apellido"];
            return deportista;
        }

        public Deportista BuscarPorIdentificacion(string identificacion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Deportista where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                var Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Deportista deportista = new Deportista();
                        deportista.Identificacion = Reader.GetString(0);
                        deportista.Nombre = Reader.GetString(1);
                        deportista.Apellidó = Reader.GetString(2);
                        deportista.Sexo = Reader.GetString(3);
                        deportista.Edad = Reader.GetInt32(4);
                        deportista.Telefono = Reader.GetString(5);
                        deportista.Peso = Reader.GetDouble(6);
                        deportista.Altura = Reader.GetDouble(7);
                        deportista.Deporte = Reader.GetString(8);
                        deportista.PesoActual = Reader.GetDouble(9);
                        deportista.FechaEgreso = Reader.GetDateTime(10);
                        deportista.CaloriasDiarias = Reader.GetDouble(11);
                        deportista.MetabolismoBasal = Reader.GetDouble(12);
                        deportista.TermogenesisActividadFisica = Reader.GetString(13);
                        return deportista;
                    }
                }
                Reader.Close();
            }
            return null;
        }

    }


}
