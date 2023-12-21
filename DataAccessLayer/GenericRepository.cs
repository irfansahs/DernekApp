using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        OleDbConnection connection = new OleDbConnection();

        public int DeleteAll()
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int p)
        {


            return 0;
        }


        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T p)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\dernekproje\Dernek.accdb";

            connection.ConnectionString = connectionString;

            connection.Open();
            string insertQuery = "INSERT INTO dernektablosu (alan1, alan2, alan3) VALUES ('a','b','c')";
            OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable ListAll()
        {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\dernekproje\Dernek.accdb";

            connection.ConnectionString = connectionString;

            string query = "SELECT * FROM dernektablosu";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public int Update(T p)
        {
            throw new NotImplementedException();
        }
    }
}

