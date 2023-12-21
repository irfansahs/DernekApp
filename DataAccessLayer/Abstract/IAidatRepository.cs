using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAidatRepository<Aidat>
    {
        DataTable ListAll();
        void Update(Aidat aidat);

    }
}
