using Microsoft.EntityFrameworkCore;
using Projektarbete.Domain.Models;

namespace Projektarbete.Data
{
    class ProjektarbeteContext : DbContext
    {
        public DbSet<Target> Target { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Kraken;Trusted_Connection=True");
        }
    }
}
