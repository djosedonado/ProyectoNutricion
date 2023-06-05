using Entidad;
using Entidad.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class personaRepository
    {
        public ConnectionDB ConnectionDB = new ConnectionDB();

        public void SavePerson(Persona persona)
        {
            using (var commands = ConnectionDB.connectionDB.CreateCommand()) {
                commands.CommandText = @"INSERT INTO Persona(id,tipoIdentificacion,nombre,apellido,sexo,fecha_Nacimiento,telefono,email,Password,role) 
                                                    VALUES(@id,@tipoIdentificacion,@nombre,@apellido,@sexo,@fecha_Nacimiento,@telefono,@email,@Password,@role)";
                commands.Parameters.Add(new SqlParameter("@id",persona.Identificacion));
                commands.Parameters.Add(new SqlParameter("@tipoIdentificacion",persona.TipoIdentificacion));
                commands.Parameters.Add(new SqlParameter("@nombre", persona.Nombre));
                commands.Parameters.Add(new SqlParameter("@apellido", persona.Apellidó));
                commands.Parameters.Add(new SqlParameter("@sexo",persona.Sexo));
                commands.Parameters.Add(new SqlParameter("@fecha_Nacimiento",persona.Fecha_Nacimiento));
                commands.Parameters.Add(new SqlParameter("@telefono",persona.Telefono));
                commands.Parameters.Add(new SqlParameter("@email",persona.Correo));
                commands.Parameters.Add(new SqlParameter("@Password",persona.password));
                commands.Parameters.Add(new SqlParameter("@role", persona.role));
                var fila = commands.ExecuteNonQuery();
            }
        }

        public bool Login(string email,string password)
        {
            using (var commands = ConnectionDB.connectionDB.CreateCommand()) 
            {
                commands.CommandText = @"SELECT * FROM Persona WHERE email=@email AND Password=@Password";
                commands.Parameters.Add(new System.Data.SqlClient.SqlParameter("@email",email));
                commands.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Password", password));
                commands.CommandType = CommandType.Text;
                SqlDataReader reader = commands.ExecuteReader();
                Persona persona = new Persona();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.Id = reader.GetString(0);
                        UserLoginCache.FirstName = reader.GetString(2);
                        UserLoginCache.LastName = reader.GetString(3);
                        UserLoginCache.Sexo = reader.GetString(4);
                        UserLoginCache.Fecha_Nacimineto = reader.GetDateTime(5);
                        UserLoginCache.Email = reader.GetString(7);
                        UserLoginCache.Rol = reader.GetInt32(9);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
