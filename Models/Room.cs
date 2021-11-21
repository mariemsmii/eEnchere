using eEnchere.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Models
{
    public class Room
    {
        [Key]
        public int IdRoom { get; set; }
        public string NomRoom { get; set; }
        public DateTime DateDebut { get; set; }
        public int NombreParticipants { get; set; }
        public int Timeur { get; set; }
        public float MontantEnchére { get; set; }
        public float DernierMise { get; set; }
        public float FraisRoom { get; set; }
        public float MontantLancement { get; set; }
        public float MontantInitial { get; set; }
        public float MontantEnchéreFinal { get; set; }
        //relationships

        public int IdArticle { get; set; }
        [ForeignKey("IdArticle")]
        public Article Article { get; set; }

        public List<Client_Room> Clients_Rooms { get; set; }
        //public int IdCommande { get; set; }
        //[ForeignKey("IdCommande")]
       // public Commande Commande { get; set; }

    }
}