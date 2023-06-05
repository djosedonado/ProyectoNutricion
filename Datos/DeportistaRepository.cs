using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;
using System.Data.Common;

namespace Datos
{
    public class deportistaRepository
    {
        public ConnectionDB connection = new ConnectionDB();

        //guardar
        public void Guardar(Deportista deportista)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"insert into Deportista(id,peso,altura,deporte,pesoActual,fechaEgreso,caloriasDiarias,metabolismoBasal,termogenesisActividadFisica)
                                                        values(@id,@peso,@altura,@deporte,@pesoActual,@fechaEgreso,@caloriasDiarias,@metabolismoBasal,@termogenesisActividadFisica)";
                command.Parameters.Add(new SqlParameter("@id", deportista.id));
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

        public void EliminarDieta(string idD)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"DELETE Dieta WHERE idDeportista=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", idD));
                var file = command.ExecuteNonQuery();
            }
        }
        public List<Deportista> Consultar()
        {
            List<Deportista> deportistas = new List<Deportista>();
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"SELECT Persona.id,Persona.tipoIdentificacion,Persona.nombre,Persona.apellido,Persona.sexo,Persona.fecha_Nacimiento,Persona.telefono,Persona.email,Deportista.peso,Deportista.altura,Deportista.deporte,Deportista.pesoActual,Deportista.fechaEgreso,Deportista.caloriasDiarias,Deportista.metabolismoBasal,Deportista.termogenesisActividadFisica FROM Persona FULL OUTER JOIN Deportista ON Persona.id = Deportista.id WHERE role=0";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Deportista deportista = new Deportista();
                    deportista.id = dataReader.GetString(0);
                    deportista.TipoId = dataReader.GetString(1);
                    deportista.Nombre = dataReader.GetString(2);
                    deportista.Apellidó = dataReader.GetString(3);
                    deportista.Sexo = dataReader.GetString(4);
                    deportista.Telefono = dataReader.GetString(6);
                    deportista.Correo = dataReader.GetString(7);
                    deportista.Peso = dataReader.GetDouble(8);
                    deportista.Altura = dataReader.GetDouble(9);
                    deportista.Deporte = dataReader.GetString(10);
                    deportista.FechaEgreso = dataReader.GetDateTime(12);
                    deportista.CaloriasDiarias = dataReader.GetDouble(13);
                    deportista.MetabolismoBasal = dataReader.GetDouble(14);
                    deportista.TermogenesisActividadFisica = dataReader.GetString(15);
                    deportistas.Add(deportista);
                }
                dataReader.Close();
            }
            return deportistas;
        }

        //consultar todos SELECT Persona.id,Persona.tipoIdentificacion,Persona.nombre,Persona.apellido,Persona.sexo,Persona.fecha_Nacimiento,Persona.telefono,Persona.email,Deportista.peso,Deportista.altura,Deportista.deporte,Deportista.pesoActual,Deportista.fechaEgreso,Deportista.caloriasDiarias,Deportista.metabolismoBasal,Deportista.termogenesisActividadFisica FROM Persona FULL OUTER JOIN Deportista ON Persona.id = Deportista.id WHERE role=0

        
        public List<Deportista> FiltrarPorNombre(string nombre)
        {
            return (from p in Consultar()
                    where p.Nombre.ToLower().Contains(nombre.ToLower())
                    select p).ToList();
        }
        
        public void GuardarRecomendaciones(Dieta dieta)
        {
            using (var commnad = connection.connectionDB.CreateCommand())
            {
                commnad.CommandText = @"insert into Dieta(diasAplicada,recomendacionAlimentaria,recomendacionNutriccional,idDeportista,idPlantilla)
                                                    values(@diasAplicada,@recomendacionAlimentaria,@recomendacionNutriccional,@idDeportista,@idPlantilla)";
                commnad.Parameters.Add(new SqlParameter("@diasAplicada",dieta.DiasAplicados));
                commnad.Parameters.Add(new SqlParameter("@recomendacionAlimentaria", dieta.RecomendacionAlimentaria));
                commnad.Parameters.Add(new SqlParameter("@recomendacionNutriccional", dieta.RecomendacionNutriccional));
                commnad.Parameters.Add(new SqlParameter("@idDeportista", dieta.identificacion));
                commnad.Parameters.Add(new SqlParameter("@idPlantilla", dieta.plantillas));
                var filas = commnad.ExecuteNonQuery();
            }
        }

    }


}
