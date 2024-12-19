using Microsoft.EntityFrameworkCore;
using TestApi.Entities;

namespace TestApi.DAL
{
    public class BabuDbContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public BabuDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>(b =>
            {
                b.HasKey(b => b.Code);
                b.HasIndex(b => b.Name).IsUnique();
                b.Property(b => b.Code).IsFixedLength(true).HasMaxLength(2);
                b.Property(b => b.Name).IsRequired().HasMaxLength(32);
                b.Property(b=>b.Icon).HasMaxLength(120);
                b.HasData(new Language
                {
                    Code="az",
                    Name="Azərbaycan",
                    Icon= "https://cdn-icons-png.flaticon.com/512/330/330544.png"


                });


            });
            base.OnModelCreating(modelBuilder);
        }


    }
}
