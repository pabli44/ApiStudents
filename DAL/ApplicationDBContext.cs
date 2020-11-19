using ApiStudents.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiStudents.DAL
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Student> Student { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
