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

        public DbSet<TaskType> Types { get; set; }
        public DbSet<TaskTodo> Tasks { get; set; }
        public DbSet<TaskCollection> TaskCollections { get; set; }

        public TodoDbContext(string connectionString)
        {

            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
