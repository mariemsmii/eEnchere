using eEnchere.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Room>().HasKey(am => new
            {
                am.IdClient,
                am.IdRoom
            });

            modelBuilder.Entity<Client_Room>().HasOne(m => m.Client).WithMany(am => am.Clients_Rooms).HasForeignKey(m => m.IdClient);
            modelBuilder.Entity<Client_Room>().HasOne(m => m.Room).WithMany(am => am.Clients_Rooms).HasForeignKey(m => m.IdRoom);
            base.OnModelCreating(modelBuilder);
        }

        internal Task GetAllAsync(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client_Room> Client_Rooms { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}


