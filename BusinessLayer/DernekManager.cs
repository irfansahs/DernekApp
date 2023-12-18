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

        GenericRepository<Dernek> dernek = new GenericRepository<Dernek>();

        public DataTable ListAll()
        {
            return dernek.ListAll();
        }

        public void Insert(DataTable p)
        {
            dernek.Insert(p);
        }

        public int DeleteById(int Id)
        {
            dernek.DeleteById(Id);
            
            return 0;
        }
    }

}
