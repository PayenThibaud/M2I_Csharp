using ContactApiDTO.Models;
using ContactApiDTOAsync.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactApiDTO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
#nullable disable
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
#nullable enable
    }
}
