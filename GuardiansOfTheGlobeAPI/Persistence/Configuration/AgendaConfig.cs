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
    public class AgendaConfig : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agendas");
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.IdHeroe).IsRequired();
            builder.Property(x => x.Fecha).IsRequired();   
            builder.Property(x => x.Actividad).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedBy).HasMaxLength(80);
            builder.Property(x => x.LastModifiedBy).HasMaxLength(80);

        }
    }
}
