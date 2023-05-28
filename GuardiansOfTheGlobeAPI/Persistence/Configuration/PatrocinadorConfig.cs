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
    public class PatrocinadorConfig : IEntityTypeConfiguration<Patrocinador>
    {
        public void Configure(EntityTypeBuilder<Patrocinador> builder)
        {
            builder.ToTable("Patrocinadores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdHeroe).IsRequired();
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.Property(x => x.OrigenDinero).HasMaxLength(80).IsRequired();
            builder.Property(x => x.CreatedBy).HasMaxLength(80);
            builder.Property(x => x.LastModifiedBy).HasMaxLength(80);
            
            
        }
    }
}
