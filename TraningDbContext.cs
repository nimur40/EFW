using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class TraningDbContext : DbContext
    {
        private readonly string _connectionstring;
        private readonly string _assemblyName;
        public TraningDbContext()
        {
            _connectionstring = "Server=NIMUR-IT;Database=EFW;User Id=sa;Password=123;Trusted_Connection=True;TrustServerCertificate=True";
            _assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionstring, m => m.MigrationsAssembly(_assemblyName));
            }
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseOne> CoursesOne {  get; set; }
    }
}

