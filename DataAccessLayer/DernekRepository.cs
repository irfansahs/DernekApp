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
    public class DernekRepository : IDernekRepository<Dernek>
    {

        public int DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string insertQuery = $"DELETE FROM uyeTablosu WHERE Kimlik={id}";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public Dernek GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Dernek entity)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {


                string insertQuery = "INSERT INTO dernekTablosu (tc, email) VALUES (@tc, @email)";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tc", entity.tc);
                    insertCommand.Parameters.AddWithValue("@email", entity.email);

                    
                    insertCommand.ExecuteNonQuery();
                }

                ListAll();
            }
        }

        public DataTable ListAll()
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM dernekTablosu";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public DataTable ListAllBorclular()
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM dernekTablosu where borc>0";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public DataTable GetBorcluEmail()
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT email FROM dernekTablosu where borc>0";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public DataTable Borclular()
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM dernekTablosu WHERE borc>0";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

      
        public int BorcOde(Dernek entity)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "UPDATE dernekTablosu SET borc = borc - @OdenenBorc, odemeTarihi = @OdemeTarihi WHERE tc = @Tc";

                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@OdenenBorc", entity.odenenBorc);
                cmd.Parameters.AddWithValue("@OdemeTarihi", entity.odemeTarihi);
                cmd.Parameters.AddWithValue("@Tc", entity.tc);

                int affectedRows = cmd.ExecuteNonQuery();
                connection.Close();

                return 1;
            }
        }

        public int Update(Dernek entity)
        {
            throw new NotImplementedException();
        }
    }
}
