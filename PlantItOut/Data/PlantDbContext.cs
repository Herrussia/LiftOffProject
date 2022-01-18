﻿using Microsoft.EntityFrameworkCore;
using PlantItOut.Models;

namespace PlantItOut.Data
{
    public class PlantDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PlantTag> PlantTags { get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }

        public PlantDbContext(DbContextOptions<PlantDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlantTag>()
                .HasKey(p => new { p.PlantId, p.TagId });
        }

    }
}
