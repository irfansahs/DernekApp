using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AidatRepository : IAidatRepository<Aidat>
    {
        public DataTable ListAll()
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM aidat";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public void Update(Aidat aidat)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {

                string insertQuery = "UPDATE aidat SET aidat = @aylar WHERE aylar = @aylar";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@aylar", aidat.Aylar);
                    insertCommand.Parameters.AddWithValue("@aidat", aidat.aidat);

                    insertCommand.ExecuteNonQuery();
                }

                ListAll();
            }

        }
    }
}
