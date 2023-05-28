using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class PeleaConfig : IEntityTypeConfiguration<Pelea>
    {
        public void Configure(EntityTypeBuilder<Pelea> builder)
        {
            builder.ToTable("Peleas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdHeroe).IsRequired();
            builder.Property(x => x.IdVillano).IsRequired();
            builder.Property(x => x.Victoria_heroes).IsRequired();
            builder.Property(x => x.Victoria_villanos).IsRequired();
            builder.Property(x => x.CreatedBy).HasMaxLength(80);
            builder.Property(x => x.LastModifiedBy).HasMaxLength(80);
        }
    }
}
