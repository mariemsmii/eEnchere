using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Models
{
    public class Admin
    {
        [Key]
        public int IdAdmin { get; set; }
        public string PrénomAdmin { get; set; }
        public string NomAdmin { get; set; }
        public string Mail { get; set; }
        public string MotDePasse { get; set; }
    }
}
