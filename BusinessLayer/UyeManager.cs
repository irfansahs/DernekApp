using DataAccessLayer;
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

        public DataTable Search(string isim, string soyisim, string kanGrubu)
        {
            UyeRepository uyeRepository = new UyeRepository();
            return uyeRepository.Search(isim, soyisim, kanGrubu);
        }

    }
}
