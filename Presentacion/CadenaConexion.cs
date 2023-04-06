using System.Configuration;

namespace Presentacion
{
    public static class CadenaConexion
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
    }
}
