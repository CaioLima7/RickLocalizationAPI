using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Configuration
{
    class RickHistoricConfiguration : IEntityTypeConfiguration<RickHistoricEntity>
    {
        public void Configure(EntityTypeBuilder<RickHistoricEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.RickId)
                .IsRequired();

            builder.Property(p => p.Navigation)
                .IsRequired();
        }
    }
}
