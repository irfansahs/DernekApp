using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Aidat
    {
        [Key]
        public int Id { get; set; }
        public DateOnly aylar { get; set; }
        public int aidat { get; set; }
    }
}
