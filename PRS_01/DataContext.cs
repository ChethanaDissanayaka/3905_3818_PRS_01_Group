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
            //optionsBuilder.UseSqlite("Data Source = UserData.db");
            //optionsBuilder.UseSqlite("Data Source = PatientData.db");
        }
        public DbSet< User> Users { get; set; }
        public DbSet< Patient> Patients { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
//public class DataBaseContext : DbContext
//{
//    public readonly string path = "C:\\Users\\IPK COMPUTER\\Documents\\GUI_Codes\\WPF_Lecture_12\\Student_db01.db";

//    protected override void OnConfiguring(
//        DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlite($"Data Source={path}");
//    }
//    public DbSet<Student> Students { get; set; }
//    public DbSet<Module> Modules { get; set; }
//    public DbSet<Teacher> Teachers { get; set; }
//    public DbSet<Result> Results { get; set; }

