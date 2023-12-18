using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T>
    {
        DataTable ListAll();
        T GetById(int id);
        void Insert(DataTable p);
        int Update(T p);
        int DeleteById(int id);
        int DeleteAll();

    }
}
