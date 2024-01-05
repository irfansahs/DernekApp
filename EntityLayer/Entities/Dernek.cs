using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
        public string AidatTarihi { get; set; }
        public string aidat { get; set; }
        public string borc { get; set; }
        public DateOnly odemeTarihi { get; set; }
        public string email { get; set; }
        public int odenenBorc { get; set; }
    }
}
