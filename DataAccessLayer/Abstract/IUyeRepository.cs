using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUyeRepository<Uye>
    {
        void Insert(Uye uye);
        DataTable ListAll();
        DataTable SearchByBloodTypeAndStatus(string kanGrubu,bool durum);
        DataTable SearchByCityAndStatus(string sehir, bool durum);

        Dernek GetById(int id);
        int Update(Uye uye);
        void DeleteById(int id);
        int DeleteAll();
    }
}
