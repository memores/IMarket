using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using IMarket.Model.ModelFirst;
using Microsoft.EntityFrameworkCore.Internal;

namespace IMarket.Model {
    public class Context : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IMarketDb;Integrated Security = True;")
                .EnableDetailedErrors();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
