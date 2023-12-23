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
    public class UyeRepository : IUyeRepository<Uye>
    {
        public int DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Dernek GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Uye uye)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string insertQuery = "INSERT INTO uyeTablosu (tc, isim, soyisim, dogTarih, sehir, kanGrubu, durum) " +
                     "VALUES (@tc, @isim, @soyisim, @dogTarih, @sehir, @kanGrubu, @durum)";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tc", uye.tc);
                    insertCommand.Parameters.AddWithValue("@isim", uye.isim);
                    insertCommand.Parameters.AddWithValue("@soyisim", uye.soyisim);
                    insertCommand.Parameters.Add("@dogTarih", uye.dogTarih);
                    insertCommand.Parameters.AddWithValue("@sehir", uye.sehir);
                    insertCommand.Parameters.AddWithValue("@kanGrubu", uye.kanGrubu);
                    insertCommand.Parameters.AddWithValue("@durum", uye.durum);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListAll()
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string isim, string soyisim, string kanGrubu)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM uyeTablosu WHERE 1 = 1";

                query += (!string.IsNullOrEmpty(isim)) ? " AND isim LIKE @isim" : "";
                query += (!string.IsNullOrEmpty(soyisim)) ? " AND soyisim LIKE @soyisim" : "";
                query += (!string.IsNullOrEmpty(kanGrubu)) ? " AND KanGrubu = @kanGrubu" : "";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@isim", $"%{isim}%");
                    adapter.SelectCommand.Parameters.AddWithValue("@soyisim", $"%{soyisim}%");
                    adapter.SelectCommand.Parameters.AddWithValue("@kanGrubu", kanGrubu);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public int Update(Uye uye)
        {
            throw new NotImplementedException();
        }
    }
}
