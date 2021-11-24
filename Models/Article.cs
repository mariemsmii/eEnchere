using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Models
{
    public class Article
    {[Key]
        public int IdArticle { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        public string Photo { get; set; }
        public string Etat { get; set; }
        public string Origine { get; set; }
    
    }
}
