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
            DernekRepository repository = new DernekRepository();
            return repository.ListAll();
        }


        public void Insert(Dernek entity)
        {
            DernekRepository repository = new DernekRepository();
            repository.Insert(entity);
        }

        public void DeleteById(int id)
        {
            dernekRepository.DeleteById(id);
        }



    }


}
