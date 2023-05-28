using Microsoft.EntityFrameworkCore;
using Application.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using System.Reflection;

namespace Persistence.Contexts
{
        public class ApplicationDbContext : DbContext
        {
            private readonly IDateTimeService _dateTime;
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTimeService dateTime) : base(options)
            {
                ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                _dateTime = dateTime;
            }
            public DbSet<Heroe> Heroes { get; set; }
            public DbSet<Patrocinador> Patrocinadores { get; set; }
            public DbSet<Agenda> Agendas { get; set; }
            public DbSet<Pelea> Peleas { get; set; }
            public DbSet<Villano> Villanos { get; set; }


            public override Task<int> SaveChangesAsync(CancellationToken cancellationTaken = new CancellationToken())
            {
                foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.Created = _dateTime.NowUtc;
                            break;
                        case EntityState.Modified:
                            entry.Entity.LastModified = _dateTime.NowUtc;
                            break;
                    }
                }
                return base.SaveChangesAsync(cancellationTaken);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
        }
    }

