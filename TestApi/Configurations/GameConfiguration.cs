﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TestApi.Entities;

namespace TestApi.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        void IEntityTypeConfiguration<Game>.Configure(EntityTypeBuilder<Game> builder)
        {

            builder.HasOne(x => x.Language).WithMany(x => x.Games).HasForeignKey(x => x.LangCode);


        }
    }
}
