using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class personServices
    {
        public personaRepository personaRepository;

        public personServices()
        {
                personaRepository = new personaRepository();
        }

        public bool LoginPerson(string email,string password)
        {
            try
            {
                personaRepository.ConnectionDB.Open();
                return personaRepository.Login(email, password);
            }
            catch (Exception)
            {

                throw;
            }finally { personaRepository.ConnectionDB.Close();}
        }

        public string RegisterPerson(Persona persona)
        {
            try
            {
                personaRepository.ConnectionDB.Open();
                personaRepository.SavePerson(persona);
                return "Usuario Registrado";
            }
            catch (Exception e)
            {
                return "Error Identificacion o Email ya existe.";
            }
            finally { personaRepository.ConnectionDB.Close();}
        }
    }
}
