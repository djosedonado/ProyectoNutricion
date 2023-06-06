using System;
using System.Data.SqlClient;

namespace Datos
{
    public class ConnectionDB
    {
        public string connectionString = "Data Source=DESKTOP-14ISCP9\\SQLEXPRESS;Initial Catalog=Nutrisoft; Integrated Security=True";
        public SqlConnection connectionDB = new SqlConnection();

        public ConnectionDB()
        {
            connectionDB.ConnectionString = connectionString;
        }

        public void Open()
        {
            try
            {
                connectionDB.Open();
                Console.WriteLine("---Connection DataBase---");
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR" + e.Message);
            }
        }

        public void Close()
        {
            connectionDB.Close();
        }

    }
}
