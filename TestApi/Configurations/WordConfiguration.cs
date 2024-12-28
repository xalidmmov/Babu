using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApi.Entities;

namespace TestApi.Configurations
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        void IEntityTypeConfiguration<Word>.Configure(EntityTypeBuilder<Word> builder)
        {
            builder.Property(x => x.Text).IsRequired().HasMaxLength(32);
            builder.HasOne(x => x.Language).WithMany(x => x.Words).HasForeignKey(x => x.LangCode);
            builder.HasMany(x => x.BannedWords).WithOne(x => x.Word).HasForeignKey(x => x.WordId);
        }
    }
}
