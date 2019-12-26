using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    class ctx :DbContext

    {
        public DbSet<Person> Personen { get; set; }
        public DbSet <Event> Events { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonenEvent>()
                .HasKey(t => new { t.PersonId, t.EventId });

            modelBuilder.Entity<PersonenEvent>()
                .HasOne(p => p.Person)
                .WithMany(p => p.PersonenEvents)
                .HasForeignKey(p => p.PersonId)
                ;
            modelBuilder.Entity<PersonenEvent>()
                .HasOne(e => e.Event)
                .WithMany(e => e.PersonenEvents)
                .HasForeignKey(e => e.EventId)
                ;
        }
    }
}
