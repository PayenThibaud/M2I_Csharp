using Microsoft.EntityFrameworkCore;
using Playtypuces.Models;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Playtypuces.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Playtypuce> Playtypuces { get; set; }

        public ApplicationDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Playtypuce; Database=Playtypuces;");
        }

    }
}
