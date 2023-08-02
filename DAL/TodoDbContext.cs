using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TodoDbContext : DbContext
    {
        public string ConnectionString { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCollection> ItemCollections { get; set; }
        public DbSet<ItemsTypesJoin> ItemsTypesJoins { get; set; }

        public TodoDbContext(string connectionString)
        {

            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Item>()
                .HasMany(it => it.ItemTypes)
                .WithMany(it => it.Items)
                .UsingEntity<ItemsTypesJoin>();
            
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}
