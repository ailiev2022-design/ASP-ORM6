using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using StudentSystemApp.Data.Domain;

namespace StudentSystemApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Courses> Courses { get; set; } = null!;
        public DbSet<Resources> Resources { get; set; } = null!;
        public DbSet<Students> Students { get; set; } = null!;
        public DbSet<StudentCourses> StudentCourses { get; set; } = null!;
        public DbSet<HomeworkSubmissions> HomeworkSubmissions { get; set; } = null!;
    }
}
