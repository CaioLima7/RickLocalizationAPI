using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Configuration
{
    class NavigationConfiguration : IEntityTypeConfiguration<NavigationEntity>
    {
        public void Configure(EntityTypeBuilder<NavigationEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Date)
                .IsRequired();

            builder.Property(p => p.TravelName)
                .IsRequired();
        }
    }
}
