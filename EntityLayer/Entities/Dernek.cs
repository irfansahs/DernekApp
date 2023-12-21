using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Dernek
    {
        [Key]
        public int Id { get; set; }
        public string tc { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string sehir { get; set; }
        public DateOnly dogTarih { get; set; }
        public string kanGrubu { get; set; }
        public bool durum { get; set; }
    }
}
