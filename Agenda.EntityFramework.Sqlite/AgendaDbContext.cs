using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Agenda.EntityFramework.Sqlite
{
    internal class AgendaDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AgendaDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("Sqlite"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gateways.PersistenceEntities.Task>()
                .Property(t => t.Timestamp)
                .IsRowVersion();
        }

        public DbSet<Gateways.PersistenceEntities.Task> Tasks { get; set; }
    }
}
