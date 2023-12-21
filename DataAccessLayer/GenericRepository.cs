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

        public void Insert(T p) { 

            OleDbConnection connection= new OleDbConnection();  
            string insertQuery = "INSERT INTO uyeTablosu (alan1, alan2, alan3) VALUES ('a','b','c')";

            OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable ListAll()
        {
            OleDbConnection connection = new OleDbConnection();


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

