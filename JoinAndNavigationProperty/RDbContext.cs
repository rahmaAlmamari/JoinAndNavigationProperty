using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JoinAndNavigationProperty
{
    public class RDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-IUF9HHIH;Initial Catalog=StoreDB;Integrated Security=True;TrustServerCertificate=True");
        }

    }
}
