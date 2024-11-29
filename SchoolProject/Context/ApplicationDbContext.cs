using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;

namespace SchoolProject.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
        {
        }




        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }




         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
        }


    }
}
