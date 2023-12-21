using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AidatManager
    {

        public DataTable ListAll()
        {
            AidatRepository AidatRepository = new AidatRepository();

            return AidatRepository.ListAll();
        }

        public void Update(Aidat aidat)
        {
            AidatRepository AidatRepository = new AidatRepository();
            AidatRepository.Update(aidat);
        }


    }
}
