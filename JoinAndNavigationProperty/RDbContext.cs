using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty
{
    public class RDbContext : DbContext
    {
        //to override the OnModelCreating method to configure the relationships ...
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-IUF9HHIH;Initial Catalog=StoreDB_R;Integrated Security=True;TrustServerCertificate=True");
        }
        //to define the DbSet properties for each entity ...
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
