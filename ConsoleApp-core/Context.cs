using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    public class Context :DbContext

    {
        public DbSet<Person> Personen { get; set; }
        public DbSet <Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=.\BTPlan.db");        }
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
