using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Uye
    {
        [Key]
        
        public string tc { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string sehir { get; set; }
        public string email { get; set; }  
        public DateTime dogTarih { get; set; }
        public string kanGrubu { get; set; }
        public bool durum { get; set; }
    }
}
