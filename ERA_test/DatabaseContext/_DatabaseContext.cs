using ERA_test.Configurations;
using ERA_test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.DatabaseContext
{
    public class _DatabaseContext:DbContext
    {
        public _DatabaseContext(DbContextOptions<_DatabaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaTypeConfiguration());
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaCoordinates> AreaCoordinates { get; set; }
        public DbSet<AreaLimits> AreaLimits { get; set; }
        public DbSet<AreaType> AreaType { get; set; }
        public DbSet<Regulations> Regulations { get; set; }
        public DbSet<AreaRegulations> AreaRegulations { get; set; }



    }
}
