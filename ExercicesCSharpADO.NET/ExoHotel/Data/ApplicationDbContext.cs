using ExoHotel.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public ApplicationDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\DDB_Ado; Initial Catalog=Hotel; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chambre>().HasKey(c => c.Id);
            modelBuilder.Entity<Hotel>().HasNoKey();
            modelBuilder.Entity<Reservation>().HasKey(c => c.Id);

        }
    }
}
