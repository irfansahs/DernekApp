using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDernekRepository<Dernek>
    {
        void Insert(Dernek entity);
        DataTable ListAll();
        DataTable Borclular();
        int BorcOde(Dernek entity);
        Dernek GetById(int id);
        int Update(Dernek entity);
        void DeleteById(int id);
        int DeleteAll();
    }
}
