using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using BizMan.Models;

namespace BizMan.DataBase
{
    /// <summary>
    /// The following code defines the AppDbContext class, which is a part of the BizMan.DataBase namespace.
    /// 
    /// </summary>
    public class AppDbContext : DbContext // DbContext is a class provided by Entity Framework Core that represents a session with the database.
    // DbContext provides methods to query and save data to the database.
    {
        public DbSet<Employee> Employees { get; set; } // DbSet represents a collection of entities that can be queried from the database.

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlite("Data Source=bizman.db");     // BizMan database has been created in project folder
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.ID)
                .ValueGeneratedNever(); // that line disabled ID auto generation
        }


    }
}
