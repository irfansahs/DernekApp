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

       

        public Dernek GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Uye uye)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string insertQuery = "INSERT INTO uyeTablosu (tc, isim, soyisim,email, dogTarih, sehir, kanGrubu, durum) " +
                     "VALUES (@tc, @isim, @soyisim, @email, @dogTarih, @sehir, @kanGrubu, @durum)";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    try
                    {
                        insertCommand.Parameters.AddWithValue("@tc", uye.tc);
                        insertCommand.Parameters.AddWithValue("@isim", uye.isim);
                        insertCommand.Parameters.AddWithValue("@soyisim", uye.soyisim);
                        insertCommand.Parameters.AddWithValue("@email", uye.email);
                        insertCommand.Parameters.Add("@dogTarih", uye.dogTarih);
                        insertCommand.Parameters.AddWithValue("@sehir", uye.sehir);
                        insertCommand.Parameters.AddWithValue("@kanGrubu", uye.kanGrubu);
                        insertCommand.Parameters.AddWithValue("@durum", uye.durum);
                        insertCommand.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
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
        public DataTable SearchByBloodTypeAndStatus(string kanGrubu, bool durum)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM uyeTablosu WHERE kanGrubu = @kanGrubu AND Durum = @durum";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@kanGrubu", kanGrubu);
                    adapter.SelectCommand.Parameters.AddWithValue("@durum", durum);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable SearchByCityAndStatus(string sehir, bool durum)
        {
            using (OleDbConnection connection = Context.GetConnection())
            {
                string query = "SELECT * FROM uyeTablosu WHERE sehir LIKE @sehir AND Durum = @durum";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@sehir", "%" + sehir + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@durum", durum);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable SearchByDateDiff(DateTime firstDate, DateTime secondDate)
        {
            DataTable result = new DataTable();

            
                using (OleDbConnection connection = Context.GetConnection())
                {
                    string query = @"
                SELECT uyeTablosu.*, dernekTablosu.*
                FROM uyeTablosu
                INNER JOIN dernekTablosu ON uyeTablosu.tc = dernekTablosu.tc
                WHERE dernekTablosu.odemeTarihi BETWEEN @firstDate AND @secondDate";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@firstDate", firstDate);
                        adapter.SelectCommand.Parameters.AddWithValue("@secondDate", secondDate);

                        adapter.Fill(result);
                    }
                }
            
           

            return result;
        }


        public DataTable Search(string isim, string soyisim, string kanGrubu)
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

        public int Update(Uye uye)
        {
            throw new NotImplementedException();
        }
    }
}
