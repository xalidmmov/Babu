using Microsoft.EntityFrameworkCore;
using TestApi.Entities;

namespace TestApi.DAL
{
    public class BabuDbContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<BannedWord> BannedWords { get; set; }
        public BabuDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BabuDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
