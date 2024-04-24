using Microsoft.EntityFrameworkCore;
using mvc_project.Models.Dbo;

namespace mvc_project.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }
    }
}
