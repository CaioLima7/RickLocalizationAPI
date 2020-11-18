using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Configuration
{
    class RickConfiguration : IEntityTypeConfiguration<RickEntity>
    {
        public void Configure(EntityTypeBuilder<RickEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired();

            builder.Property(p => p.Dimension)
                .IsRequired();
        }
    }
}
