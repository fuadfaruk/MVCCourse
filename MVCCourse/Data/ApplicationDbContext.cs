using Microsoft.EntityFrameworkCore;
using MVCCourse.Models;

namespace MVCCourse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
