using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Context : DbContext
    {
        public DbSet<RickandMortyEntity> RickandMorty { get; set; }
        public DbSet<RickEntity> Ricks { get; set; }
        public DbSet<MortyEntity> Morty { get; set; }
        public DbSet<RickHistoricEntity> RickHistorics { get; set; }
        public DbSet<NavigationEntity> Navigations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RickandMortyConfiguration());
            modelBuilder.ApplyConfiguration(new RickConfiguration());
            modelBuilder.ApplyConfiguration(new MortyConfiguration());
            modelBuilder.ApplyConfiguration(new RickHistoricConfiguration());
            modelBuilder.ApplyConfiguration(new NavigationConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\RickLocalizationDB;Database=RickLocalizationDB;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}