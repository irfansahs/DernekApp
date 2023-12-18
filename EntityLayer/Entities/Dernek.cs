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
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Adres { get; set; }
    }
}
