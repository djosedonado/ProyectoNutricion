﻿using System;
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
        SqlConnection connection;

        public AlimentoRepository(ConnectionDB connectionDB)
        {
            connection = connectionDB.connectionDB;
        }

        public void Guardar(Alimento alimento)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"Insert into Alimento (id,nombre,caloria,carbohidrato,proteinas,liquidos) 
                                                values ( @id,@nombre,@caloria,@carbohidrato,@proteinas,@liquidos)";
                command.Parameters.Add(new SqlParameter("@id", alimento.IdAlimentos));
                command.Parameters.Add(new SqlParameter("@nombre", alimento.NombreAlimento));
                command.Parameters.Add(new SqlParameter("@caloria", alimento.Calorias));
                command.Parameters.Add(new SqlParameter("@carbohidrato", alimento.Carbohidratos));
                command.Parameters.Add(new SqlParameter("@proteinas", alimento.Proteinas));
                command.Parameters.Add(new SqlParameter("@liquidos", alimento.Liquidos));
                var fila = command.ExecuteNonQuery();
            }
        }

        public List<Alimento> Consultar()
        {
            List<Alimento> alimentos = new List<Alimento>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select *from Alimento";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Alimento alimento = new Alimento();
                    alimento.IdAlimentos = dataReader.GetString(0);
                    alimento.NombreAlimento = dataReader.GetString(1);
                    alimento.Calorias = dataReader.GetDouble(2);
                    alimento.Carbohidratos = dataReader.GetDouble(3);
                    alimento.Proteinas = dataReader.GetDouble(4);
                    alimento.Liquidos = dataReader.GetDouble(5);
                    alimentos.Add(alimento);
                }
                dataReader.Close();
            }
            return alimentos;
        }

        public Alimento BuscarIdAlimento(string idAlimento)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Alimento where id=@id";
                command.Parameters.Add(new SqlParameter("@id", idAlimento));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Alimento alimento = new Alimento();
                        alimento.IdAlimentos = reader.GetString(0);
                        alimento.NombreAlimento = reader.GetString(1);
                        alimento.Calorias = reader.GetDouble(2);
                        alimento.Carbohidratos = reader.GetDouble(3);
                        alimento.Proteinas = reader.GetDouble(4);
                        alimento.Liquidos = reader.GetDouble(5);
                        return alimento;
                    }
                }
                reader.Close();
            }
            return null;
        }


    }
}
