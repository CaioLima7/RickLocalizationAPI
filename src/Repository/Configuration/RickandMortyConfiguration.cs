using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Configuration
{
    class RickandMortyConfiguration : IEntityTypeConfiguration<RickandMortyEntity>
    {
        public void Configure(EntityTypeBuilder<RickandMortyEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Rick)
                .IsRequired();

            builder.Property(p => p.Morty)
                .IsRequired();

            builder.Property(p => p.ImgFileRick)
            .IsRequired();

            builder.Property(p => p.ImgFileMorty)
            .IsRequired();
        }
    }
}
