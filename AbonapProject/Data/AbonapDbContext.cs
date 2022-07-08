using AbonapProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AbonapProject.Data
{
    public class AbonapDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public AbonapDbContext(DbContextOptions<AbonapDbContext> options) : base(options)
        {
        }
    }
}
