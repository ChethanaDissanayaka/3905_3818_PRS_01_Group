using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRS_01
{
    public class DataContext:DbContext
    {
        public readonly string path = "C:\\Users\\IPK COMPUTER\\Documents\\GUI_PROJECTS\\PRS_01\\Data.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={path}");
          
        }
        public DbSet< User> Users { get; set; }
        public DbSet< Patient> Patients { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}


