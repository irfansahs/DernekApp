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
        AidatRepository AidatRepository = new AidatRepository();

        public DataTable ListAll()
        {

            return AidatRepository.ListAll();
        }

        public void Update(Aidat aidat)
        {
            AidatRepository.Update(aidat);
        }


    }
}
