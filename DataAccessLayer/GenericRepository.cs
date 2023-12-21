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
<<<<<<< HEAD
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\dernekproje\Dernek.accdb";

            connection.ConnectionString = connectionString;

            connection.Open();
            string insertQuery = "INSERT INTO dernektablosu (alan1, alan2, alan3) VALUES ('a','b','c')";
=======
            OleDbConnection connection= new OleDbConnection();
            
            string insertQuery = "INSERT INTO uyeTablosu (alan1, alan2, alan3) VALUES ('a','b','c')";
            
>>>>>>> 3638d8b66919facff4a02d47231d43428095c32b
            OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable ListAll()
        {

<<<<<<< HEAD
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\dernekproje\Dernek.accdb";
=======
            OleDbConnection connection = new OleDbConnection();
>>>>>>> 3638d8b66919facff4a02d47231d43428095c32b

            string query = "SELECT * FROM uyeTablosu";

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

