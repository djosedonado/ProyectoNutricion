using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class ConnectionDB
    {
        internal SqlConnection connectionDB;

        public ConnectionDB(string connection)
        {
            connectionDB = new SqlConnection(connection);
        }

        public void open()
        {
            connectionDB.Open();
        }

        public void close()
        {
            connectionDB.Close();
        }

    }
}
