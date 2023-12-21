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
                string insertQuery = "INSERT INTO uyeTablosu (tc, isim, soyisim, dogTarih, sehir, kanGrubu, durum) " +
                     "VALUES (@tc, @isim, @soyisim, @dogTarih, @sehir, @kanGrubu, @durum)";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tc", entity.tc);
                    insertCommand.Parameters.AddWithValue("@isim", entity.isim);
                    insertCommand.Parameters.AddWithValue("@soyisim", entity.soyisim);
                    insertCommand.Parameters.Add("@dogTarih", "2023-12-20");
                    insertCommand.Parameters.AddWithValue("@sehir", entity.sehir);
                    insertCommand.Parameters.AddWithValue("@kanGrubu", entity.kanGrubu);
                    insertCommand.Parameters.AddWithValue("@durum", entity.durum);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListAll()
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM uyeTablosu";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public int Update(Dernek entity)
        {
            throw new NotImplementedException();
        }
    }
}
