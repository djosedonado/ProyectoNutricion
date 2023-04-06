using System.Configuration;


namespace PruebasDeSofoware
{
    public static class Conexion
    {
        public static string connectionStrings = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
    }
}
