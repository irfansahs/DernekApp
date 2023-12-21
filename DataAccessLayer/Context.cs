using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context
    {

        private const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\selcu.SELCUK.000\source\repos\DernekApp\Dernek.accdb";
        public static OleDbConnection GetConnection()
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            return connection;
        }

    }
}
