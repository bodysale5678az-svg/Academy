using Academy.Models;
using Microsoft.EntityFrameworkCore;


namespace Academy
{
    public class AcademyDbContext:DbContext
    {
        public AcademyDbContext(DbContextOptions<AcademyDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
