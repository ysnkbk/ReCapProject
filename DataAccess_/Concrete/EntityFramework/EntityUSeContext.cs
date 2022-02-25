using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entitites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntityUSeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EntityUSe;Trusted_Connection=true");
        }
        public DbSet<Car> Cars  { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }

        
    }
}
