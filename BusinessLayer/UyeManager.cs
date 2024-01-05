using DataAccessLayer;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UyeManager
    {
        UyeRepository uyeRepository = new UyeRepository();


        public DataTable SearchByBloodTypeAndStatus(string kanGrubu, bool durum)
        {
            return uyeRepository.SearchByBloodTypeAndStatus(kanGrubu, durum);
        }

        public DataTable SearchByCityAndStatus(string sehir, bool durum)
        {
            return uyeRepository.SearchByCityAndStatus(sehir, durum);
        }
        public DataTable ListAll()
        {
            return uyeRepository.ListAll();
        }

        public void Insert(Uye uye)
        {
            UyeRepository uyeRepository = new UyeRepository();
            uyeRepository.Insert(uye);
        }
        public void DeleteById(int id)
        {
            uyeRepository.DeleteById(id);
        }

    }
}
