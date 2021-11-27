using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class PlantillaRepository
    {
        private readonly SqlConnection connection;

        public PlantillaRepository(ConnectionDB connectionDB)
        {
            connection = connectionDB.connectionDB;
        }

        public void Guardar(Plantilla plantilla)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Plantilla(nombrePlantilla,porcion,categoria,idDieta,idAlimento)
                                                   values(@nombrePlantilla,@porcion,@categoria,@idDieta,@idAlimento)";
                command.Parameters.Add(new SqlParameter("@idDieta", plantilla.idDieta));
                command.Parameters.Add(new SqlParameter("@idAlimento", plantilla.idAlimento));
                command.Parameters.Add(new SqlParameter("@nombre", plantilla.NombrePlantilla));
                command.Parameters.Add(new SqlParameter("@porcion", plantilla.Porcion));
                command.Parameters.Add(new SqlParameter("@categoria", plantilla.Categoria));
                var file = command.ExecuteNonQuery();
            }

        }

        public List<Plantilla> Consultar()
        {
            List<Plantilla> plantillas = new List<Plantilla>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select *from Plantilla";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Plantilla plantilla = new Plantilla();
                    plantilla.NombrePlantilla = Reader.GetString(0);
                    plantilla.Ingrediente = Reader.GetString(1);
                    plantilla.Porcion = Reader.GetInt32(2);
                    plantilla.idAlimento = Reader.GetString(3);
                    plantilla.idDieta = Reader.GetString(4);
                }

            }
            return plantillas;
        }

        public Plantilla BuscarPorNombre(string nombre)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Alimento where nombre=@nombre";
                command.Parameters.Add(new SqlParameter("nombre", nombre));
                var Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while(Reader.Read()){
                        Plantilla plantilla = new Plantilla();
                        plantilla.NombrePlantilla = Reader.GetString(0);
                        plantilla.Ingrediente = Reader.GetString(1);
                        plantilla.Porcion = Reader.GetInt32(2);
                        plantilla.idAlimento = Reader.GetString(3);
                        plantilla.idDieta = Reader.GetString(4);
                        return plantilla;
                    }
                }
                Reader.Close();
            }
            return null;
        }

        public List<Plantilla> FiltarPorNombre(string nombre)
        {
            return Consultar().Where(p => p.NombrePlantilla.ToString().Contains(nombre)).ToList();
        }

    }
}
