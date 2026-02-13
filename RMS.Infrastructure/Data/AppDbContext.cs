using RMS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SqlServer;


namespace RMS.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;" +
                    "Database=RMSDb;" +
                    "Trusted_Connection=True;");
            }
        }

        public DbSet<Equipment> Equipments { get; set; }
    }
}
