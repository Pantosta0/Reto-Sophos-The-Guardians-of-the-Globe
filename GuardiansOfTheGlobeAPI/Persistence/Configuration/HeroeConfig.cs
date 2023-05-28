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
    public class HeroeConfig : IEntityTypeConfiguration<Heroe>
    {
        public void Configure(EntityTypeBuilder<Heroe> builder)
        {
            builder.ToTable("Heroes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NombreSuper)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.Nombre)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.Edad)
                .IsRequired();

            builder.Property(x => x.Sexo)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.GrupoEdad)
                .HasMaxLength(80);

            builder.Property(x => x.Habilidades)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Debilidades)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.RelacionesPersonales)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.CreatedBy)
                .HasMaxLength(80);

            builder.Property(x => x.LastModifiedBy)
                .HasMaxLength(80);


        }
    }
}
