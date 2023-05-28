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
    public class VillanoConfig : IEntityTypeConfiguration<Villano>
    {
        public void Configure(EntityTypeBuilder<Villano> builder)
        {
            builder.ToTable("Villanos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NombreVillano)
                .HasMaxLength(80)
                .IsRequired();
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Edad).IsRequired();
                builder.Property(x => x.Origen).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Habilidades).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Debilidades).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Poder).HasMaxLength(80).IsRequired();
            builder.Property(x => x.CreatedBy).HasMaxLength(80);
            builder.Property(x => x.LastModifiedBy).HasMaxLength(80);


        }
    }
}
