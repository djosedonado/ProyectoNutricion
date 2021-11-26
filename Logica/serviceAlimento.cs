using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data.SqlClient;

namespace Logica
{
    public class serviceAlimento
    {
        private readonly ConnectionDB connection;
        private readonly AlimentoRepository alimentoRepository;

        public serviceAlimento(string connectionDB)
        {
            connection = new ConnectionDB(connectionDB);
            alimentoRepository = new AlimentoRepository(connection);
        }

        public ConsultarAlimentoRespuesta consultarTodo()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            try
            {
                connection.open();
                respuesta.Alimentos = alimentoRepository.Consultar();
                connection.close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Alimentos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

        public string Guardar(Alimento alimento)
        {
            try
            {
                connection.open();
                if (alimentoRepository.BuscarIdAlimento(alimento.IdAlimentos) == null)
                {
                    alimentoRepository.Guardar(alimento);
                    return $"Se guardaron los datos de satisfactoriamente";
                }
                else
                {
                    return $"El Ingrediente con esta id ya Existe en la Base de datos";
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { connection.close(); }

        }

        public ConsultarAlimentoRespuesta consultarPorId(string id)
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            try
            {
                connection.open();
                respuesta.Alimentos = (IList<Alimento>)alimentoRepository.BuscarIdAlimento(id);
                connection.close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Alimentos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

        public ConsultarAlimentoRespuesta FiltrarPorNombre(string nombre)
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            try
            {
                connection.open();
                respuesta.Alimentos = alimentoRepository.FiltrarConsulta(nombre);
                connection.close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Alimentos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

    public class ConsultarAlimentoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Alimento> Alimentos { get; set; }
    }


}
