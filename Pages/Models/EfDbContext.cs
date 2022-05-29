
using Microsoft.EntityFrameworkCore;

namespace melihozaslanodev2_2.Pages.Models
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base (options)
        {

        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
