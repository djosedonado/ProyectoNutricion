﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;
using Datos;

namespace Logica
{
    public class serviceDeportista
    {
        private readonly deportistaRepository deportistaRepository;
        private readonly ConnectionDB connection;
        public serviceDeportista(string SQLServerExpress)
        {
            connection = new ConnectionDB(SQLServerExpress);
            deportistaRepository = new deportistaRepository(connection);
        }

        public ConsultarPersonaRespuesta ConsultarTodos()
        {
            ConsultarPersonaRespuesta respuesta = new ConsultarPersonaRespuesta();
            try
            {
                connection.open();
                respuesta.Deportistas = deportistaRepository.consultarTodo();
                connection.close();
                respuesta.Error = false;
                respuesta.Mensaje=(respuesta.Deportistas.Count>0)? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { connection.close(); }
        }
    }

    public class ConsultarPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Deportista> Deportistas { get; set; }
    }
}
