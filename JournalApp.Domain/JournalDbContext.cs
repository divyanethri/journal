using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JournalApp.Domain
{
    public class JournalDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public JournalDbContext ( DbContextOptions<JournalDbContext> options , IConfiguration configuration )
          : base(options)
        {
            _configuration = configuration;
        }

        //protected override void OnConfiguring ( DbContextOptionsBuilder options )
        //{
        //    options.UseNpgsql("Server=localhost;Database=journaldb; Username=postgres; Password=Nethri@2310." , b => b.MigrationsAssembly("JournalApp.Domain"));
        //}

        public DbSet<SleepTracker> SleepTrackers { get; set; }
    }
}