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

                string queryGet = "SELECT Borc, odemedemeTarihi FROM dernekTablosu WHERE tc = @Tc";
                OleDbCommand cmdGet = new OleDbCommand(queryGet, connection);
                cmdGet.Parameters.AddWithValue("@Tc", entity.tc);
                OleDbDataReader reader = cmdGet.ExecuteReader();

                if (reader.Read())
                {
                    decimal mevcutBorc = reader.GetDecimal(0);
                    DateTime sonOdemeTarihi = reader.GetDateTime(1);

                    if (DateTime.Now > sonOdemeTarihi)
                    {
                        int gecikmeAyi = (DateTime.Now.Year - sonOdemeTarihi.Year) * 12 + DateTime.Now.Month - sonOdemeTarihi.Month;
                        mevcutBorc += mevcutBorc * 0.02m * gecikmeAyi;
                    }

                    decimal yeniBorc = mevcutBorc - entity.odenenBorc;
                    string queryUpdate = "UPDATE dernekTablosu SET borc = @YeniBorc, odemeTarihi = @SonOdemeTarihi WHERE tc = @Tc";
                    OleDbCommand cmdUpdate = new OleDbCommand(queryUpdate, connection);
                    cmdUpdate.Parameters.AddWithValue("@YeniBorc", yeniBorc);
                    cmdUpdate.Parameters.AddWithValue("@SonOdemeTarihi", entity.odemeTarihi);
                    cmdUpdate.Parameters.AddWithValue("@Tc", entity.tc);

                    return cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Update(Dernek entity)
        {
            throw new NotImplementedException();
        }
    }
}
