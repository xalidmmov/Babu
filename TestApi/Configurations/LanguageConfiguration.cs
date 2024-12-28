using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TestApi.Entities;

namespace TestApi.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        void IEntityTypeConfiguration<Language>.Configure(EntityTypeBuilder<Language> builder)
        {

            builder.HasKey(b => b.Code);
            builder.HasIndex(b => b.Name).IsUnique();
            builder.Property(b => b.Code).IsFixedLength(true).HasMaxLength(2);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(32);
            builder.Property(b => b.Icon).HasMaxLength(120);
           
        }

    }
}
