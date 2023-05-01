using GondorCars.Domain.Entities.Car;
using GondorCars.Domain.Entities.Owner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GondorCars.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
             :base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<OrganizationOwners> OrganizationOwners { get; set; }

        public DbSet<PersonOwners> PersonEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PCN8TME;Database=GONDOR_CARS;Trusted_Connection=True;");
        }



        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataRegister") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataRegister").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataRegister").IsModified = false;
            }
            return base.SaveChanges();
        }
    }
}