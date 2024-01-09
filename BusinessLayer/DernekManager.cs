using DataAccessLayer;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DernekManager
    {
         DernekRepository dernekRepository = new DernekRepository();

        public DataTable ListAll()
        {
            return dernekRepository.ListAll();
        }
        public void Insert(Dernek entity)
        {
            dernekRepository.Insert(entity);
        }
        public DataTable Borclular()
        {
            return dernekRepository.ListAll();

        }
        public DataTable BorclularListele()
        {
            return dernekRepository.ListAllBorclular();


        }
        public DataTable GetEmail()
        {
            return dernekRepository.GetBorcluEmail();


        }

        public int BorcOde(Dernek entity) {
           return dernekRepository.BorcOde(entity);
        
        }

        public void DeleteById(int id)
        {
            dernekRepository.DeleteById(id);
        }

    }

}
