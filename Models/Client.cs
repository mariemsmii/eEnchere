using eEnchere.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrénomClient { get; set; }
        public string MailClient { get; set; }
        public string MotDePasse { get; set; }
        public double Solde { get; set; }
        public string Pseudo { get; set; }

        //Relationships
        public List<Client_Room> Clients_Rooms { get; set; }
    }
}
