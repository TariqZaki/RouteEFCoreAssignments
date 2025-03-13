using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RouteEFCore.Entities;

namespace RouteEFCore.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = DESKTOP-1C0NTJO; Database = ITIDataBase; Trusted_Connection = True ; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
        public  DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Instructor_Course> Instructor_Courses { get; set; }
    }
}
