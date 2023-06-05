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
                command.Parameters.Add(new SqlParameter("@id", deportista.Identificacion));
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

        public void EditarDeportista(Deportista deportista,string id)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"UPDATE Deportista SET id=@id,peso=@peso,altura=@altura,deporte=@deporte,pesoActual=@pesoActual,fechaEgreso=@fechaEgreso,caloriasDiarias=@caloriasDiarias,metabolismoBasal=@metabolismoBasal,termogenesisActividadFisica=@termogenesisActividadFisica
                                        WHERE id=@id";
                command.Parameters.Add(new SqlParameter("@id",id));
                command.Parameters.Add(new SqlParameter("@identificacion", deportista.Identificacion));
                command.Parameters.Add(new SqlParameter("@tipoIdentificacion", deportista.TipoIdentificacion));
                command.Parameters.Add(new SqlParameter("@nombre", deportista.Nombre));
                command.Parameters.Add(new SqlParameter("@apellido", deportista.Apellidó));
                command.Parameters.Add(new SqlParameter("@sexo", deportista.Sexo));
                command.Parameters.Add(new SqlParameter("@fecha_Nacimiento", deportista.Fecha_Nacimiento));
                command.Parameters.Add(new SqlParameter("@telefono", deportista.Telefono));
                command.Parameters.Add(new SqlParameter("@correo", deportista.Correo));
                command.Parameters.Add(new SqlParameter("@peso", deportista.Peso));
                command.Parameters.Add(new SqlParameter("@altura", deportista.Altura));
                command.Parameters.Add(new SqlParameter("@deporte", deportista.Deporte));
                command.Parameters.Add(new SqlParameter("@pesoActual", deportista.PesoActual));
                command.Parameters.Add(new SqlParameter("@fechaEgreso", deportista.FechaEgreso));
                command.Parameters.Add(new SqlParameter("@caloriasDiarias", deportista.CaloriasDiarias));
                command.Parameters.Add(new SqlParameter("@metabolismoBasal", deportista.MetabolismoBasal));
                command.Parameters.Add(new SqlParameter("@termogenesisActividadFisica", deportista.TermogenesisActividadFisica));
                var fila = command.ExecuteNonQuery();
            }
        }

        public void EliminarDeportista(string identificacion)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = "delete From Deportista where id=@id;delete From Persona where id=@id;";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
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

        //consultar todos
        public List<Deportista> Consultar()
        {
            List<Deportista> deportistas = new List<Deportista>();
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"SELECT Persona.id,Persona.tipoIdentificacion,Persona.nombre,Persona.apellido,Persona.sexo,Persona.fecha_Nacimiento,Persona.telefono,Persona.email
                                        ,Deportista.peso,Deportista.altura,Deportista.deporte,Deportista.pesoActual,Deportista.fechaEgreso,Deportista.caloriasDiarias,Deportista.metabolismoBasal
                                        ,Deportista.termogenesisActividadFisica FROM Persona FULL OUTER JOIN Deportista ON Persona.id = Deportista.id WHERE role=0";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Deportista deportista = new Deportista();
                    deportista.Identificacion = dataReader.GetString(0);
                    deportista.Nombre = dataReader.GetString(1);
                    deportista.Apellidó = dataReader.GetString(2);
                    deportista.Sexo = dataReader.GetString(3);
                    deportista.FechaEgreso = dataReader.GetDateTime(4);
                    deportista.Telefono = dataReader.GetString(5);
                    deportista.Correo = dataReader.GetString(6);
                    deportista.Peso = dataReader.GetDouble(7);
                    deportista.Altura = dataReader.GetDouble(8);
                    deportista.Deporte = dataReader.GetString(9);
                    deportista.FechaEgreso = dataReader.GetDateTime(10);
                    deportista.CaloriasDiarias = dataReader.GetDouble(11);
                    deportista.MetabolismoBasal = dataReader.GetDouble(12);
                    deportista.TermogenesisActividadFisica = dataReader.GetString(13);
                    deportistas.Add(deportista);
                }
                dataReader.Close();
            }
            return deportistas;
        }


        public List<Deportista> consultarPorIdentificacion(string identificacion)
        {
            List<Deportista> deportistas = new List<Deportista>();

            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = "select * from Deportista where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
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
            deportista.TipoIdentificacion = (string)Reader["tipoIdentificacion"];
            deportista.Nombre = (string)Reader["nombre"];
            deportista.Apellidó = (string)Reader["apellido"];
            deportista.Sexo = (string)Reader["sexo"];
            deportista.Fecha_Nacimiento = (DateTime)Reader["fecha_Nacimiento"];
            deportista.Telefono = (string)Reader["telefono"];
            deportista.Correo = (string)Reader["correo"];
            deportista.Peso = (double)Reader["peso"];
            deportista.Altura = (double)Reader["altura"];
            deportista.Deporte = (string)Reader["deporte"];
            deportista.PesoActual = (double)Reader["pesoActual"];
            deportista.FechaEgreso = (DateTime)Reader["fechaEgreso"];
            deportista.CaloriasDiarias = (double)Reader["caloriasDiarias"];
            deportista.MetabolismoBasal = (double)Reader["metabolismoBasal"];
            deportista.TermogenesisActividadFisica = (string)Reader["termogenesisActividadFisica"];
            return deportista;
        }


        public Deportista BuscarPorIdentificacion(string identificacion)
        {
            using (var command = connection.connectionDB.CreateCommand())
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
                        deportista.TipoIdentificacion = Reader.GetString(1);
                        deportista.Nombre = Reader.GetString(2);
                        deportista.Apellidó = Reader.GetString(3);
                        deportista.Sexo = Reader.GetString(4);
                        deportista.Fecha_Nacimiento = Reader.GetDateTime(5);
                        deportista.Telefono = Reader.GetString(6);
                        deportista.Correo = Reader.GetString(7);
                        deportista.Peso = Reader.GetDouble(8);
                        deportista.Altura = Reader.GetDouble(9);
                        deportista.Deporte = Reader.GetString(10);
                        deportista.PesoActual = Reader.GetDouble(11);
                        deportista.FechaEgreso = Reader.GetDateTime(12);
                        deportista.CaloriasDiarias = Reader.GetDouble(13);
                        deportista.MetabolismoBasal = Reader.GetDouble(14);
                        deportista.TermogenesisActividadFisica = Reader.GetString(15);
                        return deportista;
                    }
                }
                Reader.Close();
            }
            return null;
        }

        public List<Deportista> FiltrarPorNombre(string nombre)
        {
            return (from p in Consultar()
                    where p.Nombre.ToLower().Contains(nombre.ToLower())
                    select p).ToList();
        }


        public void Modificar(Deportista deportista)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"update Deportista set pesoActual=@pesoActual where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@pesoActual", deportista.PesoActual));
                var file = command.ExecuteNonQuery();
            }
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
