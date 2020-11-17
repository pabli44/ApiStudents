using ApiStudents.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiStudents.DAL
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Students> Student { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
